using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


//test comment for commit practice
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

            DataAccess.OpenConn();
            MySqlDataReader rdr = DataAccess.ReadData(query, parameters);
            bool isRowReturned = rdr.Read();
            DataAccess.CloseConn();

            if (isRowReturned)
            {
                return true;
            }
            return false;
        }

        public static DataSet GetPickups(int pickUpDay)
        {
            string query = String.Format("SELECT Client.Client_ID, FirstName, LastName, Phone, CONCAT(Street, ', ', City, ', ', State, ' ', Zipcode) AS Address, Size, PickUpDay FROM Client INNER JOIN FamilySize ON Client.Client_ID=FamilySize.Client_ID WHERE PickUpDay={0}", pickUpDay);

            return DataAccess.ReadSet(query);
        }

        public static DataSet GetFBag(int cid)
        {
            string query = String.Format("SELECT CONCAT(FirstName, ' ', LastName) AS Name, Bag_Name, Product_Name, Current_Mnth_Qty FROM Client INNER JOIN Holds ON Client.Bag_Type=Holds.Bag_Name WHERE Client_ID={0}", cid);

            return DataAccess.ReadSet(query);
        }

        public static void LogPickup(int cid, string bagName)
        {
            string query = "INSERT INTO Pick_Up_Transaction (Date_Of_Pick_Up) VALUES (NOW()); INSERT INTO Pick_Up (Client_ID, Bag_Name) VALUES (@cid, @bagName)";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@cid", cid),
                new MySqlParameter("@bagName", bagName)
            };

            DataAccess.OpenConn();
            WriteData(query, parameters);
            DataAccess.CloseConn();
        }

        public static void CompleteDropoff(System.Windows.Forms.DataGridView dgDropoff)
        {
            DataAccess.OpenConn();
            string query = "INSERT INTO Drop_Off_Transaction (Date_of_Drop_Off) VALUES (NOW())";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
            };
            WriteData(query, parameters);
            
            foreach (System.Windows.Forms.DataGridViewRow row in dgDropoff.Rows)
            {
                if (row.Cells[0].Value == null)
                {
                    continue;
                }
                query = "INSERT INTO Drop_Off (Drop_Off_Tx_ID, Product_Name, Source_Name, Quantity_Dropped) VALUES (LAST_INSERT_ID(), @pname, @sname, @quantity)";
                parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@pname", row.Cells[0].Value),
                    new MySqlParameter("@sname", row.Cells[1].Value),
                    new MySqlParameter("@quantity", row.Cells[2].Value)
                };
                WriteData(query, parameters);
            }

            DataAccess.CloseConn();
        }

        public static DataSet ReadSet(string query)
        {
            try
            {
                DataAccess.OpenConn();
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.Fill(ds, "Results");
                DataAccess.CloseConn();

                return ds;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                return null;
            }
        }

        public static MySqlDataReader ReadData(string query, MySqlParameter[] parameters)
        {
            try
            {
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
            try
            {
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

        public static void OpenConn()
        {
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
        }

        public static void CloseConn()
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
        }
    }

}
