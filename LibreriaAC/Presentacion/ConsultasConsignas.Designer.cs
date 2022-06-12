namespace Presentacion
{
    partial class ConsultasConsignas
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
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnseleccionado = new System.Windows.Forms.Button();
            this.gConsulta = new DevExpress.XtraGrid.GridControl();
            this.gridViewPintarFilas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CONMA_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CONMA_EDI_CODIGO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EDI_EDITORIAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CONMA_FECENVIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CONMA_FECRECEPCION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CONMA_REMITO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnagregacon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancelar64;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(488, 380);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(102, 87);
            this.btncancelar.TabIndex = 197;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnseleccionado
            // 
            this.btnseleccionado.Image = global::Presentacion.Properties.Resources.editar64;
            this.btnseleccionado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnseleccionado.Location = new System.Drawing.Point(349, 380);
            this.btnseleccionado.Name = "btnseleccionado";
            this.btnseleccionado.Size = new System.Drawing.Size(102, 87);
            this.btnseleccionado.TabIndex = 196;
            this.btnseleccionado.Text = "Seleccionar";
            this.btnseleccionado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnseleccionado.UseVisualStyleBackColor = true;
            this.btnseleccionado.Click += new System.EventHandler(this.btnseleccionado_Click);
            // 
            // gConsulta
            // 
            this.gConsulta.Location = new System.Drawing.Point(12, 71);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(772, 295);
            this.gConsulta.TabIndex = 195;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            // 
            // gridViewPintarFilas
            // 
            this.gridViewPintarFilas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CONMA_IDE,
            this.CONMA_EDI_CODIGO,
            this.EDI_EDITORIAL,
            this.CONMA_FECENVIO,
            this.CONMA_FECRECEPCION,
            this.CONMA_REMITO});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            // 
            // CONMA_IDE
            // 
            this.CONMA_IDE.Caption = "Consigna";
            this.CONMA_IDE.FieldName = "CONMA_IDE";
            this.CONMA_IDE.MaxWidth = 70;
            this.CONMA_IDE.MinWidth = 70;
            this.CONMA_IDE.Name = "CONMA_IDE";
            this.CONMA_IDE.Visible = true;
            this.CONMA_IDE.VisibleIndex = 0;
            this.CONMA_IDE.Width = 70;
            // 
            // CONMA_EDI_CODIGO
            // 
            this.CONMA_EDI_CODIGO.Caption = "Código";
            this.CONMA_EDI_CODIGO.FieldName = "CONMA_EDI_CODIGO";
            this.CONMA_EDI_CODIGO.MaxWidth = 130;
            this.CONMA_EDI_CODIGO.MinWidth = 130;
            this.CONMA_EDI_CODIGO.Name = "CONMA_EDI_CODIGO";
            this.CONMA_EDI_CODIGO.Visible = true;
            this.CONMA_EDI_CODIGO.VisibleIndex = 1;
            this.CONMA_EDI_CODIGO.Width = 130;
            // 
            // EDI_EDITORIAL
            // 
            this.EDI_EDITORIAL.Caption = "Editorial";
            this.EDI_EDITORIAL.FieldName = "EDI_EDITORIAL";
            this.EDI_EDITORIAL.MaxWidth = 300;
            this.EDI_EDITORIAL.MinWidth = 300;
            this.EDI_EDITORIAL.Name = "EDI_EDITORIAL";
            this.EDI_EDITORIAL.Visible = true;
            this.EDI_EDITORIAL.VisibleIndex = 2;
            this.EDI_EDITORIAL.Width = 300;
            // 
            // CONMA_FECENVIO
            // 
            this.CONMA_FECENVIO.Caption = "Envío";
            this.CONMA_FECENVIO.FieldName = "CONMA_FECENVIO";
            this.CONMA_FECENVIO.MaxWidth = 70;
            this.CONMA_FECENVIO.MinWidth = 70;
            this.CONMA_FECENVIO.Name = "CONMA_FECENVIO";
            this.CONMA_FECENVIO.Visible = true;
            this.CONMA_FECENVIO.VisibleIndex = 3;
            this.CONMA_FECENVIO.Width = 70;
            // 
            // CONMA_FECRECEPCION
            // 
            this.CONMA_FECRECEPCION.Caption = "Recepción";
            this.CONMA_FECRECEPCION.FieldName = "CONMA_FECRECEPCION";
            this.CONMA_FECRECEPCION.MaxWidth = 70;
            this.CONMA_FECRECEPCION.MinWidth = 70;
            this.CONMA_FECRECEPCION.Name = "CONMA_FECRECEPCION";
            this.CONMA_FECRECEPCION.Visible = true;
            this.CONMA_FECRECEPCION.VisibleIndex = 4;
            this.CONMA_FECRECEPCION.Width = 70;
            // 
            // CONMA_REMITO
            // 
            this.CONMA_REMITO.Caption = "Remito";
            this.CONMA_REMITO.FieldName = "CONMA_REMITO";
            this.CONMA_REMITO.MaxWidth = 90;
            this.CONMA_REMITO.MinWidth = 90;
            this.CONMA_REMITO.Name = "CONMA_REMITO";
            this.CONMA_REMITO.Visible = true;
            this.CONMA_REMITO.VisibleIndex = 5;
            this.CONMA_REMITO.Width = 90;
            // 
            // btnagregacon
            // 
            this.btnagregacon.Image = global::Presentacion.Properties.Resources.agrega64;
            this.btnagregacon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnagregacon.Location = new System.Drawing.Point(210, 380);
            this.btnagregacon.Name = "btnagregacon";
            this.btnagregacon.Size = new System.Drawing.Size(102, 87);
            this.btnagregacon.TabIndex = 199;
            this.btnagregacon.Text = "Nueva consigna";
            this.btnagregacon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnagregacon.UseVisualStyleBackColor = true;
            this.btnagregacon.Click += new System.EventHandler(this.btnagregacon_Click);
            // 
            // ConsultasConsignas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 482);
            this.Controls.Add(this.btnagregacon);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnseleccionado);
            this.Controls.Add(this.gConsulta);
            this.Name = "ConsultasConsignas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.ConsultasConsignas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnseleccionado;
        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private DevExpress.XtraGrid.Columns.GridColumn CONMA_IDE;
        private DevExpress.XtraGrid.Columns.GridColumn CONMA_EDI_CODIGO;
        private DevExpress.XtraGrid.Columns.GridColumn EDI_EDITORIAL;
        private DevExpress.XtraGrid.Columns.GridColumn CONMA_FECENVIO;
        private DevExpress.XtraGrid.Columns.GridColumn CONMA_FECRECEPCION;
        private DevExpress.XtraGrid.Columns.GridColumn CONMA_REMITO;
        private System.Windows.Forms.Button btnagregacon;
    }
}