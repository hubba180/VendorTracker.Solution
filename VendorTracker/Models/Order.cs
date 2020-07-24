namespace VendorTracker.Models
{
  public class Order
  {
    public string Type { get; set; }
    public int Quantity { get; set; }
    public Order(string type, int quantity)
    {
      Type = type;
      Quantity = quantity;
    }
    public int Price()
    {
      if (Type == "Bread")
      {
        int normalPrice = Quantity * 5;
        int Remainder = (Quantity / 3) * 5;
        return normalPrice - Remainder;
      } else if (Type == "Pastry")
      {
        int AdjustedPrice = 0;
        if (Quantity > 2) 
        {
        int Buy3Promo = (Quantity / 3) * 5;
        int Buy2Promo = (Quantity % 3) * 2; 
        AdjustedPrice = Buy3Promo + Buy2Promo;
        } 
        else if (Quantity <= 2)
        {
        int Buy2Promo = Quantity * 2; 
        AdjustedPrice = Buy2Promo; 
        }
        return AdjustedPrice;
      } else{
        return 0;
      }
    }
  }
}