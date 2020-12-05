using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PL;
using DTO;

namespace Gestion_d_abscence
{
    public partial class frmManageStudents : Form
    {
        DataGridViewRow currentRow;
        public frmManageStudents()
        {
            InitializeComponent();
        }

        private void frmManageStudents_Load(object sender, EventArgs e)
        {
            PlStudent.printAllStudents(dgvStudents);
        }

        private void txbSearchBar_TextChanged(object sender, EventArgs e)
        {
            PlStudent.printSearchResult(dgvStudents, txbSearchBar.Text, lblNotFound);
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            string message = PlStudent.deleteStudentById(Convert.ToInt32(currentRow.Cells[3].Value));
            MessageBox.Show(message);
            PlStudent.printAllStudents(dgvStudents);
        }

        private void dgvStudents_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentRow = dgvStudents.Rows[e.RowIndex];
            btnDeleteStudent.Visible = true;
            btnModifierStudent.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.Show();
            this.Close();
        }

        private void btnModifierStudent_Click(object sender, EventArgs e)
        {
            
            frmModifyStudent frm = new frmModifyStudent();
            frm.currentStudent = new DtoStudent(currentRow.Cells[0].Value.ToString(), currentRow.Cells[1].Value.ToString(), Convert.ToInt32(currentRow.Cells[2].Value), Convert.ToInt32(currentRow.Cells[3].Value));
            frm.Show();
            this.Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmAddStudent frm = new frmAddStudent();
            frm.Show();
            this.Close();
        }
    }
}
