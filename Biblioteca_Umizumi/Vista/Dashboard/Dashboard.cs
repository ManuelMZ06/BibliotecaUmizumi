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

namespace Biblioteca_Umizumi.Vista.Dashboard
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            // Iconos sidebar
            pbUser.Image = Properties.Resources.user1;
            pbCRUD.Image = Properties.Resources.edit;
            pbReportes.Image = Properties.Resources.report;
            pbRespaldos.Image = Properties.Resources.database_management;
            pbAnalisis.Image = Properties.Resources.data;
            pbPredictivo.Image = Properties.Resources.ai;

            //Iconos Cards
            pbCardUser.Image = Properties.Resources.user1;
            pbCardCRUD.Image = Properties.Resources.edit;
            pbCardReportes.Image = Properties.Resources.report;
            pbCardRespaldos.Image = Properties.Resources.database_management;
            pbCardAnalisis.Image = Properties.Resources.data;
            pbCardPredictivo.Image = Properties.Resources.ai;



        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

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
            RedondearPanel(panelCardAnalisis, 10);
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
            Vista.CRUD_Libros_Registros.CRUD_Libros crudLibros = new Vista.CRUD_Libros_Registros.CRUD_Libros();
            crudLibros.ShowDialog();
        }
    }
}