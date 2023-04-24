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
using Microsoft.Office.Interop.Excel;

namespace Presentacion.TodaBella
{
    public partial class FrmClienteAdd : Form
    {
        ManejadorCliente mc;
        public FrmClienteAdd()
        {
            InitializeComponent();
            mc = new ManejadorCliente();
            if (FrmCliente.cliente.IdUsuario > 0)
            {
                txtNombre.Text = FrmCliente.cliente.Nombre;
                txtTelefono.Text = FrmCliente.cliente.Telefono;
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            Cliente h = new Cliente(FrmCliente.cliente.IdUsuario, txtNombre.Text,
                     txtTelefono.Text);

            var valida = mc.ValidarCliente(h);

            if (valida.Item1)
            {
                mc.Guardar(new Cliente(FrmCliente.cliente.IdUsuario, txtNombre.Text,
                     txtTelefono.Text));
            }
            else
            {
                MessageBox.Show(valida.Item2, "Ocurrio un error", MessageBoxButtons.OK);
            }
            Close();
        }
    }
}
