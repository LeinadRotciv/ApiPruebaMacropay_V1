namespace ApiPruebaMacropay.Entities
{
    public class Proveedor
    {
        public int Id { get; set; }
        public int idProveedor { get; set; }
        public string nombreProveedor { get; set; }
        public string estatus { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaEliminacion { get; set; }
        public DateTime fechaActualizacion { get; set; }
    }
}
