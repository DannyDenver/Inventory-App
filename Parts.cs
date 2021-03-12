using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class Parts : Form
    {
        public Parts()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var inventory = (Inventory)Tag;
            inventory.Show();
            Close();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Parts_Load(object sender, EventArgs e)
        {

        }
    }
}
