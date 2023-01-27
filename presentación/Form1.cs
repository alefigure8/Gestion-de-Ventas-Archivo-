using configuracion;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace presentación
{
    public partial class presentacion : Form
    {

        public presentacion()
        {
            InitializeComponent();
            LoadPresentacion();
        }

        private void LoadPresentacion()
        {
            //frmPrincipal screen = new frmPrincipal(this);
            frmVentas screen = new frmVentas();
            screen.MdiParent = this;
            screen.Show();
            propiedadesBtn();
            cargarFecha(); 
            cargarImagenes();
        }

        private void cargarFecha()
        {
            lbFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void cargarImagenes()
        {
            string path = Path.GetDirectoryName(Directory.GetCurrentDirectory().Replace(@"\bin", "")) + Opciones.Folder.ROOTIMAGE;

            //Icono
            picLogo.Image = Image.FromFile(path + Opciones.Folder.ICONO);

            //Logo
            if(File.Exists(path + Opciones.Folder.LOGOPERSONAL))
                picLogoEmpresa.Image = Image.FromFile(path + Opciones.Folder.LOGOPERSONAL);
            else
                picLogoEmpresa.Image = Image.FromFile(path + Opciones.Folder.LOGO);

            this.Icon = new Icon(path + Opciones.Folder.ICONO);

            //Boton cerrar aplicación
            btnCerrar.Image = (Image)new Bitmap(path + Opciones.Folder.CERRAR);
            int sourceWidth = btnCerrar.Image.Width;
            int sourceHeight = btnCerrar.Image.Height;
            Bitmap b = new Bitmap(30, 30);

            using (Graphics g = Graphics.FromImage((Image)b))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(btnCerrar.Image, 0, 0, 30, 30);
            }
            Image myResizedImg = (Image)b;
            btnCerrar.Image = myResizedImg;

            //Boton Configuración
            btnConfiguracion.Image = (Image)new Bitmap(path + Opciones.Folder.CONFIGURACIONHOME);
            int sourceWidthBtnConfigure = btnConfiguracion.Image.Width;
            int sourceHeightBtnConfigure = btnConfiguracion.Image.Height;
            Bitmap c = new Bitmap(30, 30);

            using (Graphics g = Graphics.FromImage((Image)c))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(btnConfiguracion.Image, 0, 0, 30, 30);
            }
            Image myResizedImgbtnConfigure = (Image)c;
            btnConfiguracion.Image = myResizedImgbtnConfigure;
        }

        protected override void OnLoad(EventArgs e)
        {
            //Remover Bordes MDIContainer
            var mdiclient = this.Controls.OfType<MdiClient>().Single();
            this.SuspendLayout();
            mdiclient.SuspendLayout();
            var hdiff = mdiclient.Size.Width - mdiclient.ClientSize.Width;
            var vdiff = mdiclient.Size.Height - mdiclient.ClientSize.Height;
            var size = new Size(mdiclient.Width + hdiff, mdiclient.Height + vdiff);
            var location = new Point(mdiclient.Left - (hdiff / 2), mdiclient.Top - (vdiff / 2));
            mdiclient.Dock = DockStyle.None;
            mdiclient.Size = size;
            mdiclient.Location = location;
            mdiclient.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
            mdiclient.ResumeLayout(true);
            this.ResumeLayout(true);
            base.OnLoad(e);

            //Remover Menu MDIContainer
            this.MainMenuStrip = new MenuStrip();
            this.MainMenuStrip.Visible = false;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout screen = new frmAbout();
            screen.MdiParent = this;
            screen.Show();
            propiedadesBtn();
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            frmPrincipal screen = new frmPrincipal(this);
            screen.MdiParent = this;
            screen.Show();
            propiedadesBtn();
        }

        private void btnPresupuesto_Click(object sender, EventArgs e)
        {
            frmPresupuesto screen = new frmPresupuesto();
            screen.MdiParent = this;
            screen.Show();
            propiedadesBtn();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmVentas screen = new frmVentas();
            screen.MdiParent = this;
            screen.Show();
            propiedadesBtn();
        }

        private void btnEstadistica_Click(object sender, EventArgs e)
        {
            frmEstadistica screen = new frmEstadistica(this);
            screen.MdiParent = this;
            screen.Show();
            propiedadesBtn();
        }

        private void propiedadesBtn()
        {
            Color btnNonSelected = Color.FromArgb(38,62,79);
            Color btnSelected = Color.FromArgb(27, 44, 56);

            foreach (var views in this.MdiChildren)
            {
                if (views is frmPrincipal)
                {
                    panelBtnAbout.Visible = false;
                    panelBtnPresupuesto.Visible = false;
                    panelBtnPrincipal.Visible = true;
                    panelBtnVentas.Visible = false;
                    panelBtnEstadistica.Visible = false;
                    btnEstadistica.BackColor = btnNonSelected;
                    btnPresupuesto.BackColor = btnNonSelected;
                    btnAbout.BackColor = btnNonSelected;
                    btnVentas.BackColor = btnNonSelected;
                    btnCatalogo.BackColor = btnSelected;
                }
                else if(views is frmAbout)
                {
                    panelBtnAbout.Visible = true;
                    panelBtnPrincipal.Visible = false;
                    panelBtnPresupuesto.Visible = false;
                    panelBtnVentas.Visible = false;
                    panelBtnEstadistica.Visible = false;
                    btnEstadistica.BackColor = btnNonSelected;
                    btnPresupuesto.BackColor = btnNonSelected;
                    btnAbout.BackColor = btnSelected;
                    btnVentas.BackColor = btnNonSelected;
                    btnCatalogo.BackColor = btnNonSelected;
                }
                else if(views is frmPresupuesto)
                {
                    panelBtnAbout.Visible = false;
                    panelBtnPresupuesto.Visible = true;
                    panelBtnPrincipal.Visible = false;
                    panelBtnVentas.Visible = false;
                    panelBtnEstadistica.Visible = false;
                    btnEstadistica.BackColor = btnNonSelected;
                    btnPresupuesto.BackColor = btnSelected;
                    btnAbout.BackColor = btnNonSelected;
                    btnVentas.BackColor = btnNonSelected;
                    btnCatalogo.BackColor = btnNonSelected;
                }
                else if (views is frmVentas)
                {
                    panelBtnEstadistica.Visible = false;
                    panelBtnAbout.Visible = false;
                    panelBtnPresupuesto.Visible = false;
                    panelBtnPrincipal.Visible = false;
                    panelBtnVentas.Visible = true;
                    btnEstadistica.BackColor = btnNonSelected;
                    btnPresupuesto.BackColor = btnNonSelected;
                    btnAbout.BackColor = btnNonSelected;
                    btnCatalogo.BackColor = btnNonSelected;
                    btnVentas.BackColor = btnSelected;

                }
                else if (views is frmEstadistica)
                {
                    panelBtnAbout.Visible = false;
                    panelBtnPresupuesto.Visible = false;
                    panelBtnPrincipal.Visible = false;
                    panelBtnVentas.Visible = false;
                    panelBtnEstadistica.Visible = true;
                    btnEstadistica.BackColor = btnSelected;
                    btnPresupuesto.BackColor = btnNonSelected;
                    btnAbout.BackColor = btnNonSelected;
                    btnCatalogo.BackColor = btnNonSelected;
                    btnVentas.BackColor = btnNonSelected;

                }
                else
                {
                    panelBtnAbout.Visible = false;
                    panelBtnPresupuesto.Visible = false;
                    panelBtnPrincipal.Visible = false;
                    panelBtnVentas.Visible = false;
                    panelBtnEstadistica.Visible = false;
                    btnEstadistica.BackColor = btnNonSelected;
                    btnPresupuesto.BackColor = btnNonSelected;
                    btnAbout.BackColor = btnNonSelected;
                    btnCatalogo.BackColor = btnNonSelected;
                    btnVentas.BackColor = btnNonSelected;
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            backUpArchivos();
            this.Close();
        }

        private void backUpArchivos()
        {
            // Paths
            string original = Application.LocalUserAppDataPath + Opciones.Folder.DATABASE;
            string backup = Application.LocalUserAppDataPath + Opciones.Folder.DATABASEBACKUP;

            // Si no existe la carpeta se crea.
            if (!Directory.Exists(backup))
            {
                Directory.CreateDirectory(backup);
            }

            try
            {
                if (File.Exists(original + Opciones.Folder.DATA))
                {
                    if (File.Exists(backup + Opciones.Folder.DATA))
                        File.Delete(backup + Opciones.Folder.DATA);

                    File.Copy(original + Opciones.Folder.DATA, backup + Opciones.Folder.DATA);
                }

                if (File.Exists(original + Opciones.Folder.DATAMARCA))
                {
                    if (File.Exists(backup + Opciones.Folder.DATAMARCA))
                        File.Delete(backup + Opciones.Folder.DATAMARCA);

                    File.Copy(original + Opciones.Folder.DATAMARCA, backup + Opciones.Folder.DATAMARCA);
                }

                if (File.Exists(original + Opciones.Folder.DATACATEGORIA))
                {
                    if (File.Exists(backup + Opciones.Folder.DATACATEGORIA))
                        File.Delete(backup + Opciones.Folder.DATACATEGORIA);

                    File.Copy(original + Opciones.Folder.DATACATEGORIA, backup + Opciones.Folder.DATACATEGORIA);
                }

                if (File.Exists(original + Opciones.Folder.VENTAS))
                {
                    if (File.Exists(backup + Opciones.Folder.VENTAS))
                        File.Delete(backup + Opciones.Folder.VENTAS);

                    File.Copy(original + Opciones.Folder.VENTAS, backup + Opciones.Folder.VENTAS);
                }

                if (File.Exists(original + Opciones.Folder.CLIENTE))
                {
                    if (File.Exists(backup + Opciones.Folder.CLIENTE))
                        File.Delete(backup + Opciones.Folder.CLIENTE);

                    File.Copy(original + Opciones.Folder.CLIENTE, backup + Opciones.Folder.CLIENTE);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            frmConfiguracion screen = new frmConfiguracion(this);
            screen.MdiParent = this;
            screen.Show();
            propiedadesBtn();
        }
    }
}
