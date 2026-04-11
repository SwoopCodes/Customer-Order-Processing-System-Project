using System.Drawing;
using System.Windows.Forms;

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
            this.button_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Input_CompanyName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Box_status = new System.Windows.Forms.TextBox();
            this.Input_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Input_representative = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Input_address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Input_phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_search.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_search.Location = new System.Drawing.Point(615, 18);
            this.button_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(151, 44);
            this.button_search.TabIndex = 16;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 41);
            this.label1.TabIndex = 15;
            this.label1.Text = "Company Name";
            // 
            // Input_CompanyName
            // 
            this.Input_CompanyName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_CompanyName.Location = new System.Drawing.Point(290, 22);
            this.Input_CompanyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_CompanyName.Name = "Input_CompanyName";
            this.Input_CompanyName.Size = new System.Drawing.Size(319, 38);
            this.Input_CompanyName.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Box_status);
            this.panel1.Controls.Add(this.Input_email);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Input_representative);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Input_address);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Input_phone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(27, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 257);
            this.panel1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 41);
            this.label6.TabIndex = 30;
            this.label6.Text = "Status:";
            // 
            // Box_status
            // 
            this.Box_status.BackColor = System.Drawing.SystemColors.GrayText;
            this.Box_status.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_status.Location = new System.Drawing.Point(159, 205);
            this.Box_status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Box_status.Name = "Box_status";
            this.Box_status.ReadOnly = true;
            this.Box_status.Size = new System.Drawing.Size(286, 38);
            this.Box_status.TabIndex = 29;
            // 
            // Input_email
            // 
            this.Input_email.BackColor = System.Drawing.SystemColors.GrayText;
            this.Input_email.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_email.Location = new System.Drawing.Point(208, 16);
            this.Input_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_email.Name = "Input_email";
            this.Input_email.ReadOnly = true;
            this.Input_email.Size = new System.Drawing.Size(334, 38);
            this.Input_email.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 41);
            this.label5.TabIndex = 27;
            this.label5.Text = "Representative";
            // 
            // Input_representative
            // 
            this.Input_representative.BackColor = System.Drawing.SystemColors.GrayText;
            this.Input_representative.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_representative.Location = new System.Drawing.Point(263, 157);
            this.Input_representative.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_representative.Name = "Input_representative";
            this.Input_representative.ReadOnly = true;
            this.Input_representative.Size = new System.Drawing.Size(286, 38);
            this.Input_representative.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 41);
            this.label2.TabIndex = 21;
            this.label2.Text = "Address";
            // 
            // Input_address
            // 
            this.Input_address.BackColor = System.Drawing.SystemColors.GrayText;
            this.Input_address.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_address.Location = new System.Drawing.Point(208, 108);
            this.Input_address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_address.Name = "Input_address";
            this.Input_address.ReadOnly = true;
            this.Input_address.Size = new System.Drawing.Size(451, 38);
            this.Input_address.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 41);
            this.label3.TabIndex = 19;
            this.label3.Text = "Phone";
            // 
            // Input_phone
            // 
            this.Input_phone.BackColor = System.Drawing.SystemColors.GrayText;
            this.Input_phone.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_phone.Location = new System.Drawing.Point(208, 61);
            this.Input_phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_phone.Name = "Input_phone";
            this.Input_phone.ReadOnly = true;
            this.Input_phone.Size = new System.Drawing.Size(334, 38);
            this.Input_phone.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 41);
            this.label4.TabIndex = 15;
            this.label4.Text = "Email";
            // 
            // Button_Delete
            // 
            this.Button_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Button_Delete.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Delete.Location = new System.Drawing.Point(29, 333);
            this.Button_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(151, 61);
            this.Button_Delete.TabIndex = 20;
            this.Button_Delete.Text = "Delete";
            this.Button_Delete.UseVisualStyleBackColor = false;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Button_Cancel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_Cancel.Location = new System.Drawing.Point(610, 333);
            this.Button_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(151, 61);
            this.Button_Cancel.TabIndex = 19;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = false;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_Update
            // 
            this.Button_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Button_Update.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Update.Location = new System.Drawing.Point(443, 333);
            this.Button_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(151, 61);
            this.Button_Update.TabIndex = 18;
            this.Button_Update.Text = "Update";
            this.Button_Update.UseVisualStyleBackColor = false;
            this.Button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(186, 333);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 61);
            this.button1.TabIndex = 21;
            this.button1.Text = "Activate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_updateCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(809, 403);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Update);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Input_CompanyName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_updateCustomers";
            this.Text = "Update Customer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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