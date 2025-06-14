﻿// Formulario: CRUD_Libros.cs
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Biblioteca_Umizumi.Modelo;
using Biblioteca_Umizumi.Controlador;
using System.Linq;
using BibliotecaUmizumi.Controlador;

namespace Biblioteca_Umizumi.Vista.CRUD_Libros_Registros
{
    public partial class CRUD_Libros : Form
    {
        private CRUDLibrosController libroController = new CRUDLibrosController();
        private AutorController autorController = new AutorController();
        private CategoriaController categoriaController = new CategoriaController();
        private ProveedorController proveedorController = new ProveedorController();

        public CRUD_Libros(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        public CRUD_Libros()
        {
            InitializeComponent();
        }

        public int idUsuario;

        private void CRUD_Libros_Load(object sender, EventArgs e)
        {
            cbEstado.Items.AddRange(new string[] { "Activado", "Desactivado" });
            cbEstado.SelectedIndex = 0;

            CargarCombos();
            CargarLibros();
        }

        private void CargarCombos()
        {
            cbAutor.DataSource = autorController.ObtenerAutores();
            cbAutor.DisplayMember = "NombreAutor";
            cbAutor.ValueMember = "IdAutor";

            cbCategoria.DataSource = categoriaController.ObtenerCategorias();
            cbCategoria.DisplayMember = "NombreCategoria";
            cbCategoria.ValueMember = "IdCategoria";

            cbProveedor.DataSource = proveedorController.ObtenerProveedores();
            cbProveedor.DisplayMember = "NombreProveedor";
            cbProveedor.ValueMember = "IdProveedor";
        }

        private void CargarLibros()
        {
            dgvLibros.DataSource = null;
            dgvLibros.DataSource = libroController.ObtenerLibros();
        }

        private void LimpiarCampos()
        {
            txtTitulo.Clear();
            cbAutor.SelectedIndex = 0;
            cbCategoria.SelectedIndex = 0;
            cbProveedor.SelectedIndex = 0;
            nudStock.Value = 0;
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            txtDescripcion.Clear();
            cbEstado.SelectedIndex = 0;
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioCompra.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioVenta.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Todos los campos deben estar completos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrecioCompra.Text, out decimal precioCompra) ||
                !decimal.TryParse(txtPrecioVenta.Text, out decimal precioVenta))
            {
                MessageBox.Show("Los precios deben ser valores numéricos válidos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existentes = libroController.ObtenerLibros();
            bool duplicado = existentes.Any(l =>
                l.Titulo.Equals(txtTitulo.Text.Trim(), StringComparison.OrdinalIgnoreCase) &&
                l.IdAutor == (int)cbAutor.SelectedValue &&
                l.IdCategoria == (int)cbCategoria.SelectedValue);

            if (duplicado)
            {
                MessageBox.Show("Ya existe un libro con el mismo título, autor y categoría.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Libro libro = new Libro
            {
                Titulo = txtTitulo.Text.Trim(),
                IdAutor = (int)cbAutor.SelectedValue,
                IdCategoria = (int)cbCategoria.SelectedValue,
                IdProveedor = (int)cbProveedor.SelectedValue,
                Cantidad_Stock = (int)nudStock.Value,
                PrecioCompra = precioCompra,
                PrecioVenta = precioVenta,
                Descripcion = txtDescripcion.Text.Trim(),
                Status = cbEstado.SelectedItem.ToString() == "Activado"
            };

            libroController.AgregarLibro(libro);
            CargarLibros();
            LimpiarCampos();
            MessageBox.Show("Libro agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BitacoraController.RegistrarAccion(idUsuario, "INSERT", "Libros");
        }

        private void btnActualizarLibro_Click(object sender, EventArgs e)
        {
            if (dgvLibros.CurrentRow != null)
            {
                try
                {
                    int id = Convert.ToInt32(dgvLibros.CurrentRow.Cells["IdLibro"].Value);

                    Libro libro = new Libro
                    {
                        IdLibro = id,
                        Titulo = txtTitulo.Text,
                        IdAutor = (int)cbAutor.SelectedValue,
                        IdCategoria = (int)cbCategoria.SelectedValue,
                        IdProveedor = (int)cbProveedor.SelectedValue,
                        Cantidad_Stock = (int)nudStock.Value,
                        PrecioCompra = Convert.ToDecimal(txtPrecioCompra.Text),
                        PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text),
                        Descripcion = txtDescripcion.Text,
                        Status = cbEstado.SelectedItem.ToString() == "Activado"
                    };

                    libroController.EditarLibro(libro);
                    CargarLibros();
                    LimpiarCampos();

                    MessageBox.Show("✅ Libro actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BitacoraController.RegistrarAccion(idUsuario, "UPDATE", "Libros");
                }
                catch (FormatException)
                {
                    MessageBox.Show("❌ Error de formato: asegúrate de que los precios sean numéricos válidos.", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (InvalidCastException)
                {
                    MessageBox.Show("❌ Error al convertir datos: revisa que los campos seleccionados (autor, categoría, proveedor) estén correctamente definidos.", "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"❌ Error inesperado al actualizar el libro:\n{ex.Message}", "Error general", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("❗ Selecciona un libro antes de actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            if (dgvLibros.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvLibros.CurrentRow.Cells["IdLibro"].Value);
                libroController.EliminarLibro(id);
                CargarLibros();
                LimpiarCampos();
            }

            BitacoraController.RegistrarAccion(idUsuario, "DELETE", "Libros");
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtTitulo.Text = dgvLibros.Rows[e.RowIndex].Cells["Titulo"].Value.ToString();
                cbAutor.SelectedValue = dgvLibros.Rows[e.RowIndex].Cells["IdAutor"].Value;
                cbCategoria.SelectedValue = dgvLibros.Rows[e.RowIndex].Cells["IdCategoria"].Value;
                cbProveedor.SelectedValue = dgvLibros.Rows[e.RowIndex].Cells["IdProveedor"].Value;
                nudStock.Value = Convert.ToInt32(dgvLibros.Rows[e.RowIndex].Cells["Cantidad_Stock"].Value);
                txtPrecioCompra.Text = dgvLibros.Rows[e.RowIndex].Cells["PrecioCompra"].Value.ToString();
                txtPrecioVenta.Text = dgvLibros.Rows[e.RowIndex].Cells["PrecioVenta"].Value.ToString();
                txtDescripcion.Text = dgvLibros.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                bool estado = (bool)dgvLibros.Rows[e.RowIndex].Cells["Status"].Value;
                cbEstado.SelectedItem = estado ? "Activado" : "Desactivado";
            }
        }

        private void btnAutorCategoria_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autor_Categoria form = new Autor_Categoria(idUsuario);
            form.ShowDialog();
            this.Show();
            CargarCombos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vista.Dashboard.Dashboard dashboard = new Vista.Dashboard.Dashboard(idUsuario);
            dashboard.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vista.CRUD_Libros_Registros.Proveedores proveedores = new Proveedores(idUsuario);
            proveedores.ShowDialog();
        }

        private void lblDatos_Click(object sender, EventArgs e)
        {

        }
    }
}
