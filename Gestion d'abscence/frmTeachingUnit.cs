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
        private DataGridViewRow currentRow; 
        public frmTeachingUnit()
        {
            InitializeComponent();
        }

        private void frmTeachingUnit_Load(object sender, EventArgs e)
        {
            Ut.LoadUt();
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
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DtoUt utDelete = new DtoUt() { Id = currentRow.Index };
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
        }

        private void dgvUt_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnModifierUt.Visible = true;
            btnSupprimer.Visible = true;
            currentRow = dgvUt.Rows[e.RowIndex];
            lblCrudMessage.Visible = false;
        }
    }
}
