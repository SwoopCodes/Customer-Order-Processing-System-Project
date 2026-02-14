using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace SoftwareProject.Properties
{
    public static class NavigationHelper
    {
        public static void ViewStockNavigation()
        {
            frm_inventory_viewStock viewStock = new frm_inventory_viewStock();
            viewStock.Show();
        }

        public static void manageStockNavigation()
        {
            frm_inventory_manageStock manageStock = new frm_inventory_manageStock();
            manageStock.Show();
        }

        public static void addStockNavigation()
        {
            frm_inventory_addStock addStock = new frm_inventory_addStock();
            addStock.Show();
        }

        public static void lowStockNavigation()
        {
            frm_inventory_lowStockAlerts lowStockAlerts = new frm_inventory_lowStockAlerts();
            lowStockAlerts.Show();
        }

        public static void viewCustomersNavigation()
        {
            frm_customers_viewCustomers viewCustomers = new frm_customers_viewCustomers();
            viewCustomers.Show();
        }

        public static void updateCustomersNavigation()
        {
            frm_updateCustomers updateCustomers = new frm_updateCustomers();
            updateCustomers.Show();
        }

        public static void addCustomerNavigation()
        {
            frm_customers_addCustomers addCustomers = new frm_customers_addCustomers();
            addCustomers.Show();
        }

        public static void viewOrdersNavigation()
        {
            frm_orders_viewOrders orders = new frm_orders_viewOrders();
            orders.Show();
        }

        public static void createOrderNavigation()
        {
            frm_orders_createOrder navigation = new frm_orders_createOrder();
            navigation.Show();
        }

        public static void modifyOrderNavigation()
        {
            frm_modifyOrder navigation = new frm_modifyOrder();
            navigation.Show();
        }

        public static void revenueAnalysisNavigation()
        {
            frm_finances_revenueAnalysis navigation = new frm_finances_revenueAnalysis();
            navigation.Show();
        }

        public static void addExistingNavigation(Form currentForm)
        {

            frm_addExistingStock addExistingStock = new frm_addExistingStock();
            addExistingStock.Show();
            currentForm.Close();
        }

        public static void addNewItemNavigation(Form currentForm)
        {
            frm_addNewItem addNewItem = new frm_addNewItem();
            addNewItem.Show();
            currentForm.Close();
        }
    }
}