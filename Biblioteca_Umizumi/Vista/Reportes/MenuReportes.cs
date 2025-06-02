using Biblioteca_Umizumi.Modelo;
using BibliotecaUmizumi.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_Umizumi.Vista.Reportes
{
    public partial class MenuReportes : Form
    {
        private int idUsuario;
        private int idRol;
        public MenuReportes(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.idRol = ObtenerRolUsuario(idUsuario);
        }

        private void btnReporteLibros_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vista.Reportes.ReportesLibros rLibros = new ReportesLibros(idUsuario);
            rLibros.ShowDialog();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vista.Dashboard.Dashboard dashboard = new Vista.Dashboard.Dashboard(idUsuario);
            dashboard.ShowDialog();
        }

        private void btnReportesUsuarios_Click(object sender, EventArgs e)
        {
            if (idRol == 2)
            {
                MessageBox.Show("❌ Permiso denegado. No tienes acceso a este reporte.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Hide();
            Vista.Reportes.ReportesUsuarios rUsuarios = new ReportesUsuarios(idUsuario);
            rUsuarios.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (idRol == 2)
            {
                MessageBox.Show("❌ Permiso denegado. No tienes acceso a este reporte.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Hide();
            Vista.Reportes.ReportesBitacoras rBitacoras = new ReportesBitacoras(idUsuario);
            rBitacoras.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idRol == 2)
            {
                MessageBox.Show("❌ Permiso denegado. No tienes acceso a este reporte.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Hide();
            Vista.Reportes.ReportesMovimientos movimientos = new ReportesMovimientos(idUsuario);
            movimientos.ShowDialog();
        }

        private void MenuReportes_Load(object sender, EventArgs e)
        {

        }

        private int ObtenerRolUsuario(int idUsuario)
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "SELECT idRol FROM Usuarios WHERE IdUsuario = @id";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@id", idUsuario);

                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }
    }
}
