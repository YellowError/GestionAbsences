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

        public static DtoUt getUtById(string name)
        {
            return DalUe.getUtById(name);
        }

        public static string deleteUt(DtoUt ut)
        {
            return DalUe.deleteUt(ut);
        }
    }
}
