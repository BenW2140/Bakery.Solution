namespace Bakery.Models
{
  public class Bread
  {
    public float Price {get;}
    public int Quantity {get; set;}
    public float TotalPrice {get; set;}

    public Bread(int quantity)
    {
      Price = 5;
      Quantity = quantity;
      TotalPrice = Price * Quantity;
    }

    public void BreadDeal()
    {
      if (Quantity % 3 == 0)
      {
         TotalPrice -= Price * (Quantity / 3);
      }
    }
  }
}