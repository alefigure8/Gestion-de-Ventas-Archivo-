using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
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

            //Cargar ComboBox
            cargarComboBox();

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

            dgvVentas.Columns.Add("Fecha", "Fecha");
            dgvVentas.Columns["Fecha"].DisplayIndex = 0;

            dgvVentas.Columns.Add("Total", "Total");
            dgvVentas.Columns["Total"].DisplayIndex = 1;

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

                //Fecha
                DateTime date = listaVentaPeriodo[i].Fecha;
                dgvVentas.Rows[index].Cells["Fecha"].Value = date.ToString("dd/MM/yyyy");
                dgvVentas.Rows[index].Cells["Fecha"].Style.ForeColor = Color.Black;
                dgvVentas.Rows[index].Cells["Fecha"].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

                //Precio
                decimal total = listaVentaPeriodo[i].Total - ((listaVentaPeriodo[i].Descuento / 100) * (listaVentaPeriodo[i].Total + (listaVentaPeriodo[i].Impuesto / 100) * listaVentaPeriodo[i].Total)) + ((listaVentaPeriodo[i].Impuesto / 100) * listaVentaPeriodo[i].Total);
                dgvVentas.Rows[index].Cells["Total"].Value = total.ToString("c");
                dgvVentas.Rows[index].Cells["Total"].Style.ForeColor = Color.Black;
                dgvVentas.Rows[index].Cells["Total"].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;


                //Cliente
                dgvVentas.Rows[index].Cells["Cliente"].Value = rowCliente;
                dgvVentas.Rows[index].Cells["Cliente"].Style.ForeColor = Color.Black;
                dgvVentas.Rows[index].Cells["Cliente"].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;


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

        private void cargarComboBox()
        {
            helper.ComboBoxOptions.comboBoxOpcionesDescarga(cbOpcionesDescarga);
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

                    //Listas
                    CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                    MarcaNegocio marcaNegocio = new MarcaNegocio();

                    List<Categoria> listaCategoria = categoriaNegocio.listar();
                    List<Marca> listaMarca = marcaNegocio.listar();

                    //Date
                    TimeSpan diff = end - start;
                    DateTime date = start;

                    //Configuraciones Workbooks
                    string fileName = saveDialog.FileName;
                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)excel.ActiveSheet;
                    excel.Visible = false;

                    //Inicio de fila
                    int index = 1;

                    //Range
                    Range formatRange;

                    string opcion = cbOpcionesDescarga.Text;

                    switch (opcion)
                    {
                        //por Dia
                        case Opciones.OpcionesDescargas.DIA:
                            {
                                for (int i = 0; i <= diff.Days; i++)
                                {
                                    //Guardar en archivos
                                    List<Ventas> aux = listaVentaPeriodo.FindAll(x => x.Fecha.ToString("dd/MM/yyyy") == date.ToString("dd/MM/yyyy"));

                                    if (aux != null && aux.Count != 0)
                                    {
                                        List<Struct.ventaPorProducto> listaPorProducto = cargarListaProducto(aux);

                                        if (listaPorProducto != null && listaPorProducto.Count != 0)
                                        {
                                            index++;

                                            //Date
                                            formatRange = ws.get_Range($"a{index}", $"f{index}");
                                            formatRange.BorderAround(XlLineStyle.xlContinuous,
                                            XlBorderWeight.xlMedium, XlColorIndex.xlColorIndexAutomatic,
                                            XlColorIndex.xlColorIndexAutomatic);
                                            formatRange.Interior.Color = ColorTranslator.ToOle(Color.LightGray);
                                            formatRange.Font.Bold = true;
                                            ws.Cells[index, 1] = $"{date.ToString("dd/MM/yyyy")}";

                                            index++;

                                            //Header
                                            formatRange = ws.get_Range($"a{index}", $"f{index}");
                                            formatRange.BorderAround(XlLineStyle.xlContinuous,
                                            XlBorderWeight.xlMedium, XlColorIndex.xlColorIndexAutomatic,
                                            XlColorIndex.xlColorIndexAutomatic);
                                            formatRange.Interior.Color = ColorTranslator.ToOle(Color.LightGray);
                                            formatRange.Font.Bold = true;

                                            //Columns
                                            ws.Cells[index, 1] = "Código";
                                            ws.Cells[index, 2] = "Nombre";
                                            ws.Cells[index, 3] = "Descripción";
                                            ws.Cells[index, 4] = "Categoria";
                                            ws.Cells[index, 5] = "Cantidad";
                                            ws.Cells[index, 6] = "Precio Total";

                                            index++;

                                            foreach (var venta in listaPorProducto)
                                            {
                                                ws.Cells[index, 1] = venta.Codigo;
                                                ws.Cells[index, 2] = venta.Nombre;
                                                ws.Cells[index, 3] = venta.Descripcion;
                                                ws.Cells[index, 4] = venta.Categoria;
                                                ws.Cells[index, 5] = venta.Cantidad;
                                                ws.Cells[index, 6] = Math.Round(venta.Total, 2);
                                                index++;
                                            }
                                        }
                                    }

                                    date = date.AddDays(1);
                                }

                                index++;
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
                            break;

                        //Por Categorias
                        case Opciones.OpcionesDescargas.CATEGORIAS:
                            {
                                //Titulo
                                formatRange = ws.get_Range($"a{index}", $"f{index}");
                                formatRange.BorderAround(XlLineStyle.xlContinuous,
                                XlBorderWeight.xlMedium, XlColorIndex.xlColorIndexAutomatic,
                                XlColorIndex.xlColorIndexAutomatic);
                                formatRange.Interior.Color = ColorTranslator.ToOle(Color.LightGray);
                                formatRange.Font.Bold = true;
                                ws.Cells[index, 1] = $"Desde el {start.ToString("dd/MM/yyyy")} hasta el {end.ToString("dd/MM/yyyy")}";

                                foreach (var categoria in listaCategoria)
                                {
                                    index++;

                                    //Categoria
                                    formatRange = ws.get_Range($"a{index}", $"f{index}");
                                    formatRange.BorderAround(XlLineStyle.xlContinuous,
                                    XlBorderWeight.xlMedium, XlColorIndex.xlColorIndexAutomatic,
                                    XlColorIndex.xlColorIndexAutomatic);
                                    formatRange.Interior.Color = ColorTranslator.ToOle(Color.LightGray);
                                    formatRange.Font.Bold = true;
                                    ws.Cells[index, 1] = $"{categoria.Descripcion}";

                                    index++;

                                    //Header
                                    formatRange = ws.get_Range($"a{index}", $"f{index}");
                                    formatRange.BorderAround(XlLineStyle.xlContinuous,
                                    XlBorderWeight.xlMedium, XlColorIndex.xlColorIndexAutomatic,
                                    XlColorIndex.xlColorIndexAutomatic);
                                    formatRange.Interior.Color = ColorTranslator.ToOle(Color.LightGray);
                                    formatRange.Font.Bold = true;

                                    //Columns
                                    ws.Cells[index, 1] = "Código";
                                    ws.Cells[index, 2] = "Nombre";
                                    ws.Cells[index, 3] = "Descripción";
                                    ws.Cells[index, 4] = "Categoria";
                                    ws.Cells[index, 5] = "Cantidad";
                                    ws.Cells[index, 6] = "Precio Total";

                                    index++;

                                    List<Ventas> aux = listaVentaPeriodo.FindAll(x => x.Fecha >= start && x.Fecha <= end);

                                    if (aux != null && aux.Count != 0)
                                    {
                                        List<Struct.ventaPorProducto> listaPorProducto = cargarListaProducto(aux);

                                        if (listaPorProducto != null && listaPorProducto.Count != 0)
                                        {
                                            foreach (var venta in listaPorProducto)
                                            {
                                                if (venta.Categoria == categoria.Descripcion)
                                                {
                                                    ws.Cells[index, 1] = venta.Codigo;
                                                    ws.Cells[index, 2] = venta.Nombre;
                                                    ws.Cells[index, 3] = venta.Descripcion;
                                                    ws.Cells[index, 4] = venta.Categoria;
                                                    ws.Cells[index, 5] = venta.Cantidad;
                                                    ws.Cells[index, 6] = Math.Round(venta.Total, 2);
                                                    index++;
                                                }
                                            }
                                        }
                                    }
                                }

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
                            break;

                        //Por Marcas
                        case Opciones.OpcionesDescargas.MARCAS:
                            {
                                //Titulo
                                formatRange = ws.get_Range($"a{index}", $"f{index}");
                                formatRange.BorderAround(XlLineStyle.xlContinuous,
                                XlBorderWeight.xlMedium, XlColorIndex.xlColorIndexAutomatic,
                                XlColorIndex.xlColorIndexAutomatic);
                                formatRange.Interior.Color = ColorTranslator.ToOle(Color.LightGray);
                                formatRange.Font.Bold = true;
                                ws.Cells[index, 1] = $"Desde el {start.ToString("dd/MM/yyyy")} hasta el {end.ToString("dd/MM/yyyy")}";

                                foreach (var marca in listaMarca)
                                {
                                    index++;

                                    //Categoria
                                    formatRange = ws.get_Range($"a{index}", $"f{index}");
                                    formatRange.BorderAround(XlLineStyle.xlContinuous,
                                    XlBorderWeight.xlMedium, XlColorIndex.xlColorIndexAutomatic,
                                    XlColorIndex.xlColorIndexAutomatic);
                                    formatRange.Interior.Color = ColorTranslator.ToOle(Color.LightGray);
                                    formatRange.Font.Bold = true;
                                    ws.Cells[index, 1] = $"{marca.Descripcion}";

                                    index++;

                                    //Header
                                    formatRange = ws.get_Range($"a{index}", $"f{index}");
                                    formatRange.BorderAround(XlLineStyle.xlContinuous,
                                    XlBorderWeight.xlMedium, XlColorIndex.xlColorIndexAutomatic,
                                    XlColorIndex.xlColorIndexAutomatic);
                                    formatRange.Interior.Color = ColorTranslator.ToOle(Color.LightGray);
                                    formatRange.Font.Bold = true;

                                    //Columns
                                    ws.Cells[index, 1] = "Código";
                                    ws.Cells[index, 2] = "Nombre";
                                    ws.Cells[index, 3] = "Descripción";
                                    ws.Cells[index, 4] = "Categoria";
                                    ws.Cells[index, 5] = "Cantidad";
                                    ws.Cells[index, 6] = "Precio Total";

                                    index++;

                                    List<Ventas> aux = listaVentaPeriodo.FindAll(x => x.Fecha >= start && x.Fecha <= end);

                                    if (aux != null && aux.Count != 0)
                                    {
                                        List<Struct.ventaPorProducto> listaPorProducto = cargarListaProducto(aux);

                                        if (listaPorProducto != null && listaPorProducto.Count != 0)
                                        {
                                            foreach (var venta in listaPorProducto)
                                            {
                                                if (venta.Marca == marca.Descripcion)
                                                {
                                                    ws.Cells[index, 1] = venta.Codigo;
                                                    ws.Cells[index, 2] = venta.Nombre;
                                                    ws.Cells[index, 3] = venta.Descripcion;
                                                    ws.Cells[index, 4] = venta.Categoria;
                                                    ws.Cells[index, 5] = venta.Cantidad;
                                                    ws.Cells[index, 6] = Math.Round(venta.Total, 2);
                                                    index++;
                                                }
                                            }
                                        }
                                    }
                                }

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
                            break;

                        //Por Articulos
                        case Opciones.OpcionesDescargas.ARTICULOS:
                            {
                                index++;

                                //Titulo
                                formatRange = ws.get_Range($"a{index}", $"f{index}");
                                formatRange.BorderAround(XlLineStyle.xlContinuous,
                                XlBorderWeight.xlMedium, XlColorIndex.xlColorIndexAutomatic,
                                XlColorIndex.xlColorIndexAutomatic);
                                formatRange.Interior.Color = ColorTranslator.ToOle(Color.LightGray);
                                formatRange.Font.Bold = true;
                                ws.Cells[index, 1] = $"Desde el {start.ToString("dd/MM/yyyy")} hasta el {end.ToString("dd/MM/yyyy")}";

                                //Categoria
                                formatRange = ws.get_Range($"a{index}", $"f{index}");
                                formatRange.BorderAround(XlLineStyle.xlContinuous,
                                XlBorderWeight.xlMedium, XlColorIndex.xlColorIndexAutomatic,
                                XlColorIndex.xlColorIndexAutomatic);
                                formatRange.Interior.Color = ColorTranslator.ToOle(Color.LightGray);
                                formatRange.Font.Bold = true;
                                ws.Cells[index, 1] = $"Lista por Producto";

                                index++;

                                //Header
                                formatRange = ws.get_Range($"a{index}", $"f{index}");
                                formatRange.BorderAround(XlLineStyle.xlContinuous,
                                XlBorderWeight.xlMedium, XlColorIndex.xlColorIndexAutomatic,
                                XlColorIndex.xlColorIndexAutomatic);
                                formatRange.Interior.Color = ColorTranslator.ToOle(Color.LightGray);
                                formatRange.Font.Bold = true;

                                //Columns
                                ws.Cells[index, 1] = "Código";
                                ws.Cells[index, 2] = "Nombre";
                                ws.Cells[index, 3] = "Descripción";
                                ws.Cells[index, 4] = "Categoria";
                                ws.Cells[index, 5] = "Cantidad";
                                ws.Cells[index, 6] = "Precio Total";

                                index++;

                                List<Ventas> aux = listaVentaPeriodo.FindAll(x => x.Fecha >= start && x.Fecha <= end);

                                if (aux != null && aux.Count != 0)
                                {
                                    List<Struct.ventaPorProducto> listaPorProducto = cargarListaProducto(aux);

                                    if (listaPorProducto != null && listaPorProducto.Count != 0)
                                    {
                                        foreach (var venta in listaPorProducto)
                                        {
      
                                            ws.Cells[index, 1] = venta.Codigo;
                                            ws.Cells[index, 2] = venta.Nombre;
                                            ws.Cells[index, 3] = venta.Descripcion;
                                            ws.Cells[index, 4] = venta.Categoria;
                                            ws.Cells[index, 5] = venta.Cantidad;
                                            ws.Cells[index, 6] = Math.Round(venta.Total, 2);
                                            index++;

                                        }
                                    }
                                }

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
                            break;

                        default:
                            break;
                    }

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
            //Listas
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            List<Categoria> listaCategoria = categoriaNegocio.listar();
            List<Marca> listaMarca = marcaNegocio.listar();

            //Date
            TimeSpan diff = end - start;
            DateTime date = start;
            
            //Style
            System.Drawing.Font font = new System.Drawing.Font("Tahoma", 14, FontStyle.Bold);
            System.Drawing.Font fontProductos = new System.Drawing.Font("Tahoma", 14);
            System.Drawing.Font fontProductosBold = new System.Drawing.Font("Tahoma", 14, FontStyle.Bold);
            int width = 800;
            int y = 40;

            //Opcion ComboBox
            string opcion = cbOpcionesDescarga.Text;

            // Segun la opcion del combobox
            switch (opcion)
            {
                //Por día
                case Opciones.OpcionesDescargas.DIA:
                {
                    //Titulo
                    e.Graphics.DrawString($"Desde el {start.ToString("dd/MM/yyyy")} al {end.ToString("dd/MM/yyyy")}", fontProductosBold, Brushes.Black, new RectangleF(40, y, width, 40));
                    y += 40;

                    for (int i = 0; i <= diff.Days; i++)
                    {
                        //Buscar ventas por dia
                        List<Ventas> aux = listaVentaPeriodo.FindAll(x => x.Fecha.ToString("dd/MM/yyyy") == date.ToString("dd/MM/yyyy"));

                        if (aux != null && aux.Count != 0)
                        {
                            //Crear lista por producto
                            List<Struct.ventaPorProducto> listaPorProducto = cargarListaProducto(aux);

                            if (listaPorProducto != null && listaPorProducto.Count != 0)
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
                    break;

                //Por Categoria
                case Opciones.OpcionesDescargas.CATEGORIAS:
                {
                    //Titulo
                    e.Graphics.DrawString($"Desde el {start.ToString("dd/MM/yyyy")} al {end.ToString("dd/MM/yyyy")}", fontProductosBold, Brushes.Black, new RectangleF(40, y, width, 40));
                    y += 40;

                    foreach (var categoria in listaCategoria)
                    {
                         //Render Cateogoria
                        RectangleF r = new RectangleF(40, y, width, 25);
                        e.Graphics.FillRectangle(Brushes.LightGray, r);
                        e.Graphics.DrawString(categoria.Descripcion, fontProductosBold, Brushes.Black, new RectangleF(40, y, width, 40));

                        y += 40;
                        //Headers
                        e.Graphics.DrawString("CODIGO", fontProductosBold, Brushes.Black, new RectangleF(40, y, width, 40));
                        e.Graphics.DrawString("NOMBRE", fontProductosBold, Brushes.Black, new RectangleF(140, y, width, 40));
                        e.Graphics.DrawString("DESCR.", fontProductosBold, Brushes.Black, new RectangleF(350, y, width, 40));
                        e.Graphics.DrawString("UNI.", fontProductosBold, Brushes.Black, new RectangleF(650, y, width, 40));
                        e.Graphics.DrawString("TOTAL", fontProductosBold, Brushes.Black, new RectangleF(700, y, width, 40));

                        List<Ventas> aux = listaVentaPeriodo.FindAll(x => x.Fecha >= start && x.Fecha <= end);

                        if(aux != null && aux.Count != 0)
                        {
                            List<Struct.ventaPorProducto> listaPorProducto = cargarListaProducto(aux);

                            if (listaPorProducto != null && listaPorProducto.Count != 0)
                            {
                                foreach (var item in listaPorProducto)
                                {
                                    if (item.Categoria == categoria.Descripcion)
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
                        }
                    }

                    //Total
                    y += 40;
                    e.Graphics.DrawString($"TOTAL CON IMP. y DESC.: {Math.Round(VentaTotal, 2)}", font, Brushes.Black, new RectangleF(450, y, width, 40));
                }
                break;

                //Por Marca
                case Opciones.OpcionesDescargas.MARCAS:
                {
                    //Titulo
                    e.Graphics.DrawString($"Desde el {start.ToString("dd/MM/yyyy")} al {end.ToString("dd/MM/yyyy")}", fontProductosBold, Brushes.Black, new RectangleF(40, y, width, 40));
                    y += 40;

                    foreach (var marca in listaMarca)
                    {
                        //Render Cateogoria
                        RectangleF r = new RectangleF(40, y, width, 25);
                        e.Graphics.FillRectangle(Brushes.LightGray, r);
                        e.Graphics.DrawString(marca.Descripcion, fontProductosBold, Brushes.Black, new RectangleF(40, y, width, 40));

                        y += 40;
                        //Headers
                        e.Graphics.DrawString("CODIGO", fontProductosBold, Brushes.Black, new RectangleF(40, y, width, 40));
                        e.Graphics.DrawString("NOMBRE", fontProductosBold, Brushes.Black, new RectangleF(140, y, width, 40));
                        e.Graphics.DrawString("DESCR.", fontProductosBold, Brushes.Black, new RectangleF(350, y, width, 40));
                        e.Graphics.DrawString("UNI.", fontProductosBold, Brushes.Black, new RectangleF(650, y, width, 40));
                        e.Graphics.DrawString("TOTAL", fontProductosBold, Brushes.Black, new RectangleF(700, y, width, 40));

                        List<Ventas> aux = listaVentaPeriodo.FindAll(x => x.Fecha >= start && x.Fecha <= end);

                        if (aux != null && aux.Count != 0)
                        {
                            List<Struct.ventaPorProducto> listaPorProducto = cargarListaProducto(aux);

                            if (listaPorProducto != null && listaPorProducto.Count != 0)
                            {
                                foreach (var item in listaPorProducto)
                                {
                                    if (item.Marca == marca.Descripcion)
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
                        }
                    }

                    //Total
                    y += 40;
                    e.Graphics.DrawString($"TOTAL CON IMP. y DESC.: {Math.Round(VentaTotal, 2)}", font, Brushes.Black, new RectangleF(450, y, width, 40));
                }
                break;

                //Por Artiuclos
                case Opciones.OpcionesDescargas.ARTICULOS:
                {
                    //Titulo
                    e.Graphics.DrawString($"Desde el {start.ToString("dd/MM/yyyy")} al {end.ToString("dd/MM/yyyy")}", fontProductosBold, Brushes.Black, new RectangleF(40, y, width, 40));
                    y += 40;
      
                    //Headers
                    e.Graphics.DrawString("CODIGO", fontProductosBold, Brushes.Black, new RectangleF(40, y, width, 40));
                    e.Graphics.DrawString("NOMBRE", fontProductosBold, Brushes.Black, new RectangleF(140, y, width, 40));
                    e.Graphics.DrawString("DESCR.", fontProductosBold, Brushes.Black, new RectangleF(350, y, width, 40));
                    e.Graphics.DrawString("UNI.", fontProductosBold, Brushes.Black, new RectangleF(650, y, width, 40));
                    e.Graphics.DrawString("TOTAL", fontProductosBold, Brushes.Black, new RectangleF(700, y, width, 40));

                    List<Ventas> aux = listaVentaPeriodo.FindAll(x => x.Fecha >= start && x.Fecha <= end);

                    if (aux != null && aux.Count != 0)
                    {
                        List<Struct.ventaPorProducto> listaPorProducto = cargarListaProducto(aux);

                        if (listaPorProducto != null && listaPorProducto.Count != 0)
                        {
                            foreach (var item in listaPorProducto)
                            {
                                y += 30;
                                e.Graphics.DrawString($"{item.Codigo}", fontProductos, Brushes.Black, new RectangleF(40, y, 100, 20));
                                e.Graphics.DrawString($"{item.Nombre}", fontProductos, Brushes.Black, new RectangleF(140, y, 200, 20));
                                e.Graphics.DrawString($"{item.Descripcion}", fontProductos, Brushes.Black, new RectangleF(350, y, 300, 20));
                                e.Graphics.DrawString($"{item.Cantidad}", fontProductos, Brushes.Black, new RectangleF(650, y, 100, 20));
                                e.Graphics.DrawString($"{item.Total}", fontProductos, Brushes.Black, new RectangleF(700, y, 100, 20));
                                y += 40;
                            }
                        }
                    }
                        
                    //Total
                    y += 40;
                    e.Graphics.DrawString($"TOTAL CON IMP. y DESC.: {Math.Round(VentaTotal, 2)}", font, Brushes.Black, new RectangleF(450, y, width, 40));
                }
                break;
                default:
                    break;
            }
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
                        aux.Marca = venta.MarcaInfo.Descripcion;
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
