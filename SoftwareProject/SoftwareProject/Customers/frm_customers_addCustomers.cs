using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SoftwareProject
{
    public partial class frm_customers_addCustomers : Form
    {
        public frm_customers_addCustomers()
        {
            InitializeComponent();
        }

        private void frm_customers_addCustomers_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Button_Update_Click(object sender, EventArgs e)
        {

            if (ValidateCustomerInputs())
            {
                Customers newCustomer = new Customers(Customers.getNextCustomerID(), Input_CompanyName.Text, Input_email.Text, Input_phone.Text, Input_address.Text, Input_Representative.Text);

                newCustomer.AddCustomer();

                MessageBox.Show("Customer " + Input_CompanyName.Text + " added successfully", "Success");

                ClearForm();
            }
            else
            {
                MessageBox.Show("Information failed to validate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private bool ValidateCustomerInputs()
        {
            bool isValid = true;

            // Company Name
            if (string.IsNullOrWhiteSpace(Input_CompanyName.Text))
            {
                Input_CompanyName.BackColor = Color.LightPink;
                MessageBox.Show("Company name is required.");
                isValid = false;
            }
            else if (Input_CompanyName.Text.Length > 100)
            {
                Input_CompanyName.BackColor = Color.LightPink;
                MessageBox.Show("Company name max 100 characters.");
                isValid = false;
            }

            // Email
            if (string.IsNullOrWhiteSpace(Input_email.Text))
            {
                Input_email.BackColor = Color.LightPink;
                MessageBox.Show("Email is required.");
                isValid = false;
            }
            else if (Input_email.Text.Length > 50)
            {
                Input_email.BackColor = Color.LightPink;
                MessageBox.Show("Email max 50 characters.");
                isValid = false;
            }
            else if (!Input_email.Text.Contains("@"))
            {
                Input_email.BackColor = Color.LightPink;
                MessageBox.Show("Enter valid email.");
                isValid = false;
            }
            else if (Input_email.Text.IndexOf("@") < 3)
            {
                MessageBox.Show("Enter Valid email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }

            // Phone
            if (string.IsNullOrWhiteSpace(Input_phone.Text))
            {
                Input_phone.BackColor = Color.LightPink;
                MessageBox.Show("Phone is required.");
                isValid = false;
            }
            else if (Input_phone.Text.Length > 10)
            {
                Input_phone.BackColor = Color.LightPink;
                MessageBox.Show("Phone max 10 digits.");
                isValid = false;
            }

            // Address
            if (string.IsNullOrWhiteSpace(Input_address.Text))
            {
                Input_address.BackColor = Color.LightPink;
                MessageBox.Show("Address is required.");
                isValid = false;
            }
            else if (Input_address.Text.Length > 300)
            {
                Input_address.BackColor = Color.LightPink;
                MessageBox.Show("Address max 300 characters.");
                isValid = false;
            }

            // Representative
            if (string.IsNullOrWhiteSpace(Input_Representative.Text))
            {
                Input_Representative.BackColor = Color.LightPink;
                MessageBox.Show("Representative is required.");
                isValid = false;
            }
            else if (Input_Representative.Text.Length > 50)
            {
                Input_Representative.BackColor = Color.LightPink;
                MessageBox.Show("Representative max 50 characters.");
                isValid = false;
            }

            return isValid;
        }

        private void ClearForm()
        {
            Input_CompanyName.Clear();
            Input_email.Clear();
            Input_phone.Clear();
            Input_address.Clear();
            Input_Representative.Clear();
            Input_CompanyName.Focus();
        }
    }
}
