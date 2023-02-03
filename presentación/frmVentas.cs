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
        Ventas ventaFinal;
        frmPrincipal screen;
        int idCliente;

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

            //Iniciar Ventas
            ventaFinal = new Ventas();
            
            //Cargar view
            cargarGridView();

            //settings
            this.KeyPreview = true;
            txtCliente.Text = "Cliente Ocasional";
            idCliente = 0;

        }

        private void cargarGridView()
        {
            dgvProductos.DataSource = listaVentas;
            dgvProductos.Columns[Opciones.Campo.DESCRIPCION].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProductos.Columns[Opciones.Campo.ID].Visible = false;
            dgvProductos.Columns[Opciones.Campo.URLIMAGEN].Visible = false;
            dgvProductos.Columns[Opciones.Campo.MODIFICADO].Visible = false;
            dgvProductos.Columns[Opciones.Campo.CREADO].Visible = false;
            dgvProductos.Columns[Opciones.Campo.STOCKMODIFICADO].Visible = false;
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

                    //Buscar el producto por codigo
                    aux = productoNegocio.busquedaCodigo(dgvProductos[Opciones.Campo.CODIGO, iCell].Value.ToString());

                    //Agregar producto a la lista
                    if (aux.Codigo.ToLower() == dgvProductos[Opciones.Campo.CODIGO, iCell].Value.ToString().ToLower())
                    {
                        //Setting
                        aux.Cantidad = cantidad;
                        aux.Total = (cantidad * aux.Precio);

                        //Carhar producto en la lista de venta
                        listaVentas.Add(aux);

                        //Colocar último el objeto tipo para búsqueda
                        reiniciarAgregarProducto();

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

            if (e.KeyCode.ToString() == "F2")
            {
                //Cargar pantalla de busqueda
                screen = new frmPrincipal(this.screen, true);
                screen.ShowDialog();

                if (screen.codigo != null)
                {
                    editGridView(screen.codigo);
                }
            }

            if (e.KeyCode.ToString() == "F3")
            {
                //Cargar pantalla de producto libre
                frmAgregarLibre screen = new frmAgregarLibre();
                screen.ShowDialog();
                
                if (screen.producto != null)
                {
                    Venta aux = new Venta();
                    aux.Id = screen.producto.Id;
                    aux.Codigo = screen.producto.Codigo;
                    aux.Nombre = screen.producto.Nombre;
                    aux.Descripcion = screen.producto.Descripcion;
                    aux.Precio = screen.producto.Precio;
                    aux.Cantidad = this.cantidad;
                    aux.Total = aux.Cantidad * aux.Precio;

                    this.listaVentas.Add(aux);

                    //Reiniciar Grid
                    reiniciarAgregarProducto();
                    
                    this.cantidad = 1;
                    iCell++;

                    cargarGUI();
                }
            }
        }

        private void editGridView(string value = "Ingrese Código")
        {
            //Reado only true
            foreach (DataGridViewColumn c in dgvProductos.Columns)
            {
                c.ReadOnly = true;
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //setting celda de búsqueda
            DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
            this.dgvProductos[Opciones.Campo.CODIGO, iCell] = cell;
            cell.Value = value;
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

            cargarDescuento();
            cargarIVA();
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
                decimal aux = total;
                total = aux * 1.210M;
                iva = total - aux;
            }
            else
            {
                iva = 0;
            }
        }

        private void cargarDescuento()
        {
            if (!string.IsNullOrEmpty(txtDescuento.Text) && Validacion.esNumero(txtDescuento.Text))
            {
                descuento = decimal.Parse(txtDescuento.Text);
                decimal totalDescuento = (descuento * subTotal) / 100;
                total -= totalDescuento;
                descuento = totalDescuento;
            }
            else
            {
                descuento = 0;
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

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            actualizarTotal();
        }

        private void dgvProductos_KeyDown(object sender, KeyEventArgs e)
        {
            //Borrar producto de lista si se preciona delete;
            if(e.KeyCode == Keys.Delete && dgvProductos.CurrentRow.Index != iCell)
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

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            try
            {
                if(listaVentas.Count > 1)
                {
                    //Guardar la venta final en el archivo de ventas
                    //ventaFinal.Total = total;
                    ventaFinal.Total = subTotal;
                    ventaFinal.Fecha = Convert.ToDateTime(txtFecha.Text);
                    ventaFinal.Venta = listaVentas;
                    ventaFinal.id_cliente = idCliente;

                    string auxImpuesto = lbIVAPorcentaje.Text.Replace(".", ",");
                    decimal auxImpuestoParse = decimal.Parse(auxImpuesto);
                    if (checkIVA.Checked)
                        ventaFinal.Impuesto = Convert.ToDecimal(auxImpuesto);
                    else
                        ventaFinal.Impuesto = 0m;

                    if(!string.IsNullOrEmpty(txtDescuento.Text))
                        ventaFinal.Descuento = Convert.ToDecimal(txtDescuento.Text);

                    VentaNegocio ventaNegocio = new VentaNegocio();

                    //Ventana resumen
                    frmVentaFinalizar screen = new frmVentaFinalizar(ventaFinal, descuento, subTotal, iva);
                    screen.ShowDialog();
                    DialogResult result = screen.result;
                    ventaFinal.Credit = screen.credit;

                    if(result == DialogResult.OK)
                    {
                        if (ventaNegocio.agregar(ventaFinal))
                        {
                            //Actualizar stock en el archivo de Productos
                            ProductoNegocio productoNegocio = new ProductoNegocio();
                            List<Producto> listaProductos = productoNegocio.listar();

                            //Actualizar stock de los productos
                            foreach (var item in listaVentas)
                            {
                                listaProductos.ForEach(prod =>
                                {
                                    if (item.Id == prod.Id)
                                    {
                                        prod.Stock -= item.Cantidad;
                                    }
                                });
                            }

                            //Actualiza toda la lista general para modficar el stock luego de una venta
                            productoNegocio.modificarLista(listaProductos);
                        }

                        MessageBox.Show("Venta Generada con éxito");

                        borrarLista();
                    }

                }
                else
                {
                    MessageBox.Show("Aún no hay ventas");
                }
            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.Message);
            }
        }

        private void borrarLista()
        {
            //Borramos todos
            listaVentas.Clear();

            //Insertamos un objeto vacío para la búsqueda
            listaVentas = new List<Venta>()
            {
                new Venta()
            };

            //reset numero de celda
            iCell = 0;

            //Cargamos grid
            cargarGUI();

            //Configuración inicial
            txtCliente.Text = "Cliente Ocasional";
            idCliente = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show("¿Está seguro que quiere cancelar la venta?", "Cancelar Venta", btn);

            //Validar cancelar la venta
            if (result == DialogResult.OK)
                borrarLista();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if(txtCliente.Text == "Cliente Ocasional" || txtCliente.Text == "")
            {
                frmCliente screen = new frmCliente();
                screen.ShowDialog();
                idCliente = screen.idCliente;
                txtCliente.Text = null;
                txtCliente.Text = screen.cliente;
                btnAgregarCliente.Text = "Quitar";
            }
            else
            {
                txtCliente.Text = "Cliente Ocasional";
                idCliente = 0;
                btnAgregarCliente.Text = "Agregar";

            }
        }

        private void reiniciarAgregarProducto()
        {
            //Colocar último el objeto tipo para búsqueda
            Venta eraser = listaVentas.Find(x => string.IsNullOrEmpty(x.Nombre));
            listaVentas.Remove(eraser);
            listaVentas.Add(new Venta());
        }
    }
}
