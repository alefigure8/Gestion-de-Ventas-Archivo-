using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using configuracion;
using dominio;

namespace negocio
{
    public class VentaNegocio
    {
        public List<Ventas> listar()
        {
            string path = Application.LocalUserAppDataPath + Opciones.Folder.DATABASE;

            //Lista Ventas para retornar
            List<Ventas> listaVentas = new List<Ventas>();

            try
            {
                //Si el directorio no exste, lo crea
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    File.Create(path + Opciones.Folder.VENTAS);
                }

                //i el archivo no existe, lo crea
                if (!File.Exists(path + Opciones.Folder.VENTAS))
                {
                    File.Create(path + Opciones.Folder.VENTAS);
                }

                //Si el archivo tiene un longitud mayor a 2
                if (new FileInfo(path + Opciones.Folder.VENTAS).Length > 2)
                {

                    List<string[]> lines = File.ReadAllLines(path + Opciones.Folder.VENTAS)
                        .Select(line => line.Split(',')).ToList();

                    foreach (var data in lines)
                    {
                        //Lista Producto
                        ProductoNegocio productoNegocio = new ProductoNegocio();
                        List<Producto> listaProducto = new List<Producto>();
                        listaProducto = productoNegocio.listar();

                        //Lsita Venta
                        List<Venta> listaVenta = new List<Venta>();

                        int icolumn = 0;
                        //Ventas
                        Ventas aux = new Ventas();
                        aux.Id = int.Parse(data[icolumn++]);
                        aux.Fecha = DateTime.ParseExact(data[icolumn++], "dd/MM/yyyy", null);
                        aux.Total = Convert.ToDecimal(data[icolumn++].ToString().Replace(".", ","));
                        string aux_id_producto = data[icolumn++];
                        string aux_cantidad_venta = data[icolumn++];

                        //Llave con Id de Productos
                        List<string> id_Producto = new List<string>();
                        id_Producto = aux_id_producto.Split('.').ToList();

                        foreach(var id in id_Producto)
                        {
                           if(!string.IsNullOrEmpty(id))
                            {
                                Venta aux_venta = new Venta();
                                Producto aux_producto = listaProducto.Find(x => int.Parse(id) == x.Id);

                                aux_venta.Id = aux_producto.Id;
                                aux_venta.Codigo = aux_producto.Codigo;
                                aux_venta.Nombre = aux_producto.Nombre;
                                aux_venta.Descripcion = aux_producto.Descripcion;
                                aux_venta.Precio = aux_producto.Precio;
                                aux_venta.Stock = aux_producto.Stock;

                                Marca marca = new Marca();
                                marca.Id = aux_producto.MarcaInfo.Id;
                                marca.Descripcion = aux_producto.MarcaInfo.Descripcion;
                                aux_venta.MarcaInfo = marca;

                                Categoria categoria = new Categoria();
                                categoria.Id = aux_producto.CategoriaInfo.Id;
                                categoria.Descripcion = aux_producto.CategoriaInfo.Descripcion;
                                aux_venta.CategoriaInfo = categoria;

                                listaVenta.Add(aux_venta);
                            }
                        }

                        //Cargar cantidades de cada venta
                        List<string> cantidad_venta = new List<string>();
                        cantidad_venta = aux_cantidad_venta.Split('.').ToList();

                        for (int i = 0; i < listaVenta.Count; i++)
                        {
                            int aux_camtidad_vemta;
                            int.TryParse(cantidad_venta[i], out aux_camtidad_vemta);
                            listaVenta[i].Cantidad = aux_camtidad_vemta;
                        }

                        listaVentas.Add(aux);
                    }
                }          

                return listaVentas;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool agregar(Ventas venta)
        {
            string path = Application.LocalUserAppDataPath + Opciones.Folder.DATABASE;
            string csv = string.Empty;
            string id_venta = string.Empty;
            string cantiadad_venta = string.Empty;
            List<Ventas> listaVentas = new List<Ventas>();

            //Si no existe el directorio, locrea
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            //i el archivo no existe, lo crea
            if (!File.Exists(path + Opciones.Folder.VENTAS))
            {
                File.Create(path + Opciones.Folder.VENTAS);
            }

            try
            {
                if (new FileInfo(path + Opciones.Folder.DATA).Length > 2)
                {
                    //Listar ventas del archivo
                    listaVentas = this.listar();

                    //Gnerar Id
                    if (listaVentas.Count != 0)
                    {
                        venta.Id = listaVentas[listaVentas.Count - 1].Id + 1;
                    }
                    else
                    {
                        venta.Id = 1;
                    }

                    //Agregamos la venta a la lista de venta
                    listaVentas.Add(venta);

                    //Crear llave con Id de Venta
                    foreach (var item in venta.Venta)
                    {
                        if(item.Id != 0)
                            id_venta += item.Id.ToString() + ".";
                    }

                    //Crear llave con Id de Cantidades
                    foreach (var item in venta.Venta)
                    {
                        if (item.Cantidad != 0)
                            cantiadad_venta += item.Cantidad.ToString() + ".";
                    }

                    //Adding the Rows
                    foreach (var item in listaVentas)
                    {
                        //Add the Data rows.
                        csv += $"{item.Id},{item.Fecha.ToString("dd/MM/yyyy")},{item.Total.ToString().Replace(".", ",")},{id_venta},{cantiadad_venta}";
                        //Add new line.
                        csv += "\r\n";

                    }

                    File.WriteAllText(path + Opciones.Folder.VENTAS, csv);

                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminar(int id)
        {

        }

        public List<Ventas> buscar(string filtro, int id, DateTime fecha)
        {
            List<Ventas> listaVentas = new List<Ventas>();

            return listaVentas;
        }
    }
}
