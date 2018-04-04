namespace FAS
{
    partial class frm_vendors
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dg_vendorList = new System.Windows.Forms.DataGridView();
            this.btn_new_vendor = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_vendorList)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_vendorList
            // 
            this.dg_vendorList.AllowUserToAddRows = false;
            this.dg_vendorList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dg_vendorList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_vendorList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_vendorList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_vendorList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dg_vendorList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_vendorList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_vendorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_vendorList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dg_vendorList.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dg_vendorList.Location = new System.Drawing.Point(32, 30);
            this.dg_vendorList.MultiSelect = false;
            this.dg_vendorList.Name = "dg_vendorList";
            this.dg_vendorList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_vendorList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_vendorList.RowTemplate.Height = 28;
            this.dg_vendorList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_vendorList.Size = new System.Drawing.Size(550, 270);
            this.dg_vendorList.TabIndex = 0;
            this.dg_vendorList.TabStop = false;
            this.dg_vendorList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_vendorList_CellClick);
            // 
            // btn_new_vendor
            // 
            this.btn_new_vendor.BackColor = System.Drawing.Color.Teal;
            this.btn_new_vendor.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btn_new_vendor.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_new_vendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new_vendor.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_vendor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_new_vendor.Location = new System.Drawing.Point(413, 306);
            this.btn_new_vendor.Name = "btn_new_vendor";
            this.btn_new_vendor.Size = new System.Drawing.Size(80, 44);
            this.btn_new_vendor.TabIndex = 2;
            this.btn_new_vendor.Text = "New";
            this.btn_new_vendor.UseVisualStyleBackColor = false;
            this.btn_new_vendor.Click += new System.EventHandler(this.btn_new_vendor_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_close.Location = new System.Drawing.Point(502, 306);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(80, 44);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // frm_vendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(611, 362);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_new_vendor);
            this.Controls.Add(this.dg_vendorList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_vendors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendors";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_vendorList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_vendorList;
        private System.Windows.Forms.Button btn_new_vendor;
        private System.Windows.Forms.Button btn_close;
    }
}