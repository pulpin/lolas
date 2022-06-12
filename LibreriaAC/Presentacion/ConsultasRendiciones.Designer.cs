namespace Presentacion
{
    partial class ConsultasRendiciones
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
            this.PRENMA_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PRENMA_EDI_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EDI_EDITORIAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PRENMA_FECHA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PRENMA_DESDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PRENMA_HASTA = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.btnseleccionado.Text = "Ver libros";
            this.btnseleccionado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnseleccionado.UseVisualStyleBackColor = true;
            this.btnseleccionado.Click += new System.EventHandler(this.btnseleccionado_Click);
            // 
            // gConsulta
            // 
            this.gConsulta.Location = new System.Drawing.Point(12, 31);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(772, 335);
            this.gConsulta.TabIndex = 195;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            // 
            // gridViewPintarFilas
            // 
            this.gridViewPintarFilas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PRENMA_IDE,
            this.PRENMA_EDI_IDE,
            this.EDI_EDITORIAL,
            this.PRENMA_FECHA,
            this.PRENMA_DESDE,
            this.PRENMA_HASTA});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            // 
            // PRENMA_IDE
            // 
            this.PRENMA_IDE.Caption = "Rendición";
            this.PRENMA_IDE.FieldName = "PRENMA_IDE";
            this.PRENMA_IDE.MaxWidth = 70;
            this.PRENMA_IDE.MinWidth = 70;
            this.PRENMA_IDE.Name = "PRENMA_IDE";
            this.PRENMA_IDE.Visible = true;
            this.PRENMA_IDE.VisibleIndex = 0;
            this.PRENMA_IDE.Width = 70;
            // 
            // PRENMA_EDI_IDE
            // 
            this.PRENMA_EDI_IDE.Caption = "Código";
            this.PRENMA_EDI_IDE.FieldName = "PRENMA_EDI_IDE";
            this.PRENMA_EDI_IDE.MaxWidth = 130;
            this.PRENMA_EDI_IDE.MinWidth = 130;
            this.PRENMA_EDI_IDE.Name = "PRENMA_EDI_IDE";
            this.PRENMA_EDI_IDE.Visible = true;
            this.PRENMA_EDI_IDE.VisibleIndex = 1;
            this.PRENMA_EDI_IDE.Width = 130;
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
            // PRENMA_FECHA
            // 
            this.PRENMA_FECHA.Caption = "Fecha";
            this.PRENMA_FECHA.FieldName = "PRENMA_FECHA";
            this.PRENMA_FECHA.MaxWidth = 70;
            this.PRENMA_FECHA.MinWidth = 70;
            this.PRENMA_FECHA.Name = "PRENMA_FECHA";
            this.PRENMA_FECHA.Visible = true;
            this.PRENMA_FECHA.VisibleIndex = 3;
            this.PRENMA_FECHA.Width = 70;
            // 
            // PRENMA_DESDE
            // 
            this.PRENMA_DESDE.Caption = "Desde";
            this.PRENMA_DESDE.FieldName = "PRENMA_DESDE";
            this.PRENMA_DESDE.MaxWidth = 70;
            this.PRENMA_DESDE.MinWidth = 70;
            this.PRENMA_DESDE.Name = "PRENMA_DESDE";
            this.PRENMA_DESDE.Visible = true;
            this.PRENMA_DESDE.VisibleIndex = 4;
            this.PRENMA_DESDE.Width = 70;
            // 
            // PRENMA_HASTA
            // 
            this.PRENMA_HASTA.Caption = "Hasta";
            this.PRENMA_HASTA.FieldName = "PRENMA_HASTA";
            this.PRENMA_HASTA.MaxWidth = 90;
            this.PRENMA_HASTA.MinWidth = 90;
            this.PRENMA_HASTA.Name = "PRENMA_HASTA";
            this.PRENMA_HASTA.Visible = true;
            this.PRENMA_HASTA.VisibleIndex = 5;
            this.PRENMA_HASTA.Width = 90;
            // 
            // btnagregacon
            // 
            this.btnagregacon.Image = global::Presentacion.Properties.Resources.agrega64;
            this.btnagregacon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnagregacon.Location = new System.Drawing.Point(210, 380);
            this.btnagregacon.Name = "btnagregacon";
            this.btnagregacon.Size = new System.Drawing.Size(102, 87);
            this.btnagregacon.TabIndex = 199;
            this.btnagregacon.Text = "Nueva rendición";
            this.btnagregacon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnagregacon.UseVisualStyleBackColor = true;
            this.btnagregacon.Click += new System.EventHandler(this.btnagregacon_Click);
            // 
            // ConsultasRendiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 482);
            this.Controls.Add(this.btnagregacon);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnseleccionado);
            this.Controls.Add(this.gConsulta);
            this.Name = "ConsultasRendiciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas de rendiciones";
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
        private DevExpress.XtraGrid.Columns.GridColumn PRENMA_IDE;
        private DevExpress.XtraGrid.Columns.GridColumn PRENMA_EDI_IDE;
        private DevExpress.XtraGrid.Columns.GridColumn EDI_EDITORIAL;
        private DevExpress.XtraGrid.Columns.GridColumn PRENMA_FECHA;
        private DevExpress.XtraGrid.Columns.GridColumn PRENMA_DESDE;
        private DevExpress.XtraGrid.Columns.GridColumn PRENMA_HASTA;
        private System.Windows.Forms.Button btnagregacon;
    }
}