using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

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


        public Customers(Int32 customer_id, string company_name, string email, string phone, string address, string representative)
        {
            this.customer_ID = customer_id;
            this.Company_name = company_name;
            this.email = email;
            this.phone = phone;
            this.address = address;
            this.representative = representative;
        }

        public static DataSet getAllCustomers()
        {
            string query = "SELECT * FROM customer";

            return Database.ExecuteMultiRowQuery(query);
        }

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

        public static DataSet findCustomer(String searchCompany)
        {
            String query = $"SELECT * FROM customer WHERE company_name LIKE '%{searchCompany}%'";
            DataSet customerData = Database.ExecuteMultiRowQuery(query);

            if (customerData.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show($"No items found with description {searchCompany}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return customerData;
        }

        public void AddCustomer()
        {

            //Define the SQL query to be executed
            string sqlQuery = "INSERT INTO customer VALUES (" +
                              this.customer_ID + ", '" +
                              this.Company_name.Replace("'", "''") + "', '" +
                              this.email.Replace("'", "''") + "', " +
                              this.phone + ", '" +
                              this.address.Replace("'", "''") + "', '" +
                              this.representative.Replace("'", "''") + "')";

            //Execute the SQL query
            Database.ExecuteNonQuery(sqlQuery);

        }

        public static void findItemToUpdate(TextBox emailBox, TextBox phoneBox, TextBox addressBox, TextBox representativeBox, String inputCompanyName)
        {
    
            String emailQuery = $"SELECT email FROM customer WHERE company_name LIKE '%{inputCompanyName.Trim()}%'";
            String phoneQuery = $"SELECT phone FROM customer WHERE company_name LIKE '%{inputCompanyName.Trim()}%'";
            String addressQuery = $"SELECT address FROM customer WHERE company_name LIKE '%{inputCompanyName.Trim()}%'";
            String representativeQuery = $"SELECT representative FROM customer WHERE company_name LIKE '%{inputCompanyName.Trim()}%'";


            try
            {

                emailBox.Text = Database.ExecuteMultiRowQuery(emailQuery).Tables[0].Rows[0]["email"].ToString();
                emailBox.BackColor = Color.White;
                emailBox.ReadOnly = false;

                phoneBox.Text = Database.ExecuteMultiRowQuery(phoneQuery).Tables[0].Rows[0]["phone"].ToString();
                phoneBox.BackColor = Color.White;
                phoneBox.ReadOnly = false;

                addressBox.Text = Database.ExecuteMultiRowQuery(addressQuery).Tables[0].Rows[0]["address"].ToString();
                addressBox.BackColor = Color.White;
                addressBox.ReadOnly = false;

                representativeBox.Text = Database.ExecuteMultiRowQuery(representativeQuery).Tables[0].Rows[0]["representative"].ToString();
                representativeBox.BackColor = Color.White;
                representativeBox.ReadOnly = false;

            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Company not found!\nPlease Try again");

            }
            catch (Exception e)
            {
                MessageBox.Show($"An Error Has Occurred\n\n {e}");
            }
        }

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

        public static void deleteCustomer(String companyName)
        {
            String deleteQuery = $"DELETE FROM customer WHERE company_name LIKE '%{companyName}%'";

            try
            {
                Database.ExecuteNonQuery(deleteQuery);

            }
            catch (Exception e)
            {
                MessageBox.Show("Error has occured\n" + e);
            }

            MessageBox.Show("Item successfully deleted");

        }

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
