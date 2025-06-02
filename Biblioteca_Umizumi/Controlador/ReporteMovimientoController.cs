// Modelo: ReporteMovimiento.cs
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Biblioteca_Umizumi.Modelo;
using Biblioteca_Umizumi.Vista.Reportes;
using BibliotecaUmizumi.Modelo;

namespace Biblioteca_Umizumi.Controlador
{
    public class ReporteMovimientoController
    {
        public List<ReporteMovimiento> ObtenerReporte(int? anio, int? mes, int? trimestre, string tipo, int? idLibro)
        {
            List<ReporteMovimiento> lista = new List<ReporteMovimiento>();

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = @"SELECT * FROM bd_almacen_datos.dbo.vw_CuboMovimientos WHERE 1=1";

                if (anio.HasValue) query += " AND Año = @anio";
                if (mes.HasValue) query += " AND Mes = @mes";
                if (trimestre.HasValue) query += " AND Trimestre = @trimestre";
                if (!string.IsNullOrWhiteSpace(tipo)) query += " AND TipoMovimiento = @tipo";
                if (idLibro.HasValue) query += " AND IdLibro = @idLibro";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    if (anio.HasValue) cmd.Parameters.AddWithValue("@anio", anio);
                    if (mes.HasValue) cmd.Parameters.AddWithValue("@mes", mes);
                    if (trimestre.HasValue) cmd.Parameters.AddWithValue("@trimestre", trimestre);
                    if (!string.IsNullOrWhiteSpace(tipo)) cmd.Parameters.AddWithValue("@tipo", tipo);
                    if (idLibro.HasValue) cmd.Parameters.AddWithValue("@idLibro", idLibro);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        lista.Add(new ReporteMovimiento
                        {
                            IdMovimiento = reader["IdMovimiento"] != DBNull.Value ? Convert.ToInt32(reader["IdMovimiento"]) : 0,
                            FechaMovimiento = reader["FechaMovimiento"] != DBNull.Value ? Convert.ToDateTime(reader["FechaMovimiento"]) : DateTime.MinValue,
                            Anio = reader["Año"] != DBNull.Value ? Convert.ToInt32(reader["Año"]) : 0,
                            Mes = reader["Mes"] != DBNull.Value ? Convert.ToInt32(reader["Mes"]) : 0,
                            Trimestre = reader["Trimestre"] != DBNull.Value ? Convert.ToInt32(reader["Trimestre"]) : 0,
                            IdLibro = reader["IdLibro"] != DBNull.Value ? Convert.ToInt32(reader["IdLibro"]) : 0,
                            Titulo = reader["Titulo"]?.ToString() ?? "",
                            PrecioVenta = reader["PrecioVenta"] != DBNull.Value ? Convert.ToDecimal(reader["PrecioVenta"]) : 0,
                            IdUsuario = reader["IdUsuario"] != DBNull.Value ? Convert.ToInt32(reader["IdUsuario"]) : 0,
                            NombreUsuario = reader["NombreUsuario"]?.ToString() ?? "",
                            TipoMovimiento = reader["TipoMovimiento"]?.ToString() ?? "",
                            Cantidad = reader["Cantidad"] != DBNull.Value ? Convert.ToInt32(reader["Cantidad"]) : 0
                        });
                    }
                }
            }
            return lista;
        }
    }
}
