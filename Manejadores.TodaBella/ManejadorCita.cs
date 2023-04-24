using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos.TodaBella;
using Crud;
namespace Manejadores.TodaBella
{
    public class ManejadorCita : IManejador
    {
        AccesoCitas aa = new AccesoCitas();
        AccesoCliente ac = new AccesoCliente();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(
                string.Format("¿Está seguro de borrar {0}",
                Entidad.IdFolio),
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
            g.Mensaje("Pago realizado", "¡ATENCIÓN!",
                MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource =
                aa.Mostrar(filtro).Tables["tipoPago"];
            tabla.Columns.Insert(4, g.Boton(
                "Editar", System.Drawing.Color.Green));
            tabla.Columns.Insert(5, g.Boton(
                "Borrar", System.Drawing.Color.Red));
            tabla.Columns[0].Visible = false;
            tabla.AutoResizeColumns();
        }
        public void ExtraerCliente(ComboBox caja)
        {
            caja.DataSource = ac.Mostrar("").Tables["nombre"];
            caja.DisplayMember = "nombre";
            caja.ValueMember = "idUsuario";
        }
    }
}
