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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Input_ModelNo = new TextBox();
            Input_Quantity = new TextBox();
            Button_Add_Item = new Button();
            Order_Items_Table = new DataGridView();
            Order_Model_no = new DataGridViewTextBoxColumn();
            Data_Quantity = new DataGridViewTextBoxColumn();
            deleteButtonColumn = new DataGridViewButtonColumn();
            Input_CompanyName = new TextBox();
            Input_ShippingAddress = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            Input_itemSearch = new TextBox();
            label5 = new Label();
            Button_findItem = new Button();
            ((System.ComponentModel.ISupportInitialize)Order_Items_Table).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 24);
            label1.Name = "label1";
            label1.Size = new Size(258, 41);
            label1.TabIndex = 0;
            label1.Text = "Company Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(419, 261);
            label2.Name = "label2";
            label2.Size = new Size(175, 41);
            label2.TabIndex = 1;
            label2.Text = "Model No: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(419, 320);
            label3.Name = "label3";
            label3.Size = new Size(150, 41);
            label3.TabIndex = 2;
            label3.Text = "Quantity:";
            // 
            // Input_ModelNo
            // 
            Input_ModelNo.BackColor = SystemColors.ScrollBar;
            Input_ModelNo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Input_ModelNo.Location = new Point(588, 266);
            Input_ModelNo.Name = "Input_ModelNo";
            Input_ModelNo.ReadOnly = true;
            Input_ModelNo.Size = new Size(197, 38);
            Input_ModelNo.TabIndex = 3;
            // 
            // Input_Quantity
            // 
            Input_Quantity.BackColor = SystemColors.ScrollBar;
            Input_Quantity.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Input_Quantity.Location = new Point(588, 323);
            Input_Quantity.Name = "Input_Quantity";
            Input_Quantity.ReadOnly = true;
            Input_Quantity.Size = new Size(87, 38);
            Input_Quantity.TabIndex = 4;
            // 
            // Button_Add_Item
            // 
            Button_Add_Item.BackColor = Color.FromArgb(224, 224, 224);
            Button_Add_Item.Enabled = false;
            Button_Add_Item.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_Add_Item.Location = new Point(419, 382);
            Button_Add_Item.Name = "Button_Add_Item";
            Button_Add_Item.Size = new Size(151, 51);
            Button_Add_Item.TabIndex = 24;
            Button_Add_Item.Text = "Add";
            Button_Add_Item.UseVisualStyleBackColor = false;
            Button_Add_Item.Click += Button_Add_Item_Click;
            // 
            // Order_Items_Table
            // 
            Order_Items_Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Order_Items_Table.Columns.AddRange(new DataGridViewColumn[] { Order_Model_no, Data_Quantity, deleteButtonColumn });
            Order_Items_Table.Location = new Point(31, 251);
            Order_Items_Table.Name = "Order_Items_Table";
            Order_Items_Table.ReadOnly = true;
            Order_Items_Table.RowHeadersWidth = 51;
            Order_Items_Table.Size = new Size(366, 304);
            Order_Items_Table.TabIndex = 25;
            // 
            // Order_Model_no
            // 
            Order_Model_no.HeaderText = "Model No";
            Order_Model_no.MinimumWidth = 6;
            Order_Model_no.Name = "Order_Model_no";
            Order_Model_no.ReadOnly = true;
            Order_Model_no.Width = 125;
            // 
            // Data_Quantity
            // 
            Data_Quantity.HeaderText = "Quantity";
            Data_Quantity.MinimumWidth = 6;
            Data_Quantity.Name = "Data_Quantity";
            Data_Quantity.ReadOnly = true;
            Data_Quantity.Width = 125;
            // 
            // deleteButtonColumn
            // 
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.MinimumWidth = 6;
            deleteButtonColumn.Name = "deleteButtonColumn";
            deleteButtonColumn.ReadOnly = true;
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.Width = 60;
            // 
            // Input_CompanyName
            // 
            Input_CompanyName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Input_CompanyName.Location = new Point(309, 24);
            Input_CompanyName.Name = "Input_CompanyName";
            Input_CompanyName.Size = new Size(403, 38);
            Input_CompanyName.TabIndex = 26;
            // 
            // Input_ShippingAddress
            // 
            Input_ShippingAddress.BackColor = SystemColors.ScrollBar;
            Input_ShippingAddress.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Input_ShippingAddress.Location = new Point(309, 85);
            Input_ShippingAddress.Name = "Input_ShippingAddress";
            Input_ShippingAddress.ReadOnly = true;
            Input_ShippingAddress.Size = new Size(447, 38);
            Input_ShippingAddress.TabIndex = 28;
            Input_ShippingAddress.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 80);
            label4.Name = "label4";
            label4.Size = new Size(270, 41);
            label4.TabIndex = 27;
            label4.Text = "Shipping address:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(728, 19);
            button1.Name = "button1";
            button1.Size = new Size(151, 51);
            button1.TabIndex = 29;
            button1.Text = "Find";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(224, 224, 224);
            button2.Enabled = false;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(698, 435);
            button2.Name = "button2";
            button2.Size = new Size(181, 81);
            button2.TabIndex = 30;
            button2.Text = "Complete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Input_itemSearch
            // 
            Input_itemSearch.BackColor = SystemColors.ScrollBar;
            Input_itemSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Input_itemSearch.Location = new Point(200, 198);
            Input_itemSearch.Name = "Input_itemSearch";
            Input_itemSearch.ReadOnly = true;
            Input_itemSearch.Size = new Size(370, 38);
            Input_itemSearch.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 195);
            label5.Name = "label5";
            label5.Size = new Size(160, 41);
            label5.TabIndex = 31;
            label5.Text = "Find item:";
            // 
            // Button_findItem
            // 
            Button_findItem.BackColor = Color.FromArgb(255, 192, 128);
            Button_findItem.Enabled = false;
            Button_findItem.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_findItem.Location = new Point(588, 194);
            Button_findItem.Name = "Button_findItem";
            Button_findItem.Size = new Size(151, 43);
            Button_findItem.TabIndex = 33;
            Button_findItem.Text = "Find";
            Button_findItem.UseVisualStyleBackColor = false;
            Button_findItem.Click += Button_findItem_Click;
            // 
            // frm_orders_createOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(891, 583);
            Controls.Add(Button_findItem);
            Controls.Add(Input_itemSearch);
            Controls.Add(label5);
            Controls.Add(Order_Items_Table);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Input_ShippingAddress);
            Controls.Add(label4);
            Controls.Add(Input_CompanyName);
            Controls.Add(Button_Add_Item);
            Controls.Add(Input_Quantity);
            Controls.Add(Input_ModelNo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frm_orders_createOrder";
            Text = "Create Order";
            Load += frm_orders_createOrder_Load;
            ((System.ComponentModel.ISupportInitialize)Order_Items_Table).EndInit();
            ResumeLayout(false);
            PerformLayout();
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