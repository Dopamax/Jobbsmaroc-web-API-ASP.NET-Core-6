using FirstWebAPICore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatsController : ControllerBase
    {
        [HttpGet("touslescandidats")]
        public List<Candidat> getTousLesCandidats()
        {

            using (DBJobbsmaroc db= new DBJobbsmaroc())
            {
                return db.Candidats.ToList();
            }
        }
        [HttpGet("{id}")]
        public Candidat avoirUnCandidat(int id)
        {
            using (DBJobbsmaroc db= new DBJobbsmaroc())
            {
                return db.Candidats.Find(id);
            }
        }
    }
}
