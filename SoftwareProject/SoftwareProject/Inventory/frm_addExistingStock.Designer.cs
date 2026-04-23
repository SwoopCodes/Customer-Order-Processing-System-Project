using System.Drawing;
using System.Windows.Forms;

namespace SoftwareProject
{
    partial class frm_addExistingStock
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
            this.Input_searchQuery = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Box_CurrentQuantity = new System.Windows.Forms.TextBox();
            this.Label_AddStock = new System.Windows.Forms.Label();
            this.Input_StockToAdd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Box_ModelNo = new System.Windows.Forms.RichTextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.Panel_AddStock = new System.Windows.Forms.Panel();
            this.Panel_AddStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // Input_searchQuery
            // 
            this.Input_searchQuery.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_searchQuery.Location = new System.Drawing.Point(260, 27);
            this.Input_searchQuery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Input_searchQuery.Name = "Input_searchQuery";
            this.Input_searchQuery.Size = new System.Drawing.Size(169, 32);
            this.Input_searchQuery.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find by description: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Current Quantity";
            // 
            // Box_CurrentQuantity
            // 
            this.Box_CurrentQuantity.BackColor = System.Drawing.SystemColors.GrayText;
            this.Box_CurrentQuantity.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_CurrentQuantity.Location = new System.Drawing.Point(399, 161);
            this.Box_CurrentQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Box_CurrentQuantity.Name = "Box_CurrentQuantity";
            this.Box_CurrentQuantity.ReadOnly = true;
            this.Box_CurrentQuantity.Size = new System.Drawing.Size(85, 32);
            this.Box_CurrentQuantity.TabIndex = 2;
            // 
            // Label_AddStock
            // 
            this.Label_AddStock.AutoSize = true;
            this.Label_AddStock.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_AddStock.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label_AddStock.Location = new System.Drawing.Point(37, 5);
            this.Label_AddStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_AddStock.Name = "Label_AddStock";
            this.Label_AddStock.Size = new System.Drawing.Size(128, 32);
            this.Label_AddStock.TabIndex = 5;
            this.Label_AddStock.Text = "Add stock";
            // 
            // Input_StockToAdd
            // 
            this.Input_StockToAdd.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Input_StockToAdd.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_StockToAdd.Location = new System.Drawing.Point(10, 40);
            this.Input_StockToAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Input_StockToAdd.Name = "Input_StockToAdd";
            this.Input_StockToAdd.ReadOnly = true;
            this.Input_StockToAdd.Size = new System.Drawing.Size(169, 32);
            this.Input_StockToAdd.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(200, 310);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(361, 310);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(272, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Model No:";
            // 
            // Box_ModelNo
            // 
            this.Box_ModelNo.BackColor = System.Drawing.SystemColors.GrayText;
            this.Box_ModelNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_ModelNo.Location = new System.Drawing.Point(182, 124);
            this.Box_ModelNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Box_ModelNo.Name = "Box_ModelNo";
            this.Box_ModelNo.ReadOnly = true;
            this.Box_ModelNo.Size = new System.Drawing.Size(326, 25);
            this.Box_ModelNo.TabIndex = 9;
            this.Box_ModelNo.Text = "";
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_search.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_search.Location = new System.Drawing.Point(442, 22);
            this.button_search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(113, 37);
            this.button_search.TabIndex = 10;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // Panel_AddStock
            // 
            this.Panel_AddStock.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Panel_AddStock.Controls.Add(this.Input_StockToAdd);
            this.Panel_AddStock.Controls.Add(this.Label_AddStock);
            this.Panel_AddStock.Location = new System.Drawing.Point(242, 216);
            this.Panel_AddStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Panel_AddStock.Name = "Panel_AddStock";
            this.Panel_AddStock.Size = new System.Drawing.Size(188, 81);
            this.Panel_AddStock.TabIndex = 11;
            // 
            // frm_addExistingStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.Panel_AddStock);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.Box_ModelNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Box_CurrentQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Input_searchQuery);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_addExistingStock";
            this.Text = "Add Existing stock";
            this.Panel_AddStock.ResumeLayout(false);
            this.Panel_AddStock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Input_searchQuery;
        private Label label1;
        private Label label2;
        private TextBox Box_CurrentQuantity;
        private Label Label_AddStock;
        private TextBox Input_StockToAdd;
        private Button button1;
        private Button button2;
        private Label label4;
        private RichTextBox Box_ModelNo;
        private Button button_search;
        private Panel Panel_AddStock;
    }
}