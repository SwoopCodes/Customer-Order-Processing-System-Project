using System.Drawing;
using System.Windows.Forms;

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
            this.button_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Input_ModelNo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Input_CostPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Input_Supplier = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Input_SalePrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Input_MinStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Input_CurrentStock = new System.Windows.Forms.TextBox();
            this.Input_Description = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Update = new System.Windows.Forms.Button();
            this.Input_searchQuery = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_search.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_search.Location = new System.Drawing.Point(513, 28);
            this.button_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(151, 49);
            this.button_search.TabIndex = 13;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 41);
            this.label1.TabIndex = 12;
            this.label1.Text = "Model No: ";
            // 
            // Input_ModelNo
            // 
            this.Input_ModelNo.BackColor = System.Drawing.SystemColors.GrayText;
            this.Input_ModelNo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_ModelNo.Location = new System.Drawing.Point(210, 14);
            this.Input_ModelNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_ModelNo.Name = "Input_ModelNo";
            this.Input_ModelNo.ReadOnly = true;
            this.Input_ModelNo.Size = new System.Drawing.Size(224, 38);
            this.Input_ModelNo.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Input_CostPrice);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Input_Supplier);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Input_ModelNo);
            this.panel1.Controls.Add(this.Input_SalePrice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Input_MinStock);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Input_CurrentStock);
            this.panel1.Controls.Add(this.Input_Description);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(21, 81);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 282);
            this.panel1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(387, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 41);
            this.label6.TabIndex = 27;
            this.label6.Text = "Cost Price";
            // 
            // Input_CostPrice
            // 
            this.Input_CostPrice.BackColor = System.Drawing.SystemColors.GrayText;
            this.Input_CostPrice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_CostPrice.Location = new System.Drawing.Point(573, 179);
            this.Input_CostPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_CostPrice.Name = "Input_CostPrice";
            this.Input_CostPrice.ReadOnly = true;
            this.Input_CostPrice.Size = new System.Drawing.Size(148, 38);
            this.Input_CostPrice.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 41);
            this.label7.TabIndex = 25;
            this.label7.Text = "Supplier";
            // 
            // Input_Supplier
            // 
            this.Input_Supplier.BackColor = System.Drawing.SystemColors.GrayText;
            this.Input_Supplier.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Supplier.Location = new System.Drawing.Point(210, 230);
            this.Input_Supplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_Supplier.Name = "Input_Supplier";
            this.Input_Supplier.ReadOnly = true;
            this.Input_Supplier.Size = new System.Drawing.Size(254, 38);
            this.Input_Supplier.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 41);
            this.label5.TabIndex = 23;
            this.label5.Text = "Sale Price";
            // 
            // Input_SalePrice
            // 
            this.Input_SalePrice.BackColor = System.Drawing.SystemColors.GrayText;
            this.Input_SalePrice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_SalePrice.Location = new System.Drawing.Point(210, 179);
            this.Input_SalePrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_SalePrice.Name = "Input_SalePrice";
            this.Input_SalePrice.ReadOnly = true;
            this.Input_SalePrice.Size = new System.Drawing.Size(148, 38);
            this.Input_SalePrice.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 41);
            this.label2.TabIndex = 21;
            this.label2.Text = "Minimum Stock Allowed";
            // 
            // Input_MinStock
            // 
            this.Input_MinStock.BackColor = System.Drawing.SystemColors.GrayText;
            this.Input_MinStock.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_MinStock.Location = new System.Drawing.Point(394, 138);
            this.Input_MinStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_MinStock.Name = "Input_MinStock";
            this.Input_MinStock.ReadOnly = true;
            this.Input_MinStock.Size = new System.Drawing.Size(109, 38);
            this.Input_MinStock.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 41);
            this.label3.TabIndex = 19;
            this.label3.Text = "Current Stock";
            // 
            // Input_CurrentStock
            // 
            this.Input_CurrentStock.BackColor = System.Drawing.SystemColors.GrayText;
            this.Input_CurrentStock.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_CurrentStock.Location = new System.Drawing.Point(249, 93);
            this.Input_CurrentStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_CurrentStock.Name = "Input_CurrentStock";
            this.Input_CurrentStock.ReadOnly = true;
            this.Input_CurrentStock.Size = new System.Drawing.Size(109, 38);
            this.Input_CurrentStock.TabIndex = 18;
            // 
            // Input_Description
            // 
            this.Input_Description.BackColor = System.Drawing.SystemColors.GrayText;
            this.Input_Description.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Description.Location = new System.Drawing.Point(210, 55);
            this.Input_Description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_Description.Name = "Input_Description";
            this.Input_Description.ReadOnly = true;
            this.Input_Description.Size = new System.Drawing.Size(433, 38);
            this.Input_Description.TabIndex = 16;
            this.Input_Description.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 41);
            this.label4.TabIndex = 15;
            this.label4.Text = "Description";
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Button_Cancel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_Cancel.Location = new System.Drawing.Point(604, 383);
            this.Button_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(151, 61);
            this.Button_Cancel.TabIndex = 16;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = false;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_Update
            // 
            this.Button_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Button_Update.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Update.Location = new System.Drawing.Point(447, 383);
            this.Button_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(151, 61);
            this.Button_Update.TabIndex = 15;
            this.Button_Update.Text = "Update";
            this.Button_Update.UseVisualStyleBackColor = false;
            this.Button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // Input_searchQuery
            // 
            this.Input_searchQuery.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Input_searchQuery.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_searchQuery.Location = new System.Drawing.Point(247, 33);
            this.Input_searchQuery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_searchQuery.Name = "Input_searchQuery";
            this.Input_searchQuery.Size = new System.Drawing.Size(224, 38);
            this.Input_searchQuery.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 41);
            this.label8.TabIndex = 28;
            this.label8.Text = "Description: ";
            // 
            // frm_inventory_manageStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(787, 463);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Input_searchQuery);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Update);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_search);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_inventory_manageStock";
            this.Text = "Manage Stock";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private TextBox Input_searchQuery;
        private Label label8;
    }
}