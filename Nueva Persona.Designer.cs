namespace Practicas_Profesionalizantes_II___APAPED
{
    partial class Nueva_Persona
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BotonEliminarRegistro = new System.Windows.Forms.Button();
            this.BotonGuardarRegistro = new System.Windows.Forms.Button();
            this.BotonNuevoTutorDePersona = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 71);
            this.label1.TabIndex = 7;
            this.label1.Text = "PERSONAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practicas_Profesionalizantes_II___APAPED.Properties.Resources.APAPED_LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(357, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 426);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // BotonEliminarRegistro
            // 
            this.BotonEliminarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonEliminarRegistro.Location = new System.Drawing.Point(197, 391);
            this.BotonEliminarRegistro.Name = "BotonEliminarRegistro";
            this.BotonEliminarRegistro.Size = new System.Drawing.Size(142, 35);
            this.BotonEliminarRegistro.TabIndex = 3;
            this.BotonEliminarRegistro.Text = "Eliminar Registro";
            this.BotonEliminarRegistro.UseVisualStyleBackColor = true;
            // 
            // BotonGuardarRegistro
            // 
            this.BotonGuardarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonGuardarRegistro.Location = new System.Drawing.Point(32, 391);
            this.BotonGuardarRegistro.Name = "BotonGuardarRegistro";
            this.BotonGuardarRegistro.Size = new System.Drawing.Size(142, 35);
            this.BotonGuardarRegistro.TabIndex = 2;
            this.BotonGuardarRegistro.Text = "Guardar Registro";
            this.BotonGuardarRegistro.UseVisualStyleBackColor = true;
            // 
            // BotonNuevoTutorDePersona
            // 
            this.BotonNuevoTutorDePersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonNuevoTutorDePersona.Location = new System.Drawing.Point(291, 262);
            this.BotonNuevoTutorDePersona.Name = "BotonNuevoTutorDePersona";
            this.BotonNuevoTutorDePersona.Size = new System.Drawing.Size(33, 35);
            this.BotonNuevoTutorDePersona.TabIndex = 1;
            this.BotonNuevoTutorDePersona.Text = "+";
            this.BotonNuevoTutorDePersona.UseVisualStyleBackColor = true;
            // 
            // Nueva_Persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotonNuevoTutorDePersona);
            this.Controls.Add(this.BotonEliminarRegistro);
            this.Controls.Add(this.BotonGuardarRegistro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Nueva_Persona";
            this.Text = "Nueva_Persona";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BotonEliminarRegistro;
        private System.Windows.Forms.Button BotonGuardarRegistro;
        private System.Windows.Forms.Button BotonNuevoTutorDePersona;
    }
}