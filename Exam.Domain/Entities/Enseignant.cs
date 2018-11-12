using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Entities
{
    public class Enseignant:Personne
    {
        public DateTime DateDePriseDeFonction { get; set; }
        public string Grade { get; set; }
        [DataType(DataType.Currency)]
        public int Salaire { get; set; }
    }
}
