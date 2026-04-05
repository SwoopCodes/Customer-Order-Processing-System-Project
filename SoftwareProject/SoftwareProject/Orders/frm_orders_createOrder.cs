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
    public partial class frm_orders_createOrder : Form
    {
        public frm_orders_createOrder()
        {
            InitializeComponent();

            DataGridViewButtonColumn c = (DataGridViewButtonColumn)deleteButtonColumn;
            c.DefaultCellStyle.BackColor = Color.Red;
            c.DefaultCellStyle.ForeColor = Color.White;
            Order_Items_Table.CellClick += Order_Items_Table_CellClick;

        }



        private void frm_orders_createOrder_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            frm_General_SelectionForm selectionTable = new frm_General_SelectionForm("Customers", Input_CompanyName.Text);
            selectionTable.ShowDialog();
            DataRow selectedRow = selectionTable.selectedItem;

            if (selectedRow != null)
            {

                Input_ModelNo.BackColor = Color.White;
                Input_CompanyName.Text = selectedRow["company_name"].ToString();

                Input_Quantity.ReadOnly = false;
                Input_Quantity.BackColor = Color.White;

                Input_ShippingAddress.ReadOnly = false;
                Input_ShippingAddress.BackColor = Color.White;
                Input_ShippingAddress.Text = selectedRow["address"].ToString();

                Button_Add_Item.BackColor = Color.FromArgb(127, 253, 127);
                Button_Add_Item.Enabled = true;

                button2.BackColor = Color.FromArgb(127, 253, 127);
                button2.Enabled = true;

                Button_findItem.BackColor = Color.FromArgb(255, 192, 128);
                Button_findItem.Enabled = true;

                Input_itemSearch.BackColor = Color.White;
                Input_itemSearch.ReadOnly = false ;

            }


        }

        private void Button_Add_Item_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(Input_Quantity.Text) || !int.TryParse(Input_Quantity.Text, out _))
            {

                MessageBox.Show("Invalid quantity entered\nMust be number and not empty");
                return;
            }

            if (Order.checkItemToAdd(Input_ModelNo.Text, Int32.Parse(Input_Quantity.Text)))
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

            if (Order_Items_Table.Rows.Count == 1)
            {
                MessageBox.Show("No Items selected for order\nPlease add items before continuing");
                return;
            }

            string customerID = Order.getCustomerID(Input_CompanyName.Text);
            string formattedDate = DateTime.Now.ToString("dd-MMM-yyyy").ToUpper();

            Order newOrder = new Order(Order.getNextOrderID(), Int32.Parse(customerID), formattedDate, 'A', Input_ShippingAddress.Text);
            newOrder.createOrder();

            int latestOrder = Order.getLatestOrderID();

            foreach (DataGridViewRow row in Order_Items_Table.Rows)
            {
                Object modelNo = row.Cells[0].Value;
                Object quantity = row.Cells[1].Value;

                if (modelNo == null)
                {
                    return;
                }

                Order.addOrderItems(latestOrder, modelNo.ToString(), Convert.ToInt32(quantity));
            }

        }

        private void Order_Items_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                if (e.RowIndex >= 0 && e.ColumnIndex == Order_Items_Table.Columns["deleteButtonColumn"].Index)
                {

                    Order_Items_Table.Rows.RemoveAt(e.RowIndex);

                }

            }
            catch{

                MessageBox.Show("Cannot delete row", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            }
        }

        private void Button_findItem_Click(object sender, EventArgs e)
        {

            if (Input_itemSearch.TextLength > 2)
            {

                frm_General_SelectionForm selectionTable = new frm_General_SelectionForm("Inventory", Input_itemSearch.Text);
                selectionTable.ShowDialog();
                DataRow itemRow = selectionTable.selectedItem;

                if (itemRow != null)
                {

                    Input_ModelNo.Text = itemRow["model_no"].ToString();

                }
            }
            else
            {
                MessageBox.Show("Description too short", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }
    }
}
