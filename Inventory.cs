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

        public static void updateProduct(int productId, Product product)
        {

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

            part.InStock = updatedPart.InStock;
            part.Name = updatedPart.Name;
            part.Price = updatedPart.Price;
            part.Min = updatedPart.Min;
            part.Max = updatedPart.Max;
            part.InStock = updatedPart.InStock;

            if (updatedPart is Inhouse)
            {
                var inhouseUpdatedPart = updatedPart as Inhouse;

                // changes Outsourced => Inhouse
                if (part is Outsourced)
                {
                    deletePart(part);
                    addPart(inhouseUpdatedPart);
                }else
                {
                    // stays inhouse
                    var inhouseP = part as Inhouse;
                    inhouseP.InStock = inhouseUpdatedPart.InStock;
                    inhouseP.MachineID = inhouseUpdatedPart.MachineID;
                }

            }else
            {
                var outUpdatedPart = updatedPart as Outsourced;

                // changes from Inhouse => Outsourced
                if (part is Inhouse)
                {
                    deletePart(part);
                    addPart(outUpdatedPart);
                }
                else
                {
                    // stays outsourced
                    Outsourced oPart = new Outsourced(part.PartID, part.Name, part.Price, part.InStock, part.Min, part.Max, outUpdatedPart.CompanyName);
                    deletePart(part);
                    addPart(oPart);
                }               
            }
        }
    }
}
