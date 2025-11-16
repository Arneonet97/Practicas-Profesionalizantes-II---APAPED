using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas_Profesionalizantes_II___APAPED
{
    public partial class Nuevo_Tutor : Form
    {
        public Nuevo_Tutor()
        {
            InitializeComponent();
        }

        private void tutorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tutorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.equipo_2Final_6DataSet);
            

        }
        private void nivel_de_educación_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargandoCombo)
                return; // 🔹 Ignorar mientras se carga o cambia desde código
        }

        private bool cargandoCombo = false;
        private void CargarNivelEducacion()
        {
            cargandoCombo = true; // 🔹 Bloquea eventos

            nivel_de_educación.Items.Clear();
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Equipo_2Final_6.accdb";

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(connectionString))
                {
                    conexion.Open();

                    string consulta = "SELECT DISTINCT [Nivel de educación] FROM Tutor WHERE [Nivel de educación] IS NOT NULL";
                    OleDbCommand comando = new OleDbCommand(consulta, conexion);
                    OleDbDataReader lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        string nivel = lector["Nivel de educación"].ToString().Trim();
                        if (!string.IsNullOrEmpty(nivel))
                            nivel_de_educación.Items.Add(nivel);
                    }

                    lector.Close();
                }

                string[] nivelesCompletos = { "Primario", "Secundario", "Terciario", "Universitario", "Otro" };
                foreach (var nivel in nivelesCompletos)
                {
                    if (!nivel_de_educación.Items.Contains(nivel))
                        nivel_de_educación.Items.Add(nivel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar niveles de educación: " + ex.Message);
            }
            finally
            {
                cargandoCombo = false; // 🔹 Desbloquea
            }

            if (nivel_de_educación.Items.Count > 0)
                nivel_de_educación.SelectedIndex = -1;
        }

        private void Nuevo_Tutor_Load(object sender, EventArgs e)
        {
            nivel_de_educación.Enabled = false;

            // TODO: esta línea de código carga datos en la tabla 'equipo_2Final_6DataSet1.Tutor' Puede moverla o quitarla según sea necesario.
            this.tutorTableAdapter.Fill(this.equipo_2Final_6DataSet.Tutor);

            CargarNivelEducacion(); 

            // Asignar el valor del primer registro al ComboBox
            AsignarNivelPrimerRegistro();

            CambiarEstadoTextBoxes(false);

            // Configurar cada botón
            ConfigurarBotonModerno(BotonNuevoRegistro, "NUEVO REGISTRO");
            ConfigurarBotonModerno(BotonCancelar, "CANCELAR");
            ConfigurarBotonModerno(BotonModificarRegistro, "MODIFICAR REGISTRO");
            ConfigurarBotonModerno(BotonGuardarRegistro, "GUARDAR REGISTRO");
            ConfigurarBotonModerno(BotonEliminarRegistro, "ELIMINAR REGISTRO");
            ConfigurarBotonModerno(buttonbuscar, "BUSCAR");
            ConfigurarBotonModerno(btnmostrar, "MOSTRAR");
            ConfigurarBotonModerno(BotonInsertarRegistro, "INSERTAR");

            ConfigurarLabels();
            BotonGuardarRegistro.Enabled = false;
            BotonEliminarRegistro.Enabled = false;
            BotonInsertarRegistro.Enabled = false;
            BotonCancelar.Enabled = false;
            panelFiltrar.Visible = false;
            adopcionCheckBox.Enabled = false;
            _Asiste_a_la_escuela_CheckBox.Enabled = false;
        }
        private void ConfigurarLabels()
        {
            // Fuente y colores
            label1.Font = new Font("Segoe UI", 40, FontStyle.Bold);
            label3.Font = new Font("Segoe UI", 40, FontStyle.Bold);
            label2.Font = new Font("Segoe UI", 25, FontStyle.Bold);
            label4.Font = new Font("Segoe UI", 25, FontStyle.Bold);

            Color fondoAzul = Color.FromArgb(45, 130, 220);

            // Fondo y color principal
            label1.BackColor = fondoAzul;
            label3.BackColor = fondoAzul;

            // Asignar el evento Paint a los tres labels
            label1.Paint -= LabelConSombra_Paint;
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
        private void AsignarNivelPrimerRegistro()
        {
            if (tutorBindingSource.Count > 0)
            {
                var primerRegistro = tutorBindingSource[0] as DataRowView;

                if (primerRegistro != null)
                {
                    string nivel = primerRegistro["Nivel de educación"] != DBNull.Value
                        ? primerRegistro["Nivel de educación"].ToString()
                        : null;

                    if (!string.IsNullOrEmpty(nivel) && nivel_de_educación.Items.Contains(nivel))
                        nivel_de_educación.SelectedItem = nivel;
                    else
                        nivel_de_educación.SelectedIndex = -1; // No seleccionar nada si no hay valor
                }
            }
        }
        private void _Asiste_a_la_escuela_CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void CargarDatosDeTutorActual()
        {
            var tutorActual = tutorBindingSource.Current as DataRowView;

            if (tutorActual != null)
            {
                nombreTextBox.Text = tutorActual["Nombre"] != DBNull.Value ? tutorActual["Nombre"].ToString() : "";
                apellidoTextBox.Text = tutorActual["Apellido"] != DBNull.Value ? tutorActual["Apellido"].ToString() : "";
                documentoTextBox.Text = tutorActual["Documento"] != DBNull.Value ? tutorActual["Documento"].ToString() : "";
                parentescoTextBox.Text = tutorActual["Parentesco"] != DBNull.Value ? tutorActual["Parentesco"].ToString() : "";
                edadTextBox.Text = tutorActual["Edad"] != DBNull.Value ? tutorActual["Edad"].ToString() : "";
                ocupaciónTextBox.Text = tutorActual["Ocupación"] != DBNull.Value ? tutorActual["Ocupación"].ToString() : "";
                ingresosTextBox.Text = tutorActual["Ingresos"] != DBNull.Value ? tutorActual["Ingresos"].ToString() : "";

                _Asiste_a_la_escuela_CheckBox.Checked = tutorActual["Asiste a la escuela"] != DBNull.Value
                    && Convert.ToBoolean(tutorActual["Asiste a la escuela"]);
                adopcionCheckBox.Checked = tutorActual["Adopcion"] != DBNull.Value
                    && Convert.ToBoolean(tutorActual["Adopcion"]);

                institución_a_la_que_asisteTextBox.Text = tutorActual["Institución a la que asiste"] != DBNull.Value
                    ? tutorActual["Institución a la que asiste"].ToString()
                    : "";

                // Nivel de educación: asignar SelectedItem si existe
                string nivel = tutorActual["Nivel de educación"] != DBNull.Value
                    ? tutorActual["Nivel de educación"].ToString()
                    : null;

                if (!string.IsNullOrEmpty(nivel) && nivel_de_educación.Items.Contains(nivel))
                    nivel_de_educación.SelectedItem = nivel;
                else
                    nivel_de_educación.SelectedIndex = 0; // valor por defecto

                id_TutorTextBox.Text = tutorActual["Id Tutor"] != DBNull.Value ? tutorActual["Id Tutor"].ToString() : "";
            }
            else
            {
                LimpiarTextBoxes(this);
                _Asiste_a_la_escuela_CheckBox.Checked = false;
                adopcionCheckBox.Checked = false;
                nivel_de_educación.SelectedIndex = 0;
            }
        }

        private void BotonTutorSiguiente_Click(object sender, EventArgs e)
        {
            if (tutorBindingSource.Position < tutorBindingSource.Count - 1)
                tutorBindingSource.MoveNext();

            CargarDatosDeTutorActual();
        }

        private void BotonTutorAnterior_Click(object sender, EventArgs e)
        {
            if (tutorBindingSource.Position > 0)
                tutorBindingSource.MovePrevious();

            CargarDatosDeTutorActual();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    printDocument1.Print();
                }
                catch (Exception ex)
                {
                    MostrarError("Error: " + ex.Message + ". Cierre el archivo para poder reemplazarlo.");
                }
            }
        }
        private void MostrarError(string mensaje)
        {
            // Forzamos que la ventana principal vuelva al frente antes del diálogo
            SetForegroundWindow(this.Handle);

            Form errorForm = new Form();
            errorForm.Text = "Error de impresión";
            errorForm.StartPosition = FormStartPosition.CenterParent;
            errorForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            errorForm.MaximizeBox = false;
            errorForm.MinimizeBox = false;
            errorForm.ShowInTaskbar = true;
            errorForm.Icon = this.Icon; // Usa el ícono de tu app
            errorForm.ClientSize = new Size(420, 180);
            errorForm.TopMost = true; // 🔹 Siempre visible

            // --- Contenido ---
            // Ícono de error
            PictureBox iconBox = new PictureBox();
            iconBox.Image = SystemIcons.Error.ToBitmap();
            iconBox.SizeMode = PictureBoxSizeMode.CenterImage;
            iconBox.Size = new Size(64, 64);
            iconBox.Location = new Point(25, 50);

            // Texto del error
            System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
            lbl.Text = mensaje;
            lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lbl.ForeColor = Color.FromArgb(32, 32, 32);
            lbl.AutoSize = false;
            lbl.Size = new Size(300, 80);
            lbl.Location = new Point(100, 45);
            lbl.TextAlign = ContentAlignment.MiddleLeft;

            // Botón Aceptar
            Button btn = new Button();
            btn.Text = "Aceptar";
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            btn.Size = new Size(100, 35);
            btn.Location = new Point((errorForm.ClientSize.Width - btn.Width) / 2, 130);
            btn.BackColor = Color.FromArgb(230, 230, 230);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.DialogResult = DialogResult.OK;
            btn.Cursor = Cursors.Hand;

            // Bordes redondeados (opcional, estilo Win11)
            btn.Region = new Region(new System.Drawing.Drawing2D.GraphicsPath());
            btn.Region.MakeEmpty();
            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radius = 8;
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();
                btn.Region = new Region(path);
            }

            // Ensamblamos el formulario
            errorForm.Controls.Add(iconBox);
            errorForm.Controls.Add(lbl);
            errorForm.Controls.Add(btn);
            errorForm.AcceptButton = btn;

            // Mostramos modal
            errorForm.ShowDialog(this);

            // Restaura estado normal
            errorForm.TopMost = false;
            this.Activate();
        }

        // Import de Windows API
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            int marginLeft = 80;   // Columna única
            int marginTop = 100;
            int spacing = 35;
            int labelWidth = 150;
            int valueWidth = 400;   // Ancho máximo de cada valor
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font labelFont = new Font("Arial", 11, FontStyle.Bold);
            Font valueFont = new Font("Arial", 11);
            Brush brush = Brushes.Black;

            try
            {
                // Título
                g.DrawString("Ficha de Registro de Tutor", titleFont, brush, marginLeft, marginTop);
                marginTop += 50;

                var campos = new KeyValuePair<string, string>[]
                {
            new KeyValuePair<string, string>("Nombre:", nombreTextBox.Text),
            new KeyValuePair<string, string>("Apellido:", apellidoTextBox.Text),
            new KeyValuePair<string, string>("Documento:", documentoTextBox.Text),
            new KeyValuePair<string, string>("Parentesco:", parentescoTextBox.Text),
            new KeyValuePair<string, string>("Adopción:", adopcionCheckBox.Checked ? "Sí" : "No"),
            new KeyValuePair<string, string>("Edad:", edadTextBox.Text),
            new KeyValuePair<string, string>("Nivel de Educación:", nivel_de_educación.Text),
            new KeyValuePair<string, string>("Ocupación:", ocupaciónTextBox.Text),
            new KeyValuePair<string, string>("Ingresos:", ingresosTextBox.Text),
            new KeyValuePair<string, string>("Asiste a la escuela:", _Asiste_a_la_escuela_CheckBox.Checked ? "Sí" : "No"),
            new KeyValuePair<string, string>("Institución:", institución_a_la_que_asisteTextBox.Text)
                };

                foreach (var campo in campos)
                {
                    // Dibujar label + valor con "..."
                    DrawFieldWithEllipsis(g, campo.Key, campo.Value, marginLeft, marginTop, labelWidth, valueWidth, labelFont, valueFont, brush);

                    // Línea debajo del valor
                    g.DrawLine(Pens.Black, marginLeft, marginTop + spacing - 5, marginLeft + labelWidth + valueWidth, marginTop + spacing - 5);

                    // Avanzar al siguiente campo
                    marginTop += spacing;
                }

                // Pie de página
                g.DrawString($"Fecha de impresión: {DateTime.Now:dd/MM/yyyy}",
                    new Font("Arial", 9, FontStyle.Italic), Brushes.Gray, marginLeft, e.MarginBounds.Bottom - 40);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al imprimir: " + ex.Message);
            }
        }

        // Función reutilizable para recortar texto y agregar "..."
        private void DrawFieldWithEllipsis(Graphics g, string label, string valor, int x, int y, int labelWidth, int valueMaxWidth, Font labelFont, Font valueFont, Brush brush)
        {
            // Dibujar label
            g.DrawString(label, labelFont, brush, x, y);

            // Posición del valor
            int valueX = x + labelWidth;

            // Preparar texto
            string textoFinal = valor ?? "";
            int margenSeguridadPx = 10;

            SizeF size = g.MeasureString(textoFinal, valueFont);
            if (size.Width > valueMaxWidth - margenSeguridadPx)
            {
                while (textoFinal.Length > 0 && g.MeasureString(textoFinal + "...", valueFont).Width > valueMaxWidth - margenSeguridadPx)
                {
                    textoFinal = textoFinal.Substring(0, textoFinal.Length - 1);
                }
                textoFinal += "...";
            }

            // Dibujar valor
            g.DrawString(textoFinal, valueFont, brush, valueX, y);
        }

        private void BotonNuevoRegistro_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("¿Agregar nuevo registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (decision == DialogResult.Yes)
            {
                // Crear nuevo registro sin volver a llenar la tabla
                tutorBindingSource.AddNew();

                CambiarEstadoTextBoxes(true);
                BotonCancelar.Enabled = true;
                BotonInsertarRegistro.Enabled = true;
                BotonPersonaAnterior.Enabled = false;
                BotonPersonaSiguiente.Enabled = false;
                BotonModificarRegistro.Enabled = false;
                btnBuscar.Enabled = false;
                button1.Enabled = true;
                BotonNuevoRegistro.Enabled = false;
                printbutton.Enabled = false;
                adopcionCheckBox.Enabled = true;
                _Asiste_a_la_escuela_CheckBox.Enabled = true;
                nivel_de_educación.Enabled = true;

                // Evitar que se reasigne el SelectedItem automáticamente
                nivel_de_educación.SelectedIndex = -1;

                // 🔹 Asegurar que los CheckBox no aparezcan indeterminados
                adopcionCheckBox.ThreeState = false;
                _Asiste_a_la_escuela_CheckBox.ThreeState = false;
                adopcionCheckBox.CheckState = CheckState.Unchecked; // o CheckState.Checked si querés que arranquen marcados
                _Asiste_a_la_escuela_CheckBox.CheckState = CheckState.Unchecked;
            }
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
        private void CambiarEstadoTextBoxes(bool estado)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = estado;
                }
            }
        }
        private void BotonModificarRegistro_Click(object sender, EventArgs e)
        {
            BotonNuevoRegistro.Enabled = false;
            BotonInsertarRegistro.Enabled = false;
            BotonGuardarRegistro.Enabled = true;
            BotonEliminarRegistro.Enabled = true;
            BotonCancelar.Enabled = true;
            CambiarEstadoTextBoxes(true);
            btnBuscar.Enabled = false;
            BotonModificarRegistro.Enabled = false;
            button1.Enabled = true;
            BotonPersonaAnterior.Enabled = false;
            BotonPersonaSiguiente.Enabled = false;
            adopcionCheckBox.Enabled = true;
            _Asiste_a_la_escuela_CheckBox.Enabled = true;
            nivel_de_educación.Enabled = true;
            printbutton.Enabled = false;

        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            CambiarEstadoTextBoxes(false);
            BotonPersonaAnterior.Enabled = true;
            BotonPersonaSiguiente.Enabled = true;
            tutorBindingSource.CancelEdit(); // Cancela el nuevo registro
            tutorBindingSource.ResetBindings(false); // Refresca los datos
            nivel_de_educación.Enabled = false;
            adopcionCheckBox.Enabled = false;
            _Asiste_a_la_escuela_CheckBox.Enabled = false;
            BotonModificarRegistro.Enabled = true;
            BotonNuevoRegistro.Enabled = true;
            BotonCancelar.Enabled = false;
            BotonInsertarRegistro.Enabled = false;
            BotonEliminarRegistro.Enabled = false;
            BotonGuardarRegistro.Enabled = false;
            btnBuscar.Enabled = true;
            printbutton.Enabled = true;

        }
        private void tutorBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tutorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.equipo_2Final_6DataSet);

        }

        private void tutorBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.tutorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.equipo_2Final_6DataSet);

        }

        private void tutorBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.tutorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.equipo_2Final_6DataSet);

        }

        private void tutorBindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
        {
            this.Validate();
            this.tutorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.equipo_2Final_6DataSet);

        }

        private void BotonGuardarRegistro_Click(object sender, EventArgs e)
        {
            string nivel = nivel_de_educación.SelectedItem?.ToString();

            try
            {
                // Intentar insertar el registro
                this.tutorTableAdapter.ConsultaActualizarTutor(
                   nombreTextBox.Text,
                    apellidoTextBox.Text,
                    documentoTextBox.Text,
                    parentescoTextBox.Text,
                    adopcionCheckBox.Checked,
                    int.Parse(edadTextBox.Text),
                    ocupaciónTextBox.Text,
                    ingresosTextBox.Text,
                    _Asiste_a_la_escuela_CheckBox.Checked,
                    institución_a_la_que_asisteTextBox.Text,
                    nivel ?? "",
                    int.Parse(id_TutorTextBox.Text)
                    );

                MessageBox.Show("El registro fue Editado correctamente.");
            }
            catch (Exception ex)
            {
                // Si ocurre un error, mostrar el mensaje de error
                MessageBox.Show("Error: " + ex.Message);
            }

            nivel_de_educación.Enabled = false;
            adopcionCheckBox.Enabled = false;
            _Asiste_a_la_escuela_CheckBox.Enabled = false;
            BotonPersonaAnterior.Enabled = true;
            BotonPersonaSiguiente.Enabled = true;
            CambiarEstadoTextBoxes(false);
            BotonModificarRegistro.Enabled = true;
            BotonNuevoRegistro.Enabled = true;
            BotonCancelar.Enabled = false;
            BotonInsertarRegistro.Enabled = false;
            BotonEliminarRegistro.Enabled = false;
            BotonGuardarRegistro.Enabled = false;
            btnBuscar.Enabled = true;
            printbutton.Enabled = true;

            // 🔹 Refrescar los datos en memoria
            this.tutorTableAdapter.Fill(this.equipo_2Final_6DataSet.Tutor);

            // 🔹 Volver a posicionarse en el mismo registro editado
            tutorBindingSource.Position = tutorBindingSource.Find("Id Tutor", int.Parse(id_TutorTextBox.Text));

        }

        private void BotonEliminarRegistro_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("¿Desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (decision == DialogResult.Yes)
            {
                try
                {
                    this.tutorTableAdapter.ConsultaEliminarTutor(
                       Convert.ToInt32(id_TutorTextBox.Text));

                    // Si no hay errores, mostrar mensaje de éxito
                    MessageBox.Show("El registro fue Eliminado correctamente.");
                    LimpiarTextBoxes(this);

                    this.tutorTableAdapter.Fill(this.equipo_2Final_6DataSet.Tutor);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            nivel_de_educación.Enabled = false;
            adopcionCheckBox.Enabled = false;
            _Asiste_a_la_escuela_CheckBox.Enabled = false;
            CambiarEstadoTextBoxes(false);
            BotonModificarRegistro.Enabled = true;
            BotonNuevoRegistro.Enabled = true;
            BotonCancelar.Enabled = false;
            BotonInsertarRegistro.Enabled = false;
            BotonEliminarRegistro.Enabled = false;
            BotonGuardarRegistro.Enabled = false;
            BotonPersonaAnterior.Enabled = true;
            BotonPersonaSiguiente.Enabled = true;
            btnBuscar.Enabled = true;
            printbutton.Enabled = true;

        }
        
        private void BotonInsertarRegistro_Click(object sender, EventArgs e)
        {
            string nivel = nivel_de_educación.SelectedItem?.ToString();
            //Permitir valor vacio 
            int edadFinal = 0;
            if (int.TryParse(edadTextBox.Text, out int valorEdad))
                edadFinal = valorEdad;

            try
            {
                this.tutorTableAdapter.ConsultaInsertarTutor(
                    nombreTextBox.Text,
                    apellidoTextBox.Text,
                    documentoTextBox.Text,
                    parentescoTextBox.Text,
                    adopcionCheckBox.Checked,
                    edadFinal,  // 👈 siempre entero
                    ocupaciónTextBox.Text,
                    ingresosTextBox.Text,
                    _Asiste_a_la_escuela_CheckBox.Checked,
                    institución_a_la_que_asisteTextBox.Text,
                    nivel ?? ""
                    );

                // Si no hay errores, mostrar mensaje de éxito
                MessageBox.Show("El registro fue agregado correctamente.");
                LimpiarTextBoxes(this);
            }
            catch (Exception ex)
            {
                // Si ocurre un error, mostrar el mensaje de error
                MessageBox.Show("Error: " + ex.Message);
            }

            nivel_de_educación.Enabled = false;
            adopcionCheckBox.Enabled = false;
            _Asiste_a_la_escuela_CheckBox.Enabled = false;
            CambiarEstadoTextBoxes(false);
            BotonModificarRegistro.Enabled = true;
            BotonNuevoRegistro.Enabled = true;
            BotonCancelar.Enabled = false;
            BotonInsertarRegistro.Enabled = false;
            BotonEliminarRegistro.Enabled = false;
            BotonGuardarRegistro.Enabled = false;
            BotonPersonaAnterior.Enabled = true;
            btnBuscar.Enabled = true;
            BotonPersonaSiguiente.Enabled = true;
            printbutton.Enabled = true;
            this.tutorTableAdapter.Fill(this.equipo_2Final_6DataSet.Tutor);

        }

        private void tutorBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //No toques nada acá.
        }

        private void MostrarControlesdeBusqueda()
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            panelFiltrar.Visible = true;
            BotonPersonaAnterior.Enabled = false;
            BotonPersonaSiguiente.Enabled = false;
            BotonNuevoRegistro.Enabled = false;
        }

        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string busqueda = "%" + txtBuscar.Text.Trim() + "%"; // Usamos % en lugar de *

                using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Equipo_2Final_6.accdb"))
                {
                    conn.Open();

                    string sql = @"
    SELECT [Id Tutor], [Nombre] & ' ' & [Apellido] AS NombreCompleto
    FROM Tutor
    WHERE [Nombre] LIKE ? OR [Apellido] LIKE ? OR [Documento] LIKE ?";

                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        // Pasar comodines dentro del parámetro
                        cmd.Parameters.AddWithValue("?", "%" + busqueda + "%");
                        cmd.Parameters.AddWithValue("?", "%" + busqueda + "%");
                        cmd.Parameters.AddWithValue("?", "%" + busqueda + "%");


                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            DataTable resultados = new DataTable();
                            adapter.Fill(resultados);

                            if (resultados.Rows.Count == 0)
                            {
                                MessageBox.Show("No se encontraron registros con ese valor.");
                                return;
                            }

                            comboFiltrar.DataSource = resultados;
                            comboFiltrar.DisplayMember = "NombreCompleto";
                            comboFiltrar.ValueMember = "Id Tutor";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {

            panelFiltrar.Visible = false;

            if (comboFiltrar.SelectedValue == null)
            {
                MessageBox.Show("No se ha seleccionado ningún tutor.");
                return;
            }

            try
            {
                int idTutor = Convert.ToInt32(comboFiltrar.SelectedValue);

                using (OleDbConnection conn = new OleDbConnection(
                    @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Equipo_2Final_6.accdb"))
                {
                    conn.Open();

                    string sql = @"
                SELECT *
                FROM Tutor
                WHERE [Id Tutor] = ?";

                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("?", idTutor);

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("No se encontraron datos para este tutor.");
                                return;
                            }

                            DataRow fila = dt.Rows[0];

                            // Asignar valores a los TextBoxes y CheckBoxes
                            id_TutorTextBox.Text = fila["Id Tutor"].ToString();
                            nombreTextBox.Text = fila["Nombre"].ToString();
                            apellidoTextBox.Text = fila["Apellido"].ToString();
                            documentoTextBox.Text = fila["Documento"].ToString();
                            parentescoTextBox.Text = fila["Parentesco"].ToString();
                            adopcionCheckBox.Checked = fila["Adopcion"] != DBNull.Value && Convert.ToBoolean(fila["Adopcion"]);
                            edadTextBox.Text = fila["Edad"].ToString();
                            ocupaciónTextBox.Text = fila["Ocupación"].ToString();
                            ingresosTextBox.Text = fila["Ingresos"].ToString();
                            _Asiste_a_la_escuela_CheckBox.Checked = fila["¿Asiste a la escuela?"] != DBNull.Value
                                && Convert.ToBoolean(fila["¿Asiste a la escuela?"]);
                            institución_a_la_que_asisteTextBox.Text = fila["Institución a la que asiste"].ToString();

                            // ✅ Nivel de educación en ComboBox
                            string nivel = fila["Nivel de educación"] != DBNull.Value
                                ? fila["Nivel de educación"].ToString().Trim()
                                : string.Empty;

                            if (!string.IsNullOrEmpty(nivel))
                            {
                                // Buscar coincidencia sin importar mayúsculas/minúsculas
                                foreach (var item in nivel_de_educación.Items)
                                {
                                    if (string.Equals(item.ToString(), nivel, StringComparison.OrdinalIgnoreCase))
                                    {
                                        nivel_de_educación.SelectedItem = item;
                                        return;
                                    }
                                }
                                // Si no hay coincidencia exacta, dejar sin selección
                                nivel_de_educación.SelectedIndex = -1;
                            }
                            else
                            {
                                nivel_de_educación.SelectedIndex = -1;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los datos: " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
             panelFiltrar.Visible = false;
            BotonNuevoRegistro.Visible = true;
            BotonPersonaAnterior.Enabled = true;
            BotonPersonaSiguiente.Enabled = true;
        }

        private void edadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir números y tecla de borrado
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void panelFiltrar_Paint(object sender, PaintEventArgs e)
        {
            int borderThickness = 8;
            Color borderColor = Color.Black;

            using (Pen pen = new Pen(borderColor, borderThickness))
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.DrawRectangle(pen,
                    new Rectangle(
                        borderThickness / 2,
                        borderThickness / 2,
                        panelFiltrar.Width - borderThickness,
                        panelFiltrar.Height - borderThickness));
            }
        }
    }
}

