using System.Drawing;
using System.Windows.Forms;

namespace SoftwareProject
{
    partial class frm_inventory_addStock
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
            button_newItem = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button_newItem
            // 
            button_newItem.BackColor = Color.Moccasin;
            button_newItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_newItem.Location = new Point(396, 100);
            button_newItem.Name = "button_newItem";
            button_newItem.Size = new Size(178, 81);
            button_newItem.TabIndex = 1;
            button_newItem.Text = "Add New Item";
            button_newItem.UseVisualStyleBackColor = false;
            button_newItem.Click += button_newItem_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(144, 100);
            button2.Name = "button2";
            button2.Size = new Size(178, 81);
            button2.TabIndex = 2;
            button2.Text = "Add Existing Stock";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // frm_inventory_addStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(700, 338);
            Controls.Add(button2);
            Controls.Add(button_newItem);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frm_inventory_addStock";
            Text = "Add Stock";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button_newItem;
        private Button button2;
    }
}