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
    public partial class frmShowStudentsByUe : Form
    {
        public DtoUt currentUt;
        public DataGridViewRow currentRow;
        private int idStudentSelected;
        List<DtoStudent> students;
        public frmShowStudentsByUe()
        {
            InitializeComponent();
        }

        private void populateCbStudents()
        {
            cbAddStudentInUt.Items.Clear();
            List<DtoStudent> allStudents = PlStudent.getAllStudents();
            List<DtoStudent> studentsInDgv = PlStudent.getStudentsByIds(currentUt.IdStudent);
            foreach (DtoStudent student in allStudents)
            {
                bool isAlreadyInDgv = false;
                foreach (DtoStudent studInDgv in studentsInDgv)
                {
                    if(student.Id == studInDgv.Id)
                    {
                        isAlreadyInDgv = true;
                    }
                }
                if (!isAlreadyInDgv)
                {
                    cbAddStudentInUt.Items.Add(student.FirstName + " " + student.LastName);
                }
            }
        }

        private void populateDgvStudent()
        {
            students = PlStudent.getStudentsByIds(currentUt.IdStudent);

            foreach (DtoStudent student in students)
            {
                dgvStudentsByUt.Rows.Add(student.Id, student.FirstName, student.LastName, student.TotalAbsence);
            }
        }

        private void frmShowStudentsByUe_Load(object sender, EventArgs e)
        {
            populateCbStudents();
            populateDgvStudent();
            lblTitle.Text = currentUt.Name;
           
        }

        private void dgvStudentsByUt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvStudentsByUt_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                btnDeleteStudentByUe.Visible = true;
                idStudentSelected = Convert.ToInt32(dgvStudentsByUt.Rows[e.RowIndex].Cells[0].Value);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("out of range");
            }
            
           

        }

        private void btnDeleteStudentByUe_Click(object sender, EventArgs e)
        {
            string message = PlUt.deleteStudentInUeById(idStudentSelected, currentUt);
            MessageBox.Show(message);

            dgvStudentsByUt.Rows.Clear();
            students = PlStudent.getStudentsByIds(currentUt.IdStudent);

            foreach (DtoStudent student in students)
            {
                dgvStudentsByUt.Rows.Add(student.Id, student.FirstName, student.LastName, student.TotalAbsence);
            }
            btnDeleteStudentByUe.Visible = false;
            populateCbStudents();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmTeachingUnit frm = new frmTeachingUnit();
            frm.Show();
            this.Close();
        }

        private void btnAddStudentByUe_Click(object sender, EventArgs e)
        {
            string cbStudentSelected = cbAddStudentInUt.SelectedItem.ToString();
            string[] valueSelected = new string[2];
            valueSelected = cbStudentSelected.Split(' ');

            List<DtoStudent> allStudents = PlStudent.getAllStudents();
            DtoStudent SelectedStudent = allStudents.Find(student => student.FirstName == valueSelected[0] && student.LastName == valueSelected[1]);
            string message = PlUt.addStudentinUt(SelectedStudent.Id, currentUt);
            MessageBox.Show(message);

            cbAddStudentInUt.Text = "";
            btnAddStudentByUe.Visible = false;
            dgvStudentsByUt.Rows.Clear();
            populateDgvStudent();
            populateCbStudents();
        }

        private void cbAddStudentInUt_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddStudentByUe.Visible = true;
        }

        private void cbAddStudentInUt_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbAddStudentInUt.Text == "") btnAddStudentByUe.Visible = false;
        }

        private void cbAddStudentInUt_TextChanged(object sender, EventArgs e)
        {
            //List<string> students = cbAddStudentInUt.Items.Cast<string>().ToList();
            //List<string[]> studentsSplit = new List<string[]>();
            //string
            //foreach (string student in students)
            //{
            //    string[] name = student.Split(' ');
            //    studentsSplit.Add(name);
            //}
            //studentsSplit.Find(student => student[0] == "lol");

            if (cbAddStudentInUt.Text == "") btnAddStudentByUe.Visible = false;
        }

        private void cbAddStudentInUt_MouseClick(object sender, MouseEventArgs e)
        {
            btnDeleteStudentByUe.Visible = false;
        }
    }
}
