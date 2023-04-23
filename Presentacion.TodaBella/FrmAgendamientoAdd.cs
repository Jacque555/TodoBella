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
    public partial class FrmAgendamientoAdd : Form
    {
        ManejadorAgedamiento ma;
        public FrmAgendamientoAdd()
        {
            InitializeComponent();
            ma = new ManejadorAgedamiento();
            ma.ExtraerTipos(cmbNombre);
            if (FrmAgendamiento.agendamiento.IdCita > 0)
            {
                cmbNombre.Text = FrmAgendamiento.agendamientoc;
                txtHora.Text = FrmAgendamiento.agendamiento.Hora;
                txtFecha.Text = FrmAgendamiento.agendamiento.Fecha;
                cmbServicio.Text = FrmAgendamiento.agendamiento.Servicio;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ma.Guardar(new Agendamiento(FrmAgendamiento.agendamiento.IdCita,
                int.Parse(cmbNombre.SelectedValue.ToString()),
                txtHora.Text,
                txtFecha.Text,
                cmbServicio.Text));
            Close();
        }
    }
}
