using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoStudent
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int TotalAbsence { get; set; }

        public int Id { get; set; }

        public DtoStudent() { }

        public DtoStudent(string fName, string LName, int totalAbs, int id)
        {
            this.FirstName = fName;
            this.LastName = LName;
            this.TotalAbsence = totalAbs;
            this.Id = id;
            
        }
    }
}
