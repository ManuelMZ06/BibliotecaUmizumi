using System;
using System.Data;
using System.Data.SqlClient;
using BibliotecaUmizumi.Modelo;

namespace Biblioteca_Umizumi.Controlador
{
    public class ReporteBitacoraSesionesController
    {
        public DataTable ObtenerSesiones(string usuario, DateTime? desde, DateTime? hasta, bool soloAbiertas)
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ReporteBitacoraSesiones", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Usuario", (object)usuario ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DesdeFecha", (object)desde ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@HastaFecha", (object)hasta ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@SoloAbiertas", soloAbiertas ? 1 : 0);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);

                return tabla;
            }
        }
    }
}

