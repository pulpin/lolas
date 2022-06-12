namespace Presentacion
{
    partial class ConsultaProfor
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
            this.VEN_FECHA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_NOMBRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_DIRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_CUIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_TELEFONO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnproforma = new System.Windows.Forms.Button();
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
            this.VEN_FECHA,
            this.VEN_NOMBRE,
            this.VEN_DIRE,
            this.VEN_CUIT,
            this.VEN_TELEFONO,
            this.VEN_IDE});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            // 
            // VEN_FECHA
            // 
            this.VEN_FECHA.Caption = "Fecha";
            this.VEN_FECHA.FieldName = "VEN_FECHA";
            this.VEN_FECHA.MaxWidth = 90;
            this.VEN_FECHA.MinWidth = 90;
            this.VEN_FECHA.Name = "VEN_FECHA";
            this.VEN_FECHA.Visible = true;
            this.VEN_FECHA.VisibleIndex = 1;
            this.VEN_FECHA.Width = 90;
            // 
            // VEN_NOMBRE
            // 
            this.VEN_NOMBRE.Caption = "Nombre";
            this.VEN_NOMBRE.FieldName = "VEN_NOMBRE";
            this.VEN_NOMBRE.Name = "VEN_NOMBRE";
            this.VEN_NOMBRE.Visible = true;
            this.VEN_NOMBRE.VisibleIndex = 2;
            // 
            // VEN_DIRE
            // 
            this.VEN_DIRE.Caption = "Dirección";
            this.VEN_DIRE.FieldName = "VEN_DIRE";
            this.VEN_DIRE.Name = "VEN_DIRE";
            this.VEN_DIRE.Visible = true;
            this.VEN_DIRE.VisibleIndex = 3;
            // 
            // VEN_CUIT
            // 
            this.VEN_CUIT.Caption = "CUIT";
            this.VEN_CUIT.FieldName = "VEN_CUIT";
            this.VEN_CUIT.Name = "VEN_CUIT";
            this.VEN_CUIT.Visible = true;
            this.VEN_CUIT.VisibleIndex = 4;
            // 
            // VEN_TELEFONO
            // 
            this.VEN_TELEFONO.Caption = "Teléfono";
            this.VEN_TELEFONO.FieldName = "VEN_TELEFONO";
            this.VEN_TELEFONO.Name = "VEN_TELEFONO";
            this.VEN_TELEFONO.Visible = true;
            this.VEN_TELEFONO.VisibleIndex = 5;
            // 
            // VEN_IDE
            // 
            this.VEN_IDE.Caption = "Proforma_Nro";
            this.VEN_IDE.FieldName = "VEN_IDE";
            this.VEN_IDE.Name = "VEN_IDE";
            this.VEN_IDE.Visible = true;
            this.VEN_IDE.VisibleIndex = 0;
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
            // btnproforma
            // 
            this.btnproforma.Image = global::Presentacion.Properties.Resources.proforma48;
            this.btnproforma.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnproforma.Location = new System.Drawing.Point(349, 372);
            this.btnproforma.Name = "btnproforma";
            this.btnproforma.Size = new System.Drawing.Size(91, 70);
            this.btnproforma.TabIndex = 214;
            this.btnproforma.Text = "Ver proforma";
            this.btnproforma.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnproforma.UseVisualStyleBackColor = true;
            this.btnproforma.Click += new System.EventHandler(this.btnproforma_Click);
            // 
            // ConsultaProfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(785, 443);
            this.ControlBox = false;
            this.Controls.Add(this.btnproforma);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.gConsulta);
            this.Name = "ConsultaProfor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proformas...";
            this.Load += new System.EventHandler(this.ConsultaInteres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_FECHA;
        private System.Windows.Forms.Button btncancelar;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_NOMBRE;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_DIRE;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_CUIT;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_TELEFONO;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_IDE;
        private System.Windows.Forms.Button btnproforma;
    }
}