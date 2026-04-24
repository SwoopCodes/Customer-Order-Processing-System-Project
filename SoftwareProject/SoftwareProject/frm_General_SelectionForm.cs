using Oracle.ManagedDataAccess.Client;
using OracleInternal.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareProject.Finances
{
    public partial class frm_General_SelectionForm : Form
    {

        public DataRow selectedItem;
        public frm_General_SelectionForm(string category, string query)
        {

            InitializeComponent();

            try
            {
                if (category == "Inventory")
                {
                    dataGridView.DataSource = Inventory.findItemToUpdate(query).Tables[0];
                }

                if (category == "Customers")
                {
                    dataGridView.DataSource = Customers.findCustomer(query).Tables[0];
                }

                if (category == "Orders")
                {
                    dataGridView.DataSource = Order.findOrderByName(query).Tables[0];
                }
            } catch(OracleException ex)
            {
                if(ex.Number == 933)
                {
                    MessageBox.Show("No special chars");
                }
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow currentRow = dataGridView.Rows[e.RowIndex];
                DataRowView rowData = (DataRowView)currentRow.DataBoundItem;
                DataRow selectedDataRow = rowData.Row;

                this.selectedItem = selectedDataRow;
                this.Close();
            }
        }
    }
}
