
namespace dominio
{
    public class Presupuesto : Producto
    {
        public int cantidad { get; set; }
        public decimal total { get; set; }

        public Presupuesto()
        {
            this.Id = 0;
            this.Codigo = "";
            this.Nombre = "";
            this.Precio = 0;
            this.Descripcion = "";
            this.cantidad = 0;
            this.total = 0;

            Categoria auxCategoria = new Categoria();
            auxCategoria.Id = 0;
            auxCategoria.Descripcion = "";

            Marca auxMarca= new Marca();
            auxMarca.Id = 0;
            auxMarca.Descripcion = "";

            this.CategoriaInfo = auxCategoria;
            this.MarcaInfo = auxMarca;
        }
    }
}
