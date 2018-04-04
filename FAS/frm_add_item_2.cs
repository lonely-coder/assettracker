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
    public partial class frm_add_item_2 : Form
    {
        DataTable _dt_cat = new DataTable();
        DataTable _dt_sub_cat = new DataTable();
        DataTable _dt_vendor = new DataTable();

        Vendors vendors = new Vendors();
        Category category = new Category();
        SubCategory subCategory = new SubCategory();
        public frm_add_item_2()
        {
            InitializeComponent();
        }
       
        private void frm_add_item_2_Load(object sender, EventArgs e)
        {

       
        }
        private void metroTextBox6_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cb_cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
