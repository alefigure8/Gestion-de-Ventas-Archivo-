using System;
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
        public List<Producto> listaProductos = new List<Producto>();

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

                }

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

        //TODO BUSQUEDA EN ARCHIVOS O LISTA
        public List<Producto> busquedaAvanzada(string filtro, string campo, string criterio, string categoria, string marca)
        {
            List<Producto> listaProducto = new List<Producto>();
            AccesoDB datoSQL = new AccesoDB();

            try
            {
                string query = "select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.ImagenUrl, A.IdMarca, A.IdCategoria, C.Descripcion as CategoriaDescripcion, M.Descripcion as MarcaDescripcion, A.Precio " +
                    $"from {Opciones.DBTablas.ARTICULOS} A, {Opciones.DBTablas.CATEGORIAS} C, {Opciones.DBTablas.MARCAS} M " +
                    "where A.IdCategoria = C.Id AND A.IdMarca = M.Id " +
                    $"AND M.Descripcion LIKE '%{marca}%' AND C.Descripcion LIKE '%{categoria}%' ";

                switch(campo)
                {
                    case Opciones.Campo.NOMBRE:
                        {
                            switch(criterio)
                            {
                                case Opciones.CriterioTexto.CONTIENE:
                                    query += $"AND A.Nombre LIKE '%{filtro}%'";
                                    break;
                                case Opciones.CriterioTexto.EMPIEZA:
                                    query += $"AND A.Nombre LIKE '{filtro}%'";
                                    break;
                                case Opciones.CriterioTexto.INCLUYE:
                                    {
                                        bool encontrado = false;
                                        string[] vFiltro = filtro.Split(' ');

                                        foreach(string item in vFiltro)
                                        {
                                            datoSQL.setQuery($"select Nombre from ARTICULOS where Nombre LIKE '%{item}%'");
                                            datoSQL.executeReader();

                                            if (datoSQL.Reader.HasRows)
                                            {
                                                query += $"AND A.Nombre LIKE '%{item}%'";
                                                encontrado= true;
                                                break;  
                                            }

                                            datoSQL.closeConnection();
                                        }

                                        if(!encontrado)
                                        {
                                            query += $"AND A.Nombre LIKE '%{filtro}%'";
                                        }

                                        datoSQL.closeConnection();
                                    }
                                    break;
                                default:
                                    query += $"";
                                    break;
                            }
                        }
                        break;
                    case Opciones.Campo.CODIGO:
                        {
                            switch(criterio)
                            {
                                case Opciones.CriterioTexto.CONTIENE:
                                    query += $"AND A.Codigo LIKE '%{filtro}%'";
                                    break;
                                case Opciones.CriterioTexto.EMPIEZA:
                                    query += $"AND A.Codigo LIKE '{filtro}%'";
                                    break;
                                case Opciones.CriterioTexto.INCLUYE:
                                    {
                                        bool encontrado = false;
                                        string[] vFiltro = filtro.Split(' ');

                                        foreach (string item in vFiltro)
                                        {
                                            datoSQL.setQuery($"select Codigo from ARTICULOS where Codigo LIKE '%{item}%'");
                                            datoSQL.executeReader();

                                            if (datoSQL.Reader.HasRows)
                                            {
                                                query += $"AND A.Codigo LIKE '%{item}%'";
                                                encontrado = true;
                                                break;
                                            }

                                            datoSQL.closeConnection();
                                        }

                                        if (!encontrado)
                                        {
                                            query += $"AND A.Codigo LIKE '%{filtro}%'";
                                        }

                                        datoSQL.closeConnection();
                                    }
                                    break;
                                default:
                                    query += $"";
                                    break;
                            }
                        }
                        break;
                    case Opciones.Campo.DESCRIPCION:
                        {
                            switch (criterio)
                            {
                                case Opciones.CriterioTexto.CONTIENE:
                                    query += $"AND A.Descripcion LIKE '%{filtro}%'";
                                    break;
                                case Opciones.CriterioTexto.EMPIEZA:
                                    query += $"AND A.Descripcion LIKE '{filtro}%'";
                                    break;
                                case Opciones.CriterioTexto.INCLUYE:
                                    {
                                        bool encontrado = false;
                                        string[] vFiltro = filtro.Split(' ');

                                        foreach (string item in vFiltro)
                                        {
                                            datoSQL.setQuery($"select Descripcion from ARTICULOS where Descripcion LIKE '%{item}%'");
                                            datoSQL.executeReader();

                                            if (datoSQL.Reader.HasRows)
                                            {
                                                query += $"AND A.Descripcion LIKE '%{item}%'";
                                                encontrado = true;
                                                break;
                                            }

                                            datoSQL.closeConnection();
                                        }

                                        if (!encontrado)
                                        {
                                            query += $"AND A.Descripcion LIKE '%{filtro}%'";
                                        }

                                        datoSQL.closeConnection();
                                    }
                                    break;
                                default:
                                    query += $"";
                                    break;
                            }
                        }
                        break;
                    //case Opciones.Campo.MARCA:
                    //    {
                    //        switch (criterio)
                    //        {
                    //            case Opciones.CriterioTexto.CONTIENE:
                    //                query += $"AND M.Descripcion LIKE '%{filtro}%'";
                    //                break;
                    //            case Opciones.CriterioTexto.EMPIEZA:
                    //                query += $"AND M.Descripcion LIKE '{filtro}%'";
                    //                break;
                    //            case Opciones.CriterioTexto.TERMINA:
                    //                query += $"AND M.Descripcion LIKE '%{filtro}'";
                    //                break;
                    //            default:
                    //                query += $"";
                    //                break;
                    //        }
                    //    }
                    //    break;
                    //case Opciones.Campo.CATEGORIA:
                    //    {
                    //        switch (criterio)
                    //        {
                    //            case Opciones.CriterioTexto.CONTIENE:
                    //                query += $"AND C.Descripcion LIKE '%{filtro}%'";
                    //                break;
                    //            case Opciones.CriterioTexto.EMPIEZA:
                    //                query += $"AND C.Descripcion LIKE '{filtro}%'";
                    //                break;
                    //            case Opciones.CriterioTexto.TERMINA:
                    //                query += $"AND C.Descripcion LIKE '%{filtro}'";
                    //                break;
                    //            default:
                    //                query += $"";
                    //                break;
                    //        }
                    //    }
                    //    break;
                    case Opciones.Campo.PRECIO:
                        {
                            switch (criterio)
                            {
                                case Opciones.CriterioNumero.MAYOR:
                                    query += $"AND A.Precio > {filtro}";
                                    break;
                                case Opciones.CriterioNumero.MENOR:
                                    query += $"AND A.Precio < {filtro}";
                                    break;
                                case Opciones.CriterioNumero.IGUAL:
                                    query += $"AND A.Precio = {filtro}";
                                    break;
                                default:
                                    query += $"";
                                    break;
                            }
                        }
                        break;
                    default:
                            query += $"A.Nombre LIKE '%'";
                        break;
                }

                datoSQL.setQuery(query);
                datoSQL.executeReader();

                while(datoSQL.Reader.Read())
                {
                    Producto aux = new Producto();

                    //***** PRODUCTO ***** //
                   aux.Id = (int)datoSQL.Reader[Opciones.Campo.ID];
                   aux.Codigo = (string)datoSQL.Reader[Opciones.Campo.CODIGO];
                   aux.Nombre = (string)datoSQL.Reader[Opciones.Campo.NOMBRE];
                   aux.Descripcion = (string)datoSQL.Reader[Opciones.Campo.DESCRIPCION];
                   aux.Precio = Math.Round(Convert.ToDecimal(datoSQL.Reader["Precio"]), 2);
                    aux.ImagenURL = (string)datoSQL.Reader[Opciones.Campo.URLIMAGEN];
                   
                   //**** MARCA ***** //
                   aux.MarcaInfo = new Marca();
                   aux.MarcaInfo.Id = (int)datoSQL.Reader[Opciones.Campo.IDMARCA];
                   aux.MarcaInfo.Descripcion = (string)datoSQL.Reader[Opciones.Campo.DESCMARCA];
                   
                   //**** CATEGORIA ***** ///
                   aux.CategoriaInfo = new Categoria();
                   aux.CategoriaInfo.Id = (int)datoSQL.Reader[Opciones.Campo.IDCATEGORIA];
                   aux.CategoriaInfo.Descripcion = (string)datoSQL.Reader[Opciones.Campo.DESCCATEGORIA];

                    listaProducto.Add(aux);
                }

                return listaProducto;
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

        public List<Producto> busquedaSimple(string filtro)
        {
            List<Producto> listaProducto = new List<Producto>();
            AccesoDB datoSQL = new AccesoDB();

            try
            {
                string query =
                    "select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.ImagenUrl, A.IdMarca, A.IdCategoria, C.Descripcion as CategoriaDescripcion, M.Descripcion as MarcaDescripcion, A.Precio " +
                    "from ARTICULOS A, CATEGORIAS C, MARCAS M " +
                    "where  A.IdCategoria = C.Id AND A.IdMarca = M.Id ";
                bool encontrado = false;
                string[] vFiltro = filtro.Split(' ');

                foreach (string item in vFiltro)
                {
                    datoSQL.setQuery($"SELECT Nombre FROM ARTICULOS WHERE Nombre LIKE '%{item}%' ");
                    datoSQL.executeReader();

                    if (datoSQL.Reader.HasRows)
                    {
                        Console.WriteLine("Entra " + item);
                        query += $"AND A.Nombre LIKE '%{item}%'";
                        encontrado = true;
                        datoSQL.closeConnection();
                        break;
                    }

                    datoSQL.closeConnection();
                }

                if (!encontrado)
                {
                    query += $"AND A.Nombre LIKE '%{filtro}%'";
                }
                Console.WriteLine(query);

                datoSQL.setQuery(query);
                datoSQL.executeReader();

                while (datoSQL.Reader.Read())
                {
                    Producto aux = new Producto();

                    //***** PRODUCTO ***** //
                    aux.Id = (int)datoSQL.Reader[Opciones.Campo.ID];
                    aux.Codigo = (string)datoSQL.Reader[Opciones.Campo.CODIGO];
                    aux.Nombre = (string)datoSQL.Reader[Opciones.Campo.NOMBRE];
                    aux.Descripcion = (string)datoSQL.Reader[Opciones.Campo.DESCRIPCION];
                    aux.Precio = Math.Round(Convert.ToDecimal(datoSQL.Reader["Precio"]), 2);
                    aux.ImagenURL = (string)datoSQL.Reader[Opciones.Campo.URLIMAGEN];

                    //**** MARCA ***** //
                    aux.MarcaInfo = new Marca();
                    aux.MarcaInfo.Id = (int)datoSQL.Reader[Opciones.Campo.IDMARCA];
                    aux.MarcaInfo.Descripcion = (string)datoSQL.Reader[Opciones.Campo.DESCMARCA];

                    //**** CATEGORIA ***** ///
                    aux.CategoriaInfo = new Categoria();
                    aux.CategoriaInfo.Id = (int)datoSQL.Reader[Opciones.Campo.IDCATEGORIA];
                    aux.CategoriaInfo.Descripcion = (string)datoSQL.Reader[Opciones.Campo.DESCCATEGORIA];

                    listaProducto.Add(aux);
                }
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
