namespace SoftwareProject
{
    partial class frm_finances_revenueAnalysis
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
            panel1 = new Panel();
            panel7 = new Panel();
            Label_CostOfItemsSold = new Label();
            label12 = new Label();
            panel6 = new Panel();
            Label_totalOrders = new Label();
            label10 = new Label();
            panel5 = new Panel();
            Label_TotalProfit = new Label();
            label8 = new Label();
            panel4 = new Panel();
            Label_totalOrderValue = new Label();
            label6 = new Label();
            panel3 = new Panel();
            Label_AverageOrderValue = new Label();
            label4 = new Label();
            panel2 = new Panel();
            Label_InventoryValue = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(27, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 525);
            panel1.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ActiveBorder;
            panel7.Controls.Add(Label_CostOfItemsSold);
            panel7.Controls.Add(label12);
            panel7.Location = new Point(30, 257);
            panel7.Name = "panel7";
            panel7.Size = new Size(747, 45);
            panel7.TabIndex = 21;
            // 
            // Label_CostOfItemsSold
            // 
            Label_CostOfItemsSold.AutoSize = true;
            Label_CostOfItemsSold.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_CostOfItemsSold.ForeColor = Color.Red;
            Label_CostOfItemsSold.Location = new Point(390, 0);
            Label_CostOfItemsSold.Name = "Label_CostOfItemsSold";
            Label_CostOfItemsSold.Size = new Size(94, 41);
            Label_CostOfItemsSold.TabIndex = 18;
            Label_CostOfItemsSold.Text = "€0.00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(0, 0);
            label12.Name = "label12";
            label12.Size = new Size(353, 41);
            label12.TabIndex = 17;
            label12.Text = "YTD Cost of sold items: ";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveBorder;
            panel6.Controls.Add(Label_totalOrders);
            panel6.Controls.Add(label10);
            panel6.Location = new Point(29, 91);
            panel6.Name = "panel6";
            panel6.Size = new Size(747, 45);
            panel6.TabIndex = 21;
            // 
            // Label_totalOrders
            // 
            Label_totalOrders.AutoSize = true;
            Label_totalOrders.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_totalOrders.ForeColor = Color.Lime;
            Label_totalOrders.Location = new Point(390, 0);
            Label_totalOrders.Name = "Label_totalOrders";
            Label_totalOrders.Size = new Size(35, 41);
            Label_totalOrders.TabIndex = 18;
            Label_totalOrders.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(274, 41);
            label10.TabIndex = 17;
            label10.Text = "YTD Total Orders: ";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveBorder;
            panel5.Controls.Add(Label_TotalProfit);
            panel5.Controls.Add(label8);
            panel5.Location = new Point(29, 315);
            panel5.Name = "panel5";
            panel5.Size = new Size(747, 45);
            panel5.TabIndex = 20;
            // 
            // Label_TotalProfit
            // 
            Label_TotalProfit.AutoSize = true;
            Label_TotalProfit.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_TotalProfit.ForeColor = Color.Lime;
            Label_TotalProfit.Location = new Point(390, 0);
            Label_TotalProfit.Name = "Label_TotalProfit";
            Label_TotalProfit.Size = new Size(94, 41);
            Label_TotalProfit.TabIndex = 18;
            Label_TotalProfit.Text = "€0.00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(260, 41);
            label8.TabIndex = 17;
            label8.Text = "YTD Total Profit: ";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveBorder;
            panel4.Controls.Add(Label_totalOrderValue);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(29, 199);
            panel4.Name = "panel4";
            panel4.Size = new Size(747, 45);
            panel4.TabIndex = 20;
            // 
            // Label_totalOrderValue
            // 
            Label_totalOrderValue.AutoSize = true;
            Label_totalOrderValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_totalOrderValue.ForeColor = Color.Lime;
            Label_totalOrderValue.Location = new Point(390, 0);
            Label_totalOrderValue.Name = "Label_totalOrderValue";
            Label_totalOrderValue.Size = new Size(94, 41);
            Label_totalOrderValue.TabIndex = 18;
            Label_totalOrderValue.Text = "€0.00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(346, 41);
            label6.TabIndex = 17;
            label6.Text = "YTD Total Order Value: ";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Controls.Add(Label_AverageOrderValue);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(29, 147);
            panel3.Name = "panel3";
            panel3.Size = new Size(747, 45);
            panel3.TabIndex = 19;
            // 
            // Label_AverageOrderValue
            // 
            Label_AverageOrderValue.AutoSize = true;
            Label_AverageOrderValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_AverageOrderValue.ForeColor = Color.Lime;
            Label_AverageOrderValue.Location = new Point(390, 0);
            Label_AverageOrderValue.Name = "Label_AverageOrderValue";
            Label_AverageOrderValue.Size = new Size(94, 41);
            Label_AverageOrderValue.TabIndex = 18;
            Label_AverageOrderValue.Text = "€0.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(386, 41);
            label4.TabIndex = 17;
            label4.Text = "YTD Average order Value: ";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(Label_InventoryValue);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(29, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(747, 45);
            panel2.TabIndex = 0;
            // 
            // Label_InventoryValue
            // 
            Label_InventoryValue.AutoSize = true;
            Label_InventoryValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_InventoryValue.ForeColor = Color.Yellow;
            Label_InventoryValue.Location = new Point(390, 0);
            Label_InventoryValue.Name = "Label_InventoryValue";
            Label_InventoryValue.Size = new Size(94, 41);
            Label_InventoryValue.TabIndex = 18;
            Label_InventoryValue.Text = "€0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(332, 41);
            label1.TabIndex = 17;
            label1.Text = "Total Inventory value: ";
            // 
            // frm_finances_revenueAnalysis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(944, 609);
            Controls.Add(panel1);
            Name = "frm_finances_revenueAnalysis";
            Text = "Yearly Revenue Analysis";
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label Label_AverageOrderValue;
        private Label label4;
        private Label Label_InventoryValue;
        private Label label1;
        private Panel panel5;
        private Label Label_TotalProfit;
        private Label label8;
        private Panel panel4;
        private Label Label_totalOrderValue;
        private Label label6;
        private Panel panel7;
        private Label Label_CostOfItemsSold;
        private Label label12;
        private Panel panel6;
        private Label Label_totalOrders;
        private Label label10;
    }
}