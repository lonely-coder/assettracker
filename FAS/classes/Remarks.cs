using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
namespace FAS
{
    class Remarks: DB
    {

        private int _id;
        private string _remarks;
        private DataTable _dt;
        public int Id {
            get {
                return this._id;
            }
            set {
                this._id = value;
            }
        }
        public string Remark {
            get {
                return this._remarks;
            }
            set {
                this._remarks = value;
            }
        }
        public DataTable AssetRemarks() {
   
                this.Query = $"SELECT id,remarks from remarks";
                
                return this._dt = this.Select();
   
   
            
        }
    }
}
