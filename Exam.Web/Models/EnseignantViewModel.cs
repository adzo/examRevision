using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exam.Web.Models
{
    public class EnseignantViewModel : PersonneViewModel
    {
        public DateTime DateDePriseDeFonction { get; set; }
        public string Grade { get; set; }
        public int Salaire { get; set; }
    }
}