using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas_Profesionalizantes_II___APAPED
{
    public partial class Login : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Usuario\Desktop\Practicas Profesionalizantes II - APAPED\Equipo_2Final.accdb";

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtPass.Text.Trim();

            if (string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("Por favor, escriba su Usuario", "Usuario requerido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, ingrese correctamente su Contraseña", "Contraseña requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPass.Focus();
                return;
            }

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT Nivel_Seguridad FROM Usuarios WHERE Usuario = ? AND Pass = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", usuario);
                        cmd.Parameters.AddWithValue("?", contraseña);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            int nivel = Convert.ToInt32(result);
                            MessageBox.Show($"¡Bienvenido! Nivel de seguridad: {nivel}", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form1 menuprincipal = new Form1();
                            this.Hide();
                            menuprincipal.ShowDialog();
                            this.Close();
                            // Aquí puedes abrir otro formulario
                            // Por ejemplo: new MenuPrincipal().Show(); this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario y/o Contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }
    }
}
