using Biblioteca_Umizumi.Modelo;
using BibliotecaUmizumi.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Biblioteca_Umizumi.Controlador
{
    public class UserController
    {
        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "SELECT IdUsuario, usuario, idRol, status, created_at, updated_at FROM Usuarios";
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Usuario
                    {
                        IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                        UsuarioNombre = reader["usuario"].ToString(),
                        IdRol = Convert.ToInt32(reader["idRol"]),
                        Status = Convert.ToBoolean(reader["status"]),
                        CreatedAt = Convert.ToDateTime(reader["created_at"]),
                        UpdatedAt = Convert.ToDateTime(reader["updated_at"])
                    });
                }
            }

            return lista;
        }

        public void ActivarUsuario(int idUsuario)
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "UPDATE Usuarios SET status = 1, updated_at = GETDATE() WHERE IdUsuario = @id";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@id", idUsuario);
                cmd.ExecuteNonQuery();
            }
        }

        public void DesactivarUsuario(int idUsuario)
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "UPDATE Usuarios SET status = 0, updated_at = GETDATE() WHERE IdUsuario = @id";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@id", idUsuario);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
