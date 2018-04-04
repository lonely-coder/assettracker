namespace FAS
{
    partial class uc_add_assets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_add_assets));
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dt_date_acquired = new System.Windows.Forms.DateTimePicker();
            this.txt_emp_id = new MetroFramework.Controls.MetroTextBox();
            this.txt_name = new MetroFramework.Controls.MetroTextBox();
            this.txt_department = new MetroFramework.Controls.MetroTextBox();
            this.txt_position = new MetroFramework.Controls.MetroTextBox();
            this.txt_property_tag = new MetroFramework.Controls.MetroTextBox();
            this.txt_model = new MetroFramework.Controls.MetroTextBox();
            this.txt_serial = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(362, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Date Acquired";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(127)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(127)))));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(482, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 48);
            this.button3.TabIndex = 9;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(127)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(127)))));
            this.button4.Location = new System.Drawing.Point(581, 374);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 48);
            this.button4.TabIndex = 10;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dt_date_acquired
            // 
            this.dt_date_acquired.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_date_acquired.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_date_acquired.Location = new System.Drawing.Point(365, 255);
            this.dt_date_acquired.Name = "dt_date_acquired";
            this.dt_date_acquired.Size = new System.Drawing.Size(308, 29);
            this.dt_date_acquired.TabIndex = 7;
            // 
            // txt_emp_id
            // 
            this.txt_emp_id.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.txt_emp_id.CustomButton.Image = null;
            this.txt_emp_id.CustomButton.Location = new System.Drawing.Point(224, 2);
            this.txt_emp_id.CustomButton.Name = "";
            this.txt_emp_id.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txt_emp_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_emp_id.CustomButton.TabIndex = 1;
            this.txt_emp_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_emp_id.CustomButton.UseSelectable = true;
            this.txt_emp_id.CustomButton.Visible = false;
            this.txt_emp_id.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_emp_id.Lines = new string[0];
            this.txt_emp_id.Location = new System.Drawing.Point(21, 42);
            this.txt_emp_id.MaxLength = 32767;
            this.txt_emp_id.Name = "txt_emp_id";
            this.txt_emp_id.PasswordChar = '\0';
            this.txt_emp_id.PromptText = "Employee Id";
            this.txt_emp_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_emp_id.SelectedText = "";
            this.txt_emp_id.SelectionLength = 0;
            this.txt_emp_id.SelectionStart = 0;
            this.txt_emp_id.ShortcutsEnabled = true;
            this.txt_emp_id.Size = new System.Drawing.Size(262, 40);
            this.txt_emp_id.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_emp_id.TabIndex = 2;
            this.txt_emp_id.UseSelectable = true;
            this.txt_emp_id.UseStyleColors = true;
            this.txt_emp_id.WaterMark = "Employee Id";
            this.txt_emp_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_emp_id.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emp_id.Click += new System.EventHandler(this.txt_emp_id_Click);
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.txt_name.CustomButton.Image = null;
            this.txt_name.CustomButton.Location = new System.Drawing.Point(270, 2);
            this.txt_name.CustomButton.Name = "";
            this.txt_name.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txt_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_name.CustomButton.TabIndex = 1;
            this.txt_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_name.CustomButton.UseSelectable = true;
            this.txt_name.CustomButton.Visible = false;
            this.txt_name.Enabled = false;
            this.txt_name.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_name.Lines = new string[0];
            this.txt_name.Location = new System.Drawing.Point(21, 104);
            this.txt_name.MaxLength = 32767;
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.PromptText = "Name";
            this.txt_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_name.SelectedText = "";
            this.txt_name.SelectionLength = 0;
            this.txt_name.SelectionStart = 0;
            this.txt_name.ShortcutsEnabled = true;
            this.txt_name.Size = new System.Drawing.Size(308, 40);
            this.txt_name.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_name.TabIndex = 33;
            this.txt_name.UseSelectable = true;
            this.txt_name.UseStyleColors = true;
            this.txt_name.WaterMark = "Name";
            this.txt_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_name.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txt_department
            // 
            this.txt_department.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.txt_department.CustomButton.Image = null;
            this.txt_department.CustomButton.Location = new System.Drawing.Point(270, 2);
            this.txt_department.CustomButton.Name = "";
            this.txt_department.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txt_department.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_department.CustomButton.TabIndex = 1;
            this.txt_department.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_department.CustomButton.UseSelectable = true;
            this.txt_department.CustomButton.Visible = false;
            this.txt_department.Enabled = false;
            this.txt_department.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_department.Lines = new string[0];
            this.txt_department.Location = new System.Drawing.Point(365, 42);
            this.txt_department.MaxLength = 32767;
            this.txt_department.Name = "txt_department";
            this.txt_department.PasswordChar = '\0';
            this.txt_department.PromptText = "Department";
            this.txt_department.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_department.SelectedText = "";
            this.txt_department.SelectionLength = 0;
            this.txt_department.SelectionStart = 0;
            this.txt_department.ShortcutsEnabled = true;
            this.txt_department.Size = new System.Drawing.Size(308, 40);
            this.txt_department.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_department.TabIndex = 34;
            this.txt_department.UseSelectable = true;
            this.txt_department.UseStyleColors = true;
            this.txt_department.WaterMark = "Department";
            this.txt_department.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_department.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txt_position
            // 
            this.txt_position.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.txt_position.CustomButton.Image = null;
            this.txt_position.CustomButton.Location = new System.Drawing.Point(270, 2);
            this.txt_position.CustomButton.Name = "";
            this.txt_position.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txt_position.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_position.CustomButton.TabIndex = 1;
            this.txt_position.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_position.CustomButton.UseSelectable = true;
            this.txt_position.CustomButton.Visible = false;
            this.txt_position.Enabled = false;
            this.txt_position.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_position.Lines = new string[0];
            this.txt_position.Location = new System.Drawing.Point(365, 104);
            this.txt_position.MaxLength = 32767;
            this.txt_position.Name = "txt_position";
            this.txt_position.PasswordChar = '\0';
            this.txt_position.PromptText = "Position";
            this.txt_position.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_position.SelectedText = "";
            this.txt_position.SelectionLength = 0;
            this.txt_position.SelectionStart = 0;
            this.txt_position.ShortcutsEnabled = true;
            this.txt_position.Size = new System.Drawing.Size(308, 40);
            this.txt_position.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_position.TabIndex = 35;
            this.txt_position.UseSelectable = true;
            this.txt_position.UseStyleColors = true;
            this.txt_position.WaterMark = "Position";
            this.txt_position.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_position.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txt_property_tag
            // 
            // 
            // 
            // 
            this.txt_property_tag.CustomButton.Image = null;
            this.txt_property_tag.CustomButton.Location = new System.Drawing.Point(270, 2);
            this.txt_property_tag.CustomButton.Name = "";
            this.txt_property_tag.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txt_property_tag.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_property_tag.CustomButton.TabIndex = 1;
            this.txt_property_tag.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_property_tag.CustomButton.UseSelectable = true;
            this.txt_property_tag.CustomButton.Visible = false;
            this.txt_property_tag.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_property_tag.Lines = new string[0];
            this.txt_property_tag.Location = new System.Drawing.Point(21, 188);
            this.txt_property_tag.MaxLength = 32767;
            this.txt_property_tag.Name = "txt_property_tag";
            this.txt_property_tag.PasswordChar = '\0';
            this.txt_property_tag.PromptText = "Property Tag";
            this.txt_property_tag.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_property_tag.SelectedText = "";
            this.txt_property_tag.SelectionLength = 0;
            this.txt_property_tag.SelectionStart = 0;
            this.txt_property_tag.ShortcutsEnabled = true;
            this.txt_property_tag.Size = new System.Drawing.Size(308, 40);
            this.txt_property_tag.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_property_tag.TabIndex = 3;
            this.txt_property_tag.UseSelectable = true;
            this.txt_property_tag.UseStyleColors = true;
            this.txt_property_tag.WaterMark = "Property Tag";
            this.txt_property_tag.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_property_tag.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_property_tag.Leave += new System.EventHandler(this.txt_property_tag_Leave_1);
            // 
            // txt_model
            // 
            // 
            // 
            // 
            this.txt_model.CustomButton.Image = null;
            this.txt_model.CustomButton.Location = new System.Drawing.Point(224, 2);
            this.txt_model.CustomButton.Name = "";
            this.txt_model.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txt_model.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_model.CustomButton.TabIndex = 1;
            this.txt_model.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_model.CustomButton.UseSelectable = true;
            this.txt_model.CustomButton.Visible = false;
            this.txt_model.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_model.Lines = new string[0];
            this.txt_model.Location = new System.Drawing.Point(21, 253);
            this.txt_model.MaxLength = 32767;
            this.txt_model.Name = "txt_model";
            this.txt_model.PasswordChar = '\0';
            this.txt_model.PromptText = "Model";
            this.txt_model.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_model.SelectedText = "";
            this.txt_model.SelectionLength = 0;
            this.txt_model.SelectionStart = 0;
            this.txt_model.ShortcutsEnabled = true;
            this.txt_model.Size = new System.Drawing.Size(262, 40);
            this.txt_model.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_model.TabIndex = 38;
            this.txt_model.UseSelectable = true;
            this.txt_model.UseStyleColors = true;
            this.txt_model.WaterMark = "Model";
            this.txt_model.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_model.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_model.Click += new System.EventHandler(this.txt_model_Click);
            // 
            // txt_serial
            // 
            // 
            // 
            // 
            this.txt_serial.CustomButton.Image = null;
            this.txt_serial.CustomButton.Location = new System.Drawing.Point(224, 2);
            this.txt_serial.CustomButton.Name = "";
            this.txt_serial.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txt_serial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_serial.CustomButton.TabIndex = 1;
            this.txt_serial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_serial.CustomButton.UseSelectable = true;
            this.txt_serial.CustomButton.Visible = false;
            this.txt_serial.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_serial.Lines = new string[0];
            this.txt_serial.Location = new System.Drawing.Point(21, 312);
            this.txt_serial.MaxLength = 32767;
            this.txt_serial.Name = "txt_serial";
            this.txt_serial.PasswordChar = '\0';
            this.txt_serial.PromptText = "Serial Number";
            this.txt_serial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_serial.SelectedText = "";
            this.txt_serial.SelectionLength = 0;
            this.txt_serial.SelectionStart = 0;
            this.txt_serial.ShortcutsEnabled = true;
            this.txt_serial.Size = new System.Drawing.Size(262, 40);
            this.txt_serial.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_serial.TabIndex = 39;
            this.txt_serial.UseSelectable = true;
            this.txt_serial.UseStyleColors = true;
            this.txt_serial.WaterMark = "Serial Number";
            this.txt_serial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_serial.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serial.Click += new System.EventHandler(this.txt_serial_Click);
            this.txt_serial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_serial_KeyPress);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 29;
            this.metroComboBox1.Location = new System.Drawing.Point(365, 188);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(308, 35);
            this.metroComboBox1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroComboBox1.TabIndex = 6;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.UseStyleColors = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(127)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(289, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 1;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(270, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(365, 312);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "Price";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(308, 40);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTextBox1.TabIndex = 8;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.UseStyleColors = true;
            this.metroTextBox1.WaterMark = "Price";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox1_KeyPress);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(127)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(289, 312);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 40);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(127)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(289, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Employee Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(3, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Item Information";
            // 
            // uc_add_assets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_emp_id);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_property_tag);
            this.Controls.Add(this.txt_department);
            this.Controls.Add(this.txt_position);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dt_date_acquired);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txt_serial);
            this.Name = "uc_add_assets";
            this.Size = new System.Drawing.Size(697, 538);
            this.Load += new System.EventHandler(this.uc_add_assets_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dt_date_acquired;
        private System.Windows.Forms.Button button5;
        internal MetroFramework.Controls.MetroTextBox txt_emp_id;
        internal MetroFramework.Controls.MetroTextBox txt_name;
        internal MetroFramework.Controls.MetroTextBox txt_department;
        internal MetroFramework.Controls.MetroTextBox txt_position;
        internal MetroFramework.Controls.MetroTextBox txt_property_tag;
        internal MetroFramework.Controls.MetroTextBox txt_model;
        internal MetroFramework.Controls.MetroTextBox txt_serial;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        internal MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
