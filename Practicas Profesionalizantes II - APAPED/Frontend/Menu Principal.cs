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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotonPersonas_Click(object sender, EventArgs e)
        {
            Menu_Personas menuPersonas = new Menu_Personas();
            this.Hide();
            menuPersonas.ShowDialog();
            this.Close();
        }

        private void MenuGrupos_Click(object sender, EventArgs e)
        {
            Menu_Grupos menuGrupos = new Menu_Grupos();
            this.Hide();
            menuGrupos.ShowDialog();
            this.Close();
        }

        private void MenuTutores_Click(object sender, EventArgs e)
        {
            Menu_Tutores menuTutores = new Menu_Tutores();
            this.Hide();
            menuTutores.ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
