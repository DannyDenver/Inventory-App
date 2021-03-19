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

        // Product

        public void addProduct(Product newProduct)
        {
            Products.Add(newProduct);
        }

        public bool removeProduct(int productID)
        {
            Product removeProduct = Products.SingleOrDefault(p => p.ProductID == productID);
            return Products.Remove(removeProduct);
        }

        public Product lookupProduct(int productId)
        {
            return Products.FirstOrDefault(p => p.ProductID == productId);
        }

        public void updateProduct(int productId, Product product)
        {

        }

        // Part
        public void addPart(Part part)
        {
            Parts.Add(part);
        }

        public void deletePart(Part part)
        {
            Parts.Remove(part);
        }

        public Part lookupPart(int partID)
        {
            return Parts.FirstOrDefault(p => p.PartID == partID);
        }

        public void updatePart(int partID, Part updatedPart)
        {
           
                
        }
    }
}
