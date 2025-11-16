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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practicas_Profesionalizantes_II___APAPED
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
            this.ControlBox = false;

        }
        #region Conexion
        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = usuarioTextBox.Text.Trim();
            string password = passTextBox.Text.Trim();

            string conexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Equipo_2Final_6.accdb";

            using (OleDbConnection con = new OleDbConnection(conexion))
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM usuarios WHERE Usuario = ? AND Pass = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("?", usuario);
                        cmd.Parameters.AddWithValue("?", password);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Bienvenido " + usuario);
                            this.Hide(); //Oculto el form de login 
                            Menu_Principal menu = new Menu_Principal(usuario);
                            menu.Show();
                        }
                        else
                        {
                            //Si la contraseña o usuario son incorrectos muestra...
                            MessageBox.Show("Usuario o contraseña incorrectos. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos:\n" + ex.Message);
                }
            }
        }
        #endregion
        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.equipo_2Final_6DataSet);

        }

        private void usuariosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.equipo_2Final_6DataSet);

        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'equipo_2Final_6DataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.equipo_2Final_6DataSet.Usuarios);
            this.KeyPreview = true;
            this.AcceptButton = button1;
            ConfigurarLabels();

            // Configurar cada botón
            ConfigurarBotonModerno(button1, "ENTRAR");
            ConfigurarBotonModerno(buttonExit, "SALIR");
            usuarioTextBox.ScrollBars = ScrollBars.None;
            passTextBox.ScrollBars = ScrollBars.None;
        }

        
        private void ConfigurarLabels()
        {
            // Fuente y colores
            Bienvenida.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            usuario.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            passLabel.Font = new Font("Segoe UI", 18, FontStyle.Bold);

            Color fondoAzul = Color.FromArgb(45, 130, 220);

            // Fondo y color principal
            Bienvenida.BackColor = fondoAzul;
            usuario.BackColor = fondoAzul;
            passLabel.BackColor = fondoAzul;

            // Asignar el evento Paint a los tres labels
            Bienvenida.Paint -= LabelConSombra_Paint;
            usuario.Paint -= LabelConSombra_Paint;
            passLabel.Paint -= LabelConSombra_Paint;

            Bienvenida.Paint += LabelConSombra_Paint;
            usuario.Paint += LabelConSombra_Paint;
            passLabel.Paint += LabelConSombra_Paint;
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
            btn.Size = new Size(150, 80);

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
        
        private void passLabel_Click(object sender, EventArgs e)
        {

        }

        private void Bienvenida_Click(object sender, EventArgs e)
        {
        }

        private void ConfirmarSalida()
        {
            DialogResult decision = MessageBox.Show("¿Estás seguro de que quieres salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (decision == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            ConfirmarSalida();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Escape)
                {
                    ConfirmarSalida();
                }
            }
        }

        private void Bienvenida_Click_1(object sender, EventArgs e)
        {

        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
            passTextBox.UseSystemPasswordChar = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Acerca_de acercade = new Acerca_de();
            this.Hide();
            acercade.ShowDialog();
            this.Show();
        }
    }
}

        
