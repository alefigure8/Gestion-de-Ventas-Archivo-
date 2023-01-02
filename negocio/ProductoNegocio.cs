﻿using System;
using System.Collections.Generic;
using dominio;
using configuracion;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace negocio
{
    public class ProductoNegocio
    {
        public List<Producto> listar()
        {
            string path = Application.LocalUserAppDataPath + Opciones.Folder.DATABASE;

            //Listar Marca
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            List<Marca> listaMarca = new List<Marca>();
            listaMarca = marcaNegocio.listar();

            //Listar Categoria
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            List <Categoria> listaCategoria = new List<Categoria>();
            listaCategoria = categoriaNegocio.listar();

            List<Producto> listaProducto = new List<Producto>();

            try
            {
                if(File.Exists(path + Opciones.Folder.DATA))
                {
                    if (new FileInfo(path + Opciones.Folder.DATA).Length > 2)
                    {
                        List<string[]> lines = File.ReadAllLines(path + Opciones.Folder.DATA)
                            .Select(line => line.Split(',')).ToList();

                        foreach (var data in lines)
                        {
                            int icolumn = 0;
                            Producto aux = new Producto();
                            aux.Id = int.Parse(data[icolumn++]);
                            aux.Codigo = data[icolumn++];
                            aux.Nombre = data[icolumn++];
                            aux.Descripcion = data[icolumn++];
                            aux.Precio = Convert.ToDecimal(data[icolumn++].Replace(".", ","));
                            aux.ImagenURL = data[icolumn++];

                            Marca marca = new Marca();
                            marca.Id = int.Parse(data[icolumn++]);
                            marca.Descripcion = listaMarca.Find(x => x.Id == marca.Id).Descripcion;
                            aux.MarcaInfo = marca;

                            Categoria categoria = new Categoria();
                            categoria.Id = int.Parse(data[icolumn++]);
                            categoria.Descripcion = listaCategoria.Find(x => x.Id == categoria.Id).Descripcion;
                            aux.CategoriaInfo = categoria;

                            listaProducto.Add(aux);
                        }

                    }

                } // SI NO EXISTE CREAMOS CARPETA Y ARCHIVO

                return listaProducto;
                
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public bool agregar (Producto producto)
        {
            string path = Application.LocalUserAppDataPath + Opciones.Folder.DATABASE;
            string csv = string.Empty;

            List<Producto> listaProductos = new List<Producto>();
            listaProductos = this.listar();

            listaProductos.Add(producto);

            //Adding the Rows
            foreach (var item in listaProductos)
            {
                //Add the Data rows.
                csv += $"{item.Id},{item.Codigo},{item.Nombre},{item.Descripcion},{item.Precio.ToString().Replace(",", ".")},{item.ImagenURL},{item.MarcaInfo.Id},{item.CategoriaInfo.Id}";
                //Add new line.
                csv += "\r\n";
                //Add new line.
            }

            //Guardar
            try
            {
                File.WriteAllText(path + Opciones.Folder.DATA, csv);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
                
            
        }

        public bool modificar(Producto producto)
        {
            List<Producto> listaProductos = new List<Producto>();
            listaProductos = this.listar();

            listaProductos = listaProductos.FindAll(prod => prod.Id != producto.Id );
            listaProductos.Add(producto);

            string path = Application.LocalUserAppDataPath + Opciones.Folder.DATABASE;
            string csv = string.Empty;

            // Adding the Rows
            foreach (var item in listaProductos)
            {
                //Add the Data rows.
                csv += $"{item.Id},{item.Codigo},{item.Nombre},{item.Descripcion},{item.Precio.ToString().Replace(",", ".")},{item.ImagenURL},{item.MarcaInfo.Id},{item.CategoriaInfo.Id}";
                //Add new line.
                csv += "\r\n";
                //Add new line.
            }

            try
            {
                File.WriteAllText(path + Opciones.Folder.DATA, csv);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }

        }

        public bool borrar(int id)
        {
            List<Producto> listaProductos = new List<Producto>();
            listaProductos = this.listar();
            listaProductos = listaProductos.FindAll(prod => prod.Id != id);
 
            string path = Application.LocalUserAppDataPath + Opciones.Folder.DATABASE;
            string csv = string.Empty;

            foreach (var item in listaProductos)
            {
                //Add the Data rows.
                csv += $"{item.Id},{item.Codigo},{item.Nombre},{item.Descripcion},{item.Precio.ToString().Replace(",", ".")},{item.ImagenURL},{item.MarcaInfo.Id},{item.CategoriaInfo.Id}";
                //Add new line.
                csv += "\r\n";
                //Add new line.
            }

            try
            {
                File.WriteAllText(path + Opciones.Folder.DATA, csv);
                return true;
            }
            catch (Exception ex)
            {

                 return false;
                throw ex;
            }

        }

        public List<Producto> busquedaAvanzada(string filtro, string campo, string criterio, string categoria, string marca)
        {
            List<Producto> listaProducto = new List<Producto>();
            listaProducto = this.listar();

            try
            {
                //Filtro Marca
                if(!string.IsNullOrEmpty(marca))
                    listaProducto = listaProducto.FindAll(prod => prod.MarcaInfo.Descripcion == marca);

                //Friltro Categoria
                if(!string.IsNullOrEmpty(categoria))
                    listaProducto = listaProducto.FindAll(prod => prod.CategoriaInfo.Descripcion == categoria);

                switch (campo)
                {
                    case Opciones.Campo.NOMBRE:
                        {
                            switch(criterio)
                            {
                                case Opciones.CriterioTexto.CONTIENE:
                                    {
                                        if (string.IsNullOrEmpty(filtro))
                                            return listaProducto;

                                        listaProducto = listaProducto.FindAll(x => x.Nombre.ToLower() == filtro.ToLower()).ToList();
                                    }
                                    break;

                                case Opciones.CriterioTexto.EMPIEZA:
                                    {
                                        if (string.IsNullOrEmpty(filtro))
                                            return listaProducto;

                                        listaProducto = listaProducto.FindAll(x => x.Nombre.Contains(filtro)).ToList();
                                    }
                                    break;
                                case Opciones.CriterioTexto.INCLUYE:
                                    {
                                        if (string.IsNullOrEmpty(filtro))
                                            return listaProducto;

                                        string[] keyWords = filtro.Split(',');
                                        foreach(string word in keyWords)
                                        {
                                            if (listaProducto.Any(x => x.Nombre.Contains(word)))
                                            {
                                                listaProducto.FindAll(x => x.Nombre.Contains(word));
                                                break;
                                            }
                                        }
                                    }
                                    break;
                                default:
                                    listaProducto.Clear();
                                    break;
                            }
                        }
                        break;
                    case Opciones.Campo.CODIGO:
                        {
                            switch(criterio)
                            {
                                case Opciones.CriterioTexto.CONTIENE:
                                    listaProducto = listaProducto.FindAll(x => x.Codigo.ToLower() == filtro.ToLower()).ToList();
                                    break;

                                case Opciones.CriterioTexto.EMPIEZA:
                                    listaProducto = listaProducto.FindAll(x => x.Codigo.Contains(filtro)).ToList();
                                    break;
                                case Opciones.CriterioTexto.INCLUYE:
                                    {
                                        string[] keyWords = filtro.Split(',');
                                        foreach (string word in keyWords)
                                        {
                                            if (listaProducto.Any(x => x.Codigo.Contains(word)))
                                            {
                                                listaProducto.FindAll(x => x.Codigo.Contains(word));
                                                break;
                                            }
                                        }
                                    }
                                    break;
                                default:
                                    listaProducto.Clear();
                                    break;
                            }
                        }
                        break;
                    case Opciones.Campo.DESCRIPCION:
                        {
                            switch (criterio)
                            {
                                case Opciones.CriterioTexto.CONTIENE:
                                    listaProducto = listaProducto.FindAll(x => x.Descripcion.ToLower() == filtro.ToLower()).ToList();
                                    break;

                                case Opciones.CriterioTexto.EMPIEZA:
                                    listaProducto = listaProducto.FindAll(x => x.Descripcion.Contains(filtro)).ToList();
                                    break;
                                case Opciones.CriterioTexto.INCLUYE:
                                    {
                                        string[] keyWords = filtro.Split(',');
                                        foreach (string word in keyWords)
                                        {
                                            if (listaProducto.Any(x => x.Descripcion.Contains(word)))
                                            {
                                                listaProducto.FindAll(x => x.Descripcion.Contains(word));
                                                break;
                                            }
                                        }
                                    }
                                    break;
                                default:
                                    listaProducto.Clear();
                                    break;
                            }
                        }
                        break;
                    case Opciones.Campo.PRECIO:
                        {
                            switch (criterio)
                            {
                                case Opciones.CriterioNumero.MAYOR:
                                    listaProducto = listaProducto.FindAll(x => x.Precio > Convert.ToDecimal(filtro));
                                    break;
                                case Opciones.CriterioNumero.MENOR:
                                    listaProducto = listaProducto.FindAll(x => x.Precio < Convert.ToDecimal(filtro));
                                    break;
                                case Opciones.CriterioNumero.IGUAL:
                                    listaProducto = listaProducto.FindAll(x => x.Precio == Convert.ToDecimal(filtro));
                                    break;
                                default:
                                    listaProducto.Clear();
                                    break;
                            }
                        }
                        break;
                    default:
                        listaProducto.Clear();
                        break;
                }


                return listaProducto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Producto> busquedaSimple(string filtro)
        {
            List<Producto> listaProducto = new List<Producto>();
            listaProducto = this.listar();

            try
            {
                if (!string.IsNullOrEmpty(filtro))
                    listaProducto = listaProducto.FindAll(x => x.Nombre.ToLower().Contains(filtro));
                else
                    listaProducto.Clear();
                
                return listaProducto;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool existeMarca(string keyword)
        {
            AccesoDB datoSQL = new AccesoDB();

            try
            {
                datoSQL.setQuery($"SELECT * FROM {Opciones.DBTablas.ARTICULOS} WHERE {Opciones.Campo.DESCRIPCION} = '{keyword}'");
                datoSQL.executeReader();

                if (datoSQL.Reader.Read())
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datoSQL.closeConnection();
            }
        }
    }
}
