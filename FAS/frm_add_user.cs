using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FAS
{
    public partial class frm_add_user : MetroFramework.Forms.MetroForm
    {
        public int _id;
        Users priv;
        public frm_add_user()
        {
            InitializeComponent();
        }
        public void Privilege() {
            try
            {
                priv = new Users();
                //priv.Query = "SELECT * from privileges WHERE id != 1";
                //DataTable dt = priv.Select();

                //metroComboBox1.DisplayMember = dt.Columns[1].ToString();
                //metroComboBox1.ValueMember = dt.Columns[0].ToString();
                //metroComboBox1.DataSource = dt;

                //DataRow row = dt.NewRow();

                //row[0] = 0;
                //row[1] = "Select Privilege";

                //dt.Rows.InsertAt(row, 0);

                metroComboBox1.SelectedIndex = 0;

            }
            catch (Exception ex) {

            }
            
        }

        private void frm_add_user_Load(object sender, EventArgs e)
        {
            this.Privilege();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try {
                Users user = new Users();
                user.EmployeeId= this._id;
                user.UserName = metroTextBox2.Text;
                user.Password =metroTextBox3.Text;
                user.Privilege = int.Parse(metroComboBox1.SelectedValue.ToString());
                user.InsertUser();
                MessageBox.Show("New User Has Been Saved");
                metroTextBox2.Clear();
                metroTextBox3.Clear();
                metroTextBox4.Clear();
                metroComboBox1.SelectedIndex = 0;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

    }
}
