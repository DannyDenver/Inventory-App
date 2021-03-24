using System.ComponentModel;
using System.Linq;

namespace InventoryApp
{
    static class Inventory
    {
        private static BindingList<Product> products = new BindingList<Product>();
        public static BindingList<Product> Products { get { return products; } set { products = value; } }

        private static BindingList<Part> parts = new BindingList<Part>();
        public static BindingList<Part> AllParts { get { return parts; } set { parts = value; } }

        public static void addProduct(Product product)
        {
            Products.Add(product);
        }

        public static bool removeProduct(int productID)
        {
            Product product = Products.FirstOrDefault(p => p.ProductID == productID);
            return Products.Remove(product);
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

        public static void addPart(Part part)
        {
            AllParts.Add(part);
        }

        public static void deletePart(Part part)
        {
            AllParts.Remove(part);
        }

        public static Part lookupPart(int partID)
        {
            return AllParts.FirstOrDefault(p => p.PartID == partID);
        }

        public static void updatePart(int partID, Part updatedPart)
        {
            Part part = AllParts.FirstOrDefault(p => p.PartID == partID);
            deletePart(part);
            addPart(updatedPart);
        }
    }
}
