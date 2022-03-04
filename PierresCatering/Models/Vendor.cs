using System.Collections.Generic;

namespace Bakery.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }

    public int Id { get; }
    private List<Vendor> _vendorList = new List<Vendor> { };

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _vendorList.Add(this);
      Id = _vendorList.Count;
    }

    public static List<Vendor> GetAll()
    {
      string name = "Fail name";
      string description = "Fail description";
      Vendor failVendor = new Vendor(name, description);
      List<Vendor> failList = new List<Vendor>{ failVendor};

      return failList;
    }

  }
}