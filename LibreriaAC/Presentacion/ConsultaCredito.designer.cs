namespace Presentacion
{
    partial class ConsultaCredito
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
            this.li_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.li_titulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.li_rubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.li_editorial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.li_tomos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.li_stock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.li_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.li_distribucion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.li_contado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.li_financiado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.li_seis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.li_ocho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.li_diez = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            this.SuspendLayout();
            // 
            // gConsulta
            // 
            this.gConsulta.Location = new System.Drawing.Point(12, 71);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(861, 292);
            this.gConsulta.TabIndex = 1;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            this.gConsulta.DoubleClick += new System.EventHandler(this.gConsulta_DoubleClick);
            // 
            // gridViewPintarFilas
            // 
            this.gridViewPintarFilas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.li_codigo,
            this.li_titulo,
            this.li_rubro,
            this.li_editorial,
            this.li_tomos,
            this.li_stock,
            this.li_costo,
            this.li_distribucion,
            this.li_contado,
            this.li_financiado,
            this.li_seis,
            this.li_ocho,
            this.li_diez});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            // 
            // li_codigo
            // 
            this.li_codigo.Caption = "li_codigo";
            this.li_codigo.FieldName = "li_codigo";
            this.li_codigo.MaxWidth = 90;
            this.li_codigo.MinWidth = 90;
            this.li_codigo.Name = "li_codigo";
            this.li_codigo.Width = 90;
            // 
            // li_titulo
            // 
            this.li_titulo.Caption = "Titulo";
            this.li_titulo.FieldName = "li_titulo";
            this.li_titulo.Name = "li_titulo";
            this.li_titulo.Visible = true;
            this.li_titulo.VisibleIndex = 0;
            this.li_titulo.Width = 200;
            // 
            // li_rubro
            // 
            this.li_rubro.Caption = "Rubro";
            this.li_rubro.FieldName = "li_rubro";
            this.li_rubro.Name = "li_rubro";
            this.li_rubro.Width = 41;
            // 
            // li_editorial
            // 
            this.li_editorial.Caption = "Editorial";
            this.li_editorial.FieldName = "li_editorial";
            this.li_editorial.Name = "li_editorial";
            this.li_editorial.Width = 41;
            // 
            // li_tomos
            // 
            this.li_tomos.Caption = "Tomos";
            this.li_tomos.FieldName = "li_tomos";
            this.li_tomos.Name = "li_tomos";
            this.li_tomos.Width = 41;
            // 
            // li_stock
            // 
            this.li_stock.Caption = "Stock";
            this.li_stock.FieldName = "li_stock";
            this.li_stock.Name = "li_stock";
            this.li_stock.Width = 41;
            // 
            // li_costo
            // 
            this.li_costo.Caption = "Costo";
            this.li_costo.FieldName = "li_costo";
            this.li_costo.Name = "li_costo";
            this.li_costo.Width = 41;
            // 
            // li_distribucion
            // 
            this.li_distribucion.Caption = "Distribuicion";
            this.li_distribucion.FieldName = "li_distribucion";
            this.li_distribucion.Name = "li_distribucion";
            this.li_distribucion.Width = 41;
            // 
            // li_contado
            // 
            this.li_contado.Caption = "Contado";
            this.li_contado.FieldName = "li_contado";
            this.li_contado.Name = "li_contado";
            this.li_contado.Visible = true;
            this.li_contado.VisibleIndex = 1;
            this.li_contado.Width = 41;
            // 
            // li_financiado
            // 
            this.li_financiado.Caption = "Financiado";
            this.li_financiado.FieldName = "li_financiado";
            this.li_financiado.Name = "li_financiado";
            this.li_financiado.Visible = true;
            this.li_financiado.VisibleIndex = 2;
            this.li_financiado.Width = 51;
            // 
            // li_seis
            // 
            this.li_seis.Caption = "Seis";
            this.li_seis.FieldName = "li_seis";
            this.li_seis.Name = "li_seis";
            // 
            // li_ocho
            // 
            this.li_ocho.Caption = "Ocho";
            this.li_ocho.FieldName = "li_ocho";
            this.li_ocho.Name = "li_ocho";
            // 
            // li_diez
            // 
            this.li_diez.Caption = "Diez";
            this.li_diez.FieldName = "li_diez";
            this.li_diez.Name = "li_diez";
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
            // btnmodificar
            // 
            this.btnmodificar.Enabled = false;
            this.btnmodificar.Image = global::Presentacion.Properties.Resources.editar321;
            this.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmodificar.Location = new System.Drawing.Point(12, 8);
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
            this.txttitulo.Location = new System.Drawing.Point(427, 31);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(244, 20);
            this.txttitulo.TabIndex = 197;
            this.txttitulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttitulo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 198;
            this.label1.Text = "Título:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConsultaCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 443);
            this.ControlBox = false;
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.gConsulta);
            this.Name = "ConsultaCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libros de crédito...";
            this.Load += new System.EventHandler(this.ConsultaInteres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private DevExpress.XtraGrid.Columns.GridColumn li_codigo;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnmodificar;
        private DevExpress.XtraGrid.Columns.GridColumn li_titulo;
        private DevExpress.XtraGrid.Columns.GridColumn li_rubro;
        private DevExpress.XtraGrid.Columns.GridColumn li_editorial;
        private DevExpress.XtraGrid.Columns.GridColumn li_tomos;
        private DevExpress.XtraGrid.Columns.GridColumn li_stock;
        private DevExpress.XtraGrid.Columns.GridColumn li_costo;
        private DevExpress.XtraGrid.Columns.GridColumn li_distribucion;
        private DevExpress.XtraGrid.Columns.GridColumn li_contado;
        private DevExpress.XtraGrid.Columns.GridColumn li_financiado;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn li_seis;
        private DevExpress.XtraGrid.Columns.GridColumn li_ocho;
        private DevExpress.XtraGrid.Columns.GridColumn li_diez;
    }
}