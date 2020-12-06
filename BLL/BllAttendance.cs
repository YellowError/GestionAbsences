using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BllAttendance
    {
        public static DtoAttendance getAllUtPerDay(DateTime date, int idUt)
        {
            return DalAttendance.getAllUtPerDay(date, idUt);
        }

        public static string createAttendance(DtoAttendance attendance)
        {
            return DalAttendance.createAttendance(attendance);
        }
    }
}
