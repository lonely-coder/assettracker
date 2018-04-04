namespace FAS
{
    partial class frm_add_item
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_category = new MetroFramework.Controls.MetroComboBox();
            this.cb_sub_category = new MetroFramework.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_brand = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape6 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape5 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.dt_warranty = new MetroFramework.Controls.MetroDateTime();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Item Description :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(127)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(127)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(443, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 32;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(524, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 47);
            this.button2.TabIndex = 33;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(355, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "Warranty:";
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.ItemHeight = 23;
            this.cb_category.Location = new System.Drawing.Point(54, 64);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(242, 29);
            this.cb_category.TabIndex = 40;
            this.cb_category.UseSelectable = true;
            this.cb_category.SelectedIndexChanged += new System.EventHandler(this.cb_category_SelectedIndexChanged);
            // 
            // cb_sub_category
            // 
            this.cb_sub_category.FormattingEnabled = true;
            this.cb_sub_category.ItemHeight = 23;
            this.cb_sub_category.Location = new System.Drawing.Point(54, 116);
            this.cb_sub_category.Name = "cb_sub_category";
            this.cb_sub_category.Size = new System.Drawing.Size(242, 29);
            this.cb_sub_category.TabIndex = 41;
            this.cb_sub_category.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "Sub Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 54;
            this.label7.Text = "Brand";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(54, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 55;
            this.label8.Text = "Model";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(356, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 17);
            this.label10.TabIndex = 56;
            this.label10.Text = "Description ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(355, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 17);
            this.label11.TabIndex = 57;
            this.label11.Text = "Price";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(356, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 58;
            this.label13.Text = "Quantity";
            // 
            // txt_description
            // 
            this.txt_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_description.Location = new System.Drawing.Point(365, 69);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(229, 18);
            this.txt_description.TabIndex = 60;
            // 
            // txt_price
            // 
            this.txt_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_price.Location = new System.Drawing.Point(365, 120);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(229, 18);
            this.txt_price.TabIndex = 61;
            // 
            // txt_quantity
            // 
            this.txt_quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_quantity.Location = new System.Drawing.Point(365, 170);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(229, 18);
            this.txt_quantity.TabIndex = 62;
            // 
            // txt_model
            // 
            this.txt_model.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_model.Location = new System.Drawing.Point(59, 223);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(230, 18);
            this.txt_model.TabIndex = 63;
            // 
            // txt_brand
            // 
            this.txt_brand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_brand.Location = new System.Drawing.Point(59, 173);
            this.txt_brand.Name = "txt_brand";
            this.txt_brand.Size = new System.Drawing.Size(230, 18);
            this.txt_brand.TabIndex = 64;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape6,
            this.rectangleShape5,
            this.rectangleShape4,
            this.rectangleShape3,
            this.rectangleShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(666, 352);
            this.shapeContainer1.TabIndex = 65;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape6
            // 
            this.rectangleShape6.BackColor = System.Drawing.SystemColors.Window;
            this.rectangleShape6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape6.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.rectangleShape6.Location = new System.Drawing.Point(359, 165);
            this.rectangleShape6.Name = "rectangleShape6";
            this.rectangleShape6.Size = new System.Drawing.Size(240, 28);
            // 
            // rectangleShape5
            // 
            this.rectangleShape5.BackColor = System.Drawing.SystemColors.Window;
            this.rectangleShape5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape5.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.rectangleShape5.Location = new System.Drawing.Point(358, 115);
            this.rectangleShape5.Name = "rectangleShape5";
            this.rectangleShape5.Size = new System.Drawing.Size(240, 28);
            // 
            // rectangleShape4
            // 
            this.rectangleShape4.BackColor = System.Drawing.SystemColors.Window;
            this.rectangleShape4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape4.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.rectangleShape4.Location = new System.Drawing.Point(358, 65);
            this.rectangleShape4.Name = "rectangleShape4";
            this.rectangleShape4.Size = new System.Drawing.Size(240, 28);
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BackColor = System.Drawing.SystemColors.Window;
            this.rectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape3.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.rectangleShape3.Location = new System.Drawing.Point(54, 218);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(240, 28);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackColor = System.Drawing.SystemColors.Window;
            this.rectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape2.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.rectangleShape2.Location = new System.Drawing.Point(54, 168);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(240, 28);
            // 
            // dt_warranty
            // 
            this.dt_warranty.Location = new System.Drawing.Point(359, 217);
            this.dt_warranty.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_warranty.Name = "dt_warranty";
            this.dt_warranty.Size = new System.Drawing.Size(241, 29);
            this.dt_warranty.TabIndex = 49;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(127)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(127)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(362, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 47);
            this.button3.TabIndex = 66;
            this.button3.Text = "Browse";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frm_add_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 352);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_brand);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dt_warranty);
            this.Controls.Add(this.cb_sub_category);
            this.Controls.Add(this.cb_category);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_add_item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Item";
            this.Load += new System.EventHandler(this.frm_add_item_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroComboBox cb_category;
        private MetroFramework.Controls.MetroComboBox cb_sub_category;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.TextBox txt_brand;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape6;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape5;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape4;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private MetroFramework.Controls.MetroDateTime dt_warranty;
        private System.Windows.Forms.Button button3;
    }
}