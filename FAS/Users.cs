using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using BCrypt.Net;
namespace FAS
{
    public class Users
    {
        //string _id;
        string _username;
        string _password;
        int _privilege_id;
        int _employee_id;
        int _user_id;

        Connection _dbconnection;
        public Users() {

        }
        public Users(string username,string password){
            this._username = username;
            this._password = password;
        }
        public int Id {
            get {
                return this._user_id;
            }
            set {
                this._user_id = value;
            }
        }
        public string UserName
        {
            get { return this._username; }
            set {
                if (!string.IsNullOrWhiteSpace(value)) {
                    this._username = value;
                }
                else {
                    throw new ArgumentException("User Name Is Required");
                }
            }
        }

        public string Password
        {
            get { return this._password; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this._password = value;
                }
                else {
                    throw new ArgumentException("Password Is Required");
                }
            }
        }
        public int EmployeeId
        {
            get { return this._employee_id; }
            set
            {
                if (value > 0)
                {
                    this._employee_id = value;
                }
                else {
                    throw new ArgumentException("Employee ID is Required");
                }
            }
        }
        public int Privilege {
            get { return this._privilege_id; }
            set {
                if (value > 0)
                {
                    this._privilege_id = value;
                }
                else {
                    throw new ArgumentException("Privilege Type is Required");
                }
               }
        }
        public int SelectUser() {
            //this.Query = $@"SELECT privilege_id from users WHERE id = {this._user_id} LIMIT 1";
            //DataTable dt = this.Select();

            //foreach (DataRow row in dt.Rows) {
            //    this._privilege_id = int.Parse(row[0].ToString());
            //}
            return this._privilege_id;
        }

 
        public void Encrypt() {

            //this.Query = "SELECT * from users";
            //DataTable x = this.Select();
            
            //foreach (DataRow row in x.Rows)
            //{
            //    //plain text
            //    string password = row[5].ToString();
            //    //salt:random characters
            //    string salt = BCrypt.Net.BCrypt.GenerateSalt();
            //    string hash = BCrypt.Net.BCrypt.HashPassword(password+ salt);

            //    try
            //    {

            //        //this.Query = $"UPDATE users set salt = '{salt}', password = '{hash}' WHERE id = {int.Parse(row[0].ToString())}";

            //        //this.Update();
            //    }
            //    catch (Exception ex) {
            //        throw new ArgumentException(ex.Message);
            //    }
                

            //}

        }
        public void InsertUser() {
            //prepare query
            //this.Query = @"INSERT INTO users values(
            //            null,
            //            @employee_id,
            //            @privilege_id,
            //            @user_name,
            //            @salt,
            //            @password,
            //            now())";
            ////generate salt
            //string salt = BCrypt.Net.BCrypt.GenerateSalt();
            ////hash plain text password and 'Add salt to taste'
            //string password = BCrypt.Net.BCrypt.HashPassword(this._password + salt);
            ////assign salted password to variable
            //string hashed_pass = password;
            //if (this.OpenConnection() == true) {
            //    try
            //    {
            //        cmd = new MySqlCommand(this.Query, this.connection);
            //        cmd.Parameters.AddWithValue("@employee_id", this._employee_id);
            //        cmd.Parameters.AddWithValue("@privilege_id", this._privilege_id);
            //        cmd.Parameters.AddWithValue("@salt", salt);
            //        cmd.Parameters.AddWithValue("@user_name", this._userName);
            //        cmd.Parameters.AddWithValue("@password", hashed_pass);
            //        cmd.ExecuteNonQuery();
            //    }
            //    catch (MySqlException ex)
            //    {
            //        if (ex.Number == 1062)
            //        {
            //            throw new ArgumentException("Employee already has an existing account!");
            //        }
            //        else {
            //            throw new ArgumentException(ex.Message);
            //        }
                    
            //    }
            //}
            
        }
        public int PrivilegeId() {
            return this._privilege_id;
        }
        public int UserId() {
            return this._user_id;
        }
        public string GetUserName() {
            return this._username;
        }
}
}
