namespace FAS
{
    partial class frm_add_vendors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_add_vendors));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_vendorName = new MetroFramework.Controls.MetroTextBox();
            this.txt_address = new MetroFramework.Controls.MetroTextBox();
            this.txt_contactNumber = new MetroFramework.Controls.MetroTextBox();
            this.txt_email = new MetroFramework.Controls.MetroTextBox();
            this.txt_tags = new MetroFramework.Controls.MetroTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(45, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendor Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(45, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(45, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contact # : ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button2.Location = new System.Drawing.Point(290, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(45, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tags : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(45, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email Address : ";
            // 
            // txt_vendorName
            // 
            // 
            // 
            // 
            this.txt_vendorName.CustomButton.Image = null;
            this.txt_vendorName.CustomButton.Location = new System.Drawing.Point(298, 2);
            this.txt_vendorName.CustomButton.Name = "";
            this.txt_vendorName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_vendorName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_vendorName.CustomButton.TabIndex = 1;
            this.txt_vendorName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_vendorName.CustomButton.UseSelectable = true;
            this.txt_vendorName.CustomButton.Visible = false;
            this.txt_vendorName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_vendorName.Lines = new string[0];
            this.txt_vendorName.Location = new System.Drawing.Point(49, 84);
            this.txt_vendorName.MaxLength = 32767;
            this.txt_vendorName.Name = "txt_vendorName";
            this.txt_vendorName.PasswordChar = '\0';
            this.txt_vendorName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_vendorName.SelectedText = "";
            this.txt_vendorName.SelectionLength = 0;
            this.txt_vendorName.SelectionStart = 0;
            this.txt_vendorName.ShortcutsEnabled = true;
            this.txt_vendorName.Size = new System.Drawing.Size(326, 30);
            this.txt_vendorName.TabIndex = 13;
            this.txt_vendorName.UseSelectable = true;
            this.txt_vendorName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_vendorName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_address
            // 
            // 
            // 
            // 
            this.txt_address.CustomButton.Image = null;
            this.txt_address.CustomButton.Location = new System.Drawing.Point(298, 2);
            this.txt_address.CustomButton.Name = "";
            this.txt_address.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_address.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_address.CustomButton.TabIndex = 1;
            this.txt_address.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_address.CustomButton.UseSelectable = true;
            this.txt_address.CustomButton.Visible = false;
            this.txt_address.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_address.Lines = new string[0];
            this.txt_address.Location = new System.Drawing.Point(49, 140);
            this.txt_address.MaxLength = 32767;
            this.txt_address.Name = "txt_address";
            this.txt_address.PasswordChar = '\0';
            this.txt_address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_address.SelectedText = "";
            this.txt_address.SelectionLength = 0;
            this.txt_address.SelectionStart = 0;
            this.txt_address.ShortcutsEnabled = true;
            this.txt_address.Size = new System.Drawing.Size(326, 30);
            this.txt_address.TabIndex = 14;
            this.txt_address.UseSelectable = true;
            this.txt_address.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_address.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_contactNumber
            // 
            // 
            // 
            // 
            this.txt_contactNumber.CustomButton.Image = null;
            this.txt_contactNumber.CustomButton.Location = new System.Drawing.Point(298, 2);
            this.txt_contactNumber.CustomButton.Name = "";
            this.txt_contactNumber.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_contactNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_contactNumber.CustomButton.TabIndex = 1;
            this.txt_contactNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_contactNumber.CustomButton.UseSelectable = true;
            this.txt_contactNumber.CustomButton.Visible = false;
            this.txt_contactNumber.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_contactNumber.Lines = new string[0];
            this.txt_contactNumber.Location = new System.Drawing.Point(49, 196);
            this.txt_contactNumber.MaxLength = 32767;
            this.txt_contactNumber.Name = "txt_contactNumber";
            this.txt_contactNumber.PasswordChar = '\0';
            this.txt_contactNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_contactNumber.SelectedText = "";
            this.txt_contactNumber.SelectionLength = 0;
            this.txt_contactNumber.SelectionStart = 0;
            this.txt_contactNumber.ShortcutsEnabled = true;
            this.txt_contactNumber.Size = new System.Drawing.Size(326, 30);
            this.txt_contactNumber.TabIndex = 15;
            this.txt_contactNumber.UseSelectable = true;
            this.txt_contactNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_contactNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_email
            // 
            // 
            // 
            // 
            this.txt_email.CustomButton.Image = null;
            this.txt_email.CustomButton.Location = new System.Drawing.Point(298, 2);
            this.txt_email.CustomButton.Name = "";
            this.txt_email.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_email.CustomButton.TabIndex = 1;
            this.txt_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_email.CustomButton.UseSelectable = true;
            this.txt_email.CustomButton.Visible = false;
            this.txt_email.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_email.Lines = new string[0];
            this.txt_email.Location = new System.Drawing.Point(49, 252);
            this.txt_email.MaxLength = 32767;
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_email.SelectedText = "";
            this.txt_email.SelectionLength = 0;
            this.txt_email.SelectionStart = 0;
            this.txt_email.ShortcutsEnabled = true;
            this.txt_email.Size = new System.Drawing.Size(326, 30);
            this.txt_email.TabIndex = 16;
            this.txt_email.UseSelectable = true;
            this.txt_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_tags
            // 
            // 
            // 
            // 
            this.txt_tags.CustomButton.Image = null;
            this.txt_tags.CustomButton.Location = new System.Drawing.Point(232, 1);
            this.txt_tags.CustomButton.Name = "";
            this.txt_tags.CustomButton.Size = new System.Drawing.Size(93, 93);
            this.txt_tags.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_tags.CustomButton.TabIndex = 1;
            this.txt_tags.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_tags.CustomButton.UseSelectable = true;
            this.txt_tags.CustomButton.Visible = false;
            this.txt_tags.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_tags.Lines = new string[0];
            this.txt_tags.Location = new System.Drawing.Point(49, 308);
            this.txt_tags.MaxLength = 32767;
            this.txt_tags.Multiline = true;
            this.txt_tags.Name = "txt_tags";
            this.txt_tags.PasswordChar = '\0';
            this.txt_tags.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_tags.SelectedText = "";
            this.txt_tags.SelectionLength = 0;
            this.txt_tags.SelectionStart = 0;
            this.txt_tags.ShortcutsEnabled = true;
            this.txt_tags.Size = new System.Drawing.Size(326, 95);
            this.txt_tags.TabIndex = 17;
            this.txt_tags.UseSelectable = true;
            this.txt_tags.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_tags.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(127)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(127)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(192, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_add_vendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 540);
            this.Controls.Add(this.txt_tags);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_contactNumber);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_vendorName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_add_vendors";
            this.Text = "Add Vendor";
            this.Load += new System.EventHandler(this.frm_addVendors_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_addVendors_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txt_vendorName;
        private MetroFramework.Controls.MetroTextBox txt_address;
        private MetroFramework.Controls.MetroTextBox txt_contactNumber;
        private MetroFramework.Controls.MetroTextBox txt_email;
        private MetroFramework.Controls.MetroTextBox txt_tags;
    }
}