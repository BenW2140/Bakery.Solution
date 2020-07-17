namespace Bakery.Models
{
  public class Bread
  {
    public float Price {get;}
    public int Quantity {get; set;}
    public float TotalPrice {get;}

    public Bread(int quantity)
    {
      Price = 5;
      Quantity = quantity;
      TotalPrice = Price * Quantity;
    }
  }
}