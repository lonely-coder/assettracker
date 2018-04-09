namespace FAS
{
    partial class employee_list_controller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employee_list_controller));
            this.dg_employees = new System.Windows.Forms.DataGridView();
            this.txt_filter = new MetroFramework.Controls.MetroTextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_employees)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_employees
            // 
            this.dg_employees.AllowUserToAddRows = false;
            this.dg_employees.AllowUserToDeleteRows = false;
            this.dg_employees.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dg_employees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_employees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_employees.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dg_employees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_employees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dg_employees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_employees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_employees.DefaultCellStyle = dataGridViewCellStyle3;
            this.dg_employees.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_employees.Location = new System.Drawing.Point(10, 55);
            this.dg_employees.MultiSelect = false;
            this.dg_employees.Name = "dg_employees";
            this.dg_employees.RowHeadersVisible = false;
            this.dg_employees.RowTemplate.Height = 28;
            this.dg_employees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_employees.Size = new System.Drawing.Size(675, 439);
            this.dg_employees.TabIndex = 8;
            this.dg_employees.TabStop = false;
            this.dg_employees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_employees_CellClick);
            // 
            // txt_filter
            // 
            // 
            // 
            // 
            this.txt_filter.CustomButton.Image = null;
            this.txt_filter.CustomButton.Location = new System.Drawing.Point(282, 2);
            this.txt_filter.CustomButton.Name = "";
            this.txt_filter.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txt_filter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_filter.CustomButton.TabIndex = 1;
            this.txt_filter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_filter.CustomButton.UseSelectable = true;
            this.txt_filter.CustomButton.Visible = false;
            this.txt_filter.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_filter.Lines = new string[0];
            this.txt_filter.Location = new System.Drawing.Point(319, 9);
            this.txt_filter.MaxLength = 32767;
            this.txt_filter.Name = "txt_filter";
            this.txt_filter.PasswordChar = '\0';
            this.txt_filter.PromptText = "Employee I.D or Name . . . .";
            this.txt_filter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_filter.SelectedText = "";
            this.txt_filter.SelectionLength = 0;
            this.txt_filter.SelectionStart = 0;
            this.txt_filter.ShortcutsEnabled = true;
            this.txt_filter.Size = new System.Drawing.Size(320, 40);
            this.txt_filter.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_filter.TabIndex = 9;
            this.txt_filter.UseSelectable = true;
            this.txt_filter.UseStyleColors = true;
            this.txt_filter.WaterMark = "Employee I.D or Name . . . .";
            this.txt_filter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_filter.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(94)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(645, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 10;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // employee_list_controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_filter);
            this.Controls.Add(this.dg_employees);
            this.Name = "employee_list_controller";
            this.Size = new System.Drawing.Size(697, 538);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_employees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.DataGridView dg_employees;
        internal MetroFramework.Controls.MetroTextBox txt_filter;
        private System.Windows.Forms.Button button2;
    }
}
