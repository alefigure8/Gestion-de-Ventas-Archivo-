using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using configuracion;
using dominio;
using Microsoft.Office.Interop.Excel;
using Microsoft.Vbe.Interop;
using negocio;

namespace presentación
{
    public partial class frmEstadisticaDiaria : Form
    {
        List<Ventas> listaVentasActuales;
        DateTime fechaActual;
        Decimal VentaTotal = Decimal.Zero;
        Decimal ventaEfectivo = Decimal.Zero;
        Decimal ventaTarjeta = Decimal.Zero;

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

            //Cargar imagenes
            cargarImagenes();
        }

        private void cargarFechaActual()
        {
            fechaActual = DateTime.Now;
        }

        private void cargarImagenes()
        {
            string path = Path.GetDirectoryName(Directory.GetCurrentDirectory().Replace(@"\bin", "")) + Opciones.Folder.ROOTIMAGE;
            btnPrinter.Load(path + Opciones.Folder.IMPRIMIR);
            btnFile.Load(path + Opciones.Folder.GUARDARARCHIVO);
        }

        private void CargarGUI()
        {
            cargarTotales();

            lbVentasTotal.Text = $"Ventas del {fechaActual.ToString("dd/MM/yyyy")}";

            if(listaVentasActuales.Count > 0)
            {
                lbVentasTotales.Text = VentaTotal.ToString("c");
                lbVentasCantidad.Text = listaVentasActuales.Count.ToString();
                lbVentasPromedio.Text = (VentaTotal / listaVentasActuales.Count).ToString("c");
                lbVentasEfectivo.Text = ventaEfectivo.ToString("c");
                lbVentasTarjeta.Text = ventaTarjeta.ToString("c");
            }
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
                decimal total = listaVentasActuales[i].Total - ((listaVentasActuales[i].Descuento / 100) * (listaVentasActuales[i].Total + (listaVentasActuales[i].Impuesto / 100) * listaVentasActuales[i].Total)) + ((listaVentasActuales[i].Impuesto / 100) * listaVentasActuales[i].Total);
                dgvVentas.Rows[index].Cells["Precio"].Value = total.ToString("c");
                dgvVentas.Rows[index].Cells["Precio"].Style.ForeColor = Color.Black;

                //Cliente
                dgvVentas.Rows[index].Cells["Cliente"].Value = rowCliente;
                dgvVentas.Rows[index].Cells["Cliente"].Style.ForeColor = Color.Black;

                //Id
                dgvVentas.Rows[index].Cells["Id"].Value = listaVentasActuales[i].Id;

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

        private void cargarTotales()
        {
            for(int i = 0; i < listaVentasActuales.Count; i++)
            {
                //Total Ventas
                VentaTotal += listaVentasActuales[i].Total;

                if (listaVentasActuales[i].Credit)
                {
                    ventaTarjeta += listaVentasActuales[i].Total;
                }
                else
                {
                    ventaEfectivo += listaVentasActuales[i].Total;
                }

            }
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataRow = dgvVentas.Rows[e.RowIndex].Cells["Id"].Value;
           

            frmEstadisticaDiariaVentas screen = new frmEstadisticaDiariaVentas(dataRow.ToString());
            screen.ShowDialog();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {

            using (SaveFileDialog saveDialog = new SaveFileDialog() { Filter = "Excel|*.xlsx", Title = "Guardar Ventas Diarias", FileName = $"Venta Diarias - {DateTime.Now.ToString("dddd, dd MMMM yyyy")}" })
            {
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {

                    //Configuraciones Workbooks
                    string fileName = saveDialog.FileName;
                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)excel.ActiveSheet;
                    excel.Visible = false;

                    //Inicio de fila
                    int index = 2;

                    //Range
                    Range formatRange;

                    //Header
                    formatRange = ws.get_Range("a1", $"f1");
                    formatRange.BorderAround(XlLineStyle.xlContinuous,
                    XlBorderWeight.xlMedium, XlColorIndex.xlColorIndexAutomatic,
                    XlColorIndex.xlColorIndexAutomatic);
                    formatRange.Interior.Color = ColorTranslator.ToOle(Color.LightGray);
                    formatRange.Font.Bold = true;

                    ws.Cells[1, 1] = "Código";
                    ws.Cells[1, 2] = "Nombre";
                    ws.Cells[1, 3] = "Descripción";
                    ws.Cells[1, 4] = "Categoria";
                    ws.Cells[1, 5] = "Cantidad";
                    ws.Cells[1, 6] = "Precio Total";

                    //Guardar en archivos
                    List<Struct.ventaPorProducto> listaPorProducto = cargarListaProducto();

                    foreach (var venta in listaPorProducto)
                    {
                        //TODO UNIFICAR PRODUCTOS
                        ws.Cells[index, 1] = venta.Codigo;
                        ws.Cells[index, 2] = venta.Nombre;
                        ws.Cells[index, 3] = venta.Descripcion;
                        ws.Cells[index, 4] = venta.Categoria;
                        ws.Cells[index, 5] = venta.Cantidad;
                        ws.Cells[index, 6] = Math.Round(venta.Total, 2);
                        index++;
                    }

                    ws.Cells[index, 6] = Math.Round(VentaTotal, 2);

                    //Guardar
                    try
                    {
                        ws.SaveAs(fileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                        MessageBox.Show("El archivo se ha guardado con éxito");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("El archivo no se pudo guardar");
                    }
                    excel.Quit();

                }
            }
        }

        private void btnPrinter_Click(object sender, EventArgs e)
        {
            printProdcuctosDiario = new PrintDocument();
            PrinterSettings printerSetting = new PrinterSettings();
            printProdcuctosDiario.PrinterSettings = printerSetting;
            printProdcuctosDiario.PrintPage += printPresupuesto_PrintPage;

            PrintPreviewDialog printPreview = new PrintPreviewDialog();
            string path = Path.GetDirectoryName(Directory.GetCurrentDirectory().Replace(@"\bin", "")) + Opciones.Folder.ROOTIMAGE;
            printPreview.Icon = new System.Drawing.Icon(path + Opciones.Folder.ICONO);
            printPreview.MinimumSize = new Size(375, 250);
            printPreview.SetBounds(100, -550, 800, 800);
            printPreview.Document = printProdcuctosDiario;

            printPreview.ShowDialog();
        }

        private void printPresupuesto_PrintPage(object sender, PrintPageEventArgs e)
        {

            //Crear lista por producto
            List<Struct.ventaPorProducto> listaPorProducto = cargarListaProducto();

            System.Drawing.Font font = new System.Drawing.Font("Tahoma", 14, FontStyle.Bold);
            System.Drawing.Font fontProductos = new System.Drawing.Font("Tahoma", 14);
            System.Drawing.Font fontProductosBold = new System.Drawing.Font("Tahoma", 14, FontStyle.Bold);
            int width = 800;
            int y = 150;

            //Headers
            e.Graphics.DrawString("CODIGO", fontProductosBold, Brushes.Black, new RectangleF(40, y, width, 40));
            e.Graphics.DrawString("NOMBRE", fontProductosBold, Brushes.Black, new RectangleF(140, y, width, 40));
            e.Graphics.DrawString("DESCR.", fontProductosBold, Brushes.Black, new RectangleF(350, y, width, 40));
            e.Graphics.DrawString("UNI.", fontProductosBold, Brushes.Black, new RectangleF(650, y, width, 40));
            e.Graphics.DrawString("TOTAL", fontProductosBold, Brushes.Black, new RectangleF(700, y, width, 40));

            //Body
            y += 40;
            foreach (var item in listaPorProducto)
            {
                y += 20;
                e.Graphics.DrawString($"{item.Codigo}", fontProductos, Brushes.Black, new RectangleF(40, y, 100, 20));
                e.Graphics.DrawString($"{item.Nombre}", fontProductos, Brushes.Black, new RectangleF(140, y, 200, 20));
                e.Graphics.DrawString($"{item.Descripcion}", fontProductos, Brushes.Black, new RectangleF(350, y, 300, 20));
                e.Graphics.DrawString($"{item.Cantidad}", fontProductos, Brushes.Black, new RectangleF(650, y, 100, 20));
                e.Graphics.DrawString($"{item.Total}", fontProductos, Brushes.Black, new RectangleF(700, y, 100, 20));
            }

            //Total
            y += 40;
            e.Graphics.DrawString($"TOTAL: {Math.Round(VentaTotal, 2)}", font, Brushes.Black, new RectangleF(650, y, width, 40));
        }

        private List<Struct.ventaPorProducto> cargarListaProducto()
        {
            //Crear lista por producto
            List<Struct.ventaPorProducto> listaPorProducto = new List<Struct.ventaPorProducto>();

            //Por cada Ventas
            foreach (var ventas in listaVentasActuales)
            {
                //Por cada venta
                foreach (var venta in ventas.Venta)
                {

                    if (listaPorProducto.Exists(x => x.Id == venta.Id))
                    {
                        Struct.ventaPorProducto aux = new Struct.ventaPorProducto();

                        //Modifica el item que es igual
                        aux = listaPorProducto.Find(x => x.Id == venta.Id);
                        aux.Cantidad += venta.Cantidad;
                        aux.Total += venta.Total;

                        //Lista auxiliar sin el producto anterior
                        List<Struct.ventaPorProducto> auxListaProProdcuto = new List<Struct.ventaPorProducto>();
                        auxListaProProdcuto = listaPorProducto.FindAll(x => x.Id != venta.Id);
                        auxListaProProdcuto.Add(aux);

                        listaPorProducto.Clear();
                        listaPorProducto = auxListaProProdcuto;

                    }
                    else
                    {
                        //Creamos un nuevo elemento para la lista
                        Struct.ventaPorProducto aux = new Struct.ventaPorProducto();
                        aux.Id = venta.Id;
                        aux.Codigo = venta.Codigo;
                        aux.Nombre = venta.Nombre;
                        aux.Descripcion = venta.Descripcion;
                        aux.Categoria = venta.CategoriaInfo.Descripcion;
                        aux.Cantidad = venta.Cantidad;
                        aux.Total = venta.Total;

                        listaPorProducto.Add(aux);
                    }

                }
                    
            }

            return listaPorProducto;
        }
    }
}
