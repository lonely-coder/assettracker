using System;
using System.Data;
using System.Windows.Forms;


namespace FAS
{
    public partial class frm_employee_info : MetroFramework.Forms.MetroForm
    {
        int _employee_id=0;
        int _user_id;
        int _privilege_id;

        employee_list_controller _employee_list;

        Departments departments = new Departments();
        Position position = new Position();
        EmployeeRepository employeeRepository;

        public frm_employee_info()
        {
            InitializeComponent();
            GetDepartments();

        }
        public frm_employee_info(employee_list_controller employee_list, int UserId)
        {
            InitializeComponent();
            GetDepartments();
            this._employee_list = employee_list;
            this._user_id = UserId;

        }
        public frm_employee_info(employee_list_controller employee_list, int id,int UserId)
        {
            InitializeComponent();
            GetDepartments();
            this._employee_list = employee_list;
            this._user_id = UserId;

            this._employee_id = id;

            employeeRepository = new EmployeeRepository();
            Employee employee =  employeeRepository.SelectById(this._employee_id);
            txt_firstName.Text = employee.FirstName;
            txt_lastName.Text = employee.LastName;
            txt_empid.Text = employee.EmployeeID;
            cb_department.SelectedValue = int.Parse(employee.Department.Id.ToString());
            cb_position.SelectedValue = int.Parse(employee.Position.Id.ToString());
            dateTimePicker1.Value = DateTime.Parse(employee.DateHired.ToString());

            Users user = new Users();
            user.Id = this._user_id;
            this._privilege_id = user.SelectUser();

        }
        private void showEmployeeList() {
            if (_employee_list != null)
            {
                _employee_list.EmployeeList();
            }
        }
        public void ClearFields()
        {
            txt_empid.Clear();
            txt_empid.Focus();
            txt_firstName.Clear();
            txt_lastName.Clear();
            
            cb_department.SelectedIndex = 0;
            cb_position.SelectedIndex = 0;
            
        }

        private void GetDepartments()
        {
            try
            {
                
                DataTable dt = departments.LoadDepartments();

                cb_department.DisplayMember = dt.Columns[1].ToString();

                cb_department.ValueMember = dt.Columns[0].ToString();

                cb_department.DataSource = dt;

                DataRow dr = dt.NewRow();

                dr["department_name"] = "Select a Department";
                dr["id"] = 0;

                dt.Rows.InsertAt(dr, 0);
                cb_department.SelectedIndex = 0;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
                try
                {
                    Employee employee = new Employee();
                    EmployeeRepository employeeRepository = new EmployeeRepository(employee);
                    employee.FirstName = txt_firstName.Text ;
                    employee.LastName = txt_lastName.Text;
                    employee.EmployeeID = txt_empid.Text;
                    employee.Department = new Department()
                    {
                        Id = int.Parse(cb_department.SelectedValue.ToString())
                    };
                    employee.Position = new Position()
                    {
                        Id = int.Parse(cb_position.SelectedValue.ToString())
                    };
                    employee.DateHired = DateTime.Parse(dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"));
                    switch (this._employee_id)
                    {
                        case 0:
                            employeeRepository.Insert();
                            MessageBox.Show("Records has been saved!");
                            ClearFields();
                            break;
                        default:
                            employee.ID = this._employee_id;
                            employeeRepository.Update();
                            MessageBox.Show("Records has been Updated!");
                            ClearFields();
                            break;
                    }
                showEmployeeList();
                    
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 
        }
        private void btn_cancel_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                position.DepartmentId = int.Parse(cb_department.SelectedValue.ToString());
                DataTable dt = position.LoadPosition();

                cb_position.DisplayMember = dt.Columns[2].ToString();

                cb_position.ValueMember = dt.Columns[0].ToString();

                cb_position.DataSource = dt;

                DataRow positiondr = dt.NewRow();

                positiondr["position_name"] = "Select a Position";
                positiondr["id"] = 0;

                dt.Rows.InsertAt(positiondr, 0);

                cb_position.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_empid_TextChanged(object sender, EventArgs e)
        {
            employeeRepository = new EmployeeRepository(); 
            lbl_employee_id_error.Visible = employeeRepository.EmployeeExist(_employee_id, txt_empid.Text);
            btn_save.Enabled = !employeeRepository.EmployeeExist(_employee_id, txt_empid.Text);
        }
    }
}
