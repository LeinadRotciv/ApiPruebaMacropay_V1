using ApiPruebaMacropay.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiPruebaMacropay.Context
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<Material> Material { get; set; }
        public DbSet<RecepcionMaterial> RecepcionMaterial { get; set; }
    }
}
