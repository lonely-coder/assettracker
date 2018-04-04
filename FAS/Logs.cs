using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using MySql.Data.MySqlClient;
namespace FAS
{
    class Logs:DB
    {
        private int _id;
        private int _log_type;
        private int _user_id;
        private string _ip_address;
        private string _log_description;
        public string _host_name;
        public string _IP;

        public int Id {
            get {
                return this._id;
            }
            set {
                this._id = value;
            }
        }
        public int LogType {
            get {
                return this._log_type;
            }
            set {
                this._log_type = value;
            }
        }
        public int UserId {
            get {
                return this._user_id;
            }
            set {
                this._user_id = value;
            }
        }
        public string IP {
            get {
                return this._ip_address;
            }
            set {
                this._ip_address = value;
            }
        }
        public string LogDescription {
            get {
                return this._log_description;
            }
            set {
                this._log_description = value;
            }
        }

        public void ErrorLog(string ErrorLog,object obj) {
            string _error_log = ErrorLog;
            object _obj = obj;
            this._host_name = Dns.GetHostName();
            this._IP = Dns.GetHostEntry(this._host_name).AddressList[0].ToString();
            this.Query = $@"INSERT INTO logs
                        values(null,
                        2,
                        @log_description,
                        @ip_address,
                        now())";
            
                if (this.OpenConnection() == true) {
                    cmd = new MySqlCommand(this.Query, this.connection);
                    cmd.Parameters.AddWithValue("@log_description", _error_log +" from "+_obj);
                    cmd.Parameters.AddWithValue("@ip_address", this._IP);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
            }
            
        }
    }
}
