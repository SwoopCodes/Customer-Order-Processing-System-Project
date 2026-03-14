namespace SoftwareProject
{
    partial class frm_inventory_manageStock
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
            label1 = new Label();
            Input_ModelNo = new TextBox();
            panel1 = new Panel();
            label6 = new Label();
            Input_CostPrice = new TextBox();
            label7 = new Label();
            Input_Supplier = new TextBox();
            label5 = new Label();
            Input_SalePrice = new TextBox();
            label2 = new Label();
            Input_MinStock = new TextBox();
            label3 = new Label();
            Input_CurrentStock = new TextBox();
            Input_Description = new RichTextBox();
            label4 = new Label();
            Button_Cancel = new Button();
            Button_Update = new Button();
            Button_Delete = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button_search
            // 
            button_search.BackColor = Color.FromArgb(255, 192, 128);
            button_search.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_search.ForeColor = SystemColors.ActiveCaptionText;
            button_search.Location = new Point(517, 15);
            button_search.Name = "button_search";
            button_search.Size = new Size(151, 47);
            button_search.TabIndex = 13;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 18);
            label1.Name = "label1";
            label1.Size = new Size(196, 41);
            label1.TabIndex = 12;
            label1.Text = "Description: ";
            // 
            // Input_ModelNo
            // 
            Input_ModelNo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Input_ModelNo.Location = new Point(251, 21);
            Input_ModelNo.Name = "Input_ModelNo";
            Input_ModelNo.Size = new Size(224, 38);
            Input_ModelNo.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(Input_CostPrice);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(Input_Supplier);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(Input_SalePrice);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Input_MinStock);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Input_CurrentStock);
            panel1.Controls.Add(Input_Description);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(21, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 321);
            panel1.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(385, 184);
            label6.Name = "label6";
            label6.Size = new Size(157, 41);
            label6.TabIndex = 27;
            label6.Text = "Cost Price";
            // 
            // Input_CostPrice
            // 
            Input_CostPrice.BackColor = SystemColors.GrayText;
            Input_CostPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Input_CostPrice.Location = new Point(571, 184);
            Input_CostPrice.Name = "Input_CostPrice";
            Input_CostPrice.ReadOnly = true;
            Input_CostPrice.Size = new Size(148, 38);
            Input_CostPrice.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(22, 247);
            label7.Name = "label7";
            label7.Size = new Size(137, 41);
            label7.TabIndex = 25;
            label7.Text = "Supplier";
            // 
            // Input_Supplier
            // 
            Input_Supplier.BackColor = SystemColors.GrayText;
            Input_Supplier.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Input_Supplier.Location = new Point(208, 247);
            Input_Supplier.Name = "Input_Supplier";
            Input_Supplier.ReadOnly = true;
            Input_Supplier.Size = new Size(254, 38);
            Input_Supplier.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 187);
            label5.Name = "label5";
            label5.Size = new Size(153, 41);
            label5.TabIndex = 23;
            label5.Text = "Sale Price";
            // 
            // Input_SalePrice
            // 
            Input_SalePrice.BackColor = SystemColors.GrayText;
            Input_SalePrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Input_SalePrice.Location = new Point(208, 187);
            Input_SalePrice.Name = "Input_SalePrice";
            Input_SalePrice.ReadOnly = true;
            Input_SalePrice.Size = new Size(148, 38);
            Input_SalePrice.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 132);
            label2.Name = "label2";
            label2.Size = new Size(364, 41);
            label2.TabIndex = 21;
            label2.Text = "Minimum Stock Allowed";
            // 
            // Input_MinStock
            // 
            Input_MinStock.BackColor = SystemColors.GrayText;
            Input_MinStock.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Input_MinStock.Location = new Point(402, 135);
            Input_MinStock.Name = "Input_MinStock";
            Input_MinStock.ReadOnly = true;
            Input_MinStock.Size = new Size(109, 38);
            Input_MinStock.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 76);
            label3.Name = "label3";
            label3.Size = new Size(210, 41);
            label3.TabIndex = 19;
            label3.Text = "Current Stock";
            // 
            // Input_CurrentStock
            // 
            Input_CurrentStock.BackColor = SystemColors.GrayText;
            Input_CurrentStock.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Input_CurrentStock.Location = new Point(261, 79);
            Input_CurrentStock.Name = "Input_CurrentStock";
            Input_CurrentStock.ReadOnly = true;
            Input_CurrentStock.Size = new Size(109, 38);
            Input_CurrentStock.TabIndex = 18;
            // 
            // Input_Description
            // 
            Input_Description.BackColor = SystemColors.GrayText;
            Input_Description.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Input_Description.Location = new Point(208, 24);
            Input_Description.Name = "Input_Description";
            Input_Description.ReadOnly = true;
            Input_Description.Size = new Size(433, 37);
            Input_Description.TabIndex = 16;
            Input_Description.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 20);
            label4.Name = "label4";
            label4.Size = new Size(180, 41);
            label4.TabIndex = 15;
            label4.Text = "Description";
            // 
            // Button_Cancel
            // 
            Button_Cancel.BackColor = Color.FromArgb(255, 192, 128);
            Button_Cancel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_Cancel.ForeColor = SystemColors.ActiveCaptionText;
            Button_Cancel.Location = new Point(604, 410);
            Button_Cancel.Name = "Button_Cancel";
            Button_Cancel.Size = new Size(151, 76);
            Button_Cancel.TabIndex = 16;
            Button_Cancel.Text = "Cancel";
            Button_Cancel.UseVisualStyleBackColor = false;
            Button_Cancel.Click += Button_Cancel_Click;
            // 
            // Button_Update
            // 
            Button_Update.BackColor = Color.FromArgb(128, 255, 128);
            Button_Update.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_Update.Location = new Point(271, 410);
            Button_Update.Name = "Button_Update";
            Button_Update.Size = new Size(151, 76);
            Button_Update.TabIndex = 15;
            Button_Update.Text = "Update";
            Button_Update.UseVisualStyleBackColor = false;
            Button_Update.Click += Button_Update_Click;
            // 
            // Button_Delete
            // 
            Button_Delete.BackColor = Color.FromArgb(255, 128, 128);
            Button_Delete.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_Delete.Location = new Point(437, 410);
            Button_Delete.Name = "Button_Delete";
            Button_Delete.Size = new Size(151, 76);
            Button_Delete.TabIndex = 17;
            Button_Delete.Text = "Delete";
            Button_Delete.UseVisualStyleBackColor = false;
            Button_Delete.Click += Button_Delete_Click;
            // 
            // frm_inventory_manageStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(787, 498);
            Controls.Add(Button_Delete);
            Controls.Add(Button_Cancel);
            Controls.Add(Button_Update);
            Controls.Add(panel1);
            Controls.Add(button_search);
            Controls.Add(label1);
            Controls.Add(Input_ModelNo);
            Name = "frm_inventory_manageStock";
            Text = "Manage Stock";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_search;
        private Label label1;
        private TextBox Input_ModelNo;
        private Panel panel1;
        private RichTextBox Input_Description;
        private Label label4;
        private Label label6;
        private TextBox Input_CostPrice;
        private Label label7;
        private TextBox Input_Supplier;
        private Label label5;
        private TextBox Input_SalePrice;
        private Label label2;
        private TextBox Input_MinStock;
        private Label label3;
        private TextBox Input_CurrentStock;
        private Button Button_Cancel;
        private Button Button_Update;
        private Button Button_Delete;
    }
}