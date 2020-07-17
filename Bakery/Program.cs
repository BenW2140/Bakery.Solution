using System;
using Bakery.Models;

public class Program
{
  public static void Main()
  {
    WelcomeMessage();
    StartOrder();
    Console.WriteLine("Thank you for visiting Happy Little Bakery! Please come again!");
  }

  public static void WelcomeMessage()
  {
    Console.WriteLine("-------------------------------------------------------------------------");
    Console.WriteLine("Hello! Welcome to Happy Little Bakery!");
    Console.WriteLine("Bread: $5"); 
    Console.WriteLine("Pastries: $2");
    Console.WriteLine("Deals: Buy two loaves get one free, Buy two pastries get the third $1 off");
    Console.WriteLine("-------------------------------------------------------------------------");
  }

  public static void StartOrder()
  {
    Console.WriteLine("Would you like to buy something? (y or n)");
    string userInput = Console.ReadLine();
    userInput.ToLower();
    if (userInput == "y")
    {
      ReadUserInput();
    }
  }

  public static void ReadUserInput()
  {
    Console.WriteLine("What would you like to buy? Enter amount of bread then pastries:");
    string bread = Console.ReadLine();
    string pastries = Console.ReadLine();
    int numBread = 0;
    int numPastries = 0;
    ValidateUserInput(bread, pastries, numBread, numPastries);
  }

  public static void ValidateUserInput(string bread, string pastries, int numBread, int numPastries)
  {
    while (String.IsNullOrEmpty(bread) || String.IsNullOrEmpty(pastries))
    {
      Console.WriteLine("If you changed your mind about buying something enter 0, otherwise please enter a positive integer:");
      bread = Console.ReadLine();
      pastries = Console.ReadLine();
      numBread = int.Parse(bread);
      numPastries = int.Parse(pastries);
      if (numBread < 0 || numPastries < 0)
      {
        bread = "";
      }
    }
    CreateOrder(numPastries, numPastries);
  }

  public static void CreateOrder(int numBread, int numPastries)
  {
    Bread breadOrder = new Bread(numBread);
    Pastry pastryOrder = new Pastry(numPastries);
    breadOrder.BreadDeal();
    pastryOrder.PastryDeal();
    DisplayTotal(breadOrder, pastryOrder);
  }

  public static void DisplayTotal(Bread breadOrder, Pastry pastryOrder)
  {
    Console.WriteLine("You bought " + breadOrder.Quantity + " loaves of bread for $" + 
    breadOrder.TotalPrice + " and " + pastryOrder.Quantity + " pastries for $" + pastryOrder.TotalPrice);
    Console.WriteLine("Your total is $" + (breadOrder.TotalPrice + pastryOrder.TotalPrice));
  }
}