using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentación
{
    public partial class frmCantidadVentas : Form
    {
        public int cantidad { get; set; }
        public frmCantidadVentas()
        {
            InitializeComponent();
            this.cantidad = 1;
            numericCantidad.Value = 1;
            numericCantidad.Select(0, numericCantidad.Text.Length);
        }

        private void numericCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.cantidad = int.Parse(numericCantidad.Value.ToString());
                this.Close();
            }
        }
    }
}
