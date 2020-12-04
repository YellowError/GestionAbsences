using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
