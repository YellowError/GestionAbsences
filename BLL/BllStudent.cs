using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BllStudent
    {
        public static List<DtoStudent> getStudentsByIds(List<int> idStudent)
        {
            return DalStudent.getStudentsByIds(idStudent);
        }

        public static List<DtoStudent> getAllStudents()
        {
            return DalStudent.getAllSudents();
        }

        public static List<DtoStudent> getStudentsByString(string text)
        {
            return DalStudent.getStudentsByString(text);
        }

        public static string deleteStudentById(int id)
        {
            return DalStudent.deleteStudentById(id);
        }

        public static string updateStudent(DtoStudent student)
        {
            return DalStudent.updateStudent(student);
        }

        public static string createStudent(DtoStudent student)
        {
            return DalStudent.createStudent(student);
        }

    }
}
