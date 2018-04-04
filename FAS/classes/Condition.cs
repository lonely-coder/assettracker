using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace FAS
{
    class Condition :DB
    {

        private int _id;
        private string _item_condition;
        private DataTable _dt;

        Logs log = new Logs();
        public int ID {
            get {
                return this._id;
            }
            set {
                if (value > 0)
                {
                    this._id = value;
                }
                else {
                    throw new ArgumentException("Invalid Item Condition ID");
                }
            }
        }
        public string ItemConditon {
            get {
                return this._item_condition;
            }
            set {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this._item_condition = value;
                }
                else {
                    throw new ArgumentException("Invalud Item Condition");
                }
            }
        }
        public DataTable SelectItemCondition() {
            
            try
            {            
                this.Query = "SELECT * from item_condition";
                this._dt = new DataTable();
                this._dt = this.Select();

            }
            catch (MySqlException ex)
            {
                log.ErrorLog(ex.Message, this);
                throw new ArgumentException("Error loading categories.\nPlease contact your System Administrator.");
            }
            return _dt;
        }
    }
}
