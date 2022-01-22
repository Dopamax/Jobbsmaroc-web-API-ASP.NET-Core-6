using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebAPICore.Models
{
    public class Recruteur { 


        [Key]
        [Column("id")]
        public int id { get; set; }
        public string societe { get; set; }
        public string siteweb { get; set; }
        public string details_societe { get; set; }
        public string ville { get; set; }
        public string email { get; set; }
        public string  motdepasse { get; set; }
        public string telephone { get; set; }


        public Recruteur(int id, string societe, string siteweb, string details_societe, string ville, string email, string motdepasse, string telephone)
        {
            this.id = id;
            this.societe = societe;
            this.siteweb = siteweb;
            this.details_societe = details_societe;
            this.ville = ville;
            this.email = email;
            this.motdepasse = motdepasse;
            this.telephone = telephone;
        }

        public Recruteur()
        {
        }
    }
}
