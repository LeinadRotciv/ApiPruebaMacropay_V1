namespace ApiPruebaMacropay.Entities
{
    public class RecepcionMaterial
    {
        public int Id { get; set; }
        public Proveedor Proveedor { get; set; }
        public Material Material { get; set; }
        public decimal cantidadRecibida { get; set; }
        public DateTime fechaRecepcion { get; set; }
    }
}
