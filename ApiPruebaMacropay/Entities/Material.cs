namespace ApiPruebaMacropay.Entities
{
    public class Material
    {
        public int Id { get; set; }
        public int idMaterial { get; set; }
        public string nombreMaterial { get; set; }
        public string estatus { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaEliminacion { get; set; }
        public DateTime fechaActualizacion { get; set; }

    }
}
