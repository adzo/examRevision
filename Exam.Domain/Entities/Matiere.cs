using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Entities
{
    public class Matiere
    {
        public int Code { get; set; }
        public int Duree { get; set; }
        [DataType(DataType.MultilineText)]
        public string Libelle { get; set; }
        public int Salle { get; set; }

        //Navigation
        public ICollection<Note> Notes { get; set; }
    }
}
