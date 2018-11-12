using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.Domain.Entities;

namespace Exam.Data.Configurations
{
    public class PersonneConfiguration : EntityTypeConfiguration<Personne>
    {
        public PersonneConfiguration()
        {
            //HasRequired(t => t.Departement).WithMany(t => t.Personnes).HasForeignKey(t => t.CodeDepartement);
            HasRequired<Departement>(s => s.Departement)
                .WithMany(g => g.Personnes)
                .HasForeignKey(s => s.DepartementFk);

            Map<Enseignant>(c =>
            {
                c.Requires("Type").HasValue(1); //Type is the descriminator
            });
            Map<Etudiant>(c =>
            {
                c.Requires("Type").HasValue(0);
            });
        }
    }
}
