using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationTier
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void pickupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pickups control = new Pickups();
            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);

            control.addBtnReturnClickHandler(new EventHandler(CloseClickHandler));
        }

        private void SignInClickHandler(object sender, EventArgs e)
        {
            //panel1.Controls[0].GetClient();
            panel1.Controls.Clear();

        }

        private void CloseClickHandler(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
        }
    }
}
