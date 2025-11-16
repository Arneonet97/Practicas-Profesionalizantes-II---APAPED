using Practicas_Profesionalizantes_II___APAPED.Equipo_2Final_6DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practicas_Profesionalizantes_II___APAPED
{
    public partial class Menu_Personas : Form
    {
        private Menu_Principal menuPrincipal;
        public Menu_Personas(Menu_Principal menu)
        {
            InitializeComponent();
            menuPrincipal = menu;
            this.ControlBox = false;
        }

        private void BotonAgregarPersonas_Click(object sender, EventArgs e)
        {
            Navegar_Personas open = new Navegar_Personas();
            this.Hide();
            open.ShowDialog();
            this.Show();
            
        }

        private void BotonListadePersonas_Click(object sender, EventArgs e)
        {
            Consulta.Todas_las_personas todaslaspersonas = new Consulta.Todas_las_personas();
            this.Hide();
            todaslaspersonas.ShowDialog();
            this.Show();
        }

        private void botonCUDVencidos_Click(object sender, EventArgs e)
        {
            Consulta.CUDs_vencidos cudsvencidos = new Consulta.CUDs_vencidos();
            this.Hide();
            cudsvencidos.ShowDialog();
            this.Show();
        }

        private void return_menu_Click(object sender, EventArgs e)
        {
            menuPrincipal.Show();
            this.Close();
        }

        private void Menu_Personas_Load(object sender, EventArgs e)
        {
            // Cambiar color de fondo del formulario
            this.BackColor = Color.FromArgb(240, 240, 240);

            // Configurar cada botón
            ConfigurarBotonModerno(BotonAgregarPersonas, "AGREGAR PERSONA");
            ConfigurarBotonModerno(BotonListadePersonas, "LISTA DE PERSONAS");
            ConfigurarBotonModerno(botonCUDVencidos, "CUD VENCIDOS");
            ConfigurarBotonModerno(return_menu, "VOLVER AL MENÚ");
        }

        // Función para configurar botones
        private void ConfigurarBotonModerno(System.Windows.Forms.Button btn, string texto)
        {
            btn.Text = texto;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.ForeColor = Color.White;
            btn.BackColor = Color.FromArgb(45, 130, 220); // azul moderno
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Size = new Size(150, 80);

            // Bordes redondeados
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 10;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            btn.Region = new Region(path);

            // Efecto hover
            btn.MouseEnter += (s, evt) => { btn.BackColor = Color.FromArgb(65, 150, 240); };
            btn.MouseLeave += (s, evt) => { btn.BackColor = Color.FromArgb(45, 130, 220); };

        }

    }
}
