using Biblioteca_Umizumi.Modelo;
using BibliotecaUmizumi.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Biblioteca_Umizumi.Controlador
{
    public class CRUDLibrosController
    {
        public List<Libro> ObtenerLibros()
        {
            List<Libro> lista = new List<Libro>();

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "SELECT * FROM Libros";
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Libro
                    {
                        IdLibro = Convert.ToInt32(reader["IdLibro"]),
                        Titulo = reader["Titulo"].ToString(),
                        IdCategoria = Convert.ToInt32(reader["IdCategoria"]),
                        IdAutor = Convert.ToInt32(reader["IdAutor"]),
                        IdProveedor = reader["IdProveedor"] != DBNull.Value ? Convert.ToInt32(reader["IdProveedor"]) : 0,
                        Cantidad_Stock = Convert.ToInt32(reader["Cantidad_Stock"]),
                        PrecioCompra = Convert.ToDecimal(reader["PrecioCompra"]),
                        PrecioVenta = Convert.ToDecimal(reader["PrecioVenta"]),
                        Descripcion = reader["Descripcion"].ToString(),
                        Status = Convert.ToBoolean(reader["status"]),
                        CreatedAt = Convert.ToDateTime(reader["created_at"]),
                        UpdatedAt = Convert.ToDateTime(reader["updated_at"])
                    });
                }
            }

            return lista;
        }

        public void AgregarLibro(Libro libro)
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "INSERT INTO Libros (Titulo, IdCategoria, IdAutor, IdProveedor, Cantidad_Stock, PrecioCompra, PrecioVenta, Descripcion, status) " +
                               "VALUES (@Titulo, @IdCategoria, @IdAutor, @IdProveedor, @Cantidad_Stock, @PrecioCompra, @PrecioVenta, @Descripcion, @status)";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Titulo", libro.Titulo);
                cmd.Parameters.AddWithValue("@IdCategoria", libro.IdCategoria);
                cmd.Parameters.AddWithValue("@IdAutor", libro.IdAutor);
                cmd.Parameters.AddWithValue("@IdProveedor", libro.IdProveedor);
                cmd.Parameters.AddWithValue("@Cantidad_Stock", libro.Cantidad_Stock);
                cmd.Parameters.AddWithValue("@PrecioCompra", libro.PrecioCompra);
                cmd.Parameters.AddWithValue("@PrecioVenta", libro.PrecioVenta);
                cmd.Parameters.AddWithValue("@Descripcion", libro.Descripcion);
                cmd.Parameters.AddWithValue("@status", libro.Status);
                cmd.ExecuteNonQuery();
            }
        }

        public void EditarLibro(Libro libro)
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "UPDATE Libros SET Titulo = @Titulo, IdCategoria = @IdCategoria, IdAutor = @IdAutor, IdProveedor = @IdProveedor, " +
                               "Cantidad_Stock = @Cantidad_Stock, PrecioCompra = @PrecioCompra, PrecioVenta = @PrecioVenta, " +
                               "Descripcion = @Descripcion, status = @status, updated_at = GETDATE() WHERE IdLibro = @IdLibro";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Titulo", libro.Titulo);
                cmd.Parameters.AddWithValue("@IdCategoria", libro.IdCategoria);
                cmd.Parameters.AddWithValue("@IdAutor", libro.IdAutor);
                cmd.Parameters.AddWithValue("@IdProveedor", libro.IdProveedor);
                cmd.Parameters.AddWithValue("@Cantidad_Stock", libro.Cantidad_Stock);
                cmd.Parameters.AddWithValue("@PrecioCompra", libro.PrecioCompra);
                cmd.Parameters.AddWithValue("@PrecioVenta", libro.PrecioVenta);
                cmd.Parameters.AddWithValue("@Descripcion", libro.Descripcion);
                cmd.Parameters.AddWithValue("@status", libro.Status);
                cmd.Parameters.AddWithValue("@IdLibro", libro.IdLibro);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarLibro(int id)
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "UPDATE Libros SET status = 0, updated_at = GETDATE() WHERE IdLibro = @IdLibro";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@IdLibro", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
