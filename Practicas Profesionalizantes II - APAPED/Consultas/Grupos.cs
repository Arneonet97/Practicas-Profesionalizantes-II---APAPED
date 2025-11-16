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
    public partial class Grupos : Form
    {
        public Grupos()
        {
            InitializeComponent();
        }

        private void Grupos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'equipo_2Final_6DataSet.Grupos' Puede moverla o quitarla según sea necesario.
            this.gruposTableAdapter.Fill(this.equipo_2Final_6DataSet.Grupos);

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
