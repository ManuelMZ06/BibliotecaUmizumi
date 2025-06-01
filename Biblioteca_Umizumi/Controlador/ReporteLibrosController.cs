using System;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;
using BibliotecaUmizumi.Modelo;

namespace Biblioteca_Umizumi.Controlador
{
    public class ReporteLibrosController
    {
        public DataTable ObtenerReporte(string autor, string categoria, DateTime? inicio, DateTime? fin,
                                        decimal? ventaMin, decimal? ventaMax, decimal? compraMin, decimal? compraMax,
                                        bool soloStockBajo)
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ReporteLibrosAvanzado", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Autor", (object)autor ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Categoria", (object)categoria ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DesdeFecha", (object)inicio ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@HastaFecha", (object)fin ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@PrecioVentaMin", (object)ventaMin ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@PrecioVentaMax", (object)ventaMax ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@PrecioCompraMin", (object)compraMin ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@PrecioCompraMax", (object)compraMax ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@SoloStockBajo", soloStockBajo);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);

                return tabla;
            }
        }
    }
}
