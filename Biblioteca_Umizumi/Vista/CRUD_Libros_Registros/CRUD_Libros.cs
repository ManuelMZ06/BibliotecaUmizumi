using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Biblioteca_Umizumi.Modelo;
using Biblioteca_Umizumi.Controlador;
using System.Linq;

namespace Biblioteca_Umizumi.Vista.CRUD_Libros_Registros
{
    public partial class CRUD_Libros : Form
    {
        private CRUDLibrosController libroController = new CRUDLibrosController();
        private AutorController autorController = new AutorController();
        private CategoriaController categoriaController = new CategoriaController();

        public CRUD_Libros()
        {
            InitializeComponent();
        }

        private void CRUD_Libros_Load(object sender, EventArgs e)
        {
            cbEstado.Items.AddRange(new string[] { "Activado", "Desactivado" });
            cbEstado.SelectedIndex = 0;

            CargarAutoresYCategorias();
            CargarLibros();
        }

        private void CargarAutoresYCategorias()
        {
            cbAutor.DataSource = autorController.ObtenerAutores();
            cbAutor.DisplayMember = "NombreAutor";
            cbAutor.ValueMember = "IdAutor";

            cbCategoria.DataSource = categoriaController.ObtenerCategorias();
            cbCategoria.DisplayMember = "NombreCategoria";
            cbCategoria.ValueMember = "IdCategoria";
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
            nudStock.Value = 0;
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            txtDescripcion.Clear();
            cbEstado.SelectedIndex = 0;
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            // Validación 1: campos vacíos
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioCompra.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioVenta.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Todos los campos deben estar completos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validación 2: conversión numérica segura
            if (!decimal.TryParse(txtPrecioCompra.Text, out decimal precioCompra) ||
                !decimal.TryParse(txtPrecioVenta.Text, out decimal precioVenta))
            {
                MessageBox.Show("Los precios deben ser valores numéricos válidos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validación 3: registro duplicado (título + autor + categoría)
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

            // Si todo está bien, continuar
            Libro libro = new Libro
            {
                Titulo = txtTitulo.Text.Trim(),
                IdAutor = (int)cbAutor.SelectedValue,
                IdCategoria = (int)cbCategoria.SelectedValue,
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
        }


        private void btnActualizarLibro_Click(object sender, EventArgs e)
        {
            if (dgvLibros.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvLibros.CurrentRow.Cells["IdLibro"].Value);

                Libro libro = new Libro
                {
                    IdLibro = id,
                    Titulo = txtTitulo.Text,
                    IdAutor = (int)cbAutor.SelectedValue,
                    IdCategoria = (int)cbCategoria.SelectedValue,
                    Cantidad_Stock = (int)nudStock.Value,
                    PrecioCompra = Convert.ToDecimal(txtPrecioCompra.Text),
                    PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text),
                    Descripcion = txtDescripcion.Text,
                    Status = cbEstado.SelectedItem.ToString() == "Activado"
                };

                libroController.EditarLibro(libro);
                CargarLibros();
                LimpiarCampos();
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
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtTitulo.Text = dgvLibros.Rows[e.RowIndex].Cells["Titulo"].Value.ToString();
                cbAutor.SelectedValue = dgvLibros.Rows[e.RowIndex].Cells["IdAutor"].Value;
                cbCategoria.SelectedValue = dgvLibros.Rows[e.RowIndex].Cells["IdCategoria"].Value;
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
            Autor_Categoria form = new Autor_Categoria();
            form.ShowDialog();
            this.Show();
            CargarAutoresYCategorias(); // refrescar comboboxes después de insertar
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vista.Dashboard.Dashboard dashboard = new Vista.Dashboard.Dashboard();
            dashboard.ShowDialog();
        }
    }
}
