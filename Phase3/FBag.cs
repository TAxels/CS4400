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

            DataSet ds = Phase3.DataAccess.GetPickups(cid);

        }


    }
}
