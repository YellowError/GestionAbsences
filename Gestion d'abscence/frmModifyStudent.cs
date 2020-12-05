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
    public partial class frmModifyStudent : Form
    {
        public DtoStudent currentStudent;
        public frmModifyStudent()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmManageStudents frm = new frmManageStudents();
            frm.Show();
            this.Close();
        }

        private void frmModifyStudent_Load(object sender, EventArgs e)
        {
            txbFirstName.Text = currentStudent.FirstName;
            txbLastName.Text = currentStudent.LastName;
            txbTotalAbsence.Text = currentStudent.TotalAbsence.ToString();
            lblTitle.Text = currentStudent.FirstName + " " + currentStudent.LastName;
            btnModify.Visible = false;
        }

        private void txbFirstName_TextChanged(object sender, EventArgs e)
        {
            btnModify.Visible = true;
        }

        private void txbLastName_TextChanged(object sender, EventArgs e)
        {
            btnModify.Visible = true;
        }

        private void txbTotalAbsence_TextChanged(object sender, EventArgs e)
        {
            btnModify.Visible = true;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string message = PlStudent.updateStudent(new DtoStudent(txbFirstName.Text, txbLastName.Text, Convert.ToInt32(txbTotalAbsence.Text), currentStudent.Id));
            MessageBox.Show(message);
            frmManageStudents frm = new frmManageStudents();
            frm.Show();
            this.Close();
        }
    }
}
