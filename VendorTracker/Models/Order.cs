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
  }
}