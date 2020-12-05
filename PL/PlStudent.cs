using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace PL
{
    public class PlStudent
    {
        public static List<DtoStudent> getStudentsByIds(List<int> idStudent)
        {
            return BllStudent.getStudentsByIds(idStudent);
        }

        public static List<DtoStudent> getAllStudents()
        {
            return BllStudent.getAllStudents();
        }

        public static List<DtoStudent> getStudentsByString(string text)
        {
            return BllStudent.getStudentsByString(text);
        }


        public static void printSearchResult(DataGridView dgv, string search, Label lblNotFound)
        {
            if (search.Length > 2)
            {
                dgv.Rows.Clear();

                List<DtoStudent> students = PlStudent.getStudentsByString(search);
                if (students.Count == 0)
                {
                    lblNotFound.Text = "not found";
                    lblNotFound.Visible = true;
                }
                else
                {
                    lblNotFound.Visible = false;
                    foreach (DtoStudent item in students)
                    {
                        dgv.Rows.Add(item.FirstName, item.LastName, item.TotalAbsence, item.Id);
                    }
                }

            }
            else if (search.Length == 0)
            {
                lblNotFound.Visible = false;
                dgv.Rows.Clear();
                List<DtoStudent> students = PlStudent.getAllStudents();
                foreach (DtoStudent student in students)
                {
                    dgv.Rows.Add(student.FirstName, student.LastName, student.TotalAbsence, student.Id);
                }
            }
        }
        
        public static string deleteStudentById(int id)
        {
            return BllStudent.deleteStudentById(id);
        }

        public static void printAllStudents(DataGridView dgv)
        {
            dgv.Rows.Clear();
            List<DtoStudent> students = PlStudent.getAllStudents();

            foreach (DtoStudent student in students)
            {
                dgv.Rows.Add(student.FirstName, student.LastName, student.TotalAbsence, student.Id);
            }
        }

        public static string updateStudent(DtoStudent student)
        {
            return BllStudent.updateStudent(student);
        }

        public static string createStudent(DtoStudent student)
        {
            return BllStudent.createStudent(student);
        }
    }
}
