using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoUt
    {
        public string Name { get; set; }
        public int Periodes { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public string Teacher { get; set; }
        public bool Decisive { get; set; }
        public int Id { get; set; }

        public List<int> IdStudent { get; set; }

        public string ExceptionMessage { get; set; }

        public DtoUt(string name, int periodes, DateTime startAt, DateTime endAt, string teacher, bool decisive, int id, List<int> idStud)
        {
            this.Name = name;
            this.Periodes = periodes;
            this.StartAt = startAt;
            this.EndAt = endAt;
            this.Teacher = teacher;
            this.Decisive = decisive;
            this.Id = id;
            this.IdStudent = idStud;
        }

        public DtoUt(string exceptionMessage)
        {
            this.ExceptionMessage = exceptionMessage;
        }

        public DtoUt() {  }
    }
}
