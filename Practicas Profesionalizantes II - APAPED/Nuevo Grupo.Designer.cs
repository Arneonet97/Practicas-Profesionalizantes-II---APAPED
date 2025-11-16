namespace Practicas_Profesionalizantes_II___APAPED
{
    partial class Nuevo_Grupo
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label descripcíonLabel;
            System.Windows.Forms.Label persona_a_cargoLabel;
            System.Windows.Forms.Label hora_de_inicioLabel;
            System.Windows.Forms.Label díasLabel;
            System.Windows.Forms.Label duraciónLabel;
            System.Windows.Forms.Label lugarLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nuevo_Grupo));
            this.BotonEliminarRegistro = new System.Windows.Forms.Button();
            this.BotonInsertarRegistro = new System.Windows.Forms.Button();
            this.BotonNuevoRegistro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.id_GrupoTextBox = new System.Windows.Forms.TextBox();
            this.grupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipo_2Final_6DataSet = new Practicas_Profesionalizantes_II___APAPED.Equipo_2Final_6DataSet();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.descripcíonTextBox = new System.Windows.Forms.TextBox();
            this.persona_a_cargoTextBox = new System.Windows.Forms.TextBox();
            this.hora_de_inicioTextBox = new System.Windows.Forms.TextBox();
            this.díasTextBox = new System.Windows.Forms.TextBox();
            this.duraciónTextBox = new System.Windows.Forms.TextBox();
            this.lugarTextBox = new System.Windows.Forms.TextBox();
            this.BotonPersonaSiguiente = new System.Windows.Forms.Button();
            this.BotonPersonaAnterior = new System.Windows.Forms.Button();
            this.BotonModificarRegistro = new System.Windows.Forms.Button();
            this.BotonGuardarRegistro = new System.Windows.Forms.Button();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.grupoTableAdapter = new Practicas_Profesionalizantes_II___APAPED.Equipo_2Final_6DataSetTableAdapters.GrupoTableAdapter();
            this.tableAdapterManager = new Practicas_Profesionalizantes_II___APAPED.Equipo_2Final_6DataSetTableAdapters.TableAdapterManager();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btn_print = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            nombreLabel = new System.Windows.Forms.Label();
            descripcíonLabel = new System.Windows.Forms.Label();
            persona_a_cargoLabel = new System.Windows.Forms.Label();
            hora_de_inicioLabel = new System.Windows.Forms.Label();
            díasLabel = new System.Windows.Forms.Label();
            duraciónLabel = new System.Windows.Forms.Label();
            lugarLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipo_2Final_6DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(90, 165);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(103, 26);
            nombreLabel.TabIndex = 11;
            nombreLabel.Text = "Nombre:";
            // 
            // descripcíonLabel
            // 
            descripcíonLabel.AutoSize = true;
            descripcíonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcíonLabel.Location = new System.Drawing.Point(473, 233);
            descripcíonLabel.Name = "descripcíonLabel";
            descripcíonLabel.Size = new System.Drawing.Size(144, 26);
            descripcíonLabel.TabIndex = 13;
            descripcíonLabel.Text = "Descripcíon:";
            // 
            // persona_a_cargoLabel
            // 
            persona_a_cargoLabel.AutoSize = true;
            persona_a_cargoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            persona_a_cargoLabel.Location = new System.Drawing.Point(90, 194);
            persona_a_cargoLabel.Name = "persona_a_cargoLabel";
            persona_a_cargoLabel.Size = new System.Drawing.Size(193, 26);
            persona_a_cargoLabel.TabIndex = 15;
            persona_a_cargoLabel.Text = "Persona a cargo:";
            // 
            // hora_de_inicioLabel
            // 
            hora_de_inicioLabel.AutoSize = true;
            hora_de_inicioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hora_de_inicioLabel.Location = new System.Drawing.Point(90, 221);
            hora_de_inicioLabel.Name = "hora_de_inicioLabel";
            hora_de_inicioLabel.Size = new System.Drawing.Size(166, 26);
            hora_de_inicioLabel.TabIndex = 17;
            hora_de_inicioLabel.Text = "Hora de inicio:";
            // 
            // díasLabel
            // 
            díasLabel.AutoSize = true;
            díasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            díasLabel.Location = new System.Drawing.Point(90, 247);
            díasLabel.Name = "díasLabel";
            díasLabel.Size = new System.Drawing.Size(67, 26);
            díasLabel.TabIndex = 19;
            díasLabel.Text = "Días:";
            // 
            // duraciónLabel
            // 
            duraciónLabel.AutoSize = true;
            duraciónLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            duraciónLabel.Location = new System.Drawing.Point(90, 273);
            duraciónLabel.Name = "duraciónLabel";
            duraciónLabel.Size = new System.Drawing.Size(114, 26);
            duraciónLabel.TabIndex = 21;
            duraciónLabel.Text = "Duración:";
            // 
            // lugarLabel
            // 
            lugarLabel.AutoSize = true;
            lugarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lugarLabel.Location = new System.Drawing.Point(90, 299);
            lugarLabel.Name = "lugarLabel";
            lugarLabel.Size = new System.Drawing.Size(79, 26);
            lugarLabel.TabIndex = 23;
            lugarLabel.Text = "Lugar:";
            // 
            // BotonEliminarRegistro
            // 
            this.BotonEliminarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonEliminarRegistro.Location = new System.Drawing.Point(229, 399);
            this.BotonEliminarRegistro.Name = "BotonEliminarRegistro";
            this.BotonEliminarRegistro.Size = new System.Drawing.Size(150, 35);
            this.BotonEliminarRegistro.TabIndex = 5;
            this.BotonEliminarRegistro.Text = "Eliminar Registro";
            this.BotonEliminarRegistro.UseVisualStyleBackColor = true;
            this.BotonEliminarRegistro.Click += new System.EventHandler(this.BotonEliminarRegistro_Click);
            // 
            // BotonInsertarRegistro
            // 
            this.BotonInsertarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonInsertarRegistro.Location = new System.Drawing.Point(589, 399);
            this.BotonInsertarRegistro.Name = "BotonInsertarRegistro";
            this.BotonInsertarRegistro.Size = new System.Drawing.Size(150, 35);
            this.BotonInsertarRegistro.TabIndex = 4;
            this.BotonInsertarRegistro.Text = "Insertar Registro";
            this.BotonInsertarRegistro.UseVisualStyleBackColor = true;
            this.BotonInsertarRegistro.Click += new System.EventHandler(this.BotonInsertarRegistro_Click);
            // 
            // BotonNuevoRegistro
            // 
            this.BotonNuevoRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonNuevoRegistro.Location = new System.Drawing.Point(387, 39);
            this.BotonNuevoRegistro.Name = "BotonNuevoRegistro";
            this.BotonNuevoRegistro.Size = new System.Drawing.Size(147, 35);
            this.BotonNuevoRegistro.TabIndex = 3;
            this.BotonNuevoRegistro.Text = "Nuevo Registro";
            this.BotonNuevoRegistro.UseVisualStyleBackColor = true;
            this.BotonNuevoRegistro.Click += new System.EventHandler(this.BotonNuevoRegistro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 71);
            this.label1.TabIndex = 7;
            this.label1.Text = "GRUPOS";
            // 
            // id_GrupoTextBox
            // 
            this.id_GrupoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "Id Grupo", true));
            this.id_GrupoTextBox.Location = new System.Drawing.Point(58, 50);
            this.id_GrupoTextBox.Name = "id_GrupoTextBox";
            this.id_GrupoTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_GrupoTextBox.TabIndex = 10;
            // 
            // grupoBindingSource
            // 
            this.grupoBindingSource.DataMember = "Grupo";
            this.grupoBindingSource.DataSource = this.equipo_2Final_6DataSet;
            // 
            // equipo_2Final_6DataSet
            // 
            this.equipo_2Final_6DataSet.DataSetName = "Equipo_2Final_6DataSet";
            this.equipo_2Final_6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(289, 171);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(163, 23);
            this.nombreTextBox.TabIndex = 12;
            // 
            // descripcíonTextBox
            // 
            this.descripcíonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "Descripcíon", true));
            this.descripcíonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcíonTextBox.Location = new System.Drawing.Point(623, 165);
            this.descripcíonTextBox.Multiline = true;
            this.descripcíonTextBox.Name = "descripcíonTextBox";
            this.descripcíonTextBox.Size = new System.Drawing.Size(206, 173);
            this.descripcíonTextBox.TabIndex = 14;
            // 
            // persona_a_cargoTextBox
            // 
            this.persona_a_cargoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "Persona a cargo", true));
            this.persona_a_cargoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persona_a_cargoTextBox.Location = new System.Drawing.Point(289, 197);
            this.persona_a_cargoTextBox.Name = "persona_a_cargoTextBox";
            this.persona_a_cargoTextBox.Size = new System.Drawing.Size(163, 23);
            this.persona_a_cargoTextBox.TabIndex = 16;
            // 
            // hora_de_inicioTextBox
            // 
            this.hora_de_inicioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "Hora de inicio", true));
            this.hora_de_inicioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora_de_inicioTextBox.Location = new System.Drawing.Point(289, 224);
            this.hora_de_inicioTextBox.Name = "hora_de_inicioTextBox";
            this.hora_de_inicioTextBox.Size = new System.Drawing.Size(163, 23);
            this.hora_de_inicioTextBox.TabIndex = 18;
            // 
            // díasTextBox
            // 
            this.díasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "Días", true));
            this.díasTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.díasTextBox.Location = new System.Drawing.Point(289, 250);
            this.díasTextBox.Name = "díasTextBox";
            this.díasTextBox.Size = new System.Drawing.Size(163, 23);
            this.díasTextBox.TabIndex = 20;
            // 
            // duraciónTextBox
            // 
            this.duraciónTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "Duración", true));
            this.duraciónTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duraciónTextBox.Location = new System.Drawing.Point(289, 276);
            this.duraciónTextBox.Name = "duraciónTextBox";
            this.duraciónTextBox.Size = new System.Drawing.Size(163, 23);
            this.duraciónTextBox.TabIndex = 22;
            // 
            // lugarTextBox
            // 
            this.lugarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "Lugar", true));
            this.lugarTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lugarTextBox.Location = new System.Drawing.Point(289, 302);
            this.lugarTextBox.Name = "lugarTextBox";
            this.lugarTextBox.Size = new System.Drawing.Size(163, 23);
            this.lugarTextBox.TabIndex = 24;
            // 
            // BotonPersonaSiguiente
            // 
            this.BotonPersonaSiguiente.BackgroundImage = global::Practicas_Profesionalizantes_II___APAPED.Properties.Resources.sig;
            this.BotonPersonaSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonPersonaSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonPersonaSiguiente.Location = new System.Drawing.Point(841, 34);
            this.BotonPersonaSiguiente.Name = "BotonPersonaSiguiente";
            this.BotonPersonaSiguiente.Size = new System.Drawing.Size(77, 70);
            this.BotonPersonaSiguiente.TabIndex = 42;
            this.BotonPersonaSiguiente.UseVisualStyleBackColor = true;
            this.BotonPersonaSiguiente.Click += new System.EventHandler(this.BotonPersonaSiguiente_Click);
            // 
            // BotonPersonaAnterior
            // 
            this.BotonPersonaAnterior.BackgroundImage = global::Practicas_Profesionalizantes_II___APAPED.Properties.Resources.ant;
            this.BotonPersonaAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonPersonaAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonPersonaAnterior.Location = new System.Drawing.Point(752, 34);
            this.BotonPersonaAnterior.Name = "BotonPersonaAnterior";
            this.BotonPersonaAnterior.Size = new System.Drawing.Size(77, 70);
            this.BotonPersonaAnterior.TabIndex = 41;
            this.BotonPersonaAnterior.UseVisualStyleBackColor = true;
            this.BotonPersonaAnterior.Click += new System.EventHandler(this.BotonPersonaAnterior_Click);
            // 
            // BotonModificarRegistro
            // 
            this.BotonModificarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonModificarRegistro.Location = new System.Drawing.Point(549, 39);
            this.BotonModificarRegistro.Name = "BotonModificarRegistro";
            this.BotonModificarRegistro.Size = new System.Drawing.Size(150, 35);
            this.BotonModificarRegistro.TabIndex = 43;
            this.BotonModificarRegistro.Text = "Modificar Registro";
            this.BotonModificarRegistro.UseVisualStyleBackColor = true;
            this.BotonModificarRegistro.Click += new System.EventHandler(this.BotonModificarRegistro_Click);
            // 
            // BotonGuardarRegistro
            // 
            this.BotonGuardarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonGuardarRegistro.Location = new System.Drawing.Point(47, 399);
            this.BotonGuardarRegistro.Name = "BotonGuardarRegistro";
            this.BotonGuardarRegistro.Size = new System.Drawing.Size(150, 35);
            this.BotonGuardarRegistro.TabIndex = 44;
            this.BotonGuardarRegistro.Text = "Guardar Registro";
            this.BotonGuardarRegistro.UseVisualStyleBackColor = true;
            this.BotonGuardarRegistro.Click += new System.EventHandler(this.BotonGuardarRegistro_Click);
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCancelar.Location = new System.Drawing.Point(415, 399);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(150, 35);
            this.BotonCancelar.TabIndex = 45;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // grupoTableAdapter
            // 
            this.grupoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Grupo_PersonaTableAdapter = null;
            this.tableAdapterManager.GrupoTableAdapter = this.grupoTableAdapter;
            this.tableAdapterManager.Personas_con_discapacidadTableAdapter = null;
            this.tableAdapterManager.TutorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Practicas_Profesionalizantes_II___APAPED.Equipo_2Final_6DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Usuarios_NivelTableAdapter = null;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btn_print
            // 
            this.btn_print.BackgroundImage = global::Practicas_Profesionalizantes_II___APAPED.Properties.Resources.imprimir;
            this.btn_print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(817, 399);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(71, 59);
            this.btn_print.TabIndex = 46;
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(425, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(448, 446);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 65;
            this.pictureBox2.TabStop = false;
            // 
            // Nuevo_Grupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 495);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonGuardarRegistro);
            this.Controls.Add(this.BotonModificarRegistro);
            this.Controls.Add(this.BotonPersonaSiguiente);
            this.Controls.Add(this.BotonPersonaAnterior);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(descripcíonLabel);
            this.Controls.Add(this.descripcíonTextBox);
            this.Controls.Add(persona_a_cargoLabel);
            this.Controls.Add(this.persona_a_cargoTextBox);
            this.Controls.Add(hora_de_inicioLabel);
            this.Controls.Add(this.hora_de_inicioTextBox);
            this.Controls.Add(díasLabel);
            this.Controls.Add(this.díasTextBox);
            this.Controls.Add(duraciónLabel);
            this.Controls.Add(this.duraciónTextBox);
            this.Controls.Add(lugarLabel);
            this.Controls.Add(this.lugarTextBox);
            this.Controls.Add(this.BotonEliminarRegistro);
            this.Controls.Add(this.BotonInsertarRegistro);
            this.Controls.Add(this.BotonNuevoRegistro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_GrupoTextBox);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(941, 534);
            this.MinimumSize = new System.Drawing.Size(941, 534);
            this.Name = "Nuevo_Grupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Control de Personas ";
            this.Load += new System.EventHandler(this.Nuevo_Grupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipo_2Final_6DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonEliminarRegistro;
        private System.Windows.Forms.Button BotonInsertarRegistro;
        private System.Windows.Forms.Button BotonNuevoRegistro;
        private System.Windows.Forms.Label label1;
        private Equipo_2Final_6DataSet equipo_2Final_6DataSet;
        private System.Windows.Forms.BindingSource grupoBindingSource;
        private Equipo_2Final_6DataSetTableAdapters.GrupoTableAdapter grupoTableAdapter;
        private Equipo_2Final_6DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox id_GrupoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox descripcíonTextBox;
        private System.Windows.Forms.TextBox persona_a_cargoTextBox;
        private System.Windows.Forms.TextBox hora_de_inicioTextBox;
        private System.Windows.Forms.TextBox díasTextBox;
        private System.Windows.Forms.TextBox duraciónTextBox;
        private System.Windows.Forms.TextBox lugarTextBox;
        private System.Windows.Forms.Button BotonPersonaSiguiente;
        private System.Windows.Forms.Button BotonPersonaAnterior;
        private System.Windows.Forms.Button BotonModificarRegistro;
        private System.Windows.Forms.Button BotonGuardarRegistro;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}