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
    public partial class frm_inventory_manageStock : Form
    {

        Boolean itemActive = false;
        public frm_inventory_manageStock()
        {
            InitializeComponent();
        }

        private void button_search_Click(object sender, EventArgs e)
        {

            frm_General_SelectionForm selectionTable = new frm_General_SelectionForm("Inventory", Input_searchQuery.Text);
            selectionTable.ShowDialog();
            DataRow selectedRow = selectionTable.selectedItem;

           
            if (selectedRow != null)
            {

                itemActive = true;

                Input_ModelNo.Text = selectedRow["model_no"].ToString();
                Input_ModelNo.BackColor = Color.White;

                Input_Description.Text = selectedRow["Description"].ToString();
                Input_Description.BackColor = Color.White;
                Input_Description.ReadOnly = false;

                Input_CurrentStock.Text = selectedRow["current_stock"].ToString();
                Input_CurrentStock.BackColor = Color.White;
                Input_CurrentStock.ReadOnly = false;

                Input_MinStock.Text = selectedRow["minimum_stock"].ToString();
                Input_MinStock.BackColor = Color.White;
                Input_MinStock.ReadOnly = false;

                Input_SalePrice.Text = selectedRow["sale_price"].ToString();
                Input_SalePrice.BackColor = Color.White;
                Input_SalePrice.ReadOnly = false;

                Input_CostPrice.Text = selectedRow["cost_price"].ToString();
                Input_CostPrice.BackColor = Color.White;
                Input_CostPrice.ReadOnly = false;

                Input_Supplier.Text = selectedRow["supplier"].ToString();
                Input_Supplier.BackColor = Color.White;
                Input_Supplier.ReadOnly = false;


            }


        }

        private void Button_Update_Click(object sender, EventArgs e)

        {

            if (validateInputs())
            {

                Inventory updatedDetails = new Inventory(Inventory.getNextProdID(), Input_ModelNo.Text, Input_Description.Text, Convert.ToInt32(Input_CurrentStock.Text),
                Convert.ToInt32(Input_MinStock.Text), Convert.ToDecimal(Input_SalePrice.Text), Convert.ToDecimal(Input_CostPrice.Text), Input_Supplier.Text);

                updatedDetails.updateStockItem();

            }
        }

        private bool validateInputs()
        {

            bool isValid = true;


            // Check if user chose item
            if(!itemActive)
            {
                Input_searchQuery.BackColor = Color.OrangeRed;
                MessageBox.Show("Must choose an item first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }
            else
            {
                // Validate Model_No
                if (string.IsNullOrWhiteSpace(Input_ModelNo.Text))
                {
                    Input_ModelNo.BackColor = Color.OrangeRed;
                    MessageBox.Show("Model number is required.", "Validation Error");
                    isValid = false;
                }
                else if (Input_ModelNo.Text.Length > 50)
                {
                    Input_ModelNo.BackColor = Color.OrangeRed;
                    MessageBox.Show("Model number cannot exceed 50 characters.", "Validation Error");
                    isValid = false;
                }

                // Validate Description
                if (string.IsNullOrWhiteSpace(Input_Description.Text))
                {
                    Input_Description.BackColor = Color.OrangeRed;
                    MessageBox.Show("Description is required.", "Validation Error");
                    isValid = false;
                }
                else if (Input_Description.Text.Length > 200)
                {
                    Input_Description.BackColor = Color.OrangeRed;
                    MessageBox.Show("Description cannot exceed 200 characters.", "Validation Error");
                    isValid = false;
                }

                // Validate Current Stock
                if (!int.TryParse(Input_CurrentStock.Text, out int currentStock))
                {
                    Input_CurrentStock.BackColor = Color.OrangeRed;
                    MessageBox.Show("Current stock must be a whole number.", "Validation Error");
                    isValid = false;
                }
                else if (currentStock < 0)
                {
                    Input_CurrentStock.BackColor = Color.OrangeRed;
                    MessageBox.Show("Current stock must be between 0 and 99999.", "Validation Error");
                    isValid = false;
                }

                // Validate Minimum Stock
                if (!int.TryParse(Input_MinStock.Text, out int minStock))
                {
                    Input_MinStock.BackColor = Color.OrangeRed;
                    MessageBox.Show("Minimum stock must be a whole number.", "Validation Error");
                    isValid = false;
                }
                else if (minStock < 0 || minStock > 99999)
                {
                    Input_MinStock.BackColor = Color.OrangeRed;
                    MessageBox.Show("Minimum stock must be between 0 and 99999.", "Validation Error");
                    isValid = false;
                }

                // Validate sales price
                if (!decimal.TryParse(Input_SalePrice.Text, out decimal salePrice))
                {
                    Input_SalePrice.BackColor = Color.OrangeRed;
                    MessageBox.Show("Sale price must be a valid number.", "Validation Error");
                    isValid = false;
                }
                else if (salePrice < 0 || salePrice > 999999.99m)
                {
                    Input_SalePrice.BackColor = Color.OrangeRed;
                    MessageBox.Show("Sale price must be between 0 and 999999.99", "Validation Error");
                    isValid = false;
                }

                // Validate Cost Price
                if (!decimal.TryParse(Input_CostPrice.Text, out decimal costPrice))
                {
                    Input_CostPrice.BackColor = Color.OrangeRed;
                    MessageBox.Show("Cost price must be a valid number.", "Validation Error");
                    isValid = false;
                }
                else if (costPrice < 0 || costPrice > 999999.99m)
                {
                    Input_CostPrice.BackColor = Color.OrangeRed;
                    MessageBox.Show("Cost price must be between 0 and 999999.99", "Validation Error");
                    isValid = false;
                }

                // Validate Supplier
                if (string.IsNullOrWhiteSpace(Input_Supplier.Text))
                {
                    Input_Supplier.BackColor = Color.OrangeRed;
                    MessageBox.Show("Supplier is required.", "Validation Error");
                    isValid = false;
                }
                else if (Input_Supplier.Text.Length > 100)
                {
                    Input_Supplier.BackColor = Color.OrangeRed;
                    MessageBox.Show("Supplier name cannot exceed 100 characters.", "Validation Error");
                    isValid = false;
                }
            }
            
            

            return isValid;
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            Inventory.deleteStockItem(Input_ModelNo.Text);
            resetUI();
        }

        private void resetUI()
        {
            Input_ModelNo.Text = "";

            Input_Description.ReadOnly = true;
            Input_Description.BackColor = Color.Gray;
            Input_Description.Text = "";

            Input_CurrentStock.ReadOnly = true;
            Input_CurrentStock.BackColor = Color.Gray;
            Input_CurrentStock.Text = "";

            Input_MinStock.ReadOnly = true;
            Input_MinStock.BackColor = Color.Gray;
            Input_MinStock.Text = "";

            Input_SalePrice.ReadOnly = true;
            Input_SalePrice.BackColor = Color.Gray;
            Input_SalePrice.Text = "";

            Input_CostPrice.ReadOnly = true;
            Input_CostPrice.BackColor = Color.Gray;
            Input_CostPrice.Text = "";

            Input_Supplier.ReadOnly = true;
            Input_Supplier.BackColor = Color.Gray;
            Input_Supplier.Text = "";

            itemActive = false;
            Input_searchQuery.BackColor = Color.White;

        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            resetUI();
          
        }
    }


}
