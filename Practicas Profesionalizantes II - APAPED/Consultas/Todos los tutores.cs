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
    public partial class Todos_los_tutores : Form
    {
        public Todos_los_tutores()
        {
            InitializeComponent();
        }

        private void Todos_los_tutores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'equipo_2Final_6DataSet.Todos_los_tutores' Puede moverla o quitarla según sea necesario.
            this.todos_los_tutoresTableAdapter.Fill(this.equipo_2Final_6DataSet.Todos_los_tutores);

        }
    }
}
