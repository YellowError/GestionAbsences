using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class DbAttendance
    {
        public static List<DbAttendance> attendancePerDate = new List<DbAttendance>();
        public static List<DbAttendance> AttendancePerDate
        {
            get { return attendancePerDate; }
            set { attendancePerDate = value; }
        }

        public DateTime Date { get; set; }

        public int IdUt { get; set; }

        public List<int> IdStudentsPresent { get; set; }

        public DbAttendance()
        {

        }

        public DbAttendance(DateTime date, int idUt, List<int> idStudentPresent)
        {
            this.Date = date;
            this.IdUt = idUt;
            this.IdStudentsPresent = idStudentPresent;
        }
    }
}
