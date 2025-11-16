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

namespace Practicas_Profesionalizantes_II___APAPED.Consultas
{
    public partial class Todas_las_personas : Form
    {
        public Todas_las_personas()
        {
            InitializeComponent();
        }

     

        private void Todas_las_personas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'equipo_2Final_6DataSet.Todas_las_personas' Puede moverla o quitarla según sea necesario.
            this.todas_las_personasTableAdapter.Fill(this.equipo_2Final_6DataSet.Todas_las_personas);

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

