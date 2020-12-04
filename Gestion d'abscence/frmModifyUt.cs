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
    public partial class frmModifyUt : Form
    {
        public DtoUt currentUt;
        public frmModifyUt()
        {
            InitializeComponent();
        }

        private void frmModifyUt_Load(object sender, EventArgs e)
        {
            lblTitle.Text = currentUt.Name;
            txbDenomination.Text = currentUt.Name;
            txbNumberOfPeriode.Text = currentUt.Periodes.ToString();
            txbStartOn.Text = currentUt.StartAt.ToString();
            txbEndOn.Text = currentUt.EndAt.ToString();
            if (currentUt.Decisive) chbDecisive.Checked = true;
            txbTeacher.Text = currentUt.Teacher;
            btnModify.Visible = false;
            txbDenomination.Focus();
        }

        private void txbDenomination_TextChanged(object sender, EventArgs e)
        {
            btnModify.Visible = true;
        }

        private void txbNumberOfPeriode_TextChanged(object sender, EventArgs e)
        {
            btnModify.Visible = true;
        }

        private void txbStartOn_TextChanged(object sender, EventArgs e)
        {
            btnModify.Visible = true;
        }

        private void txbEndOn_TextChanged(object sender, EventArgs e)
        {
            btnModify.Visible = true;
        }

        private void txbTeacher_TextChanged(object sender, EventArgs e)
        {
            btnModify.Visible = true;
        }

        private void chbDecisive_CheckedChanged(object sender, EventArgs e)
        {
            btnModify.Visible = true;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            DateTime start = Convert.ToDateTime(txbStartOn.Text);
            DateTime end = Convert.ToDateTime(txbEndOn.Text);

            DtoUt utUpdated = new DtoUt() { Id = currentUt.Id, Name = txbDenomination.Text, Periodes = Convert.ToInt32(txbNumberOfPeriode.Text), StartAt = start, EndAt = end, Decisive = chbDecisive.Checked, Teacher = txbTeacher.Text };

            string done = PlUt.PlUpdateUt(utUpdated);
            MessageBox.Show(done);
            frmTeachingUnit frm = new frmTeachingUnit();
            frm.Show();
            this.Close();

        }

        private void frmModifyUt_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmTeachingUnit frm = new frmTeachingUnit();
            frm.Show();
            this.Close();
        }
    }
}
