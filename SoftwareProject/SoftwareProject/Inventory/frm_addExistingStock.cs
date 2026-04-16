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
    public partial class frm_addExistingStock : Form
    {

        Boolean isActive = false;
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

            if (Input_searchQuery.Text.Length > 2)
            {

                frm_General_SelectionForm selectionTable = new frm_General_SelectionForm("Inventory", Input_searchQuery.Text);
                selectionTable.ShowDialog();
                DataRow selectedRow = selectionTable.selectedItem;

                if (selectedRow != null)
                {

                    isActive = true;

                    Box_ModelNo.Text = selectedRow["model_no"].ToString();
                    Box_ModelNo.BackColor = Color.White;

                    Box_CurrentQuantity.Text = selectedRow["current_stock"].ToString();
                    Box_CurrentQuantity.BackColor = Color.White;

                    Panel_AddStock.BackColor = Color.LightGray;
                    Input_StockToAdd.BackColor = Color.White;
                    Label_AddStock.ForeColor = Color.Black;
                    Input_StockToAdd.ReadOnly = false;

                }

            }
            else
            {
                MessageBox.Show("Search query is too short", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void Input_StockToAdd_KeyDown(object sender, KeyEventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs ex)
        {

            if (isActive)
            {
                String userModelNo = Box_ModelNo.Text;
                int userNewQuantity = 0;

                try
                {
                    userNewQuantity = int.Parse(Input_StockToAdd.Text);
                }
                catch (Exception e)
                {
                    MessageBox.Show("You must enter a digit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                Boolean updateQueryResult = Inventory.updateExistingInventory(userModelNo, userNewQuantity);

                if (updateQueryResult == true)
                {
                    int newQuantity = int.Parse(Box_CurrentQuantity.Text) + userNewQuantity;

                    MessageBox.Show($"Item {Box_ModelNo.Text} updated\nNewQuantity: {newQuantity}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Box_CurrentQuantity.Text = $"{newQuantity}";
                }
                else
                {
                    MessageBox.Show("An Error has occured");
                }
            }
            else
            {
                MessageBox.Show("Choose an item first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            isActive = false;

            Box_ModelNo.Text = "";
            Box_ModelNo.BackColor = ColorTranslator.FromHtml("#626262");

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
