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
        public FBag(int cid)
        {
            InitializeComponent();

            DataSet ds = Phase3.DataAccess.GetFBag(cid);
            bagData.AutoGenerateColumns = false;
            bagData.DataSource = ds;
            bagData.DataMember = ds.Tables[0].ToString();

            lblName.Text = (string) bagData.Rows[0].Cells["PersonName"].Value;
            lblDate.Text = DateTime.Now.ToString();
        }


    }
}
