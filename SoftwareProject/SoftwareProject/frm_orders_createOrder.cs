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
            Order_Items_Table.Rows.Add(Input_ModelNo.Text, Input_Quantity.Text);
        }
    }
}
