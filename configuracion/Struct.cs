using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace configuracion
{
    static public class Struct
    {
        public struct Configure
        {
            //public bool impuesto_1;
            //public bool impuesto_2;
            //public int impuesto_1;
            //public int impuesto_2;
            //public string logo;
            //public string icono;
        }

        public struct ventaPorProducto
        {
            public int Id;
            public string Codigo;
            public string Nombre;
            public string Descripcion;
            public string Categoria;
            public string Marca;
            public int Cantidad;
            public decimal Total;
        }
    }
}
