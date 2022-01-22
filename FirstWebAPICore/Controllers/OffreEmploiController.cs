using FirstWebAPICore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OffreEmploiController : ControllerBase
    {
        [HttpGet("touslesoffres")]
        public List<Offre_emploi> tousLesOffres()
        {
            using (DBJobbsmaroc db = new DBJobbsmaroc())
            {
                return db.Offre_emploi.ToList();
            }
        }

        [HttpGet("{id}")]
        public Offre_emploi avoirUnOffreEmploi(int id)
        {
            using (DBJobbsmaroc db = new DBJobbsmaroc())
            {
                return db.Offre_emploi.Find(id);
            }
        }
    }
}
