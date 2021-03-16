using System;
using System.Windows.Forms;
using System.ComponentModel;

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

            PageLabel.Text = "Modify Product";

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
            if (validInputs())
            {
                if (modifyingProduct != null)
                {
                    modifyProduct();
                }else
                {
                    newProduct.ProductID = int.Parse(ProductID.Text);
                    newProduct.Name = ProductName.Text;
                    newProduct.Price = decimal.Parse(Price.Text);
                    newProduct.InStock = int.Parse(Inventory.Text);
                    newProduct.Min = int.Parse(Min.Text);
                    newProduct.Max = int.Parse(Max.Text);

                    InventoryApp.Inventory.Products.Add(newProduct);
                }

                CloseForm();
            };
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
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            BindingList<Part> TempMatchingList = new BindingList<Part>();

            bool found = false;
            if (SearchPartQuery.Text != "")
            {
                for (int i = 0; i < InventoryApp.Inventory.Parts.Count; i++)
                {
                    if (InventoryApp.Inventory.Parts[i].Name.ToUpper().Contains(SearchPartQuery.Text.ToUpper()))
                    {
                        TempMatchingList.Add(InventoryApp.Inventory.Parts[i]);
                        found = true;
                    }
                }

                if (found)
                {
                    AllCandidatePartsDataGrid.DataSource = TempMatchingList;
                }
            }

            if (!found)
            {
                AllCandidatePartsDataGrid.DataSource = InventoryApp.Inventory.Parts;
                MessageBox.Show("No parts found.");
            }
        }

        private void modifyProduct()
        {
            foreach (Product p in InventoryApp.Inventory.Products)
            {
                if (p.ProductID == modifyingProduct.ProductID)
                {
                    p.Name = ProductName.Text;
                    p.Price = decimal.Parse(Price.Text);
                    p.InStock = int.Parse(Inventory.Text);
                    p.Min = int.Parse(Min.Text);
                    p.Max = int.Parse(Max.Text);
                    p.AssociatedParts = modifyingProduct.AssociatedParts;
                    return;
                }
            }
        }

        private bool validInputs()
        {
            try
            {
                if ((int)Min.Value > (int)Max.Value)
                {
                    throw new MinGreaterThenMaxException();
                }

                if (((int)Min.Value > (int)Inventory.Value) || ((int)Max.Value < (int)Inventory.Value))
                {
                    throw new InventoryOutOfRangeException();
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Warning: Machine ID must be an integer.");
                return false;
            }
            catch (MinGreaterThenMaxException ex)
            {
                MessageBox.Show("Warning: Min must be less than Max.");
                return false;
            }
            catch (InventoryOutOfRangeException ex)
            {
                MessageBox.Show("Warning: Inventory must be between Min and Max.");
                return false;
            }

            return true;
        }

        private void CloseForm()
        {
            var inventory = (InventoryPage)Tag;
            inventory.Show();
            Close();
        }
    }
}
