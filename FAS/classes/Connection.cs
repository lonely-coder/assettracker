using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace FAS
{
    public class Connection
    {
        private MySqlConnection _connection;
        protected MySqlCommand _cmd;
        protected MySqlTransaction _transaction;

        private int _last_inserted_id = 0;
        //Constructor
        public Connection()
        {
            
        }
        public int LastInsertedId {
            get { return this._last_inserted_id; }
            set { this._last_inserted_id = value; }
        }
        public MySqlConnection GetConnection()
        {
            try
            {
                _connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                _connection.Open();
                Console.WriteLine("Database Connection Established.");
            }
            catch (MySqlException ex) {
                
                switch (ex.Number)
                {
                    //0: Cannot connect to server.
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;
                    //1045: Invalid user name and/or password.
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
              
            }
          
            return _connection;
        }
        public MySqlTransaction BeginTransaction() {
            return _transaction = _connection.BeginTransaction();
        }
        public MySqlTransaction CommitChanges() {
            _transaction.Commit();
            return _transaction;
        }
        public MySqlTransaction RollBack() {
            try
            {
                _transaction.Rollback();
            }
            catch (MySqlException ex) {
                throw new ArgumentException(ex.ToString());
            }
            
            return _transaction;
        }
        public int GetLastInsertedId() {
            return _last_inserted_id;
        }
        
    }
}

