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
            Input_searchQuery = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Box_CurrentQuantity = new TextBox();
            Label_AddStock = new Label();
            Input_StockToAdd = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            Box_ModelNo = new RichTextBox();
            button_search = new Button();
            Panel_AddStock = new Panel();
            Panel_AddStock.SuspendLayout();
            SuspendLayout();
            // 
            // Input_searchQuery
            // 
            Input_searchQuery.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Input_searchQuery.Location = new Point(322, 41);
            Input_searchQuery.Name = "Input_searchQuery";
            Input_searchQuery.Size = new Size(224, 38);
            Input_searchQuery.TabIndex = 0;
            Input_searchQuery.TextChanged += Input_ModelNo_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 41);
            label1.Name = "label1";
            label1.Size = new Size(306, 41);
            label1.TabIndex = 1;
            label1.Text = "Find by description: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(242, 242);
            label2.Name = "label2";
            label2.Size = new Size(257, 41);
            label2.TabIndex = 3;
            label2.Text = "Current Quantity";
            // 
            // Box_CurrentQuantity
            // 
            Box_CurrentQuantity.BackColor = SystemColors.GrayText;
            Box_CurrentQuantity.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Box_CurrentQuantity.Location = new Point(532, 247);
            Box_CurrentQuantity.Name = "Box_CurrentQuantity";
            Box_CurrentQuantity.ReadOnly = true;
            Box_CurrentQuantity.Size = new Size(112, 38);
            Box_CurrentQuantity.TabIndex = 2;
            // 
            // Label_AddStock
            // 
            Label_AddStock.AutoSize = true;
            Label_AddStock.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_AddStock.ForeColor = SystemColors.ControlDark;
            Label_AddStock.Location = new Point(45, 17);
            Label_AddStock.Name = "Label_AddStock";
            Label_AddStock.Size = new Size(159, 41);
            Label_AddStock.TabIndex = 5;
            Label_AddStock.Text = "Add stock";
            // 
            // Input_StockToAdd
            // 
            Input_StockToAdd.BackColor = SystemColors.MenuBar;
            Input_StockToAdd.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Input_StockToAdd.Location = new Point(13, 61);
            Input_StockToAdd.Name = "Input_StockToAdd";
            Input_StockToAdd.ReadOnly = true;
            Input_StockToAdd.Size = new Size(224, 38);
            Input_StockToAdd.TabIndex = 4;
            Input_StockToAdd.TextChanged += textBox2_TextChanged;
            Input_StockToAdd.KeyDown += Input_StockToAdd_KeyDown;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(266, 476);
            button1.Name = "button1";
            button1.Size = new Size(151, 76);
            button1.TabIndex = 6;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(481, 476);
            button2.Name = "button2";
            button2.Size = new Size(151, 76);
            button2.TabIndex = 7;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(363, 131);
            label4.Name = "label4";
            label4.Size = new Size(167, 41);
            label4.TabIndex = 8;
            label4.Text = "Model No:";
            // 
            // Box_ModelNo
            // 
            Box_ModelNo.BackColor = SystemColors.GrayText;
            Box_ModelNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Box_ModelNo.Location = new Point(242, 191);
            Box_ModelNo.Name = "Box_ModelNo";
            Box_ModelNo.ReadOnly = true;
            Box_ModelNo.Size = new Size(433, 37);
            Box_ModelNo.TabIndex = 9;
            Box_ModelNo.Text = "";
            // 
            // button_search
            // 
            button_search.BackColor = Color.FromArgb(255, 192, 128);
            button_search.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_search.ForeColor = SystemColors.ActiveCaptionText;
            button_search.Location = new Point(567, 35);
            button_search.Name = "button_search";
            button_search.Size = new Size(151, 47);
            button_search.TabIndex = 10;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // Panel_AddStock
            // 
            Panel_AddStock.BackColor = SystemColors.ScrollBar;
            Panel_AddStock.Controls.Add(Input_StockToAdd);
            Panel_AddStock.Controls.Add(Label_AddStock);
            Panel_AddStock.Location = new Point(322, 332);
            Panel_AddStock.Name = "Panel_AddStock";
            Panel_AddStock.Size = new Size(250, 125);
            Panel_AddStock.TabIndex = 11;
            // 
            // frm_addExistingStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(914, 600);
            Controls.Add(Panel_AddStock);
            Controls.Add(button_search);
            Controls.Add(Box_ModelNo);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(Box_CurrentQuantity);
            Controls.Add(label1);
            Controls.Add(Input_searchQuery);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_addExistingStock";
            Text = "Add Existing stock";
            Panel_AddStock.ResumeLayout(false);
            Panel_AddStock.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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