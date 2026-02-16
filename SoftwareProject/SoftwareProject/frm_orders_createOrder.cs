using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SoftwareProject
{
    public partial class frm_orders_createOrder : Form
    {
        public frm_orders_createOrder()
        {
            InitializeComponent();
        }

        private void frm_orders_createOrder_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order.findCompany(Input_ModelNo.Text, Input_CompanyName, Input_ShippingAddress);
        }

        private void Button_Add_Item_Click(object sender, EventArgs e)
        {

            if(Order.checkItemToAdd(Input_ModelNo.Text, Int32.Parse(Input_Quantity.Text)))
            {

                foreach (DataGridViewRow row in Order_Items_Table.Rows)
                {
                    String userModel = Input_ModelNo.Text.Trim();

                    if (row.Cells[0] != null && row.Cells[0].Value != null)
                    {
                        string rowItem = row.Cells[0].Value.ToString().Trim();

                        if (rowItem.Equals(userModel, StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show($"Item '{userModel}' already exists in order");
                            return;
                        }
                    }
                }

                Order_Items_Table.Rows.Add(Input_ModelNo.Text, Input_Quantity.Text);
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {


            //Creating order in orders table

            string customerID = Order.getCustomerID(Input_CompanyName.Text);
            string formattedDate = DateTime.Now.ToString("dd-MMM-yyyy").ToUpper();

            Order newOrder = new Order(Order.getNextOrderID(), Int32.Parse(customerID), formattedDate, 'A', Input_ShippingAddress.Text);
            newOrder.createOrder();


            //Create order items for current order
            int latestOrder = Order.getLatestOrderID();
            
            foreach(DataGridViewRow row in Order_Items_Table.Rows)
            {
                Object modelNo = row.Cells[0].Value;
                Object quantity = row.Cells[1].Value;

                if(modelNo == null)
                {
                    return;
                }

                Order.addOrderItems(latestOrder, modelNo.ToString(), Convert.ToInt32(quantity));
            }


        }


    }
}
