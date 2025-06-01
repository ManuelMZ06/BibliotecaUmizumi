using Biblioteca_Umizumi.Controlador;
using BibliotecaUmizumi.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_Umizumi.Vista.Movimientos
{
    public partial class Movimientos : Form
    {
        private MovimientoController controller = new MovimientoController();
        private CRUDLibrosController librosController = new CRUDLibrosController();
        private int idUsuario;
        public Movimientos(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void Movimientos_Load(object sender, EventArgs e)
        {
            cbTipoMovimiento.Items.AddRange(new string[] { "Entrada", "Salida" });
            cbTipoMovimiento.SelectedIndex = 0;

            cbLibro.DataSource = librosController.ObtenerLibros();
            cbLibro.DisplayMember = "Titulo";
            cbLibro.ValueMember = "IdLibro";

            CargarMovimientos();
        }

        private void CargarMovimientos()
        {
            dgvMovimientos.DataSource = null;
            dgvMovimientos.DataSource = controller.ObtenerMovimientos();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int idLibro = (int)cbLibro.SelectedValue;
            string tipo = cbTipoMovimiento.SelectedItem.ToString();
            int cantidad = (int)nudCantidad.Value;
            string observaciones = txtObservaciones.Text.Trim();

            string mensaje = controller.RegistrarMovimiento(idLibro, tipo, cantidad, idUsuario, observaciones);
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarMovimientos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vista.Dashboard.Dashboard dashboard = new Vista.Dashboard.Dashboard();
            dashboard.ShowDialog();
        }
    }
}
