using System.Drawing;
using System.Windows.Forms;

namespace SoftwareProject
{
    partial class frm_orders_createOrder
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Input_ModelNo = new System.Windows.Forms.TextBox();
            this.Input_Quantity = new System.Windows.Forms.TextBox();
            this.Button_Add_Item = new System.Windows.Forms.Button();
            this.Order_Items_Table = new System.Windows.Forms.DataGridView();
            this.Order_Model_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Input_CompanyName = new System.Windows.Forms.TextBox();
            this.Input_ShippingAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Input_itemSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Button_findItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Order_Items_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(542, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model No: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(542, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity:";
            // 
            // Input_ModelNo
            // 
            this.Input_ModelNo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Input_ModelNo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_ModelNo.Location = new System.Drawing.Point(727, 222);
            this.Input_ModelNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_ModelNo.Name = "Input_ModelNo";
            this.Input_ModelNo.ReadOnly = true;
            this.Input_ModelNo.Size = new System.Drawing.Size(197, 38);
            this.Input_ModelNo.TabIndex = 3;
            // 
            // Input_Quantity
            // 
            this.Input_Quantity.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Input_Quantity.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Quantity.Location = new System.Drawing.Point(727, 267);
            this.Input_Quantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_Quantity.Name = "Input_Quantity";
            this.Input_Quantity.ReadOnly = true;
            this.Input_Quantity.Size = new System.Drawing.Size(87, 38);
            this.Input_Quantity.TabIndex = 4;
            // 
            // Button_Add_Item
            // 
            this.Button_Add_Item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button_Add_Item.Enabled = false;
            this.Button_Add_Item.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Add_Item.Location = new System.Drawing.Point(542, 317);
            this.Button_Add_Item.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_Add_Item.Name = "Button_Add_Item";
            this.Button_Add_Item.Size = new System.Drawing.Size(151, 46);
            this.Button_Add_Item.TabIndex = 24;
            this.Button_Add_Item.Text = "Add";
            this.Button_Add_Item.UseVisualStyleBackColor = false;
            this.Button_Add_Item.Click += new System.EventHandler(this.Button_Add_Item_Click);
            // 
            // Order_Items_Table
            // 
            this.Order_Items_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Order_Items_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order_Model_no,
            this.Data_Quantity,
            this.deleteButtonColumn});
            this.Order_Items_Table.Location = new System.Drawing.Point(31, 201);
            this.Order_Items_Table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Order_Items_Table.Name = "Order_Items_Table";
            this.Order_Items_Table.ReadOnly = true;
            this.Order_Items_Table.RowHeadersWidth = 51;
            this.Order_Items_Table.Size = new System.Drawing.Size(483, 243);
            this.Order_Items_Table.TabIndex = 25;
            // 
            // Order_Model_no
            // 
            this.Order_Model_no.HeaderText = "Model No";
            this.Order_Model_no.MinimumWidth = 6;
            this.Order_Model_no.Name = "Order_Model_no";
            this.Order_Model_no.ReadOnly = true;
            this.Order_Model_no.Width = 125;
            // 
            // Data_Quantity
            // 
            this.Data_Quantity.HeaderText = "Quantity";
            this.Data_Quantity.MinimumWidth = 6;
            this.Data_Quantity.Name = "Data_Quantity";
            this.Data_Quantity.ReadOnly = true;
            this.Data_Quantity.Width = 125;
            // 
            // deleteButtonColumn
            // 
            this.deleteButtonColumn.HeaderText = "Delete";
            this.deleteButtonColumn.MinimumWidth = 6;
            this.deleteButtonColumn.Name = "deleteButtonColumn";
            this.deleteButtonColumn.ReadOnly = true;
            this.deleteButtonColumn.Text = "Delete";
            this.deleteButtonColumn.UseColumnTextForButtonValue = true;
            this.deleteButtonColumn.Width = 60;
            // 
            // Input_CompanyName
            // 
            this.Input_CompanyName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_CompanyName.Location = new System.Drawing.Point(333, 19);
            this.Input_CompanyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_CompanyName.Name = "Input_CompanyName";
            this.Input_CompanyName.Size = new System.Drawing.Size(403, 38);
            this.Input_CompanyName.TabIndex = 26;
            // 
            // Input_ShippingAddress
            // 
            this.Input_ShippingAddress.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Input_ShippingAddress.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_ShippingAddress.Location = new System.Drawing.Point(333, 68);
            this.Input_ShippingAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_ShippingAddress.Name = "Input_ShippingAddress";
            this.Input_ShippingAddress.ReadOnly = true;
            this.Input_ShippingAddress.Size = new System.Drawing.Size(447, 38);
            this.Input_ShippingAddress.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 41);
            this.label4.TabIndex = 27;
            this.label4.Text = "Shipping address:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(752, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 45);
            this.button1.TabIndex = 29;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(845, 390);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 65);
            this.button2.TabIndex = 30;
            this.button2.Text = "Complete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Input_itemSearch
            // 
            this.Input_itemSearch.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Input_itemSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_itemSearch.Location = new System.Drawing.Point(240, 156);
            this.Input_itemSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_itemSearch.Name = "Input_itemSearch";
            this.Input_itemSearch.ReadOnly = true;
            this.Input_itemSearch.Size = new System.Drawing.Size(370, 38);
            this.Input_itemSearch.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 41);
            this.label5.TabIndex = 31;
            this.label5.Text = "Find item:";
            // 
            // Button_findItem
            // 
            this.Button_findItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Button_findItem.Enabled = false;
            this.Button_findItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_findItem.Location = new System.Drawing.Point(628, 153);
            this.Button_findItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_findItem.Name = "Button_findItem";
            this.Button_findItem.Size = new System.Drawing.Size(151, 46);
            this.Button_findItem.TabIndex = 33;
            this.Button_findItem.Text = "Find";
            this.Button_findItem.UseVisualStyleBackColor = false;
            this.Button_findItem.Click += new System.EventHandler(this.Button_findItem_Click);
            // 
            // frm_orders_createOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1038, 466);
            this.Controls.Add(this.Button_findItem);
            this.Controls.Add(this.Input_itemSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Order_Items_Table);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Input_ShippingAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Input_CompanyName);
            this.Controls.Add(this.Button_Add_Item);
            this.Controls.Add(this.Input_Quantity);
            this.Controls.Add(this.Input_ModelNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_orders_createOrder";
            this.Text = "Create Order";
            ((System.ComponentModel.ISupportInitialize)(this.Order_Items_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Input_ModelNo;
        private TextBox Input_Quantity;
        private Button Button_Add_Item;
        private DataGridView Order_Items_Table;
        private TextBox Input_CompanyName;
        private TextBox Input_ShippingAddress;
        private Label label4;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn Order_Model_no;
        private DataGridViewTextBoxColumn Data_Quantity;
        private DataGridViewButtonColumn deleteButtonColumn;
        private TextBox Input_itemSearch;
        private Label label5;
        private Button Button_findItem;
    }
}