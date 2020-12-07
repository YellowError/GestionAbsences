using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB;
using PL;
using DTO;

namespace PlTest
{
    [TestClass]
    public class PlTestUnitaire
    {
        [TestMethod]
        public void getUtById()
        {
            //Je vais rentrer un id dans la methode et il va aller me rechercher l'unité d'enseignement correspondante dans la base de données
            //La méthode va me retourner un objet de type DtoUt (dto unit teaching)
            //Je testerais enfin si l'id de l'ut recue est égale à celle envoyée.

            //Arranger////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////Arranger// 

            //Cette méthode popule ma db des unités d'enseignement.
            Ut.LoadUt();
            int id = 2;

            //AGIR///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////AGIR//

            //Cette méthode va faire passer un id de couche en couche pour pouvoir me retourné un objet dto contenant mon unité d'enseignement.
            DtoUt utFound = PlUt.getUtById(id);

            //AUDIT///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////AUDIT//

            //Je compare enfin pour voir si l'id de mon unité d'enseignement est bien le même que celui passé en paramètre.
            Assert.AreEqual(id, utFound.Id);
        }

        [TestMethod]

        public void createAttendance()
        {
            //Cette méthode à la particularité de créer une présence si elle n'existe pas déjà ou de modifier une présence si elle existe déjà.
            //Je vais passer un objet de type DtoAttendance contenant les informations des présences.
            //Dans cette version du test la méthode créera une nouvelle objet présence car il n'en existera pas déjà un dans la liste de présence
            //La méthode renvoie un string spécifique à la création de la présence, que l'on testera.

            //ARRANGER//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////ARRANGER//

            //Je popule mes ue et mes etudiants car tous étant lié, je suis obligé.
            Ut.LoadUt();
            DbStudents.LoadStudents();

            //Je crée les variables nécessaire à la création d'un attendance
            DateTime date = new DateTime(2020, 12, 5);
            int idUnitTeaching = 1;
            List<int> idStudents = new List<int>(){ 1, 4, 6 };

            //J'instancie mon objet attendance à l'aide de mes variables définies précédement.
            DtoAttendance attendance = new DtoAttendance(date, idUnitTeaching, idStudents);

            //AGIR///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////AGIR//

            //Je passe un paramètre de ma méthode de création de présence l'objet attendance créé précédement pour créer une nouvelle présence dans ma database.
            //Je récupère le message renvoyé par la base de données me spécifiant que c'est une création et non une modification.
            string creation = PlAttendance.createAttendance(attendance);

            //AUDIT///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////AUDIT//

            //Je test si le message recu est bien celui attendu pour la creation d'une présence(cela me confirme qu'il est bien passé par la boucle de création et non de modification).
            Assert.AreEqual("Presence confirmed", creation);

        }

        [TestMethod]

        public void modifyAttendance()
        {
            //Cette méthode à la particularité de créer une présence si elle n'existe pas déjà ou de modifier une présence si elle existe déjà.
            //Je vais passer un objet de type DtoAttendance contenant les informations des présences.
            //Dans cette version du test la méthode modifiera la présence car elle existera déjà dans la base de données.
            //La méthode renvoie un string spécifique à la modification de la présence, que l'on testera.

            //ARRANGER//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////ARRANGER//

            //Je popule mes ue et mes etudiants car tous étant lié, je suis obligé.
            Ut.LoadUt();
            DbStudents.LoadStudents();

            //Je crée les variables nécessaire à la création d'un attendance
            DateTime date = new DateTime(2020, 12, 5);
            int idUnitTeaching = 2;
            List<int> idStudents = new List<int>() { 1, 4, 6 };

            //J'instancie mon objet attendance à l'aide de mes variables définies précédement.
            DtoAttendance attendance = new DtoAttendance(date, idUnitTeaching, idStudents);

            //Je crée mes présences dans la base de données.
            PlAttendance.createAttendance(attendance);

            //Je modifie la liste des présences
            idStudents.Add(2);

            DtoAttendance sameAttendanceWithDifferentPresence = new DtoAttendance(date, idUnitTeaching, idStudents);

            //AGIR//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////AGIR//

            //Je passe un paramètre de ma méthode l'objet attendance qui à la même date, la même unité d'enseignement mais pas la même list de présence.
            //Je récupère le message renvoyé par la base de données me spécifiant que c'est une modification de présences déjà existante.
            string modify = PlAttendance.createAttendance(sameAttendanceWithDifferentPresence);

            //AUDIT/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////AUDIT//

            //Je test si le message recu est bien celui attendu pour la modification d'une présence(cela me confirme qu'il est bien passé par la boucle de modification et non de création).
            Assert.AreEqual("Presence Modified", modify);
        }
    }
}
