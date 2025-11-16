namespace Practicas_Profesionalizantes_II___APAPED
{
    partial class Menu_Tutores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Tutores));
            this.return_menu = new System.Windows.Forms.Button();
            this.BotonListadeTutores = new System.Windows.Forms.Button();
            this.BotonNuevoTutor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // return_menu
            // 
            this.return_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.return_menu.Location = new System.Drawing.Point(436, 532);
            this.return_menu.Name = "return_menu";
            this.return_menu.Size = new System.Drawing.Size(78, 61);
            this.return_menu.TabIndex = 43;
            this.return_menu.UseVisualStyleBackColor = true;
            this.return_menu.Click += new System.EventHandler(this.return_menu_Click);
            // 
            // BotonListadeTutores
            // 
            this.BotonListadeTutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonListadeTutores.Location = new System.Drawing.Point(265, 532);
            this.BotonListadeTutores.Name = "BotonListadeTutores";
            this.BotonListadeTutores.Size = new System.Drawing.Size(133, 61);
            this.BotonListadeTutores.TabIndex = 41;
            this.BotonListadeTutores.Text = "VER LISTA DE TUTORES";
            this.BotonListadeTutores.UseVisualStyleBackColor = true;
            this.BotonListadeTutores.Click += new System.EventHandler(this.BotonListadeTutores_Click);
            // 
            // BotonNuevoTutor
            // 
            this.BotonNuevoTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonNuevoTutor.Location = new System.Drawing.Point(97, 532);
            this.BotonNuevoTutor.Name = "BotonNuevoTutor";
            this.BotonNuevoTutor.Size = new System.Drawing.Size(133, 61);
            this.BotonNuevoTutor.TabIndex = 40;
            this.BotonNuevoTutor.Text = "NUEVO TUTOR";
            this.BotonNuevoTutor.UseVisualStyleBackColor = true;
            this.BotonNuevoTutor.Click += new System.EventHandler(this.BotonNuevoTutor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(114, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 447);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // Menu_Tutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 654);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.return_menu);
            this.Controls.Add(this.BotonListadeTutores);
            this.Controls.Add(this.BotonNuevoTutor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu_Tutores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Control de Personas ";
            this.Load += new System.EventHandler(this.Menu_Tutores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button return_menu;
        private System.Windows.Forms.Button BotonListadeTutores;
        private System.Windows.Forms.Button BotonNuevoTutor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}