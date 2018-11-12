using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exam.Web.Models
{
    public class EtudiantMatiereNoteViewModel
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Libelle { get; set; }
        public int NoteMatiere { get; set; }
    }
}