using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> {};
    public string Type { get; set; }
    public int Quantity { get; set; }
    public string Date { get; set; }
    public int Id { get; }
    public Order(string type, int quantity, string date)
    {
      Type = type;
      Quantity = quantity;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
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
    public static List<Order> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Order Find(int searchId)
    {
      for ( int i = 0; i < _instances.Count; i++)
      {
        if (searchId == _instances[i].Id)
        {
          return _instances[i];
        }
      }
      return _instances[searchId - 1];
    }
  }
}