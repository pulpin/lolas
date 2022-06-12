namespace Presentacion
{
    partial class ConsultaVentasProduc
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
            this.VEND_LI_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEND_CANTIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btncancelar = new System.Windows.Forms.Button();
            this.VEND_IMPORTEIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEND_VALORIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEND_IMPORTE = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            this.SuspendLayout();
            // 
            // gConsulta
            // 
            this.gConsulta.Location = new System.Drawing.Point(12, 12);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(761, 351);
            this.gConsulta.TabIndex = 1;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            this.gConsulta.DoubleClick += new System.EventHandler(this.gConsulta_DoubleClick);
            // 
            // gridViewPintarFilas
            // 
            this.gridViewPintarFilas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.VEND_LI_IDE,
            this.LI_DESC,
            this.VEND_CANTIDAD,
            this.VEND_IMPORTEIVA,
            this.VEND_VALORIVA,
            this.VEND_IMPORTE});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            // 
            // VEND_LI_IDE
            // 
            this.VEND_LI_IDE.Caption = "Código";
            this.VEND_LI_IDE.FieldName = "VEND_LI_IDE";
            this.VEND_LI_IDE.MaxWidth = 90;
            this.VEND_LI_IDE.MinWidth = 90;
            this.VEND_LI_IDE.Name = "VEND_LI_IDE";
            this.VEND_LI_IDE.Visible = true;
            this.VEND_LI_IDE.VisibleIndex = 0;
            this.VEND_LI_IDE.Width = 90;
            // 
            // LI_DESC
            // 
            this.LI_DESC.Caption = "Descripción";
            this.LI_DESC.FieldName = "LI_DESC";
            this.LI_DESC.Name = "LI_DESC";
            this.LI_DESC.Visible = true;
            this.LI_DESC.VisibleIndex = 1;
            // 
            // VEND_CANTIDAD
            // 
            this.VEND_CANTIDAD.Caption = "Cantidad";
            this.VEND_CANTIDAD.FieldName = "VEND_CANTIDAD";
            this.VEND_CANTIDAD.Name = "VEND_CANTIDAD";
            this.VEND_CANTIDAD.Visible = true;
            this.VEND_CANTIDAD.VisibleIndex = 2;
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancelar32;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(700, 372);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(73, 59);
            this.btncancelar.TabIndex = 12;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // VEND_IMPORTEIVA
            // 
            this.VEND_IMPORTEIVA.Caption = "Importe";
            this.VEND_IMPORTEIVA.FieldName = "VEND_IMPORTEIVA";
            this.VEND_IMPORTEIVA.Name = "VEND_IMPORTEIVA";
            this.VEND_IMPORTEIVA.Visible = true;
            this.VEND_IMPORTEIVA.VisibleIndex = 3;
            // 
            // VEND_VALORIVA
            // 
            this.VEND_VALORIVA.Caption = "IVA";
            this.VEND_VALORIVA.FieldName = "VEND_VALORIVA";
            this.VEND_VALORIVA.Name = "VEND_VALORIVA";
            this.VEND_VALORIVA.Visible = true;
            this.VEND_VALORIVA.VisibleIndex = 4;
            // 
            // VEND_IMPORTE
            // 
            this.VEND_IMPORTE.Caption = "Total";
            this.VEND_IMPORTE.FieldName = "VEND_IMPORTE";
            this.VEND_IMPORTE.Name = "VEND_IMPORTE";
            this.VEND_IMPORTE.Visible = true;
            this.VEND_IMPORTE.VisibleIndex = 5;
            // 
            // ConsultaVentasProduc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 443);
            this.ControlBox = false;
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.gConsulta);
            this.Name = "ConsultaVentasProduc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas detalle...";
            this.Load += new System.EventHandler(this.ConsultaInteres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private DevExpress.XtraGrid.Columns.GridColumn VEND_LI_IDE;
        private System.Windows.Forms.Button btncancelar;
        private DevExpress.XtraGrid.Columns.GridColumn LI_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn VEND_CANTIDAD;
        private DevExpress.XtraGrid.Columns.GridColumn VEND_IMPORTEIVA;
        private DevExpress.XtraGrid.Columns.GridColumn VEND_VALORIVA;
        private DevExpress.XtraGrid.Columns.GridColumn VEND_IMPORTE;
    }
}