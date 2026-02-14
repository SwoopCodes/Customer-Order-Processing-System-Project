using SoftwareProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SoftwareProject
{
    public partial class frm_inventory_addStock : Form
    {
        public frm_inventory_addStock()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            NavigationHelper.addExistingNavigation(this);
        }

        private void button_newItem_Click(object sender, EventArgs e)
        {
            NavigationHelper.addNewItemNavigation(this);
        }
    }
}
