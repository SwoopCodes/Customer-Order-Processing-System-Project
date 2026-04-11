using SoftwareProject.Properties;
using System;
using System.Windows.Forms;

namespace SoftwareProject
{
    public partial class frm_mainMenu : Form
    {
        public frm_mainMenu()
        {
            InitializeComponent();
        }

        private void mnu_inventory_viewStock_Click(object sender, EventArgs e)
        {
            NavigationHelper.ViewStockNavigation();
        }

        private void mnu_inventory_manageStock_Click(object sender, EventArgs e)
        {
            NavigationHelper.manageStockNavigation();
        }

        private void mnu_inventory_addStock_Click(object sender, EventArgs e)
        {
            NavigationHelper.addStockNavigation();
        }

        private void mnu_Inventory_lowStock_Click(object sender, EventArgs e)
        {
            NavigationHelper.lowStockNavigation();
        }

        private void mnu_customers_viewCustomer_Click(object sender, EventArgs e)
        {
            NavigationHelper.viewCustomersNavigation();
        }

        private void mnu_customer_updateCustomer_Click(object sender, EventArgs e)
        {
            NavigationHelper.updateCustomersNavigation();
        }

        private void mnu_customer_registerCustomer_Click(object sender, EventArgs e)
        {
            NavigationHelper.addCustomerNavigation();
        }

        private void mnu_orders_viewOrders_Click(object sender, EventArgs e)
        {
            NavigationHelper.viewOrdersNavigation();
        }

        private void mnu_orders_createOrder_Click(object sender, EventArgs e)
        {
            NavigationHelper.createOrderNavigation();
        }

        private void mnu_orders_modifyOrder_Click(object sender, EventArgs e)
        {
            NavigationHelper.modifyOrderNavigation();
        }

        private void mnu_finances_revenueAnalysis_Click(object sender, EventArgs e)
        {
            NavigationHelper.revenueAnalysisNavigation();
        }
    }
}
