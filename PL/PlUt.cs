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

        public static List<DtoUt> getUtById(string name)
        {
            return BllUt.getUtById(name);
        }

        public static void printUt(DataGridView dgvUt, TextBox txbSearch, Label lblNotFound)
        {
            if (txbSearch.Text.Length > 2)
            {
                dgvUt.Rows.Clear();

                List<DtoUt> ut = PlUt.getUtById(txbSearch.Text);
                if (ut.Count == 0)
                {
                    lblNotFound.Text = "not found" ;
                    lblNotFound.Visible = true;
                }
                else
                {
                    lblNotFound.Visible = false;
                    foreach(DtoUt item in ut)
                    {
                        dgvUt.Rows.Add(item.Name, item.Periodes, item.StartAt, item.EndAt, item.Decisive, item.Teacher);
                    }
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

        public static string PlUpdateUt(DtoUt ut)
        {
            return BllUt.updateUt(ut);
        }

        public static string PlCreateUt(DtoUt ut)
        {
            return BllUt.CreateUt(ut);
        }

        public static string deleteStudentInUeById(int id, DtoUt utSelected)
        {
            return BllUt.deleteStudentInUeById(id, utSelected);
        }

        public static string addStudentinUt(int id, DtoUt utSelected)
        {
            return BllUt.addStudentInUt(id, utSelected);
        }
    }
}
