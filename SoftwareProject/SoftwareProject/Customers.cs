using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SoftwareProject
{
    public class Customers
    {
        public Int32 customer_ID { get; set;}
        public string Company_name { get; set;}
        public string email { get; set;}
        public string phone { get; set;}
        public string address { get; set;}
        public string representative { get; set;}
        public string status { get; set;}


        public Customers(Int32 customer_id, string company_name, string email, string phone, string address, string representative)
        {
            this.customer_ID = customer_id;
            this.Company_name = company_name;
            this.email = email;
            this.phone = phone;
            this.address = address;
            this.representative = representative;
        }



        // found in view customers
        public static DataSet searchCustomer(String searchItem)
        {
            string query = $"SELECT * FROM customer WHERE LOWER(customer.company_name) LIKE '%{searchItem.ToLower()}%'";

            DataSet customerSet = Database.ExecuteMultiRowQuery(query);

            if (customerSet.Tables[0].Rows.Count < 0)
            {
                MessageBox.Show($"No items found with description {searchItem}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return Database.ExecuteMultiRowQuery(query);
        }

        // found in general selection form
        public static DataSet findCustomer(String searchCompany)
        {
            String query = $"SELECT * FROM customer WHERE LOWER(company_name) LIKE '%{searchCompany.ToLower()}%'";
            DataSet customerData = Database.ExecuteMultiRowQuery(query);

            if (customerData.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show($"No items found with description {searchCompany}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return customerData;
        }


        //found in add customer
        public void AddCustomer()
        {

            string sqlQuery = $@"INSERT INTO customer VALUES(
                                {this.customer_ID},
                                '{this.Company_name}',
                                '{this.email}',
                                {this.phone},
                                '{this.address}',
                                '{this.representative}',
                                'A')";

            Database.ExecuteNonQuery(sqlQuery);

        }

        // found in update customer
        public void updateCustomer()
        {

            try
            {

                String updateQuery = $"UPDATE customer SET email = '{this.email}', phone = '{this.phone}', address = '{this.address}', representative = '{this.representative}' WHERE company_name LIKE '%{this.Company_name}%'";

                int rowsAffected = Database.ExecuteUpdateStatement(updateQuery);

                if (rowsAffected == 0)
                {
                    MessageBox.Show("An error has occured");
                }
                else
                {
                    MessageBox.Show("Item successfully updated");
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("An error has occured\n\n" + e);
            }

        }


        // found in update customer
        public static void deleteCustomer(String companyName)
        {

            if(companyName == null)
            {
                MessageBox.Show("No company name chosen");
                return;
            }

            String deleteQuery = $"UPDATE customer SET status = 'D' WHERE company_name LIKE '{companyName}'";

            try
            {
                int rowsAffected = Database.ExecuteUpdateStatement(deleteQuery);

                if (rowsAffected == 0)
                {
                    MessageBox.Show("An error has occured");
                }
                else
                {
                    MessageBox.Show("Customer successfully updated");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error has occured\n" + e);
            }


        }

        // found in update customer
        public static void activateCustomer(String companyName)
        {
            String activateQuery = $"UPDATE customer SET status = 'A' WHERE company_name LIKE '{companyName}'";

            try
            {

                int rowsAffected = Database.ExecuteUpdateStatement(activateQuery);

                if (rowsAffected == 0)
                {
                    MessageBox.Show("Company not found");
                }
                else
                {
                    MessageBox.Show("Customer successfully updated");
                }

            }
            catch (Exception e)
            {

                MessageBox.Show($"An error occured\n\n {e}");

            }


        }


        // found in add customer
        public static int getNextCustomerID()
        {

            string sqlQuery = "SELECT MAX(customer_ID) FROM customer";

            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);
            int nextId;

            dr.Read();

            if (dr.IsDBNull(0))
                nextId = 1;
            else
                nextId = dr.GetInt32(0) + 1;

            dr.Close();
            return nextId;
        }

    }
}
