namespace SoftwareProject
{
    partial class frm_mainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mainMenu));
            menuStrip1 = new MenuStrip();
            Mnu_Inventory = new ToolStripMenuItem();
            mnu_inventory_viewStock = new ToolStripMenuItem();
            mnu_inventory_manageStock = new ToolStripMenuItem();
            mnu_inventory_addStock = new ToolStripMenuItem();
            mnu_Inventory_lowStock = new ToolStripMenuItem();
            mnu_customers = new ToolStripMenuItem();
            mnu_customers_viewCustomer = new ToolStripMenuItem();
            mnu_customer_updateCustomer = new ToolStripMenuItem();
            mnu_customer_registerCustomer = new ToolStripMenuItem();
            mnu_orders = new ToolStripMenuItem();
            mnu_orders_viewOrders = new ToolStripMenuItem();
            mnu_orders_createOrder = new ToolStripMenuItem();
            mnu_orders_modifyOrder = new ToolStripMenuItem();
            mnu_finances = new ToolStripMenuItem();
            mnu_finances_revenueAnalysis = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { Mnu_Inventory, mnu_customers, mnu_orders, mnu_finances });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1824, 39);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "Menu Strip";
            // 
            // Mnu_Inventory
            // 
            Mnu_Inventory.DropDownItems.AddRange(new ToolStripItem[] { mnu_inventory_viewStock, mnu_inventory_manageStock, mnu_inventory_addStock, mnu_Inventory_lowStock });
            Mnu_Inventory.Name = "Mnu_Inventory";
            Mnu_Inventory.Size = new Size(123, 35);
            Mnu_Inventory.Text = "Inventory";
            // 
            // mnu_inventory_viewStock
            // 
            mnu_inventory_viewStock.Name = "mnu_inventory_viewStock";
            mnu_inventory_viewStock.Size = new Size(268, 36);
            mnu_inventory_viewStock.Text = "View Stock";
            mnu_inventory_viewStock.Click += mnu_inventory_viewStock_Click;
            // 
            // mnu_inventory_manageStock
            // 
            mnu_inventory_manageStock.Name = "mnu_inventory_manageStock";
            mnu_inventory_manageStock.Size = new Size(268, 36);
            mnu_inventory_manageStock.Text = "Manage Stock";
            mnu_inventory_manageStock.Click += mnu_inventory_manageStock_Click;
            // 
            // mnu_inventory_addStock
            // 
            mnu_inventory_addStock.Name = "mnu_inventory_addStock";
            mnu_inventory_addStock.Size = new Size(268, 36);
            mnu_inventory_addStock.Text = "Add Stock";
            mnu_inventory_addStock.Click += mnu_inventory_addStock_Click;
            // 
            // mnu_Inventory_lowStock
            // 
            mnu_Inventory_lowStock.Name = "mnu_Inventory_lowStock";
            mnu_Inventory_lowStock.Size = new Size(268, 36);
            mnu_Inventory_lowStock.Text = "Low Stock Alerts";
            mnu_Inventory_lowStock.Click += mnu_Inventory_lowStock_Click;
            // 
            // mnu_customers
            // 
            mnu_customers.DropDownItems.AddRange(new ToolStripItem[] { mnu_customers_viewCustomer, mnu_customer_updateCustomer, mnu_customer_registerCustomer });
            mnu_customers.Name = "mnu_customers";
            mnu_customers.Size = new Size(136, 35);
            mnu_customers.Text = "Customers";
            // 
            // mnu_customers_viewCustomer
            // 
            mnu_customers_viewCustomer.Name = "mnu_customers_viewCustomer";
            mnu_customers_viewCustomer.Size = new Size(289, 36);
            mnu_customers_viewCustomer.Text = "View Customers";
            mnu_customers_viewCustomer.Click += mnu_customers_viewCustomer_Click;
            // 
            // mnu_customer_updateCustomer
            // 
            mnu_customer_updateCustomer.Name = "mnu_customer_updateCustomer";
            mnu_customer_updateCustomer.Size = new Size(289, 36);
            mnu_customer_updateCustomer.Text = "Update Customer";
            mnu_customer_updateCustomer.Click += mnu_customer_updateCustomer_Click;
            // 
            // mnu_customer_registerCustomer
            // 
            mnu_customer_registerCustomer.Name = "mnu_customer_registerCustomer";
            mnu_customer_registerCustomer.Size = new Size(289, 36);
            mnu_customer_registerCustomer.Text = "Register Customer";
            mnu_customer_registerCustomer.Click += mnu_customer_registerCustomer_Click;
            // 
            // mnu_orders
            // 
            mnu_orders.DropDownItems.AddRange(new ToolStripItem[] { mnu_orders_viewOrders, mnu_orders_createOrder, mnu_orders_modifyOrder });
            mnu_orders.Name = "mnu_orders";
            mnu_orders.Size = new Size(97, 35);
            mnu_orders.Text = "Orders";
            // 
            // mnu_orders_viewOrders
            // 
            mnu_orders_viewOrders.Name = "mnu_orders_viewOrders";
            mnu_orders_viewOrders.Size = new Size(305, 36);
            mnu_orders_viewOrders.Text = "View current Orders";
            mnu_orders_viewOrders.Click += mnu_orders_viewOrders_Click;
            // 
            // mnu_orders_createOrder
            // 
            mnu_orders_createOrder.Name = "mnu_orders_createOrder";
            mnu_orders_createOrder.Size = new Size(305, 36);
            mnu_orders_createOrder.Text = "Create Order";
            mnu_orders_createOrder.Click += mnu_orders_createOrder_Click;
            // 
            // mnu_orders_modifyOrder
            // 
            mnu_orders_modifyOrder.Name = "mnu_orders_modifyOrder";
            mnu_orders_modifyOrder.Size = new Size(305, 36);
            mnu_orders_modifyOrder.Text = "Order Details";
            mnu_orders_modifyOrder.Click += mnu_orders_modifyOrder_Click;
            // 
            // mnu_finances
            // 
            mnu_finances.DropDownItems.AddRange(new ToolStripItem[] { mnu_finances_revenueAnalysis });
            mnu_finances.Name = "mnu_finances";
            mnu_finances.Size = new Size(116, 35);
            mnu_finances.Text = "Finances";
            // 
            // mnu_finances_revenueAnalysis
            // 
            mnu_finances_revenueAnalysis.Name = "mnu_finances_revenueAnalysis";
            mnu_finances_revenueAnalysis.Size = new Size(343, 36);
            mnu_finances_revenueAnalysis.Text = "Yearly Revenue Analysis";
            mnu_finances_revenueAnalysis.Click += mnu_finances_revenueAnalysis_Click;
            // 
            // frm_mainMenu
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1824, 866);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frm_mainMenu";
            Text = "Main Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem Mnu_Inventory;
        private ToolStripMenuItem mnu_inventory_viewStock;
        private ToolStripMenuItem mnu_inventory_manageStock;
        private ToolStripMenuItem mnu_inventory_addStock;
        private ToolStripMenuItem mnu_Inventory_lowStock;
        private ToolStripMenuItem mnu_customers;
        private ToolStripMenuItem mnu_customers_viewCustomer;
        private ToolStripMenuItem mnu_customer_updateCustomer;
        private ToolStripMenuItem mnu_customer_registerCustomer;
        private ToolStripMenuItem mnu_orders;
        private ToolStripMenuItem mnu_orders_viewOrders;
        private ToolStripMenuItem mnu_orders_createOrder;
        private ToolStripMenuItem mnu_orders_modifyOrder;
        private ToolStripMenuItem mnu_finances;
        private ToolStripMenuItem mnu_finances_revenueAnalysis;
    }
}
