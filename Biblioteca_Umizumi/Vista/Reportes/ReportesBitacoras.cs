using Biblioteca_Umizumi.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_Umizumi.Vista.Reportes
{
    public partial class ReportesBitacoras : Form
    {
        private int idUsuario;
        public ReportesBitacoras(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }


        private void btnExcel_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            
        }


        private void ReportesBitacoras_Load(object sender, EventArgs e)
        {

        }





        private void tabPage2_Click(object sender, EventArgs e)
        {

        }


        private void dgvSesiones_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();

            DateTime? desde = dtpInicio.Checked ? dtpInicio.Value.Date : (DateTime?)null;
            DateTime? hasta = dtpFin.Checked ? dtpFin.Value.Date : (DateTime?)null;
            bool soloAbiertas = chkSoloAbiertas.Checked;

            var controller = new ReporteBitacoraSesionesController();
            dgvSesiones.DataSource = controller.ObtenerSesiones(usuario, desde, hasta, soloAbiertas);
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Vista.Reportes.MenuReportes menu = new Vista.Reportes.MenuReportes(idUsuario);
            menu.ShowDialog();
        }

        private void btnExcel_Click_1(object sender, EventArgs e)
        {
            ExportadorExcel.Exportar(dgvSesiones, "Sesiones");
        }

        private void btnPDF_Click_1(object sender, EventArgs e)
        {
            ExportadorPDF.Exportar(dgvSesiones, "Reporte de Sesiones");
        }

        private void btnBuscarAcciones_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuarioAccion.Text.Trim();
            string accion = txtAccion.Text.Trim();
            string tabla = txtTabla.Text.Trim();

            DateTime? desde = dtpInicioAccion.Checked ? dtpInicioAccion.Value.Date : (DateTime?)null;
            DateTime? hasta = dtpFinAccion.Checked ? dtpFinAccion.Value.Date : (DateTime?)null;

            var controller = new ReporteBitacoraAccionesController();
            dgvAcciones.DataSource = controller.ObtenerAcciones(usuario, accion, tabla, desde, hasta);
        }

        private void btnExcelAcciones_Click(object sender, EventArgs e)
        {
            ExportadorExcel.Exportar(dgvAcciones, "Sesiones");
        }

        private void btnPdfAcciones_Click(object sender, EventArgs e)
        {
            ExportadorPDF.Exportar(dgvAcciones, "Reporte de Sesiones");
        }

        private void btnRegresar2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vista.Reportes.MenuReportes menu = new Vista.Reportes.MenuReportes (idUsuario);
            menu.ShowDialog();
        }
    }
}
