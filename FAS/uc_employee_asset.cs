using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
namespace FAS
{
    public partial class employee_assets_controller : UserControl
    {
        uc_employee_with_assets _main;
        public int _employeeId;
        int _user_id;
        int _privilege_id;
        public employee_assets_controller(int Id,int UserId)
        {
            InitializeComponent();
            this._main = new uc_employee_with_assets();
            _employeeId = Id;
            EmployeeRepository employeeRepository = new EmployeeRepository();
            Employee employee = employeeRepository.SelectById(Id);

            StringBuilder name = new StringBuilder();
            name.Append(employee.FirstName).Append(" ").Append(employee.LastName);
            txt_name.Text = name.ToString();
            txt_emp_id.Text = employee.EmployeeID;
            txt_dept.Text = employee.Department.DepartmentNames;
            txt_pos.Text = employee.Position.PositionName;
            this._user_id = UserId;

            Users user = new Users();
            user.Id = this._user_id;
            this._privilege_id = user.SelectUser();

 
        }

        public void EmployeeAssets()
        {
            try {
                var source = new BindingSource();
                AssetsRepository assetRepository = new AssetsRepository();
                List<AssetsModel> assetList = assetRepository.GetEmployeeAssets(_employeeId);
                source.DataSource = assetList;
                dataGridView1.DataSource = source;
                dataGridView1.Columns["Id"].Visible = false;
                //dataGridView1.Columns["EmployeeId"].Visible = false;
                dataGridView1.Columns["Employee"].Visible = false;
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        public void AddButtonOnGrid() {
            //if (this._privilege_id == 1) {
            //    DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            //    dataGridView1.Columns.Add(btnDelete);
            //    btnDelete.HeaderText = "Delete";
            //    btnDelete.Text = "Remove";
            //    btnDelete.UseColumnTextForButtonValue = true;
            //    btnDelete.Name = "btnDelete";

            //    DataGridViewButtonColumn btnTransfer = new DataGridViewButtonColumn();
            //    dataGridView1.Columns.Add(btnTransfer);
            //    btnTransfer.HeaderText = "Transfer";
            //    btnTransfer.Text = "Transfer";
            //    btnTransfer.UseColumnTextForButtonValue = true;
            //    btnTransfer.Name = "btnTransfer";

            //}


            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //dataGridView1.Columns.Add(btn);
            //btn.HeaderText = "View";
            //btn.Text = "View";
            //btn.UseColumnTextForButtonValue = true;
            //btn.Name = "btn";
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            this.EmployeeAssets();

            //if (this._privilege_id > 1)
            //{
            //    btn_add_asset.Visible = false;
            //    button1.Visible = false;
                
            //}
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //var accountabilityId = int.Parse(dataGridView1.CurrentRow.Cells["pkAccountability"].Value.ToString());
            //var employeeId = int.Parse(dataGridView1.CurrentRow.Cells["pkEmployeeId"].Value.ToString());
            //var senderGrid = (DataGridView)sender;

            //if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
            //    e.RowIndex >= 0)
            //{
            //    switch (senderGrid.Columns[e.ColumnIndex].HeaderText) {
            //        case "Transfer":
            //            frm_employees _employees = new frm_employees(this, employeeId, accountabilityId);
            //            _employees.ShowDialog();
            //            break;
            //        case "Delete":
            //            frm_delete_asset _delete = new frm_delete_asset(this, accountabilityId);
            //            _delete.ShowDialog();
            //            break;
            //        case "View":
            //            //Console.WriteLine(employeeId+""+accountabilityId,_user_id);
            //            frm_add_asset _asset = new frm_add_asset(this, accountabilityId,_user_id);
            //            _asset.ShowDialog();
            //            break;
            //        default:
            //            MessageBox.Show("No Action Has been take");
            //            break;
            //    } 
            //}
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            frm_add_asset _addAsset = new frm_add_asset(this, this._employeeId);
            _addAsset.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_preview_assets _assets = new frm_preview_assets(this._employeeId);
            _assets.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frm_employees _employees = new frm_employees(this, this._employeeId);
            _employees.ShowDialog();
        }
    }
}
