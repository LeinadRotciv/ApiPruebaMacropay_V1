using ApiPruebaMacropay.Context;
using ApiPruebaMacropay.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiPruebaMacropay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecepcionMaterialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly ApplicationDBContext context;

        public RecepcionMaterialController(ApplicationDBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<RecepcionMaterial>> Get()
        {
            return context.RecepcionMaterial.ToList();
        }
        [HttpGet("{id}", Name = "ObtenerRecepcionMaterial")]
        public ActionResult<RecepcionMaterial> Get(int id)
        {
            var rm = context.RecepcionMaterial.FirstOrDefault(x => x.Id == id);
            if (rm == null)
            {
                return NotFound();
            }
            return rm;
        }
        [HttpPost]
        public ActionResult Post([FromBody] RecepcionMaterial rm)
        {
            context.RecepcionMaterial.Add(rm);
            context.SaveChanges();

            return new CreatedAtRouteResult("ObtenerRecepcionMaterial", new { id = rm.Id }, rm);
        }
    }
}
