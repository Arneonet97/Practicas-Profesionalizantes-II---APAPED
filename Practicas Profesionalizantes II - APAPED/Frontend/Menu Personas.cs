using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Practicas_Profesionalizantes_II___APAPED.Consultas;

namespace Practicas_Profesionalizantes_II___APAPED
{
    public partial class Menu_Personas : Form
    {
        public Menu_Personas()
        {
            InitializeComponent();
        }

        private void BotonAgregarPersonas_Click(object sender, EventArgs e)
        {
            Navegar_Personas navegarpersonas = new Navegar_Personas();
            this.Hide();
            navegarpersonas.ShowDialog();
            this.Close();
        }

        private void BotonListadePersonas_Click(object sender, EventArgs e)
        {
            Todas_las_personas todaslaspersonas = new Todas_las_personas();
            this.Hide();
            todaslaspersonas.ShowDialog();
            this.Close();
        }

        private void botonCUDVencidos_Click(object sender, EventArgs e)
        {
            CUDs_vencidos cudsvencidos = new CUDs_vencidos();
            this.Hide();
            cudsvencidos.ShowDialog();
            this.Close();
        }

        private void BotonMenuPrincipal_Click(object sender, EventArgs e)
        {
            Form1 menuprincipal = new Form1();
            this.Hide();
            menuprincipal.ShowDialog();
            this.Close();
        }
    }
}
