using System.Drawing;
using System.Windows.Forms;

namespace SoftwareProject
{
    partial class frm_customers_viewCustomers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_search = new Button();
            label2 = new Label();
            input_search = new TextBox();
            dataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // button_search
            // 
            button_search.BackColor = Color.FromArgb(0, 192, 0);
            button_search.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_search.ForeColor = SystemColors.ActiveCaptionText;
            button_search.Location = new Point(801, 66);
            button_search.Name = "button_search";
            button_search.Size = new Size(113, 43);
            button_search.TabIndex = 7;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(84, 36);
            label2.Name = "label2";
            label2.Size = new Size(243, 28);
            label2.TabIndex = 6;
            label2.Text = "Search by Company Name";
            // 
            // input_search
            // 
            input_search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            input_search.Location = new Point(84, 75);
            input_search.Name = "input_search";
            input_search.Size = new Size(276, 34);
            input_search.TabIndex = 5;
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(84, 123);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowHeadersWidth = 51;
            dataGrid.Size = new Size(830, 416);
            dataGrid.TabIndex = 4;
            // 
            // frm_customers_viewCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(982, 573);
            Controls.Add(button_search);
            Controls.Add(label2);
            Controls.Add(input_search);
            Controls.Add(dataGrid);
            Name = "frm_customers_viewCustomers";
            Text = "View Customers";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_search;
        private Label label2;
        private TextBox input_search;
        private DataGridView dataGrid;
    }
}