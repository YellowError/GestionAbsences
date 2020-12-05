using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
using DTO;

namespace DAL
{
    public class DalUe
    {
        public static List<DtoUt> getUt()
        {
            //get all UT
            List<DtoUt> lstDtoUt = new List<DtoUt>();
            foreach (Ut ut in Ut.uts)
            {
                lstDtoUt.Add(new DtoUt() { Name = ut.Name, Periodes = ut.Periodes, StartAt = ut.StartAt, EndAt = ut.EndAt, Decisive = ut.Decisive, Teacher = ut.Teacher, Id=ut.Id, IdStudent=ut.IdStudents });
            }
            return lstDtoUt;
        }
        public static List<DtoUt> getUtById(string name)
        {
            try
            {
                List<Ut> uts = Ut.uts.FindAll(item => item.Name.ToLower().Contains(name.ToLower()));
                List<DtoUt> dtoUts = new List<DtoUt>();
                foreach (var ut in uts)
                {
                    dtoUts.Add(new DtoUt() { Name = ut.Name, Periodes = ut.Periodes, StartAt = ut.StartAt, EndAt = ut.EndAt, Decisive = ut.Decisive, Teacher = ut.Teacher, Id = ut.Id, IdStudent=ut.IdStudents });
                }
                return dtoUts;
            }
            catch (NullReferenceException)
            {
                List<DtoUt> fail = new List<DtoUt>();
                fail.Add(new DtoUt() { ExceptionMessage = "not found" });
                return fail;
            }
        }

        public static string deleteUt(DtoUt ut)
        {
            Ut.uts.RemoveAt(findIndex(ut));
            return "Remove " + ut.Name + " done";
        }

        private static int findIndex(DtoUt ut)
        {
            return Ut.uts.FindIndex(x => x.Name == ut.Name);
        }

        public static string updateUt(DtoUt ut)
        {
            foreach (Ut item in Ut.uts)
            {
                if(item.Id == ut.Id)
                {
                    item.Name = ut.Name;
                    item.Periodes = ut.Periodes;
                    item.StartAt = ut.StartAt;
                    item.EndAt = ut.EndAt;
                    item.Decisive = ut.Decisive;
                    item.Teacher = ut.Teacher;
                }
            }

            return "Update done";
        }

        public static string CreateUt(DtoUt ut)
        {
            Ut.uts.Add(new Ut(ut.Name, ut.Periodes, ut.StartAt, ut.EndAt, ut.Teacher, ut.Decisive));
            return "Sucessful";
        }

        public static string addStudentInUt(int id, DtoUt utSelected)
        {
            int index = Ut.uts.FindIndex(x => x.Id == utSelected.Id);
            Ut.uts[index].IdStudents.Add(id);
            return "Adding student successful";
        }

        public static string deleteStudentInUeById(int id, DtoUt utSelected)
        {
            int indexOfUtSelected = Ut.uts.FindIndex(ut => ut.Id == utSelected.Id);
            int index = Ut.uts[indexOfUtSelected].IdStudents.FindIndex(i => i == id);
            Ut.uts[indexOfUtSelected].IdStudents.RemoveAt(index);
            return "Delete Done";
        }
    }
}
