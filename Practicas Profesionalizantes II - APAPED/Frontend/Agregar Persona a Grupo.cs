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
    public partial class Agregar_Persona_a_Grupo : Form
    {
        public Agregar_Persona_a_Grupo()
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
    }
}
