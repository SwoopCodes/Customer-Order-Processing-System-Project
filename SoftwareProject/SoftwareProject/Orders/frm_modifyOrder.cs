using SoftwareProject.Finances;
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

        int orderID;

        public frm_modifyOrder()
        {
            InitializeComponent();
        }

        private void Order_Items_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            frm_General_SelectionForm selectionTable = new frm_General_SelectionForm("Orders", Input_orderID.Text);
            selectionTable.ShowDialog();
            DataRow selectedRow = selectionTable.selectedItem;

            if (selectedRow != null)
            {

                orderID = Convert.ToInt32(selectedRow["order_id"].ToString());

                DataSet orderItems = Order.retrieveOrderItems(selectedRow["order_id"].ToString());
                Order_Items_Table.DataSource = orderItems.Tables[0];
                Order.getOrderTotal(Convert.ToInt32(orderID), label_orderTotal);
                Order.displayOrderStatus(Convert.ToInt32(orderID), Label_Status);

                button1.Enabled = false;
                button1.BackColor = Color.Gray;
                Input_orderID.Enabled = false;

                box_companyName.Text = selectedRow["company_name"].ToString();
                box_shippingAddress.Text = selectedRow["shipping_address"].ToString();

                button_markComplete.Enabled = true;
                button_markComplete.BackColor = Color.FromArgb(152, 251, 152);

                button_removeOrder.Enabled = true;
                button_removeOrder.BackColor = Color.FromArgb(233, 150, 122);



            }

        }

        private void button_markComplete_Click(object sender, EventArgs e)
        {
            Order.markOrderComplete(orderID);
        }

        private void button_removeOrder_Click(object sender, EventArgs e)
        {
            Order.removeOrder(orderID);
        }
    }
}
