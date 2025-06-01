using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Biblioteca_Umizumi.Modelo.BibliotecaUmizumi.Modelo;
using BibliotecaUmizumi.Modelo;

namespace BibliotecaUmizumi.Controlador
{
    public class MovimientoController
    {
        public string RegistrarMovimiento(int idLibro, string tipoMovimiento, int cantidad, int idUsuario, string observaciones)
        {
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarMovimiento", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdLibro", idLibro);
                    cmd.Parameters.AddWithValue("@TipoMovimiento", tipoMovimiento);
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@Observaciones", observaciones ?? (object)DBNull.Value);

                    cmd.ExecuteNonQuery();
                    return "✅ Movimiento registrado correctamente.";
                }
            }
            catch (SqlException ex)
            {
                return $"❌ Error SQL: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"❌ Error general: {ex.Message}";
            }
        }

        public List<Movimiento> ObtenerMovimientos()
        {
            List<Movimiento> lista = new List<Movimiento>();

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = @"
            SELECT m.IdMovimiento, m.IdLibro, l.Titulo AS TituloLibro,
                   m.TipoMovimiento, m.Cantidad, m.FechaMovimiento,
                   m.IdUsuario, u.usuario AS NombreUsuario,
                   m.Observaciones, m.status
            FROM Movimientos m
            INNER JOIN Libros l ON m.IdLibro = l.IdLibro
            INNER JOIN Usuarios u ON m.IdUsuario = u.IdUsuario";

                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Movimiento
                    {
                        IdMovimiento = Convert.ToInt32(reader["IdMovimiento"]),
                        IdLibro = Convert.ToInt32(reader["IdLibro"]),
                        TituloLibro = reader["TituloLibro"].ToString(),
                        TipoMovimiento = reader["TipoMovimiento"].ToString(),
                        Cantidad = Convert.ToInt32(reader["Cantidad"]),
                        FechaMovimiento = Convert.ToDateTime(reader["FechaMovimiento"]),
                        IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                        NombreUsuario = reader["NombreUsuario"].ToString(),
                        Observaciones = reader["Observaciones"].ToString(),
                        Status = Convert.ToBoolean(reader["status"])
                    });
                }
            }

            return lista;
        }

    }
}
