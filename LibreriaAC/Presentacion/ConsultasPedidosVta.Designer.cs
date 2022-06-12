namespace Presentacion
{
    partial class ConsultasPedidosVta
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
            this.gConsulta = new DevExpress.XtraGrid.GridControl();
            this.gridViewPintarFilas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.VEN_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_TIPOFACTU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_FECHA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_NOMBRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_TOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USU_NCOMPLETO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancelar32;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(596, 280);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(73, 59);
            this.btncancelar.TabIndex = 12;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // gConsulta
            // 
            this.gConsulta.Location = new System.Drawing.Point(31, 12);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(638, 262);
            this.gConsulta.TabIndex = 199;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            // 
            // gridViewPintarFilas
            // 
            this.gridViewPintarFilas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.VEN_IDE,
            this.VEN_TIPOFACTU,
            this.VEN_FECHA,
            this.VEN_NOMBRE,
            this.VEN_TOTAL,
            this.USU_NCOMPLETO});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Cantidad", null, "(Cantidad: Recuento={0})")});
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            // 
            // VEN_IDE
            // 
            this.VEN_IDE.Caption = "Número";
            this.VEN_IDE.FieldName = "VEN_IDE";
            this.VEN_IDE.MaxWidth = 80;
            this.VEN_IDE.MinWidth = 80;
            this.VEN_IDE.Name = "VEN_IDE";
            this.VEN_IDE.Visible = true;
            this.VEN_IDE.VisibleIndex = 0;
            this.VEN_IDE.Width = 80;
            // 
            // VEN_TIPOFACTU
            // 
            this.VEN_TIPOFACTU.Caption = "Tipo";
            this.VEN_TIPOFACTU.FieldName = "VEN_TIPOFACTU";
            this.VEN_TIPOFACTU.MaxWidth = 100;
            this.VEN_TIPOFACTU.MinWidth = 100;
            this.VEN_TIPOFACTU.Name = "VEN_TIPOFACTU";
            this.VEN_TIPOFACTU.Visible = true;
            this.VEN_TIPOFACTU.VisibleIndex = 1;
            this.VEN_TIPOFACTU.Width = 100;
            // 
            // VEN_FECHA
            // 
            this.VEN_FECHA.Caption = "Fecha";
            this.VEN_FECHA.FieldName = "VEN_FECHA";
            this.VEN_FECHA.MaxWidth = 75;
            this.VEN_FECHA.MinWidth = 75;
            this.VEN_FECHA.Name = "VEN_FECHA";
            // 
            // VEN_NOMBRE
            // 
            this.VEN_NOMBRE.Caption = "Cliente";
            this.VEN_NOMBRE.FieldName = "VEN_NOMBRE";
            this.VEN_NOMBRE.MaxWidth = 170;
            this.VEN_NOMBRE.MinWidth = 170;
            this.VEN_NOMBRE.Name = "VEN_NOMBRE";
            this.VEN_NOMBRE.Visible = true;
            this.VEN_NOMBRE.VisibleIndex = 2;
            this.VEN_NOMBRE.Width = 170;
            // 
            // VEN_TOTAL
            // 
            this.VEN_TOTAL.Caption = "Importe";
            this.VEN_TOTAL.FieldName = "VEN_TOTAL";
            this.VEN_TOTAL.MaxWidth = 85;
            this.VEN_TOTAL.MinWidth = 85;
            this.VEN_TOTAL.Name = "VEN_TOTAL";
            this.VEN_TOTAL.Visible = true;
            this.VEN_TOTAL.VisibleIndex = 3;
            this.VEN_TOTAL.Width = 85;
            // 
            // USU_NCOMPLETO
            // 
            this.USU_NCOMPLETO.Caption = "Vendedor";
            this.USU_NCOMPLETO.FieldName = "USU_NCOMPLETO";
            this.USU_NCOMPLETO.Name = "USU_NCOMPLETO";
            this.USU_NCOMPLETO.Visible = true;
            this.USU_NCOMPLETO.VisibleIndex = 4;
            // 
            // ConsultasPedidosVta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 346);
            this.ControlBox = false;
            this.Controls.Add(this.gConsulta);
            this.Controls.Add(this.btncancelar);
            this.Name = "ConsultasPedidosVta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos para la venta";
            this.Load += new System.EventHandler(this.ConsultaInteres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btncancelar;
        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_IDE;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_TIPOFACTU;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_FECHA;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_NOMBRE;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_TOTAL;
        private DevExpress.XtraGrid.Columns.GridColumn USU_NCOMPLETO;
    }
}