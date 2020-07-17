using System;
using Bakery.Models;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Hello! Welcome to Happy Little Bakery!");
    Console.WriteLine("Bread: $5"); 
    Console.WriteLine("Pastries: $2");
    Console.WriteLine("Deals: Buy two loaves get one free, Buy two pastries get the third $1 off");
    Console.WriteLine("Would you like to buy something? (y or n)");
    string userInput = Console.ReadLine();
    userInput.ToLower();
    if (userInput == "y")
    {
      Console.WriteLine("What would you like to buy? Enter amount of bread then pastries:");
      int bread = int.Parse(Console.ReadLine());
      int pastries = int.Parse(Console.ReadLine());
      Bread breadOrder = new Bread(bread);
      Pastry pastryOrder = new Pastry(pastries);
      breadOrder.BreadDeal();
      pastryOrder.PastryDeal();
      Console.WriteLine("You bought " + breadOrder.Quantity + " loaves of bread for $" + 
      breadOrder.TotalPrice + " and " + pastryOrder.Quantity + " pastries for $" + pastryOrder.TotalPrice);
      Console.WriteLine("Your total is $" + (breadOrder.TotalPrice + pastryOrder.TotalPrice));
    }
    Console.WriteLine("Thank you for visiting Happy Little Bakery! Please come again!");
  }
}