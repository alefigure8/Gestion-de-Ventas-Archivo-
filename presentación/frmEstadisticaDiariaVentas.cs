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
    public partial class frmEstadisticaDiariaVentas : Form
    {
        List<Ventas> listaVentas;
        List<Cliente> listaCliente;
        Ventas aux = null;
        private int id;

        public frmEstadisticaDiariaVentas(string id)
        {
            InitializeComponent();

            //Configuraciones
            this.id = int.Parse(id);
        }

        private void frmEstadisticaDiariaVentas_Load(object sender, EventArgs e)
        {
            cargarListas();
            buscarVenta();
            cargarGridView();
            cargarGUI();
        }

        private void cargarGridView()
        {
            if (aux != null)
            {
                //Cargar grid
                dgvProductos.DataSource = aux.Venta;

                //Opciones de columnas
                dgvProductos.Columns[Opciones.Campo.ID].Visible = false;
                dgvProductos.Columns[Opciones.Campo.URLIMAGEN].Visible = false;
               // dgvProductos.Columns[Opciones.Campo.MARCA].Visible = false;
                dgvProductos.Columns[Opciones.Campo.COSTO].Visible = false;
                dgvProductos.Columns[Opciones.Campo.CREADO].Visible = false;
                dgvProductos.Columns[Opciones.Campo.MODIFICADO].Visible = false;
                dgvProductos.Columns[Opciones.Campo.STOCK].Visible = false;

                //Mover columnas al final
                dgvProductos.Columns["Cantidad"].DisplayIndex = 10;
                dgvProductos.Columns["Total"].DisplayIndex = 11;

                //Opciones visuales
                dgvProductos.EnableHeadersVisualStyles = false;
            }
        }

        private void cargarListas()
        {
            VentaNegocio ventaNegocio = new VentaNegocio();
            listaVentas = ventaNegocio.listar();
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            listaCliente = clienteNegocio.Listar();
        }

        private void buscarVenta()
        {
            aux = listaVentas.Find(x => x.Id == id);
        }

        private void cargarGUI()
        {
            //Numero de venta
            lbNumeroVentaTitulo.Text = $"Venta Número: {id.ToString()}";

            if(aux != null)
            {
                //Cliente
                Cliente auxCliente = listaCliente.Find(x => x.Id == aux.id_cliente);
               if(auxCliente != null)
                {
                    string cliente = auxCliente.Empresa == "" ? $"{auxCliente.Nombre} {auxCliente.Apellido}" : auxCliente.Empresa;
                    lbClienteNombre.Text = cliente;
                }
               else
                {
                    lbClienteNombre.Text = "Cliente Ocasional";
                }

                //Precio Total
                lbTotalPrecio.Text = (aux.Total - ((aux.Descuento / 100) * (aux.Total + (aux.Impuesto / 100) * aux.Total)) + ((aux.Impuesto / 100) * aux.Total)).ToString("c");

                //Impuesto
                lbImpuestoTotal.Text = ((aux.Total - (aux.Total * (aux.Descuento / 100))) * (aux.Impuesto / 100)).ToString("c");

                //Descuento
                lbDescuentoTotal.Text = (aux.Total * (aux.Descuento / 100)).ToString("c");

                //Tarjeta o Credito
                string tarjetoEfectivo = aux.Credit ? "Crédito" : "Efectivo";
                lbTarjetaOEfectivo.Text = tarjetoEfectivo;

                if(tarjetoEfectivo == "Crédito")
                {
                    lbTarjetaOEfectivo.ForeColor = Color.Gold;
                }
                else
                {
                    lbTarjetaOEfectivo.ForeColor = Color.LightGreen;

                }

                //Fecha
                lbFecha.Text = aux.Fecha.ToString("dd/MM/yyyy");
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
