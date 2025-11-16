using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas_Profesionalizantes_II___APAPED.Consultas
{
    public partial class Personas_en_grupo : Form
    {
        public Personas_en_grupo()
        {
            InitializeComponent();
        }

        private void Personas_en_grupo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'equipo_2Final_6DataSet.Personas_en_grupo' Puede moverla o quitarla según sea necesario.
            this.personas_en_grupoTableAdapter.Fill(this.equipo_2Final_6DataSet.Personas_en_grupo);

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
