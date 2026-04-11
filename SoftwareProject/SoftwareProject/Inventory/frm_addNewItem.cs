using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SoftwareProject
{
    public partial class frm_addNewItem : Form
    {
        public frm_addNewItem()
        {
            InitializeComponent();
        }

        //DO NOT TOUCH FRM_ADDNEWITEM_LOAD
        private void frm_addNewItem_Load(object sender, EventArgs e)
        {
            // DO NOT TOUCH OR DELETE THIS FUNCTION!!!!
            // WILL BREAK THIS FORM
        }

        private void Button_AddItem_Click(object sender, EventArgs e)
        {
            //Validate ALL the input data first
            if(validateInputs() == false)
            {
                return;
            }

            //Create a Product object and initialise with values from form controls

            Inventory newItem = new Inventory(Inventory.getNextProdID(), Input_ModelNo.Text, Input_Description.Text, Convert.ToInt32(Input_CurrentStock.Text),
            Convert.ToInt32(Input_MinStock.Text), Convert.ToDecimal(Input_SalePrice.Text), Convert.ToDecimal(Input_CostPrice.Text), Input_Supplier.Text);

            //Call the method to add the data to the Products table

            newItem.AddProduct();

            //display confirmation message

            MessageBox.Show("Product " + Input_Description.Text + " added successfully", "Success",

            MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI

            Input_ModelNo.Clear();
            Input_Description.Clear();
            Input_CurrentStock.Clear();
            Input_MinStock.Clear();
            Input_SalePrice.Text = "0.00";
            Input_CostPrice.Text = "0.00";
            Input_Supplier.Clear();

        }


        // Industry level validation right here
        private bool validateInputs()
        {
            bool isValid = true;

            // Validate Model_No
            if (string.IsNullOrWhiteSpace(Input_ModelNo.Text))
            {
                Input_ModelNo.BackColor = Color.OrangeRed;
                MessageBox.Show("Model number is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }
            else if (Input_ModelNo.Text.Length > 50)
            {
                Input_ModelNo.BackColor = Color.OrangeRed;
                MessageBox.Show("Model number cannot exceed 50 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            // Validate Description
            if (string.IsNullOrWhiteSpace(Input_Description.Text))
            {
                Input_Description.BackColor = Color.OrangeRed;
                MessageBox.Show("Description is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }
            else if (Input_Description.Text.Length > 200)
            {
                Input_Description.BackColor = Color.OrangeRed;
                MessageBox.Show("Description cannot exceed 200 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            // Validate Current Stock
            if (!int.TryParse(Input_CurrentStock.Text, out int currentStock))
            {
                Input_CurrentStock.BackColor = Color.OrangeRed;
                MessageBox.Show("Current stock must be a whole number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }
            else if (currentStock < 0)
            {
                Input_CurrentStock.BackColor = Color.OrangeRed;
                MessageBox.Show("Current stock must be between 0 and 99999.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            // Validate Minimum Stock
            if (!int.TryParse(Input_MinStock.Text, out int minStock))
            {
                Input_MinStock.BackColor = Color.OrangeRed;
                MessageBox.Show("Minimum stock must be a whole number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }
            else if (minStock < 0 || minStock > 99999)
            {
                Input_MinStock.BackColor = Color.OrangeRed;
                MessageBox.Show("Minimum stock must be between 0 and 99999.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            // Validate sales price
            if (!decimal.TryParse(Input_SalePrice.Text, out decimal salePrice))
            {
                Input_SalePrice.BackColor = Color.OrangeRed;
                MessageBox.Show("Sale price must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }
            else if (salePrice < 0 || salePrice > 999999.99m)
            {
                Input_SalePrice.BackColor = Color.OrangeRed;
                MessageBox.Show("Sale price must be between 0 and 999999.99", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            // Validate Cost Price
            if (!decimal.TryParse(Input_CostPrice.Text, out decimal costPrice))
            {
                Input_CostPrice.BackColor = Color.OrangeRed;
                MessageBox.Show("Cost price must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }
            else if (costPrice < 0 || costPrice > 999999.99m)
            {
                Input_CostPrice.BackColor = Color.OrangeRed;
                MessageBox.Show("Cost price must be between 0 and 999999.99", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            // Validate Supplier
            if (string.IsNullOrWhiteSpace(Input_Supplier.Text))
            {
                Input_Supplier.BackColor = Color.OrangeRed;
                MessageBox.Show("Supplier is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }
            else if (Input_Supplier.Text.Length > 100)
            {
                Input_Supplier.BackColor = Color.OrangeRed;
                MessageBox.Show("Supplier name cannot exceed 100 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            return isValid;
        }

        private void Input_ModelNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
