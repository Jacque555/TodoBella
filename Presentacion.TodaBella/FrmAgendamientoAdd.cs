using Manejadores.TodaBella;
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
            ma.ExtraerCliente(cmbCliente);
            if (FrmAgendamiento.agendamiento.IdCita > 0)
            {
                cmbServicio.Text = FrmAgendamiento.agendamiento.Servicio;
                TxtHora.Text = FrmAgendamiento.agendamiento.Hora;
                TxtFecha.Text = FrmAgendamiento.agendamiento.Fecha;
                cmbCliente.Text = FrmAgendamiento.agendamientoc;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ma.Guardar(new Agendamiento(FrmAgendamiento.agendamiento.IdCita,
                cmbServicio.Text,
                TxtHora.Text, TxtFecha.Text,
                int.Parse(cmbCliente.SelectedValue.ToString())));
            Close();
        }
    }
}
