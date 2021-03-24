using System.ComponentModel;
using System.Linq;

namespace InventoryApp
{
    static class Inventory
    {
        private static BindingList<Product> products = new BindingList<Product>();
        public static BindingList<Product> Products { get { return products; } set { products = value; } }

        private static BindingList<Part> parts = new BindingList<Part>();
        public static BindingList<Part> Parts { get { return parts; } set { parts = value; } }

        // Product

        public static void addProduct(Product newProduct)
        {
            Products.Add(newProduct);
        }

        public static bool removeProduct(int productID)
        {
            Product removeProduct = Products.SingleOrDefault(p => p.ProductID == productID);
            return Products.Remove(removeProduct);
        }

        public static Product lookupProduct(int productId)
        {
            return Products.FirstOrDefault(p => p.ProductID == productId);
        }

        public static void updateProduct(int productId, Product updatedProduct)
        {
            removeProduct(productId);
            addProduct(updatedProduct);
        }

        // Part
        public static void addPart(Part part)
        {
            Parts.Add(part);
        }

        public static void deletePart(Part part)
        {
            Parts.Remove(part);
        }

        public static Part lookupPart(int partID)
        {
            return Parts.FirstOrDefault(p => p.PartID == partID);
        }

        public static void updatePart(int partID, Part updatedPart)
        {
            Part part = Parts.FirstOrDefault(p => p.PartID == partID);
            deletePart(part);
            addPart(updatedPart);
        }
    }
}
