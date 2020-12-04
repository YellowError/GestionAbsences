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
        public frmShowStudentsByUe()
        {
            InitializeComponent();
        }

        private void frmShowStudentsByUe_Load(object sender, EventArgs e)
        {
           
            List<DtoStudent> students = PlStudent.getStudentsByIds(currentUt.IdStudent);

            foreach (DtoStudent student in students)
            {
                dgvStudentsByUt.Rows.Add(student.FirstName, student.LastName, student.TotalAbsence);
            }
        }
    }
}
