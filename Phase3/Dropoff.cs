using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phase3
{
    public partial class Dropoff : UserControl
    {
        public Dropoff()
        {
            InitializeComponent();
            lblDatetime.Text = DateTime.Now.ToString();
        }
    }
}
