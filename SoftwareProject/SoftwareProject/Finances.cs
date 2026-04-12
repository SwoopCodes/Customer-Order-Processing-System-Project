using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SoftwareProject
{
    public class FinancesData
    {

       

        public static double getTotalInventoryValue()
        {

            string query = "SELECT SUM(current_stock * Cost_price) as total_inventory FROM inventory";

            DataSet totalInventoryValue = Database.ExecuteMultiRowQuery(query);

            string convertedInventoryValue = totalInventoryValue.Tables[0].Rows[0]["total_inventory"].ToString();

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
                            FROM (
                                SELECT o.order_ID, SUM(oi.TOTAL) AS order_total 
                                FROM orders o 
                                JOIN order_items oi ON o.order_id = oi.order_id 
                                WHERE o.order_date >= trunc(sysdate, 'YEAR') 
                                AND o.status NOT IN ('D') 
                                GROUP BY o.order_ID
                            )";

            DataSet averageOrderValue = Database.ExecuteMultiRowQuery(query);

            string convertedAvgOrderValue = averageOrderValue.Tables[0].Rows[0]["avg_value"].ToString();

            return Convert.ToDouble(convertedAvgOrderValue);
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

        public static double getTotalCostOfItems()
        {

            string query = @"SELECT sum(cost) FROM order_items oi
                            JOIN orders o ON o.order_id = oi.order_id
                            WHERE o.order_date >= trunc(sysdate, 'Year')
                            AND o.status NOT IN ('D')";

            DataSet totalOrderCostValue = Database.ExecuteMultiRowQuery(query);
            string convertedTotalOrderCostValue = totalOrderCostValue.Tables[0].Rows[0]["sum(cost)"].ToString();

            return Convert.ToDouble(convertedTotalOrderCostValue);
        }

        public static double totalProfit()
        {

            double totalProfit = getTotalOrderValue();
            double totalCost = getTotalCostOfItems();

            

            return totalProfit - totalCost;

        }

        public static void LoadChart(string year, Chart chart)
        {
            string query = $@"SELECT SUM(oi.TOTAL), TO_CHAR(o.ORDER_DATE, 'MM')
                           FROM Orders o JOIN Order_Items oi ON o.ORDER_ID = oi.ORDER_ID
                           WHERE TO_CHAR(o.ORDER_DATE, 'YYYY') = '{year}'
                           GROUP BY TO_CHAR(o.ORDER_DATE, 'MM')
                           ORDER BY TO_CHAR(o.ORDER_DATE, 'MM')";

            DataSet ds = Database.ExecuteMultiRowQuery(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No sales data found for " + year, "No Data",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                chart.Visible = false;
                return;
            }

            string[] months = { "JAN", "FEB", "MAR", "APR", "MAY", "JUN",
                         "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };
            decimal[] amounts = new decimal[12]; 

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                int monthIndex = Convert.ToInt32(ds.Tables[0].Rows[i][1]) - 1;
                amounts[monthIndex] = Convert.ToDecimal(ds.Tables[0].Rows[i][0]);
            }

            chart.Series[0].Points.Clear();

            chart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            chart.ChartAreas[0].AxisX.Interval = 1;

            chart.Series[0].LegendText = "Sales Total";
            chart.Series[0].Label = "€#VALY";

            chart.Titles.Add("Sales Analysis " + year);
            chart.ChartAreas[0].AxisX.Title = "Month";
            chart.ChartAreas[0].AxisY.Title = "Total Sales";

            chart.Series[0].Points.DataBindXY(months, amounts);

            chart.Visible = true;
        }



    }
}
