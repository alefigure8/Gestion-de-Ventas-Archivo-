using System;
using System.Collections.Generic;
using System.Linq;
using dominio;
using configuracion;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            //TODO Crear Carpeta y archivo en caso de que no existan
            string path = Application.LocalUserAppDataPath + Opciones.Folder.DATABASE;
            List<Categoria> listaCategoria = new List<Categoria>();

            try
            {
                //verificar si existe el directorio. Caso contrario, crear carpeta y archivo.
                if (Directory.Exists(path))
                {
                    //Verificar si no existe el archivo
                    if (!File.Exists(path + Opciones.Folder.DATACATEGORIA))
                    {
                        File.Create(path + Opciones.Folder.DATACATEGORIA);
                    }

                    if (new FileInfo(path + Opciones.Folder.DATACATEGORIA).Length > 2)
                    {
                        List<string[]> lines = File.ReadAllLines(path + Opciones.Folder.DATACATEGORIA)
                                .Select(line => line.Split(',')).ToList();

                        foreach (string[] line in lines)
                        {
                            Categoria categoria = new Categoria();
                            categoria.Id = int.Parse(line[0]);
                            categoria.Descripcion = line[1];

                            listaCategoria.Add(categoria);
                        }
                    }
                }
                else
                {
                    Directory.CreateDirectory(path);
                    File.Create(path + Opciones.Folder.DATACATEGORIA);
                }

                return listaCategoria;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool agregar(string keyword)
        {
            string path = Application.LocalUserAppDataPath + Opciones.Folder.DATABASE;

            List<Categoria> listaCategoria = new List<Categoria>();
            listaCategoria = this.listar();

            //Crear objeto
            Categoria aux = new Categoria();
            aux.Id = Utils.generarIdRandom();
            aux.Descripcion = keyword;

            //Listar objeto
            listaCategoria.Add(aux);

            string csv = string.Empty;

            //Adding the Rows
            foreach (var item in listaCategoria)
            {
                //Add the Data rows.
                csv += $"{item.Id},{item.Descripcion}";
                //Add new line.
                csv += "\r\n";
            }

            try
            {
                File.WriteAllText(path + Opciones.Folder.DATACATEGORIA, csv);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        public bool modificar(Categoria categoria, string change)
        {
            string path = Application.LocalUserAppDataPath + Opciones.Folder.DATABASE;

            List<Categoria> listaCategoria = new List<Categoria>();
            listaCategoria = this.listar();

            listaCategoria = listaCategoria.FindAll(prod => prod.Id != categoria.Id);

            Categoria aux = new Categoria();
            aux.Id = categoria.Id;
            aux.Descripcion = change;
            listaCategoria.Add(aux);

            string csv = string.Empty;

            //Adding the Rows
            foreach (var item in listaCategoria)
            {
                //Add the Data rows.
                csv += $"{item.Id},{item.Descripcion}";
                //Add new line.
                csv += "\r\n";
            }

            try
            {
                File.WriteAllText(path + Opciones.Folder.DATACATEGORIA, csv);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        public bool eliminar(Categoria categoria)
        {
            string path = Application.LocalUserAppDataPath + Opciones.Folder.DATABASE;

            List<Categoria> listaCategoria = new List<Categoria>();
            listaCategoria = this.listar();

            listaCategoria = listaCategoria.FindAll(prod => prod.Id != categoria.Id);

            string csv = string.Empty;

            //Adding the Rows
            foreach (var item in listaCategoria)
            {
                //Add the Data rows.
                csv += $"{item.Id},{item.Descripcion}";
                //Add new line.
                csv += "\r\n";
            }

            try
            {
                File.WriteAllText(path + Opciones.Folder.DATACATEGORIA, csv);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        public bool existeCategoria(string keyword)
        {
            string path = Application.LocalUserAppDataPath + Opciones.Folder.DATABASE;

            List<Categoria> listaCategoria = new List<Categoria>();
            listaCategoria = this.listar();

            try
            {
                if (listaCategoria.Any(prod => prod.Descripcion == keyword))
                    return true;

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
