using Biblioteca_Umizumi.Modelo;
using BibliotecaUmizumi.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Biblioteca_Umizumi.Controlador
{
    public class AutorController
    {
        public List<Autor> ObtenerAutores()
        {
            List<Autor> lista = new List<Autor>();

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "SELECT * FROM Autores";
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Autor
                    {
                        IdAutor = Convert.ToInt32(reader["IdAutor"]),
                        NombreAutor = reader["NombreAutor"].ToString(),
                        Status = Convert.ToBoolean(reader["status"]),
                        CreatedAt = Convert.ToDateTime(reader["created_at"]),
                        UpdatedAt = Convert.ToDateTime(reader["updated_at"])
                    });
                }
            }

            return lista;
        }

        public void AgregarAutor(Autor autor)
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "INSERT INTO Autores (NombreAutor, status) VALUES (@nombre, @status)";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@nombre", autor.NombreAutor);
                cmd.Parameters.AddWithValue("@status", autor.Status);
                cmd.ExecuteNonQuery();
            }
        }

        public void EditarAutor(Autor autor)
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "UPDATE Autores SET NombreAutor = @nombre, status = @status, updated_at = GETDATE() WHERE IdAutor = @id";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@nombre", autor.NombreAutor);
                cmd.Parameters.AddWithValue("@status", autor.Status);
                cmd.Parameters.AddWithValue("@id", autor.IdAutor);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarAutor(int id)
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "UPDATE Autores SET status = 0, updated_at = GETDATE() WHERE IdAutor = @id";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
