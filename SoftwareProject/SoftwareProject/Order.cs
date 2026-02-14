using System;
using System.Collections.Generic;
using System.Data;
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
            String companyQuery = $"SELECT company_name FROM customer WHERE company_name LIKE '%{searchItem}%'";
            String addressQuery = $"SELECT address FROM customer WHERE company_name LIKE '%{searchItem}%'";

            companyName.Text = Database.ExecuteMultiRowQuery(companyQuery).Tables[0].Rows[0]["company_name"].ToString();
            companyAddress.Text = Database.ExecuteMultiRowQuery(addressQuery).Tables[0].Rows[0]["address"].ToString();

        }
    }
}
