using System.ComponentModel;
using System.Linq;

namespace InventoryApp
{
    class Inventory
    {
        private static BindingList<Product> products = new BindingList<Product>();
        public static BindingList<Product> Products { get { return products; } set { products = value; } }

        private static BindingList<Part> parts = new BindingList<Part>();
        public static BindingList<Part> Parts { get { return parts; } set { parts = value; } }

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
