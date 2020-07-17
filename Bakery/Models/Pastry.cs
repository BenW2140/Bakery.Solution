namespace Bakery.Models
{
  public class Pastry
  {
    public float Price {get;}
    public int Quantity {get; set;}
    public Pastry(int quantity)
    {
      Price = 2;
      Quantity = quantity;
    }
  }
}