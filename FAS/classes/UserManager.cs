using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
namespace FAS
{
    public class UserManager
    {
        Connection _connection;
        Users _users;
        public UserManager(Connection connection,Users users) {
            _connection = connection;
            _users = users;
        }

        public bool AuthenticateUser() {
            bool matched = false;
            
            string query = $@"SELECT id,
                            user_name,
                            password,
                            salt 
                            FROM users 
                            WHERE 
                            user_name = @username
                            LIMIT 1";

            try
            {
                using (MySqlConnection connection = _connection.GetConnection()) {
                    using (MySqlCommand cmd = new MySqlCommand(query,connection)) {
                        cmd.Parameters.AddWithValue("@username",this._users.UserName);
                        using (MySqlDataReader reader = cmd.ExecuteReader()) {
                            while (reader.Read()) {
                                matched= BCrypt.Net.BCrypt.Verify(this._users.Password + reader["salt"].ToString(), reader["password"].ToString());
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex) {
                throw new ArgumentException(ex.Message);
            }
            catch (Exception ex) {
                throw new ArgumentException(ex.Message);
            }

            return matched;
        }
    }
}
