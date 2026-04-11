using System.Drawing;
using System.Windows.Forms;

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
            this.label1 = new System.Windows.Forms.Label();
            this.Input_CompanyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Input_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Input_phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Input_address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Input_Representative = new System.Windows.Forms.TextBox();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 41);
            this.label1.TabIndex = 14;
            this.label1.Text = "Company Name";
            // 
            // Input_CompanyName
            // 
            this.Input_CompanyName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_CompanyName.Location = new System.Drawing.Point(290, 18);
            this.Input_CompanyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_CompanyName.Name = "Input_CompanyName";
            this.Input_CompanyName.Size = new System.Drawing.Size(348, 38);
            this.Input_CompanyName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 41);
            this.label2.TabIndex = 16;
            this.label2.Text = "Email";
            // 
            // Input_email
            // 
            this.Input_email.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_email.Location = new System.Drawing.Point(290, 64);
            this.Input_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_email.Name = "Input_email";
            this.Input_email.Size = new System.Drawing.Size(280, 38);
            this.Input_email.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 41);
            this.label3.TabIndex = 18;
            this.label3.Text = "Phone";
            // 
            // Input_phone
            // 
            this.Input_phone.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_phone.Location = new System.Drawing.Point(290, 108);
            this.Input_phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_phone.Name = "Input_phone";
            this.Input_phone.Size = new System.Drawing.Size(224, 38);
            this.Input_phone.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 41);
            this.label4.TabIndex = 20;
            this.label4.Text = "Address";
            // 
            // Input_address
            // 
            this.Input_address.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_address.Location = new System.Drawing.Point(290, 154);
            this.Input_address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_address.Name = "Input_address";
            this.Input_address.Size = new System.Drawing.Size(453, 38);
            this.Input_address.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 41);
            this.label5.TabIndex = 22;
            this.label5.Text = "Representative";
            // 
            // Input_Representative
            // 
            this.Input_Representative.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Representative.Location = new System.Drawing.Point(290, 201);
            this.Input_Representative.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_Representative.Name = "Input_Representative";
            this.Input_Representative.Size = new System.Drawing.Size(305, 38);
            this.Input_Representative.TabIndex = 21;
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Button_Cancel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_Cancel.Location = new System.Drawing.Point(631, 290);
            this.Button_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(151, 61);
            this.Button_Cancel.TabIndex = 24;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = false;
            // 
            // Button_Update
            // 
            this.Button_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Button_Update.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Update.Location = new System.Drawing.Point(461, 290);
            this.Button_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(151, 61);
            this.Button_Update.TabIndex = 23;
            this.Button_Update.Text = "Update";
            this.Button_Update.UseVisualStyleBackColor = false;
            this.Button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // frm_customers_addCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Update);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Input_Representative);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Input_address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Input_phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Input_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Input_CompanyName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_customers_addCustomers";
            this.Text = "Add Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

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