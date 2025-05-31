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

namespace Biblioteca_Umizumi.Vista.Dashboard
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            pbUser.Image = Properties.Resources.user1;
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
    }
}
