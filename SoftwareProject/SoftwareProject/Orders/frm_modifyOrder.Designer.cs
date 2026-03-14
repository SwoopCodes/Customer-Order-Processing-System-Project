namespace SoftwareProject
{
    partial class frm_modifyOrder
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
            Input_orderID = new TextBox();
            panel1 = new Panel();
            label_orderTotal = new Label();
            label4 = new Label();
            Order_Items_Table = new DataGridView();
            label3 = new Label();
            box_shippingAddress = new TextBox();
            label2 = new Label();
            box_companyName = new TextBox();
            button_markComplete = new Button();
            button_removeOrder = new Button();
            button1 = new Button();
            Label_Status = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Order_Items_Table).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(230, 41);
            label1.TabIndex = 16;
            label1.Text = "Enter Order ID:";
            // 
            // Input_orderID
            // 
            Input_orderID.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Input_orderID.Location = new Point(260, 34);
            Input_orderID.Name = "Input_orderID";
            Input_orderID.Size = new Size(348, 38);
            Input_orderID.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(Label_Status);
            panel1.Controls.Add(label_orderTotal);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(Order_Items_Table);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(box_shippingAddress);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(box_companyName);
            panel1.Location = new Point(12, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(897, 447);
            panel1.TabIndex = 17;
            // 
            // label_orderTotal
            // 
            label_orderTotal.AutoSize = true;
            label_orderTotal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_orderTotal.ForeColor = Color.FromArgb(0, 192, 0);
            label_orderTotal.Location = new Point(538, 344);
            label_orderTotal.Name = "label_orderTotal";
            label_orderTotal.Size = new Size(121, 41);
            label_orderTotal.TabIndex = 31;
            label_orderTotal.Text = "Total: €";
            label_orderTotal.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 145);
            label4.Name = "label4";
            label4.Size = new Size(194, 41);
            label4.TabIndex = 27;
            label4.Text = "Order Items:";
            // 
            // Order_Items_Table
            // 
            Order_Items_Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Order_Items_Table.Location = new Point(12, 199);
            Order_Items_Table.Name = "Order_Items_Table";
            Order_Items_Table.ReadOnly = true;
            Order_Items_Table.RowHeadersWidth = 51;
            Order_Items_Table.Size = new Size(511, 230);
            Order_Items_Table.TabIndex = 26;
            Order_Items_Table.CellContentClick += Order_Items_Table_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 78);
            label3.Name = "label3";
            label3.Size = new Size(270, 41);
            label3.TabIndex = 21;
            label3.Text = "Shipping address:";
            // 
            // box_shippingAddress
            // 
            box_shippingAddress.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            box_shippingAddress.Location = new Point(288, 83);
            box_shippingAddress.Name = "box_shippingAddress";
            box_shippingAddress.ReadOnly = true;
            box_shippingAddress.Size = new Size(463, 38);
            box_shippingAddress.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 23);
            label2.Name = "label2";
            label2.Size = new Size(250, 41);
            label2.TabIndex = 19;
            label2.Text = "Comapny Name:";
            // 
            // box_companyName
            // 
            box_companyName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            box_companyName.Location = new Point(268, 26);
            box_companyName.Name = "box_companyName";
            box_companyName.ReadOnly = true;
            box_companyName.Size = new Size(348, 38);
            box_companyName.TabIndex = 18;
            // 
            // button_markComplete
            // 
            button_markComplete.BackColor = SystemColors.AppWorkspace;
            button_markComplete.Enabled = false;
            button_markComplete.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_markComplete.Location = new Point(550, 549);
            button_markComplete.Margin = new Padding(3, 4, 3, 4);
            button_markComplete.Name = "button_markComplete";
            button_markComplete.Size = new Size(240, 63);
            button_markComplete.TabIndex = 19;
            button_markComplete.Text = "Mark Complete";
            button_markComplete.UseVisualStyleBackColor = false;
            button_markComplete.Click += button_markComplete_Click;
            // 
            // button_removeOrder
            // 
            button_removeOrder.BackColor = SystemColors.AppWorkspace;
            button_removeOrder.Enabled = false;
            button_removeOrder.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_removeOrder.Location = new Point(796, 549);
            button_removeOrder.Margin = new Padding(3, 4, 3, 4);
            button_removeOrder.Name = "button_removeOrder";
            button_removeOrder.Size = new Size(240, 63);
            button_removeOrder.TabIndex = 20;
            button_removeOrder.Text = "Remove Order";
            button_removeOrder.UseVisualStyleBackColor = false;
            button_removeOrder.Click += button_removeOrder_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(639, 28);
            button1.Name = "button1";
            button1.Size = new Size(151, 47);
            button1.TabIndex = 30;
            button1.Text = "Find";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Label_Status
            // 
            Label_Status.AutoSize = true;
            Label_Status.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_Status.ForeColor = Color.Black;
            Label_Status.Location = new Point(538, 388);
            Label_Status.Name = "Label_Status";
            Label_Status.Size = new Size(121, 41);
            Label_Status.TabIndex = 32;
            Label_Status.Text = "Status: ";
            Label_Status.Visible = false;
            // 
            // frm_modifyOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1048, 634);
            Controls.Add(button1);
            Controls.Add(button_removeOrder);
            Controls.Add(button_markComplete);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(Input_orderID);
            Name = "frm_modifyOrder";
            Text = "Order details";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Order_Items_Table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Input_orderID;
        private Panel panel1;
        private Label label3;
        private TextBox box_shippingAddress;
        private Label label2;
        private TextBox box_companyName;
        private DataGridView Order_Items_Table;
        private Button button_markComplete;
        private Button button_removeOrder;
        private Label label4;
        private Button button1;
        private Label label_orderTotal;
        private Label Label_Status;
    }
}