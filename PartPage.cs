using System;
using System.Linq;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class PartPage : Form
    {
        private Part modifyingPart { get; set; }
        private bool partIsInHouse = true;

        public PartPage()
        {
            InitializeComponent();
        }

        public PartPage(Inhouse part)
        {
            InitializeComponent();
            CompanyOrMachineID.Text = part.MachineID.ToString();
            setPartDetails(part);

        }
        public PartPage(Outsourced part)
        {
            InitializeComponent();
            CompanyOrMachineID.Text = part.CompanyName;
            setPartDetails(part);
        }

        private void setPartDetails(Part part)
        {
            label1.Text = "Modify Part";
            Name.Text = part.Name;
            PartID.Text = part.PartID.ToString();
            PartID.Enabled = false;
            Inventory.Value = part.InStock;
            Price.Value = part.Price;
            Max.Value = part.Max;
            Min.Value = part.Min;

            if(part is Outsourced)
            {
                outSourcedButton.Checked = true;
                label6.Text = "Comany Name";
                partIsInHouse = false;
            }
            modifyingPart = part;
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
                partIsInHouse = false;
            }
            else
            {
               label6.Text = "Machine ID";
               partIsInHouse = true;
            }                        
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (modifyingPart != null)
            {
                modifyPart();
                return;
            }

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

        private void modifyPart()
        {
            foreach (Part p in InventoryApp.Inventory.Parts)
            {
                if (p.PartID == modifyingPart.PartID)
                {
                    // outsourced => inhouse
                    if ((p is Outsourced) && partIsInHouse) 
                    {
                        Inhouse pInHouse = new Inhouse((int)PartID.Value, Name.Text, Price.Value, (int)Inventory.Value, (int)Min.Value, (int)Max.Value, Int32.Parse(CompanyOrMachineID.Text));
                        InventoryApp.Inventory.Parts.Remove(p);
                        InventoryApp.Inventory.Parts.Add(pInHouse);
                        CloseForm();
                        return;
                    }

                    // inhouse => outsourced
                    if((p is Inhouse) && !partIsInHouse)
                    {
                        Outsourced pOutsourced = new Outsourced((int)PartID.Value, Name.Text, Price.Value, (int)Inventory.Value, (int)Min.Value, (int)Max.Value, CompanyOrMachineID.Text);
                        InventoryApp.Inventory.Parts.Remove(p);
                        InventoryApp.Inventory.Parts.Add(pOutsourced);
                        CloseForm();
                        return;
                    }

                    //stays inhouse
                    if ((p is Inhouse) && partIsInHouse)
                    {
                        Inhouse inhouse = p as Inhouse;
                        inhouse.Name = Name.Text;
                        inhouse.InStock = (int)Inventory.Value;
                        inhouse.Price = Price.Value;
                        inhouse.Max = (int)Max.Value;
                        inhouse.Min = (int)Min.Value;
                        inhouse.MachineID = Int32.Parse(CompanyOrMachineID.Text);

                        CloseForm();
                        return;
                    }

                    //stays outsourced
                    Outsourced outsourced = p as Outsourced;
                    outsourced.Name = Name.Text;
                    outsourced.InStock = (int)Inventory.Value;
                    outsourced.Price = Price.Value;
                    outsourced.Max = (int)Max.Value;
                    outsourced.Min = (int)Min.Value;
                    outsourced.CompanyName = CompanyOrMachineID.Text;

                    CloseForm();
                    return;
                }
            }
        }

        private void CloseForm()
        {
            var inventory = (InventoryPage)Tag;
            inventory.Show();
            Close();
        }
    }
}
