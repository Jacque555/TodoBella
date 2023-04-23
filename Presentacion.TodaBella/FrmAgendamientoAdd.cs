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
        ManejadorAgendamiento ma;
        public FrmAgendamientoAdd()
        {
            InitializeComponent();
            ma = new ManejadorAgendamiento();
            ma.ExtraerClinete(cmbCliente);
            if (FrmAgendamiento.agendamiento.IdCita > 0)
            {
                cmbCliente.Text = FrmAgendamiento.agendamientoc;
                TxtHora.Text = FrmAgendamiento.agendamiento.Hora;
                TxtFecha.Text = FrmAgendamiento.agendamiento.Fecha;
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
                int.Parse(cmbCliente.SelectedValue.ToString()),
                TxtHora.Text, TxtFecha.Text,
                cmbServicio.Text));
            Close();
        }
    }
}
