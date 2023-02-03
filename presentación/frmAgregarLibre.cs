using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using helper;

namespace presentación
{
    public partial class frmAgregarLibre: Form
    {
        public Producto producto { get; set; }

        List<Label> listaLabels;
        public frmAgregarLibre()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Listado de booleans en caso de que haya textBox vacíos
            List<bool> estaVacio = Validacion.estaVacio(new List<TextBox>()
            {
                txtAgregarArticulo,
                txtAgregarDescripcion
            });

            if (estaVacio.Contains(true) || !Validacion.esNumero(txtAgregarPrecio.Text))
            {
                for (int i = 0; i < estaVacio.Count; i++)
                {
                    listaLabels[i].Visible = estaVacio[i];
                }
            }
            else
            {
                producto = new Producto();
                producto.Id = 0;
                producto.Codigo = "LIBRE";
                producto.Nombre = txtAgregarArticulo.Text;
                producto.Descripcion = txtAgregarDescripcion.Text;
                producto.Precio = decimal.Parse(txtAgregarPrecio.Text);

                this.Close();
            }
        }

        private void frmAgregarLibre_Load(object sender, EventArgs e)
        {
            listaLabels = new List<Label> { lbErrorArticulo, lbErrorDescripcion, lbErrorPrecio };

            // Colocar imagenes de error como invisibles
            Metodos.errorInvisible(listaLabels);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
