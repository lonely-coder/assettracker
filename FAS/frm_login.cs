using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;
using System.Net;

namespace FAS
{
    public partial class frm_login :MetroFramework.Forms.MetroForm {

        Thread th;
        //int _privilege_id;
        //string _user_name;
        int _user_id;
        
        int togMove;
        int MValX;
        int MValY;
       
        public frm_login()
        {
            InitializeComponent();
            
        }

        private void openmainform(object obj)
        {
            Application.Run(new frm_fas(_user_id));
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            txt_username.Focus();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            Logs logs = new Logs();
            //logs.IP = user.myIP;
            

            try
            {
                Connection connection = new Connection();
                Users users = new Users(this.txt_username.Text, this.txt_password.Text);
                UserManager userController = new UserManager(connection,users);
                bool authenticate = userController.AuthenticateUser();

                this._user_id = int.Parse(users.UserId().ToString());

                if (authenticate == true)
                {
                    this.Close();

                    th = new Thread(openmainform);

                    th.SetApartmentState(ApartmentState.STA);

                    th.Start();
                }
                else
                {
                    MessageBox.Show("Authentication Failed");
                }
        }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            togMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void pictureBox1_MouseUp_1(object sender, MouseEventArgs e)
        {
            togMove = 0;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (togMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }
    }
}
