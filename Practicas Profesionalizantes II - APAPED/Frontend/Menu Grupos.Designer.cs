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
            this.BotonMenuPrincipal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BotonAGREGARPERSONAS = new System.Windows.Forms.Button();
            this.BotonLISTADEGRUPOS = new System.Windows.Forms.Button();
            this.BotonEDITARGRUPOS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonMenuPrincipal
            // 
            this.BotonMenuPrincipal.BackgroundImage = global::Practicas_Profesionalizantes_II___APAPED.Properties.Resources.menuprincipal;
            this.BotonMenuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonMenuPrincipal.Location = new System.Drawing.Point(586, 46);
            this.BotonMenuPrincipal.Name = "BotonMenuPrincipal";
            this.BotonMenuPrincipal.Size = new System.Drawing.Size(80, 71);
            this.BotonMenuPrincipal.TabIndex = 27;
            this.BotonMenuPrincipal.UseVisualStyleBackColor = true;
            this.BotonMenuPrincipal.Click += new System.EventHandler(this.BotonMenuPrincipal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practicas_Profesionalizantes_II___APAPED.Properties.Resources.WhatsApp_Image_2025_04_13_at_8_17_31_PM;
            this.pictureBox1.Location = new System.Drawing.Point(145, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // BotonAGREGARPERSONAS
            // 
            this.BotonAGREGARPERSONAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAGREGARPERSONAS.Location = new System.Drawing.Point(430, 515);
            this.BotonAGREGARPERSONAS.Name = "BotonAGREGARPERSONAS";
            this.BotonAGREGARPERSONAS.Size = new System.Drawing.Size(133, 62);
            this.BotonAGREGARPERSONAS.TabIndex = 30;
            this.BotonAGREGARPERSONAS.Text = "AGREGAR PERSONAS";
            this.BotonAGREGARPERSONAS.UseVisualStyleBackColor = true;
            this.BotonAGREGARPERSONAS.Click += new System.EventHandler(this.BotonAGREGARPERSONAS_Click);
            // 
            // BotonLISTADEGRUPOS
            // 
            this.BotonLISTADEGRUPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonLISTADEGRUPOS.Location = new System.Drawing.Point(262, 515);
            this.BotonLISTADEGRUPOS.Name = "BotonLISTADEGRUPOS";
            this.BotonLISTADEGRUPOS.Size = new System.Drawing.Size(133, 62);
            this.BotonLISTADEGRUPOS.TabIndex = 29;
            this.BotonLISTADEGRUPOS.Text = "LISTA DE GRUPOS";
            this.BotonLISTADEGRUPOS.UseVisualStyleBackColor = true;
            this.BotonLISTADEGRUPOS.Click += new System.EventHandler(this.BotonLISTADEGRUPOS_Click);
            // 
            // BotonEDITARGRUPOS
            // 
            this.BotonEDITARGRUPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonEDITARGRUPOS.Location = new System.Drawing.Point(90, 515);
            this.BotonEDITARGRUPOS.Name = "BotonEDITARGRUPOS";
            this.BotonEDITARGRUPOS.Size = new System.Drawing.Size(133, 62);
            this.BotonEDITARGRUPOS.TabIndex = 28;
            this.BotonEDITARGRUPOS.Text = "EDITAR GRUPOS";
            this.BotonEDITARGRUPOS.UseVisualStyleBackColor = true;
            this.BotonEDITARGRUPOS.Click += new System.EventHandler(this.BotonEDITARGRUPOS_Click);
            // 
            // Menu_Grupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 654);
            this.Controls.Add(this.BotonAGREGARPERSONAS);
            this.Controls.Add(this.BotonLISTADEGRUPOS);
            this.Controls.Add(this.BotonEDITARGRUPOS);
            this.Controls.Add(this.BotonMenuPrincipal);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu_Grupos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_Grupos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotonMenuPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BotonAGREGARPERSONAS;
        private System.Windows.Forms.Button BotonLISTADEGRUPOS;
        private System.Windows.Forms.Button BotonEDITARGRUPOS;
    }
}