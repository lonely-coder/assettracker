namespace FAS
{
    partial class uc_item_receipt
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_error_price = new System.Windows.Forms.Label();
            this.lbl_warranty_error = new System.Windows.Forms.Label();
            this.lbl_dop_error = new System.Windows.Forms.Label();
            this.lbl_vendor_error = new System.Windows.Forms.Label();
            this.lbl_receipt_error = new System.Windows.Forms.Label();
            this.lbl_error_quantity = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_vendor = new System.Windows.Forms.Label();
            this.dtpicker_warrantyperoiod = new System.Windows.Forms.DateTimePicker();
            this.dtpicker_dateofpurchase = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown_quantity = new System.Windows.Forms.NumericUpDown();
            this.txt_price = new MetroFramework.Controls.MetroTextBox();
            this.txt_official_receipt = new MetroFramework.Controls.MetroTextBox();
            this.cb_vendors = new MetroFramework.Controls.MetroComboBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // lbl_error_price
            // 
            this.lbl_error_price.AutoSize = true;
            this.lbl_error_price.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_price.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_price.Location = new System.Drawing.Point(216, 292);
            this.lbl_error_price.Name = "lbl_error_price";
            this.lbl_error_price.Size = new System.Drawing.Size(106, 20);
            this.lbl_error_price.TabIndex = 148;
            this.lbl_error_price.Text = "-Invalid price";
            this.lbl_error_price.Visible = false;
            // 
            // lbl_warranty_error
            // 
            this.lbl_warranty_error.AutoSize = true;
            this.lbl_warranty_error.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warranty_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_warranty_error.Location = new System.Drawing.Point(287, 235);
            this.lbl_warranty_error.Name = "lbl_warranty_error";
            this.lbl_warranty_error.Size = new System.Drawing.Size(186, 20);
            this.lbl_warranty_error.TabIndex = 147;
            this.lbl_warranty_error.Text = "-Invalid warranty period";
            this.lbl_warranty_error.Visible = false;
            // 
            // lbl_dop_error
            // 
            this.lbl_dop_error.AutoSize = true;
            this.lbl_dop_error.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dop_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_dop_error.Location = new System.Drawing.Point(294, 178);
            this.lbl_dop_error.Name = "lbl_dop_error";
            this.lbl_dop_error.Size = new System.Drawing.Size(195, 20);
            this.lbl_dop_error.TabIndex = 146;
            this.lbl_dop_error.Text = "-Invalid date of purchase";
            this.lbl_dop_error.Visible = false;
            // 
            // lbl_vendor_error
            // 
            this.lbl_vendor_error.AutoSize = true;
            this.lbl_vendor_error.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendor_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_vendor_error.Location = new System.Drawing.Point(250, 57);
            this.lbl_vendor_error.Name = "lbl_vendor_error";
            this.lbl_vendor_error.Size = new System.Drawing.Size(182, 20);
            this.lbl_vendor_error.TabIndex = 145;
            this.lbl_vendor_error.Text = "-Please select a vendor";
            this.lbl_vendor_error.Visible = false;
            // 
            // lbl_receipt_error
            // 
            this.lbl_receipt_error.AutoSize = true;
            this.lbl_receipt_error.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_receipt_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_receipt_error.Location = new System.Drawing.Point(250, 117);
            this.lbl_receipt_error.Name = "lbl_receipt_error";
            this.lbl_receipt_error.Size = new System.Drawing.Size(125, 20);
            this.lbl_receipt_error.TabIndex = 144;
            this.lbl_receipt_error.Text = "-Invalid Receipt";
            this.lbl_receipt_error.Visible = false;
            // 
            // lbl_error_quantity
            // 
            this.lbl_error_quantity.AutoSize = true;
            this.lbl_error_quantity.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_quantity.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_quantity.Location = new System.Drawing.Point(233, 353);
            this.lbl_error_quantity.Name = "lbl_error_quantity";
            this.lbl_error_quantity.Size = new System.Drawing.Size(130, 20);
            this.lbl_error_quantity.TabIndex = 143;
            this.lbl_error_quantity.Text = "-Invalid Quantity";
            this.lbl_error_quantity.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(156, 292);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 20);
            this.label14.TabIndex = 142;
            this.label14.Text = "Price";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(156, 353);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 20);
            this.label13.TabIndex = 141;
            this.label13.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(154, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 140;
            this.label8.Text = "Warranty Period";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(154, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 20);
            this.label7.TabIndex = 139;
            this.label7.Text = "Date Of Purchase";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(154, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 138;
            this.label6.Text = "O.R#/P.O#";
            // 
            // lbl_vendor
            // 
            this.lbl_vendor.AutoSize = true;
            this.lbl_vendor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_vendor.Location = new System.Drawing.Point(154, 57);
            this.lbl_vendor.Name = "lbl_vendor";
            this.lbl_vendor.Size = new System.Drawing.Size(64, 20);
            this.lbl_vendor.TabIndex = 137;
            this.lbl_vendor.Text = "Vendor";
            // 
            // dtpicker_warrantyperoiod
            // 
            this.dtpicker_warrantyperoiod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicker_warrantyperoiod.Location = new System.Drawing.Point(160, 258);
            this.dtpicker_warrantyperoiod.Name = "dtpicker_warrantyperoiod";
            this.dtpicker_warrantyperoiod.Size = new System.Drawing.Size(323, 26);
            this.dtpicker_warrantyperoiod.TabIndex = 134;
            // 
            // dtpicker_dateofpurchase
            // 
            this.dtpicker_dateofpurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicker_dateofpurchase.Location = new System.Drawing.Point(158, 201);
            this.dtpicker_dateofpurchase.Name = "dtpicker_dateofpurchase";
            this.dtpicker_dateofpurchase.Size = new System.Drawing.Size(323, 26);
            this.dtpicker_dateofpurchase.TabIndex = 133;
            // 
            // numericUpDown_quantity
            // 
            this.numericUpDown_quantity.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_quantity.Location = new System.Drawing.Point(158, 376);
            this.numericUpDown_quantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_quantity.Name = "numericUpDown_quantity";
            this.numericUpDown_quantity.Size = new System.Drawing.Size(109, 33);
            this.numericUpDown_quantity.TabIndex = 130;
            // 
            // txt_price
            // 
            // 
            // 
            // 
            this.txt_price.CustomButton.Image = null;
            this.txt_price.CustomButton.Location = new System.Drawing.Point(136, 2);
            this.txt_price.CustomButton.Name = "";
            this.txt_price.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_price.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_price.CustomButton.TabIndex = 1;
            this.txt_price.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_price.CustomButton.UseSelectable = true;
            this.txt_price.CustomButton.Visible = false;
            this.txt_price.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_price.Lines = new string[0];
            this.txt_price.Location = new System.Drawing.Point(158, 315);
            this.txt_price.MaxLength = 15;
            this.txt_price.Name = "txt_price";
            this.txt_price.PasswordChar = '\0';
            this.txt_price.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_price.SelectedText = "";
            this.txt_price.SelectionLength = 0;
            this.txt_price.SelectionStart = 0;
            this.txt_price.ShortcutsEnabled = true;
            this.txt_price.Size = new System.Drawing.Size(164, 30);
            this.txt_price.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_price.TabIndex = 135;
            this.txt_price.UseSelectable = true;
            this.txt_price.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_price.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txt_official_receipt
            // 
            // 
            // 
            // 
            this.txt_official_receipt.CustomButton.Image = null;
            this.txt_official_receipt.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.txt_official_receipt.CustomButton.Name = "";
            this.txt_official_receipt.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_official_receipt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_official_receipt.CustomButton.TabIndex = 1;
            this.txt_official_receipt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_official_receipt.CustomButton.UseSelectable = true;
            this.txt_official_receipt.CustomButton.Visible = false;
            this.txt_official_receipt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_official_receipt.Lines = new string[0];
            this.txt_official_receipt.Location = new System.Drawing.Point(158, 140);
            this.txt_official_receipt.MaxLength = 50;
            this.txt_official_receipt.Name = "txt_official_receipt";
            this.txt_official_receipt.PasswordChar = '\0';
            this.txt_official_receipt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_official_receipt.SelectedText = "";
            this.txt_official_receipt.SelectionLength = 0;
            this.txt_official_receipt.SelectionStart = 0;
            this.txt_official_receipt.ShortcutsEnabled = true;
            this.txt_official_receipt.Size = new System.Drawing.Size(202, 30);
            this.txt_official_receipt.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_official_receipt.TabIndex = 132;
            this.txt_official_receipt.UseSelectable = true;
            this.txt_official_receipt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_official_receipt.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cb_vendors
            // 
            this.cb_vendors.FormattingEnabled = true;
            this.cb_vendors.ItemHeight = 23;
            this.cb_vendors.Location = new System.Drawing.Point(158, 80);
            this.cb_vendors.Name = "cb_vendors";
            this.cb_vendors.Size = new System.Drawing.Size(323, 29);
            this.cb_vendors.Style = MetroFramework.MetroColorStyle.Teal;
            this.cb_vendors.TabIndex = 131;
            this.cb_vendors.UseSelectable = true;
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(94)))));
            this.btn_next.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(94)))));
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_next.Location = new System.Drawing.Point(388, 442);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(93, 52);
            this.btn_next.TabIndex = 149;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = false;
            // 
            // btn_back
            // 
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(158, 442);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(93, 52);
            this.btn_back.TabIndex = 150;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // uc_item_receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.lbl_error_price);
            this.Controls.Add(this.lbl_warranty_error);
            this.Controls.Add(this.lbl_dop_error);
            this.Controls.Add(this.lbl_vendor_error);
            this.Controls.Add(this.lbl_receipt_error);
            this.Controls.Add(this.lbl_error_quantity);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_vendor);
            this.Controls.Add(this.dtpicker_warrantyperoiod);
            this.Controls.Add(this.dtpicker_dateofpurchase);
            this.Controls.Add(this.numericUpDown_quantity);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_official_receipt);
            this.Controls.Add(this.cb_vendors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "uc_item_receipt";
            this.Size = new System.Drawing.Size(697, 538);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_error_price;
        private System.Windows.Forms.Label lbl_warranty_error;
        private System.Windows.Forms.Label lbl_dop_error;
        private System.Windows.Forms.Label lbl_vendor_error;
        private System.Windows.Forms.Label lbl_receipt_error;
        private System.Windows.Forms.Label lbl_error_quantity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_vendor;
        private System.Windows.Forms.DateTimePicker dtpicker_warrantyperoiod;
        private System.Windows.Forms.DateTimePicker dtpicker_dateofpurchase;
        private System.Windows.Forms.NumericUpDown numericUpDown_quantity;
        private MetroFramework.Controls.MetroTextBox txt_price;
        private MetroFramework.Controls.MetroTextBox txt_official_receipt;
        private MetroFramework.Controls.MetroComboBox cb_vendors;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_back;
    }
}
