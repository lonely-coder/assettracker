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
    public partial class frm_preview_assets : Form
    {
        int _employee_id;
        public frm_preview_assets()
        {
            InitializeComponent();
        }
        public frm_preview_assets(int employee_Id)
        {
            InitializeComponent();
            _employee_id = employee_Id;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void frm_preview_assets_Load(object sender, EventArgs e)
        {
            AssetsRepository assetRepository = new AssetsRepository();

            //EmployeeAssets1.SetParameterValue("emp_id", _employee_id);
            //EmployeeAssets1.SetDataSource(assetRepository.GetEmployeeAssets(_employee_id));
            var data = assetRepository.SelectAssetsPerEmployee(_employee_id);
            
            DataSet ds = new DataSet();

            ds.Tables.Add(data);

            if (ds.Tables[0].Rows.Count > 0)
            {
                EmployeeAssets1.SetParameterValue("emp_id", _employee_id);
                EmployeeAssets1.SetDataSource(ds.Tables[0]);
            }
            else {
                MessageBox.Show("No data.");
            }
        }
    }
}
