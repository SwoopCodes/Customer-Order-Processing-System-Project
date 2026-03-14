namespace SoftwareProject
{
    partial class frm_inventory_viewStock
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
            dataGrid = new DataGridView();
            input_search = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button_search = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(31, 134);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowHeadersWidth = 51;
            dataGrid.Size = new Size(953, 416);
            dataGrid.TabIndex = 0;
            // 
            // input_search
            // 
            input_search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            input_search.Location = new Point(31, 84);
            input_search.Name = "input_search";
            input_search.Size = new Size(276, 34);
            input_search.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 45);
            label1.Name = "label1";
            label1.Size = new Size(225, 28);
            label1.TabIndex = 2;
            label1.Text = "Search by product name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 32);
            label2.Name = "label2";
            label2.Size = new Size(387, 41);
            label2.TabIndex = 2;
            label2.Text = "Search by product name";
            // 
            // button_search
            // 
            button_search.BackColor = Color.FromArgb(0, 192, 0);
            button_search.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_search.ForeColor = SystemColors.ActiveCaptionText;
            button_search.Location = new Point(871, 75);
            button_search.Name = "button_search";
            button_search.Size = new Size(113, 43);
            button_search.TabIndex = 3;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // frm_inventory_viewStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1013, 587);
            Controls.Add(button_search);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(input_search);
            Controls.Add(dataGrid);
            Name = "frm_inventory_viewStock";
            Text = "View Stock";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGrid;
        private TextBox input_search;
        private Label label1;
        private Label label2;
        private Button button_search;
    }
}