using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace InventoryApp
{
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

        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int partId)
        {
            Part part = AssociatedParts.SingleOrDefault(part => part.PartID == partId);
            return AssociatedParts.Remove(part);
        }

        public Part lookupAssociatedPart(int partId)
        {
            return AssociatedParts.FirstOrDefault(p => p.PartID == partId);
        }

    }
}
