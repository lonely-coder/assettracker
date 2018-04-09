using System;
using System.Windows.Forms;

namespace FAS
{
    public partial class frm_add_vendors : MetroFramework.Forms.MetroForm
    {
        int _vendor_id;
        
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
        public frm_add_vendors(uc_vendor_list Vendors,int vendor_id)
        {
            InitializeComponent();
            _vendors = Vendors;
            _vendor_id = vendor_id;
            VendorRepository vendorRepository = new VendorRepository();
            var vendor = vendorRepository.getById(_vendor_id);

            txt_vendorName.Text = vendor.VendorName;
            txt_address.Text = vendor.Address;
            txt_contactNumber.Text = vendor.ContactNumber;
            txt_email.Text = vendor.EmailAddress;
            txt_tags.Text = vendor.Tags;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Vendors vendor = new Vendors()
                {
                    VendorName = txt_vendorName.Text,
                    Address = txt_address.Text,
                    ContactNumber = txt_contactNumber.Text,
                    EmailAddress = txt_email.Text,
                    Tags = txt_tags.Text
                };

                VendorRepository vendorRepository = new VendorRepository(vendor);
                switch (this._vendor_id) {
                    case 0:
                        vendorRepository.CreateVendor();
                        MessageBox.Show("New Vendor Saved");
                        break;
                    default:
                        vendor.ID = this._vendor_id;
                        vendorRepository.UpdateVendor();
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
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
