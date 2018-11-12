using System.Collections.Generic;

namespace Exam.Web.Models
{

    public enum Dep
    {
        TIC,
        Telecome,
        GenieCivil
    }
    public class DepartementViewModel
    {
        public int CodeDepartement { get; set; }
        public Dep NomDepartement { get; set; }

        //Navigation
        public virtual ICollection<PersonneViewModel> Personnes { get; set; }
    }
}