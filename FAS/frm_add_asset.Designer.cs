namespace FAS
{
    partial class frm_add_asset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_add_asset));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn_save = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.date_acquired = new System.Windows.Forms.DateTimePicker();
            this.btn_browse_item = new System.Windows.Forms.Button();
            this.btn_browse_serial = new System.Windows.Forms.Button();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.txt_property_tag = new MetroFramework.Controls.MetroTextBox();
            this.txt_model = new MetroFramework.Controls.MetroTextBox();
            this.txt_description = new MetroFramework.Controls.MetroTextBox();
            this.txt_serial = new MetroFramework.Controls.MetroTextBox();
            this.txt_amount = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(127)))));
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(551, 343);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(85, 44);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(642, 343);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 44);
            this.button4.TabIndex = 12;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(413, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Date Aquired : ";
            // 
            // date_acquired
            // 
            this.date_acquired.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_acquired.Location = new System.Drawing.Point(416, 223);
            this.date_acquired.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_acquired.Name = "date_acquired";
            this.date_acquired.Size = new System.Drawing.Size(311, 29);
            this.date_acquired.TabIndex = 30;
            // 
            // btn_browse_item
            // 
            this.btn_browse_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(127)))));
            this.btn_browse_item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_browse_item.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btn_browse_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browse_item.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse_item.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_browse_item.Image = ((System.Drawing.Image)(resources.GetObject("btn_browse_item.Image")));
            this.btn_browse_item.Location = new System.Drawing.Point(328, 157);
            this.btn_browse_item.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_browse_item.Name = "btn_browse_item";
            this.btn_browse_item.Size = new System.Drawing.Size(40, 40);
            this.btn_browse_item.TabIndex = 32;
            this.btn_browse_item.UseVisualStyleBackColor = false;
            this.btn_browse_item.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_browse_serial
            // 
            this.btn_browse_serial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(127)))));
            this.btn_browse_serial.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btn_browse_serial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browse_serial.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse_serial.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_browse_serial.Image = ((System.Drawing.Image)(resources.GetObject("btn_browse_serial.Image")));
            this.btn_browse_serial.Location = new System.Drawing.Point(328, 292);
            this.btn_browse_serial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_browse_serial.Name = "btn_browse_serial";
            this.btn_browse_serial.Size = new System.Drawing.Size(40, 40);
            this.btn_browse_serial.TabIndex = 33;
            this.btn_browse_serial.UseVisualStyleBackColor = false;
            this.btn_browse_serial.Click += new System.EventHandler(this.button3_Click);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 29;
            this.metroComboBox1.Location = new System.Drawing.Point(416, 91);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(311, 35);
            this.metroComboBox1.TabIndex = 35;
            this.metroComboBox1.UseSelectable = true;
            // 
            // txt_property_tag
            // 
            // 
            // 
            // 
            this.txt_property_tag.CustomButton.Image = null;
            this.txt_property_tag.CustomButton.Location = new System.Drawing.Point(288, 2);
            this.txt_property_tag.CustomButton.Name = "";
            this.txt_property_tag.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txt_property_tag.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_property_tag.CustomButton.TabIndex = 1;
            this.txt_property_tag.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_property_tag.CustomButton.UseSelectable = true;
            this.txt_property_tag.CustomButton.Visible = false;
            this.txt_property_tag.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_property_tag.Lines = new string[0];
            this.txt_property_tag.Location = new System.Drawing.Point(42, 91);
            this.txt_property_tag.MaxLength = 32767;
            this.txt_property_tag.Name = "txt_property_tag";
            this.txt_property_tag.PasswordChar = '\0';
            this.txt_property_tag.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_property_tag.SelectedText = "";
            this.txt_property_tag.SelectionLength = 0;
            this.txt_property_tag.SelectionStart = 0;
            this.txt_property_tag.ShortcutsEnabled = true;
            this.txt_property_tag.Size = new System.Drawing.Size(326, 40);
            this.txt_property_tag.TabIndex = 38;
            this.txt_property_tag.UseSelectable = true;
            this.txt_property_tag.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_property_tag.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_property_tag.Leave += new System.EventHandler(this.txt_property_tag_Leave);
            // 
            // txt_model
            // 
            // 
            // 
            // 
            this.txt_model.CustomButton.Image = null;
            this.txt_model.CustomButton.Location = new System.Drawing.Point(242, 2);
            this.txt_model.CustomButton.Name = "";
            this.txt_model.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txt_model.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_model.CustomButton.TabIndex = 1;
            this.txt_model.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_model.CustomButton.UseSelectable = true;
            this.txt_model.CustomButton.Visible = false;
            this.txt_model.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_model.Lines = new string[0];
            this.txt_model.Location = new System.Drawing.Point(42, 157);
            this.txt_model.MaxLength = 32767;
            this.txt_model.Name = "txt_model";
            this.txt_model.PasswordChar = '\0';
            this.txt_model.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_model.SelectedText = "";
            this.txt_model.SelectionLength = 0;
            this.txt_model.SelectionStart = 0;
            this.txt_model.ShortcutsEnabled = true;
            this.txt_model.Size = new System.Drawing.Size(280, 40);
            this.txt_model.TabIndex = 39;
            this.txt_model.UseSelectable = true;
            this.txt_model.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_model.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_model.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_model_MouseClick);
            // 
            // txt_description
            // 
            // 
            // 
            // 
            this.txt_description.CustomButton.Image = null;
            this.txt_description.CustomButton.Location = new System.Drawing.Point(288, 2);
            this.txt_description.CustomButton.Name = "";
            this.txt_description.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txt_description.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_description.CustomButton.TabIndex = 1;
            this.txt_description.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_description.CustomButton.UseSelectable = true;
            this.txt_description.CustomButton.Visible = false;
            this.txt_description.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_description.Lines = new string[0];
            this.txt_description.Location = new System.Drawing.Point(42, 223);
            this.txt_description.MaxLength = 32767;
            this.txt_description.Name = "txt_description";
            this.txt_description.PasswordChar = '\0';
            this.txt_description.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_description.SelectedText = "";
            this.txt_description.SelectionLength = 0;
            this.txt_description.SelectionStart = 0;
            this.txt_description.ShortcutsEnabled = true;
            this.txt_description.Size = new System.Drawing.Size(326, 40);
            this.txt_description.TabIndex = 40;
            this.txt_description.UseSelectable = true;
            this.txt_description.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_description.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txt_serial
            // 
            // 
            // 
            // 
            this.txt_serial.CustomButton.Image = null;
            this.txt_serial.CustomButton.Location = new System.Drawing.Point(242, 2);
            this.txt_serial.CustomButton.Name = "";
            this.txt_serial.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txt_serial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_serial.CustomButton.TabIndex = 1;
            this.txt_serial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_serial.CustomButton.UseSelectable = true;
            this.txt_serial.CustomButton.Visible = false;
            this.txt_serial.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_serial.Lines = new string[0];
            this.txt_serial.Location = new System.Drawing.Point(42, 292);
            this.txt_serial.MaxLength = 32767;
            this.txt_serial.Name = "txt_serial";
            this.txt_serial.PasswordChar = '\0';
            this.txt_serial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_serial.SelectedText = "";
            this.txt_serial.SelectionLength = 0;
            this.txt_serial.SelectionStart = 0;
            this.txt_serial.ShortcutsEnabled = true;
            this.txt_serial.Size = new System.Drawing.Size(280, 40);
            this.txt_serial.TabIndex = 41;
            this.txt_serial.UseSelectable = true;
            this.txt_serial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_serial.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txt_amount
            // 
            // 
            // 
            // 
            this.txt_amount.CustomButton.Image = null;
            this.txt_amount.CustomButton.Location = new System.Drawing.Point(273, 2);
            this.txt_amount.CustomButton.Name = "";
            this.txt_amount.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txt_amount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_amount.CustomButton.TabIndex = 1;
            this.txt_amount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_amount.CustomButton.UseSelectable = true;
            this.txt_amount.CustomButton.Visible = false;
            this.txt_amount.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_amount.Lines = new string[0];
            this.txt_amount.Location = new System.Drawing.Point(416, 157);
            this.txt_amount.MaxLength = 32767;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.PasswordChar = '\0';
            this.txt_amount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_amount.SelectedText = "";
            this.txt_amount.SelectionLength = 0;
            this.txt_amount.SelectionStart = 0;
            this.txt_amount.ShortcutsEnabled = true;
            this.txt_amount.Size = new System.Drawing.Size(311, 40);
            this.txt_amount.TabIndex = 42;
            this.txt_amount.UseSelectable = true;
            this.txt_amount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_amount.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_amount_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Property Tag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "Serial Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(412, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Item Condtion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(415, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "Amount";
            // 
            // frm_add_asset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 423);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.txt_serial);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.txt_property_tag);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.btn_browse_serial);
            this.Controls.Add(this.btn_browse_item);
            this.Controls.Add(this.date_acquired);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_save);
            this.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frm_add_asset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Add Asset";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_acquired;
        private System.Windows.Forms.Button btn_browse_item;
        private System.Windows.Forms.Button btn_browse_serial;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTextBox txt_property_tag;
        internal MetroFramework.Controls.MetroTextBox txt_model;
        internal MetroFramework.Controls.MetroTextBox txt_description;
        internal MetroFramework.Controls.MetroTextBox txt_serial;
        internal MetroFramework.Controls.MetroTextBox txt_amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}