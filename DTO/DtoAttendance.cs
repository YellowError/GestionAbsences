using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DB;

namespace DTO
{
    public class DtoAttendance
    {
        public DateTime Date { get; set; }
        public int IdUt { get; set; }

        public List<int> IdStudentsPresent { get; set; }

        public DtoAttendance()
        {

        }

        public DtoAttendance(DateTime date, int ut, List<int> idStudentPresent)
        {
            this.Date = date;
            this.IdUt = ut;
            this.IdStudentsPresent = idStudentPresent;
        }
    }
}
