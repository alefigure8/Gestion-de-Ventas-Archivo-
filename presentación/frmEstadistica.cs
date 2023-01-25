using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;
using helper;

namespace presentación
{
    public partial class frmEstadistica : Form
    {
        private Form parent;

        public frmEstadistica(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmEstadistica_Load(object sender, EventArgs e)
        {
            cargarDateTimePicker();
        }

        private void btnEstadisticaSemanal_Click(object sender, EventArgs e)
        {
            frmEstadisticaSemanales screen = new frmEstadisticaSemanales(parent);
            screen.MdiParent = parent;
            screen.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panelContainerOprions.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void btnDiario_Click(object sender, EventArgs e)
        {
            frmEstadisticaDiaria screen = new frmEstadisticaDiaria();
            screen.MdiParent = parent;
            screen.Show();
        }

        private void cargarDateTimePicker()
        {
            string dateFormat = "dd/MM/yyyy";
            dateStart.Format = DateTimePickerFormat.Custom;
            dateStart.CustomFormat = dateFormat;
            dateEnd.Format = DateTimePickerFormat.Custom;
            dateEnd.CustomFormat = dateFormat;
        }

        private void btnPeriodo_Click(object sender, EventArgs e)
        {
            if (Validacion.esMayorLaFechaDeInicio(dateStart, dateEnd))
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha de finalización");
            }
            else
            {
                frmEstadisticaPeriodo screen = new frmEstadisticaPeriodo(dateStart.Value, dateEnd.Value);
                screen.MdiParent = parent;
                screen.Show();
            }
        }
    }
}
