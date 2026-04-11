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
        }

        private void button_search_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(input_search.Text) && input_search.Text.Length > 2)
            {
                dataGrid.DataSource = Inventory.getInventory(input_search.Text).Tables[0];
            }
            else
            {
                MessageBox.Show("Search query is too short", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}