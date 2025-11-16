using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas_Profesionalizantes_II___APAPED.Consulta
{
    public partial class Persona_en_grupo : Form
    {
        public Persona_en_grupo()
        {
            InitializeComponent();
        }

        private void Persona_en_grupo_Load(object sender, EventArgs e)
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;

            EstadodeInicio();

            // Cargar datos
            this.grupo_PersonaTableAdapter.FillByPersonaengrupo(this.equipo_2Final_6DataSet.Grupo_Persona);

            // Ordenar
            grupo_PersonaBindingSource.DataSource = equipo_2Final_6DataSet.Grupo_Persona;
            grupo_PersonaBindingSource.Sort = "Grupo ASC";

            // Enlazar al DataGridView
            dataGridView1.DataSource = grupo_PersonaBindingSource;

            // Cargar ComboBox de grupos (solo nombres únicos)
            var grupos = equipo_2Final_6DataSet.Grupo_Persona
                .AsEnumerable()
                .Select(r => r.Field<string>("Grupo"))
                .Distinct()
                .OrderBy(nombre => nombre)
                .ToList();

            comboFiltrarGrupo.Items.Clear();
            comboFiltrarGrupo.Items.Add("Todos"); // opción por defecto
            comboFiltrarGrupo.Items.AddRange(grupos.ToArray());
            comboFiltrarGrupo.SelectedIndex = 0; // Selecciona "Todos"

            ocultarids();

            //imprimir
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            ConfigurarLabels();

            ConfigurarBotonModerno(btnfiltrar, "FILTRAR");
            ConfigurarBotonModerno(btnfinalizarbusqueda, "SALIR");

            estilodatagridview();

        }
        private void estilodatagridview()
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.BackgroundColor = Color.FromArgb(240, 240, 240);
        }
        private void ConfigurarLabels()
        {
            // Fuente y colores
            label1.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            label2.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            Color fondoAzul = Color.FromArgb(45, 130, 220);

            // Fondo y color principal
            label1.BackColor = fondoAzul;
            label2.BackColor = fondoAzul;

            // Asignar el evento Paint a los tres labels
            label1.Paint -= LabelConSombra_Paint;
            label2.Paint -= LabelConSombra_Paint;
            //label5.Paint -= LabelConSombra_Paint;
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
        private void ocultarids()
        {
            // Ocultar IDs
            if (dataGridView1.Columns.Contains("Id Persona"))
                dataGridView1.Columns["Id Persona"].Visible = false;

            if (dataGridView1.Columns.Contains("Id Grupo"))
                dataGridView1.Columns["Id Grupo"].Visible = false;
        }

        private void EstadodeInicio()
        {
            label1.Visible = false;
            label2.Visible = false;
            txtBuscarPersona.Visible = false;
            comboFiltrarGrupo.Visible = false;
            btnfinalizarbusqueda.Visible = false;
            btnfiltrar.Visible = false;
            btnBuscar.Visible = true;
            button3.Visible = true;
        }

        private void MostrarControlesdeBusqueda()
        {
            label1.Visible = true;
            label2.Visible = true;
            txtBuscarPersona.Visible = true;
            comboFiltrarGrupo.Visible = true;
            btnfinalizarbusqueda.Visible = true;
            btnfiltrar.Visible = true;
            btnBuscar.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
        }

        private PrintDocument printDocument1 = new PrintDocument();
        private PrintDialog printDialog1 = new PrintDialog();
        private int filaActual = 0;
        
        private void button2_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    filaActual = 0; // Reiniciar para que imprima desde el inicio
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
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int y = 100;
            int x = 50;
            int altoFila = 30;
            int anchoCol = 150;

            Font fuente = new Font("Arial", 10);
            Brush pincel = Brushes.Black;
            Pen lapiz = Pens.Black;

            // Encabezados de columna
            int xCol = x;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i].Visible)
                {
                    // Fondo gris para encabezados
                    e.Graphics.FillRectangle(Brushes.LightGray, xCol, y, anchoCol, altoFila);
                    e.Graphics.DrawRectangle(lapiz, xCol, y, anchoCol, altoFila);

                    e.Graphics.DrawString(dataGridView1.Columns[i].HeaderText, fuente, pincel, new RectangleF(xCol + 2, y + 5, anchoCol - 4, altoFila));
                    xCol += anchoCol;
                }
            }

            y += altoFila;

            // Filas
            while (filaActual < dataGridView1.Rows.Count)
            {
                DataGridViewRow fila = dataGridView1.Rows[filaActual];
                xCol = x;
                int altoFilaActual = altoFila;

                // Calcular la altura necesaria según el texto más alto de la fila
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    if (celda.Visible)
                    {
                        string texto = celda.Value?.ToString() ?? "";
                        SizeF tamTexto = e.Graphics.MeasureString(texto, fuente, anchoCol - 4);
                        int altoTexto = (int)Math.Ceiling(tamTexto.Height) + 10;
                        if (altoTexto > altoFilaActual)
                            altoFilaActual = altoTexto;
                    }
                }

                // Dibujar cada celda con ajuste de texto
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    if (dataGridView1.Columns[i].Visible)
                    {
                        string valor = fila.Cells[i].Value?.ToString() ?? "";

                        RectangleF rectTexto = new RectangleF(xCol + 2, y + 5, anchoCol - 4, altoFilaActual - 10);
                        e.Graphics.DrawString(valor, fuente, pincel, rectTexto);

                        e.Graphics.DrawRectangle(lapiz, xCol, y, anchoCol, altoFilaActual); // Borde de la celda
                        xCol += anchoCol;
                    }
                }

                y += altoFilaActual;
                filaActual++;

                // Paginación
                if (y + altoFila > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false;
        }


        private void grupo_PersonaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.grupo_PersonaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.equipo_2Final_6DataSet);

        }

        private void fillByPersonaengrupoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.grupo_PersonaTableAdapter.FillByPersonaengrupo(this.equipo_2Final_6DataSet.Grupo_Persona);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarControlesdeBusqueda();
        }

        private void btnfinalizarbusqueda_Click_1(object sender, EventArgs e)
        {
            EstadodeInicio();
            btnBuscar.Enabled = true;
            button3.Enabled = true;
            button2.Enabled = true;
        }

        private void btnfiltrar_Click(object sender, EventArgs e)
        {
            string filtroPersona = txtBuscarPersona.Text.Trim().ToLower();
            string filtroGrupo = comboFiltrarGrupo.SelectedItem?.ToString();

            var tablaFiltrada = equipo_2Final_6DataSet.Grupo_Persona
                .AsEnumerable()
                .Where(row =>
                {
                    bool coincidePersona = string.IsNullOrEmpty(filtroPersona) ||
                        row.Field<string>("Nombre").ToLower().Contains(filtroPersona);

                    bool coincideGrupo = filtroGrupo == "Todos" || row.Field<string>("Grupo") == filtroGrupo;

                    return coincidePersona && coincideGrupo;
                });

            if (tablaFiltrada.Any())
            {
                dataGridView1.DataSource = tablaFiltrada.CopyToDataTable();
                ocultarids();
            }
            else
            {
                dataGridView1.DataSource = null;
                MessageBox.Show("No se encontraron resultados con los filtros aplicados.");
            }

            btnBuscar.Enabled = true;
            button3.Enabled = true;
            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("¿Desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (decision == DialogResult.Yes)
            {
                try
                {
                    // Verificar que hay al menos una fila seleccionada
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                        int idPersona = Convert.ToInt32(filaSeleccionada.Cells["Id Persona"].Value);
                        int idGrupo = Convert.ToInt32(filaSeleccionada.Cells["Id Grupo"].Value);

                        // Eliminar con TableAdapter
                        grupo_PersonaTableAdapter.ConsultaEliminarPersonaEnGrupo(idGrupo, idPersona);

                        MessageBox.Show("El registro fue eliminado correctamente.");

                        // Recargar los datos
                        grupo_PersonaTableAdapter.FillByPersonaengrupo(equipo_2Final_6DataSet.Grupo_Persona);
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar una fila para eliminar.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }
    }
}
