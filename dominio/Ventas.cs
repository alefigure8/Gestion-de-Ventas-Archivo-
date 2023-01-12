using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Ventas
    {
        public int Id{ get; set; }
        public DateTime  Fecha { get; set; }
        public decimal Total { get; set; }
        public List<Venta> Venta { get; set; }
        public int id_cliente { get; set; }

        public Ventas()
        {
            Id = 0;
            Fecha = DateTime.Now;
            Total = 0;
            Venta = new List<Venta>();
        }

    }
}
