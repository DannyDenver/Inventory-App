using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace InventoryApp
{
    class Inventory
    {
        private static BindingList<Product> products = new BindingList<Product>();
        public static BindingList<Product> Products { get { return products; } set { products = value; } }
 
        public static BindingList<Part> AllParts = new BindingList<Part>();

        public void addProduct(Product newProduct)
        {
            Products.Add(newProduct);
        }

        public bool removeProduct(int productID)
        {
            Product removeProduct = Products.SingleOrDefault(p => p.ProductID == productID);
            return Products.Remove(removeProduct);
        }

    }
}
