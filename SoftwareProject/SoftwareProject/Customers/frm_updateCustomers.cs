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
    public partial class frm_updateCustomers : Form
    {
        public frm_updateCustomers()
        {
            InitializeComponent();
        }

        private void frm_updateCustomers_Load(object sender, EventArgs e)
        {

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            frm_General_SelectionForm selectionTable = new frm_General_SelectionForm("Customers", Input_CompanyName.Text);
            selectionTable.ShowDialog();
            DataRow selectedRow = selectionTable.selectedItem;

            if (selectedRow != null)
            {

                Input_CompanyName.Text = selectedRow["company_name"].ToString();
                Input_CompanyName.ReadOnly = true;

                Input_email.Text = selectedRow["email"].ToString();
                Input_email.BackColor = Color.White;
                Input_email.ReadOnly = false;

                Input_phone.Text = selectedRow["phone"].ToString();
                Input_phone.BackColor = Color.White;
                Input_phone.ReadOnly = false;

                Input_address.Text = selectedRow["address"].ToString();
                Input_address.BackColor = Color.White;
                Input_address.ReadOnly = false;

                Input_representative.Text = selectedRow["representative"].ToString();
                Input_representative.BackColor = Color.White;
                Input_representative.ReadOnly = false;

            }

        }

        private void Button_Update_Click(object sender, EventArgs e)

        {

            if (ValidateCustomerInputs())
            {
                Customers updatedCustomer = new Customers(0, Input_CompanyName.Text, Input_email.Text, Input_phone.Text, Input_address.Text, Input_representative.Text);

                updatedCustomer.updateCustomer();
            }

        }

        private bool ValidateCustomerInputs()
        {
            bool isValid = true;


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
            if (string.IsNullOrWhiteSpace(Input_representative.Text))
            {
                Input_representative.BackColor = Color.LightPink;
                MessageBox.Show("Representative is required.");
                isValid = false;
            }
            else if (Input_representative.Text.Length > 50)
            {
                Input_representative.BackColor = Color.LightPink;
                MessageBox.Show("Representative max 50 characters.");
                isValid = false;
            }

            return isValid;
        }

        private void ClearForm()
        {
            Input_CompanyName.Text = "";
            Input_CompanyName.ReadOnly = false;

            Input_email.ReadOnly = true;
            Input_email.BackColor = Color.Gray;
            Input_email.Text = "";

            Input_phone.ReadOnly = true;
            Input_phone.BackColor = Color.Gray;
            Input_phone.Text = "";

            Input_address.ReadOnly = true;
            Input_address.BackColor = Color.Gray;
            Input_address.Text = "";

            Input_representative.ReadOnly = true;
            Input_representative.BackColor = Color.Gray;
            Input_representative.Text = "";
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            Customers.deleteCustomer(Input_CompanyName.Text);
            ClearForm();
        }
    }
}
