using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exam.Web.Models
{
    public class EtudiantViewModel : PersonneViewModel
    {
        public DateTime DateEntree { get; set; }
        public int Niveau { get; set; }
        public string Payement { get; set; }
    }
}