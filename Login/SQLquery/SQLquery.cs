using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Login.SQLquery
{
    public class queryOperation
    {
        public static bool _status { set; get; } = true;
        private const string _databasename = "EnglishMochi"; // database name


        public static bool SQLcheckUsername(string strLoginUsername)
        {
            if (_status)
            {
                return true;
            }
            SqlConnection ConnectDatabase = 
                new SqlConnection(string.Format(@"Server=(local);Database={0};Trusted_Connection=Yes;",_databasename));
            try
            {
                if (ConnectDatabase.State == System.Data.ConnectionState.Closed)
                {

                    ConnectDatabase.Open();

                    Debug.WriteLine("OPEN");

                    string sqlString = "SELECT COUNT(1) FROM _User WHERE _userName = @username";
                    SqlCommand cmd = new SqlCommand(sqlString, ConnectDatabase);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@username", strLoginUsername);
           
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count == 1)
                    {
                       
                        return false;
                    }
                    else
                    {
                        
                        return true;
                    }

                }
            }
            catch (Exception err)
            {
                Debug.WriteLine("CLOSE");
                MessageBox.Show(err.Message);
            }
            finally
            {

                ConnectDatabase.Close();
            }


            return false;
            
        }


        public static void SQLRegister(TextBox txtLoginUsername, PasswordBox txtLoginPassword)
        {
            Debug.WriteLine("START REGIS");
            _status = false;



            SqlConnection ConnectDatabase =
                new SqlConnection(string.Format(@"Server=(local);Database={0};Trusted_Connection=Yes;", _databasename));
            try
            {
                if (ConnectDatabase.State == System.Data.ConnectionState.Closed)
                {

                    ConnectDatabase.Open();

                    Debug.WriteLine("OPEN REGIS");


                    string sqlString = "INSERT INTO _User ( _userName, _passWord) \n"
                                       + " VALUES(@username, @password); ";
                    SqlCommand cmd = new SqlCommand(sqlString, ConnectDatabase);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@username", txtLoginUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtLoginPassword.Password);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Register successfully!!");

                }
            }
            catch (Exception err)
            {
                Debug.WriteLine("CLOSE");
                MessageBox.Show(err.Message);
            }
            finally
            {

                ConnectDatabase.Close();
            }
        }

        public static bool SQLlogin(TextBox txtLoginUsername, PasswordBox txtLoginPassword)
        {

            _status = true ;


            SqlConnection ConnectDatabase =
                new SqlConnection(string.Format(@"Server=(local);Database={0};Trusted_Connection=Yes;", _databasename));
            try
            {
                if (ConnectDatabase.State == System.Data.ConnectionState.Closed)
                {

                    ConnectDatabase.Open();

                    Debug.WriteLine("OPEN");

                    string sqlString = "SELECT COUNT(1) FROM _User WHERE _userName = @username  AND _passWord = @password";
                    SqlCommand cmd = new SqlCommand(sqlString, ConnectDatabase);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@username", txtLoginUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtLoginPassword.Password);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count == 1)
                    {
                       
                        return true;
                    }
                    else
                    {
                       
                        return false;
                    }

                }
            }
            catch (Exception err)
            {
                Debug.WriteLine("CLOSE");
                MessageBox.Show(err.Message);
            }
            finally
            {

                ConnectDatabase.Close();
            }


            return false;
        }
    }
}
