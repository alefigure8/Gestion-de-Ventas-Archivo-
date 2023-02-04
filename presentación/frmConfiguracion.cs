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

            configuracionGUI();
        }

        private void cargarImagenes()
        {
            string path = Path.GetDirectoryName(Directory.GetCurrentDirectory()) + Opciones.Folder.ROOTIMAGE;

            if (File.Exists(path + Opciones.Folder.LOGOPERSONAL))
                Metodos.cargarimagen(picLogoEmpresa, path + Opciones.Folder.LOGOPERSONAL);
            else
                Metodos.cargarimagen(picLogoEmpresa, path + Opciones.Folder.LOGO);
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            file = new OpenFileDialog();
            file.Filter = "All|*|Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff|Wmf Image (.wmf)|*.wmf";

            if (file.ShowDialog() == DialogResult.OK)
            {
                try
                {                   
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
                    string path = Path.GetDirectoryName(Directory.GetCurrentDirectory()) + Opciones.Folder.ROOTIMAGE;
                                       
                    //Guardar imagen nueva
                    if (Metodos.guardarLogo(file))
                    {
                        Metodos.cargarimagen(parent.picLogoEmpresa, path + Opciones.Folder.LOGOPERSONAL);
                        MessageBox.Show("La imagen se ha guardado satisfactoriamente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnLogo.Text == Opciones.Btn.SINLOGO)
                Metodos.logoTransparente(parent.picLogoEmpresa);
            else
                Metodos.defaultLogo(parent.picLogoEmpresa);

            configuracionGUI();
        }

        private void configuracionGUI()
        {
            string path = Path.GetDirectoryName(Directory.GetCurrentDirectory()) + Opciones.Folder.ROOTIMAGE;

            if (File.Exists(path + Opciones.Folder.NOLOGO))
                btnLogo.Text = Opciones.Btn.CONLOGO;
            else
                btnLogo.Text = Opciones.Btn.SINLOGO;
        }
    }
}
