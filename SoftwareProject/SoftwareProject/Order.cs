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

        public static bool findCompany(String searchItem, TextBox companyName, TextBox companyAddress)
        {
            string query = $" SELECT company_name, address FROM customer WHERE company_name LIKE '{searchItem}%' ORDER BY company_name";

            var result = Database.ExecuteMultiRowQuery(query);

            try
            {
                companyName.Text = result.Tables[0].Rows[0]["company_name"].ToString();
                companyAddress.Text = result.Tables[0].Rows[0]["address"].ToString();
                return true;
            }
            catch (Exception e)
            {
                return false;
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
            string query = $"SELECT o.order_id, c.company_name, o.order_date, o.status, o.shipping_address FROM orders o INNER JOIN Customer c ON o.customer_id = c.customer_id WHERE LOWER(company_name) LIKE '{searchQuery.ToLower()}%'";

            DataSet orderSet = Database.ExecuteMultiRowQuery(query);

            if (orderSet.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show($"No orders found with company {searchQuery}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

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

        public static DataSet retrieveOrderItems(string order_id)
        {
            String query = $"SELECT * FROM order_items WHERE order_id = {order_id}";

            return Database.ExecuteMultiRowQuery(query);
        }

        public static void viewOrderDetails(Int32 order_id, TextBox customerNameBox, TextBox shippingAddressBox, DataGridView itemsTable ,Button markComplete, Button removeOrder)
        {
            String companyNameQuery = $"SELECT c.company_name FROM orders o INNER JOIN Customer c ON o.customer_id = c.customer_id WHERE order_id = {order_id}";
            String shippingAddressQuery = $"SELECT shipping_address FROM orders WHERE order_id = {order_id}";
            String retrieveOrderItemsQuery = $"SELECT oi.model_no, i.description, oi.quantity, oi.total FROM order_items oi INNER JOIN inventory i ON oi.model_no = i.model_no WHERE order_id = {order_id}";

            customerNameBox.Text = Database.ExecuteMultiRowQuery(companyNameQuery).Tables[0].Rows[0]["company_name"].ToString();
            shippingAddressBox.Text = Database.ExecuteMultiRowQuery(shippingAddressQuery).Tables[0].Rows[0]["shipping_address"].ToString();
            markComplete.Enabled = true;
            markComplete.BackColor = Color.FromArgb(152, 251, 152);

            removeOrder.Enabled = true;
            removeOrder.BackColor = Color.FromArgb(233, 150, 122);

            itemsTable.DataSource = Database.ExecuteMultiRowQuery(retrieveOrderItemsQuery).Tables[0];
        }

        public static void markOrderComplete(Int32 orderID) 
        {
            try
            {
                string updateStatusQuery = $"UPDATE orders SET status = 'C' WHERE order_ID = {orderID}";
                Database.ExecuteUpdateStatement(updateStatusQuery);
                MessageBox.Show("Status successfully updated");
            }
            catch (Exception e)
            {
                MessageBox.Show("an error occured\n" + e);
            }
        }

        public static void removeOrder(Int32 orderID)
        {
            try
            {
                string updateStatusQuery = $"UPDATE orders SET status = 'D' WHERE order_ID = {orderID}";
                Database.ExecuteUpdateStatement(updateStatusQuery);
                MessageBox.Show("Order successfully removed");
            }
            catch (Exception e)
            {
                MessageBox.Show("an error occured\n" + e);
            }
        }

        public static void getOrderTotal(Int32 orderID, Label orderTotalField)
        {
            string findOrderTotalQuery = $"SELECT SUM(total) AS total FROM order_items WHERE order_ID = {orderID}";
            orderTotalField.Text += Database.ExecuteMultiRowQuery(findOrderTotalQuery).Tables[0].Rows[0]["total"].ToString();
            orderTotalField.Visible = true;
        }

        public static void displayOrderStatus(Int32 orderID, Label statusText) 
        {
            string findStatusQuery = $"SELECT status FROM orders WHERE order_ID = {orderID}";
            string currentStatus = Database.ExecuteMultiRowQuery(findStatusQuery).Tables[0].Rows[0]["status"].ToString();

            if (currentStatus == "A") 
            {
                statusText.Visible = true;
                statusText.Text += "Active";
            } else if (currentStatus == "C")
            {
                statusText.Visible = true;
                statusText.Text += "Completed";
            }
            else
            {
                statusText.Visible = true;
                statusText.Text += "Removed";
            }
        }
    }
}
