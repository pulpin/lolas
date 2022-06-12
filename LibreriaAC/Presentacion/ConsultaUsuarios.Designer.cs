namespace Presentacion
{
    partial class ConsultaUsuarios
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
            this.USU_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USU_NCOMPLETO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USU_NOMBRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USU_CONTRASE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USU_CONTRAVENTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USU_TIPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USU_PTOVENTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaltacliente = new System.Windows.Forms.Button();
            this.btnmodificarcliente = new System.Windows.Forms.Button();
            this.btnborrarusu = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.USU_COLOR = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            this.SuspendLayout();
            // 
            // gConsulta
            // 
            this.gConsulta.Location = new System.Drawing.Point(12, 71);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(380, 292);
            this.gConsulta.TabIndex = 1;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            this.gConsulta.DoubleClick += new System.EventHandler(this.gConsulta_DoubleClick);
            // 
            // gridViewPintarFilas
            // 
            this.gridViewPintarFilas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.USU_IDE,
            this.USU_NCOMPLETO,
            this.USU_NOMBRE,
            this.USU_CONTRASE,
            this.USU_CONTRAVENTA,
            this.USU_TIPO,
            this.USU_PTOVENTA,
            this.USU_COLOR});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            // 
            // USU_IDE
            // 
            this.USU_IDE.Caption = "Código";
            this.USU_IDE.FieldName = "USU_IDE";
            this.USU_IDE.MaxWidth = 90;
            this.USU_IDE.MinWidth = 90;
            this.USU_IDE.Name = "USU_IDE";
            this.USU_IDE.Visible = true;
            this.USU_IDE.VisibleIndex = 0;
            this.USU_IDE.Width = 90;
            // 
            // USU_NCOMPLETO
            // 
            this.USU_NCOMPLETO.Caption = "Nombre";
            this.USU_NCOMPLETO.FieldName = "USU_NCOMPLETO";
            this.USU_NCOMPLETO.Name = "USU_NCOMPLETO";
            this.USU_NCOMPLETO.Visible = true;
            this.USU_NCOMPLETO.VisibleIndex = 1;
            // 
            // USU_NOMBRE
            // 
            this.USU_NOMBRE.Caption = "USU_NOMBRE";
            this.USU_NOMBRE.FieldName = "USU_NOMBRE";
            this.USU_NOMBRE.Name = "USU_NOMBRE";
            // 
            // USU_CONTRASE
            // 
            this.USU_CONTRASE.Caption = "USU_CONTRASE";
            this.USU_CONTRASE.FieldName = "USU_CONTRASE";
            this.USU_CONTRASE.Name = "USU_CONTRASE";
            // 
            // USU_CONTRAVENTA
            // 
            this.USU_CONTRAVENTA.Caption = "USU_CONTRAVENTA";
            this.USU_CONTRAVENTA.FieldName = "USU_CONTRAVENTA";
            this.USU_CONTRAVENTA.Name = "USU_CONTRAVENTA";
            // 
            // USU_TIPO
            // 
            this.USU_TIPO.Caption = "USU_TIPO";
            this.USU_TIPO.FieldName = "USU_TIPO";
            this.USU_TIPO.Name = "USU_TIPO";
            // 
            // USU_PTOVENTA
            // 
            this.USU_PTOVENTA.Caption = "USU_PTOVENTA";
            this.USU_PTOVENTA.FieldName = "USU_PTOVENTA";
            this.USU_PTOVENTA.Name = "USU_PTOVENTA";
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancelar32;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(319, 372);
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
            this.btnaltacliente.Image = global::Presentacion.Properties.Resources.agregar321;
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
            // btnmodificarcliente
            // 
            this.btnmodificarcliente.Image = global::Presentacion.Properties.Resources.permisos32;
            this.btnmodificarcliente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmodificarcliente.Location = new System.Drawing.Point(93, 8);
            this.btnmodificarcliente.Name = "btnmodificarcliente";
            this.btnmodificarcliente.Size = new System.Drawing.Size(58, 57);
            this.btnmodificarcliente.TabIndex = 194;
            this.btnmodificarcliente.Text = "Permisos";
            this.btnmodificarcliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmodificarcliente.UseVisualStyleBackColor = true;
            this.btnmodificarcliente.Click += new System.EventHandler(this.btnmodificarcliente_Click);
            // 
            // btnborrarusu
            // 
            this.btnborrarusu.Image = global::Presentacion.Properties.Resources.borrarusu32;
            this.btnborrarusu.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnborrarusu.Location = new System.Drawing.Point(243, 8);
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
            this.btnmodificar.Image = global::Presentacion.Properties.Resources.editarusu32;
            this.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmodificar.Location = new System.Drawing.Point(168, 8);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(58, 57);
            this.btnmodificar.TabIndex = 196;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // USU_COLOR
            // 
            this.USU_COLOR.Caption = "USU_COLOR";
            this.USU_COLOR.FieldName = "USU_COLOR";
            this.USU_COLOR.Name = "USU_COLOR";
            // 
            // ConsultaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 443);
            this.ControlBox = false;
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnborrarusu);
            this.Controls.Add(this.btnmodificarcliente);
            this.Controls.Add(this.btnaltacliente);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.gConsulta);
            this.Name = "ConsultaUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.ConsultaInteres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private DevExpress.XtraGrid.Columns.GridColumn USU_IDE;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaltacliente;
        private System.Windows.Forms.Button btnmodificarcliente;
        private DevExpress.XtraGrid.Columns.GridColumn USU_NCOMPLETO;
        private System.Windows.Forms.Button btnborrarusu;
        private System.Windows.Forms.Button btnmodificar;
        private DevExpress.XtraGrid.Columns.GridColumn USU_NOMBRE;
        private DevExpress.XtraGrid.Columns.GridColumn USU_CONTRASE;
        private DevExpress.XtraGrid.Columns.GridColumn USU_CONTRAVENTA;
        private DevExpress.XtraGrid.Columns.GridColumn USU_TIPO;
        private DevExpress.XtraGrid.Columns.GridColumn USU_PTOVENTA;
        private DevExpress.XtraGrid.Columns.GridColumn USU_COLOR;
    }
}