namespace Presentacion
{
    partial class ConsultaCliente
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
            this.CLI_CUIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CLI_NOMBRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CLI_DIRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CLI_TELEFONO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TIPI_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CLI_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TIPI_LETRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TIPI_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnseleccionado = new System.Windows.Forms.Button();
            this.btnaltacliente = new System.Windows.Forms.Button();
            this.btnmodificarcliente = new System.Windows.Forms.Button();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            this.SuspendLayout();
            // 
            // gConsulta
            // 
            this.gConsulta.Location = new System.Drawing.Point(12, 48);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(707, 295);
            this.gConsulta.TabIndex = 1;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            this.gConsulta.DoubleClick += new System.EventHandler(this.gConsulta_DoubleClick);
            // 
            // gridViewPintarFilas
            // 
            this.gridViewPintarFilas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CLI_CUIT,
            this.CLI_NOMBRE,
            this.CLI_DIRE,
            this.CLI_TELEFONO,
            this.TIPI_DESC,
            this.CLI_IDE,
            this.TIPI_LETRA,
            this.TIPI_IDE});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            // 
            // CLI_CUIT
            // 
            this.CLI_CUIT.Caption = "CLI_CUIT";
            this.CLI_CUIT.FieldName = "CLI_CUIT";
            this.CLI_CUIT.MaxWidth = 90;
            this.CLI_CUIT.MinWidth = 90;
            this.CLI_CUIT.Name = "CLI_CUIT";
            this.CLI_CUIT.Visible = true;
            this.CLI_CUIT.VisibleIndex = 0;
            this.CLI_CUIT.Width = 90;
            // 
            // CLI_NOMBRE
            // 
            this.CLI_NOMBRE.Caption = "CLI_NOMBRE";
            this.CLI_NOMBRE.FieldName = "CLI_NOMBRE";
            this.CLI_NOMBRE.MaxWidth = 200;
            this.CLI_NOMBRE.MinWidth = 200;
            this.CLI_NOMBRE.Name = "CLI_NOMBRE";
            this.CLI_NOMBRE.Visible = true;
            this.CLI_NOMBRE.VisibleIndex = 1;
            this.CLI_NOMBRE.Width = 200;
            // 
            // CLI_DIRE
            // 
            this.CLI_DIRE.Caption = "CLI_DIRE";
            this.CLI_DIRE.FieldName = "CLI_DIRE";
            this.CLI_DIRE.MaxWidth = 110;
            this.CLI_DIRE.MinWidth = 110;
            this.CLI_DIRE.Name = "CLI_DIRE";
            this.CLI_DIRE.Visible = true;
            this.CLI_DIRE.VisibleIndex = 2;
            this.CLI_DIRE.Width = 110;
            // 
            // CLI_TELEFONO
            // 
            this.CLI_TELEFONO.Caption = "CLI_TELEFONO";
            this.CLI_TELEFONO.FieldName = "CLI_TELEFONO";
            this.CLI_TELEFONO.MaxWidth = 65;
            this.CLI_TELEFONO.MinWidth = 65;
            this.CLI_TELEFONO.Name = "CLI_TELEFONO";
            this.CLI_TELEFONO.Visible = true;
            this.CLI_TELEFONO.VisibleIndex = 3;
            this.CLI_TELEFONO.Width = 65;
            // 
            // TIPI_DESC
            // 
            this.TIPI_DESC.Caption = "TIPI_DESC";
            this.TIPI_DESC.FieldName = "TIPI_DESC";
            this.TIPI_DESC.MaxWidth = 120;
            this.TIPI_DESC.MinWidth = 120;
            this.TIPI_DESC.Name = "TIPI_DESC";
            this.TIPI_DESC.Visible = true;
            this.TIPI_DESC.VisibleIndex = 4;
            this.TIPI_DESC.Width = 120;
            // 
            // CLI_IDE
            // 
            this.CLI_IDE.Caption = "CLI_IDE";
            this.CLI_IDE.FieldName = "CLI_IDE";
            this.CLI_IDE.Name = "CLI_IDE";
            // 
            // TIPI_LETRA
            // 
            this.TIPI_LETRA.Caption = "TIPI_LETRA";
            this.TIPI_LETRA.FieldName = "TIPI_LETRA";
            this.TIPI_LETRA.MaxWidth = 20;
            this.TIPI_LETRA.Name = "TIPI_LETRA";
            this.TIPI_LETRA.Visible = true;
            this.TIPI_LETRA.VisibleIndex = 5;
            this.TIPI_LETRA.Width = 20;
            // 
            // TIPI_IDE
            // 
            this.TIPI_IDE.Caption = "TIPI_IDE";
            this.TIPI_IDE.FieldName = "CLI_TIPI_IDE";
            this.TIPI_IDE.Name = "TIPI_IDE";
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancelar64;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(449, 349);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(102, 87);
            this.btncancelar.TabIndex = 12;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnseleccionado
            // 
            this.btnseleccionado.Image = global::Presentacion.Properties.Resources.acepta64;
            this.btnseleccionado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnseleccionado.Location = new System.Drawing.Point(309, 349);
            this.btnseleccionado.Name = "btnseleccionado";
            this.btnseleccionado.Size = new System.Drawing.Size(102, 87);
            this.btnseleccionado.TabIndex = 11;
            this.btnseleccionado.Text = "Seleccionar";
            this.btnseleccionado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnseleccionado.UseVisualStyleBackColor = true;
            this.btnseleccionado.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnaltacliente
            // 
            this.btnaltacliente.Enabled = false;
            this.btnaltacliente.Image = global::Presentacion.Properties.Resources.agregar321;
            this.btnaltacliente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnaltacliente.Location = new System.Drawing.Point(32, 1);
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
            this.btnmodificarcliente.Location = new System.Drawing.Point(79, 1);
            this.btnmodificarcliente.Name = "btnmodificarcliente";
            this.btnmodificarcliente.Size = new System.Drawing.Size(41, 41);
            this.btnmodificarcliente.TabIndex = 194;
            this.btnmodificarcliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmodificarcliente.UseVisualStyleBackColor = true;
            this.btnmodificarcliente.Click += new System.EventHandler(this.btnmodificarcliente_Click);
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(242, 12);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(272, 20);
            this.txttitulo.TabIndex = 251;
            this.txttitulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttitulo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 252;
            this.label2.Text = "Nombre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Image = global::Presentacion.Properties.Resources.caro64;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(174, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 87);
            this.button1.TabIndex = 253;
            this.button1.Text = "Compras";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 443);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnmodificarcliente);
            this.Controls.Add(this.btnaltacliente);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnseleccionado);
            this.Controls.Add(this.gConsulta);
            this.Name = "ConsultaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.ConsultaInteres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private DevExpress.XtraGrid.Columns.GridColumn CLI_CUIT;
        private DevExpress.XtraGrid.Columns.GridColumn CLI_NOMBRE;
        private DevExpress.XtraGrid.Columns.GridColumn CLI_DIRE;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnseleccionado;
        private DevExpress.XtraGrid.Columns.GridColumn CLI_TELEFONO;
        private DevExpress.XtraGrid.Columns.GridColumn TIPI_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn CLI_IDE;
        private DevExpress.XtraGrid.Columns.GridColumn TIPI_LETRA;
        private DevExpress.XtraGrid.Columns.GridColumn TIPI_IDE;
        private System.Windows.Forms.Button btnaltacliente;
        private System.Windows.Forms.Button btnmodificarcliente;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}