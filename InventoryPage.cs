using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class InventoryPage : Form
    {
        public void formatProductDGV(DataGridView d)
        {
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.RowHeadersVisible = true;

            d.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.DataPropertyName = "ProductID";
            col1.HeaderText = "Product ID";
            d.Columns.Add(col1);

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.DataPropertyName = "Name";
            col2.HeaderText = "Name";
            d.Columns.Add(col2);

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.DataPropertyName = "InStock";
            col4.HeaderText = "Inventory";
            d.Columns.Add(col4);

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.DataPropertyName = "Price";
            col3.HeaderText = "Price";
            d.Columns.Add(col3);

            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col5.DataPropertyName = "Min";
            col5.HeaderText = "Min";
            d.Columns.Add(col5);

            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
            col6.DataPropertyName = "Max";
            col6.HeaderText = "Max";
            d.Columns.Add(col6);
        }

        public void formatPartDGV(DataGridView d)
        {
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.RowHeadersVisible = true;

            d.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.DataPropertyName = "PartID";
            col1.HeaderText = "Part ID";
            d.Columns.Add(col1);

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.DataPropertyName = "Name";
            col2.HeaderText = "Name";
            d.Columns.Add(col2);

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.DataPropertyName = "InStock";
            col3.HeaderText = "Inventory";
            d.Columns.Add(col3);

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.DataPropertyName = "Price";
            col4.HeaderText = "Price";
            d.Columns.Add(col4);

            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col5.DataPropertyName = "Min";
            col5.HeaderText = "Min";
            d.Columns.Add(col5);

            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
            col6.DataPropertyName = "Max";
            col6.HeaderText = "Max";
            d.Columns.Add(col6);

            d.Sort(col1, System.ComponentModel.ListSortDirection.Ascending);
        }

        private void build()
        {
            Inventory.Products.Clear();
            Inventory.Products.Add(new Product(1, "Screw", (decimal)2.33, 5, 2, 5));
            Inventory.Products.Add(new Product(2, "Nail", (decimal)4.33, 6, 3, 6));
            Inventory.Products.Add(new Product(3, "Hammer", (decimal)5.33, 7, 4, 7));

            Inventory.Parts.Clear();
            Inventory.Parts.Add(new Inhouse(1, "screw", (decimal).34, 44, 10, 88, 2));
            Inventory.Parts.Add(new Inhouse(2, "nut", (decimal).14, 15, 10, 88, 3));
            Inventory.Parts.Add(new Inhouse(3, "bolt", (decimal).05, 14, 10, 88, 4));
        }

        public void display()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = Inventory.Products;
            dataGridView1.ClearSelection();

            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = Inventory.Parts;
            dataGridView2.ClearSelection();
        }

        public InventoryPage()
        {
            InitializeComponent();
            build();
            formatProductDGV(dataGridView1);
            formatPartDGV(dataGridView2);
            display();
        }


        private void buttonClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button was clicked.");
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Howdy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PartPage part = new PartPage();
            part.Tag = this;
            part.Show(this);
            Hide();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            ProductPage productPage = new ProductPage();
            productPage.Tag = this;
            productPage.Show(this);
            Hide();

        }

        private void ModifyPart_buton_Click(object sender, EventArgs e)
        {
            if(dataGridView2.SelectedRows.Count > 0) {
                PartPage partp;

                var part = dataGridView2.SelectedRows[0].DataBoundItem;
                if (part is Outsourced)
                {
                    partp = new PartPage((Outsourced)part);
                    partp.Tag = this;
                    partp.Show(this);
                    Hide();
                    return;
                }

                partp = new PartPage((Inhouse)part);
                partp.Tag = this;
                partp.Show(this);
                Hide();
                return;
            }
        }

        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                Part part = dataGridView2.SelectedRows[0].DataBoundItem as Part;

                string message = string.Format("Are you sure you would like to delete {0}?", part.Name);
                string caption = "Delete Part";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Inventory.Parts.Remove(part);
                }
            }
        }

        private void buttonPartsSearch_Click(object sender, EventArgs e)
        {
            BindingList<Part> TempMatchingList = new BindingList<Part>();

            bool found = false;
            if (textBoxPartsSearch.Text != "")
            {
                for (int i = 0; i < InventoryApp.Inventory.Parts.Count; i++)
                {
                    if (InventoryApp.Inventory.Parts[i].Name.ToUpper().Contains(textBoxPartsSearch.Text.ToUpper()))
                    {
                        TempMatchingList.Add(InventoryApp.Inventory.Parts[i]);
                        found = true;
                    }
                }

                if (found)
                {
                    dataGridView2.DataSource = TempMatchingList;
                }
            }

            if (!found)
            {
                dataGridView2.DataSource = InventoryApp.Inventory.Parts;
                MessageBox.Show("No parts found.");
            }
        }

        private void buttonProductsSearch_Click(object sender, EventArgs e)
        {
            BindingList<Product> TempMatchingList = new BindingList<Product>();

            bool found = false;
            if (textBoxProductsSearch.Text != "")
            {
                for (int i = 0; i < InventoryApp.Inventory.Products.Count; i++)
                {
                    if (InventoryApp.Inventory.Products[i].Name.ToUpper().Contains(textBoxProductsSearch.Text.ToUpper()))
                    {
                        TempMatchingList.Add(InventoryApp.Inventory.Products[i]);
                        found = true;
                    }
                }

                if (found)
                {
                    dataGridView1.DataSource = TempMatchingList;
                }
            }

            if (!found)
            {
                dataGridView1.DataSource = InventoryApp.Inventory.Products;
                MessageBox.Show("No parts found.");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModifyProductButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Product product = dataGridView1.SelectedRows[0].DataBoundItem as Product;
                ProductPage productPage = new ProductPage(product);

                productPage.Tag = this;
                productPage.Show(this);
                Hide();
                return;
            }
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Product product = dataGridView1.SelectedRows[0].DataBoundItem as Product;

                if (product.AssociatedParts.Count() > 0)
                {
                    MessageBox.Show("Cannot delete product with associated parts. Remove parts from product first.");
                    return;
                }

                string message = string.Format("Are you sure you would like to delete {0}?", product.Name);
                string caption = "Delete Product";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    InventoryApp.Inventory.Products.Remove(product);
                }
            }
        }
    }
}
