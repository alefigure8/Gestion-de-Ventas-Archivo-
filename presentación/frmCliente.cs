using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using configuracion;
using dominio;
using negocio;

namespace presentación
{
    public partial class frmCliente : Form
    {
        public int idCliente { get; set; }
        public string cliente { get; set; }

        private List<Cliente> listaCLiente;
        private List<Cliente> listaResultados;
        private ClienteNegocio clienteNegocio;
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            idCliente = 0;
            clienteNegocio = new ClienteNegocio();
            listaResultados = new List<Cliente>();
            cargarListaCliente();
            cargarGridView();
        }

        private void cargarGridView(bool busqueda = false)
        {
            if (!busqueda)
                dvgClientes.DataSource = listaCLiente;
            else
                dvgClientes.DataSource = listaResultados;

            dvgClientes.Columns[Opciones.Campo.ID].Visible = false;
            dvgClientes.Columns[Opciones.Campo.ACTIVO].Visible = false;
            dvgClientes.EnableHeadersVisualStyles = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            List<TextBox> listaTxt = new List<TextBox>()
            {
                txtClienteNombre,
                txtClienteApellido,
                txtClienteEmpresa
            };

            if(helper.Validacion.estaVacio(listaTxt).All(x => x == true))
            {
                MessageBox.Show("Al menos un campo debe contenter información");
                return;
            }

            cliente.Nombre = txtClienteNombre.Text;
            cliente.Apellido = txtClienteApellido.Text;
            cliente.Empresa = txtClienteEmpresa.Text;

            try
            {
                if(clienteNegocio.Agregar(cliente))
                {
                    MessageBox.Show("El cliente se guardó existosamente");
                    cargarListaCliente();
                    limpiarGridView();
                    cargarGridView();
                    limpiarCargarCliente();
                }
                else
                    MessageBox.Show("Error al guardar al cliente");

            }
            catch (Exception)
            {

                MessageBox.Show("Error al guardar al cliente");
            }
        }

        private void limpiarCargarCliente()
        {
            txtClienteNombre.Text = "";
            txtClienteApellido.Text = "";
            txtClienteEmpresa.Text = "";
        }

        private void dvgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente aux = (Cliente)dvgClientes.CurrentRow.DataBoundItem;
            idCliente = aux.Id;
            string nombre = $"{aux.Nombre} {aux.Apellido}";
            cliente = string.IsNullOrEmpty(aux.Empresa) ? nombre : aux.Empresa;
            this.Close();
        }

        private void txtClienteBuscar_TextChanged(object sender, EventArgs e)
        {
            string filter = txtClienteBuscar.Text;
            if (!string.IsNullOrEmpty(filter))
            {
                listaResultados.Clear();
                listaResultados = listaCLiente.FindAll(cli => cli.Nombre.ToLower().Contains(filter.ToLower()) || cli.Apellido.ToLower().Contains(filter.ToLower()) || cli.Empresa.ToLower().Contains(filter.ToLower()));
                limpiarGridView();
                cargarGridView(true);
            }
            else
            {
                listaResultados.Clear();
                limpiarGridView();
                cargarGridView();
            }
        }

        private void cargarListaCliente()
        {
            listaCLiente = clienteNegocio.Listar();
        }

        private void limpiarGridView()
        {
            dvgClientes.DataSource = null;
        }
        //Busqueda de cliente
        //Agregar cliente al archivo y actualizar el data grid
        //Doble click en data grid view para colocarlo en el text box de cliente
    }
}
