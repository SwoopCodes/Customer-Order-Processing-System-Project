using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Xml.Linq;

namespace SoftwareProject
{
    public class Inventory
    {
        public int Product_ID { get; set; }
        public string Model_No { get; set; }
        public string Description { get; set; }
        public Int32 Current_stock { get; set; }
        public Int32 Minimum_Stock { get; set; } 
        public Decimal Sale_Price { get; set; }
        public Decimal Cost_Price { get; set; }
        public string Supplier {  get; set; }


        public Inventory(int product_ID, string model_No, string description, Int32 current_stock, Int32 minimum_Stock, Decimal sale_Price, Decimal cost_Price, string supplier)
        {
            this.Product_ID = product_ID;
            this.Model_No = model_No;
            this.Description = description;
            this.Current_stock = current_stock;
            this.Minimum_Stock = minimum_Stock;
            this.Sale_Price = sale_Price;
            this.Cost_Price = cost_Price;
            this.Supplier = supplier;
        }

        public static DataSet getAllInventory()
        {
            string query = "SELECT * FROM inventory";

            return Database.ExecuteMultiRowQuery(query);
        }

        public static DataSet searchItem(String searchItem)
        {
            String query = $"SELECT * FROM inventory WHERE Model_No LIKE '%{searchItem}%'";

            return Database.ExecuteMultiRowQuery(query);
        }

        public static void findStockToAdd(RichTextBox descriptionBox, TextBox currentStockBox, String inputModelNo)
        {
            String DescriptionQuery = $"SELECT Description FROM inventory WHERE model_no LIKE '{inputModelNo}'";
            String quantityQuery = $"SELECT current_stock FROM inventory WHERE model_no LIKE '{inputModelNo}'";

            try
            {

                descriptionBox.Text = Database.ExecuteMultiRowQuery(DescriptionQuery).Tables[0].Rows[0]["Description"].ToString();
                descriptionBox.BackColor = Color.White;
       
                currentStockBox.Text = Database.ExecuteMultiRowQuery(quantityQuery).Tables[0].Rows[0]["Current_Stock"].ToString();
                currentStockBox.BackColor = Color.White;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Model not found!\nPlease Try again");
                
            } catch (Exception e)
            {
                MessageBox.Show($"An Error Has Occurred\n\n {e}");
            }
        }

        public static Boolean updateExistingInventory(String model_no, int stockToAdd)
        {

            String updateQuery = $"UPDATE inventory SET current_stock = current_stock + {stockToAdd} WHERE model_no LIKE '{model_no}'";

            int rowsAffected = Database.ExecuteUpdateStatement(updateQuery);

            if (rowsAffected == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        public static int getNextProdID()
        {

            string sqlQuery = "SELECT MAX(product_id) FROM inventory";

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

        public static DataSet getTypes()

        {

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Types ORDER BY TypeCode";

            //Execute the SQL query

            return Database.ExecuteMultiRowQuery(sqlQuery);

        }

        public void AddProduct()
        {

            //Define the SQL query to be executed
            string sqlQuery = "INSERT INTO inventory Values (" +
                            this.Product_ID + ", '" +           
                            this.Model_No + "', '" +            
                            this.Description + "', " +          
                            this.Current_stock + ", " +         
                            this.Minimum_Stock + ", " +         
                            this.Sale_Price + ", " +            
                            this.Cost_Price + ", '" +           
                            this.Supplier + "')";               

            //Execute the SQL query
            Database.ExecuteNonQuery(sqlQuery);

        }

        public static void findItemToUpdate(RichTextBox descriptionBox, TextBox currentStockBox, TextBox minStockBox, TextBox salePriceBox, TextBox costPriceBox, TextBox supplierBox,String inputModelNo)
        {
            String DescriptionQuery = $"SELECT Description FROM inventory WHERE model_no LIKE '{inputModelNo}'";
            String currentStockQuery = $"SELECT current_stock FROM inventory WHERE model_no LIKE '{inputModelNo}'";
            String minStockQuery = $"SELECT MINIMUM_STOCK FROM inventory WHERE model_no LIKE '{inputModelNo}'";
            String salePriceQuery = $"SELECT SALE_PRICE FROM inventory WHERE model_no LIKE '{inputModelNo}'";
            String costPriceQuery = $"SELECT COST_PRICE FROM inventory WHERE model_no LIKE '{inputModelNo}'";
            String supplierQuery = $"SELECT SUPPLIER FROM inventory WHERE model_no LIKE '{inputModelNo}'";


            try
            {

                descriptionBox.Text = Database.ExecuteMultiRowQuery(DescriptionQuery).Tables[0].Rows[0]["Description"].ToString();
                descriptionBox.BackColor = Color.White;
                descriptionBox.ReadOnly = false;

                currentStockBox.Text = Database.ExecuteMultiRowQuery(currentStockQuery).Tables[0].Rows[0]["Current_Stock"].ToString();
                currentStockBox.BackColor = Color.White;
                currentStockBox.ReadOnly = false;

                minStockBox.Text = Database.ExecuteMultiRowQuery(minStockQuery).Tables[0].Rows[0]["MINIMUM_STOCK"].ToString();
                minStockBox.BackColor = Color.White;
                minStockBox.ReadOnly = false;

                salePriceBox.Text = Database.ExecuteMultiRowQuery(salePriceQuery).Tables[0].Rows[0]["SALE_PRICE"].ToString();
                salePriceBox.BackColor = Color.White;
                salePriceBox.ReadOnly = false;

                costPriceBox.Text = Database.ExecuteMultiRowQuery(costPriceQuery).Tables[0].Rows[0]["COST_PRICE"].ToString();
                costPriceBox.BackColor = Color.White;
                costPriceBox.ReadOnly = false;

                supplierBox.Text = Database.ExecuteMultiRowQuery(supplierQuery).Tables[0].Rows[0]["SUPPLIER"].ToString();
                supplierBox.BackColor = Color.White;
                supplierBox.ReadOnly = false;

            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Model not found!\nPlease Try again");

            }
            catch (Exception e)
            {
                MessageBox.Show($"An Error Has Occurred\n\n {e}");
            }
        }

        public void updateStockItem()
        {

            try
            {

                String updateQuery = $"UPDATE inventory SET DESCRIPTION = '{this.Description}',current_stock = {this.Current_stock},minimum_stock = {this.Minimum_Stock},sale_price = {this.Sale_Price},cost_price = {this.Cost_Price},supplier = '{this.Supplier}'WHERE model_no = '{this.Model_No}'";

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

        public static void deleteStockItem(String modelNo)
        {
            String deleteQuery = $"DELETE FROM inventory WHERE model_no = '{modelNo}'";

            try
            {
                Database.ExecuteNonQuery(deleteQuery);

            } catch (Exception e)
            {
                MessageBox.Show("Error has occured\n" + e);
            }

            MessageBox.Show("Item successfully deleted");

        }

        public static DataSet viewLowStock()
        {
            string query = "SELECT * FROM inventory WHERE current_stock < minimum_stock";

            return Database.ExecuteMultiRowQuery(query);
        }

    }
}
