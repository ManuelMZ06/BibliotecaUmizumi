using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using Biblioteca_Umizumi.Vista.Autenticacion;
using Biblioteca_Umizumi.Modelo;
using BibliotecaUmizumi.Controlador;
using BibliotecaUmizumi.Modelo;
using System.Data.SqlClient;

namespace Biblioteca_Umizumi.Vista.Dashboard
{
    public partial class Dashboard : Form
    {
        private int idUsuario;
        private int idRol; // para permisos
        public Dashboard(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.idRol = ObtenerRolUsuario(idUsuario);

        }
        public Dashboard() // Constructor sin argumentos
        {
            InitializeComponent();
        }

        private int ObtenerRolUsuario(int idUsuario)
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "SELECT idRol FROM Usuarios WHERE IdUsuario = @id";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@id", idUsuario);

                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }




        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Iconos sidebar
            pbUser.Image = Properties.Resources.user1;
            pbCRUD.Image = Properties.Resources.edit;
            pbReportes.Image = Properties.Resources.report;
            pbRespaldos.Image = Properties.Resources.database_management;
            //pbAnalisis.Image = Properties.Resources.data;
            pbPredictivo.Image = Properties.Resources.ai;
            pbMovimientos.Image = Properties.Resources.people;

            //Iconos Cards
            pbCardUser.Image = Properties.Resources.user1;
            pbCardCRUD.Image = Properties.Resources.edit;
            pbCardReportes.Image = Properties.Resources.report;
            pbCardRespaldos.Image = Properties.Resources.database_management;
            //pbCardAnalisis.Image = Properties.Resources.data;
            pbCardPredictivo.Image = Properties.Resources.ai;
            pbCardMovimientos.Image = Properties.Resources.people;

            if (idRol == 2) // Si es empleado
            {
                panelCardUsuarios.Visible = false;
                btnUsuarios.Visible = false;
                pbUser.Visible = false;
            }
        }

        public void RedondearPanel(Panel panel, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(panel.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(panel.Width - radio, panel.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, panel.Height - radio, radio, radio, 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }

        private void btnMostrarEsconderSideBar_Click(object sender, EventArgs e)
        {
            if (PanelSidebar.Visible)
            {
                PanelSidebar.Visible = false;
                btnMostrarEsconderSideBar.Text = "☰"; // Cambia a ícono de abrir
            }
            else
            {
                PanelSidebar.Visible = true;
                btnMostrarEsconderSideBar.Text = "←"; // Cambia a ícono de cerrar
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            RedondearPanel(panelCardUsuarios, 10);
        }


        private void btnCerrarSesión_Click(object sender, EventArgs e)
        {
            SesionController.RegistrarCierreSesion(idUsuario);

            this.Hide();
            new FormLogin().ShowDialog();
            this.Close();
        }

        private void panelCardCRUD_Paint(object sender, PaintEventArgs e)
        {
            RedondearPanel(panelCardCRUD, 10);
        }

        private void panelCardReportes_Paint(object sender, PaintEventArgs e)
        {
            RedondearPanel(panelCardReportes, 10);
        }

        private void panelCardRespaldos_Paint(object sender, PaintEventArgs e)
        {
            RedondearPanel(panelCardRespaldos, 10);
        }


        private void panelCardAnalisis_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void PanelPredictivo_Paint(object sender, PaintEventArgs e)
        {
            RedondearPanel(PanelPredictivo, 10);
        }

        private void btnCardUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vista.Usuarios.Usuarios users = new Vista.Usuarios.Usuarios();
            users.ShowDialog();
        }

        private void btnCardCRUD_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vista.CRUD_Libros_Registros.CRUD_Libros crudLibros = new Vista.CRUD_Libros_Registros.CRUD_Libros(idUsuario);
            crudLibros.ShowDialog();
        }

        private void btnCardReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vista.Reportes.MenuReportes menuReportes = new Reportes.MenuReportes(idUsuario);
            menuReportes.ShowDialog(); ;
        }

        private void btnCardRespaldos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vista.Resplados.Respaldos fRespaldos = new Resplados.Respaldos(idUsuario);
            fRespaldos.ShowDialog(); ;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vista.Usuarios.Usuarios users = new Vista.Usuarios.Usuarios();
            users.ShowDialog();
        }

        private void btnCRUD_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vista.CRUD_Libros_Registros.CRUD_Libros crudLibros = new Vista.CRUD_Libros_Registros.CRUD_Libros(idUsuario);
            crudLibros.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vista.Reportes.MenuReportes menuReportes = new Reportes.MenuReportes(idUsuario);
            menuReportes.ShowDialog();
        }

        private void btnRespaldos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vista.Resplados.Respaldos fRespaldos = new Resplados.Respaldos(idUsuario);
            fRespaldos.ShowDialog();
        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {

        }

        private void btnPredictivo_Click(object sender, EventArgs e)
        {

        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vista.Movimientos.Movimientos movimientos = new Vista.Movimientos.Movimientos(idUsuario);
            movimientos.ShowDialog();
        }

        private void btnCardMovimientos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vista.Movimientos.Movimientos movimientos = new Vista.Movimientos.Movimientos(idUsuario);
            movimientos.ShowDialog();
        }

        private void btnCardPredictivo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vista.ModeloPredictivo.PrediccionDemanda prediccion = new Vista.ModeloPredictivo.PrediccionDemanda(idUsuario);
            prediccion.ShowDialog();    
        }

        private void panelCardMovimientos_Paint(object sender, PaintEventArgs e)
        {
            RedondearPanel(panelCardMovimientos, 10);
        }


        private void PanelContenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbUser_Click(object sender, EventArgs e)
        {

        }
    }
}