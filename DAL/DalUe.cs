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
                lstDtoUt.Add(new DtoUt() { Name = ut.Name, Periodes = ut.Periodes, StartAt = ut.StartAt, EndAt = ut.EndAt, Decisive = ut.Decisive, Teacher = ut.Teacher, Id=ut.Id });
            }
            return lstDtoUt;
        }
        public static DtoUt getUtById(string name)
        {
            try
            {
                Ut ut = Ut.uts.Find(item => item.Name.ToLower().Contains(name.ToLower()));
                Console.WriteLine("value of ut is : {0}", ut);
                return new DtoUt() { Name = ut.Name, Periodes = ut.Periodes, StartAt = ut.StartAt, EndAt = ut.EndAt, Decisive = ut.Decisive, Teacher = ut.Teacher, Id = ut.Id };
            }
            catch (NullReferenceException)
            {
                return new DtoUt() { ExceptionMessage = "Not Found" };
            }
        }

        public static string deleteUt(DtoUt ut)
        {
            Ut.uts.RemoveAt(ut.Id);
            return "Remove done";
        }
    }
}
