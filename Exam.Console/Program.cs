using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.Domain.Entities;
using Exam.Service;

namespace Exam.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Departement D = new Departement()
            {
                CodeDepartement = 1,
                NomDepartement = Dep.TIC
            };
            Enseignant Ens1 = new Enseignant()
            {
                Id = 1,
                Mail = "enseignant1@esprit.tn",
                Nom = "Enseignant",
                Prenom = "dotNet",
                Telephone = 521251,
                DateDePriseDeFonction = new DateTime(2015, 09, 01),
                Grade = "Professeur",
                Salaire = 2000,
                DepartementFk = 1
            };
            Enseignant Ens2 = new Enseignant()
            {
                Id = 2,
                Mail = "EnseignantGraphe@esprit.tn",
                Nom = "Enseignant",
                Prenom = "Graphes",
                Telephone = 2235461,
                DateDePriseDeFonction = new DateTime(2018,09,01),
                Grade = "Professeur",
                Salaire = 2100,
                DepartementFk = 1
            };

            Etudiant Et1 = new Etudiant()
            {
                Id = 3,
                Mail = "selmi.Abdelaziz@gmail.com",
                Nom = "Selmi",
                Prenom = "Abdelaziz",
                Telephone = 58084423,
                DateEntree = new DateTime(2016,09,05),
                Niveau = 3,
                Payement = "Paye",
                DepartementFk = 1
            };
            Etudiant Et2 = new Etudiant()
            {
                Id = 4,
                Mail = "fehri.Hakim@gmail.com",
                Nom = "Fehri",
                Prenom = "Hakim",
                Telephone = 25028028,
                DateEntree = new DateTime(2016, 09, 05),
                Niveau = 3,
                Payement = "Paye",
                DepartementFk = 1
            };

            //Matiere M1 = new Matiere()
            //{
            //    Code = 1,
            //    Duree = 50,
            //    Libelle = "Architechture n-Tiers",
            //    Salle = 24
            //};
            //Matiere M2 = new Matiere()
            //{
            //    Code = 2,
            //    Duree = 50,
            //    Libelle = "Graphes Et Applications",
            //    Salle = 21
            //};
            //DepartementService DS = new DepartementService();
            //DS.Add(D);
            //DS.Commit();
            //EnseignantService EnS = new EnseignantService();
            //EnS.Add(Ens1);
            //EnS.Add(Ens2);
            //EnS.Commit();
            EtudiantService EtS = new EtudiantService();
            EtS.Add(Et1);
            EtS.Add(Et2);
            //EtS.Commit();
            //MatiereService Ms = new MatiereService();
            //Ms.Add(M1);
            //Ms.Add(M2);
            //Ms.Commit();
            System.Console.WriteLine("insert done with success");
            System.Console.ReadKey();
        }
    }
}
