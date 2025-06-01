using Biblioteca_Umizumi.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;



namespace Biblioteca_Umizumi.Vista.Reportes
{
    public partial class ReportesLibros : Form
    {
        public ReportesLibros()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string autor = txtAutor.Text.Trim();
            string categoria = txtCategoria.Text.Trim();

            DateTime? inicio = dtpInicio.Checked ? dtpInicio.Value.Date : (DateTime?)null;
            DateTime? fin = dtpFin.Checked ? dtpFin.Value.Date : (DateTime?)null;

            decimal? ventaMin = decimal.TryParse(txtPrecioVentaMin.Text, out var pvm) ? pvm : (decimal?)null;
            decimal? ventaMax = decimal.TryParse(txtPrecioVentaMax.Text, out var pvx) ? pvx : (decimal?)null;
            decimal? compraMin = decimal.TryParse(txtPrecioCompraMin.Text, out var pcm) ? pcm : (decimal?)null;
            decimal? compraMax = decimal.TryParse(txtPrecioCompraMax.Text, out var pcx) ? pcx : (decimal?)null;

            bool stockBajo = chkStockBajo.Checked;

            var controller = new ReporteLibrosController();
            dgvReporteLibros.DataSource = controller.ObtenerReporte(autor, categoria, inicio, fin, ventaMin, ventaMax, compraMin, compraMax, stockBajo);
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ReportesLibros_Load(object sender, EventArgs e)
        {

        }

        

        private void btnPDF_Click(object sender, EventArgs e)
        {
            ExportadorPDF.Exportar(dgvReporteLibros, "Reporte de Libros");
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportadorExcel.Exportar(dgvReporteLibros, "Reporte de Libros");
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vista.Reportes.MenuReportes menu = new MenuReportes();
            menu.ShowDialog();
        }

        //
    }
}
