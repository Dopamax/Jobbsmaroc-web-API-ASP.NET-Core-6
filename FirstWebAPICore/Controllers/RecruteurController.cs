using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FirstWebAPICore.Models;

namespace FirstWebAPICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecruteurController : ControllerBase
    {
        [HttpGet("touslesrecruteurs")]
        public List<Recruteur> avoirTousLesRecruteurs()
        {
            using (DBJobbsmaroc db = new DBJobbsmaroc())
            {
                return db.Recruteurs.ToList();
            }
        }
        [HttpGet("{id}")]
        public Recruteur avoirUnRecruteur(int id)
        {
            using (DBJobbsmaroc db = new DBJobbsmaroc())
            {
                return db.Recruteurs.Find(id);
            }
        }
    }
}
