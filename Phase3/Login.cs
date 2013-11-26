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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool valid = Phase3.DataAccess.ValidateUser(this.txtUsername.Text, this.txtPassword.Text);
            if (valid)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                //this.lblInvalid.Show();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
