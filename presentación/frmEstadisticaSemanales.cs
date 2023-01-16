using configuracion;
using dominio;
using Microsoft.Office.Interop.Excel;
using negocio;
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
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Drawing.Printing;
using Microsoft.Office.Interop.Excel;


namespace presentación
{
    public partial class frmEstadisticaSemanales : Form
    {
        List<Ventas> listaVentas;
        List<Categoria> listaCategorias;

        private Form parent;
        public frmEstadisticaSemanales(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmEstadisticaSemanales_Load(object sender, EventArgs e)
        {
            cargarListas();
            gananciaSemanal();
            categoriaSemanal();
            cargarImagenes();
        }

        private void cargarImagenes()
        {
            string path = Path.GetDirectoryName(Directory.GetCurrentDirectory().Replace(@"\bin", "")) + Opciones.Folder.ROOTIMAGE;
            btnPrinter.Load(path + Opciones.Folder.IMPRIMIR);
            btnFile.Load(path + Opciones.Folder.GUARDARARCHIVO);
        }

        private void gananciaSemanal()
        {
            var rand = new Random();
            string ventaPorDia = string.Empty;
            
            //Cargar ganancias semanales
            DateTime fechaAnterior = DateTime.Now;
            for (int i = 0; i < 7; i++)
            {

                decimal VentaTotal = 0;

                //Primer dia del chart
                fechaAnterior = fechaAnterior.AddDays(-7);

                foreach (var ventas in listaVentas)
                {
                    if (ventas.Fecha.ToString("dd/MM/yyyy") == fechaAnterior.ToString("dd/MM/yyyy"))
                    {
                        VentaTotal += ventas.Total;
                    }
                }

                //Concatenar ventas en string
                ventaPorDia += $"{fechaAnterior.ToString("dd/MM/yyyy")}: {VentaTotal.ToString("c")}";
                ventaPorDia += "\r\n";

                //Random Color
                Color c = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));

                //Cargar al chart
                chartGananciaSemanal.Series["Semana"].Points.Add(Convert.ToDouble(VentaTotal));
                chartGananciaSemanal.Series["Semana"].Points[i].Color = c;
                chartGananciaSemanal.Series["Semana"].Points[i].AxisLabel = fechaAnterior.ToString("dd/MM");
                chartGananciaSemanal.Series["Semana"].Points[i].Label = VentaTotal.ToString("c");

                //Agregar días para agregar de forma ascendente
                fechaAnterior = fechaAnterior.AddDays(8);

            }

            //Label venta por dia
            lbVentaTotalPorDia.Text = ventaPorDia;

            //Fecha en el titulo de venta por semana
            lbVentaSemanaTitulo.Text = $"Semana: {DateTime.Now.AddDays(-1).ToString("dd/MM")} al {fechaAnterior.ToString("dd/MM")}";
        }

        private void categoriaSemanal()
        {
            //Venta total
            decimal ventaTotal = cargarVentaSemanal();

            //Por cada Categoria
            for (int i = 1; i <= listaCategorias.Count; i++)
            {
                decimal ventaTotalCategoria = 0;
                DateTime fechaAnterior_categoria = DateTime.Now;

               //Por cada dia de la semana
                for (int j = 0; j < 7; j++)
                {
                    fechaAnterior_categoria = fechaAnterior_categoria.AddDays(-1);

                    //Por cada ventas
                    foreach (var ventas in listaVentas)
                    {
                        //Si los dias coinciden
                        if (ventas.Fecha.ToString("dd/MM/yyyy") == fechaAnterior_categoria.ToString("dd/MM/yyyy"))
                        {
                            //Por cada venta de Ventas
                            foreach(var venta in ventas.Venta)
                            {
                                if(venta.CategoriaInfo.Descripcion == listaCategorias[i - 1].Descripcion)
                                {
                                    ventaTotalCategoria += venta.Total;
                                }
                            }
                        }
                    }
                }

                double porcentajeCategoria = (decimal.ToDouble(ventaTotalCategoria) * 100) / decimal.ToDouble(ventaTotal);
                chartSemanalCategoria.Series["Categorias"].Points.AddXY(i, porcentajeCategoria);
                chartSemanalCategoria.Series["Categorias"].Points[i-1].Label = listaCategorias[i-1].Descripcion;
                chartSemanalCategoria.Series["Categorias"].Points[i-1].LabelForeColor = Color.WhiteSmoke;
                cargarPrecioTotal(ventaTotal);
            }
        }

        private decimal cargarVentaSemanal()
        {
            decimal ventaTotal = 0;
 
            //Cargar ganancias semanales
            DateTime fechaAnterior = DateTime.Now;
            for (int j = 0; j < 7; j++)
            {
                fechaAnterior = fechaAnterior.AddDays(-1);

                foreach (var ventas in listaVentas)
                {
                    if (ventas.Fecha.Date == fechaAnterior.Date)
                    {
                        ventaTotal += ventas.Total;
                    }
                }

            }

            return ventaTotal;
        }

        private void cargarListas()
        {
            VentaNegocio ventaNegocio = new VentaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            listaVentas = ventaNegocio.listar();
            listaCategorias = categoriaNegocio.listar();
        }

