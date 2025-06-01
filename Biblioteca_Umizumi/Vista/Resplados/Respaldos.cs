using BibliotecaUmizumi.Controlador;
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

namespace Biblioteca_Umizumi.Vista.Resplados
{
    public partial class Respaldos : Form
    {
        public Respaldos()
        {
            InitializeComponent();
        }

        private void Respaldos_Load(object sender, EventArgs e)
        {
            pbRespaldos.Image = Properties.Resources.database_management;
        }

        private void btnCerrarSesión_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vista.Dashboard.Dashboard dashboard = new Vista.Dashboard.Dashboard();  
            dashboard.ShowDialog();
        }

        private void btnRespaldar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRuta.Text))
            {
                MessageBox.Show("Por favor selecciona una carpeta de destino.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BackupController.CrearBackup(txtRuta.Text.Trim());
        }

        private void btnSeleccionarRuta_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Selecciona una carpeta para guardar el respaldo";

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtRuta.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void btnRestarura_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Seleccionar archivo de respaldo";
            openFileDialog.Filter = "Archivos de respaldo (*.bak)|*.bak";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ruta = openFileDialog.FileName;

                try
                {
                    using (SqlConnection conexion = Conexion.ObtenerConexion())
                    {
                        SqlCommand cmd = new SqlCommand("sp_RestaurarRespaldo", conexion);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@RutaCompleta", ruta);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("✅ Restauración completada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al restaurar respaldo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
