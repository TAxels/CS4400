using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

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
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public static DataSet GetPickups(int pickUpDay)
        {
            string query = String.Format("SELECT Client.Client_ID, FirstName, LastName, Phone, CONCAT(Street, ', ', City, ', ', State, ' ', Zipcode) AS Address, Size, PickUpDay FROM Client INNER JOIN FamilySize WHERE PickUpDay={0}", pickUpDay);
            //string query = "SELECT * FROM Client INNER JOIN FamilySize";

            return DataAccess.ReadSet(query);
        }

        public static DataSet GetFBag(int cid)
        {
            string query = String.Format("SELECT CONCAT(FirstName, ' ', LastName) AS Name, Product_Name, Current_Mnth_Qty FROM Client INNER JOIN Holds ON Client.Bag_Type=Holds.Bag_Name WHERE Client_ID={0}", cid);

            return DataAccess.ReadSet(query);
        }

        public static DataSet ReadSet(string query)
        {
            try
            {
                conn.Open();

                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.Fill(ds, "Results");

                return ds;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                return null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
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
    }
}
