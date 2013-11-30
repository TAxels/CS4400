using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phase3;

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
            panel1.Controls.Clear();
            Pickups control = new Pickups();
            control.Name = "pickups";
            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);

            control.addBtnSignInClickHandler(new EventHandler(SignInClickHandler));
            control.addBtnReturnClickHandler(new EventHandler(CloseClickHandler));
        }

        private void SignInClickHandler(object sender, EventArgs e)
        {
            int cid = ((Pickups) panel1.Controls.Find("pickups", false).FirstOrDefault()).getClient();
            FBag control = new FBag(cid);
            control.Name = "fBag";
            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);
            control.BringToFront();

            control.addBtnCompletelickHandler(new EventHandler(CloseClickHandler));
            control.addBtnReturnClickHandler(new EventHandler(PickupsClickHandler));
        }

        private void CloseClickHandler(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
        }

        private void PickupsClickHandler(object sender, EventArgs e)
        {
            panel1.Controls.RemoveByKey("fBag");
        }

        private void monthlyServiceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            MSR control = new MSR();
            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Dropoff control = new Dropoff();
            control.Name = "dropoff";
            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);
        }

        private void cToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AddClient control = new AddClient();
            control.Name = "addclient";
            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);
        }
    }
}
