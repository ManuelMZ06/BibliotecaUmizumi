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
    public partial class MenuReportes : Form
    {
        public MenuReportes()
        {
            InitializeComponent();
        }

        private void btnReporteLibros_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vista.Reportes.ReportesLibros rLibros = new ReportesLibros();
            rLibros.ShowDialog();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vista.Dashboard.Dashboard dashboard = new Vista.Dashboard.Dashboard();
            dashboard.ShowDialog();
        }

        private void btnReportesUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vista.Reportes.ReportesUsuarios rUsuarios = new ReportesUsuarios();
            rUsuarios.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vista.Reportes.ReportesBitacoras rBitacoras = new ReportesBitacoras();
            rBitacoras.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
