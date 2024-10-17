using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Signup
{
    internal class infoDAO
    {
        List<info> info_try = new List<info>();
        string connectionString = "datasource=teerachots-macbook-air.local/;port8888;username=root;password=root;database=test;";

        internal int addOneRecord(info a1)
        {
            MySqlConnection connect = new MySqlConnection(connectionString);
            connect.Open();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO 'signup'('First_Name', 'Last_Name', 'Sex', 'BirthDate', 'Email', 'Occupation') VALUES (@fname,@lname,@sex,@birthdate,@email,@occupation)",
                connect);
            cmd.Parameters.AddWithValue("@fname", a1.fName);
            cmd.Parameters.AddWithValue("@lname", a1.LName);
            cmd.Parameters.AddWithValue("@sex", a1.Sex);
            cmd.Parameters.AddWithValue("@birthdate", a1.Bdate);
            cmd.Parameters.AddWithValue("@email", a1.Email);
            cmd.Parameters.AddWithValue("@Occupation", a1.Occup);

            int newRows = cmd.ExecuteNonQuery();
            connect.Close();
            return newRows;
        }
        
        public List<info> getAll()
        {
            List<info> returnall = new List<info>();
            MySqlConnection connect = new MySqlConnection(connectionString);
            connect.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM signup", connect);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    info ret = new info()
                    {
                        ID = reader.GetInt32(0),
                        fName = reader.GetString(1),
                        LName = reader.GetString(2),
                        Sex = reader.GetString(3),
                        Bdate = reader.GetString(4),
                        Email = reader.GetString(5),
                        Occup = reader.GetString(6),
                    };
                    returnall.Add(ret);
                }
            }
                connect.Close();    
                return returnall;
        }
        
        internal int updateOneRecord(info a1)
        {
            MySqlConnection connect = new MySqlConnection(connectionString);
            connect.Open();

            MySqlCommand cmd = new MySqlCommand("UPDATE signup SET First_Name= @fname, Last_Name = @lname, Sex = @sex, BirthDate = @birthdate, Email = @email, Occupation = @Occupation WHERE ID = @ID",
                connect);
            cmd.Parameters.AddWithValue("@ID", a1.ID);
            cmd.Parameters.AddWithValue("@fname", a1.fName);
            cmd.Parameters.AddWithValue("@lname", a1.LName);
            cmd.Parameters.AddWithValue("@sex", a1.Sex);
            cmd.Parameters.AddWithValue("@birthdate", a1.Bdate);
            cmd.Parameters.AddWithValue("@email", a1.Email);
            cmd.Parameters.AddWithValue("@Occupation", a1.Occup);

            int newRows = cmd.ExecuteNonQuery();
            connect.Close();
            return newRows;
        }

        internal int deleteOnRecord(int id_row)
        {
            
            MySqlConnection connect = new MySqlConnection(connectionString);
            connect.Open();

            MySqlCommand cmd = new MySqlCommand("DELETE FROM 'signup' WHERE 'signup', 'ID' = @ID", 
                connect);
            cmd.Parameters.AddWithValue("@ID", id_row);
            int newRows = cmd.ExecuteNonQuery();
            connect.Close();
            return newRows;

        }
        
    }
}
