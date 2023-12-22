namespace Presentacion
{
    partial class ConsultaProveedor
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
            this.PROV_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PROV_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PROV_LIBRO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaltacliente = new System.Windows.Forms.Button();
            this.btnborrarusu = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rBlolasdb = new System.Windows.Forms.RadioButton();
            this.rBlibros = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gConsulta
            // 
            this.gConsulta.Location = new System.Drawing.Point(60, 71);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(466, 292);
            this.gConsulta.TabIndex = 1;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            this.gConsulta.DoubleClick += new System.EventHandler(this.gConsulta_DoubleClick);
            // 
            // gridViewPintarFilas
            // 
            this.gridViewPintarFilas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PROV_IDE,
            this.PROV_DESC,
            this.PROV_LIBRO});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            // 
            // PROV_IDE
            // 
            this.PROV_IDE.Caption = "Código";
            this.PROV_IDE.FieldName = "PROV_IDE";
            this.PROV_IDE.Name = "PROV_IDE";
            this.PROV_IDE.Visible = true;
            this.PROV_IDE.VisibleIndex = 0;
            this.PROV_IDE.Width = 59;
            // 
            // PROV_DESC
            // 
            this.PROV_DESC.Caption = "PROVEEDOR";
            this.PROV_DESC.FieldName = "PROV_DESC";
            this.PROV_DESC.Name = "PROV_DESC";
            this.PROV_DESC.Visible = true;
            this.PROV_DESC.VisibleIndex = 1;
            this.PROV_DESC.Width = 200;
            // 
            // PROV_LIBRO
            // 
            this.PROV_LIBRO.Caption = "PROV_LIBRO";
            this.PROV_LIBRO.FieldName = "PROV_LIBRO";
            this.PROV_LIBRO.Name = "PROV_LIBRO";
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
            this.txttitulo.Location = new System.Drawing.Point(322, 43);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(178, 20);
            this.txttitulo.TabIndex = 197;
            this.txttitulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttitulo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 198;
            this.label1.Text = "Proveedor:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rBlolasdb);
            this.groupBox2.Controls.Add(this.rBlibros);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(285, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 33);
            this.groupBox2.TabIndex = 258;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // rBlolasdb
            // 
            this.rBlolasdb.AutoSize = true;
            this.rBlolasdb.Checked = true;
            this.rBlolasdb.ForeColor = System.Drawing.Color.Maroon;
            this.rBlolasdb.Location = new System.Drawing.Point(87, 8);
            this.rBlolasdb.Name = "rBlolasdb";
            this.rBlolasdb.Size = new System.Drawing.Size(87, 18);
            this.rBlolasdb.TabIndex = 200;
            this.rBlolasdb.TabStop = true;
            this.rBlolasdb.Text = "Art. librería";
            this.rBlolasdb.UseVisualStyleBackColor = true;
            this.rBlolasdb.CheckedChanged += new System.EventHandler(this.rBlolasdb_CheckedChanged);
            // 
            // rBlibros
            // 
            this.rBlibros.AutoSize = true;
            this.rBlibros.ForeColor = System.Drawing.Color.Maroon;
            this.rBlibros.Location = new System.Drawing.Point(19, 8);
            this.rBlibros.Name = "rBlibros";
            this.rBlibros.Size = new System.Drawing.Size(61, 18);
            this.rBlibros.TabIndex = 199;
            this.rBlibros.Text = "Libros";
            this.rBlibros.UseVisualStyleBackColor = true;
            this.rBlibros.CheckedChanged += new System.EventHandler(this.rBlibros_CheckedChanged);
            // 
            // ConsultaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 434);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnborrarusu);
            this.Controls.Add(this.btnaltacliente);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.gConsulta);
            this.Name = "ConsultaProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.ConsultaInteres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaltacliente;
        private DevExpress.XtraGrid.Columns.GridColumn PROV_IDE;
        private System.Windows.Forms.Button btnborrarusu;
        private System.Windows.Forms.Button btnmodificar;
        private DevExpress.XtraGrid.Columns.GridColumn PROV_DESC;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn PROV_LIBRO;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rBlolasdb;
        private System.Windows.Forms.RadioButton rBlibros;
    }
}