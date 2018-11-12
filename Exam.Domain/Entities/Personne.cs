using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Entities
{
    public class Personne
    {
        [Key]
        public int Id { get; set; }
        public string Mail { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Telephone { get; set; }

        [ForeignKey("Departement")]
        public int DepartementFk { get; set; }
        //Navigation
        public virtual Departement Departement { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
    }
}
