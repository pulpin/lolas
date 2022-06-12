namespace Presentacion
{
    partial class ConsultaClienteLi
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
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaltacliente = new System.Windows.Forms.Button();
            this.btnmodificarcliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcaracteristica = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lbdescuento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gConsulta
            // 
            this.gConsulta.Location = new System.Drawing.Point(12, 48);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(506, 214);
            this.gConsulta.TabIndex = 1;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            this.gConsulta.DoubleClick += new System.EventHandler(this.gConsulta_DoubleClick_1);
            // 
            // gridViewPintarFilas
            // 
            this.gridViewPintarFilas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CLIEN_NOMBRE,
            this.CLIEN_TELEFONO,
            this.CLIEN_IDE});
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
            this.CLIEN_NOMBRE.MaxWidth = 150;
            this.CLIEN_NOMBRE.MinWidth = 150;
            this.CLIEN_NOMBRE.Name = "CLIEN_NOMBRE";
            this.CLIEN_NOMBRE.Visible = true;
            this.CLIEN_NOMBRE.VisibleIndex = 0;
            this.CLIEN_NOMBRE.Width = 150;
            // 
            // CLIEN_TELEFONO
            // 
            this.CLIEN_TELEFONO.Caption = "Teléfono";
            this.CLIEN_TELEFONO.FieldName = "CLIEN_TELEFONO";
            this.CLIEN_TELEFONO.MaxWidth = 90;
            this.CLIEN_TELEFONO.MinWidth = 90;
            this.CLIEN_TELEFONO.Name = "CLIEN_TELEFONO";
            this.CLIEN_TELEFONO.Visible = true;
            this.CLIEN_TELEFONO.VisibleIndex = 1;
            this.CLIEN_TELEFONO.Width = 90;
            // 
            // CLIEN_IDE
            // 
            this.CLIEN_IDE.Caption = "CLIEN_IDE";
            this.CLIEN_IDE.FieldName = "CLIEN_IDE";
            this.CLIEN_IDE.Name = "CLIEN_IDE";
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.salir48;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(440, 412);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(69, 74);
            this.btncancelar.TabIndex = 12;
            this.btncancelar.Text = "Salir";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaltacliente
            // 
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtcaracteristica);
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.txttelefono);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.lbdescuento);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 130);
            this.groupBox1.TabIndex = 237;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar cliente...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(235, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 23);
            this.label2.TabIndex = 242;
            this.label2.Text = "15";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtcaracteristica
            // 
            this.txtcaracteristica.BackColor = System.Drawing.SystemColors.Info;
            this.txtcaracteristica.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcaracteristica.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtcaracteristica.Location = new System.Drawing.Point(162, 65);
            this.txtcaracteristica.Name = "txtcaracteristica";
            this.txtcaracteristica.Size = new System.Drawing.Size(70, 30);
            this.txtcaracteristica.TabIndex = 241;
            this.txtcaracteristica.Text = "2966";
            this.txtcaracteristica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Image = global::Presentacion.Properties.Resources.guardar32;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(400, 29);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(97, 56);
            this.btnguardar.TabIndex = 238;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txttelefono
            // 
            this.txttelefono.BackColor = System.Drawing.SystemColors.Info;
            this.txttelefono.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txttelefono.Location = new System.Drawing.Point(271, 65);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(114, 30);
            this.txttelefono.TabIndex = 240;
            this.txttelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(76, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 239;
            this.label1.Text = "Teléfono:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.SystemColors.Info;
            this.txtnombre.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtnombre.Location = new System.Drawing.Point(162, 19);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(223, 30);
            this.txtnombre.TabIndex = 238;
            // 
            // lbdescuento
            // 
            this.lbdescuento.AutoSize = true;
            this.lbdescuento.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdescuento.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbdescuento.Location = new System.Drawing.Point(0, 20);
            this.lbdescuento.Name = "lbdescuento";
            this.lbdescuento.Size = new System.Drawing.Size(163, 19);
            this.lbdescuento.TabIndex = 237;
            this.lbdescuento.Text = "Apellido y nombre:";
            this.lbdescuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConsultaClienteLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 489);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnmodificarcliente);
            this.Controls.Add(this.btnaltacliente);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.gConsulta);
            this.Name = "ConsultaClienteLi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guardar";
            this.Load += new System.EventHandler(this.ConsultaClienteLi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private DevExpress.XtraGrid.Columns.GridColumn CLIEN_NOMBRE;
        private DevExpress.XtraGrid.Columns.GridColumn CLIEN_TELEFONO;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaltacliente;
        private System.Windows.Forms.Button btnmodificarcliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lbdescuento;
        private System.Windows.Forms.Button btnguardar;
        private DevExpress.XtraGrid.Columns.GridColumn CLIEN_IDE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcaracteristica;
    }
}