using System;
using System.Data;
using System.Data.SqlClient;
using BibliotecaUmizumi.Modelo;

namespace Biblioteca_Umizumi.Controlador
{
    public class ReporteUsuariosController
    {
        public DataTable ObtenerUsuarios(string rol, bool? estado, DateTime? inicio, DateTime? fin)
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ReporteUsuariosAvanzado", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Rol", (object)rol ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Estado", (object)estado ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DesdeFecha", (object)inicio ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@HastaFecha", (object)fin ?? DBNull.Value);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);

                return tabla;
            }
        }
    }
}
