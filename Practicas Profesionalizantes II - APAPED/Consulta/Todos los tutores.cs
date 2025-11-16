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
    public partial class Todos_los_tutores : Form
    {
        public Todos_los_tutores()
        {
            InitializeComponent();
        }

        private void Todos_los_tutores_Load(object sender, EventArgs e)
        {
            todos_los_tutoresDataGridView.RowHeadersVisible = false;
            todos_los_tutoresDataGridView.AllowUserToAddRows = false;

            // TODO: esta línea de código carga datos en la tabla 'equipo_2Final_6DataSet.Todos_los_tutores' Puede moverla o quitarla según sea necesario.
            this.todos_los_tutoresTableAdapter.Fill(this.equipo_2Final_6DataSet.Todos_los_tutores);

            //imprimir
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            estilodatagridview();

        }
        private void estilodatagridview()
        {
            todos_los_tutoresDataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Regular);
            todos_los_tutoresDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            todos_los_tutoresDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            todos_los_tutoresDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            todos_los_tutoresDataGridView.DefaultCellStyle.BackColor = Color.LightBlue;
            todos_los_tutoresDataGridView.DefaultCellStyle.ForeColor = Color.Black;
            todos_los_tutoresDataGridView.BackgroundColor = Color.FromArgb(240, 240, 240);
        }

        private void return_menu_Click(object sender, EventArgs e)
        {
            Menu_Principal menu = new Menu_Principal();
            menu.Show();
            this.Close();
        }
        private void MostrarControlesdeBusqueda()
        {
            /*
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            txtBuscarPersona.Visible = true;
            comboFiltrarGrupo.Visible = true;
            btnfinalizarbusqueda.Visible = true;
            btnfiltrar.Visible = true;
            btnBuscar.Visible = false;
            */
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarControlesdeBusqueda();
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
            for (int i = 0; i < todos_los_tutoresDataGridView.Columns.Count; i++)
            {
                if (todos_los_tutoresDataGridView.Columns[i].Visible)
                {
                    // Fondo gris para encabezado
                    e.Graphics.FillRectangle(Brushes.LightGray, xCol, y, anchoCol, altoFila);
                    e.Graphics.DrawRectangle(lapiz, xCol, y, anchoCol, altoFila);

                    e.Graphics.DrawString(todos_los_tutoresDataGridView.Columns[i].HeaderText, fuente, pincel, xCol + 2, y + 5);
                    xCol += anchoCol;
                }
            }

            y += altoFila;

            // Filas
            while (filaActual < todos_los_tutoresDataGridView.Rows.Count)
            {
                DataGridViewRow fila = todos_los_tutoresDataGridView.Rows[filaActual];
                xCol = x;

                for (int i = 0; i < todos_los_tutoresDataGridView.Columns.Count; i++)
                {
                    if (todos_los_tutoresDataGridView.Columns[i].Visible)
                    {
                        string valor = fila.Cells[i].Value?.ToString() ?? "";
                        e.Graphics.DrawString(valor, fuente, pincel, xCol + 2, y + 5);
                        e.Graphics.DrawRectangle(lapiz, xCol, y, anchoCol, altoFila); // borde de celda
                        xCol += anchoCol;
                    }
                }

                y += altoFila;
                filaActual++;

                // Paginación automática
                if (y + altoFila > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();

            // --- Si está vacío, quitamos filtro y colores ---
            if (string.IsNullOrEmpty(texto))
            {
                todos_los_tutoresBindingSource.RemoveFilter();

                foreach (DataGridViewRow row in todos_los_tutoresDataGridView.Rows)
                    row.DefaultCellStyle.BackColor = Color.White;

                return;
            }

            // --- Filtro dinámico ---
            string textoEscapado = texto.Replace("'", "''");
            todos_los_tutoresBindingSource.Filter =
                $"CONVERT(Nombre, 'System.String') LIKE '%{textoEscapado}%' OR " +
                $"CONVERT(Apellido, 'System.String') LIKE '%{textoEscapado}%' OR " +
                $"CONVERT(Documento, 'System.String') LIKE '%{textoEscapado}%'";

            // --- Resaltado visual ---
            foreach (DataGridViewRow row in todos_los_tutoresDataGridView.Rows)
            {
                bool coincide = false;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null &&
                        cell.Value.ToString().IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        coincide = true;
                        break;
                    }
                }

                // Si coincide, pintar fondo amarillo; si no, blanco
                row.DefaultCellStyle.BackColor = coincide ? Color.LightYellow : Color.White;
            }
        }

    }
}
