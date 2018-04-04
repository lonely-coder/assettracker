using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
namespace FAS
{
    class SubCategory :DB
    {
        private int _id;
        private int _category_id;
        private string _sub_category_name;
        DataTable dt;
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
                    throw new ArgumentException("Invalid Sub Category ID");
                }
                
            }
        }
        public int CategoryId {
            get
            {
                return this._category_id;
            }
            set {
             
                    this._category_id = value;
             
                
            }
        }
        public string SubCategoryName {
            get {
                return this._sub_category_name;
            }
            set {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this._sub_category_name = value;
                }
                else {
                    throw new ArgumentException("Invalid Sub Category Name");
                }
                
            }
        }
        public DataTable SubCategories() {
            this.Query = $"SELECT * FROM asset_sub_category WHERE asset_category_id = @category_id";
            
            
                if (this.OpenConnection() == true) {
                    cmd = new MySqlCommand(this.Query,this.connection);
                    da = new MySqlDataAdapter(cmd);
                    dt = new DataTable();
                    cmd.Parameters.AddWithValue("@category_id", this._category_id);
                    cmd.Prepare();
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                this.CloseConnection();
                }
            return dt;
        }

    }
}
