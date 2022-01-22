using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebAPICore.Models
{
    public class Candidat
    {
        [Key]
        [Column("id")]
        public int id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string city { get; set; }

        public Candidat()
        {
        }

        public Candidat(int id, string name, string password, string email, string phone, string city)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.email = email;
            this.phone = phone;
            this.city = city;
        }
    }
}
