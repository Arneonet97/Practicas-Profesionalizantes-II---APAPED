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
    public partial class Menu_Tutores : Form
    {
        public Menu_Tutores()
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

        private void BotonNUEVOTUTOR_Click(object sender, EventArgs e)
        {
            Nuevo_Tutor nuevotutor = new Nuevo_Tutor();
            this.Hide();
            nuevotutor.ShowDialog();
            this.Close();
        }

        private void BotonLISTATUTORES_Click(object sender, EventArgs e)
        {
            Todos_los_tutores todoslostutores = new Todos_los_tutores;
                this.Hide();
            todoslostutores.ShowDialog();
            this.Close();
        }

        private void BotonContacto_Click(object sender, EventArgs e)
        {

        }
    }
}
