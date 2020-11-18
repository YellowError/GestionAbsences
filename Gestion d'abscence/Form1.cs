using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_d_abscence
{
    public partial class frmLogin : Form
    {
        private readonly Image imageOpenEye = Image.FromFile(@"C:\Users\julie\Pictures\Dev\assets\icons\openEye.png");
        private readonly Image imageClosedEye = Image.FromFile(@"C:\Users\julie\Pictures\Dev\assets\icons\closedEye.png");

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblBadLog.Visible = true;
            frmMenu frm = new frmMenu();
            frm.Show();
            this.Hide();
        }

        private void btnTogglePasswordView_Click(object sender, EventArgs e)
        {
            txbPassword.UseSystemPasswordChar = !txbPassword.UseSystemPasswordChar;
            if(btnTogglePasswordView.BackgroundImage == imageOpenEye)
            {
                btnTogglePasswordView.BackgroundImage = imageClosedEye;
            }
            else
            {
                btnTogglePasswordView.BackgroundImage = imageOpenEye;
            }
        }

        private void btnTogglePasswordView_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnTogglePasswordView_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
