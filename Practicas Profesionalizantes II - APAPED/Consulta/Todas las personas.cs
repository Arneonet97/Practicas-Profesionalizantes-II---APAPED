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
    public partial class Todas_las_personas : Form
    {
        // === Variables ===
        private PrintDocument printDocument1 = new PrintDocument();
        private PrintDialog printDialog1 = new PrintDialog();
        private int filaActual = 0;

        public Todas_las_personas()
        {
            InitializeComponent();

            // Asociar eventos del PrintDocument
            printDocument1.BeginPrint += printDocument1_BeginPrint;
            printDocument1.PrintPage += printDocument1_PrintPage;
        }

        private void Todas_las_personas_Load(object sender, EventArgs e)
        {
            todas_las_personasDataGridView.RowHeadersVisible = false;
            todas_las_personasDataGridView.AllowUserToAddRows = false;

            // TODO: esta línea de código carga datos en la tabla 'equipo_2Final_6DataSet.Todas_las_personas' Puede moverla o quitarla según sea necesario.
            this.todas_las_personasTableAdapter.Fill(this.equipo_2Final_6DataSet.Todas_las_personas);

            estilodatagridview();

        }

        private void estilodatagridview()
        {
            todas_las_personasDataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Regular);
            todas_las_personasDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            todas_las_personasDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            todas_las_personasDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            todas_las_personasDataGridView.DefaultCellStyle.BackColor = Color.LightBlue;
            todas_las_personasDataGridView.DefaultCellStyle.ForeColor = Color.Black;
            todas_las_personasDataGridView.BackgroundColor = Color.FromArgb(240, 240, 240);
        }
        private void return_menu_Click(object sender, EventArgs e)
        {
            Menu_Principal menu = new Menu_Principal();
            menu.Show();
            this.Close();
        }

        // === Evento antes de imprimir (configuración inicial) ===
        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            filaActual = 0; // Reinicia antes de imprimir
            printDocument1.DefaultPageSettings.Landscape = true; // Modo horizontal
        }

        // === Botón para imprimir ===
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


        // === Evento de impresión de página ===
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int y = e.MarginBounds.Top;
            int x = e.MarginBounds.Left;
            int altoFila = 30;

            Font fuente = new Font("Arial", 10);
            Brush pincel = Brushes.Black;
            Pen lapiz = Pens.Black;

            // Calcular ancho de columna según el ancho disponible
            int columnasVisibles = todas_las_personasDataGridView.Columns
                .Cast<DataGridViewColumn>()
                .Count(c => c.Visible);

            int anchoCol = e.MarginBounds.Width / columnasVisibles;

            // === Encabezados ===
            int xCol = x;
            for (int i = 0; i < todas_las_personasDataGridView.Columns.Count; i++)
            {
                if (todas_las_personasDataGridView.Columns[i].Visible)
                {
                    e.Graphics.FillRectangle(Brushes.LightGray, xCol, y, anchoCol, altoFila);
                    e.Graphics.DrawRectangle(lapiz, xCol, y, anchoCol, altoFila);
                    e.Graphics.DrawString(
                        todas_las_personasDataGridView.Columns[i].HeaderText,
                        fuente,
                        pincel,
                        xCol + 2,
                        y + 5
                    );
                    xCol += anchoCol;
                }
            }

            y += altoFila;

            // === Filas ===
            while (filaActual < todas_las_personasDataGridView.Rows.Count)
            {
                DataGridViewRow fila = todas_las_personasDataGridView.Rows[filaActual];
                xCol = x;

                for (int i = 0; i < todas_las_personasDataGridView.Columns.Count; i++)
                {
                    if (todas_las_personasDataGridView.Columns[i].Visible)
                    {
                        object celdaValor = fila.Cells[i].Value;
                        string valor = "";

                        // Si la celda tiene un valor
                        if (celdaValor != null)
                        {
                            // Si el valor es tipo DateTime, mostrar solo la fecha
                            if (celdaValor is DateTime fecha)
                                valor = fecha.ToString("dd/MM/yyyy");  // 👈 formato sin hora
                            else
                                valor = celdaValor.ToString();
                        }

                        // Medir el ancho del texto
                        SizeF size = e.Graphics.MeasureString(valor, fuente);

                        // Si el texto es más ancho que la columna, lo recortamos
                        if (size.Width > anchoCol - 4)
                        {
                            // Recortar y agregar "…"
                            while (valor.Length > 0 && e.Graphics.MeasureString(valor + "...", fuente).Width > anchoCol - 4)
                                valor = valor.Substring(0, valor.Length - 1);

                            valor += "...";
                        }

                        // Dibujar el texto ajustado
                        e.Graphics.DrawString(valor, fuente, pincel, xCol + 2, y + 5);

                        e.Graphics.DrawRectangle(lapiz, xCol, y, anchoCol, altoFila);
                        xCol += anchoCol;
                    }
                }

                y += altoFila;
                filaActual++;

                // Si llegamos al final de la página, imprimimos la siguiente
                if (y + altoFila > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                // Si el cuadro está vacío, mostrar todo de nuevo
                this.todas_las_personasTableAdapter.Fill(this.equipo_2Final_6DataSet.Todas_las_personas);
                return;
            }

            // Filtrar los resultados localmente (en memoria)
            var tablaOriginal = equipo_2Final_6DataSet.Todas_las_personas;
            var filasFiltradas = tablaOriginal.AsEnumerable()
                .Where(fila =>
                    todas_las_personasDataGridView.Columns
                        .Cast<DataGridViewColumn>()
                        .Where(c => c.Visible)
                        .Any(col =>
                        {
                            object valor = fila[col.DataPropertyName];
                            return valor != null && valor.ToString().ToLower().Contains(textoBusqueda);
                        })
                );

            if (filasFiltradas.Any())
            {
                todas_las_personasDataGridView.DataSource = filasFiltradas.CopyToDataTable();
            }
            else
            {
                todas_las_personasDataGridView.DataSource = null;
                MessageBox.Show("No se encontraron resultados con ese criterio de búsqueda.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text.Trim().ToLower();

            // Si el cuadro está vacío → recargar toda la lista
            if (string.IsNullOrEmpty(textoBusqueda))
            {
                this.todas_las_personasTableAdapter.Fill(this.equipo_2Final_6DataSet.Todas_las_personas);
                return;
            }

            // Filtrar en memoria (sin afectar la base de datos)
            var tablaOriginal = equipo_2Final_6DataSet.Todas_las_personas;
            var filasFiltradas = tablaOriginal.AsEnumerable()
                .Where(fila =>
                    todas_las_personasDataGridView.Columns
                        .Cast<DataGridViewColumn>()
                        .Where(c => c.Visible)
                        .Any(col =>
                        {
                            object valor = fila[col.DataPropertyName];
                            return valor != null && valor.ToString().ToLower().Contains(textoBusqueda);
                        })
                );

            if (filasFiltradas.Any())
                todas_las_personasDataGridView.DataSource = filasFiltradas.CopyToDataTable();
            else
                todas_las_personasDataGridView.DataSource = null;
        }

    }
}