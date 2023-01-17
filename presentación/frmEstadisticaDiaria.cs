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
    public partial class frmEstadisticaDiaria : Form
    {
        List<Ventas> listaVentasActuales;
        DateTime fechaActual;
        Decimal VentaTotal = Decimal.Zero;
        public frmEstadisticaDiaria()
        {
            InitializeComponent();
        }

        private void frmEstadisticaDiaria_Load(object sender, EventArgs e)
        {
            //Cargar la fecha actual
            cargarFechaActual();

            //cargar Ventas
            listaVentasActuales = cargarVentas();

            //Cargar grid
            cargarGridView();

            //Cargar interfaz gráfica
            CargarGUI();

            //Cargar Categoria
            categoriaSemanal();
        }

        private void cargarFechaActual()
        {
            fechaActual = DateTime.Now;
        }

        private void CargarGUI()
        {
            lbVentasTotal.Text = $"Ventas del {fechaActual.ToString("dd/MM/yyyy")}";
            lbVentasTotales.Text = VentaTotal.ToString("c");
            lbVentasCantidad.Text = listaVentasActuales.Count.ToString();
            lbVentasPromedio.Text = (VentaTotal / listaVentasActuales.Count).ToString("c");
        }

        private List<Ventas> cargarVentas()
        {
            VentaNegocio ventaNegocio = new VentaNegocio();
            List<Ventas> listaVentas = ventaNegocio.listar().FindAll(x=> x.Fecha.ToString("dd/MM/yyyy") == fechaActual.ToString("dd/MM/yyyy"));

            return listaVentas;
        }

        private void cargarGridView()
        {
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            List<Cliente> cliente = clienteNegocio.Listar();
            
            dgvVentas.Columns.Add("Posicion", "Venta");
            dgvVentas.Columns["Posicion"].DisplayIndex = 0;

            dgvVentas.Columns.Add("Precio", "Precio");
            dgvVentas.Columns["Precio"].DisplayIndex = 1;

            dgvVentas.Columns.Add("Cliente", "Cliente");
            dgvVentas.Columns["Cliente"].DisplayIndex = 2;

            dgvVentas.Columns.Add("Id", "Id");
            dgvVentas.Columns["Id"].DisplayIndex = 3;
            dgvVentas.Columns["Id"].Visible = false;


            for (int i = 0; i < listaVentasActuales.Count; i++)
            {
                //Nombre o empresa
                Cliente clienteEncontrado = cliente.Find(x => x.Id == listaVentasActuales[i].id_cliente);
                string rowCliente = string.Empty;

                if (clienteEncontrado != null)
                    rowCliente = string.IsNullOrEmpty(clienteEncontrado.Empresa) ? $"{clienteEncontrado.Nombre} {clienteEncontrado.Apellido}" : clienteEncontrado.Empresa;
                else
                    rowCliente = "Cliente Ocasional";

                var index = dgvVentas.Rows.Add();

                //Posicion
                dgvVentas.Rows[index].Cells["Posicion"].Value = i + 1;
                dgvVentas.Rows[index].Cells["Posicion"].Style.ForeColor = Color.Black;

                //Precio
                dgvVentas.Rows[index].Cells["Precio"].Value = listaVentasActuales[i].Total.ToString("c");
                dgvVentas.Rows[index].Cells["Precio"].Style.ForeColor = Color.Black;

                //Cliente
                dgvVentas.Rows[index].Cells["Cliente"].Value = rowCliente;
                dgvVentas.Rows[index].Cells["Cliente"].Style.ForeColor = Color.Black;

                //Id
                dgvVentas.Rows[index].Cells["Id"].Value = listaVentasActuales[i].Id;

                //Total Ventas
                VentaTotal += listaVentasActuales[i].Total;

            }

            dgvVentas.EnableHeadersVisualStyles = false;
        }

        private void categoriaSemanal()
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            List<Categoria> listaCategorias = categoriaNegocio.listar();

            //Por cada Categoria
            for (int i = 0; i < listaCategorias.Count; i++)
            {

                decimal ventaTotalCategoria = 0;

                //Por cada ventas
                foreach (var ventas in listaVentasActuales)
                {

                    //Por cada venta de Ventas
                    foreach (var venta in ventas.Venta)
                    {
                        if (venta.CategoriaInfo.Descripcion == listaCategorias[i].Descripcion)
                        {
                            ventaTotalCategoria += venta.Total;
                        }
                    }
                }

                double porcentajeCategoria = (decimal.ToDouble(ventaTotalCategoria) * 100) / decimal.ToDouble(VentaTotal);
                chartSemanalCategoria.Series["Categorias"].Points.AddXY(i, porcentajeCategoria);
                chartSemanalCategoria.Series["Categorias"].Points[i].Label = listaCategorias[i].Descripcion;
                chartSemanalCategoria.Series["Categorias"].Points[i].LabelForeColor = Color.WhiteSmoke;

                //Si el promedio es 0, no se coloca en el gráfico
                if (porcentajeCategoria <= 0)
                {
                    chartSemanalCategoria.Series["Categorias"].Points[i].LabelForeColor = Color.Transparent;
                }

            }
        }
    }
}
