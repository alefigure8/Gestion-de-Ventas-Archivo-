using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Venta : Producto
    {
        public int Cantidad { get; set; }
        public decimal Total{ get; set; }

        public Venta()
        {
            this.Id = 0;
            this.Codigo = "";
            this.Nombre = "";
            this.Precio = 0;
            this.Descripcion = "";
            this.Cantidad = 0;
            this.Total = 0;
            this.Stock = 0;
            this.Costo = 0;

            Categoria auxCategoria = new Categoria();
            auxCategoria.Id = 0;
            auxCategoria.Descripcion = "";

            Marca auxMarca = new Marca();
            auxMarca.Id = 0;
            auxMarca.Descripcion = "";

            this.CategoriaInfo = auxCategoria;
            this.MarcaInfo = auxMarca;
        }
    }
}
