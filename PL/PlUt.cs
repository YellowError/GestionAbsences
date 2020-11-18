using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BLL;
using System.Windows.Forms;

namespace PL
{
    public class PlUt
    {
        
        public static List<DtoUt> getAllUt()
        {
            return BllUt.getAllUt();
        }

        public static DtoUt getUtById(string name)
        {
            return BllUt.getUtById(name);
        }

        public static void printUt(DataGridView dgvUt, TextBox txbSearch, Label lblNotFound)
        {
            if (txbSearch.Text.Length > 2)
            {
                dgvUt.Rows.Clear();

                DtoUt ut = PlUt.getUtById(txbSearch.Text);
                if (ut.ExceptionMessage != null)
                {
                    lblNotFound.Text = ut.ExceptionMessage;
                    lblNotFound.Visible = true;
                }
                else
                {
                    lblNotFound.Visible = false;
                    dgvUt.Rows.Add(ut.Name, ut.Periodes, ut.StartAt, ut.EndAt, ut.Decisive, ut.Teacher);
                }

            }
            else if (txbSearch.Text.Length == 0)
            {
                lblNotFound.Visible = false;
                dgvUt.Rows.Clear();
                List<DtoUt> uts = PlUt.getAllUt();
                foreach (DtoUt ut in uts)
                {
                    dgvUt.Rows.Add(ut.Name, ut.Periodes, ut.StartAt, ut.EndAt, ut.Decisive, ut.Teacher);
                }
            }
        }

        public static string deleteUt(DtoUt ut)
        {
            return BllUt.deleteUt(ut);
        }
    }
}
