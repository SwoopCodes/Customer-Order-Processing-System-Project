using System.Drawing;
using System.Windows.Forms;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Label_CostOfItemsSold = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Label_totalOrders = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Label_TotalProfit = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Label_totalOrderValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Label_AverageOrderValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Label_InventoryValue = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_filter = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.Label_potentialProfit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 86);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1760, 417);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel7.Controls.Add(this.Label_CostOfItemsSold);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Location = new System.Drawing.Point(30, 180);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(747, 44);
            this.panel7.TabIndex = 21;
            // 
            // Label_CostOfItemsSold
            // 
            this.Label_CostOfItemsSold.AutoSize = true;
            this.Label_CostOfItemsSold.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CostOfItemsSold.ForeColor = System.Drawing.Color.Red;
            this.Label_CostOfItemsSold.Location = new System.Drawing.Point(389, 0);
            this.Label_CostOfItemsSold.Name = "Label_CostOfItemsSold";
            this.Label_CostOfItemsSold.Size = new System.Drawing.Size(94, 41);
            this.Label_CostOfItemsSold.TabIndex = 18;
            this.Label_CostOfItemsSold.Text = "€0.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(353, 41);
            this.label12.TabIndex = 17;
            this.label12.Text = "YTD Cost of sold items: ";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel6.Controls.Add(this.Label_totalOrders);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(30, 39);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(747, 41);
            this.panel6.TabIndex = 21;
            // 
            // Label_totalOrders
            // 
            this.Label_totalOrders.AutoSize = true;
            this.Label_totalOrders.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_totalOrders.ForeColor = System.Drawing.Color.Lime;
            this.Label_totalOrders.Location = new System.Drawing.Point(389, 0);
            this.Label_totalOrders.Name = "Label_totalOrders";
            this.Label_totalOrders.Size = new System.Drawing.Size(35, 41);
            this.Label_totalOrders.TabIndex = 18;
            this.Label_totalOrders.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(274, 41);
            this.label10.TabIndex = 17;
            this.label10.Text = "YTD Total Orders: ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel5.Controls.Add(this.Label_TotalProfit);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(30, 229);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(747, 41);
            this.panel5.TabIndex = 20;
            // 
            // Label_TotalProfit
            // 
            this.Label_TotalProfit.AutoSize = true;
            this.Label_TotalProfit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TotalProfit.ForeColor = System.Drawing.Color.Lime;
            this.Label_TotalProfit.Location = new System.Drawing.Point(389, 0);
            this.Label_TotalProfit.Name = "Label_TotalProfit";
            this.Label_TotalProfit.Size = new System.Drawing.Size(94, 41);
            this.Label_TotalProfit.TabIndex = 18;
            this.Label_TotalProfit.Text = "€0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(260, 41);
            this.label8.TabIndex = 17;
            this.label8.Text = "YTD Total Profit: ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Controls.Add(this.Label_totalOrderValue);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(30, 132);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(747, 43);
            this.panel4.TabIndex = 20;
            // 
            // Label_totalOrderValue
            // 
            this.Label_totalOrderValue.AutoSize = true;
            this.Label_totalOrderValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_totalOrderValue.ForeColor = System.Drawing.Color.Lime;
            this.Label_totalOrderValue.Location = new System.Drawing.Point(389, 0);
            this.Label_totalOrderValue.Name = "Label_totalOrderValue";
            this.Label_totalOrderValue.Size = new System.Drawing.Size(94, 41);
            this.Label_totalOrderValue.TabIndex = 18;
            this.Label_totalOrderValue.Text = "€0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(346, 41);
            this.label6.TabIndex = 17;
            this.label6.Text = "YTD Total Order Value: ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.Label_AverageOrderValue);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(30, 85);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(747, 42);
            this.panel3.TabIndex = 19;
            // 
            // Label_AverageOrderValue
            // 
            this.Label_AverageOrderValue.AutoSize = true;
            this.Label_AverageOrderValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_AverageOrderValue.ForeColor = System.Drawing.Color.Lime;
            this.Label_AverageOrderValue.Location = new System.Drawing.Point(389, 0);
            this.Label_AverageOrderValue.Name = "Label_AverageOrderValue";
            this.Label_AverageOrderValue.Size = new System.Drawing.Size(94, 41);
            this.Label_AverageOrderValue.TabIndex = 18;
            this.Label_AverageOrderValue.Text = "€0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(386, 41);
            this.label4.TabIndex = 17;
            this.label4.Text = "YTD Average order Value: ";
            // 
            // Label_InventoryValue
            // 
            this.Label_InventoryValue.AutoSize = true;
            this.Label_InventoryValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_InventoryValue.ForeColor = System.Drawing.Color.Yellow;
            this.Label_InventoryValue.Location = new System.Drawing.Point(389, 0);
            this.Label_InventoryValue.Name = "Label_InventoryValue";
            this.Label_InventoryValue.Size = new System.Drawing.Size(94, 41);
            this.Label_InventoryValue.TabIndex = 18;
            this.Label_InventoryValue.Text = "€0.00";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(683, 34);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(255, 34);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Year";
            // 
            // button_filter
            // 
            this.button_filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_filter.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_filter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_filter.Location = new System.Drawing.Point(960, 27);
            this.button_filter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(113, 43);
            this.button_filter.TabIndex = 4;
            this.button_filter.Text = "Filter";
            this.button_filter.UseVisualStyleBackColor = false;
            this.button_filter.Click += new System.EventHandler(this.button_filter_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(878, 39);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Sales Total";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(807, 369);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.panel14);
            this.panel8.Location = new System.Drawing.Point(450, 517);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(809, 227);
            this.panel8.TabIndex = 5;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel14.Controls.Add(this.Label_InventoryValue);
            this.panel14.Controls.Add(this.label18);
            this.panel14.Location = new System.Drawing.Point(29, 39);
            this.panel14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(747, 43);
            this.panel14.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(0, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(332, 41);
            this.label18.TabIndex = 17;
            this.label18.Text = "Total Inventory value: ";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel9.Controls.Add(this.Label_potentialProfit);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Location = new System.Drawing.Point(29, 96);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(747, 43);
            this.panel9.TabIndex = 19;
            // 
            // Label_potentialProfit
            // 
            this.Label_potentialProfit.AutoSize = true;
            this.Label_potentialProfit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_potentialProfit.ForeColor = System.Drawing.Color.Lime;
            this.Label_potentialProfit.Location = new System.Drawing.Point(389, 0);
            this.Label_potentialProfit.Name = "Label_potentialProfit";
            this.Label_potentialProfit.Size = new System.Drawing.Size(94, 41);
            this.Label_potentialProfit.TabIndex = 18;
            this.Label_potentialProfit.Text = "€0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 41);
            this.label3.TabIndex = 17;
            this.label3.Text = "Potential Profit: ";
            // 
            // frm_finances_revenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1799, 850);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_filter);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_finances_revenueAnalysis";
            this.Text = "Yearly Revenue Analysis";
            this.Load += new System.EventHandler(this.frm_finances_revenueAnalysis_Load);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label Label_AverageOrderValue;
        private Label label4;
        private Label Label_InventoryValue;
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
        private ComboBox comboBox1;
        private Button button_filter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Panel panel8;
        private Panel panel9;
        private Label Label_potentialProfit;
        private Label label3;
        private Panel panel14;
        private Label label18;
    }
}