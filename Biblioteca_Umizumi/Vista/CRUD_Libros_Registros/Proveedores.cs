using BibliotecaUmizumi.Controlador;
using BibliotecaUmizumi.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_Umizumi.Vista.CRUD_Libros_Registros
{
    public partial class Proveedores : Form
    {
        private ProveedorController proveedorController = new ProveedorController();
        public Proveedores()
        {
            InitializeComponent();
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor
            {
                NombreProveedor = txtNombre.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Direccion = txtDireccion.Text.Trim(),
                Status = cbEstado.SelectedItem.ToString() == "Activado"
            };

            proveedorController.AgregarProveedor(proveedor);
            CargarProveedores();
            LimpiarCampos();
        }

        private void btnActualizarLibro_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvProveedores.CurrentRow.Cells["IdProveedor"].Value);

                Proveedor proveedor = new Proveedor
                {
                    IdProveedor = id,
                    NombreProveedor = txtNombre.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim(),
                    Status = cbEstado.SelectedItem.ToString() == "Activado"
                };

                proveedorController.EditarProveedor(proveedor);
                CargarProveedores();
                LimpiarCampos();
            }
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            cbEstado.Items.AddRange(new string[] { "Activado", "Desactivado" });
            cbEstado.SelectedIndex = 0;
            CargarProveedores();
        }

        private void CargarProveedores()
        {
            dgvProveedores.DataSource = null;
            dgvProveedores.DataSource = proveedorController.ObtenerProveedores();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();
            cbEstado.SelectedIndex = 0;
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNombre.Text = dgvProveedores.Rows[e.RowIndex].Cells["NombreProveedor"].Value.ToString();
                txtTelefono.Text = dgvProveedores.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
                txtEmail.Text = dgvProveedores.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                txtDireccion.Text = dgvProveedores.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
                bool estado = (bool)dgvProveedores.Rows[e.RowIndex].Cells["Status"].Value;
                cbEstado.SelectedItem = estado ? "Activado" : "Desactivado";
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vista.CRUD_Libros_Registros.CRUD_Libros crud = new CRUD_Libros();
            crud.ShowDialog();
        }
    }
}
