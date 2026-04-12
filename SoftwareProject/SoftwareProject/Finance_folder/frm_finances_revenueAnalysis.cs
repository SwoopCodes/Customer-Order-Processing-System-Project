using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SoftwareProject
{
    public partial class frm_finances_revenueAnalysis : Form
    {
        public frm_finances_revenueAnalysis()
        {
            InitializeComponent();

            Label_InventoryValue.Text = "€" + FinancesData.getTotalInventoryValue().ToString();
            Label_totalOrders.Text = FinancesData.getTotalOrdersYTD().ToString();
            Label_AverageOrderValue.Text = "€" + FinancesData.getAverageOrderValue().ToString();
            Label_totalOrderValue.Text = "€" + FinancesData.getTotalOrderValue().ToString();
            Label_CostOfItemsSold.Text = "-€" + FinancesData.getTotalCostOfItems().ToString();
            Label_TotalProfit.Text = "€" + FinancesData.totalProfit().ToString();

        }

        private void frm_finances_revenueAnalysis_Load(object sender, EventArgs e)
        {
            string yearQuery = "SELECT EXTRACT(YEAR FROM MIN(ORDER_DATE)) FROM Orders";
            DataSet ds = Database.ExecuteMultiRowQuery(yearQuery);

            if (ds.Tables[0].Rows.Count > 0)
            {
                int minYear = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                int currentYear = DateTime.Now.Year;

                for (int y = minYear; y <= currentYear; y++)
                {
                    comboBox1.Items.Add(y.ToString());
                }
            }

            chart1.Visible = false;
        }

        private void extractYearComboBox(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedYear = comboBox1.SelectedItem.ToString();
                FinancesData.LoadChart(selectedYear, chart1);
            }
        }

        private void button_filter_Click(object sender, EventArgs e)
        {
            extractYearComboBox(sender, e);
        }
    }
}
