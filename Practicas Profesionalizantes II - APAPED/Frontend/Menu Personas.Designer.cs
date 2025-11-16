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
            this.botonCUDVencidos = new System.Windows.Forms.Button();
            this.BotonListadePersonas = new System.Windows.Forms.Button();
            this.BotonAgregarPersonas = new System.Windows.Forms.Button();
            this.BotonMenuPrincipal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // BotonMenuPrincipal
            // 
            this.BotonMenuPrincipal.BackgroundImage = global::Practicas_Profesionalizantes_II___APAPED.Properties.Resources.menuprincipal;
            this.BotonMenuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonMenuPrincipal.Location = new System.Drawing.Point(590, 49);
            this.BotonMenuPrincipal.Name = "BotonMenuPrincipal";
            this.BotonMenuPrincipal.Size = new System.Drawing.Size(80, 71);
            this.BotonMenuPrincipal.TabIndex = 27;
            this.BotonMenuPrincipal.UseVisualStyleBackColor = true;
            this.BotonMenuPrincipal.Click += new System.EventHandler(this.BotonMenuPrincipal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practicas_Profesionalizantes_II___APAPED.Properties.Resources.WhatsApp_Image_2025_04_13_at_8_17_31_PM;
            this.pictureBox1.Location = new System.Drawing.Point(149, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Menu_Personas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 654);
            this.Controls.Add(this.BotonMenuPrincipal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botonCUDVencidos);
            this.Controls.Add(this.BotonListadePersonas);
            this.Controls.Add(this.BotonAgregarPersonas);
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
        private System.Windows.Forms.Button botonCUDVencidos;
        private System.Windows.Forms.Button BotonListadePersonas;
        private System.Windows.Forms.Button BotonAgregarPersonas;
        private System.Windows.Forms.Button BotonMenuPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}