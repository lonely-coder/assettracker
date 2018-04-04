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
        //Constructor
        public Connection()
        {
            
        }
        
        public MySqlConnection GetConnection()
        {
            try
            {
                _connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                _connection.Open();
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
        public void CommitChanges() {
            _transaction.Commit();
        }
        public void RollBack() {
            _transaction.Rollback();
        }
        
    }
}

