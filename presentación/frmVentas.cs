using configuracion;
using dominio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace presentación
{
    public partial class frmVentas : Form
    {
        List<Venta> listaVentas = null;
        int row = 0;
        int column = 0;

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

            foreach(DataGridViewColumn c in dgvProductos.Columns)
            {
                c.ReadOnly = true;
            }

            DataGridViewTextBoxColumn textBoxColumn = new DataGridViewTextBoxColumn();
            textBoxColumn.Name = "TEXTO";
            textBoxColumn.HeaderText = "TEXTO";
            textBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            textBoxColumn.ReadOnly = false;
            dgvProductos.Columns.Add(textBoxColumn);
        }

        void ItemTxtBox_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text != null)
            {
                MessageBox.Show((sender as TextBox).Text);
            }
        }

        private void dgvProductos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvProductos.CurrentCell.ColumnIndex == 0)
            {

                TextBox tb = (TextBox)e.Control;

                tb.TextChanged += new EventHandler(tb_TextChanged);

            }
        }

        void tb_TextChanged(object sender, EventArgs e)

        {
            //TEST
            MessageBox.Show("changed");

        }

    }
}
