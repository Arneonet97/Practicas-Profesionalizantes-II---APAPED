using Practicas_Profesionalizantes_II___APAPED.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas_Profesionalizantes_II___APAPED
{
    public partial class Menu_Grupos : Form
    {
        public Menu_Grupos()
        {
            InitializeComponent();
        }

        private void BotonMenuPrincipal_Click(object sender, EventArgs e)
        {
            Form1 menuprincipal = new Form1();
            this.Hide();
            menuprincipal.ShowDialog();
            this.Close();
        }

        private void BotonEDITARGRUPOS_Click(object sender, EventArgs e)
        {
            Nuevo_Grupo nuevogrupo = new Nuevo_Grupo();
            this.Hide();
            nuevogrupo.ShowDialog();
            this.Close();
        }

        private void BotonLISTADEGRUPOS_Click(object sender, EventArgs e)
        {
            Grupos Grupos = new Grupos();
            this.Hide();
            Grupos.ShowDialog();
            this.Close();
        }

        private void BotonAGREGARPERSONAS_Click(object sender, EventArgs e)
        {
            Agregar_Persona_a_Grupo agregarpersonaagrupo = new Agregar_Persona_a_Grupo();
            this.Hide();
            agregarpersonaagrupo.ShowDialog();
            this.Close();
        }
    }
}
