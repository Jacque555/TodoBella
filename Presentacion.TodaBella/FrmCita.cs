using Entidades.TodaBella;
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
    public partial class FrmCita : Form
    {
        ManejadorCita ma;
        public static Citas
            cita = new Citas(0, 0, 0, "");
        int fila = 0, col = 0;
        public static string citac = "";
        public FrmCita()
        {
            InitializeComponent();
            ma= new ManejadorCita();
        }
        void Actualizar()
        {
            ma.Mostrar(dtgCita, txtBuscar.Text);
        }

        private void dtgCita_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cita.IdFolio = int.Parse(dtgCita.Rows[fila].Cells[0].Value.ToString());
            citac = dtgCita.Rows[fila].Cells[1].Value.ToString();
            cita.Pago = int.Parse(dtgCita.Rows[fila].Cells[2].Value.ToString());
            cita.TipoPago = dtgCita.Rows[fila].Cells[3].Value.ToString();
            switch (col)
            {
                case 4:
                    {
                        FrmCitasAdd pa = new FrmCitasAdd();
                        pa.ShowDialog();
                        txtBuscar.Text = "-1";
                        txtBuscar.Clear();
                        Actualizar();
                    }
                    break;
                case 5:
                    {
                        ma.Borrar(cita);
                        txtBuscar.Text = "";
                        Actualizar();
                    }
                    break;
            }
        }

        private void dtgCita_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cita.IdFolio = -1;
            FrmCitasAdd pa = new FrmCitasAdd();
            pa.ShowDialog();
        }
    }
}
