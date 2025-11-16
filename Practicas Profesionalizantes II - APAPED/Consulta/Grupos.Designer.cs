namespace Practicas_Profesionalizantes_II___APAPED.Consulta
{
    partial class Grupos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grupos));
            this.equipo_2Final_6DataSet = new Practicas_Profesionalizantes_II___APAPED.Equipo_2Final_6DataSet();
            this.gruposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gruposTableAdapter = new Practicas_Profesionalizantes_II___APAPED.Equipo_2Final_6DataSetTableAdapters.GruposTableAdapter();
            this.tableAdapterManager = new Practicas_Profesionalizantes_II___APAPED.Equipo_2Final_6DataSetTableAdapters.TableAdapterManager();
            this.gruposDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.equipo_2Final_6DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // equipo_2Final_6DataSet
            // 
            this.equipo_2Final_6DataSet.DataSetName = "Equipo_2Final_6DataSet";
            this.equipo_2Final_6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gruposBindingSource
            // 
            this.gruposBindingSource.DataMember = "Grupos";
            this.gruposBindingSource.DataSource = this.equipo_2Final_6DataSet;
            // 
            // gruposTableAdapter
            // 
            this.gruposTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Grupo_PersonaTableAdapter = null;
            this.tableAdapterManager.GrupoTableAdapter = null;
            this.tableAdapterManager.Personas_con_discapacidadTableAdapter = null;
            this.tableAdapterManager.TutorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Practicas_Profesionalizantes_II___APAPED.Equipo_2Final_6DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Usuarios_NivelTableAdapter = null;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // gruposDataGridView
            // 
            this.gruposDataGridView.AllowUserToAddRows = false;
            this.gruposDataGridView.AllowUserToDeleteRows = false;
            this.gruposDataGridView.AutoGenerateColumns = false;
            this.gruposDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gruposDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.gruposDataGridView.DataSource = this.gruposBindingSource;
            this.gruposDataGridView.Location = new System.Drawing.Point(0, 0);
            this.gruposDataGridView.Name = "gruposDataGridView";
            this.gruposDataGridView.ReadOnly = true;
            this.gruposDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gruposDataGridView.Size = new System.Drawing.Size(375, 449);
            this.gruposDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descripcíon";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripcíon";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Practicas_Profesionalizantes_II___APAPED.Properties.Resources.imprimir;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(307, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 55);
            this.button2.TabIndex = 41;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Grupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 451);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gruposDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(394, 490);
            this.MinimumSize = new System.Drawing.Size(394, 490);
            this.Name = "Grupos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Control de Personas ";
            this.Load += new System.EventHandler(this.Grupos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipo_2Final_6DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Equipo_2Final_6DataSet equipo_2Final_6DataSet;
        private System.Windows.Forms.BindingSource gruposBindingSource;
        private Equipo_2Final_6DataSetTableAdapters.GruposTableAdapter gruposTableAdapter;
        private Equipo_2Final_6DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView gruposDataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}