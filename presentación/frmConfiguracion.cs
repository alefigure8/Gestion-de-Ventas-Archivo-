using configuracion;
using dominio;
using helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace presentación
{
    public partial class frmConfiguracion : Form
    {
        private OpenFileDialog file = null;
        presentacion parent;
   
        public frmConfiguracion(presentacion parent)
        {
            InitializeComponent();
            cargarImagenes();    
            this.parent = parent;
        }

        private void cargarImagenes()
        {
            string path = Path.GetDirectoryName(Directory.GetCurrentDirectory().Replace(@"\bin", "")) + Opciones.Folder.ROOTIMAGE;

            if (File.Exists(path + Opciones.Folder.LOGOPERSONAL))
                picLogoEmpresa.Image = System.Drawing.Image.FromFile(path + Opciones.Folder.LOGOPERSONAL);
            else
                picLogoEmpresa.Image = System.Drawing.Image.FromFile(path + Opciones.Folder.LOGO);
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {

            file = new OpenFileDialog();
            file.Filter = "All|*|Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff|Wmf Image (.wmf)|*.wmf";

            if (file.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picLogoEmpresa.Image.Dispose();
                    Metodos.cargarimagen(picLogoEmpresa, file.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("La iamgen no pudo ser cargada");
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Copir imagen cargada desde Archivos
            if (file != null)
            {
                try
                {
                    string path = Path.GetDirectoryName(Directory.GetCurrentDirectory().Replace(@"\bin", "")) + Opciones.Folder.ROOTIMAGE;

                    //Borrar imagen actual
                    System.Drawing.Image pic = parent.picLogoEmpresa.Image;
                    pic.Dispose();

                    //Guardar imagen nueva
                    if (Metodos.guardarLogo(file))
                    {
                        Metodos.cargarimagen(parent.picLogoEmpresa, path + Opciones.Folder.LOGOPERSONAL);
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Error al cargar la imagen");
                }
            }
        }
    }
}
