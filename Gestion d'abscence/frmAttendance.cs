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
    public partial class frmAttendance : Form
    {
        public int utSelected;
        public frmAttendance()
        {
            InitializeComponent();
        }

        private void frmAttendance_Load(object sender, EventArgs e)
        {
            List<DtoUt> uts = PlUt.getAllUt();
            foreach (DtoUt ut in uts)
            {
                cbTeachingUnit.Items.Add(ut.Id + " " + ut.Name);
            }
            
        }

        private void cbTeachingUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cbTeachingUnit.SelectedItem.ToString();
            string[] temp = selected.Split(' ');
            utSelected = Convert.ToInt32(temp[0]);
            btnFindAttendance.Visible = true;
        }

        private void btnFindAttendance_Click(object sender, EventArgs e)
        {
            dgvStudents.Rows.Clear();
            if(cbTeachingUnit.SelectedIndex != -1)
            {
                DateTime date = dtpSelectDateOfPresence.Value;
                DtoAttendance utAttendances = PlAttendance.getAllUtPerDay(date, utSelected);
                DtoUt utFound = PlUt.getUtById(utAttendances.IdUt);
                List<DtoStudent> students = PlStudent.getStudentsByIds(utFound.IdStudent);
                foreach (DtoStudent student in students)
                {
                    bool present = utAttendances.IdStudentsPresent.Exists(x => x == student.Id);

                    dgvStudents.Rows.Add(student.Id, student.FirstName, student.LastName, present);
                }
            }
            btnFindAttendance.Visible = false;
        }

        private void dgvStudents_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //btnConfirmPresence.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.Show();
            this.Close();
        }

        private void btnConfirmPresence_Click(object sender, EventArgs e)
        {
            if(dgvStudents.Rows.Count > 0)
            {
                List<int> idStudentPresent = new List<int>();
                foreach (DataGridViewRow row in dgvStudents.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[3].Value.ToString()))
                    {
                        idStudentPresent.Add(Convert.ToInt32(row.Cells[0].Value));
                    }
                }
                string message = PlAttendance.createAttendance(new DtoAttendance(dtpSelectDateOfPresence.Value.Date, utSelected, idStudentPresent));
                MessageBox.Show(message);
                dgvStudents.Rows.Clear();
                cbTeachingUnit.Text = String.Empty;
                btnConfirmPresence.Visible = false;
            } 
        }

        private void dgvStudents_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dgvStudents_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                btnConfirmPresence.Visible = true;
            }
        }
    }
}
