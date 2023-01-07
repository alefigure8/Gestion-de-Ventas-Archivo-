using configuracion;
using dominio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using negocio;
using helper;

namespace presentación
{
    public partial class frmVentas : Form
    {
        List<Venta> listaVentas = null;
        int iCell;
        int cantidad;
        decimal subTotal;
        decimal total;
        decimal iva;
        decimal descuento;

        public frmVentas()
        {
            InitializeComponent();

            this.iCell = 0;
            this.cantidad = 1;
            this.subTotal = 0;
            this.total = 0;
            this.iva = 0;
            this.descuento = 0;
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            cargarFecha();

            //Agregar a la lista de ventas un objeto de tipo venta
            listaVentas = new List<Venta>()
            {
                new Venta()
            };
            
            cargarGridView();

            //settings
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
            
            cargarTotal();
            editGridView();
        }

        private void dgvProductos_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Finalizar editado para poder tomar valores de la celda
                dgvProductos.EndEdit();

                if (!string.IsNullOrEmpty(dgvProductos[Opciones.Campo.CODIGO, iCell].Value.ToString()))
                {
                    Venta aux = new Venta();
                    ProductoNegocio productoNegocio = new ProductoNegocio();

                    //Buscar el prodicto por codigo
                    aux = productoNegocio.busquedaCodigo(dgvProductos[Opciones.Campo.CODIGO, iCell].Value.ToString());

                    //Agregar producto a la lista
                    if (aux.Codigo == dgvProductos[Opciones.Campo.CODIGO, iCell].Value.ToString())
                    {
                        //Setting
                        aux.Cantidad = cantidad;
                        aux.Total = cantidad * aux.Precio;
                        
                        //Carhar producto en la lista de venta
                        listaVentas.Add(aux);
                        Venta eraser = listaVentas.Find(x => string.IsNullOrEmpty(x.Nombre));
                        
                        //Colocar último el objeto tipo para búsqueda
                        listaVentas.Remove(eraser);
                        listaVentas.Add(new Venta());
                        
                        this.cantidad = 1;
                        iCell++;
                    }

                    //Cargar la lista en el gridview
                    cargarGUI();
                }
            }

            if (e.KeyCode.ToString() == "F1")
            {
                //Cargar ventana de cantidad de items por producto
                frmCantidadVentas screen = new frmCantidadVentas();
                screen.ShowDialog();
                this.cantidad = screen.cantidad;
            }
        }

        private void editGridView()
        {
            //Reado only true
            foreach (DataGridViewColumn c in dgvProductos.Columns)
            {
                c.ReadOnly = true;
            }

            //setting celda de búsqueda
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

            //Seleccionar texto en la celda de búsqueda
            dgvProductos.CurrentCell = dgvProductos[Opciones.Campo.CODIGO, iCell];
            dgvProductos.SelectAll();
        }

        private void dgvProductos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DataGridViewTextBoxEditingControl txt)
            {
                txt.PreviewKeyDown -= new PreviewKeyDownEventHandler(dgvProductos_PreviewKeyDown);
                txt.PreviewKeyDown += new PreviewKeyDownEventHandler(dgvProductos_PreviewKeyDown);
            }
        }
        
        private void cargarFecha()
        {
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        
        private void actualizarTotal()
        {
            subTotal = 0;

            foreach (Venta item in listaVentas)
            {
                subTotal += item.Total;
                total = subTotal;
            }

            cargarIVA();
            cargarDescuento();
            cargarTotal();
        }

        private void checkIVA_CheckedChanged(object sender, EventArgs e)
        {
            actualizarTotal();
        }

        private void cargarTotal()
        {
            lbSubTotalPrecio.Text = subTotal.ToString("c");
            lbTotalPrecio.Text = total.ToString("c");
            lbIVAPrecio.Text = iva.ToString("c");
            lbTotalDescuento.Text = descuento > 0 ? "-" + descuento.ToString("c") : descuento.ToString("c");
        }
        
        private void cargarIVA()
        {

            if (checkIVA.Checked)
            {
                decimal aux = subTotal;
                total = aux * 1.210M;
                iva = total - aux;
            }
            else
            {
                total = subTotal;
                iva = 0;
            }
        }

        private void cargarCantidadItems()
        {
            int total = 0;

            foreach(var item in listaVentas)
            {
                total += item.Cantidad;
            }
            lbCantidadItemsTotal.Text = total.ToString();
        }

        private void cargarCantidadProducto()
        {
            int total = 0;
            Dictionary<string, int> dic = new Dictionary<string, int>();

            foreach(var item in listaVentas)
            {
                if (!dic.ContainsKey(item.Codigo) && item.Codigo != "Ingrese Código")
                {
                    dic[item.Codigo] = 1;
                }
            }

            foreach(var item in dic)
            {
                total += item.Value;
            }

            lbCantidadProductosTotal.Text = total.ToString();
        }

        private void cargarDescuento()
        {
            if (!string.IsNullOrEmpty(txtDescuento.Text) && Validacion.esNumero(txtDescuento.Text))
            {
                descuento = decimal.Parse(txtDescuento.Text);
                decimal totalDescuento = (descuento * total) / 100;
                total -= totalDescuento;
                descuento = totalDescuento;
            }
            else
            {
                descuento = 0;
            }
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            actualizarTotal();
        }

        private void dgvProductos_KeyDown(object sender, KeyEventArgs e)
        {
            //Borrar producto de lista si se preciona delete;
            if(e.KeyCode == Keys.Delete)
            {
               MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show("Está por borrar un producto. ¿Está seguro?", "Borrar", btn);

                if(result == DialogResult.OK)
                {
                    int i = dgvProductos.CurrentRow.Index;
                    listaVentas.Remove(listaVentas[i]);
                    iCell--;
                    cargarGUI();
                }
            }
        }

        private void cargarGUI()
        {
            dgvProductos.DataSource = null;
            cargarGridView();
            actualizarTotal();
            cargarCantidadItems();
            cargarCantidadProducto();
        }
    }
}
