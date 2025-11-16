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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Personas));
            this.botonCUDVencidos = new System.Windows.Forms.Button();
            this.BotonListadePersonas = new System.Windows.Forms.Button();
            this.BotonAgregarPersonas = new System.Windows.Forms.Button();
            this.return_menu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonCUDVencidos
            // 
            this.botonCUDVencidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCUDVencidos.Location = new System.Drawing.Point(345, 540);
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
            this.BotonListadePersonas.Location = new System.Drawing.Point(180, 541);
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
            this.BotonAgregarPersonas.Location = new System.Drawing.Point(12, 541);
            this.BotonAgregarPersonas.Name = "BotonAgregarPersonas";
            this.BotonAgregarPersonas.Size = new System.Drawing.Size(133, 62);
            this.BotonAgregarPersonas.TabIndex = 1;
            this.BotonAgregarPersonas.Text = "AGREGAR PERSONA";
            this.BotonAgregarPersonas.UseVisualStyleBackColor = true;
            this.BotonAgregarPersonas.Click += new System.EventHandler(this.BotonAgregarPersonas_Click);
            // 
            // return_menu
            // 
            this.return_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.return_menu.Location = new System.Drawing.Point(517, 541);
            this.return_menu.Name = "return_menu";
            this.return_menu.Size = new System.Drawing.Size(78, 61);
            this.return_menu.TabIndex = 38;
            this.return_menu.UseVisualStyleBackColor = true;
            this.return_menu.Click += new System.EventHandler(this.return_menu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(128, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 447);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // Menu_Personas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 654);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.return_menu);
            this.Controls.Add(this.botonCUDVencidos);
            this.Controls.Add(this.BotonListadePersonas);
            this.Controls.Add(this.BotonAgregarPersonas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu_Personas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Control de Personas ";
            this.Load += new System.EventHandler(this.Menu_Personas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button botonCUDVencidos;
        private System.Windows.Forms.Button BotonListadePersonas;
        private System.Windows.Forms.Button BotonAgregarPersonas;
        private System.Windows.Forms.Button return_menu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}