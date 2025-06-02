using Biblioteca_Umizumi.Controlador;
using Biblioteca_Umizumi.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using BibliotecaUmizumi.Modelo;
using System.Data.SqlClient;

namespace Biblioteca_Umizumi.Vista.ModeloPredictivo
{
    public partial class PrediccionDemanda : Form
    {
        public PrediccionDemanda()
        {
            InitializeComponent();
        }

        private DemandaController controller = new DemandaController();
        private void btnPredecir_Click(object sender, EventArgs e)
        {
            if (cbLibros.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un libro.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idLibro = (int)cbLibros.SelectedValue;
            DateTime fecha = dtpFecha.Value;

            string resultado = controller.EjecutarPrediccion(idLibro, fecha);
            lblResultado.Text = resultado;

            // Cargar archivo CSV generado
            if (File.Exists("resultado_prediccion.csv"))
            {
                var lineas = File.ReadAllLines("resultado_prediccion.csv");
                if (lineas.Length >= 2)
                {
                    var datos = lineas[1].Split(',');
                    string fechaPrediccion = datos[0];
                    int cantidad = int.Parse(datos[1]);
                    MostrarGrafico(fechaPrediccion, cantidad);
                }
            }
        }

        private void PrediccionDemanda_Load(object sender, EventArgs e)
        {
            CargarLibros();
        }

        private void MostrarGrafico(string fecha, int prediccion)
        {
            chartPrediccion.Series.Clear();
            chartPrediccion.Titles.Clear();
            chartPrediccion.ChartAreas[0].AxisX.Title = "Fecha";
            chartPrediccion.ChartAreas[0].AxisY.Title = "Cantidad Predicha";

            // Estilo de los ejes
            chartPrediccion.ChartAreas[0].AxisX.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
            chartPrediccion.ChartAreas[0].AxisY.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
            chartPrediccion.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 9);
            chartPrediccion.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Segoe UI", 9);

            // Grid y bordes
            chartPrediccion.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chartPrediccion.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chartPrediccion.ChartAreas[0].BorderDashStyle = ChartDashStyle.Solid;
            chartPrediccion.ChartAreas[0].BorderColor = Color.Gray;
            chartPrediccion.ChartAreas[0].BorderWidth = 1;

            // Título de la gráfica
            chartPrediccion.Titles.Add("Demanda Estimada");
            chartPrediccion.Titles[0].Font = new Font("Segoe UI", 12, FontStyle.Bold);

            // Crear serie
            var serie = new Series("Predicción")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Green, // color solicitado
                IsValueShownAsLabel = true,
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };

            // Establecer grosor de la barra
            serie["PointWidth"] = "0.3";  // más delgada

            // Agregar valor
            serie.Points.AddXY(fecha, prediccion);

            chartPrediccion.Series.Add(serie);
        }



        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vista.Dashboard.Dashboard dashboard = new Vista.Dashboard.Dashboard();
            dashboard.ShowDialog();
        }

        private void CargarLibros()
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "SELECT IdLibro, Titulo FROM Libros WHERE status = 1 ORDER BY Titulo";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cbLibros.DataSource = dt;
                cbLibros.DisplayMember = "Titulo";
                cbLibros.ValueMember = "IdLibro";
                cbLibros.SelectedIndex = -1; // Ningún libro seleccionado por defecto
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
