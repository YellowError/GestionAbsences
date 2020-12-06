using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BLL;

namespace PL
{
    public class PlAttendance
    {
        public static DtoAttendance getAllUtPerDay(DateTime date, int idUt)
        {
            return BllAttendance.getAllUtPerDay(date, idUt);
        }

        public static string createAttendance(DtoAttendance attendance)
        {
            return BllAttendance.createAttendance(attendance);
        }
    }
}
