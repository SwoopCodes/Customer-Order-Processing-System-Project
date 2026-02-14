namespace SoftwareProject
{
    partial class frm_customers_addCustomers
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
            Input_CompanyName = new TextBox();
            label2 = new Label();
            Input_email = new TextBox();
            label3 = new Label();
            Input_phone = new TextBox();
            label4 = new Label();
            Input_address = new TextBox();
            label5 = new Label();
            Input_Representative = new TextBox();
            Button_Cancel = new Button();
            Button_Update = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 22);
            label1.Name = "label1";
            label1.Size = new Size(242, 41);
            label1.TabIndex = 14;
            label1.Text = "Company Name";
            // 
            // Input_CompanyName
            // 
            Input_CompanyName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Input_CompanyName.Location = new Point(269, 25);
            Input_CompanyName.Name = "Input_CompanyName";
            Input_CompanyName.Size = new Size(348, 38);
            Input_CompanyName.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 79);
            label2.Name = "label2";
            label2.Size = new Size(95, 41);
            label2.TabIndex = 16;
            label2.Text = "Email";
            // 
            // Input_email
            // 
            Input_email.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Input_email.Location = new Point(260, 82);
            Input_email.Name = "Input_email";
            Input_email.Size = new Size(280, 38);
            Input_email.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 135);
            label3.Name = "label3";
            label3.Size = new Size(106, 41);
            label3.TabIndex = 18;
            label3.Text = "Phone";
            // 
            // Input_phone
            // 
            Input_phone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Input_phone.Location = new Point(260, 138);
            Input_phone.Name = "Input_phone";
            Input_phone.Size = new Size(224, 38);
            Input_phone.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 192);
            label4.Name = "label4";
            label4.Size = new Size(131, 41);
            label4.TabIndex = 20;
            label4.Text = "Address";
            label4.Click += label4_Click;
            // 
            // Input_address
            // 
            Input_address.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Input_address.Location = new Point(260, 195);
            Input_address.Name = "Input_address";
            Input_address.Size = new Size(453, 38);
            Input_address.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 251);
            label5.Name = "label5";
            label5.Size = new Size(228, 41);
            label5.TabIndex = 22;
            label5.Text = "Representative";
            // 
            // Input_Representative
            // 
            Input_Representative.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Input_Representative.Location = new Point(260, 254);
            Input_Representative.Name = "Input_Representative";
            Input_Representative.Size = new Size(305, 38);
            Input_Representative.TabIndex = 21;
            // 
            // Button_Cancel
            // 
            Button_Cancel.BackColor = Color.FromArgb(255, 192, 128);
            Button_Cancel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_Cancel.ForeColor = SystemColors.ActiveCaptionText;
            Button_Cancel.Location = new Point(631, 362);
            Button_Cancel.Name = "Button_Cancel";
            Button_Cancel.Size = new Size(151, 76);
            Button_Cancel.TabIndex = 24;
            Button_Cancel.Text = "Cancel";
            Button_Cancel.UseVisualStyleBackColor = false;
            // 
            // Button_Update
            // 
            Button_Update.BackColor = Color.FromArgb(128, 255, 128);
            Button_Update.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_Update.Location = new Point(461, 362);
            Button_Update.Name = "Button_Update";
            Button_Update.Size = new Size(151, 76);
            Button_Update.TabIndex = 23;
            Button_Update.Text = "Update";
            Button_Update.UseVisualStyleBackColor = false;
            Button_Update.Click += Button_Update_Click;
            // 
            // frm_customers_addCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(Button_Cancel);
            Controls.Add(Button_Update);
            Controls.Add(label5);
            Controls.Add(Input_Representative);
            Controls.Add(label4);
            Controls.Add(Input_address);
            Controls.Add(label3);
            Controls.Add(Input_phone);
            Controls.Add(label2);
            Controls.Add(Input_email);
            Controls.Add(label1);
            Controls.Add(Input_CompanyName);
            Name = "frm_customers_addCustomers";
            Text = "Add Customer";
            Load += frm_customers_addCustomers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Input_CompanyName;
        private Label label2;
        private TextBox Input_email;
        private Label label3;
        private TextBox Input_phone;
        private Label label4;
        private TextBox Input_address;
        private Label label5;
        private TextBox Input_Representative;
        private Button Button_Cancel;
        private Button Button_Update;
    }
}