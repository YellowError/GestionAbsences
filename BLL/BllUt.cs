using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BllUt
    {
        public static List<DtoUt> getAllUt()
        {
            return DalUe.getUt();
            //logic

        }

        public static List<DtoUt> getUtById(string name)
        {
            return DalUe.getUtById(name);
        }

        public static string deleteUt(DtoUt ut)
        {
            return DalUe.deleteUt(ut);
        }

        public static string updateUt(DtoUt ut)
        {
            return DalUe.updateUt(ut);
        }

        public static string CreateUt(DtoUt ut)
        {
            return DalUe.CreateUt(ut);
        }
    }
}
