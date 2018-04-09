using System;

namespace FAS
{
    public class Position
    {
        private int _id;
        private int _department_id;
        private string _position_name;
        
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
    }
}
