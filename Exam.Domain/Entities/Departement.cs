using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Entities
{
    public class Departement
    {
        public int CodeDepartement { get; set; }
        public Dep NomDepartement { get; set; }

        //Navigation
        public virtual ICollection<Personne> Personnes { get; set; }
    }
}
