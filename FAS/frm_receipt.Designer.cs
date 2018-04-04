namespace FAS
{
    partial class frm_receipt
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.txt_or = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_quantity = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_price = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(712, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(127)))));
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_save.Image = global::FAS.Properties.Resources.save;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(620, 328);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(86, 46);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.button2_Click);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 29;
            this.metroComboBox1.Location = new System.Drawing.Point(27, 84);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(363, 35);
            this.metroComboBox1.TabIndex = 15;
            this.metroComboBox1.UseSelectable = true;
            // 
            // txt_or
            // 
            // 
            // 
            // 
            this.txt_or.CustomButton.Image = null;
            this.txt_or.CustomButton.Location = new System.Drawing.Point(329, 1);
            this.txt_or.CustomButton.Name = "";
            this.txt_or.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txt_or.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_or.CustomButton.TabIndex = 1;
            this.txt_or.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_or.CustomButton.UseSelectable = true;
            this.txt_or.CustomButton.Visible = false;
            this.txt_or.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_or.Lines = new string[0];
            this.txt_or.Location = new System.Drawing.Point(27, 142);
            this.txt_or.MaxLength = 32767;
            this.txt_or.Name = "txt_or";
            this.txt_or.PasswordChar = '\0';
            this.txt_or.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_or.SelectedText = "";
            this.txt_or.SelectionLength = 0;
            this.txt_or.SelectionStart = 0;
            this.txt_or.Size = new System.Drawing.Size(363, 35);
            this.txt_or.TabIndex = 27;
            this.txt_or.UseSelectable = true;
            this.txt_or.WaterMark = "Official Receipt";
            this.txt_or.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_or.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Vendor :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Official Receipt :";
            // 
            // txt_quantity
            // 
            // 
            // 
            // 
            this.txt_quantity.CustomButton.Image = null;
            this.txt_quantity.CustomButton.Location = new System.Drawing.Point(329, 1);
            this.txt_quantity.CustomButton.Name = "";
            this.txt_quantity.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txt_quantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_quantity.CustomButton.TabIndex = 1;
            this.txt_quantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_quantity.CustomButton.UseSelectable = true;
            this.txt_quantity.CustomButton.Visible = false;
            this.txt_quantity.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_quantity.Lines = new string[0];
            this.txt_quantity.Location = new System.Drawing.Point(424, 200);
            this.txt_quantity.MaxLength = 32767;
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.PasswordChar = '\0';
            this.txt_quantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_quantity.SelectedText = "";
            this.txt_quantity.SelectionLength = 0;
            this.txt_quantity.SelectionStart = 0;
            this.txt_quantity.Size = new System.Drawing.Size(363, 35);
            this.txt_quantity.TabIndex = 32;
            this.txt_quantity.UseSelectable = true;
            this.txt_quantity.WaterMark = "Quantity";
            this.txt_quantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_quantity.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Quantity : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(421, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Date Purchased : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(424, 84);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(363, 33);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(421, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Warranty Period : ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(424, 142);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(363, 33);
            this.dateTimePicker2.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Price";
            // 
            // txt_price
            // 
            // 
            // 
            // 
            this.txt_price.CustomButton.Image = null;
            this.txt_price.CustomButton.Location = new System.Drawing.Point(329, 1);
            this.txt_price.CustomButton.Name = "";
            this.txt_price.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txt_price.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_price.CustomButton.TabIndex = 1;
            this.txt_price.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_price.CustomButton.UseSelectable = true;
            this.txt_price.CustomButton.Visible = false;
            this.txt_price.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_price.Lines = new string[0];
            this.txt_price.Location = new System.Drawing.Point(27, 258);
            this.txt_price.MaxLength = 32767;
            this.txt_price.Name = "txt_price";
            this.txt_price.PasswordChar = '\0';
            this.txt_price.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_price.SelectedText = "";
            this.txt_price.SelectionLength = 0;
            this.txt_price.SelectionStart = 0;
            this.txt_price.Size = new System.Drawing.Size(363, 35);
            this.txt_price.TabIndex = 39;
            this.txt_price.UseSelectable = true;
            this.txt_price.WaterMark = "Price";
            this.txt_price.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_price.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "Serial Number : ";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(329, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(27, 200);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.Size = new System.Drawing.Size(363, 35);
            this.metroTextBox1.TabIndex = 40;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "N/A";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTextBox1.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            // 
            // frm_receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 397);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_or);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.button1);
            this.Name = "frm_receipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Item Receipt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_save;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTextBox txt_or;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txt_quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox txt_price;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
    }
}