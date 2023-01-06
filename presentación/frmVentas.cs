using configuracion;
using dominio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using negocio;

namespace presentación
{
    public partial class frmVentas : Form
    {
        List<Venta> listaVentas = null;
        int iCell = 0;
        
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            listaVentas = new List<Venta>()
            {
                new Venta()
            };
            cargarGridView();
            
            this.KeyPreview = true;

        }

        private void cargarGridView()
        {
            dgvProductos.DataSource = listaVentas;
            dgvProductos.Columns[Opciones.Campo.DESCRIPCION].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProductos.Columns[Opciones.Campo.ID].Visible = false;
            dgvProductos.Columns[Opciones.Campo.URLIMAGEN].Visible = false;
            dgvProductos.Columns[Opciones.Campo.MODIFICADO].Visible = false;
            dgvProductos.Columns[Opciones.Campo.CREADO].Visible = false;
            dgvProductos.Columns[Opciones.Campo.COSTO].Visible = false;
            dgvProductos.Columns[Opciones.Campo.STOCK].Visible = false;
            dgvProductos.Columns["Cantidad"].DisplayIndex = 10;
            dgvProductos.Columns["Total"].DisplayIndex = 11;
            dgvProductos.EnableHeadersVisualStyles = false;

            //Reado only true
            foreach(DataGridViewColumn c in dgvProductos.Columns)
            {
                c.ReadOnly = true;
              }

            DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
            this.dgvProductos[Opciones.Campo.CODIGO, iCell] = cell;
            cell.Value = "Ingrese Código";
            cell.ReadOnly = false;
            dgvProductos.BeginEdit(true);

            //Edit mode
            if (listaVentas.Count < 2)
                dgvProductos.EditMode = DataGridViewEditMode.EditOnF2;
            else
                dgvProductos.EditMode = DataGridViewEditMode.EditOnEnter;

            dgvProductos.CurrentCell = dgvProductos[Opciones.Campo.CODIGO, iCell];
            dgvProductos.SelectAll();
        }

        private void dgvProductos_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Finalizar editado
                dgvProductos.EndEdit();
                
                Venta aux = new Venta();
                ProductoNegocio productoNegocio = new ProductoNegocio();

                aux = productoNegocio.busquedaCodigo(dgvProductos[Opciones.Campo.CODIGO, iCell].Value.ToString());

                if (aux.Codigo == dgvProductos[Opciones.Campo.CODIGO, iCell].Value.ToString())
                {
                    listaVentas.Add(aux);
                    Venta eraser = listaVentas.Find(x => string.IsNullOrEmpty(x.Nombre));
                    listaVentas.Remove(eraser);
                    listaVentas.Add(new Venta());
                    iCell++;
                }

                dgvProductos.DataSource = null;
                cargarGridView();
            }
        }

        private void dgvProductos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DataGridViewTextBoxEditingControl txt)
            {
                txt.PreviewKeyDown -= new PreviewKeyDownEventHandler(dgvProductos_PreviewKeyDown);
                txt.PreviewKeyDown += new PreviewKeyDownEventHandler(dgvProductos_PreviewKeyDown);
            }
        }
    }
}
