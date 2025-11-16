using Practicas_Profesionalizantes_II___APAPED.Consulta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas_Profesionalizantes_II___APAPED
{
    public partial class N_Agregar_persona_a_grupo : Form
    {
        public N_Agregar_persona_a_grupo()
        {
            InitializeComponent();
         
        }
        private void LimpiarTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else if (c.HasChildren)
                    LimpiarTextBoxes(c); // llamada recursiva para contenedores anidados
            }
        }

        private void BotonLista_Click(object sender, EventArgs e)
        {
            Consulta.Persona_en_grupo personasengrupo = new Persona_en_grupo();
            this.Hide();
            personasengrupo.ShowDialog();
            this.Show();
        }

        private void personas_con_discapacidad_NombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void CargarDatosDePersona(int idPersona)
        {

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Equipo_2Final_6.accdb";
            using (OleDbConnection conexion = new OleDbConnection(connectionString))
            {
                conexion.Open();
                string consulta = "SELECT Documento FROM [Personas con discapacidad] WHERE [Id Persona] = ?";
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                comando.Parameters.AddWithValue("?", idPersona);

                using (OleDbDataReader lector = comando.ExecuteReader())
                {
                    if (lector.Read())
                    {
                        // Mostrar el documento en la caja de texto de solo lectura
                        DNITextBox1.Text = lector["Documento"].ToString();
                    }
                }
            }
        }
       
        private void grupo_PersonaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.grupo_PersonaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.equipo_2Final_6DataSet);

        }

        private void N_Agregar_persona_a_grupo_Load(object sender, EventArgs e)
        {
            // Cargar todas las personas en el ComboBox de nombres
            var personasAdapter = new Practicas_Profesionalizantes_II___APAPED.Equipo_2Final_6DataSetTableAdapters.Personas_con_discapacidadTableAdapter();
            var personasTable = personasAdapter.GetData();

            comboBoxNombre.DisplayMember = "Nombre";
            comboBoxNombre.ValueMember = "Id Persona";
            comboBoxNombre.DataSource = personasTable;

            // Cargar todos los grupos en el ComboBox de grupos
            var gruposAdapter = new Practicas_Profesionalizantes_II___APAPED.Equipo_2Final_6DataSetTableAdapters.GruposTableAdapter();
            var gruposTable = gruposAdapter.GetData();

            ComboBoxNombreGrupo.DisplayMember = "Nombre";
            ComboBoxNombreGrupo.ValueMember = "Id Grupo";
            ComboBoxNombreGrupo.DataSource = gruposTable;

            // Mostrar DNI cuando se selecciona persona
            comboBoxNombre.SelectedIndexChanged += (s, ev) =>
            {
                if (comboBoxNombre.SelectedValue is int idPersona)
                {
                    MostrarDNI(idPersona);
                }
            };

            ConfigurarBotonModerno(botonAgregar, "AGREGAR");
            ConfigurarBotonModerno(BotonLista, "LISTA");
            ConfigurarLabels();
        }

        private void ConfigurarLabels()
        {
            // Fuente y colores
            label1.Font = new Font("Segoe UI", 40, FontStyle.Bold);
            Color fondoAzul = Color.FromArgb(45, 130, 220);

            // Fondo y color principal
            label1.BackColor = fondoAzul;

            // Asignar el evento Paint a los tres labels
            label1.Paint -= LabelConSombra_Paint;

            //label5.Paint -= LabelConSombra_Paint;
            label1.Paint += LabelConSombra_Paint;
        }

        private void LabelConSombra_Paint(object sender, PaintEventArgs e)
        {
            // 🔹 Usamos el namespace completo para evitar la ambigüedad
            System.Windows.Forms.Label lbl = sender as System.Windows.Forms.Label;
            if (lbl == null) return;

            // Dibujar sombra (ligeramente desplazada)
            e.Graphics.DrawString(lbl.Text, lbl.Font, Brushes.Black, 2, 2);

            // Dibujar texto principal
            e.Graphics.DrawString(lbl.Text, lbl.Font, Brushes.White, 0, 0);
        }



        // Función para configurar botones
        private void ConfigurarBotonModerno(System.Windows.Forms.Button btn, string texto)
        {
            btn.Text = texto;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.ForeColor = Color.White;
            btn.BackColor = Color.FromArgb(45, 130, 220); // azul moderno
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Size = new Size(150, 60);

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
        private void MostrarDNI(int idPersona)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Equipo_2Final_6.accdb";

            using (OleDbConnection conexion = new OleDbConnection(connectionString))
            {
                conexion.Open();
                string consulta = "SELECT Documento FROM [Personas con discapacidad] WHERE [Id Persona] = ?";
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                comando.Parameters.AddWithValue("?", idPersona);

                using (OleDbDataReader lector = comando.ExecuteReader())
                {
                    if (lector.Read())
                    {
                        DNITextBox1.Text = lector["Documento"].ToString();
                    }
                }
            }
        }
        private void CargarDatosActuales()
        {
            var filaActual = (DataRowView)grupo_PersonaBindingSource.Current;
            if (filaActual != null)
            {
                // Mostrar DNI en TextBox
                DNITextBox1.Text = filaActual["Documento"].ToString();

                // Mostrar valores en los ComboBox
                comboBoxNombre.SelectedValue = filaActual["Id Persona"];
                ComboBoxNombreGrupo.SelectedValue = filaActual["Id Grupo"];
            }
        }
        private void botonAgregar_Click(object sender, EventArgs e)
        {
            if (comboBoxNombre.SelectedValue is int idPersona && ComboBoxNombreGrupo.SelectedValue is int idGrupo)
            {
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Equipo_2Final_6.accdb";

                using (OleDbConnection conexion = new OleDbConnection(connectionString))
                {
                    conexion.Open();
                    string insertar = "INSERT INTO Grupo_Persona ([Id Persona], [Id Grupo]) VALUES (?, ?)";
                    OleDbCommand comando = new OleDbCommand(insertar, conexion);
                    comando.Parameters.AddWithValue("?", idPersona);
                    comando.Parameters.AddWithValue("?", idGrupo);

                    try
                    {
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Persona agregada al grupo correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una persona y un grupo.");
            }
        }
        private void CargarDatosDePersonaActual()
        {
            var personaActual = (DataRowView)grupo_PersonaBindingSource.Current;
            if (personaActual != null)
            {
                int idPersona = Convert.ToInt32(personaActual["Id Persona"]);
                CargarDatosDePersona(idPersona);
            }
        }
    }
}
