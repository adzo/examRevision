namespace Exam.Web.Models
{
    public class NoteViewModel
    {
        public int NoteId { get; set; }
        public int NoteMatiere { get; set; }
        public string Observation { get; set; }
        
        public int Id { get; set; }
        
        public int Code { get; set; }
        //Navigation
        public virtual PersonneViewModel Personne { get; set; }
        public virtual MatiereViewModel Matiere { get; set; }
    }
}