using System;

namespace InventoryApp
{
    [Serializable]
    public class Outsourced : Part
    {
        public string CompanyName { get; set; }
        public Outsourced(int partID, string name, decimal price, int inventory, int min, int max, string companyName) : base(partID, name, price, inventory, min, max)
        {
            CompanyName = companyName;
        }
    }
}
