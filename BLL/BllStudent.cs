﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BllStudent
    {
        public static List<DtoStudent> getStudentsByIds(List<int> idStudent)
        {
            return DalStudent.getStudentsByIds(idStudent);
        }
    }
}
