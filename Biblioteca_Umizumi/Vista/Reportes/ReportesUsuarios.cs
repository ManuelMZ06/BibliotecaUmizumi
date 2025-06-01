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
    public partial class ReportesUsuarios : Form
    {
        public ReportesUsuarios()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vista.Reportes.MenuReportes menu = new MenuReportes();
            menu.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string rol = txtRol.Text.Trim();

            bool? estado = null;
            if (cbEstado.SelectedIndex == 1) estado = true;
            else if (cbEstado.SelectedIndex == 2) estado = false;

            DateTime? inicio = dtpInicio.Checked ? dtpInicio.Value.Date : (DateTime?)null;
            DateTime? fin = dtpFin.Checked ? dtpFin.Value.Date : (DateTime?)null;

            var controller = new ReporteUsuariosController();
            dgvUsuarios.DataSource = controller.ObtenerUsuarios(rol, estado, inicio, fin);
        }

        private void ReportesUsuarios_Load(object sender, EventArgs e)
        {
            cbEstado.Items.AddRange(new string[] { "Todos", "Activo", "Inactivo" });
            cbEstado.SelectedIndex = 0;
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            ExportadorPDF.Exportar(dgvUsuarios, "Reporte de Usuarios");
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportadorExcel.Exportar(dgvUsuarios, "Usuarios");
        }
    }
}
