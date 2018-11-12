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
    public class EnseignantService : Service<Enseignant>, IEnseignantService
    {
        private static IDatabaseFactory databaseFactory = new DatabaseFactory();
        private static IUnitOfWork unit = new UnitOfWork(databaseFactory);

        public EnseignantService(): base(unit)
        {
            
        }

        public List<Enseignant> ListeNouveau()
        {
            EnseignantService ES = new EnseignantService();
            
            return ES.GetAll().Where(t => t.DateDePriseDeFonction > DateTime.Today.AddMonths(-6))
                .OrderByDescending(t => t.DateDePriseDeFonction).ToList(); ;
        }
    }
}
