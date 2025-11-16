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
            this.BotonMenuPrincipal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BotonContacto = new System.Windows.Forms.Button();
            this.BotonLISTATUTORES = new System.Windows.Forms.Button();
            this.BotonNUEVOTUTOR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonMenuPrincipal
            // 
            this.BotonMenuPrincipal.BackgroundImage = global::Practicas_Profesionalizantes_II___APAPED.Properties.Resources.menuprincipal;
            this.BotonMenuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonMenuPrincipal.Location = new System.Drawing.Point(583, 50);
            this.BotonMenuPrincipal.Name = "BotonMenuPrincipal";
            this.BotonMenuPrincipal.Size = new System.Drawing.Size(80, 71);
            this.BotonMenuPrincipal.TabIndex = 27;
            this.BotonMenuPrincipal.UseVisualStyleBackColor = true;
            this.BotonMenuPrincipal.Click += new System.EventHandler(this.BotonMenuPrincipal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practicas_Profesionalizantes_II___APAPED.Properties.Resources.WhatsApp_Image_2025_04_13_at_8_17_31_PM;
            this.pictureBox1.Location = new System.Drawing.Point(142, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // BotonContacto
            // 
            this.BotonContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonContacto.Location = new System.Drawing.Point(433, 506);
            this.BotonContacto.Name = "BotonContacto";
            this.BotonContacto.Size = new System.Drawing.Size(133, 62);
            this.BotonContacto.TabIndex = 30;
            this.BotonContacto.Text = "CONTACTO";
            this.BotonContacto.UseVisualStyleBackColor = true;
            this.BotonContacto.Click += new System.EventHandler(this.BotonContacto_Click);
            // 
            // BotonLISTATUTORES
            // 
            this.BotonLISTATUTORES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonLISTATUTORES.Location = new System.Drawing.Point(265, 506);
            this.BotonLISTATUTORES.Name = "BotonLISTATUTORES";
            this.BotonLISTATUTORES.Size = new System.Drawing.Size(133, 62);
            this.BotonLISTATUTORES.TabIndex = 29;
            this.BotonLISTATUTORES.Text = "LISTA TUTORES";
            this.BotonLISTATUTORES.UseVisualStyleBackColor = true;
            this.BotonLISTATUTORES.Click += new System.EventHandler(this.BotonLISTATUTORES_Click);
            // 
            // BotonNUEVOTUTOR
            // 
            this.BotonNUEVOTUTOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonNUEVOTUTOR.Location = new System.Drawing.Point(93, 506);
            this.BotonNUEVOTUTOR.Name = "BotonNUEVOTUTOR";
            this.BotonNUEVOTUTOR.Size = new System.Drawing.Size(133, 62);
            this.BotonNUEVOTUTOR.TabIndex = 28;
            this.BotonNUEVOTUTOR.Text = "NUEVO TUTOR";
            this.BotonNUEVOTUTOR.UseVisualStyleBackColor = true;
            this.BotonNUEVOTUTOR.Click += new System.EventHandler(this.BotonNUEVOTUTOR_Click);
            // 
            // Menu_Tutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 654);
            this.Controls.Add(this.BotonContacto);
            this.Controls.Add(this.BotonLISTATUTORES);
            this.Controls.Add(this.BotonNUEVOTUTOR);
            this.Controls.Add(this.BotonMenuPrincipal);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu_Tutores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_Tutores";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotonMenuPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BotonContacto;
        private System.Windows.Forms.Button BotonLISTATUTORES;
        private System.Windows.Forms.Button BotonNUEVOTUTOR;
    }
}