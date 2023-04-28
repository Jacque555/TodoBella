using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.TodaBella;
using Manejadores.TodaBella;


namespace Presentacion.TodaBella
{
    public partial class FrmCitasAdd : Form
    {
        ManejadorCita mc;
        public FrmCitasAdd()
        {
            InitializeComponent();
            mc = new ManejadorCita();
            mc.ExtraerCliente(cmbCliente);
            if (FrmCita.cita.IdFolio > 0)
            {
                cmbCliente.Text = FrmAgendamiento.agendamientoc;
                TxtPago.Text = FrmCita.cita.Pago.ToString();
                cmbPago.Text = FrmCita.cita.TipoPago;
                
            }
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {
            FrmMenu fm = new FrmMenu();
            fm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            mc.Guardar(new Citas(FrmCita.cita.IdFolio,
                int.Parse(cmbCliente.SelectedValue.ToString()),
                int.Parse(TxtPago.Text),
                cmbPago.Text));
            Close();
        }
    }
}
