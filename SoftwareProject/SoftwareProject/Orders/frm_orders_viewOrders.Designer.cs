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
            button_search = new Button();
            label2 = new Label();
            input_search = new TextBox();
            dataGrid = new DataGridView();
            button_dateAscending = new Button();
            button_dateDesc = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // button_search
            // 
            button_search.BackColor = Color.FromArgb(0, 192, 0);
            button_search.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_search.ForeColor = SystemColors.ActiveCaptionText;
            button_search.Location = new Point(852, 48);
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
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 18);
            label2.Name = "label2";
            label2.Size = new Size(295, 31);
            label2.TabIndex = 6;
            label2.Text = "Search by Customer Name";
            // 
            // input_search
            // 
            input_search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            input_search.Location = new Point(313, 18);
            input_search.Name = "input_search";
            input_search.Size = new Size(276, 34);
            input_search.TabIndex = 5;
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(12, 107);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowHeadersWidth = 51;
            dataGrid.Size = new Size(953, 416);
            dataGrid.TabIndex = 4;
            // 
            // button_dateAscending
            // 
            button_dateAscending.BackColor = Color.FromArgb(255, 192, 128);
            button_dateAscending.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_dateAscending.ForeColor = SystemColors.ActiveCaptionText;
            button_dateAscending.Location = new Point(12, 58);
            button_dateAscending.Name = "button_dateAscending";
            button_dateAscending.Size = new Size(113, 43);
            button_dateAscending.TabIndex = 8;
            button_dateAscending.Text = "Date Asc";
            button_dateAscending.UseVisualStyleBackColor = false;
            button_dateAscending.Click += button_dateAscending_Click;
            // 
            // button_dateDesc
            // 
            button_dateDesc.BackColor = Color.FromArgb(255, 255, 128);
            button_dateDesc.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_dateDesc.ForeColor = SystemColors.ActiveCaptionText;
            button_dateDesc.Location = new Point(131, 58);
            button_dateDesc.Name = "button_dateDesc";
            button_dateDesc.Size = new Size(124, 43);
            button_dateDesc.TabIndex = 9;
            button_dateDesc.Text = "Date desc";
            button_dateDesc.UseVisualStyleBackColor = false;
            button_dateDesc.Click += button_dateDesc_Click;
            // 
            // frm_orders_viewOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(997, 553);
            Controls.Add(button_dateDesc);
            Controls.Add(button_dateAscending);
            Controls.Add(button_search);
            Controls.Add(label2);
            Controls.Add(input_search);
            Controls.Add(dataGrid);
            Name = "frm_orders_viewOrders";
            Text = "View Orders";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_search;
        private Label label2;
        private TextBox input_search;
        private DataGridView dataGrid;
        private Button button_dateAscending;
        private Button button_dateDesc;
    }
}