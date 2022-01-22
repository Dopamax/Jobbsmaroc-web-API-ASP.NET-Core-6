using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace FirstWebAPICore.Models
{
    public class DBJobbsmaroc: DbContext
    {
        public DbSet<Candidat> Candidats { get; set; }
        public DbSet<Recruteur> Recruteurs { get; set; }
        public DbSet<Offre_emploi> Offre_emploi { get; set; }
        public DbSet<Cv_candidat> Cv_Candidats { get; set; }
        public DbSet<Logo_recruteur> Logo_Recruteur { get; set; }   

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =.; Initial Catalog = db_jobbsmaroc; Integrated Security = True");
        }
    }
}
