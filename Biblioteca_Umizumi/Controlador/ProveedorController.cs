using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BibliotecaUmizumi.Modelo;

namespace BibliotecaUmizumi.Controlador
{
    public class ProveedorController
    {
        public List<Proveedor> ObtenerProveedores()
        {
            List<Proveedor> lista = new List<Proveedor>();

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "SELECT * FROM Proveedores";
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Proveedor
                    {
                        IdProveedor = Convert.ToInt32(reader["IdProveedor"]),
                        NombreProveedor = reader["NombreProveedor"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        Email = reader["Email"].ToString(),
                        Direccion = reader["Direccion"].ToString(),
                        Status = Convert.ToBoolean(reader["status"]),
                        CreatedAt = Convert.ToDateTime(reader["created_at"]),
                        UpdatedAt = Convert.ToDateTime(reader["updated_at"])
                    });
                }
                reader.Close();
            }

            return lista;
        }

        public void AgregarProveedor(Proveedor proveedor)
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = @"
                    INSERT INTO Proveedores 
                    (NombreProveedor, Telefono, Email, Direccion, status)
                    VALUES (@NombreProveedor, @Telefono, @Email, @Direccion, @Status)";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@NombreProveedor", proveedor.NombreProveedor);
                cmd.Parameters.AddWithValue("@Telefono", proveedor.Telefono);
                cmd.Parameters.AddWithValue("@Email", proveedor.Email);
                cmd.Parameters.AddWithValue("@Direccion", proveedor.Direccion);
                cmd.Parameters.AddWithValue("@Status", proveedor.Status);
                cmd.ExecuteNonQuery();
            }
        }

        public void EditarProveedor(Proveedor proveedor)
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = @"
                    UPDATE Proveedores SET 
                        NombreProveedor = @NombreProveedor,
                        Telefono = @Telefono,
                        Email = @Email,
                        Direccion = @Direccion,
                        status = @Status,
                        updated_at = GETDATE()
                    WHERE IdProveedor = @IdProveedor";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@IdProveedor", proveedor.IdProveedor);
                cmd.Parameters.AddWithValue("@NombreProveedor", proveedor.NombreProveedor);
                cmd.Parameters.AddWithValue("@Telefono", proveedor.Telefono);
                cmd.Parameters.AddWithValue("@Email", proveedor.Email);
                cmd.Parameters.AddWithValue("@Direccion", proveedor.Direccion);
                cmd.Parameters.AddWithValue("@Status", proveedor.Status);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarProveedor(int id)
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "UPDATE Proveedores SET status = 0, updated_at = GETDATE() WHERE IdProveedor = @Id";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
