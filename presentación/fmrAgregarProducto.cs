using configuracion;
using dominio;
using helper;
using negocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace presentación
{
    public partial class fmrAgregarProducto : Form
    {
        Producto producto = null;
        Producto productoAux= null;
        private OpenFileDialog file = null;
        List<Marca> listaMarca = null;
        List<Producto> listaProducto = null;
        List<Categoria> listaCategoria = null;
        List<TextBox> listaTxt;
        List<Label> listaLabel;
        bool vista;
        Form parent;

        public fmrAgregarProducto(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        public fmrAgregarProducto(Producto producto, Form parent, bool vista = true)
        {
            InitializeComponent();


            if(producto != null)
                this.producto = producto;

            this.vista = vista;
            this.parent = parent;
        }

        //**** METODOS ****//
        private void modoVista()
        {
            this.vista = true;

            btnCancelar.Text = Opciones.Btn.REGRESAR;
            pbDeleteImage.Visible = false;
            btnBorrar.Visible = false;
            lbCheckStock.Visible = false;
            checkStockUpdate.Visible = false;
            cargarFechas(true);
            lbTituloCargarProducto.Text = "PRODUCTO";
            btnAgregarProducto.Text = Opciones.Btn.EDITAR;
            btnAgregarImagen.Visible = false;
            Metodos.textBoxReadOnly(listaTxt);
            Metodos.disableComboBox(cbMarca);
            Metodos.disableComboBox(cbCategoria);
        }

        private void modoModificar()
        {
            this.vista = false;

            btnCancelar.Text = Opciones.Btn.CANCELAR;
            pbDeleteImage.Visible = true;
            btnBorrar.Visible = true;
            lbCheckStock.Visible = true;
            checkStockUpdate.Visible = true;
            cargarFechas(true);
            lbTituloCargarProducto.Text = "MODIFICAR PRODUCTO";
            btnAgregarProducto.Text = Opciones.Btn.MODIFICAR;
            btnAgregarImagen.Visible = true;
            Metodos.textBoxReadOnly(listaTxt, false);
            Metodos.enableComboBox(cbMarca);
            Metodos.enableComboBox(cbCategoria);

            enbableStockUpdate();
        }

        private void modoAgregar()
        {
            producto = null;

            btnCancelar.Text = Opciones.Btn.CANCELAR;
            pbDeleteImage.Visible = false;
            btnBorrar.Visible = false;
            lbCheckStock.Visible = false;
            checkStockUpdate.Visible = false;
            cargarFechas();
            lbTituloCargarProducto.Text = "AGREGAR PRODUCTO";
            btnAgregarProducto.Text = Opciones.Btn.AGREGAR;
            btnAgregarImagen.Visible = true;
            Metodos.textBoxReadOnly(listaTxt, false);
            Metodos.enableComboBox(cbMarca);
            Metodos.enableComboBox(cbCategoria);
        }

        private void clonarObjeto()
        {
            productoAux = new Producto();
            productoAux.Id = producto.Id;
            productoAux.Codigo = producto.Codigo;
            productoAux.Nombre = producto.Nombre;
            productoAux.Descripcion = producto.Descripcion;
            productoAux.Precio = producto.Precio;
            productoAux.ImagenURL = producto.ImagenURL;
            productoAux.Stock = producto.Stock;
            Categoria categoriaAux = new Categoria();
            categoriaAux.Id = producto.CategoriaInfo.Id;
            categoriaAux.Descripcion = producto.CategoriaInfo.Descripcion;
            Marca marcaAux = new Marca();
            marcaAux.Id = producto.MarcaInfo.Id;
            marcaAux.Descripcion = producto.Descripcion;
            productoAux.CategoriaInfo = categoriaAux;
            productoAux.MarcaInfo = marcaAux;
        }

        private void cerrarScreen()
        {
            frmPrincipal screen = new frmPrincipal(parent);
            screen.MdiParent = parent;
            screen.Show();
            this.Close();
        }

        private void cargarFormulario()
        {
            //TextBoxes
            lbID.Text = productoAux.Id.ToString();
            txtAgregarCodigo.Text = productoAux.Codigo;
            txtAgregarArticulo.Text = productoAux.Nombre;
            txtAgregarDescripcion.Text = productoAux.Descripcion;
            txtAgregarPrecio.Text = productoAux.Precio.ToString();
            txtCosto.Text = productoAux.Costo.ToString();
            txtStock.Text = productoAux.Stock.ToString();
            txtAgregarImagen.Text = productoAux.ImagenURL;

            //ComboBoxes
            cbCategoria.SelectedItem = productoAux.CategoriaInfo.Id;
            cbMarca.SelectedItem = productoAux.MarcaInfo.Id;
            //cbMarca.SelectedValue = productoAux.CategoriaInfo.Id;

            Metodos.cargarimagen(pbCargarProducto, productoAux.ImagenURL);
        }

        private void cargarImagenes()
        {
            //string path = Path.GetDirectoryName(Directory.GetCurrentDirectory().Replace(@"\bin", "")) + Opciones.Folder.ROOTIMAGE;
            string path = Path.GetDirectoryName(Directory.GetCurrentDirectory()) + Opciones.Folder.ROOTIMAGE;
            btnConfigureCategoria.BackgroundImage = System.Drawing.Image.FromFile(path + Opciones.Folder.CONFIGURACION);
            btnConfigureMarca.BackgroundImage = System.Drawing.Image.FromFile(path + Opciones.Folder.CONFIGURACION);
            pbDeleteImage.Load(path + Opciones.Folder.ELIMINAR);
        }

        //**** EVENTOS ****//
        private void fmrAgregarProducto_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            ProductoNegocio productoNegocio = new ProductoNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            ComboBoxOptions.comboBoxMarca(cbAgregarMarca);
            ComboBoxOptions.comboBoxMarca(cbMarca);
            ComboBoxOptions.comboBoxCategoria(cbAgregarcategoria);
            ComboBoxOptions.comboBoxCategoria(cbCategoria);

            cbMarca.ValueMember = Opciones.Campo.ID;
            cbMarca.DisplayMember = Opciones.Campo.DESCRIPCION; 

            cbAgregarMarca.ValueMember = Opciones.Campo.ID;
            cbAgregarMarca.DisplayMember = Opciones.Campo.DESCRIPCION;

            cbCategoria.ValueMember = Opciones.Campo.ID;
            cbCategoria.DisplayMember = Opciones.Campo.DESCRIPCION;

            cbAgregarcategoria.ValueMember = Opciones.Campo.ID;
            cbAgregarcategoria.DisplayMember = Opciones.Campo.DESCRIPCION;


            listaMarca = marcaNegocio.listar();
            listaProducto = productoNegocio.listar();
            listaCategoria = categoriaNegocio.listar();

            cargarImagenes();

            cargarGUI();

            listaTxt = new List<TextBox>()
            {
                txtAgregarCodigo,
                txtAgregarArticulo,
                txtAgregarDescripcion,
                txtAgregarPrecio,
                txtCosto,
                txtStock,
                txtAgregarImagen
            };

            listaLabel = new List<Label>()
            {
                lbErrorCodigo,
                lbErrorArticulo,
                lbErrorDescripcion,
                lbErrorPrecio,
                lbErrorCosto,
                lbErrorStock,
                lbErrorImagen
            };

            Metodos.errorInvisible(listaLabel);

            //Modo
            if (producto != null)
            {
                //Carga formulario con los datos del objeto a editar
                lbID.Text = producto.Id.ToString();
                txtAgregarCodigo.Text = producto.Codigo;
                txtAgregarArticulo.Text = producto.Nombre;
                txtAgregarDescripcion.Text = producto.Descripcion;
                txtAgregarPrecio.Text = producto.Precio.ToString();
                txtStock.Text = producto.Stock.ToString();
                txtCosto.Text = producto.Costo.ToString();
                txtAgregarImagen.Text = producto.ImagenURL;
                cbCategoria.SelectedValue = producto.CategoriaInfo.Id;
                cbMarca.SelectedValue = producto.MarcaInfo.Id;
                lbModificado.Text = producto.Modifiado.ToString("dd/MM/yyyy");
                lbStockModificado.Text = producto.StockModificado.ToString("dd/MM/yyyy");
                lbFechaCreacion.Text = producto.Creado.ToString("dd/MM/yyyy");
                Metodos.cargarimagen(pbCargarProducto, producto.ImagenURL);

                clonarObjeto();

                //Modo vista o edición
                if (this.vista)
                    modoVista();
                else
                    modoModificar();
            }
            else
            {
                modoAgregar();
            }

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

            //Crear producto si no es una modificación
            if(producto == null)
                 producto = new Producto();

            //Habilitar campos para editar
            if (this.vista)
            {
                modoModificar();
                return;
            }

            // Variables formulario
            int Id = int.Parse(lbID.Text);
            string codigo = txtAgregarCodigo.Text.Trim();
            string nombre = txtAgregarArticulo.Text.Trim();
            string descripcion = txtAgregarDescripcion.Text.Trim();
            string imagenURL = txtAgregarImagen.Text.Trim();
            string precio = txtAgregarPrecio.Text.Trim();
            string costo = txtCosto.Text.Trim();
            string stock = txtStock.Text.Trim();

            Marca marca;
            Categoria categoria;

            //Validar ComboBox
            if (Validacion.estaSeleccionado(cbMarca) && Validacion.estaSeleccionado(cbCategoria))
            {
               marca  = (Marca)cbMarca.SelectedItem;
               categoria  = (Categoria)cbCategoria.SelectedItem;
            }
            else
            {
                MessageBox.Show("Marca o Categoria sin seleccionar");
                return;
            }

            //Resetear las labels error en visible false
            Metodos.errorInvisible(listaLabel);

            //Mostrar labels error
            if(Validacion.estaVacio(listaTxt).Contains(true))
            {
                 Metodos.mostrarErrorCampoVacio(listaTxt, listaLabel);
                return;
            }

            if (!Validacion.esNumero(precio) || !Validacion.esNumero(costo) || !Validacion.esNumero(stock))
            {

                //Validar Numeros
                if (!Validacion.esNumero(precio))
                {
                    Metodos.agregarToolTip(lbErrorPrecio, "Solo puede ser un número");
                    lbErrorPrecio.Visible = true;
                }

                if (!Validacion.esNumero(costo))
                {
                    Metodos.agregarToolTip(lbErrorCosto, "Solo puede ser un número");
                    lbErrorCosto.Visible = true;
                }

                if (!Validacion.esNumero(stock))
                {
                    Metodos.agregarToolTip(lbErrorStock, "Solo puede ser un número");
                    lbErrorStock.Visible = true;
                }

                return;
            }

            producto.Id = Id;
            producto.Codigo = codigo;
            producto.Precio = Convert.ToDecimal(precio.Replace(".", ","));
            producto.Costo = Convert.ToDecimal(costo.Replace(".", ","));
            producto.Stock = Convert.ToInt32(stock);
            producto.Nombre = nombre;
            producto.Descripcion = descripcion;
            producto.ImagenURL = imagenURL;
            producto.MarcaInfo= marca;
            producto.CategoriaInfo= categoria;

            Metodos.cargarimagen(pbCargarProducto, imagenURL);

            ProductoNegocio productoNegocio = new ProductoNegocio();

            // Agregar producto nuevo
            if(producto.Id == 0)
            {
                //Validar si codigo ya se encuentra cargado
                if (listaProducto.Any(prod => prod.Codigo.ToLower() == codigo.ToLower()))
                {
                    MessageBox.Show("El codigo que intenta ingresar ya existe");
                    return;
                }

                //Guardar
                try
                {
                    try
                    {
                        //Copir imagen cargada desde Archivos
                        if (file != null && !txtAgregarImagen.Text.ToLower().Contains("http"))
                        {
                            Metodos.copiarImagen(producto, file, txtAgregarImagen);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cambie la imagen y luego intenté guardar nuevamente");
                        file = null;
                        return;
                    }

                    // Guardar producto en la base de datos
                    if (productoNegocio.agregar(producto))
                    {
                        //Reset Formulario
                        Metodos.vaciarTextBox(listaTxt);

                        //Permanecer en modo Agregar
                        modoAgregar();

                        //Mensaje de producto agregado
                        MessageBox.Show("El producto fue agregado con éxito");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("El producto no pudo ser cargado");
                }
            }
            else
            {
                try
                {
                    try
                    {

                        if (file != null && !txtAgregarImagen.Text.ToLower().Contains("http"))
                        {
                            Metodos.copiarImagen(producto, file, txtAgregarImagen);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cambie la imagen y luego intenté guardar nuevamente");
                        file = null;
                        return;
                    }

                    //Actualizar fecha de Stock
                    if(checkStockUpdate.Checked)
                        producto.StockModificado = DateTime.Now;

                    if (productoNegocio.modificar(producto))
                    {

                        //Cambiar vista de edición a vista
                        modoVista();

                        MessageBox.Show("El producto fue modificado");
                    }
                }
                catch (Exception ex)
                {
                    if(productoAux != null)
                    {
                        cargarFormulario();
                    }

                    MessageBox.Show("El producto no pudo ser modificar");
                }
            }
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            CategoriaNegocio categoria = new CategoriaNegocio();

            if (string.IsNullOrEmpty(cbAgregarcategoria.Text))
            {
                MessageBox.Show(Opciones.MensajeError.CAMPOVACIOTEXTO);
                return;
            }

            if (!categoria.existeCategoria(cbAgregarcategoria.Text))
            {
                try
                {
                    MessageBoxButtons btnAgregar = MessageBoxButtons.OKCancel;
                    DialogResult respuesta =  MessageBox.Show($"¿Está seguro que quiere agregar a Categoría {cbAgregarcategoria.Text}?", "Agregar Categoria", btnAgregar);

                    if (respuesta == DialogResult.OK)
                    { 
                        if (categoria.agregar(cbAgregarcategoria.Text))
                        {
                            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

                            //Recargar ComboBoxes
                            ComboBoxOptions.comboBoxCategoria(cbAgregarcategoria);
                            ComboBoxOptions.comboBoxCategoria(cbCategoria);
                            listaCategoria = categoriaNegocio.listar();
                            MessageBox.Show(Opciones.MensajeExito.EXITOCARGARMENSAJE);
                        }
                    }

                    return;
                }
                catch (Exception)
                {
                    MessageBox.Show(Opciones.MensajeError.ERRORCARGAMARCA);
                }

                return;
            }

            MessageBox.Show(Opciones.MensajeError.MARCAYAEXISTE);
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio= new MarcaNegocio();

            if (string.IsNullOrEmpty(cbAgregarMarca.Text))
            {
                MessageBox.Show(Opciones.MensajeError.CAMPOVACIOTEXTO);
                return;
            }

            if (!negocio.existeMarca(cbAgregarMarca.Text))
            {
                try
                {
                    MessageBoxButtons btnAgregar = MessageBoxButtons.OKCancel;
                    DialogResult respuesta = MessageBox.Show($"¿Está seguro que quiere agregar a Marca {cbAgregarMarca.Text}?", "Agregar Marca", btnAgregar);

                    if(respuesta == DialogResult.OK)
                    {

                        if (negocio.agregar(cbAgregarMarca.Text))
                        {
                            MarcaNegocio marcaNegocio = new MarcaNegocio();

                            //Recargar ComboBoxes
                            ComboBoxOptions.comboBoxMarca(cbAgregarMarca);
                            ComboBoxOptions.comboBoxMarca(cbMarca);
                            listaMarca.Clear();
                            listaMarca = marcaNegocio.listar();
                            MessageBox.Show(Opciones.MensajeExito.EXITOCARGARMENSAJE);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(Opciones.MensajeError.ERRORCARGAMARCA);
                }

                return;
            }

            MessageBox.Show(Opciones.MensajeError.MARCAYAEXISTE);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            if (Validacion.estaVacio(listaTxt).Contains(true))
            {
                cerrarScreen();
            }
            else
            {
                if(btnAgregarProducto.Text == Opciones.Btn.MODIFICAR)
                {
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show("Si cancela todos los datos se perderan", "Advertencia", btn);

                    if (result == DialogResult.OK)
                    {
                        modoVista();
                        cargarFormulario();
                    }
                }
                else
                {
                    cerrarScreen();
                }
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            file = new OpenFileDialog();
            file.Filter = "All|*|Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff|Wmf Image (.wmf)|*.wmf";
            
            if (file.ShowDialog() == DialogResult.OK)
            {
                txtAgregarImagen.Text = file.FileName;
                try
                {
                    Metodos.cargarimagen(pbCargarProducto, file.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("La iamgen no pudo ser cargada");
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            ProductoNegocio productoNegocio = new ProductoNegocio();
            MessageBoxButtons btnCancel= MessageBoxButtons.OKCancel;
            MessageBoxIcon iconCancel = MessageBoxIcon.Warning;
            DialogResult result = MessageBox.Show($"¿Está seguro que quiere eliminar el artículo {producto.Nombre}?", "Eliminar", btnCancel, iconCancel);
            if (result == DialogResult.OK)
            {
                if (productoNegocio.borrar(producto.Id))
                {
                    MessageBox.Show("El producto fue borrado");
                    cerrarScreen();
                }
            }
        }

        private void pbDeleteImage_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btnConfirmar = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show("¿Esta seguro que quiere eliminiar la imagen?", "Eliminar imagen",btnConfirmar);

            if(result == DialogResult.OK)
            {
                Metodos.borrarImagen(producto, txtAgregarImagen);
            }
            Metodos.cargarimagen(pbCargarProducto, txtAgregarImagen.Text);
        }

        private void btnConfigureMarca_Click(object sender, EventArgs e)
        {
            Marca aux = listaMarca.Find(c => c.ToString() == cbAgregarMarca.Text);

            if(aux != null)
            {
                frmConfiguracionCategoriaMarca screen = new frmConfiguracionCategoriaMarca(aux, this.producto, this.parent, this);
                screen.ShowDialog();
            }
        }

        private void btnConfigureCategoria_Click(object sender, EventArgs e)
        {
            Categoria aux = listaCategoria.Find(c => c.ToString() == cbAgregarcategoria.Text);

            if(aux != null)
            {
                frmConfiguracionCategoriaMarca screen = new frmConfiguracionCategoriaMarca(aux, this.producto, this.parent, this);
                screen.ShowDialog();
            }
        }

        private void cbAgregarcategoria_TextChanged(object sender, EventArgs e)
        {
            if(listaCategoria != null)
                Metodos.buscarEnLista<Categoria>(listaCategoria, cbAgregarcategoria, btnConfigureCategoria);
        }

        private void cbAgregarMarca_TextChanged(object sender, EventArgs e)
        {
            if (listaMarca != null)
             Metodos.buscarEnLista<Marca>(listaMarca, cbAgregarMarca, btnConfigureMarca);
        }

        private void cargarGUI()
        {
            if (listaCategoria != null)
                Metodos.buscarEnLista<Categoria>(listaCategoria, cbAgregarcategoria, btnConfigureCategoria);

            if (listaMarca != null)
                Metodos.buscarEnLista<Marca>(listaMarca, cbAgregarMarca, btnConfigureMarca);
        }

        private void checkStockUpdate_CheckedChanged(object sender, EventArgs e)
        {
            enbableStockUpdate();
        }

        private void enbableStockUpdate()
        {
            if(checkStockUpdate.Checked)
                txtStock.ReadOnly = false;
            else
                txtStock.ReadOnly = true;
        }

        private void cargarFechas(bool visible = false)
        {
            panelFechas.Visible = visible;
            panelFechasTitulo.Visible = visible;
            lbFechaTitulo.Visible = visible;
            lbModificado.Visible = visible;
            lbStockModificado.Visible = visible;
            lbTextoModificado.Visible = visible;
            lbTextoFechaCreacion.Visible = visible;
            lbFechaCreacion.Visible = visible;
            lbTextStockModificado.Visible = visible;
        }
    }
}
