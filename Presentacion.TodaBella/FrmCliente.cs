using System;
using System.Windows.Forms;
using Manejadores.TodaBella;
using Entidades.TodaBella;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Presentacion.TodaBella
{
    public partial class FrmCliente : Form
    {
        ManejadorCliente mc;
        public static Cliente 
            cliente = new Cliente(0,"","");
        int fila = 0, col = 0;
        public static string clientes = "";

        public FrmCliente()
        {
            InitializeComponent();
            mc = new ManejadorCliente();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cliente.IdUsuario = -1;
            FrmClienteAdd ho = new FrmClienteAdd();
            ho.ShowDialog();
        }

        private void dtgCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cliente.IdUsuario = int.Parse(dtgCliente.Rows[fila].
                Cells[0].Value.ToString());
            cliente.Nombre = dtgCliente.Rows[fila].
                Cells[1].Value.ToString();
            cliente.Telefono = dtgCliente.Rows[fila].
                Cells[2].Value.ToString();
            switch (col)
            {
                case 3:
                    {
                        FrmClienteAdd ho = new FrmClienteAdd();
                        ho.ShowDialog();
                        txtBuscar.Text = "-1";
                        txtBuscar.Clear();
                        Actualizar();
                    }
                    break;
                case 4:
                    {
                        mc.Borrar(cliente);
                        Actualizar();
                    }
                    break;
            }
        }

        private void dtgCliente_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            Document documento = new Document(PageSize.A4);
            PdfWriter.GetInstance(documento, new FileStream(@"D:\PDFtodabella\pdftodabella.pdf", FileMode.OpenOrCreate));

            documento.Open();

            Paragraph todabella = new Paragraph();
            todabella.Alignment = Element.ALIGN_CENTER;
            todabella.Font = FontFactory.GetFont("Arial", 12);
            todabella.Add("REGITRO DE CLIENTES, TODABELLA");
            documento.Add(todabella);

            Paragraph titulo = new Paragraph();
            titulo.Alignment = Element.ALIGN_CENTER;
            titulo.Font = FontFactory.GetFont("Arial", 16);
            titulo.Add("Reporte de registro de clientes");
            documento.Add(titulo);

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"D:\Ingenieria de Software\Parcial 3\Captura de pantalla 2023-04-14 201215.png");
            logo.SetAbsolutePosition(500, 750);
            logo.ScaleAbsolute(64, 72);
            documento.Add(logo);

            documento.Add(Chunk.NEWLINE);

            PdfPTable tablaTodaBella= new PdfPTable(2);
            tablaTodaBella.WidthPercentage = 100;
            PdfPCell nombre = new PdfPCell(new Phrase("Nombre"));
            nombre.BorderWidth = 0;
            nombre.BorderWidthBottom = 0.75f;

            PdfPCell telefono = new PdfPCell(new Phrase("Teléfono"));
            telefono.BorderWidth = 0;
            telefono.BorderWidthBottom = 0.75f;

            tablaTodaBella.AddCell(nombre);
            tablaTodaBella.AddCell(telefono);

            for (int i = 0; i < dtgCliente.Rows.Count; i++)
            {
                nombre = new PdfPCell(new Phrase(dtgCliente.Rows[i].Cells["nombre"].Value.ToString()));
                nombre.BorderWidth = 0;

                telefono = new PdfPCell(new Phrase(dtgCliente.Rows[i].Cells["telefono"].Value.ToString()));
                telefono.BorderWidth = 0;

                tablaTodaBella.AddCell(nombre);
                tablaTodaBella.AddCell(telefono);
            }

            documento.Add(tablaTodaBella);
            documento.Close();
            System.Diagnostics.Process.Start(@"D:\PDFtodabella\pdftodabella.pdf");
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportarDatos(dtgCliente);
        }
        public void ExportarDatos(DataGridView datalistado)
        {
            Document documento = new Document();
            PdfWriter.GetInstance(documento, new FileStream(@"D:\PDFtodabella\excelcliente.xls", FileMode.OpenOrCreate));


            documento.Open();
            Microsoft.Office.Interop.Excel.Application exportarexcel = new Microsoft.Office.Interop.Excel.Application();
            exportarexcel.Application.Workbooks.Add(true);
            int indicecolumna = 0;
            foreach (DataGridViewColumn columna in datalistado.Columns)
            {
                indicecolumna++;
                exportarexcel.Cells[1, indicecolumna] = columna.Name;
            }
            int indicefila = 0;
            foreach (DataGridViewRow fila in datalistado.Rows)
            {
                indicefila++;
                indicecolumna = 0;
                foreach (DataGridViewColumn columna in datalistado.Columns)
                {
                    indicecolumna++;
                    exportarexcel.Cells[indicefila + 1, indicecolumna] = fila.Cells[columna.Name].Value;
                }
            }
            exportarexcel.Visible = true;
            System.Diagnostics.Process.Start(@"D:\PDFtodabella\excelcliente.xls");
        }

        void Actualizar()
        {
            mc.Mostrar(dtgCliente, txtBuscar.Text);
        }

    }
}
