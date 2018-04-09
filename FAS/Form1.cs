using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BCrypt.Net;
using MySql.Data.MySqlClient;
namespace FAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.Encrypt();
            MessageBox.Show("Success");
        }
    }
}
