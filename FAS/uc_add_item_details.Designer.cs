namespace FAS
{
    partial class uc_add_item_details
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_next = new System.Windows.Forms.Button();
            this.checkbox_has_serial = new MetroFramework.Controls.MetroCheckBox();
            this.cb_sub_category = new MetroFramework.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_category = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_brand = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_model = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_next);
            this.panel1.Controls.Add(this.checkbox_has_serial);
            this.panel1.Controls.Add(this.cb_sub_category);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cb_category);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_brand);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_model);
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 478);
            this.panel1.TabIndex = 1;
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(94)))));
            this.btn_next.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(94)))));
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_next.Location = new System.Drawing.Point(422, 328);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(86, 46);
            this.btn_next.TabIndex = 20;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // checkbox_has_serial
            // 
            this.checkbox_has_serial.AutoSize = true;
            this.checkbox_has_serial.BackColor = System.Drawing.Color.Gainsboro;
            this.checkbox_has_serial.Location = new System.Drawing.Point(169, 282);
            this.checkbox_has_serial.Name = "checkbox_has_serial";
            this.checkbox_has_serial.Size = new System.Drawing.Size(208, 15);
            this.checkbox_has_serial.TabIndex = 19;
            this.checkbox_has_serial.Text = "Require Serial Number for this item";
            this.checkbox_has_serial.UseSelectable = true;
            // 
            // cb_sub_category
            // 
            this.cb_sub_category.FormattingEnabled = true;
            this.cb_sub_category.ItemHeight = 23;
            this.cb_sub_category.Location = new System.Drawing.Point(169, 229);
            this.cb_sub_category.Name = "cb_sub_category";
            this.cb_sub_category.Size = new System.Drawing.Size(339, 29);
            this.cb_sub_category.TabIndex = 18;
            this.cb_sub_category.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Location = new System.Drawing.Point(165, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Sub-category";
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.ItemHeight = 23;
            this.cb_category.Location = new System.Drawing.Point(169, 169);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(339, 29);
            this.cb_category.TabIndex = 16;
            this.cb_category.UseSelectable = true;
            this.cb_category.SelectedIndexChanged += new System.EventHandler(this.cb_category_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(165, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Category";
            // 
            // txt_brand
            // 
            this.txt_brand.BackColor = System.Drawing.Color.Gainsboro;
            // 
            // 
            // 
            this.txt_brand.CustomButton.Image = null;
            this.txt_brand.CustomButton.Location = new System.Drawing.Point(157, 2);
            this.txt_brand.CustomButton.Name = "";
            this.txt_brand.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_brand.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_brand.CustomButton.TabIndex = 1;
            this.txt_brand.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_brand.CustomButton.UseSelectable = true;
            this.txt_brand.CustomButton.Visible = false;
            this.txt_brand.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_brand.Lines = new string[0];
            this.txt_brand.Location = new System.Drawing.Point(169, 108);
            this.txt_brand.MaxLength = 32767;
            this.txt_brand.Name = "txt_brand";
            this.txt_brand.PasswordChar = '\0';
            this.txt_brand.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_brand.SelectedText = "";
            this.txt_brand.SelectionLength = 0;
            this.txt_brand.SelectionStart = 0;
            this.txt_brand.ShortcutsEnabled = true;
            this.txt_brand.Size = new System.Drawing.Size(185, 30);
            this.txt_brand.TabIndex = 14;
            this.txt_brand.UseSelectable = true;
            this.txt_brand.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_brand.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(165, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Brand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(165, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Model";
            // 
            // txt_model
            // 
            this.txt_model.BackColor = System.Drawing.Color.Gainsboro;
            // 
            // 
            // 
            this.txt_model.CustomButton.Image = null;
            this.txt_model.CustomButton.Location = new System.Drawing.Point(311, 2);
            this.txt_model.CustomButton.Name = "";
            this.txt_model.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_model.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_model.CustomButton.TabIndex = 1;
            this.txt_model.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_model.CustomButton.UseSelectable = true;
            this.txt_model.CustomButton.Visible = false;
            this.txt_model.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_model.Lines = new string[0];
            this.txt_model.Location = new System.Drawing.Point(169, 52);
            this.txt_model.MaxLength = 32767;
            this.txt_model.Name = "txt_model";
            this.txt_model.PasswordChar = '\0';
            this.txt_model.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_model.SelectedText = "";
            this.txt_model.SelectionLength = 0;
            this.txt_model.SelectionStart = 0;
            this.txt_model.ShortcutsEnabled = true;
            this.txt_model.Size = new System.Drawing.Size(339, 30);
            this.txt_model.TabIndex = 11;
            this.txt_model.UseSelectable = true;
            this.txt_model.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_model.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_model.TextChanged += new System.EventHandler(this.txt_model_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Item Details";
            // 
            // uc_add_item_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "uc_add_item_details";
            this.Size = new System.Drawing.Size(697, 538);
            this.Load += new System.EventHandler(this.uc_add_item_details_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_next;
        private MetroFramework.Controls.MetroCheckBox checkbox_has_serial;
        private MetroFramework.Controls.MetroComboBox cb_sub_category;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroComboBox cb_category;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txt_brand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txt_model;
        private System.Windows.Forms.Label label1;
    }
}
