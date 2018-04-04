namespace FAS
{
    public class Department
    {
        private string _department_name;
        public int Id {
            get; set;
        }
        public string DepartmentNames {
            get {
                return _department_name;
            }
            set {
                _department_name = value;
            }
        }
        public override string ToString()
        {
            return _department_name.ToString();
        }

    }
}
