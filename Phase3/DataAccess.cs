using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Phase3
{
    class DataAccess
    {
        private static string cs = @"server=box439.bluehost.com;database=johncho1_cs4400_3;port=3306;uid=johncho1_cs4400;
            password=Bananaphone!";
        private static MySqlConnection conn = new MySqlConnection(cs);

        public static bool ValidateUser(string username, string password)
        {
            string query = "SELECT * FROM User WHERE Username=@Username AND Password=@Password";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@Username", username),
                new MySqlParameter("@Password", password)
            };

            try
            {
                MySqlDataReader rdr = DataAccess.ReadData(query, parameters);

                if (rdr.Read())
                {
                    return true;
                }
                return false;
            }
            finally
            {
                DataAccess.CloseConnection();
            }
        }

        public static MySqlDataReader GetPickups(int pickUpDay)
        {
            string query = "SELECT Client.Client_ID, FirstName, LastName, Phone, Street, City, State, Zipcode, Bag_Type, Size FROM Client INNER JOIN FamilySize WHERE PickUpDay=@PickUpDay";
            //string query = "SELECT * FROM Client INNER JOIN FamilySize";

            MySqlParameter[] parameters = new MySqlParameter[] {
                new MySqlParameter("@PickUpDay", pickUpDay)
            };

            return DataAccess.ReadData(query, parameters);
        }

        public static MySqlDataReader ReadData(string query, MySqlParameter[] parameters)
        {
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Prepare();

                cmd.Parameters.AddRange(parameters);

                return cmd.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                return null;
            }
        }

        public static void WriteData(string query, MySqlParameter[] parameters)
        {
            MySqlConnection conn = null;

            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Prepare();

                cmd.Parameters.AddRange(parameters);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
        }

        public static void CloseConnection()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
