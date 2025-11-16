namespace Practicas_Profesionalizantes_II___APAPED.Consulta
{
    partial class CUDs_vencidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CUDs_vencidos));
            this.button2 = new System.Windows.Forms.Button();
            this.equipo_2Final_6DataSet = new Practicas_Profesionalizantes_II___APAPED.Equipo_2Final_6DataSet();
            this.cUDS_vencidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUDS_vencidosTableAdapter = new Practicas_Profesionalizantes_II___APAPED.Equipo_2Final_6DataSetTableAdapters.CUDS_vencidosTableAdapter();
            this.tableAdapterManager = new Practicas_Profesionalizantes_II___APAPED.Equipo_2Final_6DataSetTableAdapters.TableAdapterManager();
            this.cUDS_vencidosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.equipo_2Final_6DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUDS_vencidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUDS_vencidosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Practicas_Profesionalizantes_II___APAPED.Properties.Resources.imprimir;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(281, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 50);
            this.button2.TabIndex = 42;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // equipo_2Final_6DataSet
            // 
            this.equipo_2Final_6DataSet.DataSetName = "Equipo_2Final_6DataSet";
            this.equipo_2Final_6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUDS_vencidosBindingSource
            // 
            this.cUDS_vencidosBindingSource.DataMember = "CUDS vencidos";
            this.cUDS_vencidosBindingSource.DataSource = this.equipo_2Final_6DataSet;
            // 
            // cUDS_vencidosTableAdapter
            // 
            this.cUDS_vencidosTableAdapter.ClearBeforeFill = true;
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
            // cUDS_vencidosDataGridView
            // 
            this.cUDS_vencidosDataGridView.AutoGenerateColumns = false;
            this.cUDS_vencidosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cUDS_vencidosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.cUDS_vencidosDataGridView.DataSource = this.cUDS_vencidosBindingSource;
            this.cUDS_vencidosDataGridView.Location = new System.Drawing.Point(2, 12);
            this.cUDS_vencidosDataGridView.Name = "cUDS_vencidosDataGridView";
            this.cUDS_vencidosDataGridView.Size = new System.Drawing.Size(343, 311);
            this.cUDS_vencidosDataGridView.TabIndex = 43;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Apellido";
            this.dataGridViewTextBoxColumn2.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "CUD vencido";
            this.dataGridViewCheckBoxColumn1.HeaderText = "CUD vencido";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // CUDs_vencidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 327);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cUDS_vencidosDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(362, 366);
            this.MinimumSize = new System.Drawing.Size(362, 366);
            this.Name = "CUDs_vencidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Control de Personas ";
            this.Load += new System.EventHandler(this.CUDs_vencidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipo_2Final_6DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUDS_vencidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUDS_vencidosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private Equipo_2Final_6DataSet equipo_2Final_6DataSet;
        private System.Windows.Forms.BindingSource cUDS_vencidosBindingSource;
        private Equipo_2Final_6DataSetTableAdapters.CUDS_vencidosTableAdapter cUDS_vencidosTableAdapter;
        private Equipo_2Final_6DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView cUDS_vencidosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}