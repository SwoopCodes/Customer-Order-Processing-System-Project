using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SoftwareProject
{
    public partial class frm_inventory_lowStockAlerts : Form
    {
        public frm_inventory_lowStockAlerts()
        {
            InitializeComponent();
            dataGrid.DataSource = Inventory.viewLowStock().Tables[0];
        }

        private void frm_inventory_lowStockAlerts_Load(object sender, EventArgs e)
        {

        }
    }
}
