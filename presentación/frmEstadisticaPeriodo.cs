using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
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
    public partial class frmEstadisticaPeriodo : Form
    {
        //Fecha
        DateTime start;
        DateTime end;

        //Listado venta periodo
        List<Ventas> listaVentaPeriodo;

        //Datos Totales
        Decimal VentaTotal = Decimal.Zero;
        Decimal ventaEfectivo = Decimal.Zero;
        Decimal ventaTarjeta = Decimal.Zero;

        public frmEstadisticaPeriodo(DateTime start, DateTime end)
        {
            InitializeComponent();

            //Configuracion
            this.start = start;
            this.end = end;
        }

        private void frmEstadisticaPeriodo_Load(object sender, EventArgs e)
        {
            //Cargar ventas
            listaVentaPeriodo = cargarVentas();

            //Cargar grid
            cargarGridView();

            //Cargar GUI
            cargarGUI();

            //Cargar Categoria
            categoriaPeriodo();

        }

        private List<Ventas> cargarVentas()
        {
            VentaNegocio ventaNegocio = new VentaNegocio();
            List<Ventas> listaVentas = ventaNegocio.listar().FindAll(x => x.Fecha >= start && x.Fecha <= end);

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

            for (int i = 0; i < listaVentaPeriodo.Count; i++)
            {
                //Nombre o empresa
                Cliente clienteEncontrado = cliente.Find(x => x.Id == listaVentaPeriodo[i].id_cliente);
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
                decimal total = listaVentaPeriodo[i].Total - ((listaVentaPeriodo[i].Descuento / 100) * (listaVentaPeriodo[i].Total + (listaVentaPeriodo[i].Impuesto / 100) * listaVentaPeriodo[i].Total)) + ((listaVentaPeriodo[i].Impuesto / 100) * listaVentaPeriodo[i].Total);
                dgvVentas.Rows[index].Cells["Precio"].Value = total.ToString("c");
                dgvVentas.Rows[index].Cells["Precio"].Style.ForeColor = Color.Black;

                //Cliente
                dgvVentas.Rows[index].Cells["Cliente"].Value = rowCliente;
                dgvVentas.Rows[index].Cells["Cliente"].Style.ForeColor = Color.Black;

                //Id
                dgvVentas.Rows[index].Cells["Id"].Value = listaVentaPeriodo[i].Id;

            }

            dgvVentas.EnableHeadersVisualStyles = false;

        }

        private void cargarGUI()
        {
            cargarTotales();

            lbVentasTotal.Text = $"Ventas del {start.ToString("dd/MM/yyyy")} al {end.ToString("dd/MM/yyyy")}";

            if (listaVentaPeriodo.Count > 0)
            {
                lbVentasTotales.Text = VentaTotal.ToString("c");
                lbVentasCantidad.Text = listaVentaPeriodo.Count.ToString();
                lbVentasPromedio.Text = (VentaTotal / listaVentaPeriodo.Count).ToString("c");
                lbVentasEfectivo.Text = ventaEfectivo.ToString("c");
                lbVentasTarjeta.Text = ventaTarjeta.ToString("c");
            }

            cargarImagenes();
        }

        private void cargarTotales()
        {
            for (int i = 0; i < listaVentaPeriodo.Count; i++)
            {
                //Total Ventas
                VentaTotal += listaVentaPeriodo[i].Total + ((listaVentaPeriodo[i].Total - (listaVentaPeriodo[i].Total * (listaVentaPeriodo[i].Descuento / 100))) * (listaVentaPeriodo[i].Impuesto / 100)) - (listaVentaPeriodo[i].Total * (listaVentaPeriodo[i].Descuento / 100));


                if (listaVentaPeriodo[i].Credit)
                    ventaTarjeta += listaVentaPeriodo[i].Total + ((listaVentaPeriodo[i].Total - (listaVentaPeriodo[i].Total * (listaVentaPeriodo[i].Descuento / 100))) * (listaVentaPeriodo[i].Impuesto / 100)) - (listaVentaPeriodo[i].Total * (listaVentaPeriodo[i].Descuento / 100));
                else
                    ventaEfectivo += listaVentaPeriodo[i].Total + ((listaVentaPeriodo[i].Total - (listaVentaPeriodo[i].Total * (listaVentaPeriodo[i].Descuento / 100))) * (listaVentaPeriodo[i].Impuesto / 100)) - (listaVentaPeriodo[i].Total * (listaVentaPeriodo[i].Descuento / 100));

            }
        }

        private void cargarImagenes()
        {
            string path = Path.GetDirectoryName(Directory.GetCurrentDirectory().Replace(@"\bin", "")) + Opciones.Folder.ROOTIMAGE;
            btnPrinter.Load(path + Opciones.Folder.IMPRIMIR);
            btnFile.Load(path + Opciones.Folder.GUARDARARCHIVO);
        }

        private void categoriaPeriodo()
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            List<Categoria> listaCategorias = categoriaNegocio.listar();

            //Por cada Categoria
            for (int i = 0; i < listaCategorias.Count; i++)
            {

                decimal ventaTotalCategoria = 0;

                //Por cada ventas
                foreach (var ventas in listaVentaPeriodo)
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

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataRow = dgvVentas.Rows[e.RowIndex].Cells["Id"].Value;

            frmEstadisticaDiariaVentas screen = new frmEstadisticaDiariaVentas(dataRow.ToString());
            screen.ShowDialog();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog() { Filter = "Excel|*.xlsx", Title = "Guardar Ventas Perdiodo", FileName = $"Venta Perdiodo - {start.ToString("dddd, dd MMMM yyyy")} - {end.ToString("dddd, dd MMMM yyyy")} " })
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
                    List<Struct.ventaPorProducto> listaPorProducto = cargarListaProducto(listaVentaPeriodo);

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
            printProdcuctosPeriodo = new PrintDocument();
            PrinterSettings printerSetting = new PrinterSettings();
            printProdcuctosPeriodo.PrinterSettings = printerSetting;
            printProdcuctosPeriodo.PrintPage += printPresupuesto_PrintPage;

            PrintPreviewDialog printPreview = new PrintPreviewDialog();
            string path = Path.GetDirectoryName(Directory.GetCurrentDirectory().Replace(@"\bin", "")) + Opciones.Folder.ROOTIMAGE;
            printPreview.Icon = new System.Drawing.Icon(path + Opciones.Folder.ICONO);
            printPreview.MinimumSize = new Size(375, 250);
            printPreview.SetBounds(100, -550, 800, 800);
            printPreview.Document = printProdcuctosPeriodo;

            printPreview.ShowDialog();
        }

        private void printPresupuesto_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Date
            TimeSpan diff = end - start;
            DateTime date = start;
            
            //Style
            System.Drawing.Font font = new System.Drawing.Font("Tahoma", 14, FontStyle.Bold);
            System.Drawing.Font fontProductos = new System.Drawing.Font("Tahoma", 14);
            System.Drawing.Font fontProductosBold = new System.Drawing.Font("Tahoma", 14, FontStyle.Bold);
            int width = 800;
            int y = 40;

            //Por día
            for (int i = 0; i <= diff.Days; i++)
            {
                //Buscar ventas por dia
                List<Ventas> aux = listaVentaPeriodo.FindAll(x => x.Fecha.ToString("dd/MM/yyyy") == date.ToString("dd/MM/yyyy"));

                if(aux != null && aux.Count != 0)
                {
                    //Crear lista por producto
                    List<Struct.ventaPorProducto> listaPorProducto = cargarListaProducto(aux);

                   if(listaPorProducto != null && listaPorProducto.Count != 0)
                    {
                        //Render dia
                        RectangleF r = new RectangleF(40, y, width, 25);
                        e.Graphics.FillRectangle(Brushes.LightGray, r);
                        e.Graphics.DrawString(date.ToString("dd/MM/yyyy"), fontProductosBold, Brushes.Black, new RectangleF(40, y, width, 40));

                        y += 40;
                        //Headers
                        e.Graphics.DrawString("CODIGO", fontProductosBold, Brushes.Black, new RectangleF(40, y, width, 40));
                        e.Graphics.DrawString("NOMBRE", fontProductosBold, Brushes.Black, new RectangleF(140, y, width, 40));
                        e.Graphics.DrawString("DESCR.", fontProductosBold, Brushes.Black, new RectangleF(350, y, width, 40));
                        e.Graphics.DrawString("UNI.", fontProductosBold, Brushes.Black, new RectangleF(650, y, width, 40));
                        e.Graphics.DrawString("TOTAL", fontProductosBold, Brushes.Black, new RectangleF(700, y, width, 40));

                        //Body
                        foreach (var item in listaPorProducto)
                        {
                            y += 30;
                            e.Graphics.DrawString($"{item.Codigo}", fontProductos, Brushes.Black, new RectangleF(40, y, 100, 20));
                            e.Graphics.DrawString($"{item.Nombre}", fontProductos, Brushes.Black, new RectangleF(140, y, 200, 20));
                            e.Graphics.DrawString($"{item.Descripcion}", fontProductos, Brushes.Black, new RectangleF(350, y, 300, 20));
                            e.Graphics.DrawString($"{item.Cantidad}", fontProductos, Brushes.Black, new RectangleF(650, y, 100, 20));
                            e.Graphics.DrawString($"{item.Total}", fontProductos, Brushes.Black, new RectangleF(700, y, 100, 20));
                        }

                        y += 40;
                    }
                }

                //Sumar dia
                date = date.AddDays(1);
            }

            //Total
            y += 40;
            e.Graphics.DrawString($"TOTAL CON IMP. y DESC.: {Math.Round(VentaTotal, 2)}", font, Brushes.Black, new RectangleF(450, y, width, 40));
        }

        private List<Struct.ventaPorProducto> cargarListaProducto(List<Ventas> listVentasAux)
        {
            //Crear lista por producto
            List<Struct.ventaPorProducto> listaPorProducto = new List<Struct.ventaPorProducto>();

            //Por cada Ventas
            foreach (var ventas in listVentasAux)
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
