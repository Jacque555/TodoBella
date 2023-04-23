using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crud;
using Entidades.TodaBella;
using AccesoDatos.TodaBella;

namespace Manejadores.TodaBella
{
    public class ManejadorAgedamiento : IManejador
    {
        AccesoAgendamiento aa = new AccesoAgendamiento();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(
                string.Format("¿Está seguro de borrar {0}",
                Entidad.IdCita),
                "!Atención", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                aa.Borrar(Entidad);
        }

        public void Exportar(DataGridView tabla)
        {
            throw new NotImplementedException();
        }

        public void Guardar(dynamic Entidad)
        {
            aa.Guardar(Entidad);
            g.Mensaje("Registro de agenda guardado", "¡ATENCIÓN!",
                MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource =
                aa.Mostrar(filtro).Tables["agendamiento"];
            tabla.Columns.Insert(5, g.Boton(
                "Editar", System.Drawing.Color.Green));
            tabla.Columns.Insert(6, g.Boton(
                "Borrar", System.Drawing.Color.Red));
            tabla.Columns[0].Visible = false;
            tabla.AutoResizeColumns();
        }
        public void ExtraerTipos(ComboBox caja)
        {
            caja.DataSource = aa.Mostrar("").Tables["cliente"];
            caja.DisplayMember = "nombre";
            caja.ValueMember = "idUsuario";
        }
        public Tuple<bool, string> ValidarAgendamiento(Agendamiento agendamiento)
        {
            bool error = true;
            string cadenaErrores = "";
            if (agendamiento.Fecha == "")
            {
                cadenaErrores = cadenaErrores + "-Campo Fecha no puede ser vacio\n";
                error = false;
            }
            if (agendamiento.Hora == "")
            {
                cadenaErrores = cadenaErrores + "-Campo Hora no puede ser vacio\n";
                error = false;
            }
            var valida = new Tuple<bool, string>(error, cadenaErrores);
            return valida;
        }
    }
}
