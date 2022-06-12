namespace Presentacion
{
    partial class ConsultaBancos
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
            this.banco_ide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.banco_desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaltacliente = new System.Windows.Forms.Button();
            this.btnborrarusu = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            this.SuspendLayout();
            // 
            // gConsulta
            // 
            this.gConsulta.Location = new System.Drawing.Point(12, 74);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(501, 292);
            this.gConsulta.TabIndex = 1;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            this.gConsulta.DoubleClick += new System.EventHandler(this.gConsulta_DoubleClick);
            // 
            // gridViewPintarFilas
            // 
            this.gridViewPintarFilas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.banco_ide,
            this.banco_desc});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            // 
            // banco_ide
            // 
            this.banco_ide.Caption = "Ide";
            this.banco_ide.FieldName = "banco_ide";
            this.banco_ide.MaxWidth = 90;
            this.banco_ide.MinWidth = 90;
            this.banco_ide.Name = "banco_ide";
            this.banco_ide.Width = 90;
            // 
            // banco_desc
            // 
            this.banco_desc.Caption = "Banco";
            this.banco_desc.FieldName = "banco_desc";
            this.banco_desc.Name = "banco_desc";
            this.banco_desc.Visible = true;
            this.banco_desc.VisibleIndex = 0;
            this.banco_desc.Width = 59;
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancelar32;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(441, 379);
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
            // ConsultaBancos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 443);
            this.ControlBox = false;
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnborrarusu);
            this.Controls.Add(this.btnaltacliente);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.gConsulta);
            this.Name = "ConsultaBancos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bancos";
            this.Load += new System.EventHandler(this.ConsultaInteres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private DevExpress.XtraGrid.Columns.GridColumn banco_ide;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaltacliente;
        private DevExpress.XtraGrid.Columns.GridColumn banco_desc;
        private System.Windows.Forms.Button btnborrarusu;
        private System.Windows.Forms.Button btnmodificar;
    }
}