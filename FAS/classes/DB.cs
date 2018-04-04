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
    public class DB
    {
        protected MySqlConnection connection;
        protected MySqlCommand cmd;
        protected MySqlDataAdapter da;
        private string _query;
        
        //Constructor
        public DB()
        {
            Initialize();
            //Console.WriteLine("Connection is Open");
        }
        //Initialize values
        private void Initialize()
        {

            try {
                var connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                connection = new MySqlConnection(connectionString);
                //connection.Open();
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
            
        }

        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                Console.WriteLine();
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public string Query
        {
            get { return _query; }
            set { _query = value; }
        }
        //Insert statement
        public void Insert()
        {
            //open connection
            if (this.OpenConnection() == true)
            {
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(_query, connection);
            
            //Execute command
            cmd.ExecuteNonQuery();

            //close connection
            this.CloseConnection();
            }
        }
        public string SqlQuery(string query) {
            this._query = query;
            return _query;
        }

        //Update statement
        public void Update()
        {
            
            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(_query,connection);
                //Assign the query using CommandText
                

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        public void Delete()
        {
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(_query, connection);
                //Assign the query using CommandText


                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        //Select statement
        public DataTable Select()
        {

            DataTable dt = new DataTable();

            //Open connection
            if (this.OpenConnection() == true)
            {
                
                //Create Command
                MySqlCommand cmd = new MySqlCommand(_query, connection);

                //Create a data adapter and Execute the command
                MySqlDataAdapter itemDataAdapter = new MySqlDataAdapter(cmd);

                itemDataAdapter.Fill(dt);
                

                //close Connection
                this.CloseConnection();

                //return datatable to be displayed
                return dt;
            }
            else
            {
                return dt;
            }
        }
    
        //Count statement
        public int Count()
        {
            
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(_query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }
        public string UserFriendlyError() {
            return "Ooops! Something went wrong. \nPlease Contact your System Administrator";
        }
        public string NameOfObject(object obj) {
            string name = obj.ToString();

            return name;
        }
    }
}

