using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }
    public Vendor(string name, string description)
    {
      Name = name; 
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order> {};
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Vendor> GetAll()
    {
      return _instances;
    }
    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
    public static Vendor Find(int searchId)
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