using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebAPICore.Models
{
    public class Logo_recruteur
    {
        [Key]
        [Column("id")]
        public int id { get; set; }
        public string lien_logo { get; set; }
        public Recruteur recruteur { get; set; }

        public Logo_recruteur(int id, string lien_logo, Recruteur recruteur)
        {
            this.id = id;
            this.lien_logo = lien_logo;
            this.recruteur = recruteur;
        }

        public Logo_recruteur()
        {
        }
    }
}
