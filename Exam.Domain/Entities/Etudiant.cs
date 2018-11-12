using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Entities
{
    public class Etudiant:Personne
    {
        public DateTime DateEntree { get; set; }
        public int Niveau { get; set; }
        public string Payement { get; set; }
    }
}
