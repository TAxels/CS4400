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

            this.cid = cid;
            DataSet ds = Phase3.DataAccess.GetFBag(cid);
            bagData.AutoGenerateColumns = false;
            bagData.DataSource = ds;
            bagData.DataMember = ds.Tables[0].ToString();

            lblName.Text = (string) bagData.Rows[0].Cells["PersonName"].Value;
            lblDate.Text = DateTime.Now.ToString();
        }

        private void bagData_SelectionChanged(object sender, EventArgs e)
        {
            bagData.ClearSelection();
        }

        public void addBtnReturnClickHandler(EventHandler handler)
        {
            btnReturn.Click += handler;
        }

        public void addBtnCompletelickHandler(EventHandler handler)
        {
            btnComplete.Click += handler;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            Phase3.DataAccess.LogPickup(this.cid, (string) bagData.Rows[0].Cells["BagName"].Value);
        }
    }
}
