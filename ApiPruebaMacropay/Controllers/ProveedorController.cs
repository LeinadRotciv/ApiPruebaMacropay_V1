using ApiPruebaMacropay.Context;
using ApiPruebaMacropay.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiPruebaMacropay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly ApplicationDBContext context;

        public ProveedorController(ApplicationDBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Proveedor>> Get()
        {
            return context.Proveedor.ToList();
        }
        [HttpGet("{id}", Name = "ObtenerProveedor")]
        public ActionResult<Proveedor> Get(int id)
        {
            var proveedor = context.Proveedor.FirstOrDefault(x => x.Id == id);
            if (proveedor == null)
            {
                return NotFound();
            }
            return proveedor;
        }
        [HttpPost]
        public ActionResult Post([FromBody] Proveedor proveedor)
        {
            context.Proveedor.Add(proveedor);
            context.SaveChanges();

            return new CreatedAtRouteResult("ObtenerProveedor", new { id = proveedor.Id }, proveedor);
        }
    }
}
