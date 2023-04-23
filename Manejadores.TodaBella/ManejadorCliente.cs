using System;
using System.Windows.Forms;
using Crud;
using Entidades.TodaBella;
using AccesoDatos.TodaBella;

namespace Manejadores.TodaBella
{
    public class ManejadorCliente : IManejador
    {
        AccesoCliente ac = new AccesoCliente();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(
                string.Format("¿Está seguro de borrar {0}",
                Entidad.IdUsuario),
                "!Atención", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                ac.Borrar(Entidad);
        }

        public void Exportar(DataGridView tabla)
        {
            throw new NotImplementedException();
        }

        public void Guardar(dynamic Entidad)
        {
            ac.Guardar(Entidad);
            g.Mensaje("Registro de cliente guardado", "¡ATENCIÓN!",
                MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource =
                ac.Mostrar(filtro).Tables["cliente"];
            tabla.Columns.Insert(3, g.Boton(
                "Editar", System.Drawing.Color.Green));
            tabla.Columns.Insert(4, g.Boton(
                "Borrar", System.Drawing.Color.Red));
            tabla.Columns[0].Visible = false;
            tabla.AutoResizeColumns();
        }
        public void ExtraerTipos(ComboBox caja)
        {
            caja.DataSource = ac.Mostrar("").Tables["cliente"];
            caja.DisplayMember = "nombre";
            caja.ValueMember = "fkidUsuario";
        }
        public Tuple<bool, string> ValidarCliente(Cliente cliente)
        {
            bool error = true;
            string cadenaErrores = "";
            if (cliente.Telefono == "")
            {
                cadenaErrores = cadenaErrores + "-Campo Telefono no puede ser vacio\n";
                error = false;
            }
            var valida = new Tuple<bool, string>(error, cadenaErrores);
            return valida;
        }
    }
}
