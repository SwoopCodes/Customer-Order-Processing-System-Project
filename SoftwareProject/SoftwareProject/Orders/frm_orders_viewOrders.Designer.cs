using System.Drawing;
using System.Windows.Forms;

namespace SoftwareProject
{
    partial class frm_orders_viewOrders
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
            this.button_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.input_search = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_search.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_search.Location = new System.Drawing.Point(639, 31);
            this.button_search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(85, 35);
            this.button_search.TabIndex = 7;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search by Customer Name";
            // 
            // input_search
            // 
            this.input_search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_search.Location = new System.Drawing.Point(259, 30);
            this.input_search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.input_search.Name = "input_search";
            this.input_search.Size = new System.Drawing.Size(208, 29);
            this.input_search.TabIndex = 5;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(9, 70);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.Size = new System.Drawing.Size(715, 270);
            this.dataGrid.TabIndex = 4;
            // 
            // frm_orders_viewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(748, 359);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_search);
            this.Controls.Add(this.dataGrid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_orders_viewOrders";
            this.Text = "View Orders";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_search;
        private Label label2;
        private TextBox input_search;
        private DataGridView dataGrid;
    }
}