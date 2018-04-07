namespace FAS
{
    partial class uc_add_employee_asset
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
            System.Windows.Forms.Button button1;
            this.label18 = new System.Windows.Forms.Label();
            this.lbl_serial_not_available = new System.Windows.Forms.Label();
            this.lbl_serial_required = new System.Windows.Forms.Label();
            this.lbl_item_not_found = new System.Windows.Forms.Label();
            this.lbl_propert_tag_warning = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dt_picker_date_acquired = new System.Windows.Forms.DateTimePicker();
            this.numberic_up_down_quantity = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_model = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_property_tag = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_position = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_dept = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_name = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_employee_id = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_price_list = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_emp_id_not_found = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberic_up_down_quantity)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(94)))));
            button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(94)))));
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            button1.Location = new System.Drawing.Point(220, 15);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(97, 47);
            button1.TabIndex = 23;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(221, 550);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(118, 17);
            this.label18.TabIndex = 30;
            this.label18.Text = "- Invalid Quantity";
            this.label18.Visible = false;
            // 
            // lbl_serial_not_available
            // 
            this.lbl_serial_not_available.AutoSize = true;
            this.lbl_serial_not_available.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_serial_not_available.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_serial_not_available.ForeColor = System.Drawing.Color.Red;
            this.lbl_serial_not_available.Location = new System.Drawing.Point(426, 439);
            this.lbl_serial_not_available.Name = "lbl_serial_not_available";
            this.lbl_serial_not_available.Size = new System.Drawing.Size(159, 17);
            this.lbl_serial_not_available.TabIndex = 29;
            this.lbl_serial_not_available.Text = "-This item requires serial.";
            this.lbl_serial_not_available.Visible = false;
            // 
            // lbl_serial_required
            // 
            this.lbl_serial_required.AutoSize = true;
            this.lbl_serial_required.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_serial_required.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_serial_required.ForeColor = System.Drawing.Color.Red;
            this.lbl_serial_required.Location = new System.Drawing.Point(238, 412);
            this.lbl_serial_required.Name = "lbl_serial_required";
            this.lbl_serial_required.Size = new System.Drawing.Size(0, 17);
            this.lbl_serial_required.TabIndex = 28;
            // 
            // lbl_item_not_found
            // 
            this.lbl_item_not_found.AutoSize = true;
            this.lbl_item_not_found.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_item_not_found.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item_not_found.ForeColor = System.Drawing.Color.Red;
            this.lbl_item_not_found.Location = new System.Drawing.Point(426, 381);
            this.lbl_item_not_found.Name = "lbl_item_not_found";
            this.lbl_item_not_found.Size = new System.Drawing.Size(109, 17);
            this.lbl_item_not_found.TabIndex = 27;
            this.lbl_item_not_found.Text = "Item not found.";
            this.lbl_item_not_found.Visible = false;
            // 
            // lbl_propert_tag_warning
            // 
            this.lbl_propert_tag_warning.AutoSize = true;
            this.lbl_propert_tag_warning.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_propert_tag_warning.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_propert_tag_warning.ForeColor = System.Drawing.Color.Red;
            this.lbl_propert_tag_warning.Location = new System.Drawing.Point(310, 322);
            this.lbl_propert_tag_warning.Name = "lbl_propert_tag_warning";
            this.lbl_propert_tag_warning.Size = new System.Drawing.Size(174, 17);
            this.lbl_propert_tag_warning.TabIndex = 26;
            this.lbl_propert_tag_warning.Text = "Property tag already used";
            this.lbl_propert_tag_warning.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(228, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "- Employee ID is required";
            this.label11.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.button2.Location = new System.Drawing.Point(323, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 47);
            this.button2.TabIndex = 24;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(135, 470);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "Date Acquired";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(142, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 17);
            this.label12.TabIndex = 21;
            // 
            // dt_picker_date_acquired
            // 
            this.dt_picker_date_acquired.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_picker_date_acquired.Location = new System.Drawing.Point(138, 490);
            this.dt_picker_date_acquired.Name = "dt_picker_date_acquired";
            this.dt_picker_date_acquired.Size = new System.Drawing.Size(282, 26);
            this.dt_picker_date_acquired.TabIndex = 20;
            // 
            // numberic_up_down_quantity
            // 
            this.numberic_up_down_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberic_up_down_quantity.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberic_up_down_quantity.Location = new System.Drawing.Point(138, 545);
            this.numberic_up_down_quantity.Name = "numberic_up_down_quantity";
            this.numberic_up_down_quantity.Size = new System.Drawing.Size(75, 26);
            this.numberic_up_down_quantity.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(134, 525);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(135, 412);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Serial Number";
            // 
            // txt_model
            // 
            // 
            // 
            // 
            this.txt_model.CustomButton.Image = null;
            this.txt_model.CustomButton.Location = new System.Drawing.Point(254, 2);
            this.txt_model.CustomButton.Name = "";
            this.txt_model.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_model.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_model.CustomButton.TabIndex = 1;
            this.txt_model.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_model.CustomButton.UseSelectable = true;
            this.txt_model.CustomButton.Visible = false;
            this.txt_model.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_model.Lines = new string[0];
            this.txt_model.Location = new System.Drawing.Point(138, 374);
            this.txt_model.MaxLength = 32767;
            this.txt_model.Name = "txt_model";
            this.txt_model.PasswordChar = '\0';
            this.txt_model.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_model.SelectedText = "";
            this.txt_model.SelectionLength = 0;
            this.txt_model.SelectionStart = 0;
            this.txt_model.ShortcutsEnabled = true;
            this.txt_model.Size = new System.Drawing.Size(282, 30);
            this.txt_model.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_model.TabIndex = 13;
            this.txt_model.UseSelectable = true;
            this.txt_model.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_model.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_model.TextChanged += new System.EventHandler(this.txt_model_TextChanged);
            this.txt_model.Leave += new System.EventHandler(this.txt_model_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(135, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Model";
            // 
            // txt_property_tag
            // 
            // 
            // 
            // 
            this.txt_property_tag.CustomButton.Image = null;
            this.txt_property_tag.CustomButton.Location = new System.Drawing.Point(130, 2);
            this.txt_property_tag.CustomButton.Name = "";
            this.txt_property_tag.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_property_tag.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_property_tag.CustomButton.TabIndex = 1;
            this.txt_property_tag.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_property_tag.CustomButton.UseSelectable = true;
            this.txt_property_tag.CustomButton.Visible = false;
            this.txt_property_tag.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_property_tag.Lines = new string[0];
            this.txt_property_tag.Location = new System.Drawing.Point(137, 316);
            this.txt_property_tag.MaxLength = 32767;
            this.txt_property_tag.Name = "txt_property_tag";
            this.txt_property_tag.PasswordChar = '\0';
            this.txt_property_tag.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_property_tag.SelectedText = "";
            this.txt_property_tag.SelectionLength = 0;
            this.txt_property_tag.SelectionStart = 0;
            this.txt_property_tag.ShortcutsEnabled = true;
            this.txt_property_tag.Size = new System.Drawing.Size(158, 30);
            this.txt_property_tag.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_property_tag.TabIndex = 11;
            this.txt_property_tag.UseSelectable = true;
            this.txt_property_tag.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_property_tag.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_property_tag.TextChanged += new System.EventHandler(this.txt_property_tag_TextChanged);
            this.txt_property_tag.Click += new System.EventHandler(this.txt_property_tag_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(135, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Property Tag";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(98, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Item";
            // 
            // txt_position
            // 
            // 
            // 
            // 
            this.txt_position.CustomButton.Image = null;
            this.txt_position.CustomButton.Location = new System.Drawing.Point(255, 2);
            this.txt_position.CustomButton.Name = "";
            this.txt_position.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_position.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_position.CustomButton.TabIndex = 1;
            this.txt_position.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_position.CustomButton.UseSelectable = true;
            this.txt_position.CustomButton.Visible = false;
            this.txt_position.Enabled = false;
            this.txt_position.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_position.Lines = new string[0];
            this.txt_position.Location = new System.Drawing.Point(137, 230);
            this.txt_position.MaxLength = 32767;
            this.txt_position.Name = "txt_position";
            this.txt_position.PasswordChar = '\0';
            this.txt_position.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_position.SelectedText = "";
            this.txt_position.SelectionLength = 0;
            this.txt_position.SelectionStart = 0;
            this.txt_position.ShortcutsEnabled = true;
            this.txt_position.Size = new System.Drawing.Size(283, 30);
            this.txt_position.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_position.TabIndex = 8;
            this.txt_position.UseSelectable = true;
            this.txt_position.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_position.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(134, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Position";
            // 
            // txt_dept
            // 
            // 
            // 
            // 
            this.txt_dept.CustomButton.Image = null;
            this.txt_dept.CustomButton.Location = new System.Drawing.Point(255, 2);
            this.txt_dept.CustomButton.Name = "";
            this.txt_dept.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_dept.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_dept.CustomButton.TabIndex = 1;
            this.txt_dept.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_dept.CustomButton.UseSelectable = true;
            this.txt_dept.CustomButton.Visible = false;
            this.txt_dept.Enabled = false;
            this.txt_dept.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_dept.Lines = new string[0];
            this.txt_dept.Location = new System.Drawing.Point(137, 172);
            this.txt_dept.MaxLength = 32767;
            this.txt_dept.Name = "txt_dept";
            this.txt_dept.PasswordChar = '\0';
            this.txt_dept.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_dept.SelectedText = "";
            this.txt_dept.SelectionLength = 0;
            this.txt_dept.SelectionStart = 0;
            this.txt_dept.ShortcutsEnabled = true;
            this.txt_dept.Size = new System.Drawing.Size(283, 30);
            this.txt_dept.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_dept.TabIndex = 6;
            this.txt_dept.UseSelectable = true;
            this.txt_dept.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_dept.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(134, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Department";
            // 
            // txt_name
            // 
            // 
            // 
            // 
            this.txt_name.CustomButton.Image = null;
            this.txt_name.CustomButton.Location = new System.Drawing.Point(255, 2);
            this.txt_name.CustomButton.Name = "";
            this.txt_name.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_name.CustomButton.TabIndex = 1;
            this.txt_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_name.CustomButton.UseSelectable = true;
            this.txt_name.CustomButton.Visible = false;
            this.txt_name.Enabled = false;
            this.txt_name.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_name.Lines = new string[0];
            this.txt_name.Location = new System.Drawing.Point(137, 114);
            this.txt_name.MaxLength = 32767;
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_name.SelectedText = "";
            this.txt_name.SelectionLength = 0;
            this.txt_name.SelectionStart = 0;
            this.txt_name.ShortcutsEnabled = true;
            this.txt_name.Size = new System.Drawing.Size(283, 30);
            this.txt_name.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_name.TabIndex = 4;
            this.txt_name.UseSelectable = true;
            this.txt_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(134, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // txt_employee_id
            // 
            this.txt_employee_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_employee_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txt_employee_id.CustomButton.Image = null;
            this.txt_employee_id.CustomButton.Location = new System.Drawing.Point(130, 2);
            this.txt_employee_id.CustomButton.Name = "";
            this.txt_employee_id.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_employee_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_employee_id.CustomButton.TabIndex = 1;
            this.txt_employee_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_employee_id.CustomButton.UseSelectable = true;
            this.txt_employee_id.CustomButton.Visible = false;
            this.txt_employee_id.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_employee_id.Lines = new string[0];
            this.txt_employee_id.Location = new System.Drawing.Point(137, 56);
            this.txt_employee_id.MaxLength = 32767;
            this.txt_employee_id.Name = "txt_employee_id";
            this.txt_employee_id.PasswordChar = '\0';
            this.txt_employee_id.PromptText = "Type Employee ID";
            this.txt_employee_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_employee_id.SelectedText = "";
            this.txt_employee_id.SelectionLength = 0;
            this.txt_employee_id.SelectionStart = 0;
            this.txt_employee_id.ShortcutsEnabled = true;
            this.txt_employee_id.Size = new System.Drawing.Size(158, 30);
            this.txt_employee_id.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_employee_id.TabIndex = 2;
            this.txt_employee_id.UseSelectable = true;
            this.txt_employee_id.WaterMark = "Type Employee ID";
            this.txt_employee_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_employee_id.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_employee_id.TextChanged += new System.EventHandler(this.txt_employee_id_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(134, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.cb_price_list);
            this.panel1.Controls.Add(this.metroComboBox1);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.lbl_emp_id_not_found);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.lbl_serial_not_available);
            this.panel1.Controls.Add(this.lbl_serial_required);
            this.panel1.Controls.Add(this.lbl_item_not_found);
            this.panel1.Controls.Add(this.lbl_propert_tag_warning);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.dt_picker_date_acquired);
            this.panel1.Controls.Add(this.numberic_up_down_quantity);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_model);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_property_tag);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_position);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_dept);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_employee_id);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 538);
            this.panel1.TabIndex = 1;
            // 
            // cb_price_list
            // 
            this.cb_price_list.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cb_price_list.FormattingEnabled = true;
            this.cb_price_list.ItemHeight = 29;
            this.cb_price_list.Location = new System.Drawing.Point(137, 599);
            this.cb_price_list.Name = "cb_price_list";
            this.cb_price_list.Size = new System.Drawing.Size(158, 35);
            this.cb_price_list.TabIndex = 38;
            this.cb_price_list.UseSelectable = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 29;
            this.metroComboBox1.Location = new System.Drawing.Point(138, 432);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(279, 35);
            this.metroComboBox1.TabIndex = 37;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(189, 354);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(146, 17);
            this.label17.TabIndex = 36;
            this.label17.Text = "-Item Model is empty.";
            this.label17.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(301, 605);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 17);
            this.label16.TabIndex = 35;
            this.label16.Text = "-Price is required.";
            this.label16.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(135, 579);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 17);
            this.label15.TabIndex = 33;
            this.label15.Text = "Price";
            // 
            // lbl_emp_id_not_found
            // 
            this.lbl_emp_id_not_found.AutoSize = true;
            this.lbl_emp_id_not_found.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_emp_id_not_found.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emp_id_not_found.ForeColor = System.Drawing.Color.Red;
            this.lbl_emp_id_not_found.Location = new System.Drawing.Point(301, 63);
            this.lbl_emp_id_not_found.Name = "lbl_emp_id_not_found";
            this.lbl_emp_id_not_found.Size = new System.Drawing.Size(156, 17);
            this.lbl_emp_id_not_found.TabIndex = 32;
            this.lbl_emp_id_not_found.Text = "Employee ID not found";
            this.lbl_emp_id_not_found.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label19.Location = new System.Drawing.Point(457, 638);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 17);
            this.label19.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 655);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(680, 165);
            this.panel2.TabIndex = 31;
            // 
            // uc_add_employee_asset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "uc_add_employee_asset";
            this.Size = new System.Drawing.Size(697, 538);
            this.Load += new System.EventHandler(this.uc_add_employee_asset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberic_up_down_quantity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbl_serial_not_available;
        private System.Windows.Forms.Label lbl_serial_required;
        private System.Windows.Forms.Label lbl_item_not_found;
        private System.Windows.Forms.Label lbl_propert_tag_warning;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dt_picker_date_acquired;
        private System.Windows.Forms.NumericUpDown numberic_up_down_quantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroTextBox txt_model;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroTextBox txt_property_tag;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox txt_position;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txt_dept;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txt_name;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txt_employee_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_emp_id_not_found;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroComboBox cb_price_list;
    }
}
