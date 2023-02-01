using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
                        int icolumn = 0;

                        //Lista Producto
                        ProductoNegocio productoNegocio = new ProductoNegocio();
                        List<Producto> listaProducto = new List<Producto>();
                        listaProducto = productoNegocio.listar();

                        //Lsita Venta para colocar dentro de Ventas
                        List<Venta> listaVenta = new List<Venta>();


                        //Ventas
                        Ventas aux = new Ventas();

                        aux.Id = int.Parse(data[icolumn++]);
                        aux.Fecha = DateTime.ParseExact(data[icolumn++], "dd/MM/yyyy", null);
                        aux.Total = Convert.ToDecimal(data[icolumn++].ToString().Replace(".", ","));
                        string aux_id_producto = data[icolumn++];
                        string aux_cantidad_venta = data[icolumn++];
                        aux.id_cliente = int.Parse(data[icolumn++]);
                        aux.Credit = int.Parse(data[icolumn++]) == 1 ? true : false;
                        aux.Impuesto = Convert.ToDecimal(data[icolumn++].ToString().Replace(".", ","));
                        aux.Descuento = Convert.ToDecimal(data[icolumn++].ToString().Replace(".", ","));

                        //Llave con Id de Productos, cargamos uno por uno
                        List<string> id_Producto = new List<string>();
                        id_Producto = aux_id_producto.Split('.').ToList();

                        foreach(var id in id_Producto)
                        {
                           if(!string.IsNullOrEmpty(id))
                            {
                                Venta aux_venta = new Venta();
                                Producto aux_producto = listaProducto.Find(x => int.Parse(id) == x.Id);

                               if(aux_venta != null)
                                {
                                    aux_venta.Id = aux_producto.Id;
                                    aux_venta.Codigo = aux_producto.Codigo;
                                    aux_venta.Nombre = aux_producto.Nombre;
                                    aux_venta.Descripcion = aux_producto.Descripcion;
                                    aux_venta.Precio = aux_producto.Precio;
                                    aux_venta.Stock = aux_producto.Stock;
                                    aux_venta.Costo = aux_producto.Costo;


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
                        }

                        //Llave con cantidades de cada Venta
                        List<string> cantidad_venta = new List<string>();
                        cantidad_venta = aux_cantidad_venta.Split('.').ToList();

                        for (int i = 0; i < listaVenta.Count; i++)
                        {
                            int try_cantidad_venta;
                            int.TryParse(cantidad_venta[i], out try_cantidad_venta);
                            listaVenta[i].Cantidad = try_cantidad_venta;
                            listaVenta[i].Total = listaVenta[i].Cantidad * listaVenta[i].Precio;
                        }

                        //Agrega la lista de venta al atributo venta de aux (Ventas)
                        aux.Venta = listaVenta;

                        //Agregamos Ventas a la lista de ventas
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
                    venta.Id = Utils.generarIdRandom();

                    //Agregamos la venta a la lista de venta
                    listaVentas.Add(venta);

                    //Adding the Rows
                    foreach (var item in listaVentas)
                    {
                        string id_venta = string.Empty;
                        string cantiadad_venta = string.Empty;

                        foreach (var item2 in item.Venta)
                        {
                            if (item2.Id != 0)
                                id_venta += item2.Id.ToString() + ".";
                        }

                        foreach (var item2 in item.Venta)
                        {
                            if (item2.Cantidad != 0)
                                cantiadad_venta += item2.Cantidad.ToString() + ".";

                        }

                        string credit = item.Credit ? "1": "0";

                        //Add the Data rows.
                        csv += $"{item.Id},{item.Fecha.ToString("dd/MM/yyyy")},{item.Total.ToString().Replace(",", ".")},{id_venta},{cantiadad_venta},{item.id_cliente},{credit},{item.Impuesto.ToString().Replace(",", ".")},{item.Descuento.ToString().Replace(",", ".")}";
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
