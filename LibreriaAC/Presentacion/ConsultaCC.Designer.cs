namespace Presentacion
{
    partial class ConsultaCC
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
            this.CC_NRODOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CC_NOMBRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CC_DIRECCION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CC_TEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CC_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnseleccionado = new System.Windows.Forms.Button();
            this.btnaltacliente = new System.Windows.Forms.Button();
            this.btnmodificarcliente = new System.Windows.Forms.Button();
            this.btnborrarcc = new System.Windows.Forms.Button();
            this.btncompras = new System.Windows.Forms.Button();
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
            this.gConsulta.Size = new System.Drawing.Size(707, 295);
            this.gConsulta.TabIndex = 1;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            this.gConsulta.DoubleClick += new System.EventHandler(this.gConsulta_DoubleClick);
            // 
            // gridViewPintarFilas
            // 
            this.gridViewPintarFilas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CC_NRODOC,
            this.CC_NOMBRE,
            this.CC_DIRECCION,
            this.CC_TEL,
            this.CC_IDE});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            // 
            // CC_NRODOC
            // 
            this.CC_NRODOC.Caption = "Documento";
            this.CC_NRODOC.FieldName = "CC_NRODOC";
            this.CC_NRODOC.MaxWidth = 90;
            this.CC_NRODOC.MinWidth = 90;
            this.CC_NRODOC.Name = "CC_NRODOC";
            this.CC_NRODOC.Visible = true;
            this.CC_NRODOC.VisibleIndex = 0;
            this.CC_NRODOC.Width = 90;
            // 
            // CC_NOMBRE
            // 
            this.CC_NOMBRE.Caption = "Nombre";
            this.CC_NOMBRE.FieldName = "CC_NOMBRE";
            this.CC_NOMBRE.MaxWidth = 200;
            this.CC_NOMBRE.MinWidth = 200;
            this.CC_NOMBRE.Name = "CC_NOMBRE";
            this.CC_NOMBRE.Visible = true;
            this.CC_NOMBRE.VisibleIndex = 1;
            this.CC_NOMBRE.Width = 200;
            // 
            // CC_DIRECCION
            // 
            this.CC_DIRECCION.Caption = "Dirección";
            this.CC_DIRECCION.FieldName = "CC_DIRECCION";
            this.CC_DIRECCION.MaxWidth = 110;
            this.CC_DIRECCION.MinWidth = 110;
            this.CC_DIRECCION.Name = "CC_DIRECCION";
            this.CC_DIRECCION.Visible = true;
            this.CC_DIRECCION.VisibleIndex = 2;
            this.CC_DIRECCION.Width = 110;
            // 
            // CC_TEL
            // 
            this.CC_TEL.Caption = "Teléfono";
            this.CC_TEL.FieldName = "CC_TEL";
            this.CC_TEL.MaxWidth = 65;
            this.CC_TEL.MinWidth = 65;
            this.CC_TEL.Name = "CC_TEL";
            this.CC_TEL.Visible = true;
            this.CC_TEL.VisibleIndex = 3;
            this.CC_TEL.Width = 65;
            // 
            // CC_IDE
            // 
            this.CC_IDE.Caption = "CC_IDE";
            this.CC_IDE.FieldName = "CC_IDE";
            this.CC_IDE.Name = "CC_IDE";
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancelar64;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(441, 349);
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
            this.btnseleccionado.Location = new System.Drawing.Point(316, 349);
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
            // btnborrarcc
            // 
            this.btnborrarcc.Enabled = false;
            this.btnborrarcc.Image = global::Presentacion.Properties.Resources.borrarusu32;
            this.btnborrarcc.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnborrarcc.Location = new System.Drawing.Point(126, 1);
            this.btnborrarcc.Name = "btnborrarcc";
            this.btnborrarcc.Size = new System.Drawing.Size(41, 41);
            this.btnborrarcc.TabIndex = 195;
            this.btnborrarcc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnborrarcc.UseVisualStyleBackColor = true;
            this.btnborrarcc.Click += new System.EventHandler(this.btnborrarcc_Click);
            // 
            // btncompras
            // 
            this.btncompras.Image = global::Presentacion.Properties.Resources.factu64;
            this.btncompras.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncompras.Location = new System.Drawing.Point(191, 349);
            this.btncompras.Name = "btncompras";
            this.btncompras.Size = new System.Drawing.Size(102, 87);
            this.btncompras.TabIndex = 196;
            this.btncompras.Text = "Crédito";
            this.btncompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncompras.UseVisualStyleBackColor = true;
            this.btncompras.Click += new System.EventHandler(this.btncompras_Click);
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(250, 12);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(272, 20);
            this.txttitulo.TabIndex = 249;
            this.txttitulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttitulo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 250;
            this.label2.Text = "Nombre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConsultaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 443);
            this.ControlBox = false;
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncompras);
            this.Controls.Add(this.btnborrarcc);
            this.Controls.Add(this.btnmodificarcliente);
            this.Controls.Add(this.btnaltacliente);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnseleccionado);
            this.Controls.Add(this.gConsulta);
            this.Name = "ConsultaCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuentas Corrientes";
            this.Load += new System.EventHandler(this.ConsultaInteres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private DevExpress.XtraGrid.Columns.GridColumn CC_NRODOC;
        private DevExpress.XtraGrid.Columns.GridColumn CC_NOMBRE;
        private DevExpress.XtraGrid.Columns.GridColumn CC_DIRECCION;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnseleccionado;
        private DevExpress.XtraGrid.Columns.GridColumn CC_TEL;
        private DevExpress.XtraGrid.Columns.GridColumn CC_IDE;
        private System.Windows.Forms.Button btnaltacliente;
        private System.Windows.Forms.Button btnmodificarcliente;
        private System.Windows.Forms.Button btnborrarcc;
        private System.Windows.Forms.Button btncompras;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.Label label2;
    }
}