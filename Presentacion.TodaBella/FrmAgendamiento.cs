using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores.TodaBella;
using Entidades.TodaBella;

namespace Presentacion.TodaBella
{
    public partial class FrmAgendamiento : Form
    {
        ManejadorAgedamiento ma;
        public static Agendamiento
            agendamiento = new Agendamiento(0, 0, "", "", "");
        int fila = 0, col = 0;
        public static string agendamientoc = "";
        public FrmAgendamiento()
        {
            InitializeComponent();
            ma = new ManejadorAgedamiento();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }
        void Actualizar()
        {
            ma.Mostrar(dtgAgendamiento, txtBuscar.Text);
        }

        private void dtgAgendamiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            agendamiento.IdCita = int.Parse(dtgAgendamiento.Rows[fila].
                Cells[0].Value.ToString());
            agendamientoc = dtgAgendamiento.Rows[fila].Cells[1].Value.ToString();
            agendamiento.Hora = dtgAgendamiento.Rows[fila].
                Cells[2].Value.ToString();
            agendamiento.Fecha = dtgAgendamiento.Rows[fila].
                Cells[3].Value.ToString();
            agendamiento.Servicio = dtgAgendamiento.Rows[fila].
                Cells[4].Value.ToString();
            switch (col)
            {
                case 5:
                    {
                        FrmAgendamientoAdd pa = new FrmAgendamientoAdd();
                        pa.ShowDialog();
                        txtBuscar.Text = "-1";
                        txtBuscar.Clear();
                        Actualizar();
                    }
                    break;
                case 6:
                    {
                        ma.Borrar(agendamiento);
                        txtBuscar.Text = "";
                        Actualizar();
                    }
                    break;
            }
        }

        private void dtgAgendamiento_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agendamiento.IdCita = -1;
            FrmAgendamientoAdd pa = new FrmAgendamientoAdd();
            pa.ShowDialog();
        }
    }
}
