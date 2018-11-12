using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.Data.Infrastructure;
using Exam.Domain.Entities;
using Service.Pattern;

namespace Exam.Service
{
    public class EtudiantService : Service<Etudiant>, IEtudiantService
    {
        private static IDatabaseFactory databaseFactory = new DatabaseFactory();
        private static IUnitOfWork unit = new UnitOfWork(databaseFactory);

        public EtudiantService() : base(unit)
        {
            
        }

        public List<Etudiant> ListeEtudiantInferieur(Matiere M)
        {
            EtudiantService ES = new EtudiantService();
            MatiereService MS = new MatiereService();
            List<Note> notes = new List<Note>();
            notes = MS.GetById(M.Code).Notes.ToList();
            List<Etudiant> result = new List<Etudiant>();
            foreach (var note in notes)
            {
                if (note.NoteMatiere < 10)
                {
                    result.Add(ES.GetById(note.Id));
                }
            }

            return result;
        }
    }
}
