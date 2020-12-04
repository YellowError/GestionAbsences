using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Ut
    {
        public static List<Ut> uts = new List<Ut>();
        public string Name { get; set; }
        public int Periodes { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public string Teacher { get; set; }
        public bool Decisive { get; set; }
        public int Id { get; set; }

        private static string[] utsName = {
            "Base réseau",
            "Initiation à la programmation",
            "Web base",
            "Anglais",
            "Initiation aux bases de données",
            "Principes algorithmique",
            "Comptabilité"
        };

        public Ut(string name, int periodes, DateTime startAt, DateTime endAt, string teacher, bool decisive)
        {
            this.Name = name;
            this.Periodes = periodes;
            this.StartAt = startAt;
            this.EndAt = endAt;
            this.Teacher = teacher;
            this.Decisive = decisive;
            if(uts.Count < 1)
            {
                this.Id = 1;
            }
            else
            {
                this.Id = uts[uts.Count - 1].Id + 1;
            }

        }

        public Ut() { }

        public static void LoadUt()
        {
            uts.Clear();
            uts.Add(new Ut(utsName[0], 50, new DateTime(2020, 10, 10), new DateTime(2020, 11, 24), "Daniel Delguste", true));
            uts.Add(new Ut(utsName[1], 60, new DateTime(2020, 11, 09), new DateTime(2020, 12, 12), "Daniel Delguste", false));
            uts.Add(new Ut(utsName[2], 70, new DateTime(2021, 02, 20), new DateTime(2021, 03, 20), "Daniel Delguste", true));
            uts.Add(new Ut(utsName[3], 80, new DateTime(2021, 03, 28), new DateTime(2021, 04, 05), "Daniel Delguste", false));
            uts.Add(new Ut(utsName[4], 90, new DateTime(2021, 03, 07), new DateTime(2021, 04, 29), "Daniel Delguste", false));
            uts.Add(new Ut(utsName[5], 110, new DateTime(2021, 04, 01), new DateTime(2021, 06, 12), "Daniel Delguste", true));
            uts.Add(new Ut(utsName[6], 145, new DateTime(2021, 04, 10), new DateTime(2021, 06, 18), "Daniel Delguste", true));

        }

    }
}
