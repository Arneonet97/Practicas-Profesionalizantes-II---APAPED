namespace Practicas_Profesionalizantes_II___APAPED.Consulta
{
    partial class Persona_en_grupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Persona_en_grupo));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.equipo_2Final_6DataSet = new Practicas_Profesionalizantes_II___APAPED.Equipo_2Final_6DataSet();
            this.grupo_PersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupo_PersonaTableAdapter = new Practicas_Profesionalizantes_II___APAPED.Equipo_2Final_6DataSetTableAdapters.Grupo_PersonaTableAdapter();
            this.tableAdapterManager = new Practicas_Profesionalizantes_II___APAPED.Equipo_2Final_6DataSetTableAdapters.TableAdapterManager();
            this.btnfiltrar = new System.Windows.Forms.Button();
            this.btnfinalizarbusqueda = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboFiltrarGrupo = new System.Windows.Forms.ComboBox();
            this.txtBuscarPersona = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipo_2Final_6DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupo_PersonaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 45;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(388, 486);
            this.dataGridView1.TabIndex = 44;
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
            // btnfiltrar
            // 
            this.btnfiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfiltrar.Location = new System.Drawing.Point(427, 415);
            this.btnfiltrar.Name = "btnfiltrar";
            this.btnfiltrar.Size = new System.Drawing.Size(76, 34);
            this.btnfiltrar.TabIndex = 67;
            this.btnfiltrar.Text = "Filtrar";
            this.btnfiltrar.UseVisualStyleBackColor = true;
            this.btnfiltrar.Click += new System.EventHandler(this.btnfiltrar_Click);
            // 
            // btnfinalizarbusqueda
            // 
            this.btnfinalizarbusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfinalizarbusqueda.Location = new System.Drawing.Point(622, 415);
            this.btnfinalizarbusqueda.Name = "btnfinalizarbusqueda";
            this.btnfinalizarbusqueda.Size = new System.Drawing.Size(76, 34);
            this.btnfinalizarbusqueda.TabIndex = 66;
            this.btnfinalizarbusqueda.Text = "Salir";
            this.btnfinalizarbusqueda.UseVisualStyleBackColor = true;
            this.btnfinalizarbusqueda.Click += new System.EventHandler(this.btnfinalizarbusqueda_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 20);
            this.label2.TabIndex = 64;
            this.label2.Text = "NOMBRE DEL GRUPO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "NOMBRE DE LA PERSONA";
            // 
            // comboFiltrarGrupo
            // 
            this.comboFiltrarGrupo.FormattingEnabled = true;
            this.comboFiltrarGrupo.Location = new System.Drawing.Point(479, 330);
            this.comboFiltrarGrupo.Name = "comboFiltrarGrupo";
            this.comboFiltrarGrupo.Size = new System.Drawing.Size(248, 21);
            this.comboFiltrarGrupo.TabIndex = 62;
            // 
            // txtBuscarPersona
            // 
            this.txtBuscarPersona.Location = new System.Drawing.Point(481, 189);
            this.txtBuscarPersona.Name = "txtBuscarPersona";
            this.txtBuscarPersona.Size = new System.Drawing.Size(248, 20);
            this.txtBuscarPersona.TabIndex = 61;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Practicas_Profesionalizantes_II___APAPED.Properties.Resources.imprimir;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(480, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 62);
            this.button2.TabIndex = 42;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Practicas_Profesionalizantes_II___APAPED.Properties.Resources.borrar__2_;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(666, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 62);
            this.button3.TabIndex = 68;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::Practicas_Profesionalizantes_II___APAPED.Properties.Resources.busqueda;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(575, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(62, 62);
            this.btnBuscar.TabIndex = 46;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Persona_en_grupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 487);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnfiltrar);
            this.Controls.Add(this.btnfinalizarbusqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboFiltrarGrupo);
            this.Controls.Add(this.txtBuscarPersona);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(803, 526);
            this.MinimumSize = new System.Drawing.Size(803, 526);
            this.Name = "Persona_en_grupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Control de Personas ";
            this.Load += new System.EventHandler(this.Persona_en_grupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipo_2Final_6DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupo_PersonaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Equipo_2Final_6DataSet equipo_2Final_6DataSet;
        private System.Windows.Forms.BindingSource grupo_PersonaBindingSource;
        private Equipo_2Final_6DataSetTableAdapters.Grupo_PersonaTableAdapter grupo_PersonaTableAdapter;
        private Equipo_2Final_6DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnfiltrar;
        private System.Windows.Forms.Button btnfinalizarbusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboFiltrarGrupo;
        private System.Windows.Forms.TextBox txtBuscarPersona;
        private System.Windows.Forms.Button button3;
    }
}