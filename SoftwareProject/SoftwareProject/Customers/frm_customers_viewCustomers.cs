using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SoftwareProject
{
    public partial class frm_customers_viewCustomers : Form
    {
        public frm_customers_viewCustomers()
        {
            InitializeComponent();
            dataGrid.DataSource = Customers.getAllCustomers().Tables[0];

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = Customers.searchCustomer(input_search.Text).Tables[0];
        }
    }
}
