using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryApp
{
    [Serializable]
    public abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    
        protected Part(int partID, string name, decimal price, int instock, int min, int max)
        {
            this.PartID = partID;
            this.Name = name;
            this.Price = price;
            this.InStock = instock;
            this.Min = min;
            this.Max = max;
        }
    }
}
