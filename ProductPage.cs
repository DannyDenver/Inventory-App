using System;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class ProductPage : Form
    {
        private Product modifyingProduct;
        private Product newProduct;

        public ProductPage()
        {
            InitializeComponent();
            newProduct = new Product();
            AssociatedPartsDataGrid.DataSource = newProduct.AssociatedParts;
            AllCandidatePartsDataGrid.DataSource = InventoryApp.Inventory.Parts;
            AssociatedPartsDataGrid.AutoGenerateColumns = false;
            AllCandidatePartsDataGrid.AutoGenerateColumns = false;

            AssociatedPartsDataGrid.ClearSelection();
            AllCandidatePartsDataGrid.ClearSelection();
        }

        public ProductPage(Product product)
        {
            InitializeComponent();
            modifyingProduct = product;

            AllCandidatePartsDataGrid.DataSource = InventoryApp.Inventory.Parts;
            AssociatedPartsDataGrid.DataSource = modifyingProduct.AssociatedParts;

            PageLabel.Text = "Modify Part";

            ProductID.Text = product.ProductID.ToString();
            ProductID.Enabled = false;
            ProductName.Text = product.Name;
            Inventory.Text = product.InStock.ToString();
            Max.Text = product.Max.ToString();
            Min.Text = product.Min.ToString();
            Price.Text = product.Price.ToString();
        }


        private void productCancel_button_Click(object sender, EventArgs e)
        {
            var inventory = (InventoryPage)Tag;
            inventory.Show();
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (modifyingProduct != null)
            {
                foreach(Product p in InventoryApp.Inventory.Products)
                {
                   if(p.ProductID == modifyingProduct.ProductID)
                    {
                        p.Name = ProductName.Text;
                        p.Price = decimal.Parse(Price.Text);
                        p.InStock = int.Parse(Inventory.Text);
                        p.Min = int.Parse(Min.Text);
                        p.Max = int.Parse(Max.Text);
                        p.AssociatedParts = modifyingProduct.AssociatedParts;
                        CloseForm();
                        return;
                    }
                }

                return;
            }

            newProduct.ProductID = int.Parse(ProductID.Text);
            newProduct.Name = ProductName.Text;
            newProduct.Price = decimal.Parse(Price.Text);
            newProduct.InStock = int.Parse(Inventory.Text);
            newProduct.Min = int.Parse(Min.Text);
            newProduct.Max = int.Parse(Max.Text);

            InventoryApp.Inventory.Products.Add(newProduct);

            CloseForm();
        }

        private void CloseForm()
        {
            var inventory = (InventoryPage)Tag;
            inventory.Show();
            Close();
        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {
            Part part = AllCandidatePartsDataGrid.SelectedRows[0].DataBoundItem as Part;
            if (modifyingProduct != null)
            {
                modifyingProduct.AssociatedParts.Add(part);
                return;
            }

            newProduct.AssociatedParts.Add(part);
        }


        private void DeleteProductAssociationButton_Click(object sender, EventArgs e)
        {
            if (AssociatedPartsDataGrid.SelectedRows[0].DataBoundItem != null)
            {
                Part part = AssociatedPartsDataGrid.SelectedRows[0].DataBoundItem as Part;

                modifyingProduct.AssociatedParts.Remove(part);
                //AssociatedPartsDataGrid.DataSource = modifyingProduct.AssociatedParts;
            }
        }
    }
}
