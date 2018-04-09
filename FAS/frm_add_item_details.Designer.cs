namespace FAS
{
    partial class frm_add_item_details
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
            this.txt_brand = new MetroFramework.Controls.MetroTextBox();
            this.cb_category = new MetroFramework.Controls.MetroComboBox();
            this.cb_sub_category = new MetroFramework.Controls.MetroComboBox();
            this.txt_model = new MetroFramework.Controls.MetroTextBox();
            this.txt_description = new MetroFramework.Controls.MetroTextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // txt_brand
            // 
            // 
            // 
            // 
            this.txt_brand.CustomButton.Image = null;
            this.txt_brand.CustomButton.Location = new System.Drawing.Point(267, 2);
            this.txt_brand.CustomButton.Name = "";
            this.txt_brand.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_brand.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_brand.CustomButton.TabIndex = 1;
            this.txt_brand.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_brand.CustomButton.UseSelectable = true;
            this.txt_brand.CustomButton.Visible = false;
            this.txt_brand.Lines = new string[0];
            this.txt_brand.Location = new System.Drawing.Point(40, 179);
            this.txt_brand.MaxLength = 32767;
            this.txt_brand.Name = "txt_brand";
            this.txt_brand.PasswordChar = '\0';
            this.txt_brand.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_brand.SelectedText = "";
            this.txt_brand.SelectionLength = 0;
            this.txt_brand.SelectionStart = 0;
            this.txt_brand.ShortcutsEnabled = true;
            this.txt_brand.Size = new System.Drawing.Size(295, 30);
            this.txt_brand.TabIndex = 0;
            this.txt_brand.UseSelectable = true;
            this.txt_brand.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_brand.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cb_category
            // 
            this.cb_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_category.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cb_category.FormattingEnabled = true;
            this.cb_category.ItemHeight = 29;
            this.cb_category.Location = new System.Drawing.Point(40, 63);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(295, 35);
            this.cb_category.TabIndex = 1;
            this.cb_category.UseSelectable = true;
            this.cb_category.SelectedIndexChanged += new System.EventHandler(this.cb_category_SelectedIndexChanged);
            // 
            // cb_sub_category
            // 
            this.cb_sub_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_sub_category.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cb_sub_category.FormattingEnabled = true;
            this.cb_sub_category.ItemHeight = 29;
            this.cb_sub_category.Location = new System.Drawing.Point(40, 122);
            this.cb_sub_category.Name = "cb_sub_category";
            this.cb_sub_category.Size = new System.Drawing.Size(295, 35);
            this.cb_sub_category.TabIndex = 2;
            this.cb_sub_category.UseSelectable = true;
            // 
            // txt_model
            // 
            // 
            // 
            // 
            this.txt_model.CustomButton.Image = null;
            this.txt_model.CustomButton.Location = new System.Drawing.Point(267, 2);
            this.txt_model.CustomButton.Name = "";
            this.txt_model.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_model.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_model.CustomButton.TabIndex = 1;
            this.txt_model.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_model.CustomButton.UseSelectable = true;
            this.txt_model.CustomButton.Visible = false;
            this.txt_model.Lines = new string[0];
            this.txt_model.Location = new System.Drawing.Point(40, 237);
            this.txt_model.MaxLength = 32767;
            this.txt_model.Name = "txt_model";
            this.txt_model.PasswordChar = '\0';
            this.txt_model.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_model.SelectedText = "";
            this.txt_model.SelectionLength = 0;
            this.txt_model.SelectionStart = 0;
            this.txt_model.ShortcutsEnabled = true;
            this.txt_model.Size = new System.Drawing.Size(295, 30);
            this.txt_model.TabIndex = 3;
            this.txt_model.UseSelectable = true;
            this.txt_model.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_model.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_description
            // 
            // 
            // 
            // 
            this.txt_description.CustomButton.Image = null;
            this.txt_description.CustomButton.Location = new System.Drawing.Point(267, 2);
            this.txt_description.CustomButton.Name = "";
            this.txt_description.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_description.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_description.CustomButton.TabIndex = 1;
            this.txt_description.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_description.CustomButton.UseSelectable = true;
            this.txt_description.CustomButton.Visible = false;
            this.txt_description.Lines = new string[0];
            this.txt_description.Location = new System.Drawing.Point(40, 300);
            this.txt_description.MaxLength = 32767;
            this.txt_description.Name = "txt_description";
            this.txt_description.PasswordChar = '\0';
            this.txt_description.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_description.SelectedText = "";
            this.txt_description.SelectionLength = 0;
            this.txt_description.SelectionStart = 0;
            this.txt_description.ShortcutsEnabled = true;
            this.txt_description.Size = new System.Drawing.Size(295, 30);
            this.txt_description.TabIndex = 4;
            this.txt_description.UseSelectable = true;
            this.txt_description.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_description.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(157, 399);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(86, 47);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(249, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 47);
            this.button2.TabIndex = 9;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(40, 350);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(208, 15);
            this.metroCheckBox1.TabIndex = 10;
            this.metroCheckBox1.Text = "Require Serial Number for this item";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // frm_add_item_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 469);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.cb_sub_category);
            this.Controls.Add(this.cb_category);
            this.Controls.Add(this.txt_brand);
            this.Name = "frm_add_item_details";
            this.Text = "Item Details";
            this.Load += new System.EventHandler(this.frm_add_item_details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_brand;
        private MetroFramework.Controls.MetroComboBox cb_category;
        private MetroFramework.Controls.MetroComboBox cb_sub_category;
        private MetroFramework.Controls.MetroTextBox txt_model;
        private MetroFramework.Controls.MetroTextBox txt_description;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button button2;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
    }
}