namespace Practicas_Profesionalizantes_II___APAPED
{
    partial class Menu_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Principal));
            this.BotonPersonas = new System.Windows.Forms.Button();
            this.BotonGrupos = new System.Windows.Forms.Button();
            this.BotonTutores = new System.Windows.Forms.Button();
            this.return_menu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonPersonas
            // 
            this.BotonPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonPersonas.Location = new System.Drawing.Point(12, 539);
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
            this.BotonGrupos.Location = new System.Drawing.Point(184, 539);
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
            this.BotonTutores.Location = new System.Drawing.Point(352, 539);
            this.BotonTutores.Name = "BotonTutores";
            this.BotonTutores.Size = new System.Drawing.Size(133, 62);
            this.BotonTutores.TabIndex = 3;
            this.BotonTutores.Text = "TUTORES";
            this.BotonTutores.UseVisualStyleBackColor = true;
            this.BotonTutores.Click += new System.EventHandler(this.MenuTutores_Click);
            // 
            // return_menu
            // 
            this.return_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.return_menu.Location = new System.Drawing.Point(525, 540);
            this.return_menu.Name = "return_menu";
            this.return_menu.Size = new System.Drawing.Size(69, 62);
            this.return_menu.TabIndex = 44;
            this.return_menu.UseVisualStyleBackColor = true;
            this.return_menu.Click += new System.EventHandler(this.return_menu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 447);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(635, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 38);
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Menu_Principal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(687, 654);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.return_menu);
            this.Controls.Add(this.BotonTutores);
            this.Controls.Add(this.BotonGrupos);
            this.Controls.Add(this.BotonPersonas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(703, 693);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(703, 693);
            this.Name = "Menu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Control de Personas ";
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotonPersonas;
        private System.Windows.Forms.Button BotonGrupos;
        private System.Windows.Forms.Button BotonTutores;
        private System.Windows.Forms.Button return_menu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

