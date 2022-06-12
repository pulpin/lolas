namespace Presentacion
{
    partial class ConsultaEditoriales
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
            this.EDI_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EDI_CODIGO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EDI_EDITORIAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EDI_CALLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EDI_NRO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EDI_CPOSTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EDI_LOCALIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EDI_PROVINCIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EDI_TELEFONOS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EDI_CUIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EDI_CLIENTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaltacliente = new System.Windows.Forms.Button();
            this.btnborrarusu = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EDI_PORCEN = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            this.SuspendLayout();
            // 
            // gConsulta
            // 
            this.gConsulta.Location = new System.Drawing.Point(12, 71);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(615, 292);
            this.gConsulta.TabIndex = 1;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            this.gConsulta.DoubleClick += new System.EventHandler(this.gConsulta_DoubleClick);
            // 
            // gridViewPintarFilas
            // 
            this.gridViewPintarFilas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.EDI_IDE,
            this.EDI_CODIGO,
            this.EDI_EDITORIAL,
            this.EDI_CALLE,
            this.EDI_NRO,
            this.EDI_CPOSTAL,
            this.EDI_LOCALIDAD,
            this.EDI_PROVINCIA,
            this.EDI_TELEFONOS,
            this.EDI_CUIT,
            this.EDI_CLIENTE,
            this.EDI_PORCEN});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            // 
            // EDI_IDE
            // 
            this.EDI_IDE.Caption = "Ide";
            this.EDI_IDE.FieldName = "EDI_IDE";
            this.EDI_IDE.MaxWidth = 90;
            this.EDI_IDE.MinWidth = 90;
            this.EDI_IDE.Name = "EDI_IDE";
            this.EDI_IDE.Width = 90;
            // 
            // EDI_CODIGO
            // 
            this.EDI_CODIGO.Caption = "Código";
            this.EDI_CODIGO.FieldName = "EDI_CODIGO";
            this.EDI_CODIGO.Name = "EDI_CODIGO";
            this.EDI_CODIGO.Visible = true;
            this.EDI_CODIGO.VisibleIndex = 0;
            this.EDI_CODIGO.Width = 59;
            // 
            // EDI_EDITORIAL
            // 
            this.EDI_EDITORIAL.Caption = "EDITORIAL";
            this.EDI_EDITORIAL.FieldName = "EDI_EDITORIAL";
            this.EDI_EDITORIAL.Name = "EDI_EDITORIAL";
            this.EDI_EDITORIAL.Visible = true;
            this.EDI_EDITORIAL.VisibleIndex = 1;
            this.EDI_EDITORIAL.Width = 200;
            // 
            // EDI_CALLE
            // 
            this.EDI_CALLE.Caption = "Calle";
            this.EDI_CALLE.FieldName = "EDI_CALLE";
            this.EDI_CALLE.Name = "EDI_CALLE";
            this.EDI_CALLE.Width = 41;
            // 
            // EDI_NRO
            // 
            this.EDI_NRO.Caption = "Número";
            this.EDI_NRO.FieldName = "EDI_NRO";
            this.EDI_NRO.Name = "EDI_NRO";
            this.EDI_NRO.Width = 41;
            // 
            // EDI_CPOSTAL
            // 
            this.EDI_CPOSTAL.Caption = "CódigoPostal";
            this.EDI_CPOSTAL.FieldName = "EDI_CPOSTAL";
            this.EDI_CPOSTAL.Name = "EDI_CPOSTAL";
            this.EDI_CPOSTAL.Width = 41;
            // 
            // EDI_LOCALIDAD
            // 
            this.EDI_LOCALIDAD.Caption = "Localidad";
            this.EDI_LOCALIDAD.FieldName = "EDI_LOCALIDAD";
            this.EDI_LOCALIDAD.Name = "EDI_LOCALIDAD";
            this.EDI_LOCALIDAD.Width = 41;
            // 
            // EDI_PROVINCIA
            // 
            this.EDI_PROVINCIA.Caption = "Provincia";
            this.EDI_PROVINCIA.FieldName = "EDI_PROVINCIA";
            this.EDI_PROVINCIA.Name = "EDI_PROVINCIA";
            this.EDI_PROVINCIA.Width = 41;
            // 
            // EDI_TELEFONOS
            // 
            this.EDI_TELEFONOS.Caption = "Teléfono";
            this.EDI_TELEFONOS.FieldName = "EDI_TELEFONOS";
            this.EDI_TELEFONOS.Name = "EDI_TELEFONOS";
            this.EDI_TELEFONOS.Width = 41;
            // 
            // EDI_CUIT
            // 
            this.EDI_CUIT.Caption = "Cuit";
            this.EDI_CUIT.FieldName = "EDI_CUIT";
            this.EDI_CUIT.Name = "EDI_CUIT";
            this.EDI_CUIT.Visible = true;
            this.EDI_CUIT.VisibleIndex = 2;
            this.EDI_CUIT.Width = 41;
            // 
            // EDI_CLIENTE
            // 
            this.EDI_CLIENTE.Caption = "Cliente";
            this.EDI_CLIENTE.FieldName = "EDI_CLIENTE";
            this.EDI_CLIENTE.Name = "EDI_CLIENTE";
            this.EDI_CLIENTE.Visible = true;
            this.EDI_CLIENTE.VisibleIndex = 3;
            this.EDI_CLIENTE.Width = 51;
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancelar32;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(554, 372);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(73, 59);
            this.btncancelar.TabIndex = 12;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaltacliente
            // 
            this.btnaltacliente.Enabled = false;
            this.btnaltacliente.Image = global::Presentacion.Properties.Resources.add32;
            this.btnaltacliente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnaltacliente.Location = new System.Drawing.Point(18, 8);
            this.btnaltacliente.Name = "btnaltacliente";
            this.btnaltacliente.Size = new System.Drawing.Size(58, 57);
            this.btnaltacliente.TabIndex = 193;
            this.btnaltacliente.Text = "Nuevo";
            this.btnaltacliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnaltacliente.UseVisualStyleBackColor = true;
            this.btnaltacliente.Click += new System.EventHandler(this.btnaltacliente_Click);
            // 
            // btnborrarusu
            // 
            this.btnborrarusu.Enabled = false;
            this.btnborrarusu.Image = global::Presentacion.Properties.Resources.delete32;
            this.btnborrarusu.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnborrarusu.Location = new System.Drawing.Point(173, 8);
            this.btnborrarusu.Name = "btnborrarusu";
            this.btnborrarusu.Size = new System.Drawing.Size(58, 57);
            this.btnborrarusu.TabIndex = 195;
            this.btnborrarusu.Text = "Eliminar";
            this.btnborrarusu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnborrarusu.UseVisualStyleBackColor = true;
            this.btnborrarusu.Click += new System.EventHandler(this.btnborrarusu_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Enabled = false;
            this.btnmodificar.Image = global::Presentacion.Properties.Resources.editar321;
            this.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmodificar.Location = new System.Drawing.Point(97, 8);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(58, 57);
            this.btnmodificar.TabIndex = 196;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(323, 29);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(244, 20);
            this.txttitulo.TabIndex = 197;
            this.txttitulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttitulo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 198;
            this.label1.Text = "Editorial:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EDI_PORCEN
            // 
            this.EDI_PORCEN.Caption = "Porcentaje";
            this.EDI_PORCEN.FieldName = "EDI_PORCEN";
            this.EDI_PORCEN.Name = "EDI_PORCEN";
            this.EDI_PORCEN.Visible = true;
            this.EDI_PORCEN.VisibleIndex = 4;
            // 
            // ConsultaEditoriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 443);
            this.ControlBox = false;
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnborrarusu);
            this.Controls.Add(this.btnaltacliente);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.gConsulta);
            this.Name = "ConsultaEditoriales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editoriales";
            this.Load += new System.EventHandler(this.ConsultaInteres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private DevExpress.XtraGrid.Columns.GridColumn EDI_IDE;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaltacliente;
        private DevExpress.XtraGrid.Columns.GridColumn EDI_CODIGO;
        private System.Windows.Forms.Button btnborrarusu;
        private System.Windows.Forms.Button btnmodificar;
        private DevExpress.XtraGrid.Columns.GridColumn EDI_EDITORIAL;
        private DevExpress.XtraGrid.Columns.GridColumn EDI_CALLE;
        private DevExpress.XtraGrid.Columns.GridColumn EDI_NRO;
        private DevExpress.XtraGrid.Columns.GridColumn EDI_CPOSTAL;
        private DevExpress.XtraGrid.Columns.GridColumn EDI_LOCALIDAD;
        private DevExpress.XtraGrid.Columns.GridColumn EDI_PROVINCIA;
        private DevExpress.XtraGrid.Columns.GridColumn EDI_TELEFONOS;
        private DevExpress.XtraGrid.Columns.GridColumn EDI_CUIT;
        private DevExpress.XtraGrid.Columns.GridColumn EDI_CLIENTE;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn EDI_PORCEN;
    }
}