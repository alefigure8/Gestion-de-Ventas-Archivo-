using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Empresa { get; set; }
        public bool Activo { get; set; }

        public Cliente() 
        { 
            Id = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            Empresa = string.Empty;
            Activo = true;
        }
    }
}
