using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace SoftwareProject
{



    public partial class frm_inventory_viewStock : Form
    {

        public frm_inventory_viewStock()
        {
            InitializeComponent();
            dataGrid.DataSource = Inventory.getAllInventory().Tables[0];
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = Inventory.searchItem(input_search.Text).Tables[0];

        }
    }
}
