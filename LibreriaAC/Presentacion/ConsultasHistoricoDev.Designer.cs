namespace Presentacion
{
    partial class ConsultasHistoricoDev
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
            this.DEVM_EDI_CODIGO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EDI_EDITORIAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEVM_FECHA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEVM_OBS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEVM_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancelar64;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(307, 383);
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
            this.btnseleccionado.Location = new System.Drawing.Point(168, 383);
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
            this.gConsulta.Size = new System.Drawing.Size(546, 335);
            this.gConsulta.TabIndex = 195;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            // 
            // gridViewPintarFilas
            // 
            this.gridViewPintarFilas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DEVM_EDI_CODIGO,
            this.EDI_EDITORIAL,
            this.DEVM_FECHA,
            this.DEVM_OBS,
            this.DEVM_IDE});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            // 
            // DEVM_EDI_CODIGO
            // 
            this.DEVM_EDI_CODIGO.Caption = "Código";
            this.DEVM_EDI_CODIGO.FieldName = "DEVM_EDI_CODIGO";
            this.DEVM_EDI_CODIGO.MaxWidth = 70;
            this.DEVM_EDI_CODIGO.MinWidth = 70;
            this.DEVM_EDI_CODIGO.Name = "DEVM_EDI_CODIGO";
            this.DEVM_EDI_CODIGO.Visible = true;
            this.DEVM_EDI_CODIGO.VisibleIndex = 0;
            this.DEVM_EDI_CODIGO.Width = 70;
            // 
            // EDI_EDITORIAL
            // 
            this.EDI_EDITORIAL.Caption = "Editorial";
            this.EDI_EDITORIAL.FieldName = "EDI_EDITORIAL";
            this.EDI_EDITORIAL.MaxWidth = 300;
            this.EDI_EDITORIAL.MinWidth = 300;
            this.EDI_EDITORIAL.Name = "EDI_EDITORIAL";
            this.EDI_EDITORIAL.Visible = true;
            this.EDI_EDITORIAL.VisibleIndex = 1;
            this.EDI_EDITORIAL.Width = 300;
            // 
            // DEVM_FECHA
            // 
            this.DEVM_FECHA.Caption = "Fecha";
            this.DEVM_FECHA.FieldName = "DEVM_FECHA";
            this.DEVM_FECHA.MaxWidth = 70;
            this.DEVM_FECHA.MinWidth = 70;
            this.DEVM_FECHA.Name = "DEVM_FECHA";
            this.DEVM_FECHA.Visible = true;
            this.DEVM_FECHA.VisibleIndex = 2;
            this.DEVM_FECHA.Width = 70;
            // 
            // DEVM_OBS
            // 
            this.DEVM_OBS.Caption = "Observación";
            this.DEVM_OBS.FieldName = "DEVM_OBS";
            this.DEVM_OBS.MaxWidth = 70;
            this.DEVM_OBS.MinWidth = 70;
            this.DEVM_OBS.Name = "DEVM_OBS";
            this.DEVM_OBS.Visible = true;
            this.DEVM_OBS.VisibleIndex = 3;
            this.DEVM_OBS.Width = 70;
            // 
            // DEVM_IDE
            // 
            this.DEVM_IDE.Caption = "DEVM_IDE";
            this.DEVM_IDE.FieldName = "DEVM_IDE";
            this.DEVM_IDE.MaxWidth = 90;
            this.DEVM_IDE.MinWidth = 90;
            this.DEVM_IDE.Name = "DEVM_IDE";
            this.DEVM_IDE.Width = 90;
            // 
            // ConsultasHistoricoDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 482);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnseleccionado);
            this.Controls.Add(this.gConsulta);
            this.Name = "ConsultasHistoricoDev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico de devoluciones";
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
        private DevExpress.XtraGrid.Columns.GridColumn DEVM_EDI_CODIGO;
        private DevExpress.XtraGrid.Columns.GridColumn EDI_EDITORIAL;
        private DevExpress.XtraGrid.Columns.GridColumn DEVM_FECHA;
        private DevExpress.XtraGrid.Columns.GridColumn DEVM_OBS;
        private DevExpress.XtraGrid.Columns.GridColumn DEVM_IDE;
    }
}