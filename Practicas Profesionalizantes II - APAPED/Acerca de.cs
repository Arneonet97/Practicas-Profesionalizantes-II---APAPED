using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas_Profesionalizantes_II___APAPED
{
    public partial class Acerca_de : Form
    {
        public Acerca_de()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CargarEULA()
        {
            {
                richTextBox1.Clear();

                // Título principal
                richTextBox1.SelectionFont = new Font("Segoe UI", 16, FontStyle.Bold);
                richTextBox1.SelectionColor = Color.DarkBlue;
                richTextBox1.AppendText("Contrato de Licencia de Usuario Final (EULA)\n\n");

                // Datos del proyecto
                richTextBox1.SelectionFont = new Font("Segoe UI", 12, FontStyle.Bold);
                richTextBox1.SelectionColor = Color.MediumBlue;
                richTextBox1.AppendText("Proyecto: ");
                richTextBox1.SelectionFont = new Font("Segoe UI", 12, FontStyle.Regular);
                richTextBox1.SelectionColor = Color.Black;
                richTextBox1.AppendText("Sistema de Gestión para la Organización de Padres y Amigos de Personas con Discapacidad (APAPED)\n");

                richTextBox1.SelectionFont = new Font("Segoe UI", 12, FontStyle.Bold);
                richTextBox1.SelectionColor = Color.MediumBlue;
                richTextBox1.AppendText("Desarrolladores: ");
                richTextBox1.SelectionFont = new Font("Segoe UI", 12, FontStyle.Regular);
                richTextBox1.SelectionColor = Color.Black;
                richTextBox1.AppendText("Bella Tomás, Galarza Alan, Marquez Jonathan, Correa Zaida, Yudiche Ornela\n");

                richTextBox1.SelectionFont = new Font("Segoe UI", 12, FontStyle.Bold);
                richTextBox1.SelectionColor = Color.MediumBlue;
                richTextBox1.AppendText("Institución educativa: ");
                richTextBox1.SelectionFont = new Font("Segoe UI", 12, FontStyle.Regular);
                richTextBox1.SelectionColor = Color.Black;
                richTextBox1.AppendText("Instituto Superior de Formación Docente Ramón J. Cárcano\n");

                richTextBox1.SelectionFont = new Font("Segoe UI", 12, FontStyle.Bold);
                richTextBox1.SelectionColor = Color.MediumBlue;
                richTextBox1.AppendText("Carrera: ");
                richTextBox1.SelectionFont = new Font("Segoe UI", 12, FontStyle.Regular);
                richTextBox1.SelectionColor = Color.Black;
                richTextBox1.AppendText("Tecnicatura Superior en Desarrollo de Software\n");

                richTextBox1.SelectionFont = new Font("Segoe UI", 12, FontStyle.Bold);
                richTextBox1.SelectionColor = Color.MediumBlue;
                richTextBox1.AppendText("Materia: ");
                richTextBox1.SelectionFont = new Font("Segoe UI", 12, FontStyle.Regular);
                richTextBox1.SelectionColor = Color.Black;
                richTextBox1.AppendText("Prácticas Profesionalizantes III\n");

                richTextBox1.SelectionFont = new Font("Segoe UI", 12, FontStyle.Bold);
                richTextBox1.SelectionColor = Color.MediumBlue;
                richTextBox1.AppendText("Profesor tutor: ");
                richTextBox1.SelectionFont = new Font("Segoe UI", 12, FontStyle.Regular);
                richTextBox1.SelectionColor = Color.Black;
                richTextBox1.AppendText("Silva Carlos\n\n");

                // Secciones del EULA
                string[] secciones = new string[]
                {
        "1. Objeto",
        "2. Naturaleza del software",
        "3. Licencia de uso",
        "4. Responsabilidad y garantía",
        "5. Propiedad intelectual",
        "6. Aceptación"
                };

                string[] contenidos = new string[]
                {
        "El presente Contrato de Licencia de Usuario Final (EULA) regula el uso del software desarrollado en el marco académico antes mencionado, destinado a la gestión de información interna de la organización APAPED.\n\n",
        "El software fue desarrollado con fines educativos y de práctica profesional, sin fines de lucro.\nAPAPED podrá utilizarlo con propósitos institucionales internos, sin que ello implique transferencia de propiedad intelectual ni garantía comercial alguna.\n\n",
        "Se otorga a APAPED una licencia no exclusiva, gratuita y de uso limitado del programa, exclusivamente para su funcionamiento dentro de la organización.\nNo se autoriza la redistribución, modificación ni venta del software sin el consentimiento expreso del desarrollador y/o del Instituto Superior de Formación Docente Ramón J. Cárcano.\n\n",
        "El software se entrega “tal cual”, sin garantías de funcionamiento continuo o libre de errores.\nEl desarrollador y la institución educativa no se responsabilizan por daños o pérdidas derivadas del uso del programa.\n\n",
        "Los derechos de autor del código fuente y del diseño pertenecen al estudiante desarrollador y a la institución educativa como trabajo académico.\nAPAPED podrá usar el sistema conforme a la licencia establecida, reconociendo su autoría original.\n\n",
        "El uso del programa implica la aceptación total de los términos de este acuerdo.\nSi no está de acuerdo con estas condiciones, deberá abstenerse de utilizar el software.\n\n"
                };

                for (int i = 0; i < secciones.Length; i++)
                {
                    // Título de sección
                    richTextBox1.SelectionFont = new Font("Segoe UI", 12, FontStyle.Bold);
                    richTextBox1.SelectionColor = Color.DarkBlue;
                    richTextBox1.AppendText(secciones[i] + "\n");

                    // Contenido
                    richTextBox1.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
                    richTextBox1.SelectionColor = Color.Black;
                    richTextBox1.AppendText(contenidos[i]);
                }

                // Datos finales
                richTextBox1.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
                richTextBox1.SelectionColor = Color.MediumBlue;
                richTextBox1.AppendText("📍 Lugar y fecha: Monte Caseros, 28/10/2025\n");
                richTextBox1.AppendText("\n👤 Desarrolladores: Bella Tomás, Galarza Alan, Marquez Jonathan, Correa Zaida, Yudiche Ornela\n");
                richTextBox1.AppendText("📘 Firma del tutor: (Ver contrato físico)\n");
                richTextBox1.AppendText("🏛️ Instituto Superior de Formación Docente Ramón J. Cárcano\n");
            }
        }
        private void CargarCreditos()
        {
            richTextBox2.Clear();

            // Título del proyecto
            richTextBox2.SelectionFont = new Font("Segoe UI", 16, FontStyle.Bold);
            richTextBox2.SelectionColor = Color.DarkBlue;
            richTextBox2.AppendText("Proyecto: Sistema de Gestión para la Organización de Padres y Amigos de Personas con Discapacidad (APAPED)\n\n");

            // Datos generales
            string[] datos = new string[]
            {
                "",
        "Desarrolladores: Bella Tomás, Galarza Alan, Marquez Jonathan, Correa Zaida, Yudiche Ornela",
        "Carrera: Tecnicatura Superior en Desarrollo de Software",
        "Materia: Prácticas Profesionalizantes III",
        "Institución: Instituto Superior de Formación Docente Ramón J. Cárcano",
        "Profesor tutor: Silva Carlos",
        ""
            };

            richTextBox2.SelectionFont = new Font("Segoe UI", 12, FontStyle.Regular);
            richTextBox2.SelectionColor = Color.Black;

            foreach (var dato in datos)
            {
                richTextBox2.AppendText(dato + "\n");
            }

            richTextBox2.AppendText("\n");

            // Créditos
            richTextBox2.SelectionFont = new Font("Segoe UI", 14, FontStyle.Bold);
            richTextBox2.SelectionColor = Color.MediumBlue;
            richTextBox2.AppendText("Créditos \n\n");

            richTextBox2.SelectionFont = new Font("Segoe UI", 12, FontStyle.Regular);
            richTextBox2.SelectionColor = Color.Black;
            richTextBox2.AppendText("Desarrollado en entorno Microsoft Visual Studio, utilizando el lenguaje C# y la tecnología Windows Forms, con base de datos Microsoft Access.\n");
            richTextBox2.AppendText("Diseño e implementación realizados por el estudiante como parte del proceso formativo en la materia Prácticas Profesionalizantes III.\n\n");

            // Agradecimientos
            richTextBox2.SelectionFont = new Font("Segoe UI", 14, FontStyle.Bold);
            richTextBox2.SelectionColor = Color.MediumBlue;
            richTextBox2.AppendText("Agradecimientos \n\n");

            richTextBox2.SelectionFont = new Font("Segoe UI", 12, FontStyle.Regular);
            richTextBox2.SelectionColor = Color.Black;
            richTextBox2.AppendText("Los desarrolladores expresan su sincero agradecimiento a:\n\n");

            string[] agradecimientos = new string[]
            {
        "Profesor Silva Carlos, por su guía, apoyo y supervisión técnica durante el desarrollo del proyecto.",
        "Profesor Iván Yamil Romero, por su acompañamiento durante las practicas profesionalizantes I y II.",
        "La organización APAPED, por brindar la oportunidad de colaborar en una herramienta que busca facilitar la gestión de información en beneficio de personas con discapacidad y sus familias.",
        "El Instituto Superior de Formación Docente Ramón J. Cárcano, por su acompañamiento en la formación académica y profesional.",
        "A todos los docentes, compañeros y colaboradores que aportaron sus conocimientos y tiempo para hacer posible este proyecto."
            };

            foreach (var item in agradecimientos)
            {
                richTextBox2.AppendText("• " + item + "\n\n");
            }

            // Nota final
            richTextBox2.SelectionFont = new Font("Segoe UI", 12, FontStyle.Italic);
            richTextBox2.SelectionColor = Color.Black;
            richTextBox2.AppendText("Este trabajo fue realizado con fines educativos y de práctica profesional, promoviendo la integración entre la formación técnica y las necesidades reales de las instituciones sociales. \n");
        }
        private void Acerca_de_Load(object sender, EventArgs e)
        {
            ConfigurarLabels();
            CargarEULA();
            CargarCreditos();
        }

        private void ConfigurarLabels()
        {
            // Fuente y colores

            label1.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            label2.Font = new Font("Segoe UI", 18, FontStyle.Bold);

            label3.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            label4.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            label5.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            label6.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            label7.Font = new Font("Segoe UI", 18, FontStyle.Bold);

            Color fondoAzul = Color.FromArgb(45, 130, 220);

            // Fondo y color principal

            label1.BackColor = fondoAzul;
            label2.BackColor = fondoAzul;
            
            label3.BackColor = fondoAzul;
            label4.BackColor = fondoAzul;
            label5.BackColor = fondoAzul;
            label6.BackColor = fondoAzul;
            label7.BackColor = fondoAzul;



            // Asignar el evento Paint a los labels (quitamos duplicados)
            label1.Paint -= LabelConSombra_Paint;
            label2.Paint -= LabelConSombra_Paint;
            label3.Paint -= LabelConSombra_Paint;
            label4.Paint -= LabelConSombra_Paint;
            label5.Paint -= LabelConSombra_Paint;
            label6.Paint -= LabelConSombra_Paint;
            label7.Paint -= LabelConSombra_Paint;

            label1.Paint += LabelConSombra_Paint;
            label2.Paint += LabelConSombra_Paint;
            label3.Paint += LabelConSombra_Paint;
            label4.Paint += LabelConSombra_Paint;
            label5.Paint += LabelConSombra_Paint;
            label6.Paint += LabelConSombra_Paint;
            label7.Paint += LabelConSombra_Paint;
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

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            using (Pen p = new Pen(Color.Black, 5))
            {
                e.Graphics.DrawRectangle(p, e.CellBounds);
            }
        }

        private void tableLayoutPanel3_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            using (Pen p = new Pen(Color.Black, 5))
            {
                e.Graphics.DrawRectangle(p, e.CellBounds);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            using (Pen p = new Pen(Color.Black, 5))
            {
                e.Graphics.DrawRectangle(p, e.CellBounds);
            }
        }

        private void tableLayoutPanel4_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            using (Pen p = new Pen(Color.Black, 5))
            {
                e.Graphics.DrawRectangle(p, e.CellBounds);
            }
        }

        private void tableLayoutPanel6_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            using (Pen p = new Pen(Color.Black, 5))
            {
                e.Graphics.DrawRectangle(p, e.CellBounds);
            }
        }

        private void tableLayoutPanel5_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            using (Pen p = new Pen(Color.Black, 5))
            {
                e.Graphics.DrawRectangle(p, e.CellBounds);
            }
        }

        private void tableLayoutPanel7_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            using (Pen p = new Pen(Color.Black, 5))
            {
                e.Graphics.DrawRectangle(p, e.CellBounds);
            }
        }
    }
}
