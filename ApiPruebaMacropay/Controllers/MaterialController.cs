using ApiPruebaMacropay.Context;
using ApiPruebaMacropay.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiPruebaMacropay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly ApplicationDBContext context;

        public MaterialController(ApplicationDBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Material>> Get()
        {
            return context.Material.ToList();
        }
        [HttpGet("{id}", Name = "ObtenerMaterial")]
        public ActionResult<Material> Get(int id)
        {
            var material = context.Material.FirstOrDefault(x => x.Id == id);
            if (material == null)
            {
                return NotFound();
            }
            return material;
        }
        [HttpPost]
        public ActionResult Post([FromBody] Material material)
        {
            context.Material.Add(material);
            context.SaveChanges();

            return new CreatedAtRouteResult("ObtenerMaterial", new { id = material.Id }, material);
        }
        [HttpDelete("{id}")]
        public ActionResult<Material> Delete(int id)
        {
            var material = context.Material.FirstOrDefault(x => x.Id == id);

            if (material == null)
            {
                return NotFound();
            }

            context.Entry(material).State = EntityState.Deleted;
            context.SaveChanges();
            return material;
        }
    }
}
