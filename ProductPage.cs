using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class ProductPage : Form
    {
        public ProductPage()
        {
            InitializeComponent();
        }

        private void productCancel_button_Click(object sender, EventArgs e)
        {
            var inventory = (InventoryPage)Tag;
            inventory.Show();
            Close();
        }
    }
}
