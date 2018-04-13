namespace FAS
{
    partial class uc_item_serial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_serial = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dg_serialnumbers = new System.Windows.Forms.DataGridView();
            this.bt_add_serial = new System.Windows.Forms.Button();
            this.txt_serial = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_serialnumbers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.lbl_serial);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dg_serialnumbers);
            this.panel1.Controls.Add(this.bt_add_serial);
            this.panel1.Controls.Add(this.txt_serial);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 474);
            this.panel1.TabIndex = 0;
            // 
            // lbl_serial
            // 
            this.lbl_serial.AutoSize = true;
            this.lbl_serial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_serial.ForeColor = System.Drawing.Color.Red;
            this.lbl_serial.Location = new System.Drawing.Point(281, 24);
            this.lbl_serial.Name = "lbl_serial";
            this.lbl_serial.Size = new System.Drawing.Size(193, 17);
            this.lbl_serial.TabIndex = 127;
            this.lbl_serial.Text = "Please provide serial number";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(94)))));
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_back.Location = new System.Drawing.Point(154, 328);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(98, 50);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(94)))));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(94)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(387, 328);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(98, 50);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(138, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 19);
            this.label4.TabIndex = 124;
            this.label4.Text = "Serial Number(s)";
            // 
            // dg_serialnumbers
            // 
            this.dg_serialnumbers.AllowUserToAddRows = false;
            this.dg_serialnumbers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dg_serialnumbers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_serialnumbers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_serialnumbers.BackgroundColor = System.Drawing.Color.White;
            this.dg_serialnumbers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_serialnumbers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dg_serialnumbers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_serialnumbers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_serialnumbers.Location = new System.Drawing.Point(154, 115);
            this.dg_serialnumbers.Name = "dg_serialnumbers";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_serialnumbers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_serialnumbers.RowHeadersVisible = false;
            this.dg_serialnumbers.RowTemplate.Height = 30;
            this.dg_serialnumbers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_serialnumbers.Size = new System.Drawing.Size(331, 196);
            this.dg_serialnumbers.TabIndex = 123;
            this.dg_serialnumbers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_serialnumbers_CellClick);
            this.dg_serialnumbers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_serialnumbers_CellContentClick);
            // 
            // bt_add_serial
            // 
            this.bt_add_serial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(94)))));
            this.bt_add_serial.BackgroundImage = global::FAS.Properties.Resources.add;
            this.bt_add_serial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_add_serial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(94)))));
            this.bt_add_serial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_add_serial.Location = new System.Drawing.Point(452, 54);
            this.bt_add_serial.Name = "bt_add_serial";
            this.bt_add_serial.Size = new System.Drawing.Size(33, 30);
            this.bt_add_serial.TabIndex = 2;
            this.bt_add_serial.UseVisualStyleBackColor = false;
            this.bt_add_serial.Click += new System.EventHandler(this.bt_add_serial_Click);
            // 
            // txt_serial
            // 
            // 
            // 
            // 
            this.txt_serial.CustomButton.Image = null;
            this.txt_serial.CustomButton.Location = new System.Drawing.Point(262, 2);
            this.txt_serial.CustomButton.Name = "";
            this.txt_serial.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_serial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_serial.CustomButton.TabIndex = 1;
            this.txt_serial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_serial.CustomButton.UseSelectable = true;
            this.txt_serial.CustomButton.Visible = false;
            this.txt_serial.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_serial.Lines = new string[0];
            this.txt_serial.Location = new System.Drawing.Point(154, 54);
            this.txt_serial.MaxLength = 32767;
            this.txt_serial.Name = "txt_serial";
            this.txt_serial.PasswordChar = '\0';
            this.txt_serial.PromptText = "Type each serial number here";
            this.txt_serial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_serial.SelectedText = "";
            this.txt_serial.SelectionLength = 0;
            this.txt_serial.SelectionStart = 0;
            this.txt_serial.ShortcutsEnabled = true;
            this.txt_serial.Size = new System.Drawing.Size(290, 30);
            this.txt_serial.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_serial.TabIndex = 1;
            this.txt_serial.UseSelectable = true;
            this.txt_serial.WaterMark = "Type each serial number here";
            this.txt_serial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_serial.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // uc_item_serial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "uc_item_serial";
            this.Size = new System.Drawing.Size(697, 538);
            this.Load += new System.EventHandler(this.uc_item_serial_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_serialnumbers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dg_serialnumbers;
        private System.Windows.Forms.Button bt_add_serial;
        private MetroFramework.Controls.MetroTextBox txt_serial;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_serial;
    }
}
