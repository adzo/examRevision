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
    public class DepartementService: Service<Departement>, IDepartementService
    {
        private static IDatabaseFactory databaseFactory = new DatabaseFactory();
        private static IUnitOfWork unit = new UnitOfWork(databaseFactory);

        public DepartementService() : base(unit)
        {
            
        }
    }
}
