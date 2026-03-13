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

            Label_InventoryValue.Text = "€" + Finances.getTotalInventoryValue().ToString();
            Label_totalOrders.Text = Finances.getTotalOrdersYTD().ToString();
            Label_AverageOrderValue.Text = "€" + Finances.getAverageOrderValue().ToString();
            Label_totalOrderValue.Text = "€" + Finances.getTotalOrderValue().ToString();
            Label_CostOfItemsSold.Text = "-€" + Finances.getTotalCostOfItems().ToString();
            Label_TotalProfit.Text = "€" + Finances.totalProfit().ToString();
        }
    }
}
