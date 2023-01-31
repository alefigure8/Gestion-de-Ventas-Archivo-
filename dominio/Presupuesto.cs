
namespace dominio
{
    public class Presupuesto : Producto
    {
        public int cantidad { get; set; }
        public decimal total { get; set; }

        public Presupuesto()
        {
            this.Codigo = "";
            this.Nombre = "";
            this.Precio = 0;
            this.Descripcion = "";
            this.cantidad = 0;
            this.total = 0;
        }
    }
}
