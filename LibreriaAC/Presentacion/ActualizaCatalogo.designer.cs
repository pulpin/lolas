namespace Presentacion
{
    partial class ActualizaCatalogo
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
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.gConsulta = new DevExpress.XtraGrid.GridControl();
            this.gridViewPintarFilas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LI_CODIGO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EDI_EDITORIAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GEN_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_PRECIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_STOCK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_PROPIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_ISBN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_IMAGEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_CUERPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_ESTANTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_FECHAPRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_EDI_CODIGO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_GEN_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_TIPOPRO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_COSTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_PORC_IVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_PORC_GANAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_BARRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.li_precioori = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_CODIGOPROVEE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_PEDCANTIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_PRECIOARTDI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_PRECIOAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_INVENTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_FEC_INVEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_TEM_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_USUA_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_USUM_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.Cancel64;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(853, 435);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(102, 87);
            this.btncancelar.TabIndex = 12;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Image = global::Presentacion.Properties.Resources.editar641;
            this.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmodificar.Location = new System.Drawing.Point(513, 431);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(102, 87);
            this.btnmodificar.TabIndex = 11;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // gConsulta
            // 
            this.gConsulta.Location = new System.Drawing.Point(12, 12);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(924, 400);
            this.gConsulta.TabIndex = 262;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            // 
            // gridViewPintarFilas
            // 
            this.gridViewPintarFilas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.LI_CODIGO,
            this.LI_DESC,
            this.EDI_EDITORIAL,
            this.GEN_DESC,
            this.LI_PRECIO,
            this.LI_STOCK,
            this.LI_PROPIO,
            this.LI_ISBN,
            this.LI_IMAGEN,
            this.LI_CUERPO,
            this.LI_ESTANTE,
            this.LI_FECHAPRE,
            this.LI_EDI_CODIGO,
            this.LI_IDE,
            this.LI_GEN_IDE,
            this.LI_TIPOPRO,
            this.LI_COSTO,
            this.LI_PORC_IVA,
            this.LI_PORC_GANAN,
            this.LI_BARRA,
            this.li_precioori,
            this.LI_CODIGOPROVEE,
            this.LI_PEDCANTIDAD,
            this.LI_PRECIOARTDI,
            this.LI_PRECIOAN,
            this.LI_INVENTA,
            this.LI_FEC_INVEN,
            this.LI_TEM_IDE,
            this.LI_USUA_IDE,
            this.LI_USUM_IDE});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LI_CODIGO", this.LI_CODIGO, "")});
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            // 
            // LI_CODIGO
            // 
            this.LI_CODIGO.Caption = "Código";
            this.LI_CODIGO.FieldName = "LI_CODIGO";
            this.LI_CODIGO.Name = "LI_CODIGO";
            this.LI_CODIGO.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "LI_CODIGO", "Productos={0:#.##}")});
            this.LI_CODIGO.Visible = true;
            this.LI_CODIGO.VisibleIndex = 0;
            // 
            // LI_DESC
            // 
            this.LI_DESC.Caption = "Descripción";
            this.LI_DESC.FieldName = "LI_DESC";
            this.LI_DESC.MaxWidth = 200;
            this.LI_DESC.MinWidth = 200;
            this.LI_DESC.Name = "LI_DESC";
            this.LI_DESC.Visible = true;
            this.LI_DESC.VisibleIndex = 1;
            this.LI_DESC.Width = 200;
            // 
            // EDI_EDITORIAL
            // 
            this.EDI_EDITORIAL.Caption = "EDITORIAL";
            this.EDI_EDITORIAL.FieldName = "EDI_EDITORIAL";
            this.EDI_EDITORIAL.Name = "EDI_EDITORIAL";
            this.EDI_EDITORIAL.Visible = true;
            this.EDI_EDITORIAL.VisibleIndex = 2;
            // 
            // GEN_DESC
            // 
            this.GEN_DESC.Caption = "GENERO";
            this.GEN_DESC.FieldName = "GEN_DESC";
            this.GEN_DESC.Name = "GEN_DESC";
            this.GEN_DESC.Visible = true;
            this.GEN_DESC.VisibleIndex = 3;
            // 
            // LI_PRECIO
            // 
            this.LI_PRECIO.AppearanceCell.Options.UseTextOptions = true;
            this.LI_PRECIO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LI_PRECIO.AppearanceHeader.Options.UseTextOptions = true;
            this.LI_PRECIO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LI_PRECIO.Caption = "Precio";
            this.LI_PRECIO.FieldName = "LI_PRECIO";
            this.LI_PRECIO.Name = "LI_PRECIO";
            this.LI_PRECIO.Visible = true;
            this.LI_PRECIO.VisibleIndex = 4;
            // 
            // LI_STOCK
            // 
            this.LI_STOCK.AppearanceCell.Options.UseTextOptions = true;
            this.LI_STOCK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LI_STOCK.AppearanceHeader.Options.UseTextOptions = true;
            this.LI_STOCK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LI_STOCK.Caption = "Stock";
            this.LI_STOCK.FieldName = "LI_STOCK";
            this.LI_STOCK.Name = "LI_STOCK";
            this.LI_STOCK.Visible = true;
            this.LI_STOCK.VisibleIndex = 5;
            // 
            // LI_PROPIO
            // 
            this.LI_PROPIO.AppearanceCell.Options.UseTextOptions = true;
            this.LI_PROPIO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LI_PROPIO.AppearanceHeader.Options.UseTextOptions = true;
            this.LI_PROPIO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LI_PROPIO.Caption = "Propios";
            this.LI_PROPIO.FieldName = "LI_PROPIO";
            this.LI_PROPIO.Name = "LI_PROPIO";
            this.LI_PROPIO.Visible = true;
            this.LI_PROPIO.VisibleIndex = 6;
            // 
            // LI_ISBN
            // 
            this.LI_ISBN.Caption = "Isbn";
            this.LI_ISBN.FieldName = "LI_ISBN";
            this.LI_ISBN.Name = "LI_ISBN";
            this.LI_ISBN.Visible = true;
            this.LI_ISBN.VisibleIndex = 7;
            // 
            // LI_IMAGEN
            // 
            this.LI_IMAGEN.Caption = "IMAGEN";
            this.LI_IMAGEN.FieldName = "LI_IMAGEN";
            this.LI_IMAGEN.Name = "LI_IMAGEN";
            // 
            // LI_CUERPO
            // 
            this.LI_CUERPO.Caption = "Cuerpo";
            this.LI_CUERPO.FieldName = "LI_CUERPO";
            this.LI_CUERPO.Name = "LI_CUERPO";
            // 
            // LI_ESTANTE
            // 
            this.LI_ESTANTE.Caption = "Estante";
            this.LI_ESTANTE.FieldName = "LI_ESTANTE";
            this.LI_ESTANTE.Name = "LI_ESTANTE";
            // 
            // LI_FECHAPRE
            // 
            this.LI_FECHAPRE.Caption = "Fechapres";
            this.LI_FECHAPRE.FieldName = "LI_FECHAPRE";
            this.LI_FECHAPRE.Name = "LI_FECHAPRE";
            // 
            // LI_EDI_CODIGO
            // 
            this.LI_EDI_CODIGO.Caption = "LI_EDI_CODIGO";
            this.LI_EDI_CODIGO.FieldName = "LI_EDI_CODIGO";
            this.LI_EDI_CODIGO.Name = "LI_EDI_CODIGO";
            this.LI_EDI_CODIGO.Visible = true;
            this.LI_EDI_CODIGO.VisibleIndex = 12;
            // 
            // LI_IDE
            // 
            this.LI_IDE.Caption = "LI_IDE";
            this.LI_IDE.FieldName = "LI_IDE";
            this.LI_IDE.Name = "LI_IDE";
            // 
            // LI_GEN_IDE
            // 
            this.LI_GEN_IDE.Caption = "LI_GEN_IDE";
            this.LI_GEN_IDE.FieldName = "LI_GEN_IDE";
            this.LI_GEN_IDE.Name = "LI_GEN_IDE";
            // 
            // LI_TIPOPRO
            // 
            this.LI_TIPOPRO.Caption = "LI_TIPOPRO";
            this.LI_TIPOPRO.FieldName = "LI_TIPOPRO";
            this.LI_TIPOPRO.Name = "LI_TIPOPRO";
            // 
            // LI_COSTO
            // 
            this.LI_COSTO.Caption = "LI_COSTO";
            this.LI_COSTO.FieldName = "LI_COSTO";
            this.LI_COSTO.Name = "LI_COSTO";
            // 
            // LI_PORC_IVA
            // 
            this.LI_PORC_IVA.Caption = "LI_PORC_IVA";
            this.LI_PORC_IVA.FieldName = "LI_PORC_IVA";
            this.LI_PORC_IVA.Name = "LI_PORC_IVA";
            // 
            // LI_PORC_GANAN
            // 
            this.LI_PORC_GANAN.Caption = "LI_PORC_GANAN";
            this.LI_PORC_GANAN.FieldName = "LI_PORC_GANAN";
            this.LI_PORC_GANAN.Name = "LI_PORC_GANAN";
            // 
            // LI_BARRA
            // 
            this.LI_BARRA.Caption = "Barra";
            this.LI_BARRA.FieldName = "LI_BARRA";
            this.LI_BARRA.Name = "LI_BARRA";
            this.LI_BARRA.Visible = true;
            this.LI_BARRA.VisibleIndex = 8;
            // 
            // li_precioori
            // 
            this.li_precioori.Caption = "li_precioori";
            this.li_precioori.FieldName = "li_precioori";
            this.li_precioori.Name = "li_precioori";
            // 
            // LI_CODIGOPROVEE
            // 
            this.LI_CODIGOPROVEE.Caption = "LI_CODIGOPROVEE";
            this.LI_CODIGOPROVEE.FieldName = "LI_CODIGOPROVEE";
            this.LI_CODIGOPROVEE.Name = "LI_CODIGOPROVEE";
            // 
            // LI_PEDCANTIDAD
            // 
            this.LI_PEDCANTIDAD.Caption = "Pedidos";
            this.LI_PEDCANTIDAD.FieldName = "LI_PEDCANTIDAD";
            this.LI_PEDCANTIDAD.Name = "LI_PEDCANTIDAD";
            this.LI_PEDCANTIDAD.Visible = true;
            this.LI_PEDCANTIDAD.VisibleIndex = 9;
            // 
            // LI_PRECIOARTDI
            // 
            this.LI_PRECIOARTDI.Caption = "LI_PRECIOARTDI";
            this.LI_PRECIOARTDI.FieldName = "LI_PRECIOARTDI";
            this.LI_PRECIOARTDI.Name = "LI_PRECIOARTDI";
            // 
            // LI_PRECIOAN
            // 
            this.LI_PRECIOAN.Caption = "LI_PRECIOAN";
            this.LI_PRECIOAN.FieldName = "LI_PRECIOAN";
            this.LI_PRECIOAN.Name = "LI_PRECIOAN";
            // 
            // LI_INVENTA
            // 
            this.LI_INVENTA.Caption = "LI_INVENTA";
            this.LI_INVENTA.FieldName = "LI_INVENTA";
            this.LI_INVENTA.Name = "LI_INVENTA";
            // 
            // LI_FEC_INVEN
            // 
            this.LI_FEC_INVEN.Caption = "LI_FEC_INVEN";
            this.LI_FEC_INVEN.FieldName = "LI_FEC_INVEN";
            this.LI_FEC_INVEN.Name = "LI_FEC_INVEN";
            // 
            // LI_TEM_IDE
            // 
            this.LI_TEM_IDE.Caption = "LI_TEM_IDE";
            this.LI_TEM_IDE.FieldName = "LI_TEM_IDE";
            this.LI_TEM_IDE.Name = "LI_TEM_IDE";
            this.LI_TEM_IDE.Visible = true;
            this.LI_TEM_IDE.VisibleIndex = 10;
            // 
            // LI_USUA_IDE
            // 
            this.LI_USUA_IDE.Caption = "LI_USUA_IDE";
            this.LI_USUA_IDE.FieldName = "LI_USUA_IDE";
            this.LI_USUA_IDE.MaxWidth = 40;
            this.LI_USUA_IDE.MinWidth = 40;
            this.LI_USUA_IDE.Name = "LI_USUA_IDE";
            this.LI_USUA_IDE.Visible = true;
            this.LI_USUA_IDE.VisibleIndex = 11;
            this.LI_USUA_IDE.Width = 40;
            // 
            // LI_USUM_IDE
            // 
            this.LI_USUM_IDE.Caption = "LI_USUM_IDE";
            this.LI_USUM_IDE.FieldName = "LI_USUM_IDE";
            this.LI_USUM_IDE.Name = "LI_USUM_IDE";
            this.LI_USUM_IDE.Visible = true;
            this.LI_USUM_IDE.VisibleIndex = 13;
            // 
            // ActualizaCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 534);
            this.ControlBox = false;
            this.Controls.Add(this.gConsulta);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnmodificar);
            this.Name = "ActualizaCatalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Reservas";
            this.Load += new System.EventHandler(this.ConsultaInteres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnmodificar;
        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private DevExpress.XtraGrid.Columns.GridColumn LI_CODIGO;
        private DevExpress.XtraGrid.Columns.GridColumn LI_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn EDI_EDITORIAL;
        private DevExpress.XtraGrid.Columns.GridColumn GEN_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn LI_PRECIO;
        private DevExpress.XtraGrid.Columns.GridColumn LI_STOCK;
        private DevExpress.XtraGrid.Columns.GridColumn LI_PROPIO;
        private DevExpress.XtraGrid.Columns.GridColumn LI_ISBN;
        private DevExpress.XtraGrid.Columns.GridColumn LI_IMAGEN;
        private DevExpress.XtraGrid.Columns.GridColumn LI_CUERPO;
        private DevExpress.XtraGrid.Columns.GridColumn LI_ESTANTE;
        private DevExpress.XtraGrid.Columns.GridColumn LI_FECHAPRE;
        private DevExpress.XtraGrid.Columns.GridColumn LI_EDI_CODIGO;
        private DevExpress.XtraGrid.Columns.GridColumn LI_IDE;
        private DevExpress.XtraGrid.Columns.GridColumn LI_GEN_IDE;
        private DevExpress.XtraGrid.Columns.GridColumn LI_TIPOPRO;
        private DevExpress.XtraGrid.Columns.GridColumn LI_COSTO;
        private DevExpress.XtraGrid.Columns.GridColumn LI_PORC_IVA;
        private DevExpress.XtraGrid.Columns.GridColumn LI_PORC_GANAN;
        private DevExpress.XtraGrid.Columns.GridColumn LI_BARRA;
        private DevExpress.XtraGrid.Columns.GridColumn li_precioori;
        private DevExpress.XtraGrid.Columns.GridColumn LI_CODIGOPROVEE;
        private DevExpress.XtraGrid.Columns.GridColumn LI_PEDCANTIDAD;
        private DevExpress.XtraGrid.Columns.GridColumn LI_PRECIOARTDI;
        private DevExpress.XtraGrid.Columns.GridColumn LI_PRECIOAN;
        private DevExpress.XtraGrid.Columns.GridColumn LI_INVENTA;
        private DevExpress.XtraGrid.Columns.GridColumn LI_FEC_INVEN;
        private DevExpress.XtraGrid.Columns.GridColumn LI_TEM_IDE;
        private DevExpress.XtraGrid.Columns.GridColumn LI_USUA_IDE;
        private DevExpress.XtraGrid.Columns.GridColumn LI_USUM_IDE;
    }
}