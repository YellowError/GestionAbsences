using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using PL;

namespace Gestion_d_abscence
{
    public partial class frmAddStudent : Form
    {
        public frmAddStudent()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(txbFirstName.Text == String.Empty || txbLastName.Text == string.Empty || txbTotalAbsence.Text == string.Empty)
            {
                MessageBox.Show("You must fill all inputs");
            }
            else
            {
                string message = PlStudent.createStudent(new DtoStudent() { FirstName = txbFirstName.Text, LastName = txbLastName.Text, TotalAbsence = Convert.ToInt32(txbTotalAbsence.Text) });
                MessageBox.Show(message);
                frmManageStudents frm = new frmManageStudents();
                frm.Show();
                this.Close();
            }
            
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            txbTotalAbsence.Text = "0";
        }
    }
}
