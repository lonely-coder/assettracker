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
    public partial class frm_add_vendors : MetroFramework.Forms.MetroForm
    {
        int togMove;
        int MValX;
        int MValY;

        int _vendor_id;

        Vendors vendors = new Vendors();
        Logs log = new Logs();
        uc_vendor_list _vendors;
        public frm_add_vendors()
        {
            InitializeComponent();
         
        }
        public frm_add_vendors(uc_vendor_list Vendors)
        {
            InitializeComponent();
            this._vendors = Vendors;

        }
        public frm_add_vendors(uc_vendor_list Vendors,int VendorId)
        {
            InitializeComponent();
            this._vendor_id = VendorId;
            this._vendors = Vendors;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                vendors.VendorName = txt_vendorName.Text;
                vendors.Address = txt_address.Text;
                vendors.ContactNumber = txt_contactNumber.Text;
                vendors.EmailAddress = txt_email.Text;
                vendors.Tags = txt_tags.Text;
                
                switch (this._vendor_id) {
                    case 0:
                        vendors.CreateVendor();
                        MessageBox.Show("New Vendor Saved");
                        break;
                    default:
                        vendors.ID = this._vendor_id;
                        vendors.UpdateVendor();
                        MessageBox.Show("Vendor Updated");
                        break;
                }
                if (this._vendors != null) {
                    this._vendors.Vendors();
                }
                this.Close();
                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_addVendors_Load(object sender, EventArgs e)
        {
            
            if (this._vendor_id > 0) {
                try {
                    vendors.Query = string.Format($@"SELECT * FROM vendors where id = { this._vendor_id}");
                    Console.WriteLine(vendors.Query);
                    DataTable vendorDT = vendors.Select();

                    foreach (DataRow row in vendorDT.Rows)
                    {
                        txt_vendorName.Text = row["vendor_name"].ToString();
                        txt_address.Text = row["address"].ToString();
                        txt_contactNumber.Text = row["contact_number"].ToString();
                        txt_email.Text = row["email_add"].ToString();
                        txt_tags.Text = row["tags"].ToString();

                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void txt_vendorName_Leave(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            togMove = 0;
        }



        private void frm_addVendors_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (togMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            togMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }
    }
}
