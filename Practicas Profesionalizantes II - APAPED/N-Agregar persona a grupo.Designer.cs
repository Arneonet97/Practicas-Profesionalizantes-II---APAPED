namespace Practicas_Profesionalizantes_II___APAPED
{
    partial class N_Agregar_persona_a_grupo
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
            System.Windows.Forms.Label DNILabel1;
            System.Windows.Forms.Label personas_con_discapacidad_NombreLabel;
            System.Windows.Forms.Label grupo_NombreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(N_Agregar_persona_a_grupo));
            this.label1 = new System.Windows.Forms.Label();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.BotonLista = new System.Windows.Forms.Button();
            this.comboBoxNombre = new System.Windows.Forms.ComboBox();
            this.DNITextBox1 = new System.Windows.Forms.TextBox();
            this.ComboBoxNombreGrupo = new System.Windows.Forms.ComboBox();
            this.equipo_2Final_6DataSet = new Practicas_Profesionalizantes_II___APAPED.Equipo_2Final_6DataSet();
            this.grupo_PersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupo_PersonaTableAdapter = new Practicas_Profesionalizantes_II___APAPED.Equipo_2Final_6DataSetTableAdapters.Grupo_PersonaTableAdapter();
            this.tableAdapterManager = new Practicas_Profesionalizantes_II___APAPED.Equipo_2Final_6DataSetTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            DNILabel1 = new System.Windows.Forms.Label();
            personas_con_discapacidad_NombreLabel = new System.Windows.Forms.Label();
            grupo_NombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.equipo_2Final_6DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupo_PersonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DNILabel1
            // 
            DNILabel1.AutoSize = true;
            DNILabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DNILabel1.Location = new System.Drawing.Point(49, 303);
            DNILabel1.Name = "DNILabel1";
            DNILabel1.Size = new System.Drawing.Size(50, 24);
            DNILabel1.TabIndex = 24;
            DNILabel1.Text = "DNI:";
            // 
            // personas_con_discapacidad_NombreLabel
            // 
            personas_con_discapacidad_NombreLabel.AutoSize = true;
            personas_con_discapacidad_NombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            personas_con_discapacidad_NombreLabel.Location = new System.Drawing.Point(49, 249);
            personas_con_discapacidad_NombreLabel.Name = "personas_con_discapacidad_NombreLabel";
            personas_con_discapacidad_NombreLabel.Size = new System.Drawing.Size(91, 24);
            personas_con_discapacidad_NombreLabel.TabIndex = 25;
            personas_con_discapacidad_NombreLabel.Text = "Nombre:";
            // 
            // grupo_NombreLabel
            // 
            grupo_NombreLabel.AutoSize = true;
            grupo_NombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            grupo_NombreLabel.Location = new System.Drawing.Point(49, 362);
            grupo_NombreLabel.Name = "grupo_NombreLabel";
            grupo_NombreLabel.Size = new System.Drawing.Size(155, 24);
            grupo_NombreLabel.TabIndex = 26;
            grupo_NombreLabel.Text = "Nombre Grupo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 46);
            this.label1.TabIndex = 15;
            this.label1.Text = "Agregar Persona a Grupo ";
            // 
            // botonAgregar
            // 
            this.botonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregar.Location = new System.Drawing.Point(53, 547);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(105, 42);
            this.botonAgregar.TabIndex = 16;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // BotonLista
            // 
            this.BotonLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonLista.Location = new System.Drawing.Point(614, 547);
            this.BotonLista.Name = "BotonLista";
            this.BotonLista.Size = new System.Drawing.Size(59, 50);
            this.BotonLista.TabIndex = 24;
            this.BotonLista.Text = "Lista";
            this.BotonLista.UseVisualStyleBackColor = true;
            this.BotonLista.Click += new System.EventHandler(this.BotonLista_Click);
            // 
            // comboBoxNombre
            // 
            this.comboBoxNombre.FormattingEnabled = true;
            this.comboBoxNombre.Location = new System.Drawing.Point(218, 249);
            this.comboBoxNombre.Name = "comboBoxNombre";
            this.comboBoxNombre.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNombre.TabIndex = 28;
            // 
            // DNITextBox1
            // 
            this.DNITextBox1.Location = new System.Drawing.Point(218, 308);
            this.DNITextBox1.Name = "DNITextBox1";
            this.DNITextBox1.ReadOnly = true;
            this.DNITextBox1.Size = new System.Drawing.Size(121, 20);
            this.DNITextBox1.TabIndex = 25;
            // 
            // ComboBoxNombreGrupo
            // 
            this.ComboBoxNombreGrupo.FormattingEnabled = true;
            this.ComboBoxNombreGrupo.Location = new System.Drawing.Point(218, 362);
            this.ComboBoxNombreGrupo.Name = "ComboBoxNombreGrupo";
            this.ComboBoxNombreGrupo.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxNombreGrupo.TabIndex = 29;
            // 
            // equipo_2Final_6DataSet
            // 
            this.equipo_2Final_6DataSet.DataSetName = "Equipo_2Final_6DataSet";
            this.equipo_2Final_6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grupo_PersonaBindingSource
            // 
            this.grupo_PersonaBindingSource.DataMember = "Grupo_Persona";
            this.grupo_PersonaBindingSource.DataSource = this.equipo_2Final_6DataSet;
            // 
            // grupo_PersonaTableAdapter
            // 
            this.grupo_PersonaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Grupo_PersonaTableAdapter = this.grupo_PersonaTableAdapter;
            this.tableAdapterManager.GrupoTableAdapter = null;
            this.tableAdapterManager.Personas_con_discapacidadTableAdapter = null;
            this.tableAdapterManager.TutorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Practicas_Profesionalizantes_II___APAPED.Equipo_2Final_6DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Usuarios_NivelTableAdapter = null;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(375, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 447);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // N_Agregar_persona_a_grupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 620);
            this.Controls.Add(this.ComboBoxNombreGrupo);
            this.Controls.Add(this.comboBoxNombre);
            this.Controls.Add(grupo_NombreLabel);
            this.Controls.Add(personas_con_discapacidad_NombreLabel);
            this.Controls.Add(DNILabel1);
            this.Controls.Add(this.DNITextBox1);
            this.Controls.Add(this.BotonLista);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(826, 659);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(826, 659);
            this.Name = "N_Agregar_persona_a_grupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Control de Personas ";
            this.Load += new System.EventHandler(this.N_Agregar_persona_a_grupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipo_2Final_6DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupo_PersonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Button BotonLista;
        private System.Windows.Forms.ComboBox comboBoxNombre;
        private System.Windows.Forms.TextBox DNITextBox1;
        private System.Windows.Forms.ComboBox ComboBoxNombreGrupo;
        private Equipo_2Final_6DataSet equipo_2Final_6DataSet;
        private System.Windows.Forms.BindingSource grupo_PersonaBindingSource;
        private Equipo_2Final_6DataSetTableAdapters.Grupo_PersonaTableAdapter grupo_PersonaTableAdapter;
        private Equipo_2Final_6DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}