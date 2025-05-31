using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Biblioteca_Umizumi.Controlador;
using Biblioteca_Umizumi.Modelo;

namespace Biblioteca_Umizumi.Vista.Usuarios
{
    public partial class Usuarios : Form
    {
        private UserController userController = new UserController();

        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = null;

            var lista = userController.ObtenerUsuarios();

            // Crear nueva lista con estado como texto
            var listaVisual = lista.Select(u => new
            {
                u.IdUsuario,
                u.UsuarioNombre,
                u.IdRol,
                Estado = u.Status ? "Activado" : "Desactivado",
                u.CreatedAt,
                u.UpdatedAt
            }).ToList();

            dgvUsuarios.DataSource = listaVisual;
        }


        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value);
                userController.ActivarUsuario(id);
                CargarUsuarios();
                MessageBox.Show("Usuario activado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selecciona un usuario para activar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value);
                userController.DesactivarUsuario(id);
                CargarUsuarios();
                MessageBox.Show("Usuario desactivado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selecciona un usuario para desactivar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vista.Dashboard.Dashboard dashboard = new Vista.Dashboard.Dashboard();
            dashboard.ShowDialog();
        }
    }
}
