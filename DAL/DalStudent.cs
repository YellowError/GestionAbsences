using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DB;

namespace DAL
{
    public class DalStudent
    {
        public static List<DtoStudent> getStudentsByIds(List<int> idStudent)
        {
            List<DtoStudent> students = new List<DtoStudent>();
            foreach (int item in idStudent)
            {
                DbStudents student = DbStudents.Students.Find(x => x.Id == item);

                if(student != null)
                {
                    students.Add(new DtoStudent(student.FirstName, student.LastName, student.TotalAbsence, student.Id));

                }

            }

            return students;
        }

        public static List<DtoStudent> getAllSudents()
        {
            List<DtoStudent> listStudents = new List<DtoStudent>();
            foreach (DbStudents student in DbStudents.Students)
            {
                listStudents.Add(new DtoStudent(student.FirstName, student.LastName, student.TotalAbsence, student.Id));
            }

            return listStudents;
        }

        public static List<DtoStudent> getStudentsByString(string text)
        {
            List<DbStudents> studentsFound = DbStudents.Students.FindAll(student => student.FirstName.ToLower().Contains(text.ToLower()) || student.LastName.ToLower().Contains(text.ToLower()));
            List<DtoStudent> studentsResults = new List<DtoStudent>();
            foreach (DbStudents student in studentsFound)
            {
                studentsResults.Add(new DtoStudent(student.FirstName, student.LastName, student.TotalAbsence, student.Id));
            }
            return studentsResults;
        }

        public static string deleteStudentById(int id)
        {
            DbStudents.Students.RemoveAt(DbStudents.Students.FindIndex(x => x.Id == id));

            foreach (Ut ut in Ut.uts)
            {
                int index = ut.IdStudents.FindIndex(x => x == id);
                if(index != -1)
                {
                    ut.IdStudents.RemoveAt(index);
                }
                
            }
            return "Student removed";
        }

        public static string updateStudent(DtoStudent student)
        {
            int index = DbStudents.Students.FindIndex(stud => stud.Id == student.Id);
            DbStudents.Students[index].FirstName = student.FirstName;
            DbStudents.Students[index].LastName = student.LastName;
            DbStudents.Students[index].TotalAbsence = student.TotalAbsence;
            return "Student updated";
        }

        public static string createStudent(DtoStudent student)
        {
            DbStudents.Students.Add(new DbStudents(student.LastName, student.FirstName, Convert.ToInt32(student.TotalAbsence)));
            return "Student added";
        }

        public static void addAbsence(List<DtoStudent> students)
        {
            foreach (DtoStudent student in students)
            {
                int index = DbStudents.Students.FindIndex(x => x.Id == student.Id);
                DbStudents.Students[index].TotalAbsence += 1;
            }
        }


    }
}
