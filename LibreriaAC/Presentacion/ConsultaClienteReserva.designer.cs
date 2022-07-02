namespace Presentacion
{
    partial class ConsultaClienteReserva
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
            this.CLIEN_NOMBRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CLIEN_TELEFONO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CLIEN_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CLIEN_OBS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaltacliente = new System.Windows.Forms.Button();
            this.btnmodificarcliente = new System.Windows.Forms.Button();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            this.SuspendLayout();
            // 
            // gConsulta
            // 
            this.gConsulta.Location = new System.Drawing.Point(12, 48);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(557, 295);
            this.gConsulta.TabIndex = 1;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            this.gConsulta.DoubleClick += new System.EventHandler(this.gConsulta_DoubleClick);
            // 
            // gridViewPintarFilas
            // 
            this.gridViewPintarFilas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CLIEN_NOMBRE,
            this.CLIEN_TELEFONO,
            this.CLIEN_IDE,
            this.CLIEN_OBS});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            // 
            // CLIEN_NOMBRE
            // 
            this.CLIEN_NOMBRE.Caption = "Cliente";
            this.CLIEN_NOMBRE.FieldName = "CLIEN_NOMBRE";
            this.CLIEN_NOMBRE.MaxWidth = 200;
            this.CLIEN_NOMBRE.MinWidth = 200;
            this.CLIEN_NOMBRE.Name = "CLIEN_NOMBRE";
            this.CLIEN_NOMBRE.Visible = true;
            this.CLIEN_NOMBRE.VisibleIndex = 0;
            this.CLIEN_NOMBRE.Width = 200;
            // 
            // CLIEN_TELEFONO
            // 
            this.CLIEN_TELEFONO.Caption = "Teléfono";
            this.CLIEN_TELEFONO.FieldName = "CLIEN_TELEFONO";
            this.CLIEN_TELEFONO.MaxWidth = 65;
            this.CLIEN_TELEFONO.MinWidth = 65;
            this.CLIEN_TELEFONO.Name = "CLIEN_TELEFONO";
            this.CLIEN_TELEFONO.Visible = true;
            this.CLIEN_TELEFONO.VisibleIndex = 1;
            this.CLIEN_TELEFONO.Width = 65;
            // 
            // CLIEN_IDE
            // 
            this.CLIEN_IDE.Caption = "CLIEN_IDE";
            this.CLIEN_IDE.FieldName = "CLIEN_IDE";
            this.CLIEN_IDE.Name = "CLIEN_IDE";
            // 
            // CLIEN_OBS
            // 
            this.CLIEN_OBS.Caption = "Observaciones";
            this.CLIEN_OBS.FieldName = "CLIEN_OBS";
            this.CLIEN_OBS.MaxWidth = 250;
            this.CLIEN_OBS.MinWidth = 250;
            this.CLIEN_OBS.Name = "CLIEN_OBS";
            this.CLIEN_OBS.Visible = true;
            this.CLIEN_OBS.VisibleIndex = 2;
            this.CLIEN_OBS.Width = 250;
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancelar64;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(489, 349);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(80, 80);
            this.btncancelar.TabIndex = 12;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaltacliente
            // 
            this.btnaltacliente.Enabled = false;
            this.btnaltacliente.Image = global::Presentacion.Properties.Resources.agregar321;
            this.btnaltacliente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnaltacliente.Location = new System.Drawing.Point(13, 1);
            this.btnaltacliente.Name = "btnaltacliente";
            this.btnaltacliente.Size = new System.Drawing.Size(41, 41);
            this.btnaltacliente.TabIndex = 193;
            this.btnaltacliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnaltacliente.UseVisualStyleBackColor = true;
            this.btnaltacliente.Click += new System.EventHandler(this.btnaltacliente_Click);
            // 
            // btnmodificarcliente
            // 
            this.btnmodificarcliente.Enabled = false;
            this.btnmodificarcliente.Image = global::Presentacion.Properties.Resources.editar32;
            this.btnmodificarcliente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmodificarcliente.Location = new System.Drawing.Point(60, 1);
            this.btnmodificarcliente.Name = "btnmodificarcliente";
            this.btnmodificarcliente.Size = new System.Drawing.Size(41, 41);
            this.btnmodificarcliente.TabIndex = 194;
            this.btnmodificarcliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmodificarcliente.UseVisualStyleBackColor = true;
            this.btnmodificarcliente.Click += new System.EventHandler(this.btnmodificarcliente_Click);
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(214, 12);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(221, 20);
            this.txttitulo.TabIndex = 251;
            this.txttitulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttitulo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 252;
            this.label2.Text = "Nombre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConsultaClienteReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 443);
            this.ControlBox = false;
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnmodificarcliente);
            this.Controls.Add(this.btnaltacliente);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.gConsulta);
            this.Name = "ConsultaClienteReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes de agenda";
            this.Load += new System.EventHandler(this.ConsultaInteres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private DevExpress.XtraGrid.Columns.GridColumn CLIEN_NOMBRE;
        private System.Windows.Forms.Button btncancelar;
        private DevExpress.XtraGrid.Columns.GridColumn CLIEN_TELEFONO;
        private DevExpress.XtraGrid.Columns.GridColumn CLIEN_IDE;
        private System.Windows.Forms.Button btnaltacliente;
        private System.Windows.Forms.Button btnmodificarcliente;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn CLIEN_OBS;
    }
}