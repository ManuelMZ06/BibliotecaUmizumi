using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using BibliotecaUmizumi.Modelo;

namespace BibliotecaUmizumi.Controlador
{
    public class BackupController
    {
        public static void CrearBackup(string carpetaDestino)
        {
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("sp_CrearRespaldo", conexion);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CarpetaDestino", carpetaDestino);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("✅ Respaldo creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al crear respaldo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
