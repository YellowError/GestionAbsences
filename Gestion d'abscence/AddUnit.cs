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
    public partial class AddUnit : Form
    {
        public AddUnit()
        {
            InitializeComponent();
        }

        private void btnCreateUt_Click(object sender, EventArgs e)
        {
            DateTime start = dtpStartOn.Value.Date;
            DateTime end = dtpEndOn.Value.Date;

            DtoUt utCreated= new DtoUt() { Name = txbDenomination.Text, Periodes = Convert.ToInt32(txbNumberOfPeriode.Text), StartAt = start, EndAt = end, Decisive = chbDecisive.Checked, Teacher = txbTeacher.Text };

            string sucess = PlUt.PlCreateUt(utCreated);
            MessageBox.Show(sucess);
            frmTeachingUnit frm = new frmTeachingUnit();
            frm.Show();
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmTeachingUnit frm = new frmTeachingUnit();
            frm.Show();
            this.Close();
        }
    }
}
