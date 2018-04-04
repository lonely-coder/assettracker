using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace FAS
{
    public class Position :DB
    {
        
        private int _id;
        private int _department_id;
        private string _position_name;
        private DataTable _dt;
        
        public int Id {

            get { return this._id; }
            set {
                if (value > 0)
                {
                    this._id = value;
                }
                else {
                    throw new ArgumentException("Position is required.");
                }
                
            }
        }
        public int DepartmentId
        {

            get { return this._department_id; }
            set
            {
                this._department_id = value;
            }
        }
        public string PositionName
        {
            get { return this._position_name; }
            set
            {
                this._position_name = value;
            }
        }
        public override string ToString()
        {
            return _position_name;
        }
        public DataTable LoadPosition() {

            this.Query = $"SELECT * from positions WHERE department_id = {this._department_id}";
            return this._dt = this.Select() ;
        }
    }
}
