using System;
using System.ComponentModel;
using System.Linq;

namespace InventoryApp
{
    [Serializable]
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        public int ProductID { get; set;  }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int  InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product() { }
        public Product(int pId, string name, decimal price, int inStock, int min, int max)
        {
            ProductID = pId;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        public Product(int pId, string name, decimal price, int inStock, int min, int max, BindingList<Part> parts)
        {
            ProductID = pId;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            AssociatedParts = parts; 
        }

        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int partID)
        {
            Part part = AssociatedParts.SingleOrDefault(part => part.PartID == partID);
            return AssociatedParts.Remove(part);
        }

        public Part lookupAssociatedPart(int partID)
        {
            return AssociatedParts.FirstOrDefault(p => p.PartID == partID);
        }

    }
}
