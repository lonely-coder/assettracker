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
                dataGridView1.Columns["EmployeeId"].Visible = false;
                dataGridView1.Columns["Employee"].Visible = false;
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            this.EmployeeAssets();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            frm_preview_assets _assets = new frm_preview_assets(this._employeeId);
            _assets.ShowDialog();
        }

    }
}
