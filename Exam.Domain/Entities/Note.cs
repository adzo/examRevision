using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Entities
{
    public class Note
    {
        [Key]
        [Column(Order = 1)]
        public int NoteId { get; set; }
        public int NoteMatiere { get; set; }
        public string Observation { get; set; }
        [Column(Order = 2)]
        [ForeignKey("Personne")]
        public int Id { get; set; }
        [Column(Order = 3)]
        [ForeignKey("Matiere")]
        public int Code { get; set; }
        //Navigation
        public virtual Personne Personne { get; set; }
        public virtual Matiere Matiere { get; set; }
    }
}
