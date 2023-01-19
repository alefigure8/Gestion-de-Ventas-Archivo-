using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using configuracion;
using dominio;
using System.IO;
using System.Windows.Forms;

namespace negocio
{
    public class ClienteNegocio
    {
        //Listar
        public List<Cliente> Listar()
        {
            List<Cliente> listaCliente = new List<Cliente>();
            string path = Application.LocalUserAppDataPath + Opciones.Folder.DATABASE;

            try
            {
                //Si el directorio no existe se crea
                if(!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                //i el archivo no existe se crea
                if (!File.Exists(path + Opciones.Folder.CLIENTE))
                {
                    File.Create(path + Opciones.Folder.CLIENTE);
                }

                if (new FileInfo(path + Opciones.Folder.CLIENTE).Length > 2)
                {
                    List<string[]> lines = File.ReadAllLines(path + Opciones.Folder.CLIENTE)
                        .Select(line => line.Split(',')).ToList();

                    foreach (string[] line in lines)
                    {
                        int icolumn = 0;
                        Cliente cliente = new Cliente();
                        cliente.Id = int.Parse(line[icolumn++]);
                        cliente.Nombre =line[icolumn++];
                        cliente.Apellido =line[icolumn++];
                        cliente.Empresa =line[icolumn++];

                        listaCliente.Add(cliente);
                    }

                }

                return listaCliente;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //Agregar uno

        public bool Agregar(Cliente cliente)
        {
            List<Cliente> listaCliente = this.Listar();
            string path = Application.LocalUserAppDataPath + Opciones.Folder.DATABASE;
            string csv = string.Empty;

            //Validar que no se encuentre
            Cliente agregarCliente = listaCliente.Find(cli => cli.Id == cliente.Id);

            if(agregarCliente == null)
            {
                cliente.Id = Utils.generarIdRandom();
                listaCliente.Add(cliente);

                //Agregar filas a la variable csv
                foreach (var item in listaCliente)
                {
                    //Add the Data rows.
                    int activo = item.Activo ? 1 : 0;
                    csv += $"{item.Id},{item.Nombre},{item.Apellido},{item.Empresa},{activo}";
                    //Add new line.
                    csv += "\r\n";
                }

                //Guardar
                try
                {
                    File.WriteAllText(path + Opciones.Folder.CLIENTE, csv);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                    throw ex;
                }

            }
            else
            {
                if(agregarCliente.Activo)
                {
                    //El cliente ya se encuentra
                }
                else
                {
                    //El cliente se encuentra inactivo
                }
            }
      
            //Reescribir archivo de clientes

            return true;
        }

        //Modificar Uno
        public bool Modificar()
        {
            List<Cliente> listaCliente = this.Listar();

            //Buscar cliente a modificar.
            //Borrar cliente.
            //Agregar nuevo
            return true;
        }
        //Borrar siempre y cuando no haya registros de ventas. Caso contrario impedirlo.
        public bool Borrar(int id)
        {
            //Borrado logico con Activo. 
            //Validar con lista de ventas que no haya Id cliente en ventas. Caso no contrario no se puede borrar.
            //Buscamos cliente por id y se lo pasamos a Modificar con Activo en 0
            return true;
        }
    }
}
