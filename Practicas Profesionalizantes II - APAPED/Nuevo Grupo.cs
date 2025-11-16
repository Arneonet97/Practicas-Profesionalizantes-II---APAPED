using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas_Profesionalizantes_II___APAPED
{
    public partial class Nuevo_Grupo : Form
    {
        public Nuevo_Grupo()
        {
            InitializeComponent();
        }

        private void BotonBuscarRegistro_Click(object sender, EventArgs e)
        {
            
        }

        private void grupoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.grupoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.equipo_2Final_6DataSet);

        }

        private void Nuevo_Grupo_Load(object sender, EventArgs e)
        {

            ConfigurarLabels();

            // TODO: esta línea de código carga datos en la tabla 'equipo_2Final_6DataSet.Grupo' Puede moverla o quitarla según sea necesario.
            this.grupoTableAdapter.Fill(this.equipo_2Final_6DataSet.Grupo);

            CambiarEstadoTextBoxes(false);
            BotonInsertarRegistro.Enabled = false;
            BotonGuardarRegistro.Enabled = false;
            BotonGuardarRegistro.Enabled = false;
            BotonEliminarRegistro.Enabled = false;
            BotonCancelar.Enabled = false;

            // Configurar cada botón
            ConfigurarBotonModerno(BotonNuevoRegistro, "NUEVO REGISTRO");
            ConfigurarBotonModerno(BotonCancelar, "CANCELAR");
            ConfigurarBotonModerno(BotonModificarRegistro, "MODIFICAR REGISTRO");
            ConfigurarBotonModerno(BotonGuardarRegistro, "GUARDAR REGISTRO");
            ConfigurarBotonModerno(BotonEliminarRegistro, "ELIMINAR REGISTRO");
            ConfigurarBotonModerno(BotonInsertarRegistro, "INSERTAR");

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

        
        private void BotonPersonaSiguiente_Click(object sender, EventArgs e)
        {
            if (grupoBindingSource.Position < grupoBindingSource.Count - 1)
                grupoBindingSource.MoveNext();

            BotonNuevoRegistro.Enabled = true;
            BotonModificarRegistro.Enabled = true;

        }
        private void BotonPersonaAnterior_Click(object sender, EventArgs e)
        {
            if (grupoBindingSource.Position > 0)
                grupoBindingSource.MovePrevious();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_Principal menu = new Menu_Principal();
            menu.Show();
            this.Hide();
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
        private void BotonNuevoRegistro_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("¿Agregar nuevo registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (decision == DialogResult.Yes)
            {
                grupoBindingSource.AddNew(); // Crea un nuevo registro y lo muestra
                CambiarEstadoTextBoxes(true);
                BotonCancelar.Enabled = true;
                BotonInsertarRegistro.Enabled = true;
                BotonPersonaAnterior.Enabled = false;
                BotonPersonaSiguiente.Enabled = false;
                BotonModificarRegistro.Enabled = false;
                BotonNuevoRegistro.Enabled = false;
            }
            
        }


        private void BotonEliminarRegistro_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("¿Desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (decision == DialogResult.Yes)
            {
                try
                {
                    this.grupoTableAdapter.ConsultaEliminarGrupo(nombreTextBox.Text);
                    MessageBox.Show("El registro fue eliminado correctamente.");

                    // Refrescar el DataSet y BindingSource
                    this.grupoTableAdapter.Fill(this.equipo_2Final_6DataSet.Grupo);

                    // Si aún hay registros, moverse al primero
                    if (grupoBindingSource.Count > 0)
                        grupoBindingSource.MoveFirst();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                // Estado de botones
                BotonModificarRegistro.Enabled = true;
                BotonPersonaAnterior.Enabled = true;
                BotonPersonaSiguiente.Enabled = true;
                BotonCancelar.Enabled = false;
                BotonInsertarRegistro.Enabled = false;
                BotonNuevoRegistro.Enabled = true;
                BotonGuardarRegistro.Enabled = false;
                BotonEliminarRegistro.Enabled = false;
                btn_print.Enabled = true;
            }
        }

        private void BotonInsertarRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                // Intentar insertar el registro
                this.grupoTableAdapter.ConsultaInsertarGrupo(
                    nombreTextBox.Text,
                    descripcíonTextBox.Text,
                    persona_a_cargoTextBox.Text,
                    hora_de_inicioTextBox.Text,
                    díasTextBox.Text,
                    duraciónTextBox.Text,
                    lugarTextBox.Text
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

            grupoBindingSource.ResetBindings(false); // Refresca los datos
            BotonPersonaAnterior.Enabled = true;
            BotonPersonaSiguiente.Enabled = true;
            BotonModificarRegistro.Enabled = true;
            BotonCancelar.Enabled = false;
            BotonInsertarRegistro.Enabled = false;
            BotonNuevoRegistro.Enabled = true;
            btn_print.Enabled = true;
        }

        private void BotonModificarRegistro_Click(object sender, EventArgs e)
        {
            BotonPersonaAnterior.Enabled = false;
            BotonPersonaSiguiente.Enabled = false;
            BotonNuevoRegistro.Enabled = false;
            BotonGuardarRegistro.Enabled = true;
            CambiarEstadoTextBoxes(true);
            BotonGuardarRegistro.Enabled = true;
            BotonEliminarRegistro.Enabled = true;
            BotonCancelar.Enabled = true;
            btn_print.Enabled = false;

        }

        private void BotonGuardarRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                this.grupoTableAdapter.ConsultaActualizarGrupo(
                    nombreTextBox.Text,
                    descripcíonTextBox.Text,
                    persona_a_cargoTextBox.Text,
                    hora_de_inicioTextBox.Text,
                    díasTextBox.Text,
                    duraciónTextBox.Text,
                    lugarTextBox.Text,
                    int.Parse(id_GrupoTextBox.Text)
                );

                MessageBox.Show("El registro fue Editado correctamente.");
            }
            catch (Exception ex)
            {
                // Si ocurre un error, mostrar el mensaje de error
                MessageBox.Show("Error: " + ex.Message);
            }

            BotonModificarRegistro.Enabled = true;
            BotonPersonaAnterior.Enabled = true;
            BotonPersonaSiguiente.Enabled = true;
            BotonModificarRegistro.Enabled = true;
            BotonCancelar.Enabled = false;
            BotonInsertarRegistro.Enabled = false;
            BotonNuevoRegistro.Enabled = true;
            BotonGuardarRegistro.Enabled = false;
            BotonEliminarRegistro.Enabled = false;
            btn_print.Enabled = true;

        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            grupoBindingSource.CancelEdit(); // Cancela el nuevo registro
            grupoBindingSource.ResetBindings(false); // Refresca los datos
            BotonPersonaAnterior.Enabled = true;
            BotonPersonaSiguiente.Enabled = true;
            BotonModificarRegistro.Enabled = true;
            BotonCancelar.Enabled = false;
            BotonInsertarRegistro.Enabled = false;
            BotonNuevoRegistro.Enabled = true;
            BotonGuardarRegistro.Enabled = false;
            BotonEliminarRegistro.Enabled = false;
            btn_print.Enabled = true;
            BotonGuardarRegistro.Enabled = false;
            CambiarEstadoTextBoxes(false); 

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            int marginLeft = 100;   // margen izquierdo
            int marginTop = 100;    // margen superior inicial
            int spacing = 40;       // espacio entre filas
            int labelWidth = 200;   // ancho del label
            int valueMaxWidth = 400; // ancho máximo para el valor antes de cortar
            Font titleFont = new Font("Arial", 20, FontStyle.Bold);
            Font labelFont = new Font("Arial", 12, FontStyle.Bold);
            Font valueFont = new Font("Arial", 12);
            Brush brush = Brushes.Black;

            try
            {
                // Título
                g.DrawString("Ficha de Grupo", titleFont, brush, marginLeft, marginTop);
                marginTop += 60; // espacio después del título

                // Campos del formulario
                var campos = new KeyValuePair<string, string>[]
                {
            new KeyValuePair<string, string>("Nombre:", nombreTextBox.Text),
            new KeyValuePair<string, string>("Persona A Cargo:", persona_a_cargoTextBox.Text),
            new KeyValuePair<string, string>("Horas De Inicio:", hora_de_inicioTextBox.Text),
            new KeyValuePair<string, string>("Días:", díasTextBox.Text),
            new KeyValuePair<string, string>("Lugar:", lugarTextBox.Text)
                    // puedes agregar más campos aquí
                };

                foreach (var campo in campos)
                {
                    // Dibujar label + valor con "..."
                    DrawFieldWithEllipsis(g, campo.Key, campo.Value, marginLeft, marginTop, labelWidth, valueMaxWidth, labelFont, valueFont, brush);

                    // Línea debajo del valor
                    g.DrawLine(Pens.Black, marginLeft, marginTop + spacing - 5, marginLeft + labelWidth + valueMaxWidth, marginTop + spacing - 5);

                    marginTop += spacing;
                }
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
        private void DrawField(Graphics g, string label, string value, int x, int y, int labelWidth, Font labelFont, Font valueFont, Brush brush)
        {
            g.DrawString(label, labelFont, brush, x, y);
            g.DrawString(value, valueFont, brush, x + labelWidth, y);
        }

        private void btn_print_Click(object sender, EventArgs e)
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
    }
}
