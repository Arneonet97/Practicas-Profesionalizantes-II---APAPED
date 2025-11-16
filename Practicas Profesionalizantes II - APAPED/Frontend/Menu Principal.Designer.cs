namespace Practicas_Profesionalizantes_II___APAPED
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BotonPersonas = new System.Windows.Forms.Button();
            this.BotonGrupos = new System.Windows.Forms.Button();
            this.BotonTutores = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonPersonas
            // 
            this.BotonPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonPersonas.Location = new System.Drawing.Point(114, 532);
            this.BotonPersonas.Name = "BotonPersonas";
            this.BotonPersonas.Size = new System.Drawing.Size(133, 62);
            this.BotonPersonas.TabIndex = 1;
            this.BotonPersonas.Text = "PERSONAS";
            this.BotonPersonas.UseVisualStyleBackColor = true;
            this.BotonPersonas.Click += new System.EventHandler(this.BotonPersonas_Click);
            // 
            // BotonGrupos
            // 
            this.BotonGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonGrupos.Location = new System.Drawing.Point(286, 532);
            this.BotonGrupos.Name = "BotonGrupos";
            this.BotonGrupos.Size = new System.Drawing.Size(133, 62);
            this.BotonGrupos.TabIndex = 2;
            this.BotonGrupos.Text = "GRUPOS";
            this.BotonGrupos.UseVisualStyleBackColor = true;
            this.BotonGrupos.Click += new System.EventHandler(this.MenuGrupos_Click);
            // 
            // BotonTutores
            // 
            this.BotonTutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonTutores.Location = new System.Drawing.Point(454, 532);
            this.BotonTutores.Name = "BotonTutores";
            this.BotonTutores.Size = new System.Drawing.Size(133, 62);
            this.BotonTutores.TabIndex = 3;
            this.BotonTutores.Text = "TUTORES";
            this.BotonTutores.UseVisualStyleBackColor = true;
            this.BotonTutores.Click += new System.EventHandler(this.MenuTutores_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practicas_Profesionalizantes_II___APAPED.Properties.Resources.WhatsApp_Image_2025_04_13_at_8_17_31_PM;
            this.pictureBox1.Location = new System.Drawing.Point(155, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 447);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(687, 654);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BotonTutores);
            this.Controls.Add(this.BotonGrupos);
            this.Controls.Add(this.BotonPersonas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotonPersonas;
        private System.Windows.Forms.Button BotonGrupos;
        private System.Windows.Forms.Button BotonTutores;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

