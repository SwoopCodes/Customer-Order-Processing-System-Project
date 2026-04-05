namespace SoftwareProject
{
    partial class frm_updateCustomers
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
            button_search = new Button();
            label1 = new Label();
            Input_CompanyName = new TextBox();
            panel1 = new Panel();
            label6 = new Label();
            Box_status = new TextBox();
            Input_email = new TextBox();
            label5 = new Label();
            Input_representative = new TextBox();
            label2 = new Label();
            Input_address = new TextBox();
            label3 = new Label();
            Input_phone = new TextBox();
            label4 = new Label();
            Button_Delete = new Button();
            Button_Cancel = new Button();
            Button_Update = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button_search
            // 
            button_search.BackColor = Color.FromArgb(255, 192, 128);
            button_search.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_search.ForeColor = SystemColors.ActiveCaptionText;
            button_search.Location = new Point(610, 28);
            button_search.Name = "button_search";
            button_search.Size = new Size(151, 49);
            button_search.TabIndex = 16;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 33);
            label1.Name = "label1";
            label1.Size = new Size(242, 41);
            label1.TabIndex = 15;
            label1.Text = "Company Name";
            // 
            // Input_CompanyName
            // 
            Input_CompanyName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Input_CompanyName.Location = new Point(275, 36);
            Input_CompanyName.Name = "Input_CompanyName";
            Input_CompanyName.Size = new Size(319, 38);
            Input_CompanyName.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(Box_status);
            panel1.Controls.Add(Input_email);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(Input_representative);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Input_address);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Input_phone);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(27, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 321);
            panel1.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 252);
            label6.Name = "label6";
            label6.Size = new Size(113, 41);
            label6.TabIndex = 30;
            label6.Text = "Status:";
            // 
            // Box_status
            // 
            Box_status.BackColor = SystemColors.GrayText;
            Box_status.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Box_status.Location = new Point(152, 255);
            Box_status.Name = "Box_status";
            Box_status.ReadOnly = true;
            Box_status.Size = new Size(286, 38);
            Box_status.TabIndex = 29;
            // 
            // Input_email
            // 
            Input_email.BackColor = SystemColors.GrayText;
            Input_email.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Input_email.Location = new Point(208, 20);
            Input_email.Name = "Input_email";
            Input_email.ReadOnly = true;
            Input_email.Size = new Size(334, 38);
            Input_email.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 192);
            label5.Name = "label5";
            label5.Size = new Size(228, 41);
            label5.TabIndex = 27;
            label5.Text = "Representative";
            // 
            // Input_representative
            // 
            Input_representative.BackColor = SystemColors.GrayText;
            Input_representative.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Input_representative.Location = new Point(256, 195);
            Input_representative.Name = "Input_representative";
            Input_representative.ReadOnly = true;
            Input_representative.Size = new Size(286, 38);
            Input_representative.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 132);
            label2.Name = "label2";
            label2.Size = new Size(131, 41);
            label2.TabIndex = 21;
            label2.Text = "Address";
            // 
            // Input_address
            // 
            Input_address.BackColor = SystemColors.GrayText;
            Input_address.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Input_address.Location = new Point(208, 135);
            Input_address.Name = "Input_address";
            Input_address.ReadOnly = true;
            Input_address.Size = new Size(451, 38);
            Input_address.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 76);
            label3.Name = "label3";
            label3.Size = new Size(106, 41);
            label3.TabIndex = 19;
            label3.Text = "Phone";
            // 
            // Input_phone
            // 
            Input_phone.BackColor = SystemColors.GrayText;
            Input_phone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Input_phone.Location = new Point(208, 76);
            Input_phone.Name = "Input_phone";
            Input_phone.ReadOnly = true;
            Input_phone.Size = new Size(334, 38);
            Input_phone.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 20);
            label4.Name = "label4";
            label4.Size = new Size(95, 41);
            label4.TabIndex = 15;
            label4.Text = "Email";
            // 
            // Button_Delete
            // 
            Button_Delete.BackColor = Color.FromArgb(255, 128, 128);
            Button_Delete.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_Delete.Location = new Point(29, 416);
            Button_Delete.Name = "Button_Delete";
            Button_Delete.Size = new Size(151, 76);
            Button_Delete.TabIndex = 20;
            Button_Delete.Text = "Delete";
            Button_Delete.UseVisualStyleBackColor = false;
            Button_Delete.Click += Button_Delete_Click;
            // 
            // Button_Cancel
            // 
            Button_Cancel.BackColor = Color.FromArgb(255, 192, 128);
            Button_Cancel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_Cancel.ForeColor = SystemColors.ActiveCaptionText;
            Button_Cancel.Location = new Point(610, 416);
            Button_Cancel.Name = "Button_Cancel";
            Button_Cancel.Size = new Size(151, 76);
            Button_Cancel.TabIndex = 19;
            Button_Cancel.Text = "Cancel";
            Button_Cancel.UseVisualStyleBackColor = false;
            Button_Cancel.Click += Button_Cancel_Click;
            // 
            // Button_Update
            // 
            Button_Update.BackColor = Color.FromArgb(128, 255, 128);
            Button_Update.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_Update.Location = new Point(443, 416);
            Button_Update.Name = "Button_Update";
            Button_Update.Size = new Size(151, 76);
            Button_Update.TabIndex = 18;
            Button_Update.Text = "Update";
            Button_Update.UseVisualStyleBackColor = false;
            Button_Update.Click += Button_Update_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(186, 416);
            button1.Name = "button1";
            button1.Size = new Size(151, 76);
            button1.TabIndex = 21;
            button1.Text = "Activate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frm_updateCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 504);
            Controls.Add(button1);
            Controls.Add(Button_Delete);
            Controls.Add(Button_Cancel);
            Controls.Add(Button_Update);
            Controls.Add(panel1);
            Controls.Add(button_search);
            Controls.Add(label1);
            Controls.Add(Input_CompanyName);
            Name = "frm_updateCustomers";
            Text = "Update Customer";
            Load += frm_updateCustomers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_search;
        private Label label1;
        private TextBox Input_CompanyName;
        private Panel panel1;
        private Label label2;
        private TextBox Input_address;
        private Label label3;
        private TextBox Input_phone;
        private Label label4;
        private Button Button_Delete;
        private Button Button_Cancel;
        private Button Button_Update;
        private Label label5;
        private TextBox Input_representative;
        private TextBox Input_email;
        private Label label6;
        private TextBox Box_status;
        private Button button1;
    }
}