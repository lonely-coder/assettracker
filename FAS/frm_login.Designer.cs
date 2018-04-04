namespace FAS
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_password = new MetroFramework.Controls.MetroTextBox();
            this.txt_username = new MetroFramework.Controls.MetroTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.White;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(127)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(127)))));
            this.btn_login.Location = new System.Drawing.Point(146, 214);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(129, 47);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Log In";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_password
            // 
            // 
            // 
            // 
            this.txt_password.CustomButton.Image = null;
            this.txt_password.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.txt_password.CustomButton.Name = "";
            this.txt_password.CustomButton.Size = new System.Drawing.Size(43, 43);
            this.txt_password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_password.CustomButton.TabIndex = 1;
            this.txt_password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_password.CustomButton.UseSelectable = true;
            this.txt_password.CustomButton.Visible = false;
            this.txt_password.DisplayIcon = true;
            this.txt_password.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_password.Lines = new string[0];
            this.txt_password.Location = new System.Drawing.Point(112, 149);
            this.txt_password.MaxLength = 32767;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '●';
            this.txt_password.PromptText = "Password";
            this.txt_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_password.SelectedText = "";
            this.txt_password.SelectionLength = 0;
            this.txt_password.SelectionStart = 0;
            this.txt_password.ShortcutsEnabled = true;
            this.txt_password.Size = new System.Drawing.Size(294, 45);
            this.txt_password.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_password.TabIndex = 2;
            this.txt_password.UseSelectable = true;
            this.txt_password.UseStyleColors = true;
            this.txt_password.WaterMark = "Password";
            this.txt_password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_password.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txt_username
            // 
            // 
            // 
            // 
            this.txt_username.CustomButton.Image = null;
            this.txt_username.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.txt_username.CustomButton.Name = "";
            this.txt_username.CustomButton.Size = new System.Drawing.Size(43, 43);
            this.txt_username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_username.CustomButton.TabIndex = 1;
            this.txt_username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_username.CustomButton.UseSelectable = true;
            this.txt_username.CustomButton.Visible = false;
            this.txt_username.DisplayIcon = true;
            this.txt_username.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_username.Lines = new string[0];
            this.txt_username.Location = new System.Drawing.Point(112, 81);
            this.txt_username.MaxLength = 32767;
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.PromptText = "User Name";
            this.txt_username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_username.SelectedText = "";
            this.txt_username.SelectionLength = 0;
            this.txt_username.SelectionStart = 0;
            this.txt_username.ShortcutsEnabled = true;
            this.txt_username.Size = new System.Drawing.Size(294, 45);
            this.txt_username.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_username.TabIndex = 1;
            this.txt_username.UseSelectable = true;
            this.txt_username.UseStyleColors = true;
            this.txt_username.WaterMark = "User Name";
            this.txt_username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_username.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(127)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(127)))));
            this.button1.Location = new System.Drawing.Point(281, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(127)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(53, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(59, 46);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(127)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(53, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(59, 46);
            this.panel2.TabIndex = 14;
            // 
            // frm_login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 301);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.btn_login);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_login";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Fixed Assets";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TransparencyKey = System.Drawing.Color.SlateGray;
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_login;
        private MetroFramework.Controls.MetroTextBox txt_password;
        private MetroFramework.Controls.MetroTextBox txt_username;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

