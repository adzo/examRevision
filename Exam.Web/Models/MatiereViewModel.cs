using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exam.Web.Models
{
    public class MatiereViewModel
    {
        public int Code { get; set; }
        public int Duree { get; set; }
        public string Libelle { get; set; }
        public int Salle { get; set; }

        //Navigation
        public ICollection<NoteViewModel> Notes { get; set; }
    }
}