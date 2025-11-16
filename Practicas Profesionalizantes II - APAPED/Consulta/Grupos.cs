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
    public partial class Grupos : Form
    {
        public Grupos()
        {
            InitializeComponent();
        }

        private void Grupos_Load(object sender, EventArgs e)
        {

            gruposDataGridView.RowHeadersVisible = false;
            gruposDataGridView.AllowUserToAddRows = false;

            // TODO: esta línea de código carga datos en la tabla 'equipo_2Final_6DataSet.Grupos' Puede moverla o quitarla según sea necesario.
            this.gruposTableAdapter.Fill(this.equipo_2Final_6DataSet.Grupos);

            //imprimir
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            estilodatagridview();

        }
        private void estilodatagridview()
        {
            gruposDataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Regular);
            gruposDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            gruposDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gruposDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gruposDataGridView.DefaultCellStyle.BackColor = Color.LightBlue;
            gruposDataGridView.DefaultCellStyle.ForeColor = Color.Black;
            gruposDataGridView.BackgroundColor = Color.FromArgb(240, 240, 240);
        }
        private void return_menu_Click(object sender, EventArgs e)
        {
            Menu_Principal menu = new Menu_Principal();
            menu.Show();
            this.Close();
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
            int y = 100; // margen superior
            int x = e.MarginBounds.Left;  // usar margen izquierdo de la página
            int altoFilaBase = 30; // altura mínima de fila
            Font fuente = new Font("Arial", 10);
            Brush pincel = Brushes.Black;
            Pen lapiz = Pens.Black;

            int columnasVisibles = gruposDataGridView.Columns.Cast<DataGridViewColumn>().Count(c => c.Visible);
            if (columnasVisibles == 0) return;

            // Determinar ancho disponible por columna según margen y número de columnas
            int anchoDisponible = e.MarginBounds.Width;
            int anchoCol = anchoDisponible / columnasVisibles;

            // Encabezados de columna
            int xCol = x;
            for (int i = 0; i < gruposDataGridView.Columns.Count; i++)
            {
                if (gruposDataGridView.Columns[i].Visible)
                {
                    e.Graphics.FillRectangle(Brushes.LightGray, xCol, y, anchoCol, altoFilaBase);
                    e.Graphics.DrawRectangle(lapiz, xCol, y, anchoCol, altoFilaBase);
                    e.Graphics.DrawString(gruposDataGridView.Columns[i].HeaderText, fuente, pincel, new RectangleF(xCol + 2, y + 5, anchoCol - 4, altoFilaBase), new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Near });
                    xCol += anchoCol;
                }
            }

            y += altoFilaBase;

            // Filas
            while (filaActual < gruposDataGridView.Rows.Count)
            {
                DataGridViewRow fila = gruposDataGridView.Rows[filaActual];

                // Determinar altura de fila según celda más alta
                int altoFila = altoFilaBase;
                for (int i = 0; i < gruposDataGridView.Columns.Count; i++)
                {
                    if (gruposDataGridView.Columns[i].Visible)
                    {
                        string valor = fila.Cells[i].Value?.ToString() ?? "";
                        SizeF size = e.Graphics.MeasureString(valor, fuente, anchoCol - 4);
                        int altoNecesario = (int)Math.Ceiling(size.Height) + 10;
                        if (altoNecesario > altoFila) altoFila = altoNecesario;
                    }
                }

                // Dibujar cada celda
                xCol = x;
                for (int i = 0; i < gruposDataGridView.Columns.Count; i++)
                {
                    if (gruposDataGridView.Columns[i].Visible)
                    {
                        string valor = fila.Cells[i].Value?.ToString() ?? "";
                        Rectangle rect = new Rectangle(xCol, y, anchoCol, altoFila);
                        e.Graphics.DrawRectangle(lapiz, rect);
                        e.Graphics.DrawString(valor, fuente, pincel, rect, new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Near });
                        xCol += anchoCol;
                    }
                }

                y += altoFila;
                filaActual++;

                if (y + altoFila > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false;
        }



        // Función para recortar texto si es demasiado largo para la celda
        private void DrawStringWithEllipsis(Graphics g, string text, Font font, Brush brush, float x, float y, int maxWidth)
        {
            string textoFinal = text;
            if (g.MeasureString(textoFinal, font).Width > maxWidth)
            {
                while (textoFinal.Length > 0 && g.MeasureString(textoFinal + "...", font).Width > maxWidth)
                {
                    textoFinal = textoFinal.Substring(0, textoFinal.Length - 1);
                }
                textoFinal += "...";
            }
            g.DrawString(textoFinal, font, brush, x, y);
        }
        private void MostrarControlesdeBusqueda()
        {/*
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
    }
}
