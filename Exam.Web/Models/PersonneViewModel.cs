using System.Collections.Generic;

namespace Exam.Web.Models
{
    public class PersonneViewModel
    {
        public int Id { get; set; }
        public string Mail { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Telephone { get; set; }

       
        public int DepartementFk { get; set; }
        //Navigation
        public virtual DepartementViewModel Departement { get; set; }
        public virtual ICollection<NoteViewModel> Notes { get; set; }
    }
}