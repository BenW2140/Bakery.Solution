namespace Bakery.Models
{
  public class Pastry
  {
    public float Price {get;}
    public int Quantity {get; set;}
    public float TotalPrice {get; set;}
    public Pastry(int quantity)
    {
      Price = 2;
      Quantity = quantity;
      TotalPrice = Price * Quantity;
    }

    public void PastryDeal()
    {
      if (Quantity % 3 == 0)
      {
        TotalPrice -= 1 * (Quantity / 3);
      }
    }
  }
}