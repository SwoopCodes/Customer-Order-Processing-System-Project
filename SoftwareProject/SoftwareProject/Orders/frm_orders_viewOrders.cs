using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SoftwareProject
{
    public partial class frm_orders_viewOrders : Form
    {
        public frm_orders_viewOrders()
        {
            InitializeComponent();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(input_search.Text) && input_search.Text.Length > 2)
            {
                dataGrid.DataSource = Order.findOrderByName(input_search.Text).Tables[0];
            }
            else
            {
                MessageBox.Show("Search query is too short", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
