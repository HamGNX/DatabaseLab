using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Signup
{
    internal class infoDAO
    {
        // Create a connectionString specifying datasource, port, username, password and database
        string connectionString = "datasource=10.10.100.116;port=3306;" + 
            "username=root;password=root;" + 
            "database=test_lab_06;";
        // Function to add new record
       
        internal int addOneRecord(info a1)
        {
            MySqlConnection connect = new MySqlConnection(connectionString);
            connect.Open();

            int newRows = 0;
            // Create MySqlCommand object and write SQL code to update table record based on ID
            MySqlCommand cmd = new MySqlCommand("INSERT INTO signup (First_name,Last_name,Sex,Birthdate,Email,Occupation) VALUES (@fname,@lname,@sex,@birthdate,@email,@occupation)", connect);
            cmd.Parameters.AddWithValue("@fname", a1.fName);
            cmd.Parameters.AddWithValue("@lname", a1.LName);
            cmd.Parameters.AddWithValue("@sex", a1.Sex);
            cmd.Parameters.AddWithValue("@birthdate", a1.Bdate);
            cmd.Parameters.AddWithValue("@email", a1.Email);
            cmd.Parameters.AddWithValue("@occupation", a1.Occup);

            newRows += cmd.ExecuteNonQuery();

            long signupID = cmd.LastInsertedId;

            MySqlCommand cmdSignup = new MySqlCommand("INSERT INTO login (Singup_ID, Username, Password) VALUES (@Signup_ID, @Signup_Username, @Signup_password)", connect);
            cmdSignup.Parameters.AddWithValue("@Signup_ID", signupID); // Make sure to match column name
            cmdSignup.Parameters.AddWithValue("@Signup_Username", a1.Signup_Username);
            cmdSignup.Parameters.AddWithValue("@Signup_password", a1.Signup_Password);

            newRows += cmdSignup.ExecuteNonQuery();

            connect.Close();
            return newRows;
        }

        // Function to retrieve information
        public List<info> getAll()
        {
            // Create a list of object of class inf
            List<info> info_try = new List<info>();
            // Create MySqlConnection object and open connection
            MySqlConnection connect = new MySqlConnection(connectionString);
            connect.Open();


            // Create MySqlCommand object which read all the records in database
            MySqlCommand cmd = new MySqlCommand(
                "SELECT * FROM signup",connect
                );

            // Create MySqlDataReader object and read all the data gained from  MySqlCommand object. Pass the data to relevant info class parameter
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    info ret = new info() { 
                        ID = reader.GetInt32(0),
                        fName = reader.GetString(1),
                        LName = reader.GetString(2),
                        Sex = reader.GetString(3),
                        Bdate = reader.GetString(4),
                        Email = reader.GetString(5),
                        Occup = reader.GetString(6)
                    };
                    info_try.Add(ret);
                }
            }
            // Close connection
            connect.Close();
            // Return all records
            return info_try;
        }

        // Function to update one record
        internal int updateOneRecord(info a1)
        {
            MySqlConnection connect = new MySqlConnection(connectionString);
            connect.Open();

            // Create MySqlCommand object and write SQL code to update table record based on ID
            MySqlCommand cmd = new MySqlCommand("UPDATE signup SET First_name=@fname,Last_name=@lname,Sex=@sex,Birthdate=@birthdate,Email=@email,Occupation = @occupation WHERE ID = @ID", connect);
            cmd.Parameters.AddWithValue("@ID", a1.ID);
            cmd.Parameters.AddWithValue("@fname", a1.fName);
            cmd.Parameters.AddWithValue("@lname", a1.LName);
            cmd.Parameters.AddWithValue("@sex", a1.Sex);
            cmd.Parameters.AddWithValue("@birthdate", a1.Bdate);
            cmd.Parameters.AddWithValue("@email", a1.Email);
            cmd.Parameters.AddWithValue("@occupation", a1.Occup);

            int newRows = cmd.ExecuteNonQuery();
            connect.Close();
            return newRows;
        }

        // Function to delete one record
        internal int deleteOneRecord(int id_row)
        {
            MySqlConnection connect = new MySqlConnection(connectionString);
            connect.Open();

            MySqlCommand cmd = new MySqlCommand("DELETE FROM signup WHERE ID=@ID",connect);
            cmd.Parameters.AddWithValue("@ID", id_row);
            int newRows = cmd.ExecuteNonQuery();
            MySqlCommand cmdLogin = new MySqlCommand("DELETE FROM login INNER JOIN singup ON sigup.ID = login.Signup_ID WHERE login.Signup_ID = @ID", connect);
            cmdLogin.Parameters.AddWithValue("@User_ID", id_row);

            connect.Close();
            return newRows;
        }
        public info GetUser(string username, string password)
        {
            info userInfo = null;
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT Singup_ID " +
                                                    "FROM login " + 
                                                    "WHERE login.Username = @username AND login.Password = @password", connect);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        userInfo = new info
                        {
                            Signup_ID = reader.GetInt32(0)
                        };
                    }
                }
                connect.Close();
            }
            return userInfo;
        }
    }

}
