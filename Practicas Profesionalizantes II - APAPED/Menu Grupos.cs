using Practicas_Profesionalizantes_II___APAPED.Consulta;
using Practicas_Profesionalizantes_II___APAPED.Equipo_2Final_6DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practicas_Profesionalizantes_II___APAPED
{
    public partial class Menu_Grupos : Form
    {
        private Menu_Principal menuPrincipal;

        public Menu_Grupos(Menu_Principal menu)
        {
            InitializeComponent();
            menuPrincipal = menu;
            this.ControlBox = false;
        }

        private void BotonAgregaGrupos_Click(object sender, EventArgs e)
        {
            Nuevo_Grupo open = new Nuevo_Grupo();
            this.Hide();
            open.ShowDialog();
            this.Show();

        }

        private void return_menu_Click(object sender, EventArgs e)
        {
            menuPrincipal.Show();
            this.Close(); 
        }

        private void Menu_Grupos_Load(object sender, EventArgs e)
        {
            // Cambiar color de fondo del formulario
            this.BackColor = Color.FromArgb(240, 240, 240);

            // Configurar cada botón
            ConfigurarBotonModerno(BotonAgregaGrupos, "NUEVO GRUPO");
            ConfigurarBotonModerno(BotonListadeGrupos, "VER LISTA DE GRUPOS");
            ConfigurarBotonModerno(BotonAgregarPersonaAGrupo, "PERSONAS EN GRUPO");
            ConfigurarBotonModerno(return_menu, "VOLVER AL MENÚ");
        }
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
        private void BotonAgregarPersonaAGrupo_Click(object sender, EventArgs e)
        {
            N_Agregar_persona_a_grupo personaengrupo = new N_Agregar_persona_a_grupo();
            this.Hide();
            personaengrupo.ShowDialog();
            this.Show();
        }

        private void BotonListadeGrupos_Click(object sender, EventArgs e)
        {
            Consulta.Grupos grupos = new Consulta.Grupos();
            this.Hide();
            grupos.ShowDialog();
            this.Show();
        }

        private void grupo_PersonaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }
    }
}
