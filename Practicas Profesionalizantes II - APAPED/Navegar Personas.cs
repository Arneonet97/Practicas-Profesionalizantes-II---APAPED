using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas_Profesionalizantes_II___APAPED
{
    public partial class Navegar_Personas : Form
    {

        public Navegar_Personas()
        {
            InitializeComponent();
            
        }


        private void personas_con_discapacidadBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personas_con_discapacidadBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.equipo_2Final_6DataSet);
        }

        private void Navegar_Personas_Load(object sender, EventArgs e)
        {
            BotonGuardarRegistro.Enabled = false;
            BotonEliminarRegistro.Enabled = false; 
            BotonCancelar.Enabled = false; 
            BotonInsertarRegistro.Enabled = false;
            cUD_vencidoCheckBox.Enabled = false;
            button1.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;


            ConfigurarLabels();

            // Cargar tabla Personas
            this.personas_con_discapacidadTableAdapter.Fill(this.equipo_2Final_6DataSet.Personas_con_discapacidad);

            // Cargar ComboBox de tutores
            CargarTutoresEnComboBox();

            // Inicializar ComboBoxFiltrar
            InicializarComboFiltrar();

            // Cambiar estado inicial de los TextBoxes y botones
            CambiarEstadoTextBoxes(false);
            panelFiltrar.Visible = false;

            // Configurar cada botón
            ConfigurarBotonModerno(BotonNuevoRegistro, "NUEVO REGISTRO");
            ConfigurarBotonModerno(BotonCancelar, "CANCELAR");
            ConfigurarBotonModerno(BotonModificarRegistro, "MODIFICAR REGISTRO");
            ConfigurarBotonModerno(BotonGuardarRegistro, "GUARDAR REGISTRO");
            ConfigurarBotonModerno(BotonEliminarRegistro, "ELIMINAR REGISTRO");
            ConfigurarBotonModerno(buttonbuscar, "BUSCAR");
            ConfigurarBotonModerno(btnmostrar, "MOSTRAR");
            ConfigurarBotonModerno(BotonInsertarRegistro, "INSERTAR");



        }

        private void ConfigurarLabels()
        {
            // Fuente y colores
            label1.Font = new Font("Segoe UI", 40, FontStyle.Bold);
            label5.Font = new Font("Segoe UI", 40, FontStyle.Bold);
            label6.Font = new Font("Segoe UI", 25, FontStyle.Bold);
            label4.Font = new Font("Segoe UI", 25, FontStyle.Bold);

            Color fondoAzul = Color.FromArgb(45, 130, 220);

            // Fondo y color principal
            label1.BackColor = fondoAzul;
            label5.BackColor = fondoAzul;

            // Asignar el evento Paint a los tres labels
            label1.Paint -= LabelConSombra_Paint;
            //label5.Paint -= LabelConSombra_Paint;

            label1.Paint += LabelConSombra_Paint;
            //label5.Paint += LabelConSombra_Paint;
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

            #region ComboBox Filtrar
            private void InicializarComboFiltrar()
        {
            if (this.equipo_2Final_6DataSet.Personas_con_discapacidad.Rows.Count == 0)
            {
                comboFiltrar.DataSource = null;
                comboFiltrar.Items.Clear();
                return;
            }

            // Crear DataTable con Id y NombreCompleto
            DataTable dt = new DataTable();
            dt.Columns.Add("Id Persona", typeof(int));
            dt.Columns.Add("NombreCompleto", typeof(string));

            foreach (DataRow r in this.equipo_2Final_6DataSet.Personas_con_discapacidad.Rows)
            {
                int id = r["Id Persona"] != DBNull.Value ? Convert.ToInt32(r["Id Persona"]) : -1;
                string nombre = r["Nombre"] != DBNull.Value ? r["Nombre"].ToString().Trim() : "";
                string apellido = r["Apellido"] != DBNull.Value ? r["Apellido"].ToString().Trim() : "";
                dt.Rows.Add(id, (nombre + " " + apellido).Trim());
            }

            comboFiltrar.DisplayMember = "NombreCompleto";
            comboFiltrar.ValueMember = "Id Persona";
            comboFiltrar.DataSource = dt;

            if (comboFiltrar.Items.Count > 0)
            {
                comboFiltrar.SelectedIndex = 0;
                CargarDatosDePersonaActual();
            }
        }

        #endregion

        #region Cargar Datos
        private void CargarDatosDePersonaActual()
        {
            if (comboFiltrar.SelectedValue == null)
                return;

            int idPersona;
            if (!int.TryParse(comboFiltrar.SelectedValue.ToString(), out idPersona))
                return;

            DataRow[] filas = this.equipo_2Final_6DataSet.Personas_con_discapacidad.Select($"[Id Persona] = {idPersona}");
            if (filas.Length > 0)
                CargarDatosPersonaDesdeDataRow(filas[0]);
        }

        private void CargarDatosPersonaDesdeDataRow(DataRow fila)
        {
            id_PersonaTextBox.Text = fila["Id Persona"] != DBNull.Value ? fila["Id Persona"].ToString() : "";
            nombreTextBox.Text = fila["Nombre"] != DBNull.Value ? fila["Nombre"].ToString() : "";
            apellidoTextBox.Text = fila["Apellido"] != DBNull.Value ? fila["Apellido"].ToString() : "";
            direcciónTextBox.Text = fila["Dirección"] != DBNull.Value ? fila["Dirección"].ToString() : "";
            discapacidadTextBox.Text = fila["Discapacidad"] != DBNull.Value ? fila["Discapacidad"].ToString() : "";
            teléfonoTextBox.Text = fila["Teléfono"] != DBNull.Value ? fila["Teléfono"].ToString() : "";
            teléfono_N_2TextBox.Text = fila["Teléfono N°2"] != DBNull.Value ? fila["Teléfono N°2"].ToString() : "";
            cUD_vencidoCheckBox.Checked = fila["CUD vencido"] != DBNull.Value && Convert.ToBoolean(fila["CUD vencido"]);
            vencimiento_de_CUDDateTimePicker.Value = fila["Vencimiento de CUD"] != DBNull.Value
                ? Convert.ToDateTime(fila["Vencimiento de CUD"])
                : DateTime.Today;
            localidadTextBox.Text = fila["Localidad"] != DBNull.Value ? fila["Localidad"].ToString() : "";
            estado_CivilTextBox.Text = fila["Estado Civil"] != DBNull.Value ? fila["Estado Civil"].ToString() : "";
            documentoTextBox.Text = fila["Documento"] != DBNull.Value ? fila["Documento"].ToString() : "";

            // Asignar tutor
            if (fila.Table.Columns.Contains("Id Tutor") && ComboBoxTutores.DataSource != null)
            {
                if (fila["Id Tutor"] != DBNull.Value)
                {
                    int idTutor = Convert.ToInt32(fila["Id Tutor"]);
                    bool tutorExiste = ((DataTable)ComboBoxTutores.DataSource)
                        .AsEnumerable()
                        .Any(r => Convert.ToInt32(r["Id Tutor"]) == idTutor);

                    ComboBoxTutores.SelectedValue = tutorExiste ? idTutor : -1;
                }
                else
                {
                    ComboBoxTutores.SelectedIndex = -1;
                }
            }
        }

        #endregion

        #region Cargar Tutores

        private void CargarTutoresEnComboBox()
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Equipo_2Final_6.accdb";

            using (OleDbConnection conexion = new OleDbConnection(connectionString))
            {
                conexion.Open();
                string consulta = "SELECT [Id Tutor], [Nombre] & ' ' & [Apellido] AS [NombreCompleto] FROM Tutor";
                OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                ComboBoxTutores.DisplayMember = "NombreCompleto";
                ComboBoxTutores.ValueMember = "Id Tutor";
                ComboBoxTutores.DataSource = tabla;
                ComboBoxTutores.SelectedIndex = -1;
            }

        }

        #endregion

        #region Botones de Navegación


        private void BotonPersonaSiguiente_Click(object sender, EventArgs e)
        {
            if (comboFiltrar.SelectedIndex < comboFiltrar.Items.Count - 1)
            {
                comboFiltrar.SelectedIndex++;
                CargarDatosDePersonaActual();
            }
        }

        private void BotonPersonaAnterior_Click(object sender, EventArgs e)
        {
            if (comboFiltrar.SelectedIndex > 0)
            {
                comboFiltrar.SelectedIndex--;
                CargarDatosDePersonaActual();
            }
        }
        private void CambiarEstadoTextBoxes(bool estado)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Enabled = estado;
            }

            // Deshabilitar algunos controles específicos si querés
            vencimiento_de_CUDDateTimePicker.Enabled = false;
            ComboBoxTutores.Enabled = false;
        }

        private void LimpiarTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else if (c.HasChildren)
                {
                    // llamada recursiva para contenedores anidados
                    LimpiarTextBoxes(c);
                }
            }
        }

        #endregion

        #region ComboBox Filtrar Eventos

        private void comboFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatosDePersonaActual();
        }

        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            Menu_Principal menu = new Menu_Principal();
            menu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;

            if(printDialog.ShowDialog() == DialogResult.OK)
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

            int marginLeft = 100;
            int spacing = 40;  // espacio entre filas
            int labelWidth = 200; // ancho del label
            int valueMaxWidth = 400; // ancho máximo del valor

            // Fuentes
            Font titleFont = new Font("Arial", 20, FontStyle.Bold);
            Font labelFont = new Font("Arial", 12, FontStyle.Bold);
            Font valueFont = new Font("Arial", 12);
            Brush brush = Brushes.Black;

            // Calcular posición vertical inicial
            int titleHeight = 60;
            int marginTop = e.MarginBounds.Top + 20;

            // Título
            g.DrawString("Ficha De Persona", titleFont, brush, marginLeft, marginTop);
            marginTop += titleHeight;

            // Lista de campos (nombre y valor)
            var campos = new (string label, string valor)[]
            {
        ("Nombre:", nombreTextBox.Text),
        ("Apellido:", apellidoTextBox.Text),
        ("Documento:", documentoTextBox.Text),
        ("Dirección:", direcciónTextBox.Text),
        ("Discapacidad:", discapacidadTextBox.Text),
        ("Teléfono:", teléfonoTextBox.Text),
        ("Teléfono N°2:", teléfono_N_2TextBox.Text),
        ("Vencimiento CUD:", vencimiento_de_CUDDateTimePicker.Value.ToShortDateString()),
        ("Localidad:", localidadTextBox.Text),
        ("Estado Civil:", estado_CivilTextBox.Text),
        ("Tutor:", ComboBoxTutores.Text)
            };

            // Dibujar campos con línea debajo usando el método con "..."
            foreach (var campo in campos)
            {
                DrawFieldWithEllipsis(g, campo.label, campo.valor, marginLeft, marginTop, labelWidth, valueMaxWidth, labelFont, valueFont, brush);

                // Dibujar línea debajo del valor
                int lineY = marginTop + spacing - 5;
                g.DrawLine(Pens.Black, marginLeft, lineY, marginLeft + labelWidth + valueMaxWidth, lineY);

                marginTop += spacing;
            }
        }

        // Método para dibujar label + valor con "..." si es muy largo
        private void DrawFieldWithEllipsis(Graphics g, string label, string valor, int x, int y, int labelWidth, int valueMaxWidth, Font labelFont, Font valueFont, Brush brush)
        {
            // Dibujar label
            g.DrawString(label, labelFont, brush, x, y);

            // Calcular posición del valor
            int valueX = x + labelWidth;

            // Preparar texto
            string textoFinal = valor ?? "";
            SizeF size = g.MeasureString(textoFinal, valueFont);

            // Si el texto excede el ancho máximo, recortar y agregar "..."
            if (size.Width > valueMaxWidth)
            {
                while (textoFinal.Length > 0 && g.MeasureString(textoFinal + "...", valueFont).Width > valueMaxWidth)
                    textoFinal = textoFinal.Substring(0, textoFinal.Length - 1);
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
                personas_con_discapacidadBindingSource.AddNew(); // Crea un nuevo registro y lo muestra
                CambiarEstadoTextBoxes(true);
                cUD_vencidoCheckBox.Enabled = true;
                vencimiento_de_CUDDateTimePicker.Enabled = true;
                ComboBoxTutores.Enabled = true;
                BotonCancelar.Enabled = true;
                BotonInsertarRegistro.Enabled = true;
                BotonPersonaAnterior.Enabled = false;
                BotonPersonaSiguiente.Enabled = false;
                BotonModificarRegistro.Enabled = false;
                btnBuscar.Enabled = false;
                button2.Enabled = false;
                button1.Enabled = true;
                button3.Enabled = true;
                button5.Enabled = true;
                BotonNuevoRegistro.Enabled = false;

                // 🔹 Asegurar que los CheckBox no aparezcan indeterminados
                cUD_vencidoCheckBox.ThreeState = false;
                cUD_vencidoCheckBox.CheckState = CheckState.Unchecked; // o CheckState.Checked si querés que arranquen marcados
                
            }
        }

        private void BotonEliminarRegistro_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("¿Desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (decision == DialogResult.Yes)
            {
                try
                {
                    this.personas_con_discapacidadTableAdapter.ConsultaEliminarPersona(
                        Convert.ToInt32(id_PersonaTextBox.Text)
                    );

                    // Si no hay errores, mostrar mensaje de éxito
                    MessageBox.Show("El registro fue Eliminado correctamente.");
                    LimpiarTextBoxes(this);
                }
                catch (Exception ex)
                {
                    // Si ocurre un error, mostrar el mensaje de error
                    MessageBox.Show("Error: " + ex.Message);
                }


                CambiarEstadoTextBoxes(false);
                BotonModificarRegistro.Enabled = true;
                BotonPersonaAnterior.Enabled = true;
                BotonPersonaSiguiente.Enabled = true;
                btnBuscar.Enabled = true;
                button2.Enabled = true;
                button1.Enabled = false;
                button3.Enabled = false;
                button5.Enabled = false;
                BotonModificarRegistro.Enabled = true;
                BotonCancelar.Enabled = false;
                BotonInsertarRegistro.Enabled = false;
                BotonNuevoRegistro.Enabled = true;
                BotonGuardarRegistro.Enabled = false;
                BotonEliminarRegistro.Enabled = false;
                cUD_vencidoCheckBox.Enabled = false; 
            }
        }

        private void BotonGuardarRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                this.personas_con_discapacidadTableAdapter.ConsultaActualizarPersona(
                    nombreTextBox.Text,
                    apellidoTextBox.Text,
                    documentoTextBox.Text,
                    direcciónTextBox.Text,
                    discapacidadTextBox.Text,
                    teléfonoTextBox.Text,
                    teléfono_N_2TextBox.Text,
                    cUD_vencidoCheckBox.Checked,
                    vencimiento_de_CUDDateTimePicker.Value,
                    localidadTextBox.Text,
                    estado_CivilTextBox.Text,
                    Convert.ToInt32(ComboBoxTutores.SelectedValue),
                    int.Parse(id_PersonaTextBox.Text)
                );

                MessageBox.Show("El registro fue Editado correctamente.");
            }
            catch (Exception ex)
            {
                // Si ocurre un error, mostrar el mensaje de error
                MessageBox.Show("Error: " + ex.Message);
            }


            CambiarEstadoTextBoxes(false);
            cUD_vencidoCheckBox.Enabled = false;
            BotonModificarRegistro.Enabled = true;
            BotonPersonaAnterior.Enabled = true;
            BotonPersonaSiguiente.Enabled = true;
            btnBuscar.Enabled = true;
            button2.Enabled = true;
            button1.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
            BotonModificarRegistro.Enabled = true;
            BotonCancelar.Enabled = false;
            BotonInsertarRegistro.Enabled = false;
            BotonNuevoRegistro.Enabled = true;
            BotonGuardarRegistro.Enabled = false;
            BotonEliminarRegistro.Enabled = false;

            // 🔹 Refrescar los datos en memoria
            this.personas_con_discapacidadTableAdapter.Fill(this.equipo_2Final_6DataSet.Personas_con_discapacidad);

            // 🔹 Volver a posicionarse en el mismo registro editado
            personas_con_discapacidadBindingSource.Position = personas_con_discapacidadBindingSource.Find("Id Tutor", int.Parse(id_PersonaTextBox.Text));
        }

        private void botonRegresar_Click(object sender, EventArgs e)
        {
            Nuevo_Tutor menu = new Nuevo_Tutor();
            this.Hide();
            menu.ShowDialog();
            this.Show();
        }

        private void BotonModificarRegistro_Click(object sender, EventArgs e)
        {
           
            BotonNuevoRegistro.Enabled = false;
            BotonInsertarRegistro.Enabled = false;
            BotonGuardarRegistro.Enabled = true;
            BotonEliminarRegistro.Enabled = true;
            BotonCancelar.Enabled = true;
            CambiarEstadoTextBoxes(true);
            vencimiento_de_CUDDateTimePicker.Enabled = true;
            ComboBoxTutores.Enabled = true;
            cUD_vencidoCheckBox.Enabled = true;
            btnBuscar.Enabled = false;
            button2.Enabled = false;
            BotonModificarRegistro.Enabled = false;
            button1.Enabled = true;
            button3.Enabled = true;
            button5.Enabled = true;
            BotonPersonaAnterior.Enabled = false;
            BotonPersonaSiguiente.Enabled = false;

        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            personas_con_discapacidadBindingSource.CancelEdit(); // Cancela el nuevo registro
            personas_con_discapacidadBindingSource.ResetBindings(false); // Refresca los datos
            CambiarEstadoTextBoxes(false);
            cUD_vencidoCheckBox.Enabled = false;
            BotonPersonaAnterior.Enabled = true;
            BotonPersonaSiguiente.Enabled = true;
            btnBuscar.Enabled = true;
            button2.Enabled = true;
            button1.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
            BotonModificarRegistro.Enabled = true;
            BotonCancelar.Enabled = false;
            BotonInsertarRegistro.Enabled = false;
            BotonNuevoRegistro.Enabled = true;
            BotonGuardarRegistro.Enabled = false;
            BotonEliminarRegistro.Enabled = false;
        }

        private void BotonInsertarRegistro_Click(object sender, EventArgs e)
        {
            int idTutor = Convert.ToInt32(ComboBoxTutores.SelectedValue);

            try
            {
                // Intentar insertar el registro
                this.personas_con_discapacidadTableAdapter.ConsultaInsertarPersona(
                    nombreTextBox.Text,
                    apellidoTextBox.Text,
                    direcciónTextBox.Text,
                    discapacidadTextBox.Text,
                    teléfonoTextBox.Text,
                    teléfono_N_2TextBox.Text,
                    cUD_vencidoCheckBox.Checked,
                    vencimiento_de_CUDDateTimePicker.Value,
                    localidadTextBox.Text,
                    estado_CivilTextBox.Text,
                    idTutor,
                    documentoTextBox.Text
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

            personas_con_discapacidadBindingSource.ResetBindings(false); // Refresca los datos
            CambiarEstadoTextBoxes(false);
            cUD_vencidoCheckBox.Enabled = false;
            BotonPersonaAnterior.Enabled = true;
            BotonPersonaSiguiente.Enabled = true;
            btnBuscar.Enabled = true;
            button2.Enabled = true;
            button1.Enabled = true;
            button3.Enabled = true;
            button5.Enabled = true;
            BotonModificarRegistro.Enabled = true;
            BotonCancelar.Enabled = false;
            BotonInsertarRegistro.Enabled = false;
            BotonNuevoRegistro.Enabled = true;
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {

        }

        private void cUD_vencidoLabel_Click(object sender, EventArgs e)
        {

        }
        private int ObtenerIdPersonaActual()
        {
            if (int.TryParse(id_PersonaTextBox.Text, out int id))
                return id;
            return -1;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Seleccionar archivo";
            ofd.Filter = "Todos los archivos|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = ofd.FileName;

                // Obtener el ID de la persona actual
                int personaIdActual = ObtenerIdPersonaActual(); // reemplazalo con tu forma real de obtener el ID

                // Crear carpeta para esa persona
                string rutaBase = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\ArchivosAdjuntos"));
                string carpetaPersona = Path.Combine(rutaBase, personaIdActual.ToString());
                Directory.CreateDirectory(carpetaPersona);

                // Copiar archivo
                string nombreArchivo = Path.GetFileName(rutaArchivo);
                string rutaDestino = Path.Combine(carpetaPersona, nombreArchivo);
                File.Copy(rutaArchivo, rutaDestino, true);

                MessageBox.Show("Archivo guardado en: " + rutaDestino);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int personaIdActual = ObtenerIdPersonaActual();

            if (personaIdActual == -1)
            {
                MessageBox.Show("No se pudo obtener el ID de la persona actual.");
                return;
            }

            string rutaCarpeta = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\ArchivosAdjuntos", personaIdActual.ToString()));

            if (Directory.Exists(rutaCarpeta))
            {
                // Abrir carpeta con el explorador de Windows
                System.Diagnostics.Process.Start("explorer.exe", rutaCarpeta);
            }
            else
            {
                MessageBox.Show("Esta persona no tiene archivos adjuntos.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            panelFiltrar.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Quieres agregar un nuevo tutor?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Nuevo_Tutor nuevotutor = new Nuevo_Tutor();
                this.Hide();
                nuevotutor.ShowDialog();
                this.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelFiltrar.Visible = false;
            BotonNuevoRegistro.Visible = true;
            BotonPersonaAnterior.Enabled = true;
            BotonPersonaSiguiente.Enabled = true;
        }

        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string busqueda = "%" + txtBuscar.Text.Trim() + "%";

                using (OleDbConnection conn = new OleDbConnection(
                    @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Equipo_2Final_6.accdb"))
                {
                    conn.Open();

                    string sql = @"
                SELECT [Id Persona], [Nombre], [Apellido]
                FROM [Personas con discapacidad]
                WHERE [Nombre] LIKE ? OR [Apellido] LIKE ? OR [Documento] LIKE ?";

                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("?", busqueda);
                        cmd.Parameters.AddWithValue("?", busqueda);
                        cmd.Parameters.AddWithValue("?", busqueda);

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            DataTable raw = new DataTable();
                            adapter.Fill(raw);

                            if (raw.Rows.Count == 0)
                            {
                                MessageBox.Show("No se encontraron registros con ese valor.");
                                // limpiar combo para evitar estado viejo
                                comboFiltrar.BindingContext = new BindingContext();
                                comboFiltrar.DataSource = null;
                                comboFiltrar.Items.Clear();
                                return;
                            }

                            // Construir dt con NombreCompleto (evita DataRowView sin DisplayMember)
                            DataTable resultados = new DataTable();
                            resultados.Columns.Add("Id Persona", typeof(int));
                            resultados.Columns.Add("NombreCompleto", typeof(string));

                            foreach (DataRow r in raw.Rows)
                            {
                                int id = r["Id Persona"] != DBNull.Value ? Convert.ToInt32(r["Id Persona"]) : -1;
                                string nombre = r["Nombre"] != DBNull.Value ? r["Nombre"].ToString().Trim() : "";
                                string apellido = r["Apellido"] != DBNull.Value ? r["Apellido"].ToString().Trim() : "";
                                resultados.Rows.Add(id, (nombre + " " + apellido).Trim());
                            }

                            // Asignar Display/Value antes del DataSource
                            comboFiltrar.DisplayMember = "NombreCompleto";
                            comboFiltrar.ValueMember = "Id Persona";
                            comboFiltrar.BindingContext = new BindingContext();
                            comboFiltrar.DataSource = resultados;

                            if (comboFiltrar.Items.Count > 0)
                                comboFiltrar.SelectedIndex = 0;
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
            try
            {
                // Si DataSource del combo es un DataTable, SelectedItem será DataRowView
                DataRowView drv = comboFiltrar.SelectedItem as DataRowView;

                if (drv != null)
                {
                    // Tenemos Id y Nombre en el DataRowView creado por nosotros
                    int idPersona = drv.Row.Field<int>("Id Persona");
                    // Ahora cargamos la fila original desde el DataSet (mejor que consultar la DB)
                    DataRow[] found = this.equipo_2Final_6DataSet.Personas_con_discapacidad.Select($"[Id Persona] = {idPersona}");
                    if (found.Length > 0)
                    {
                        CargarDatosPersonaDesdeDataRow(found[0]);
                    }
                    else
                    {
                        // fallback: consulta a la BD si no está en el dataset
                        LoadPersonaFromDbById(idPersona);
                    }
                }
                else
                {
                    // fallback a SelectedValue (por si DataSource fue otro tipo)
                    if (comboFiltrar.SelectedValue == null)
                    {
                        MessageBox.Show("No se ha seleccionado ninguna persona.");
                        return;
                    }

                    if (!int.TryParse(comboFiltrar.SelectedValue.ToString(), out int idPersona))
                    {
                        MessageBox.Show("Id de persona inválido.");
                        return;
                    }

                    DataRow[] found = this.equipo_2Final_6DataSet.Personas_con_discapacidad.Select($"[Id Persona] = {idPersona}");
                    if (found.Length > 0)
                        CargarDatosPersonaDesdeDataRow(found[0]);
                    else
                        LoadPersonaFromDbById(idPersona);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los datos: " + ex.Message);
            }

            panelFiltrar.Visible = false;
        }

        // helper: si no está en dataset, consulta a BD
        private void LoadPersonaFromDbById(int idPersona)
        {
            using (OleDbConnection conn = new OleDbConnection(
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Equipo_2Final_6.accdb"))
            {
                conn.Open();
                string sql = "SELECT * FROM [Personas con discapacidad] WHERE [Id Persona] = ?";
                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("?", idPersona);
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count > 0)
                            CargarDatosPersonaDesdeDataRow(dt.Rows[0]);
                        else
                            MessageBox.Show("No se encontraron datos para esta persona.");
                    }
                }
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

        private void apellidoLabel_Click(object sender, EventArgs e)
        {

        }

        private void documentoLabel_Click(object sender, EventArgs e)
        {

        }

        private void direcciónLabel_Click(object sender, EventArgs e)
        {

        }

        private void discapacidadLabel_Click(object sender, EventArgs e)
        {

        }

        private void teléfonoLabel_Click(object sender, EventArgs e)
        {

        }

        private void teléfono_N_2Label_Click(object sender, EventArgs e)
        {

        }

        private void nombreLabel_Click(object sender, EventArgs e)
        {

        }

        private void vencimiento_de_CUDLabel_Click(object sender, EventArgs e)
        {

        }

        private void localidadLabel_Click(object sender, EventArgs e)
        {

        }

        private void estado_CivilLabel_Click(object sender, EventArgs e)
        {

        }

        private void id_tutorLabel_Click(object sender, EventArgs e)
        {

        }

        private void vencimiento_de_CUDDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cUD_vencidoCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxTutores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void localidadTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void estado_CivilTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {

        }

        private void label5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
