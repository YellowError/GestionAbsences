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
    }
}
