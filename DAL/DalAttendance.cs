using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DB;

namespace DAL
{
    public class DalAttendance
    {
        public static DtoAttendance getAllUtPerDay(DateTime date, int idUt)
        {
            Ut ut = Ut.uts.Find(x => x.Id == idUt);
            DbAttendance attendanceFound = DbAttendance.attendancePerDate.Find(x => x.Date.Date == date.Date && ut.Id == x.IdUt);

            if(attendanceFound != null)
            {
                return new DtoAttendance(attendanceFound.Date, ut.Id, attendanceFound.IdStudentsPresent);
            }
            else
            {
                return new DtoAttendance(date, ut.Id, new List<int>());
            }
        }

        public static string createAttendance(DtoAttendance attendance)
        {
            int attIsExist = DbAttendance.AttendancePerDate.FindIndex(x => x.Date == attendance.Date && x.IdUt == attendance.IdUt);
            if(attIsExist != -1)
            {
                DbAttendance oldAttendance = DbAttendance.AttendancePerDate.Find(x => x.Date == attendance.Date && x.IdUt == attendance.IdUt);
                DbAttendance.AttendancePerDate.RemoveAt(attIsExist);
                DbAttendance.AttendancePerDate.Add(new DbAttendance(attendance.Date, attendance.IdUt, attendance.IdStudentsPresent));
                modifyAbscenseToStudent(oldAttendance, attendance.IdStudentsPresent, attendance.IdUt);
                return "Presence Modified";
            }
            else
            {
                DbAttendance.AttendancePerDate.Add(new DbAttendance(attendance.Date, attendance.IdUt, attendance.IdStudentsPresent));
                addAbscenseToStudent(attendance.IdUt, attendance.IdStudentsPresent);
                return "Presence confirmed";
            }
            
        }

        private static void addAbscenseToStudent(int idUt, List<int> idStudents)
        {
            DtoUt ut = DalUe.getUtById(idUt);
            List<int> idStudentsAbsent = new List<int>();
            foreach (int idStudent in ut.IdStudent)
            {
                bool isIn = false;
                foreach (int idPresent in idStudents)
                {
                    if(idStudent == idPresent)
                    {
                        isIn = true;
                    }
                }
                if (!isIn)
                {
                    idStudentsAbsent.Add(idStudent);
                }
            }

            List<DtoStudent> studentsAbsent = DalStudent.getStudentsByIds(idStudentsAbsent);

            DalStudent.addAbsence(studentsAbsent);
        }

        private static void modifyAbscenseToStudent(DbAttendance oldAttendance, List<int> newIdStudentPrensent, int idUt)
        {
            List<int> idStudentDecreaseAbsence = new List<int>();
            List<int> idStudentIncreaseAbsence = new List<int>();

            foreach (int newId in newIdStudentPrensent)
            {
                bool isNew = true;
                foreach (int oldId in oldAttendance.IdStudentsPresent)
                {
                    if(newId == oldId)
                    {
                        isNew = false;
                    }
                }
                if (isNew)
                {
                    idStudentDecreaseAbsence.Add(newId);
                }
            }

            foreach (int oldId in oldAttendance.IdStudentsPresent)
            {
                bool isOut = true;
                foreach (int newId in newIdStudentPrensent)
                {
                    if (newId == oldId)
                    {
                        isOut = false;
                    }
                }
                if (isOut)
                {
                    idStudentIncreaseAbsence.Add(oldId);
                }
            }

            foreach ( DbStudents Student in DbStudents.Students)
            {
                foreach (int idToDecrease in idStudentDecreaseAbsence)
                {
                    if(Student.Id == idToDecrease)
                    {
                        Student.TotalAbsence -= 1;
                    }
                }

                foreach (int idToIncrease in idStudentIncreaseAbsence)
                {
                    if(Student.Id == idToIncrease)
                    {
                        Student.TotalAbsence += 1;
                    }
                }
            }
        }
    }
}
