using System.Drawing;
using System.Windows.Forms;

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
            this.label1 = new System.Windows.Forms.Label();
            this.Input_orderID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label_Status = new System.Windows.Forms.Label();
            this.label_orderTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Order_Items_Table = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.box_shippingAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.box_companyName = new System.Windows.Forms.TextBox();
            this.button_markComplete = new System.Windows.Forms.Button();
            this.button_removeOrder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Order_Items_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 41);
            this.label1.TabIndex = 16;
            this.label1.Text = "Company name:";
            // 
            // Input_orderID
            // 
            this.Input_orderID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_orderID.Location = new System.Drawing.Point(379, 30);
            this.Input_orderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_orderID.Name = "Input_orderID";
            this.Input_orderID.Size = new System.Drawing.Size(348, 38);
            this.Input_orderID.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.Label_Status);
            this.panel1.Controls.Add(this.label_orderTotal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Order_Items_Table);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.box_shippingAddress);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.box_companyName);
            this.panel1.Location = new System.Drawing.Point(12, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 358);
            this.panel1.TabIndex = 17;
            // 
            // Label_Status
            // 
            this.Label_Status.AutoSize = true;
            this.Label_Status.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Status.ForeColor = System.Drawing.Color.Black;
            this.Label_Status.Location = new System.Drawing.Point(545, 302);
            this.Label_Status.Name = "Label_Status";
            this.Label_Status.Size = new System.Drawing.Size(121, 41);
            this.Label_Status.TabIndex = 32;
            this.Label_Status.Text = "Status: ";
            this.Label_Status.Visible = false;
            // 
            // label_orderTotal
            // 
            this.label_orderTotal.AutoSize = true;
            this.label_orderTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_orderTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_orderTotal.Location = new System.Drawing.Point(545, 267);
            this.label_orderTotal.Name = "label_orderTotal";
            this.label_orderTotal.Size = new System.Drawing.Size(121, 41);
            this.label_orderTotal.TabIndex = 31;
            this.label_orderTotal.Text = "Total: €";
            this.label_orderTotal.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 41);
            this.label4.TabIndex = 27;
            this.label4.Text = "Order Items:";
            // 
            // Order_Items_Table
            // 
            this.Order_Items_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Order_Items_Table.Location = new System.Drawing.Point(12, 159);
            this.Order_Items_Table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Order_Items_Table.Name = "Order_Items_Table";
            this.Order_Items_Table.ReadOnly = true;
            this.Order_Items_Table.RowHeadersWidth = 51;
            this.Order_Items_Table.Size = new System.Drawing.Size(511, 184);
            this.Order_Items_Table.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 41);
            this.label3.TabIndex = 21;
            this.label3.Text = "Shipping address:";
            // 
            // box_shippingAddress
            // 
            this.box_shippingAddress.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_shippingAddress.Location = new System.Drawing.Point(367, 62);
            this.box_shippingAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_shippingAddress.Name = "box_shippingAddress";
            this.box_shippingAddress.ReadOnly = true;
            this.box_shippingAddress.Size = new System.Drawing.Size(463, 38);
            this.box_shippingAddress.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 41);
            this.label2.TabIndex = 19;
            this.label2.Text = "Comapny Name:";
            // 
            // box_companyName
            // 
            this.box_companyName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_companyName.Location = new System.Drawing.Point(367, 15);
            this.box_companyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_companyName.Name = "box_companyName";
            this.box_companyName.ReadOnly = true;
            this.box_companyName.Size = new System.Drawing.Size(348, 38);
            this.box_companyName.TabIndex = 18;
            // 
            // button_markComplete
            // 
            this.button_markComplete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_markComplete.Enabled = false;
            this.button_markComplete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_markComplete.Location = new System.Drawing.Point(550, 439);
            this.button_markComplete.Name = "button_markComplete";
            this.button_markComplete.Size = new System.Drawing.Size(240, 50);
            this.button_markComplete.TabIndex = 19;
            this.button_markComplete.Text = "Mark Complete";
            this.button_markComplete.UseVisualStyleBackColor = false;
            this.button_markComplete.Click += new System.EventHandler(this.button_markComplete_Click);
            // 
            // button_removeOrder
            // 
            this.button_removeOrder.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_removeOrder.Enabled = false;
            this.button_removeOrder.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_removeOrder.Location = new System.Drawing.Point(796, 439);
            this.button_removeOrder.Name = "button_removeOrder";
            this.button_removeOrder.Size = new System.Drawing.Size(240, 50);
            this.button_removeOrder.TabIndex = 20;
            this.button_removeOrder.Text = "Remove Order";
            this.button_removeOrder.UseVisualStyleBackColor = false;
            this.button_removeOrder.Click += new System.EventHandler(this.button_removeOrder_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(758, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 47);
            this.button1.TabIndex = 30;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_modifyOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1048, 507);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_removeOrder);
            this.Controls.Add(this.button_markComplete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Input_orderID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_modifyOrder";
            this.Text = "Order details";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Order_Items_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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