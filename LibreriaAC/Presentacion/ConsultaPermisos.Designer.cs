namespace Presentacion
{
    partial class ConsultaPermisos
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
            this.gConsulta = new DevExpress.XtraGrid.GridControl();
            this.gridViewPintarFilas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.menu_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.per_acceder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.per_modificar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.menu_ide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.menu_prog_ide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.menu_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // gConsulta
            // 
            this.gConsulta.Location = new System.Drawing.Point(12, 29);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2});
            this.gConsulta.Size = new System.Drawing.Size(674, 387);
            this.gConsulta.TabIndex = 226;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            // 
            // gridViewPintarFilas
            // 
            this.gridViewPintarFilas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.menu_nombre,
            this.per_acceder,
            this.per_modificar,
            this.menu_ide,
            this.menu_prog_ide,
            this.menu_descripcion});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            // 
            // menu_nombre
            // 
            this.menu_nombre.Caption = "Menú";
            this.menu_nombre.FieldName = "menu_nombre";
            this.menu_nombre.Name = "menu_nombre";
            this.menu_nombre.OptionsColumn.AllowEdit = false;
            this.menu_nombre.Visible = true;
            this.menu_nombre.VisibleIndex = 0;
            // 
            // per_acceder
            // 
            this.per_acceder.Caption = "Acceder";
            this.per_acceder.ColumnEdit = this.repositoryItemCheckEdit1;
            this.per_acceder.FieldName = "per_acceder";
            this.per_acceder.MaxWidth = 50;
            this.per_acceder.MinWidth = 50;
            this.per_acceder.Name = "per_acceder";
            this.per_acceder.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.per_acceder.Visible = true;
            this.per_acceder.VisibleIndex = 1;
            this.per_acceder.Width = 50;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // per_modificar
            // 
            this.per_modificar.Caption = "Modificar";
            this.per_modificar.ColumnEdit = this.repositoryItemCheckEdit2;
            this.per_modificar.FieldName = "per_modificar";
            this.per_modificar.MaxWidth = 65;
            this.per_modificar.MinWidth = 65;
            this.per_modificar.Name = "per_modificar";
            this.per_modificar.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.per_modificar.Visible = true;
            this.per_modificar.VisibleIndex = 2;
            this.per_modificar.Width = 65;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // menu_ide
            // 
            this.menu_ide.Caption = "menu_ide";
            this.menu_ide.FieldName = "menu_ide";
            this.menu_ide.Name = "menu_ide";
            // 
            // menu_prog_ide
            // 
            this.menu_prog_ide.Caption = "menu_prog_ide";
            this.menu_prog_ide.FieldName = "menu_prog_ide";
            this.menu_prog_ide.Name = "menu_prog_ide";
            // 
            // button1
            // 
            this.button1.Image = global::Presentacion.Properties.Resources.cancelar64;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(315, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 79);
            this.button1.TabIndex = 228;
            this.button1.Text = "Cancelar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Image = global::Presentacion.Properties.Resources.guardar64;
            this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnagregar.Location = new System.Drawing.Point(179, 434);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(102, 79);
            this.btnagregar.TabIndex = 227;
            this.btnagregar.Text = "Guardar";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click_1);
            // 
            // menu_descripcion
            // 
            this.menu_descripcion.Caption = "Observación";
            this.menu_descripcion.FieldName = "menu_descripcion";
            this.menu_descripcion.Name = "menu_descripcion";
            this.menu_descripcion.Visible = true;
            this.menu_descripcion.VisibleIndex = 3;
            // 
            // ConsultaPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 525);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.gConsulta);
            this.Name = "ConsultaPermisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.ConsultaInteres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private DevExpress.XtraGrid.Columns.GridColumn menu_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn per_acceder;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn per_modificar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnagregar;
        private DevExpress.XtraGrid.Columns.GridColumn menu_ide;
        private DevExpress.XtraGrid.Columns.GridColumn menu_prog_ide;
        private DevExpress.XtraGrid.Columns.GridColumn menu_descripcion;
    }
}