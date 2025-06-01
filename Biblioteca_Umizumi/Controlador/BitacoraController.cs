using System;
using System.Data.SqlClient;
using BibliotecaUmizumi.Modelo;

namespace BibliotecaUmizumi.Controlador
{
    public static class BitacoraController
    {
        public static void RegistrarAccion(int idUsuario, string accion, string tabla)
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "INSERT INTO BitacoraAccionesUsuario (IdUsuario, Accion, TablaAfectada) " +
                               "VALUES (@IdUsuario, @Accion, @Tabla)";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    comando.Parameters.AddWithValue("@Accion", accion);
                    comando.Parameters.AddWithValue("@Tabla", tabla);
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
