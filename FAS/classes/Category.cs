using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
namespace FAS
{
    class Category :DB
    {

        private int _id;
        private string _category;
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
                    throw new ArgumentException("Invalid Category ID");
                }
            }
        }
        public string CategoryName {
            get
            {
                return this._category;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this._category = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Category");
                }
            }
        }
        public DataTable Categories() {

            try {
                this.Query = "SELECT * from asset_category";
                this._dt = new DataTable();
                this._dt = this.Select();

            }
            catch (MySqlException ex) {
                log.ErrorLog(ex.Message, this);
                throw new ArgumentException("Error loading categories.\nPlease contact your System Administrator.");
            }
            return _dt;
        }
    }
}
