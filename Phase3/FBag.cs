using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PresentationTier
{
    public partial class FBag : UserControl
    {
        private int cid;

        public FBag(int cid)
        {
            InitializeComponent();

            MySqlDataReader rdr = Phase3.DataAccess.GetPickups(3);

            while (rdr.Read())
            {
                //userIds.Add(rdr.getint32(0));
                //string address = rdr.getstring(4) + ", " + rdr.getstring(5) + ", " + rdr.getstring(6) + " " + rdr.getstring(7);
                //clientdata.rows.Add(rdr.GetString(1), rdr.GetString(2), rdr.GetInt32(9), address, rdr.GetString(3), rdr.GetString(8));
            }

            Phase3.DataAccess.CloseConnection();
        }


    }
}
