using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebAPICore.Models
{
    public class Cv_candidat
    {
        [Key]
        [Column("id")]
        public int id { get; set; }
        public string lien_cv { get; set; }
        public Candidat candidat { get; set; }

        public Cv_candidat(int id, string lien_cv, Candidat candidat)
        {
            this.id = id;
            this.lien_cv = lien_cv;
            this.candidat = candidat;
        }

        public Cv_candidat()
        {
        }
    }
}
