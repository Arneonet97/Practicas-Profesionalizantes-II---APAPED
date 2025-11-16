namespace Practicas_Profesionalizantes_II___APAPED
{
    partial class Menu_Grupos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Grupos));
            this.BotonAgregaGrupos = new System.Windows.Forms.Button();
            this.BotonListadeGrupos = new System.Windows.Forms.Button();
            this.BotonAgregarPersonaAGrupo = new System.Windows.Forms.Button();
            this.return_menu = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonAgregaGrupos
            // 
            this.BotonAgregaGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAgregaGrupos.Location = new System.Drawing.Point(12, 529);
            this.BotonAgregaGrupos.Name = "BotonAgregaGrupos";
            this.BotonAgregaGrupos.Size = new System.Drawing.Size(133, 61);
            this.BotonAgregaGrupos.TabIndex = 5;
            this.BotonAgregaGrupos.Text = "NUEVO GRUPO";
            this.BotonAgregaGrupos.UseVisualStyleBackColor = true;
            this.BotonAgregaGrupos.Click += new System.EventHandler(this.BotonAgregaGrupos_Click);
            // 
            // BotonListadeGrupos
            // 
            this.BotonListadeGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonListadeGrupos.Location = new System.Drawing.Point(180, 529);
            this.BotonListadeGrupos.Name = "BotonListadeGrupos";
            this.BotonListadeGrupos.Size = new System.Drawing.Size(133, 61);
            this.BotonListadeGrupos.TabIndex = 6;
            this.BotonListadeGrupos.Text = "VER LISTA DE GRUPOS";
            this.BotonListadeGrupos.UseVisualStyleBackColor = true;
            this.BotonListadeGrupos.Click += new System.EventHandler(this.BotonListadeGrupos_Click);
            // 
            // BotonAgregarPersonaAGrupo
            // 
            this.BotonAgregarPersonaAGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAgregarPersonaAGrupo.Location = new System.Drawing.Point(345, 528);
            this.BotonAgregarPersonaAGrupo.Name = "BotonAgregarPersonaAGrupo";
            this.BotonAgregarPersonaAGrupo.Size = new System.Drawing.Size(133, 62);
            this.BotonAgregarPersonaAGrupo.TabIndex = 7;
            this.BotonAgregarPersonaAGrupo.Text = "PERSONAS EN GRUPO";
            this.BotonAgregarPersonaAGrupo.UseVisualStyleBackColor = true;
            this.BotonAgregarPersonaAGrupo.Click += new System.EventHandler(this.BotonAgregarPersonaAGrupo_Click);
            // 
            // return_menu
            // 
            this.return_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.return_menu.Location = new System.Drawing.Point(511, 528);
            this.return_menu.Name = "return_menu";
            this.return_menu.Size = new System.Drawing.Size(78, 62);
            this.return_menu.TabIndex = 39;
            this.return_menu.UseVisualStyleBackColor = true;
            this.return_menu.Click += new System.EventHandler(this.return_menu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(117, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 447);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // Menu_Grupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 654);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.return_menu);
            this.Controls.Add(this.BotonAgregarPersonaAGrupo);
            this.Controls.Add(this.BotonListadeGrupos);
            this.Controls.Add(this.BotonAgregaGrupos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu_Grupos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Control de Personas ";
            this.Load += new System.EventHandler(this.Menu_Grupos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BotonAgregaGrupos;
        private System.Windows.Forms.Button BotonListadeGrupos;
        private System.Windows.Forms.Button BotonAgregarPersonaAGrupo;
        private System.Windows.Forms.Button return_menu;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}