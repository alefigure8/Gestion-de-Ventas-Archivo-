using configuracion;
using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listaMarca = new List<Marca>();

        public List<Marca> listar()
        {
            //TODO Crear Carpeta y archivo en caso de que no existan
            string path = Application.LocalUserAppDataPath + Opciones.Folder.DATABASE;

            List<Marca> listaMarca = new List<Marca>();

            try
            {
                //verificar si existe el directorio. Caso contrario, crear carpeta y archivo.
                if (Directory.Exists(path))
                {
                    //Verificar si no existe el archivo
                    if (!File.Exists(path + Opciones.Folder.DATAMARCA))
                    {
                        File.Create(path + Opciones.Folder.DATAMARCA);
                    }

                    if (new FileInfo(path + Opciones.Folder.DATAMARCA).Length > 2)
                    {
                        List<string[]> lines = File.ReadAllLines(path + Opciones.Folder.DATAMARCA)
                                .Select(line => line.Split(',')).ToList();

                        foreach (string[] line in lines)
                        {
                            Marca marca = new Marca();
                            marca.Id = int.Parse(line[0]);
                            marca.Descripcion = line[1];

                            listaMarca.Add(marca);
                        }
                    }
                }
                else
                {
                    Directory.CreateDirectory(path);
                    File.Create(path + Opciones.Folder.DATAMARCA);
                }

                return listaMarca;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool agregar(string keyword)
        {
            string path = Application.LocalUserAppDataPath + Opciones.Folder.DATABASE;

            List<Marca> listaMarca = new List<Marca>();
            listaMarca = this.listar();

            Marca aux = new Marca();
            aux.Id = listaMarca.Count > 0 ? listaMarca[listaMarca.Count - 1].Id + 1 : 1;
            aux.Descripcion = keyword;

            listaMarca.Add(aux);

            string csv = string.Empty;
            //Adding the Rows
            foreach (var item in listaMarca)
            {
                //Add the Data rows.
                csv += $"{item.Id},{item.Descripcion}";
                //Add new line.
                csv += "\r\n";
            }

            try
            {
                File.WriteAllText(path + Opciones.Folder.DATAMARCA, csv);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }

        }

        public bool modificar(Marca marca, string change)
        {
            string path = Application.LocalUserAppDataPath + Opciones.Folder.DATABASE;

            List<Marca> listaMarca = new List<Marca>();
            listaMarca = this.listar();

            listaMarca = listaMarca.FindAll(prod => prod.Id != marca.Id);

            Marca aux = new Marca();
            aux.Id = marca.Id;
            aux.Descripcion = change;
            listaMarca.Add(aux);

            string csv = string.Empty;

            //Adding the Rows
            foreach (var item in listaMarca)
            {
                //Add the Data rows.
                csv += $"{item.Id},{item.Descripcion}";
                //Add new line.
                csv += "\r\n";
            }

            try
            {
                File.WriteAllText(path + Opciones.Folder.DATAMARCA, csv);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }

        }

        public bool eliminar(Marca marca)
        {
            string path = Application.LocalUserAppDataPath + Opciones.Folder.DATABASE;

            List<Marca> listaMarca = new List<Marca>();
            listaMarca = this.listar();

            listaMarca = listaMarca.FindAll(prod => prod.Id != marca.Id);

            string csv = string.Empty;

            //Adding the Rows
            foreach (var item in listaMarca)
            {
                //Add the Data rows.
                csv += $"{item.Id},{item.Descripcion}";
                //Add new line.
                csv += "\r\n";
            }

            try
            {
                File.WriteAllText(path + Opciones.Folder.DATAMARCA, csv);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }

        }

        public List<Marca> buscar(string filtro)
        {
            
            List<Marca> listaMarca = new List<Marca>();

            try
            {
                listaMarca = listaMarca.Select(prod => prod.Descripcion.Contains(filtro) ? prod : null).ToList();
                return listaMarca;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool existeMarca(string keyword)
        {
            string path = Application.LocalUserAppDataPath + Opciones.Folder.DATABASE;

            List<Marca> listaMarca = new List<Marca>();
            listaMarca = this.listar();

            try
            {
                    if(listaMarca.Any(prod => prod.Descripcion == keyword))
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
