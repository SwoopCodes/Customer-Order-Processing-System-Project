using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace SoftwareProject
{
    public class Finances
    {

       

        public static double getTotalInventoryValue()
        {

            string query = "SELECT SUM(cost_price) FROM inventory";

            DataSet totalInventoryValue = Database.ExecuteMultiRowQuery(query);

            string convertedInventoryValue = totalInventoryValue.Tables[0].Rows[0]["SUM(cost_price)"].ToString();

            return Convert.ToDouble(convertedInventoryValue);


        }

        public static int getTotalOrdersYTD()
        {

            string query = @"SELECT COUNT(*) FROM orders
                            WHERE order_date >= trunc(sysdate, 'YEAR')";

            DataSet totalOrders = Database.ExecuteMultiRowQuery(query);

            string convertedTotalorders = totalOrders.Tables[0].Rows[0]["COUNT(*)"].ToString();

            return Convert.ToInt32(convertedTotalorders);
        }

        public static double getAverageOrderValue()
        {

            string query = @"SELECT ROUND(AVG(order_total), 2) as avg_value 
                     FROM (SELECT o.order_ID, SUM(oi.total) AS order_total 
                           FROM orders o 
                           JOIN order_items oi ON o.order_id = oi.order_id 
                           WHERE o.order_date >= trunc(sysdate, 'YEAR') 
                           AND o.status NOT IN ('D') 
                           GROUP BY o.order_ID)";

            DataSet averageOrderValue = Database.ExecuteMultiRowQuery(query);

            string convertedAvgOrderValue = averageOrderValue.Tables[0].Rows[0]["avg_value"].ToString();

            return Double.Round(Convert.ToDouble(convertedAvgOrderValue), 2);
        }

        public static double getTotalOrderValue()
        {

            string query = @"SELECT sum(total) FROM orders o
                            JOIN order_items oi ON o.order_id = oi.order_id
                            WHERE o.order_date >= trunc(sysdate, 'Year')
                            AND o.status NOT IN ('D')";

            DataSet totalOrderValue = Database.ExecuteMultiRowQuery(query);
            string convertedTotalOrderValue = totalOrderValue.Tables[0].Rows[0]["sum(total)"].ToString();
                

            return Convert.ToDouble(convertedTotalOrderValue);
        }



    }
}
