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
        }

        public int getClient()
        {
            return (int) clientData.SelectedRows[0].Cells["CID"].Value;
        }

        public void addBtnReturnClickHandler(EventHandler handler)
        {
            btnReturn.Click += handler;
        }

        public void addBtnSignInClickHandler(EventHandler handler)
        {
            btnSignIn.Click += handler;
        }

        private void cbPday_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = Phase3.DataAccess.GetPickups(Convert.ToInt32(cbPday.SelectedItem));

            clientData.AutoGenerateColumns = false;
            clientData.DataSource = ds;
            clientData.DataMember = ds.Tables[0].ToString();
        }
    }
}
