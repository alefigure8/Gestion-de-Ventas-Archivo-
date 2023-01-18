using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace presentación
{
    public partial class frmVentaFinalizar : Form
    {
        Ventas ventas;
        public bool credit { get; set; }
        public DialogResult result { get; set; }
        private decimal descuento;
        private decimal subTotal;
        private decimal impuesto;

        public frmVentaFinalizar(Ventas ventas, decimal descuento, decimal subTotal, decimal impuesto)
        {
            InitializeComponent();

            //Valores por Defaults
            this.ventas = ventas;
            this.credit = ventas.Credit;
            result = DialogResult.Cancel;
            this.descuento = descuento;
            this.subTotal = subTotal;
            this.impuesto = impuesto;
        }

        public frmVentaFinalizar()
        {
            InitializeComponent();
        }

        private void frmVentaFinalizar_Load(object sender, EventArgs e)
        {
            initCheckBox();
            cargarGUI();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;
            credit = checkTarjeta.Checked;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            result = DialogResult.Cancel;
            credit = checkTarjeta.Checked;
            this.Close();
        }

        private void checkEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if(checkEfectivo.Checked)
            {
                if(checkTarjeta.Checked)
                {
                    checkTarjeta.Checked = false;
                }
            }
            else
            {
                if (!checkTarjeta.Checked)
                {
                    checkTarjeta.Checked = true;
                }
            }
        }

        private void checkTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTarjeta.Checked)
            {
                if (checkEfectivo.Checked)
                {
                    checkEfectivo.Checked = false;
                }
            }
            else
            {
                if (!checkEfectivo.Checked)
                {
                    checkEfectivo.Checked = true;
                }
            }
        }

        private void initCheckBox()
        {
            //Configurar CkeckBox
            checkTarjeta.Checked = credit;
            checkEfectivo.Checked = !credit;
        }

        private void cargarGUI()
        {
            lbDescuentoPrecio.Text = $"-{descuento.ToString("c")}";
            lbSubTotalPrecio.Text = subTotal.ToString("c");
            lbImpuestoPrecio.Text = impuesto.ToString("c");
            lbTotalAPagar.Text = ventas.Total.ToString("c");
        }
    }
}
