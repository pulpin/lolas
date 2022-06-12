namespace Presentacion
{
    partial class ConsultaProveedorPagos
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
            this.acre_ide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.acre_desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.acre_local_ide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.acre_anombrede = new DevExpress.XtraGrid.Columns.GridColumn();
            this.acre_dire = new DevExpress.XtraGrid.Columns.GridColumn();
            this.acre_tel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.acre_mail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.acre_obs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cu_ide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cu_banco_ide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cu_ctacorriente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cu_cahora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cu_titular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cu_cbu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cu_cuit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaltacliente = new System.Windows.Forms.Button();
            this.btnborrarusu = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            this.SuspendLayout();
            // 
            // gConsulta
            // 
            this.gConsulta.Location = new System.Drawing.Point(18, 71);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(525, 292);
            this.gConsulta.TabIndex = 1;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            this.gConsulta.DoubleClick += new System.EventHandler(this.gConsulta_DoubleClick);
            // 
            // gridViewPintarFilas
            // 
            this.gridViewPintarFilas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.acre_ide,
            this.acre_desc,
            this.acre_local_ide,
            this.acre_anombrede,
            this.acre_dire,
            this.acre_tel,
            this.acre_mail,
            this.acre_obs,
            this.cu_ide,
            this.cu_banco_ide,
            this.cu_ctacorriente,
            this.cu_cahora,
            this.cu_titular,
            this.cu_cbu,
            this.cu_cuit});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            // 
            // acre_ide
            // 
            this.acre_ide.Caption = "Código";
            this.acre_ide.FieldName = "acre_ide";
            this.acre_ide.Name = "acre_ide";
            this.acre_ide.Visible = true;
            this.acre_ide.VisibleIndex = 0;
            this.acre_ide.Width = 59;
            // 
            // acre_desc
            // 
            this.acre_desc.Caption = "PROVEEDOR";
            this.acre_desc.FieldName = "acre_desc";
            this.acre_desc.Name = "acre_desc";
            this.acre_desc.Visible = true;
            this.acre_desc.VisibleIndex = 1;
            this.acre_desc.Width = 200;
            // 
            // acre_local_ide
            // 
            this.acre_local_ide.Caption = "acre_local_ide";
            this.acre_local_ide.FieldName = "acre_local_ide";
            this.acre_local_ide.Name = "acre_local_ide";
            // 
            // acre_anombrede
            // 
            this.acre_anombrede.Caption = "acre_anombrede";
            this.acre_anombrede.FieldName = "acre_anombrede";
            this.acre_anombrede.Name = "acre_anombrede";
            // 
            // acre_dire
            // 
            this.acre_dire.Caption = "acre_dire";
            this.acre_dire.FieldName = "acre_dire";
            this.acre_dire.Name = "acre_dire";
            // 
            // acre_tel
            // 
            this.acre_tel.Caption = "acre_tel";
            this.acre_tel.FieldName = "acre_tel";
            this.acre_tel.Name = "acre_tel";
            // 
            // acre_mail
            // 
            this.acre_mail.Caption = "acre_mail";
            this.acre_mail.FieldName = "acre_mail";
            this.acre_mail.Name = "acre_mail";
            // 
            // acre_obs
            // 
            this.acre_obs.Caption = "acre_obs";
            this.acre_obs.FieldName = "acre_obs";
            this.acre_obs.Name = "acre_obs";
            // 
            // cu_ide
            // 
            this.cu_ide.Caption = "cu_ide";
            this.cu_ide.FieldName = "cu_ide";
            this.cu_ide.Name = "cu_ide";
            this.cu_ide.Visible = true;
            this.cu_ide.VisibleIndex = 2;
            // 
            // cu_banco_ide
            // 
            this.cu_banco_ide.Caption = "cu_banco_ide";
            this.cu_banco_ide.FieldName = "cu_banco_ide";
            this.cu_banco_ide.Name = "cu_banco_ide";
            // 
            // cu_ctacorriente
            // 
            this.cu_ctacorriente.Caption = "cu_ctacorriente";
            this.cu_ctacorriente.FieldName = "cu_ctacorriente";
            this.cu_ctacorriente.Name = "cu_ctacorriente";
            // 
            // cu_cahora
            // 
            this.cu_cahora.Caption = "cu_cahora";
            this.cu_cahora.FieldName = "cu_cahora";
            this.cu_cahora.Name = "cu_cahora";
            // 
            // cu_titular
            // 
            this.cu_titular.Caption = "cu_titular";
            this.cu_titular.FieldName = "cu_titular";
            this.cu_titular.Name = "cu_titular";
            // 
            // cu_cbu
            // 
            this.cu_cbu.Caption = "cu_cbu";
            this.cu_cbu.FieldName = "cu_cbu";
            this.cu_cbu.Name = "cu_cbu";
            // 
            // cu_cuit
            // 
            this.cu_cuit.Caption = "cu_cuit";
            this.cu_cuit.FieldName = "cu_cuit";
            this.cu_cuit.Name = "cu_cuit";
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancelar32;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(405, 369);
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
            this.txttitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txttitulo.Location = new System.Drawing.Point(320, 28);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(223, 20);
            this.txttitulo.TabIndex = 197;
            this.txttitulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttitulo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 198;
            this.label1.Text = "Proveedor:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConsultaProveedorPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(570, 434);
            this.ControlBox = false;
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnborrarusu);
            this.Controls.Add(this.btnaltacliente);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.gConsulta);
            this.Name = "ConsultaProveedorPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.ConsultaInteres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaltacliente;
        private DevExpress.XtraGrid.Columns.GridColumn acre_ide;
        private System.Windows.Forms.Button btnborrarusu;
        private System.Windows.Forms.Button btnmodificar;
        private DevExpress.XtraGrid.Columns.GridColumn acre_desc;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn acre_local_ide;
        private DevExpress.XtraGrid.Columns.GridColumn acre_anombrede;
        private DevExpress.XtraGrid.Columns.GridColumn acre_dire;
        private DevExpress.XtraGrid.Columns.GridColumn acre_tel;
        private DevExpress.XtraGrid.Columns.GridColumn acre_mail;
        private DevExpress.XtraGrid.Columns.GridColumn acre_obs;
        private DevExpress.XtraGrid.Columns.GridColumn cu_ide;
        private DevExpress.XtraGrid.Columns.GridColumn cu_banco_ide;
        private DevExpress.XtraGrid.Columns.GridColumn cu_ctacorriente;
        private DevExpress.XtraGrid.Columns.GridColumn cu_cahora;
        private DevExpress.XtraGrid.Columns.GridColumn cu_titular;
        private DevExpress.XtraGrid.Columns.GridColumn cu_cbu;
        private DevExpress.XtraGrid.Columns.GridColumn cu_cuit;
    }
}