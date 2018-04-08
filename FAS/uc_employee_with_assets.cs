using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FAS
{
    public partial class uc_employee_with_assets : UserControl
    {
        Asset asset = new Asset();
        Position position = new Position();
        Logs log = new Logs();

        frm_fas _Main;
        int _user_id;
        int _privilege_id;
        DataTable _assetsDT = new DataTable();
        DataTable _posDt = new DataTable();
        public uc_employee_with_assets()
        {
            InitializeComponent();
        }
        public uc_employee_with_assets(frm_fas Main,int EmployeeId)
        {
            InitializeComponent();
            this._Main = Main;
            this._user_id = EmployeeId;
        }
        public void EmployeesWithAssets()
        {
            
            var source = new BindingSource();
            AssetsRepository assetRepository = new AssetsRepository();
            List<AssetsModel> assetList = assetRepository.GetAllEmployeeWithAssets(metroTextBox1.Text);
            source.DataSource = assetList;
            dg_employee_assets.Columns.Clear();
            dg_employee_assets.DataSource = source;
            dg_employee_assets.Columns["Id"].Visible = false;
            dg_employee_assets.Columns["PropertyTag"].Visible = false;
            dg_employee_assets.Columns["EmployeeId"].Visible = false;
            dg_employee_assets.Columns["Price"].Visible = false;
            dg_employee_assets.Columns["Items"].Visible = false;
            dg_employee_assets.Columns["Serial"].Visible = false;
            dg_employee_assets.Columns["DateAcquired"].Visible = false;
            


            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dg_employee_assets.Columns.Add(btn);
            btn.HeaderText = "View";
            btn.Text = "View";
            btn.UseColumnTextForButtonValue = true;
            btn.Name = "btn";

            dg_employee_assets.ClearSelection();



        }
        public void Department() {

        }
        public void HideControls() {
            this.panel1.Visible = false;
            
            this.btn_search.Visible = false;
            this.dg_employee_assets.Visible = false;
            
            this.metroTextBox1.Visible = false;
            //this.lbl_accountability.Visible = false;
        }
        public void ShowControls()
        {
            this.panel1.Visible = true;
            
            this.btn_search.Visible = true;
            this.dg_employee_assets.Visible = true;
            this.metroTextBox1.Visible = true;
            //this.lbl_accountability.Visible = true;
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            this.Department();  
        }



        private void btn_search_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.EmployeesWithAssets();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dg_employee_assets_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var employee_id = int.Parse(dg_employee_assets.CurrentRow.Cells["EmployeeId"].Value.ToString());
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                switch (senderGrid.Columns[e.ColumnIndex].HeaderText)
                {
                    case "View":
                        this.HideControls();
                        employee_assets_controller _employee_asset = new employee_assets_controller(employee_id, this._user_id);
                        this.Controls.Add(_employee_asset);

                        break;
                    case "Print":
                        //frm_preview_assets _print = new frm_preview_assets(employee_id);
                        //_print.ShowDialog();
                        break;
                }

            }
        }

        private void metroTextBox1_TextChanged_1(object sender, EventArgs e)
        {
        
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
