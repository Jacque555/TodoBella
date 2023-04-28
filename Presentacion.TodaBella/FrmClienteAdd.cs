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
                txtDomicilio.Text = FrmCliente.cliente.Domicilio;
                txtEdad.Text = FrmCliente.cliente.Edad.ToString();
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void lblMenu_Click(object sender, EventArgs e)
        {
            FrmMenu fm = new FrmMenu();
            Close();
            fm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Cliente h = new Cliente(FrmCliente.cliente.IdUsuario, txtNombre.Text,
                     txtTelefono.Text, txtDomicilio.Text, int.Parse(txtEdad.Text));

            var valida = mc.ValidarCliente(h);

            if (valida.Item1)
            {
                mc.Guardar(new Cliente(FrmCliente.cliente.IdUsuario, txtNombre.Text,
                     txtTelefono.Text, txtDomicilio.Text, int.Parse(txtEdad.Text)));
            }
            else
            {
                MessageBox.Show(valida.Item2, "Ocurrio un error", MessageBoxButtons.OK);
            }
            Close();
        }
    }
}
