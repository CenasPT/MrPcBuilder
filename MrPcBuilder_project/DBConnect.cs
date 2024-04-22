using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Session;

namespace MrPcBuilder_project
{
    internal class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string port;
        private string username;
        private string password;
        private string database;

        public DBConnect()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            port = "3306";
            username = "root";
            password = "";
            database = "mrpcbuilder_database";

            string connectionString = "Server = " + server + "; Port = " + port + "; Database = " +
                database + "; Uid = " + username + "; Pwd = " + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool CloseConnection()
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

        // LOGIN VALIDATION
        public bool ValidateLogin(string username, string password)
        {
            bool flag = false;

            try
            {                
                if (OpenConnection())
                {
                    // check user status (login fails)
                    string queryStatus = "select fails from employee_login where username = '" + username + "';";
                    MySqlCommand cmdStatus = new MySqlCommand(queryStatus, connection);
                    if (cmdStatus.ExecuteScalar() == null)
                    {
                        MessageBox.Show("Failed Authentication!");
                        return false;
                    }
                    else
                    {
                        int fails = int.Parse(cmdStatus.ExecuteScalar().ToString());

                        if (fails >= 5)
                        {
                            string queryUpdateStatus = "update employee_login set user_status = 'Inactive' where username = '" + username + "';";
                            MySqlCommand cmdUpdateStatus = new MySqlCommand(queryUpdateStatus, connection);
                            cmdUpdateStatus.ExecuteNonQuery();
                            MessageBox.Show("User " + username + " is bloqued!\nContact system administrator.");
                            return false;
                        }

                        // check credentials if user is not blocked
                        string queryLogin = "select username from employee_login where username = '" + username + "' and user_password = '" + password + "' and user_status = 'Active';";
                        MySqlCommand cmdLogin = new MySqlCommand(queryLogin, connection);
                        if (cmdLogin.ExecuteScalar() != null)
                        {
                            fails = 0;                            
                            flag = true;
                        }
                        else
                        {
                            fails++;
                            MessageBox.Show("Failed Authentication!\nFail limit: 5\nCurrent Fails: " + fails);
                        }
                        string queryUpdateFails = "update employee_login set fails = '" + fails + "' where username = '" + username + "';";
                        MySqlCommand cmdUpdateFails = new MySqlCommand(queryUpdateFails, connection);
                        cmdUpdateFails.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return flag;
        }        
    }
}
