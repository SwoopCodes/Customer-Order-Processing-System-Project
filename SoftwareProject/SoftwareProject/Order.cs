using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata;
using System.Text;

namespace SoftwareProject
{
    internal class Order
    {

        private int order_ID {  get; set; }
        private int customer_ID { get; set; }
        private string order_date { get; set; }
        private char status {  get; set; }
        private string shipping_address { get; set; }

        public Order(int order_ID, int customer_ID, string order_date, char status, string shipping_address)
        {
            this.order_ID = order_ID;
            this.customer_ID = customer_ID;
            this.order_date = order_date;
            this.status = status;
            this.shipping_address = shipping_address;
        }

        public static void findCompany(String searchItem, TextBox companyName, TextBox companyAddress)
        {
            string query = $@"
            SELECT company_name, address 
            FROM customer 
            WHERE company_name LIKE '{searchItem}%'
            ORDER BY company_name";

            var result = Database.ExecuteMultiRowQuery(query);


            try
            {
                companyName.Text = result.Tables[0].Rows[0]["company_name"].ToString();
                companyAddress.Text = result.Tables[0].Rows[0]["address"].ToString();
            } catch(Exception e)
            {
                MessageBox.Show("Company not found");
            }


        }

        public void createOrder()
        {

            string insertQuery = $"INSERT INTO orders VALUES( {this.order_ID}, {this.customer_ID}, TO_DATE('{this.order_date}', 'DD-MON-YYYY'), '{this.status}', '{this.shipping_address}')";

            Database.ExecuteNonQuery(insertQuery);

            MessageBox.Show($"Success\nOrder has been created\nOrder ID: {this.order_ID}");
        }

        public static int getNextOrderID()
        {

            string sqlQuery = "SELECT MAX(order_ID) FROM orders";

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

        public static string getCustomerID(String companyName)
        {
            string findCompanyIDQuery = $"Select customer_id from customer WHERE company_name LIKE '{companyName}'";

            return Database.ExecuteMultiRowQuery(findCompanyIDQuery).Tables[0].Rows[0]["customer_id"].ToString();

        }

        public static int getLatestOrderID()
        {
            string getLatestOrder = "SELECT MAX(order_ID) AS max FROM orders";
            String order_id = Database.ExecuteMultiRowQuery(getLatestOrder).Tables[0].Rows[0]["max"].ToString();
            return Int32.Parse(order_id);
        }

        public static Boolean checkItemToAdd(String itemName, int quantity) 
        {

            string checkItemExists = $"SELECT model_no FROM inventory WHERE model_no LIKE '{itemName}'";
            string checkQuantity = $"SELECT current_stock from inventory WHERE model_no LIKE '{itemName}'";

            try
            {
                Database.ExecuteMultiRowQuery(checkItemExists).Tables[0].Rows[0]["model_no"].ToString();
                int currentInventory = Int32.Parse(Database.ExecuteMultiRowQuery(checkQuantity).Tables[0].Rows[0]["current_stock"].ToString());

                if (quantity < currentInventory)
                {

                    return true;
                }

                MessageBox.Show("Chosen quantity exceeds current stock");
                return false;

            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Item Not found");
                return false;
            }

            catch (Exception ex)
            {
                MessageBox.Show("An Error has occurred \n\n" + ex);
                return false;
            }

        }

        public static void addOrderItems(int order_ID, string model_no, int quantity)
        {

            string findSalePrice = $"SELECT sale_price FROM inventory WHERE model_no LIKE '{model_no}'";
            string findCostPrice = $"SELECT COST_PRICE FROM inventory WHERE model_no LIKE '{model_no}'";

            double salePrice = double.Parse(Database.ExecuteMultiRowQuery(findSalePrice).Tables[0].Rows[0]["sale_price"].ToString());
            double costPrice = double.Parse(Database.ExecuteMultiRowQuery(findCostPrice).Tables[0].Rows[0]["COST_PRICE"].ToString());

            double salePriceTotal = salePrice * quantity;
            double costPriceTotal = costPrice * quantity;
            double net = salePriceTotal - costPriceTotal;

            string addOrderItemQuery = $"INSERT INTO order_items VALUES({order_ID}, '{model_no}', {quantity}, {salePriceTotal}, {costPriceTotal}, {net})";

            Database.ExecuteNonQuery(addOrderItemQuery);

        }

        public static DataSet getAllOrders()
        {
            string query = "SELECT o.order_id, c.company_name, o.order_date, o.status, o.shipping_address FROM orders o INNER JOIN Customer c ON o.customer_id = c.customer_id";

            return Database.ExecuteMultiRowQuery(query);
        }

        public static DataSet findOrderByName(string searchQuery)
        {
            string query = $"SELECT o.order_id, c.company_name, o.order_date, o.status, o.shipping_address FROM orders o INNER JOIN Customer c ON o.customer_id = c.customer_id WHERE company_name LIKE '{searchQuery}%'";

            return Database.ExecuteMultiRowQuery(query);
        }

        public static DataSet viewOrderByDateDesc()
        {
            string query = $"SELECT o.order_id, c.company_name, o.order_date, o.status, o.shipping_address FROM orders o INNER JOIN Customer c ON o.customer_id = c.customer_id ORDER BY order_date DESC";

            return Database.ExecuteMultiRowQuery(query);
        }

        public static DataSet viewOrderByDateAsc()
        {
            string query = $"SELECT o.order_id, c.company_name, o.order_date, o.status, o.shipping_address FROM orders o INNER JOIN Customer c ON o.customer_id = c.customer_id ORDER BY order_date asc";

            return Database.ExecuteMultiRowQuery(query);
        }
    }
}
