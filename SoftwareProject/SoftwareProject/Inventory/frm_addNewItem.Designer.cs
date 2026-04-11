using System.Drawing;
using System.Windows.Forms;

namespace SoftwareProject
{
    partial class frm_addNewItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.Input_ModelNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Input_Description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Input_CurrentStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Input_MinStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Input_SalePrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Input_Supplier = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Input_CostPrice = new System.Windows.Forms.TextBox();
            this.Button_AddItem = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Model Number";
            // 
            // Input_ModelNo
            // 
            this.Input_ModelNo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_ModelNo.Location = new System.Drawing.Point(304, 26);
            this.Input_ModelNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_ModelNo.Name = "Input_ModelNo";
            this.Input_ModelNo.Size = new System.Drawing.Size(224, 38);
            this.Input_ModelNo.TabIndex = 2;
            this.Input_ModelNo.TextChanged += new System.EventHandler(this.Input_ModelNo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 41);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description";
            // 
            // Input_Description
            // 
            this.Input_Description.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Description.Location = new System.Drawing.Point(304, 74);
            this.Input_Description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_Description.Name = "Input_Description";
            this.Input_Description.Size = new System.Drawing.Size(445, 38);
            this.Input_Description.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 41);
            this.label3.TabIndex = 7;
            this.label3.Text = "Current Stock";
            // 
            // Input_CurrentStock
            // 
            this.Input_CurrentStock.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_CurrentStock.Location = new System.Drawing.Point(304, 118);
            this.Input_CurrentStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_CurrentStock.Name = "Input_CurrentStock";
            this.Input_CurrentStock.Size = new System.Drawing.Size(109, 38);
            this.Input_CurrentStock.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(364, 41);
            this.label4.TabIndex = 9;
            this.label4.Text = "Minimum Stock Allowed";
            // 
            // Input_MinStock
            // 
            this.Input_MinStock.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_MinStock.Location = new System.Drawing.Point(445, 163);
            this.Input_MinStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_MinStock.Name = "Input_MinStock";
            this.Input_MinStock.Size = new System.Drawing.Size(109, 38);
            this.Input_MinStock.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 41);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sale Price";
            // 
            // Input_SalePrice
            // 
            this.Input_SalePrice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_SalePrice.Location = new System.Drawing.Point(304, 205);
            this.Input_SalePrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_SalePrice.Name = "Input_SalePrice";
            this.Input_SalePrice.Size = new System.Drawing.Size(148, 38);
            this.Input_SalePrice.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 41);
            this.label7.TabIndex = 15;
            this.label7.Text = "Supplier";
            // 
            // Input_Supplier
            // 
            this.Input_Supplier.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Supplier.Location = new System.Drawing.Point(304, 297);
            this.Input_Supplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_Supplier.Name = "Input_Supplier";
            this.Input_Supplier.Size = new System.Drawing.Size(250, 38);
            this.Input_Supplier.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 41);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cost Price";
            // 
            // Input_CostPrice
            // 
            this.Input_CostPrice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_CostPrice.Location = new System.Drawing.Point(304, 250);
            this.Input_CostPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_CostPrice.Name = "Input_CostPrice";
            this.Input_CostPrice.Size = new System.Drawing.Size(148, 38);
            this.Input_CostPrice.TabIndex = 16;
            // 
            // Button_AddItem
            // 
            this.Button_AddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Button_AddItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_AddItem.Location = new System.Drawing.Point(729, 396);
            this.Button_AddItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_AddItem.Name = "Button_AddItem";
            this.Button_AddItem.Size = new System.Drawing.Size(151, 61);
            this.Button_AddItem.TabIndex = 18;
            this.Button_AddItem.Text = "Add Item";
            this.Button_AddItem.UseVisualStyleBackColor = false;
            this.Button_AddItem.Click += new System.EventHandler(this.Button_AddItem_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Button_Cancel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_Cancel.Location = new System.Drawing.Point(546, 396);
            this.Button_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(151, 61);
            this.Button_Cancel.TabIndex = 19;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = false;
            // 
            // frm_addNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(914, 480);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_AddItem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Input_CostPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Input_Supplier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Input_SalePrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Input_MinStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Input_CurrentStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Input_Description);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Input_ModelNo);
            this.Name = "frm_addNewItem";
            this.Text = "Add new Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox Input_ModelNo;
        private Label label2;
        private TextBox Input_Description;
        private Label label3;
        private TextBox Input_CurrentStock;
        private Label label4;
        private TextBox Input_MinStock;
        private Label label5;
        private TextBox Input_SalePrice;
        private Label label7;
        private TextBox Input_Supplier;
        private Label label6;
        private TextBox Input_CostPrice;
        private Button Button_AddItem;
        private Button Button_Cancel;
    }
}