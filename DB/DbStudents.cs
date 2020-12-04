using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class DbStudents
    {
        public static List<DbStudents> students = new List<DbStudents>();
        public static List<DbStudents> Students
        {
            get { return students; }
            set { students = value; }
        }


        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int TotalAbsence { get; set; }



        public DbStudents() { }

        public DbStudents(string lastName, string firstName)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.TotalAbsence = 0;
 
            if (Students.Count < 1)
            {
                this.Id = 1;
            }
            else
            {
                this.Id = Students[Students.Count - 1].Id + 1;
            }
        }

        public static string addStudent(DbStudents student)
        {
            students.Add(student);
            return "Student created";
        }

        public static void LoadStudents()
        {
            Students.Clear();
            Students.Add(new DbStudents("jean", "Castex"));
            Students.Add(new DbStudents("michael", "Altof"));
            Students.Add(new DbStudents("julien", "Iannello"));
            Students.Add(new DbStudents("Guiseppe", "Fileccia"));
            Students.Add(new DbStudents("Luigi", "Chiappini"));
            Students.Add(new DbStudents("Kader", "Arouk"));
            Students.Add(new DbStudents("Wilfried", "Tsonga"));
        }

    }
}
