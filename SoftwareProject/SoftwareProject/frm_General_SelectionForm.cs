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

            if (category == "Inventory")
            {

                dataGridView.DataSource = Inventory.findItemToUpdate(query).Tables[0];

            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataRowView selectedRowView = (DataRowView)dataGridView.Rows[e.RowIndex].DataBoundItem;
                DataRow selectedRow = selectedRowView.Row;
                this.selectedItem = selectedRow;
                this.Close();
            }
        }
    }
}
