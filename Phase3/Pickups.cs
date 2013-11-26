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
    public partial class Pickups : UserControl
    {
        private List<int> userIds = new List<int>();

        public Pickups()
        {
            InitializeComponent();

            MySqlDataReader rdr = Phase3.DataAccess.GetPickups(3);


            while (rdr.Read())
            {
                userIds.Add(rdr.GetInt32(0));
                string address = rdr.GetString(4) + ", " + rdr.GetString(5) + ", " + rdr.GetString(6) + " " + rdr.GetString(7);
                clientData.Rows.Add(rdr.GetString(1), rdr.GetString(2), rdr.GetInt32(9), address, rdr.GetString(3), rdr.GetString(8));
            }

            Phase3.DataAccess.CloseConnection();
        }

        public void addBtnReturnClickHandler(EventHandler handler)
        {
            this.btnReturn.Click += handler;
        }

        public void addBtnSignInHandler(EventHandler handler)
        {
            this.btnSignIn.Click += handler;
        }
    }
}
