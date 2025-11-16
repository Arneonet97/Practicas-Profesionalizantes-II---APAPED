using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas_Profesionalizantes_II___APAPED.Consulta
{
    public partial class CUDs_vencidos : Form
    {
        public CUDs_vencidos()
        {
            InitializeComponent();
        }

        private void CUDs_vencidos_Load(object sender, EventArgs e)
        {
            cUDS_vencidosDataGridView.RowHeadersVisible = false;
            cUDS_vencidosDataGridView.AllowUserToAddRows = false;

            // TODO: esta línea de código carga datos en la tabla 'equipo_2Final_6DataSet.CUDS_vencidos' Puede moverla o quitarla según sea necesario.
            this.cUDS_vencidosTableAdapter.Fill(this.equipo_2Final_6DataSet.CUDS_vencidos);

            //imprimir
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            estilodatagridview();

        }

        private void estilodatagridview() 
        {
            cUDS_vencidosDataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Regular);
            cUDS_vencidosDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            cUDS_vencidosDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            cUDS_vencidosDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            cUDS_vencidosDataGridView.DefaultCellStyle.BackColor = Color.LightBlue;
            cUDS_vencidosDataGridView.DefaultCellStyle.ForeColor = Color.Black;
            cUDS_vencidosDataGridView.BackgroundColor = Color.FromArgb(240, 240, 240);
        }
        private void return_menu_Click(object sender, EventArgs e)
        {
            Menu_Principal menu = new Menu_Principal();
            menu.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private PrintDocument printDocument1 = new PrintDocument();
        private PrintDialog printDialog1 = new PrintDialog();
        private int filaActual = 0;
        private void button2_Click_1(object sender, EventArgs e)
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
            Label lbl = new Label();
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
            int x = 50;  // margen izquierdo
            int altoFila = 30;
            int anchoCol = 150;

            Font fuente = new Font("Arial", 10);
            Brush pincel = Brushes.Black;
            Pen lapiz = Pens.Black;

            // Encabezados de columna
            int xCol = x;
            for (int i = 0; i < cUDS_vencidosDataGridView.Columns.Count; i++)
            {
                if (cUDS_vencidosDataGridView.Columns[i].Visible)
                {
                    // Dibujar fondo del encabezado (opcional)
                    e.Graphics.FillRectangle(Brushes.LightGray, xCol, y, anchoCol, altoFila);
                    e.Graphics.DrawRectangle(lapiz, xCol, y, anchoCol, altoFila);

                    e.Graphics.DrawString(cUDS_vencidosDataGridView.Columns[i].HeaderText, fuente, pincel, xCol + 2, y + 5);
                    xCol += anchoCol;
                }
            }

            y += altoFila;

            // Filas
            while (filaActual < cUDS_vencidosDataGridView.Rows.Count)
            {
                DataGridViewRow fila = cUDS_vencidosDataGridView.Rows[filaActual];
                xCol = x;

                for (int i = 0; i < cUDS_vencidosDataGridView.Columns.Count; i++)
                {
                    if (cUDS_vencidosDataGridView.Columns[i].Visible)
                    {
                        object celdaValor = fila.Cells[i].Value;
                        string valor = "";

                        if (celdaValor is bool booleano)
                        {
                            valor = booleano ? "Sí" : "No"; // ✅ Traducción de True/False
                        }
                        else
                        {
                            valor = celdaValor?.ToString() ?? "";
                        }

                        e.Graphics.DrawString(valor, fuente, pincel, xCol + 2, y + 5);
                        e.Graphics.DrawRectangle(lapiz, xCol, y, anchoCol, altoFila);
                        xCol += anchoCol;
                    }
                }


                y += altoFila;
                filaActual++;

                // Si nos pasamos del margen inferior, pasar a la siguiente página
                if (y + altoFila > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false;
        }
    }
}
