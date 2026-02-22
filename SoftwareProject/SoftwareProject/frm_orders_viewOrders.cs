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

            dataGrid.DataSource = Order.getAllOrders().Tables[0];


            DataGridViewColumn OrderIDColumn = dataGrid.Columns[0];
            DataGridViewColumn companyNameColumn = dataGrid.Columns[1];
            DataGridViewColumn orderDateColumn = dataGrid.Columns[2];
            DataGridViewColumn statusColumn = dataGrid.Columns[3];
            DataGridViewColumn shippingAddressColumn = dataGrid.Columns[4];

            OrderIDColumn.Width = 100;
            companyNameColumn.Width = 190;
            orderDateColumn.Width = 90;
            statusColumn.Width = 60;
            shippingAddressColumn.Width = 600;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = Order.findOrderByName(input_search.Text).Tables[0];
        }

        private void button_dateDesc_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = Order.viewOrderByDateDesc().Tables[0];
        }

        private void button_dateAscending_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = Order.viewOrderByDateAsc().Tables[0];
        }
    }
}
