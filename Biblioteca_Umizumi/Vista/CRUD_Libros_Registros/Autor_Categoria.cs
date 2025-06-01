using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Biblioteca_Umizumi.Modelo;
using Biblioteca_Umizumi.Controlador;

namespace Biblioteca_Umizumi.Vista.CRUD_Libros_Registros
{
    public partial class Autor_Categoria : Form
    {
        private AutorController autorController = new AutorController();
        private CategoriaController categoriaController = new CategoriaController();

        public Autor_Categoria()
        {
            InitializeComponent();
        }

        private void Autor_Categoria_Load(object sender, EventArgs e)
        {
            cbEstadoAutor.Items.AddRange(new string[] { "Activado", "Desactivado" });
            cbEstadoCategoria.Items.AddRange(new string[] { "Activado", "Desactivado" });

            cbEstadoAutor.SelectedIndex = 0;
            cbEstadoCategoria.SelectedIndex = 0;

            CargarAutores();
            CargarCategorias();
        }

        // ================================
        // AUTORES
        // ================================
        private void CargarAutores()
        {
            dgvAutores.DataSource = null;
            dgvAutores.DataSource = autorController.ObtenerAutores();
        }

        private void dgvAutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNombreAutor.Text = dgvAutores.Rows[e.RowIndex].Cells["NombreAutor"].Value.ToString();
                bool estado = (bool)dgvAutores.Rows[e.RowIndex].Cells["Status"].Value;
                cbEstadoAutor.SelectedItem = estado ? "Activado" : "Desactivado";
            }
        }

        private void LimpiarCamposAutor()
        {
            txtNombreAutor.Clear();
            cbEstadoAutor.SelectedIndex = 0;
        }

        private void btnAgregarAutor_Click_1(object sender, EventArgs e)
        {
            Autor autor = new Autor
            {
                NombreAutor = txtNombreAutor.Text,
                Status = cbEstadoAutor.SelectedItem.ToString() == "Activado"
            };

            autorController.AgregarAutor(autor);
            CargarAutores();
            LimpiarCamposAutor();
        }

        private void btnActualizarAutor_Click_1(object sender, EventArgs e)
        {
            if (dgvAutores.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvAutores.CurrentRow.Cells["IdAutor"].Value);

                Autor autor = new Autor
                {
                    IdAutor = id,
                    NombreAutor = txtNombreAutor.Text,
                    Status = cbEstadoAutor.SelectedItem.ToString() == "Activado"
                };

                autorController.EditarAutor(autor);
                CargarAutores();
                LimpiarCamposAutor();
            }
        }

        private void btnEliminarAutor_Click_1(object sender, EventArgs e)
        {
            if (dgvAutores.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvAutores.CurrentRow.Cells["IdAutor"].Value);
                autorController.EliminarAutor(id);
                CargarAutores();
                LimpiarCamposAutor();
            }
        }

        // ================================
        // CATEGORÍAS
        // ================================
        private void CargarCategorias()
        {
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = categoriaController.ObtenerCategorias();
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNombreCategoria.Text = dgvCategorias.Rows[e.RowIndex].Cells["NombreCategoria"].Value.ToString();
                bool estado = (bool)dgvCategorias.Rows[e.RowIndex].Cells["Status"].Value;
                cbEstadoCategoria.SelectedItem = estado ? "Activado" : "Desactivado";
            }
        }

        private void LimpiarCamposCategoria()
        {
            txtNombreCategoria.Clear();
            cbEstadoCategoria.SelectedIndex = 0;
        }

        private void btnAgregarCategoria_Click_1(object sender, EventArgs e)
        {
            Categorias categoria = new Categorias
            {
                NombreCategoria = txtNombreCategoria.Text,
                Status = cbEstadoCategoria.SelectedItem.ToString() == "Activado"
            };

            categoriaController.AgregarCategoria(categoria);
            CargarCategorias();
            LimpiarCamposCategoria();
        }

        private void btnActulizarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvCategorias.CurrentRow.Cells["IdCategoria"].Value);

                Categorias categoria = new Categorias
                {
                    IdCategoria = id,
                    NombreCategoria = txtNombreCategoria.Text,
                    Status = cbEstadoCategoria.SelectedItem.ToString() == "Activado"
                };

                categoriaController.EditarCategoria(categoria);
                CargarCategorias();
                LimpiarCamposCategoria();
            }
        }

        private void btnEliminarCategoria_Click_1(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvCategorias.CurrentRow.Cells["IdCategoria"].Value);
                categoriaController.EliminarCategoria(id);
                CargarCategorias();
                LimpiarCamposCategoria();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Evento opcional
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vista.CRUD_Libros_Registros.CRUD_Libros crudLibros = new Vista.CRUD_Libros_Registros.CRUD_Libros();
            crudLibros.ShowDialog();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