        private void cargarPrecioTotal(decimal total)
        {
            lbVentasEfectivo.Text = total.ToString("c");
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog() { Filter = "Excel|*.xlsx", Title = "Guardar Ventas Semanalas", FileName = $"Venta Semanal - {DateTime.Now.ToString("dddd, dd MMMM yyyy")} - {DateTime.Now.AddDays(-7).ToString("dddd, dd MMMM yyyy")}" })
            {
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    //Venta semanal
                    decimal ventaTotal = cargarVentaSemanal();

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

                    //Crear lista por producto
                    List<ventaPorProducto> listaPorProducto = cargarListaProducto();

                    //Guardar en archivos
                    foreach (var producto in listaPorProducto)
                    {
                        ws.Cells[index, 1] = producto.Codigo;
                        ws.Cells[index, 2] = producto.Nombre;
                        ws.Cells[index, 3] = producto.Description;
                        ws.Cells[index, 4] = producto.Categorio;
                        ws.Cells[index, 5] = producto.Cantidad;
                        ws.Cells[index, 6] = Math.Round(producto.Total, 2);
                        index++;
                    }

                    ws.Cells[index, 6] = Math.Round(ventaTotal, 2);

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


        private List<ventaPorProducto> cargarListaProducto()
        {
            //Crear lista por producto
            List<ventaPorProducto> listaPorProducto = new List<ventaPorProducto>();

            //Fecha
            DateTime fechaAnterior_Ventas = DateTime.Now;

            //Por cada dia
            for (int i = 0; i < 7; i++)
            {
                //Restar día
                fechaAnterior_Ventas = fechaAnterior_Ventas.AddDays(-1);

                //Por cada Ventas
                foreach (var ventas in listaVentas)
                {
                    //Si el día coincide
                    if (ventas.Fecha.ToString("dd/MM/yyyy") == fechaAnterior_Ventas.ToString("dd/MM/yyyy"))
                    {
                        //Por cada venta
                        foreach (var venta in ventas.Venta)
                        {

                            if (listaPorProducto.Exists(x => x.Id == venta.Id))
                            {
                                ventaPorProducto aux = new ventaPorProducto();

                                //Modifica el item que es igual
                                aux = listaPorProducto.Find(x => x.Id == venta.Id);
                                aux.Cantidad += venta.Cantidad;
                                aux.Total += venta.Total;

                                //Lista auxiliar sin el producto anterior
                                List<ventaPorProducto> auxListaProProdcuto = new List<ventaPorProducto>();
                                auxListaProProdcuto = listaPorProducto.FindAll(x => x.Id != venta.Id);
                                auxListaProProdcuto.Add(aux);

                                listaPorProducto.Clear();
                                listaPorProducto = auxListaProProdcuto;

                            }
                            else
                            {
                                //Creamos un nuevo elemento para la lista
                                ventaPorProducto aux = new ventaPorProducto();
                                aux.Id = venta.Id;
                                aux.Codigo = venta.Codigo;
                                aux.Nombre = venta.Nombre;
                                aux.Description = venta.Descripcion;
                                aux.Categorio = venta.CategoriaInfo.Descripcion;
                                aux.Cantidad = venta.Cantidad;
                                aux.Total = venta.Total;

                                listaPorProducto.Add(aux);
                            }

                        }
                    }

                }
            }

            return listaPorProducto;
        }
        

        private struct ventaPorProducto
        {
            public int Id;
            public string Codigo;
            public string Nombre;
            public string Description;
            public string Categorio;
            public int Cantidad;
            public decimal Total;
        }

        private void btnPrinter_Click(object sender, EventArgs e)
        {
            printProdcuctosSemanal = new PrintDocument();
            PrinterSettings printerSetting = new PrinterSettings();
            printProdcuctosSemanal.PrinterSettings = printerSetting;
            printProdcuctosSemanal.PrintPage += printPresupuesto_PrintPage;

            PrintPreviewDialog printPreview = new PrintPreviewDialog();
            string path = Path.GetDirectoryName(Directory.GetCurrentDirectory().Replace(@"\bin", "")) + Opciones.Folder.ROOTIMAGE;
            printPreview.Icon = new System.Drawing.Icon(path + Opciones.Folder.ICONO);
            printPreview.MinimumSize = new Size(375, 250);
            printPreview.SetBounds(100, -550, 800, 800);
            printPreview.Document = printProdcuctosSemanal;

            printPreview.ShowDialog();
        }

        private void printPresupuesto_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Venta semanal
            decimal ventaTotal = cargarVentaSemanal();

            //Crear lista por producto
            List<ventaPorProducto> listaPorProducto = cargarListaProducto();

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
                e.Graphics.DrawString($"{item.Description}", fontProductos, Brushes.Black, new RectangleF(350, y, 300, 20));
                e.Graphics.DrawString($"{item.Cantidad}", fontProductos, Brushes.Black, new RectangleF(650, y, 100, 20));
                e.Graphics.DrawString($"{item.Total}", fontProductos, Brushes.Black, new RectangleF(700, y, 100, 20));
            }

            //Total
            y += 40;
            e.Graphics.DrawString($"TOTAL: {Math.Round(ventaTotal, 2)}", font, Brushes.Black, new RectangleF(650, y, width, 40));
        }
    }
}
