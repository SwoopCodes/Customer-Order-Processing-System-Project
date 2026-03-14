using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SoftwareProject
{
    public partial class frm_modifyOrder : Form
    {
        public frm_modifyOrder()
        {
            InitializeComponent();
        }

        private void Order_Items_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (int.TryParse(Input_orderID.Text, out int orderId))
            {

                Order.viewOrderDetails(Convert.ToInt32(Input_orderID.Text), box_companyName, box_shippingAddress, Order_Items_Table, button_markComplete, button_removeOrder);
                Order.getOrderTotal(Convert.ToInt32(Input_orderID.Text), label_orderTotal);
                Order.displayOrderStatus(Convert.ToInt32(Input_orderID.Text), Label_Status);
                button1.Enabled = false;
                button1.BackColor = Color.Gray;
                Input_orderID.Enabled = false;
                
            }
            else
            {
                MessageBox.Show("Invalid value entered for order ID\nMust be a number");
            }

        }

        private void button_markComplete_Click(object sender, EventArgs e)
        {
            Order.markOrderComplete(Convert.ToInt32(Input_orderID.Text));
        }

        private void button_removeOrder_Click(object sender, EventArgs e)
        {
            Order.removeOrder(Convert.ToInt32(Input_orderID.Text));
        }
    }
}
