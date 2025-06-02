using BibliotecaUmizumi.Modelo;
using BibliotecaUmizumi.Controlador;
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
using Biblioteca_Umizumi.Controlador;

namespace Biblioteca_Umizumi.Vista.Reportes
{
    public partial class ReportesMovimientos : Form
    {
        public ReportesMovimientos()
        {
            InitializeComponent();
        }

        private void ReportesMovimientos_Load(object sender, EventArgs e)
        {
            CargarAniosYLibros();
            cbMes.Items.AddRange(Enumerable.Range(1, 12).Select(i => i.ToString()).ToArray());
            cbTrimestre.Items.AddRange(new[] { "1", "2", "3", "4" });
            cbTipoMovimiento.Items.AddRange(new[] { "Entrada", "Salida" });
        }

        private void CargarAniosYLibros()
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                // Años
                SqlCommand cmdAnios = new SqlCommand("SELECT DISTINCT Año FROM bd_almacen_datos.dbo.vw_CuboMovimientos ORDER BY Año", conexion);
                SqlDataReader readerAnios = cmdAnios.ExecuteReader();
                while (readerAnios.Read())
                {
                    cbAnio.Items.Add(readerAnios.GetInt32(0));
                }
                readerAnios.Close();

                // Libros (Id + Título)
                SqlCommand cmdLibros = new SqlCommand("SELECT DISTINCT IdLibro, Titulo FROM bd_almacen_datos.dbo.vw_CuboMovimientos ORDER BY Titulo", conexion);
                SqlDataAdapter da = new SqlDataAdapter(cmdLibros);
                DataTable dtLibros = new DataTable();
                da.Fill(dtLibros);

                cbLibro.DataSource = dtLibros;
                cbLibro.DisplayMember = "Titulo";
                cbLibro.ValueMember = "IdLibro";
                cbLibro.SelectedIndex = -1;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int? anio = cbAnio.SelectedItem != null ? Convert.ToInt32(cbAnio.SelectedItem) : (int?)null;
            int? mes = cbMes.SelectedItem != null ? Convert.ToInt32(cbMes.SelectedItem) : (int?)null;
            int? trimestre = cbTrimestre.SelectedItem != null ? Convert.ToInt32(cbTrimestre.SelectedItem) : (int?)null;
            string tipo = cbTipoMovimiento.SelectedItem?.ToString();
            int? idLibro = cbLibro.SelectedValue != null ? Convert.ToInt32(cbLibro.SelectedValue) : (int?)null;

            var controller = new ReporteMovimientoController();
            dgvReporteLibros.DataSource = controller.ObtenerReporte(anio, mes, trimestre, tipo, idLibro);
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            cbAnio.SelectedIndex = -1;
            cbMes.SelectedIndex = -1;
            cbTrimestre.SelectedIndex = -1;
            cbTipoMovimiento.SelectedIndex = -1;
            cbLibro.SelectedIndex = -1;
            dgvReporteLibros.DataSource = null;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvReporteLibros.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ExportadorExcel.Exportar(dgvReporteLibros, "Reporte de Movimientos OLAP");
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (dgvReporteLibros.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ExportadorPDF.Exportar(dgvReporteLibros, "Reporte de Movimientos OLAP");
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vista.Dashboard.Dashboard dashboard = new Vista.Dashboard.Dashboard();
            dashboard.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    string script = "USE bd_almacen_datos; EXEC sp_ActualizarCuboMovimientos";

                    SqlCommand cmd = new SqlCommand(script, conexion);
                    cmd.CommandType = CommandType.Text;

                    int filas = cmd.ExecuteNonQuery();
                    MessageBox.Show($"✅ Cubo actualizado correctamente. Registros procesados: {filas}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error al actualizar cubo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
