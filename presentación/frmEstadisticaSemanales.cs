using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;


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
                fechaAnterior = fechaAnterior.AddDays(-1);

                foreach (var ventas in listaVentas)
                {
                    if (ventas.Fecha.ToString("dd/MM/yyyy") == fechaAnterior.ToString("dd/MM/yyyy"))
                    {
                        VentaTotal += ventas.Total;
                    }
                }

                ventaPorDia += $"{fechaAnterior.ToString("dd/MM/yyyy")}: {VentaTotal.ToString("c")}";
                ventaPorDia += "\r\n";

                //Random Color
                Color c = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));

                //Cargar al chart
                chartGananciaSemanal.Series["Semana"].Points.Add(Convert.ToDouble(VentaTotal));
                chartGananciaSemanal.Series["Semana"].Points[i].Color = c;
                chartGananciaSemanal.Series["Semana"].Points[i].AxisLabel = fechaAnterior.ToString("dd/MM");
                chartGananciaSemanal.Series["Semana"].Points[i].Label = VentaTotal.ToString("c");

                //Lista de ventas por dia
            }

            lbVentaTotalPorDia.Text = ventaPorDia;
            lbVentaSemanaTitulo.Text = $"Semana: {DateTime.Now.AddDays(-1).ToString("dd/MM")} al {fechaAnterior.ToString("dd/MM")}";
        }

        private void categoriaSemanal()
        {
            //Venta total
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
            }
        }

        private void cargarListas()
        {
            VentaNegocio ventaNegocio = new VentaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            listaVentas = ventaNegocio.listar();
            listaCategorias = categoriaNegocio.listar();
        }

    }
}
