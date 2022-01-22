using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebAPICore.Models
{
    public class Offre_emploi
    {
        [Key]
        [Column("id")]
        public int id { get; set; }
        public string categorie { get; set; }
        public string titre { get; set; }
        public string description { get; set; }
        public string type_emploi { get; set; }
        public string type_contrat { get; set; }
        public string experience_requise { get; set; }
        public string niveau_etude { get; set; }
        public string salaire_min { get; set; }
        public string salaire_max { get; set; }
        public string  offre_adresse { get; set; }

        public Recruteur recruteur { get; set; }

        public Offre_emploi(int id, string categorie, string titre, string description, string type_emploi, string type_contrat, string experience_requise, string niveau_etude, string salaire_min, string salaire_max, string offre_adresse, Recruteur recruteur)
        {
            this.id = id;
            this.categorie = categorie;
            this.titre = titre;
            this.description = description;
            this.type_emploi = type_emploi;
            this.type_contrat = type_contrat;
            this.experience_requise = experience_requise;
            this.niveau_etude = niveau_etude;
            this.salaire_min = salaire_min;
            this.salaire_max = salaire_max;
            this.offre_adresse = offre_adresse;
            this.recruteur = recruteur;
        }

        public Offre_emploi()
        {
        }
    }
}
