using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using configuracion;

namespace helper
{
    static public class Metodos
    {
        static public bool copiarImagen(Producto producto, OpenFileDialog file, TextBox txtImagen)
        {
            string path = Application.LocalUserAppDataPath + Opciones.Folder.IMAGE;

            //Validar si existe la carpeta
            if (!Directory.Exists(path))
            {                                      
                Directory.CreateDirectory(path);
            }

            try
            {
                if(File.Exists(path + file.SafeFileName))
                {
                    DialogResult result = MessageBox.Show("El archivo ya existe. ¿Desea Remplazarlo?", "Ya existe", MessageBoxButtons.OKCancel);

                    if (result == DialogResult.OK)
                    {
                        File.Delete(path + file.SafeFileName);
                        File.Copy(file.FileName, path + file.SafeFileName);
                        producto.ImagenURL = path + file.SafeFileName;
                        txtImagen.Text = path + file.SafeFileName;
                        return true;
                    }

                    return false;
                }
                else
                {
                    File.Copy(file.FileName, path + file.SafeFileName);
                    producto.ImagenURL = path + file.SafeFileName;
                    txtImagen.Text = path + file.SafeFileName;
                    return true;
                }

            }
            catch (Exception ex)
            {
                    throw ex;
            }
        }

        static public bool guardarLogo(OpenFileDialog file)
        {
            string path = Path.GetDirectoryName(Directory.GetCurrentDirectory().Replace(@"\bin", "")) + Opciones.Folder.ROOTIMAGE;
            
            //Validar si existe la carpeta
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            try
            {
                if (File.Exists(path + Opciones.Folder.LOGOPERSONAL))
                {
                    DialogResult result = MessageBox.Show("El archivo ya existe. ¿Desea Remplazarlo?", "Ya existe", MessageBoxButtons.OKCancel);

                    if (result == DialogResult.OK)
                    {
                        File.Delete(path + Opciones.Folder.LOGOPERSONAL);
                        File.Copy(file.FileName, path + file.SafeFileName);
                        File.Move(path + file.SafeFileName, path + Opciones.Folder.LOGOPERSONAL);
                        return true;
                    }

                    return false;
                }
                else
                {
                    File.Copy(file.FileName, path + file.SafeFileName);
                    File.Move(path + file.SafeFileName, path + Opciones.Folder.LOGOPERSONAL);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static public bool borrarImagen(Producto producto, TextBox txtImagen)
        {
            try
            {
                producto.ImagenURL = "";
                txtImagen.Text = "";

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }

        }

        public static void cargarimagen(PictureBox pictureBox, string image)
        {
            try
            {
                pictureBox.Load(image);
            }
            catch (Exception)
            {
                string path = Path.GetDirectoryName(Directory.GetCurrentDirectory().Replace(@"\bin", "")) + Opciones.Folder.ROOTIMAGE;
                pictureBox.Load(path + Opciones.Folder.PLACEHOLDER);
            }
        }

        public static void vaciarTextBox(List<TextBox> lista)
        {
            foreach (var item in lista)
            {
                item.Text = string.Empty;
            }
        }

        public static void mostrarErrorCampoVacio(List<TextBox> listaTextBox, List<Label> listaLabel)
        {
            List<bool> boolsTxt = Validacion.estaVacio(listaTextBox);

            if (boolsTxt.Contains(true))
            {
                for (int i = 0; i < listaTextBox.Count(); i++)
                {
                    if (boolsTxt[i])
                    {
                        listaLabel[i].Visible = boolsTxt[i];
                        agregarToolTip(listaLabel[i], "Todos los campos son obligatorios");
                    }
                }
            }
        }

        public static void agregarToolTip(Label label, string msg)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(label, msg);
        }

        public static void errorInvisible(List<Label> listaLabel)
        {
            foreach (var item in listaLabel)
            {
                item.Visible = false;
            }
        }

        public static void disableComboBox(ComboBox combo)
        {
            combo.DropDownStyle = ComboBoxStyle.Simple;
            combo.Enabled = false;
        }

        public static void enableComboBox(ComboBox combo)
        {
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.Enabled = true;
        }

        public static void textBoxReadOnly(List<TextBox> lista, bool read = true)
        {
            if(read)
            {
                foreach (var txt in lista)
                {
                    txt.ReadOnly = true;
                }
            }
            else
            {
                foreach (var txt in lista)
                {
                    txt.ReadOnly = false;
                }
            }
        }

        public static void buscarEnLista<T>(List<T> listaCategoria, ComboBox combo, Button btn)
        {
            if ((listaCategoria.Any(x => x.ToString() == combo.Text)) && !string.IsNullOrEmpty(combo.Text))
            {
                btn.Visible = true;
            }
            else
            {
                btn.Visible = false;
            }
        }
    }
}
