using System;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class PartPage : Form
    {
        public PartPage()
        {
            InitializeComponent();
        }

        public PartPage(Inhouse part)
        {
            InitializeComponent();
            Name.Text = part.Name;
        }
        public PartPage(Outsourced part)
        {
            InitializeComponent();
            Name.Text = part.Name;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(label6.Text == "Machine ID")
            {
                label6.Text = "Comany Name";
            }else
            {
               label6.Text = "Machine ID";
            }                        
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (label6.Text == "Machine ID")
            {
                InventoryApp.Inventory.Parts.Add(new Inhouse((int)PartID.Value, Name.Text, Price.Value, (int)Inventory.Value, (int)Min.Value, (int)Max.Value, Int32.Parse(CompanyOrMachineID.Text)));
            }else
            {
                InventoryApp.Inventory.Parts.Add(new Outsourced((int)PartID.Value, Name.Text, Price.Value, (int)Inventory.Value, (int)Min.Value, (int)Max.Value, CompanyOrMachineID.Text));
            }

            CloseForm();            
        }

        private void PartID_TextChanged(object sender, EventArgs e)
        {

        }

        private void PartPage_Load(object sender, EventArgs e)
        {

        }

        private void CloseForm()
        {
            var inventory = (InventoryPage)Tag;
            inventory.Show();
            base.Close();
        }
    }
}
