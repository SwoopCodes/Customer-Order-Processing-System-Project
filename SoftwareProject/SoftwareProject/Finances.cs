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

        public static double getPotentialInventoryProfit()
        {
            string query = "SELECT SUM(current_stock * sale_price) as TOTAL_SALEVALUE FROM inventory";

            DataSet totalInventorySaleValue = Database.ExecuteMultiRowQuery(query);

            double convertedTotalInventorySaleValue = Convert.ToDouble(totalInventorySaleValue.Tables[0].Rows[0]["TOTAL_SALEVALUE"]);
            double totalInventoryValue = getTotalInventoryValue();

            return Convert.ToDouble(convertedTotalInventorySaleValue - totalInventoryValue);


        }

        public static int getTotalOrders(String year)
        {

            string query = $@"SELECT COUNT(DISTINCT ORDER_ID) AS TOTAL_ORDERS
                            FROM ORDERS
                            WHERE EXTRACT(YEAR FROM ORDER_DATE) = {2026}";

            DataSet totalOrders = Database.ExecuteMultiRowQuery(query);

            string convertedTotalorders = totalOrders.Tables[0].Rows[0]["total_orders"].ToString();

            return Convert.ToInt32(convertedTotalorders);
        }

        public static double getAverageOrderValue(String year)
        {

            string query = $@"SELECT ROUND(SUM(OI.TOTAL) / COUNT(DISTINCT OI.ORDER_ID), 2) AS AVG_ORDER_VALUE
                            FROM ORDER_ITEMS OI
                            JOIN ORDERS O ON OI.ORDER_ID = O.ORDER_ID
                            WHERE EXTRACT(YEAR FROM O.ORDER_DATE) = {year}";

            DataSet averageOrderValue = Database.ExecuteMultiRowQuery(query);

            string convertedAvgOrderValue = averageOrderValue.Tables[0].Rows[0]["AVG_ORDER_VALUE"].ToString();

            return Convert.ToDouble(convertedAvgOrderValue);
        }

        public static double getTotalOrderValue(String year)
        {

            string query = $@"SELECT ROUND(SUM(OI.TOTAL), 2) AS TOTAL_REVENUE
                            FROM ORDER_ITEMS OI
                            JOIN ORDERS O ON OI.ORDER_ID = O.ORDER_ID
                            WHERE EXTRACT(YEAR FROM O.ORDER_DATE) = {year}
                            AND o.status NOT IN ('D')";

            DataSet totalOrderValue = Database.ExecuteMultiRowQuery(query);
            string convertedTotalOrderValue = totalOrderValue.Tables[0].Rows[0]["TOTAL_REVENUE"].ToString();
                

            return Convert.ToDouble(convertedTotalOrderValue);
        }  

        public static double getTotalCostOfItems(String year)
        {

            string query = $@"SELECT ROUND(SUM(OI.COST), 2) AS TOTAL_COST
                            FROM ORDER_ITEMS OI
                            JOIN ORDERS O ON OI.ORDER_ID = O.ORDER_ID
                            WHERE EXTRACT(YEAR FROM O.ORDER_DATE) = {year}
                            AND o.status NOT IN ('D')";

            DataSet totalOrderCostValue = Database.ExecuteMultiRowQuery(query);
            string convertedTotalOrderCostValue = totalOrderCostValue.Tables[0].Rows[0]["TOTAL_COST"].ToString();

            return Convert.ToDouble(convertedTotalOrderCostValue);
        }

        public static double totalProfit(String year)
        {

            double totalProfit = getTotalOrderValue(year);
            double totalCost = getTotalCostOfItems(year);

            

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

            string[] months = { "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };
            decimal[] amounts = new decimal[12]; 

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                int monthIndex = Convert.ToInt32(ds.Tables[0].Rows[i][1]) - 1;
                amounts[monthIndex] = Convert.ToDecimal(ds.Tables[0].Rows[i][0]);
            }

            chart.Series[0].Points.Clear();

            chart.ChartAreas[0].AxisX.Interval = 1;

            chart.Series[0].LegendText = "Sales Total";
            chart.Series[0].Label = "€#VALY";

            chart.Titles.Clear();
            chart.Titles.Add("Sales Analysis " + year);
            chart.ChartAreas[0].AxisX.Title = "Month";
            chart.ChartAreas[0].AxisY.Title = "Total Sales";

            chart.Series[0].Points.DataBindXY(months, amounts);

            chart.Visible = true;
        }



    }
}
