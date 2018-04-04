namespace FAS
{
    partial class frm_item_detail
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
            this.btn_update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.txt_brand = new MetroFramework.Controls.MetroTextBox();
            this.txt_model = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(239, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(127)))));
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(127)))));
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(153, 330);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(80, 40);
            this.btn_update.TabIndex = 6;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sub Category :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Model : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Brand : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Category : ";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 29;
            this.metroComboBox1.Location = new System.Drawing.Point(24, 85);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(296, 35);
            this.metroComboBox1.TabIndex = 14;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 29;
            this.metroComboBox2.Location = new System.Drawing.Point(23, 148);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(296, 35);
            this.metroComboBox2.TabIndex = 15;
            this.metroComboBox2.UseSelectable = true;
            // 
            // txt_brand
            // 
            // 
            // 
            // 
            this.txt_brand.CustomButton.Image = null;
            this.txt_brand.CustomButton.Location = new System.Drawing.Point(262, 1);
            this.txt_brand.CustomButton.Name = "";
            this.txt_brand.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txt_brand.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_brand.CustomButton.TabIndex = 1;
            this.txt_brand.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_brand.CustomButton.UseSelectable = true;
            this.txt_brand.CustomButton.Visible = false;
            this.txt_brand.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_brand.Lines = new string[0];
            this.txt_brand.Location = new System.Drawing.Point(23, 211);
            this.txt_brand.MaxLength = 32767;
            this.txt_brand.Name = "txt_brand";
            this.txt_brand.PasswordChar = '\0';
            this.txt_brand.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_brand.SelectedText = "";
            this.txt_brand.SelectionLength = 0;
            this.txt_brand.SelectionStart = 0;
            this.txt_brand.ShortcutsEnabled = true;
            this.txt_brand.Size = new System.Drawing.Size(296, 35);
            this.txt_brand.TabIndex = 20;
            this.txt_brand.UseSelectable = true;
            this.txt_brand.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_brand.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_model
            // 
            // 
            // 
            // 
            this.txt_model.CustomButton.Image = null;
            this.txt_model.CustomButton.Location = new System.Drawing.Point(262, 1);
            this.txt_model.CustomButton.Name = "";
            this.txt_model.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txt_model.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_model.CustomButton.TabIndex = 1;
            this.txt_model.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_model.CustomButton.UseSelectable = true;
            this.txt_model.CustomButton.Visible = false;
            this.txt_model.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_model.Lines = new string[0];
            this.txt_model.Location = new System.Drawing.Point(23, 273);
            this.txt_model.MaxLength = 32767;
            this.txt_model.Name = "txt_model";
            this.txt_model.PasswordChar = '\0';
            this.txt_model.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_model.SelectedText = "";
            this.txt_model.SelectionLength = 0;
            this.txt_model.SelectionStart = 0;
            this.txt_model.ShortcutsEnabled = true;
            this.txt_model.Size = new System.Drawing.Size(296, 35);
            this.txt_model.TabIndex = 21;
            this.txt_model.UseSelectable = true;
            this.txt_model.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_model.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frm_item_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 416);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.txt_brand);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "frm_item_detail";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Item Details";
            this.Load += new System.EventHandler(this.frm_item_detail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroTextBox txt_brand;
        private MetroFramework.Controls.MetroTextBox txt_model;
    }
}