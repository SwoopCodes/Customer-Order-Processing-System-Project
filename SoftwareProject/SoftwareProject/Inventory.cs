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

        public static DataSet getInventory(string search_query)
        {
            string query = $"SELECT * FROM inventory WHERE LOWER(inventory.description) LIKE '%{search_query.ToLower()}%'";

            DataSet inventorySet = Database.ExecuteMultiRowQuery(query);

            if (inventorySet.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show($"No items found with description {search_query}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return Database.ExecuteMultiRowQuery(query);
        }

        //Unused function
        public static DataSet searchItem(String searchItem)
        {
            String query = $"SELECT * FROM inventory WHERE Model_No LIKE '%{searchItem}%'";

            return Database.ExecuteMultiRowQuery(query);
        }

        public static void findStockToAdd(string searchQuery)
        {
            String DescriptionQuery = $"SELECT * FROM inventory WHERE model_no LIKE '%{searchQuery}%'";

           
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

            String sqlQuery = "SELECT * FROM Types ORDER BY TypeCode";


            return Database.ExecuteMultiRowQuery(sqlQuery);

        }

        public void AddProduct()
        {

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

        public static DataSet findItemToUpdate(string item_description)
        {
            string query = $"SELECT * FROM inventory WHERE LOWER(inventory.description) LIKE '%{item_description.ToLower()}%'";

            DataSet inventoryData = Database.ExecuteMultiRowQuery(query);

            if (inventoryData.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show($"No items found with description {item_description}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return inventoryData;


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
