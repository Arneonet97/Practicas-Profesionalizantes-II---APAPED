namespace Practicas_Profesionalizantes_II___APAPED
{
    partial class Menu_Personas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botonCUDVencidos = new System.Windows.Forms.Button();
            this.BotonListadePersonas = new System.Windows.Forms.Button();
            this.BotonAgregarPersonas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practicas_Profesionalizantes_II___APAPED.Properties.Resources.APAPED_LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(162, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 447);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // botonCUDVencidos
            // 
            this.botonCUDVencidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCUDVencidos.Location = new System.Drawing.Point(443, 531);
            this.botonCUDVencidos.Name = "botonCUDVencidos";
            this.botonCUDVencidos.Size = new System.Drawing.Size(133, 62);
            this.botonCUDVencidos.TabIndex = 3;
            this.botonCUDVencidos.Text = "CUD VENCIDOS";
            this.botonCUDVencidos.UseVisualStyleBackColor = true;
            this.botonCUDVencidos.Click += new System.EventHandler(this.botonCUDVencidos_Click);
            // 
            // BotonListadePersonas
            // 
            this.BotonListadePersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonListadePersonas.Location = new System.Drawing.Point(275, 531);
            this.BotonListadePersonas.Name = "BotonListadePersonas";
            this.BotonListadePersonas.Size = new System.Drawing.Size(133, 62);
            this.BotonListadePersonas.TabIndex = 2;
            this.BotonListadePersonas.Text = "LISTA DE PERSONAS";
            this.BotonListadePersonas.UseVisualStyleBackColor = true;
            this.BotonListadePersonas.Click += new System.EventHandler(this.BotonListadePersonas_Click);
            // 
            // BotonAgregarPersonas
            // 
            this.BotonAgregarPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAgregarPersonas.Location = new System.Drawing.Point(103, 531);
            this.BotonAgregarPersonas.Name = "BotonAgregarPersonas";
            this.BotonAgregarPersonas.Size = new System.Drawing.Size(133, 62);
            this.BotonAgregarPersonas.TabIndex = 1;
            this.BotonAgregarPersonas.Text = "AGREGAR/ EDITAR";
            this.BotonAgregarPersonas.UseVisualStyleBackColor = true;
            this.BotonAgregarPersonas.Click += new System.EventHandler(this.BotonAgregarPersonas_Click);
            // 
            // Menu_Personas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 654);
            this.Controls.Add(this.botonCUDVencidos);
            this.Controls.Add(this.BotonListadePersonas);
            this.Controls.Add(this.BotonAgregarPersonas);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu_Personas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_Personas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botonCUDVencidos;
        private System.Windows.Forms.Button BotonListadePersonas;
        private System.Windows.Forms.Button BotonAgregarPersonas;
    }
}