using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB;
using DTO;
using PL;

namespace Gestion_d_abscence
{
    public partial class frmTeachingUnit : Form
    {
        public DataGridViewRow currentRow; 
        public frmTeachingUnit()
        {
            InitializeComponent();
        }

        private void frmTeachingUnit_Load(object sender, EventArgs e)
        {
            List<DtoUt> uts = PlUt.getAllUt();
            foreach (DtoUt ut in uts)
            {
                dgvUt.Rows.Add(ut.Name, ut.Periodes, ut.StartAt, ut.EndAt, ut.Decisive, ut.Teacher);
            }
        }

        private void dgvUt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txbFindById_TextChanged_1(object sender, EventArgs e)
        {
            PlUt.printUt(dgvUt, txbFindById, lblNotFound);
            btnModifierUt.Visible = false;
            btnSupprimer.Visible = false;
            btnShowStudents.Visible = false;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DtoUt utDelete = new DtoUt() { Name = currentRow.Cells[0].Value.ToString() };
            string message = PlUt.deleteUt(utDelete);
            dgvUt.Rows.Clear();
            List<DtoUt> uts = PlUt.getAllUt();
            foreach (DtoUt ut in uts)
            {
                dgvUt.Rows.Add(ut.Name, ut.Periodes, ut.StartAt, ut.EndAt, ut.Decisive, ut.Teacher);
            }
            lblCrudMessage.Text = message;
            lblCrudMessage.Visible = true;
            btnModifierUt.Visible = false;
            btnSupprimer.Visible = false;
            btnShowStudents.Visible = false;
        }

        private void dgvUt_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                btnModifierUt.Visible = true;
                btnSupprimer.Visible = true;
                btnShowStudents.Visible = true;
                currentRow = dgvUt.Rows[e.RowIndex];
                lblCrudMessage.Visible = false;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out Of Range");
            }
                
            
            
        }

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            frmShowStudentsByUe frm = new frmShowStudentsByUe();
            frm.currentUt = getCurrentUtInCell();
            frm.Show();
            this.Close();
        }

        private void frmTeachingUnit_MouseClick(object sender, MouseEventArgs e)
        {
            btnModifierUt.Visible = false;
            btnSupprimer.Visible = false;
            btnShowStudents.Visible = false;
        }

        private void btnModifierUt_Click(object sender, EventArgs e)
        {
            frmModifyUt frm = new frmModifyUt();
            frm.currentUt = getCurrentUtInCell();
            frm.Show();
            this.Close();
        }


        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            AddUnit frm = new AddUnit();
            frm.Show();
            this.Close();
        }

        private DtoUt getCurrentUtInCell()
        {
            string text = currentRow.Cells[0].Value.ToString();
            List<DtoUt> lst = PlUt.getUtById(text);
            return lst[0];
        }

        private void txbFindById_MouseClick_1(object sender, MouseEventArgs e)
        {
            btnModifierUt.Visible = false;
            btnShowStudents.Visible = false;
            btnSupprimer.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.Show();
            this.Close();
        }
    }
}
