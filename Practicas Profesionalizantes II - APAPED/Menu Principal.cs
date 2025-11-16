using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Practicas_Profesionalizantes_II___APAPED
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void BotonPersonas_Click(object sender, EventArgs e)
        {
            Menu_Personas menuPersonas = new Menu_Personas(this);
            this.Hide();
            menuPersonas.ShowDialog();
            this.Show();
        }

        private void MenuGrupos_Click(object sender, EventArgs e)
        {
            Menu_Grupos menuGrupos = new Menu_Grupos(this);
            this.Hide();
            menuGrupos.ShowDialog();
            this.Show();
        }

        private void MenuTutores_Click(object sender, EventArgs e)
        {
            Menu_Tutores menuTutores = new Menu_Tutores(this);
            this.Hide();
            menuTutores.ShowDialog();
            this.Show();
        }

        private string nombreUsuario;
        public Menu_Principal(string usuario)
        {
            InitializeComponent();
            nombreUsuario = usuario;
        }
        private void return_menu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HASTA LUEGO " + nombreUsuario);
            RealizarBackupProyecto();
            Application.Exit();
        }
        #region Backup Automático

        private void RealizarBackupProyecto()
        {
            try
            {
                // Ruta dinámica al ejecutable
                string basePath = Application.StartupPath;

                // Archivo origen
                string archivoOrigen = Path.Combine(basePath, "Equipo_2Final_6.accdb");

                // Carpeta destino en Documentos
                string rutaDestinoBase = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "BackupsProyecto");

                // Crear carpeta si no existe
                Directory.CreateDirectory(rutaDestinoBase);

                // Siempre mismo nombre (se sobrescribe)
                string nombreArchivo = Path.GetFileNameWithoutExtension(archivoOrigen);
                string extension = Path.GetExtension(archivoOrigen);
                string nombreBackup = $"{nombreArchivo}_Backup{extension}";

                string destinoFinal = Path.Combine(rutaDestinoBase, nombreBackup);

                // Copiar y sobrescribir
                File.Copy(archivoOrigen, destinoFinal, true);

                MessageBox.Show($"✅ Backup actualizado en:\n{destinoFinal}",
                                "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠️ Error al realizar backup del archivo:\n" + ex.Message,
                                "Backup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CopiarDirectorio(string origen, string destino)
        {
            Directory.CreateDirectory(destino);

            foreach (string archivo in Directory.GetFiles(origen))
            {
                string nombreArchivo = Path.GetFileName(archivo);
                string destinoArchivo = Path.Combine(destino, nombreArchivo);
                File.Copy(archivo, destinoArchivo, true);
            }

            foreach (string carpeta in Directory.GetDirectories(origen))
            {
                string nombreCarpeta = Path.GetFileName(carpeta);
                string destinoCarpeta = Path.Combine(destino, nombreCarpeta);
                CopiarDirectorio(carpeta, destinoCarpeta);
            }
        }

        private void LimpiarBackupsAntiguos(string rutaDestinoBase)
        {
            try
            {
                if (!Directory.Exists(rutaDestinoBase))
                    return;

                string[] carpetas = Directory.GetDirectories(rutaDestinoBase, "Backup_*");

                if (carpetas.Length > 0)
                {
                    Array.Sort(carpetas);
                    for (int i = 0; i < carpetas.Length - 1; i++)
                    {
                        Directory.Delete(carpetas[i], true);
                        Console.WriteLine($"🗑️ Backup antiguo eliminado: {carpetas[i]}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("⚠️ Error al eliminar backups antiguos: " + ex.Message);
            }
        }
        #endregion
        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            // Cambiar color de fondo del formulario
            this.BackColor = Color.FromArgb(240, 240, 240);

            // Configurar cada botón
            ConfigurarBotonModerno(BotonPersonas, "PERSONAS");
            ConfigurarBotonModerno(BotonGrupos, "GRUPOS");
            ConfigurarBotonModerno(BotonTutores, "TUTORES");
            ConfigurarBotonModerno(return_menu, "SALIR");
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Acerca_de acercade = new Acerca_de();
            this.Hide();
            acercade.ShowDialog();
            this.Show();
        }
    }
}
