using Biblioteca_Umizumi.Modelo;
using BibliotecaUmizumi.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Biblioteca_Umizumi.Controlador
{
    public class CategoriaController
    {
        public List<Categorias> ObtenerCategorias()
        {
            List<Categorias> lista = new List<Categorias>();

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "SELECT * FROM Categorias";
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Categorias
                    {
                        IdCategoria = Convert.ToInt32(reader["IdCategoria"]),
                        NombreCategoria = reader["NombreCategoria"].ToString(),
                        Status = Convert.ToBoolean(reader["status"]),
                        CreatedAt = Convert.ToDateTime(reader["created_at"]),
                        UpdatedAt = Convert.ToDateTime(reader["updated_at"])
                    });
                }
            }

            return lista;
        }

        public void AgregarCategoria(Categorias categoria)
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "INSERT INTO Categorias (NombreCategoria, status) VALUES (@nombre, @status)";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@nombre", categoria.NombreCategoria);
                cmd.Parameters.AddWithValue("@status", categoria.Status);
                cmd.ExecuteNonQuery();
            }
        }

        public void EditarCategoria(Categorias categoria)
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "UPDATE Categorias SET NombreCategoria = @nombre, status = @status, updated_at = GETDATE() WHERE IdCategoria = @id";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@nombre", categoria.NombreCategoria);
                cmd.Parameters.AddWithValue("@status", categoria.Status);
                cmd.Parameters.AddWithValue("@id", categoria.IdCategoria);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarCategoria(int id)
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "UPDATE Categorias SET status = 0, updated_at = GETDATE() WHERE IdCategoria = @id";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
