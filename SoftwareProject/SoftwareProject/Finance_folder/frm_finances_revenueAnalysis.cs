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
    }
}
