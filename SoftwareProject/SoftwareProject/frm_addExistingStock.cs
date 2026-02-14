using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SoftwareProject
{
    public partial class frm_addExistingStock : Form
    {
        public frm_addExistingStock()
        {
            InitializeComponent();
        }

        private void Input_ModelNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            Inventory.findStockToAdd(Box_Description, Box_CurrentQuantity, Input_ModelNo.Text);

            if (Box_CurrentQuantity.Text.Length > 0)
            {

                Panel_AddStock.BackColor = Color.LightGray;
                Input_StockToAdd.BackColor = Color.White;
                Label_AddStock.ForeColor = Color.Black;
                Input_StockToAdd.ReadOnly = false;
            }
        }

        private void Input_StockToAdd_KeyDown(object sender, KeyEventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs ex)
        {
            String userModelNo = Input_ModelNo.Text;
            int userNewQuantity = 0;

            try
            {
                userNewQuantity = int.Parse(Input_StockToAdd.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }


            Boolean updateQueryResult = Inventory.updateExistingInventory(userModelNo, userNewQuantity);

            if (updateQueryResult == true)
            {
                int newQuantity = int.Parse(Box_CurrentQuantity.Text) + userNewQuantity;

                MessageBox.Show("Success!!\nStock updated in database");
                MessageBox.Show($"Item: {Input_ModelNo}" +
                    $"\nNew Quantity: {newQuantity}");

                Box_CurrentQuantity.Text = $"{newQuantity}";
            }
            else
            {
                MessageBox.Show("An Error has occured");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Box_Description.Text = "";
            Box_Description.BackColor = ColorTranslator.FromHtml("#626262");

            Box_CurrentQuantity.Text = "";
            Box_CurrentQuantity.BackColor = ColorTranslator.FromHtml("#626262");

            Input_StockToAdd.ReadOnly = true;
            Input_StockToAdd.Text = "";
            Input_StockToAdd.BackColor = ColorTranslator.FromHtml("#f0f0f0");

            Label_AddStock.ForeColor = ColorTranslator.FromHtml("#a0a0a0");
            Panel_AddStock.BackColor = ColorTranslator.FromHtml("#c8c8c8");

        }

    }


}
