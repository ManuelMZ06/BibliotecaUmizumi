using System;
using System.Data;
using System.Data.SqlClient;
using BibliotecaUmizumi.Modelo;

namespace Biblioteca_Umizumi.Controlador
{
    public class ReporteBitacoraAccionesController
    {
        public DataTable ObtenerAcciones(string usuario, string accion, string tabla, DateTime? desde, DateTime? hasta)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_ReporteBitacoraAcciones", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NombreUsuario", (object)usuario ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Accion", (object)accion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@TablaAfectada", (object)tabla ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@FechaInicio", (object)desde ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@FechaFin", (object)hasta ?? DBNull.Value);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }
    }
}
