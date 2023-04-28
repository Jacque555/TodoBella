using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.TodaBella
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void lblRegistro_DoubleClick(object sender, EventArgs e)
        {
            FrmClienteAdd fca= new FrmClienteAdd();
            fca.Show();
        }

        private void lblCliente_DoubleClick(object sender, EventArgs e)
        {
            FrmCliente fc = new FrmCliente();
            fc.Show();
        }

        private void lblCitas_DoubleClick(object sender, EventArgs e)
        {
            FrmAgendamiento fa = new FrmAgendamiento();
            fa.Show();
        }

        private void lblPago_DoubleClick(object sender, EventArgs e)
        {
            FrmCita pago = new FrmCita();
            pago.Show();
        }
    }
}
