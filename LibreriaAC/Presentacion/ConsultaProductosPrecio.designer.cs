namespace Presentacion
{
    partial class ConsultaProductosPrecio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaProductosPrecio));
            this.gConsulta = new DevExpress.XtraGrid.GridControl();
            this.gridViewPintarFilas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LI_CODIGO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_AUTOR = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.LI_PEDIDOS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_PRECIOARTDI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_PRECIOAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_INVENTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_FEC_INVEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lUEgenero = new DevExpress.XtraEditors.LookUpEdit();
            this.cBEeditorial = new DevExpress.XtraEditors.LookUpEdit();
            this.blimpiar = new System.Windows.Forms.Button();
            this.chbpalabra = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bbuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtprovee = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbarra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtporcentaje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lUEgenero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBEeditorial.Properties)).BeginInit();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // gConsulta
            // 
            this.gConsulta.Location = new System.Drawing.Point(7, 139);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(924, 358);
            this.gConsulta.TabIndex = 0;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            this.gConsulta.Click += new System.EventHandler(this.gConsulta_Click);
            // 
            // gridViewPintarFilas
            // 
            this.gridViewPintarFilas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.LI_CODIGO,
            this.LI_DESC,
            this.LI_AUTOR,
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
            this.LI_PEDIDOS,
            this.LI_PRECIOARTDI,
            this.LI_PRECIOAN,
            this.LI_INVENTA,
            this.LI_FEC_INVEN});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LI_CODIGO", this.LI_CODIGO, "")});
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            this.gridViewPintarFilas.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.LI_AUTOR, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewPintarFilas.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewPintarFilas_FocusedRowChanged);
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
            // LI_AUTOR
            // 
            this.LI_AUTOR.Caption = "Autor";
            this.LI_AUTOR.FieldName = "LI_AUTOR";
            this.LI_AUTOR.Name = "LI_AUTOR";
            // 
            // EDI_EDITORIAL
            // 
            this.EDI_EDITORIAL.Caption = "MARCA";
            this.EDI_EDITORIAL.FieldName = "EDI_EDITORIAL";
            this.EDI_EDITORIAL.Name = "EDI_EDITORIAL";
            this.EDI_EDITORIAL.Visible = true;
            this.EDI_EDITORIAL.VisibleIndex = 2;
            // 
            // GEN_DESC
            // 
            this.GEN_DESC.Caption = "Tipo";
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
            // 
            // LI_ISBN
            // 
            this.LI_ISBN.Caption = "Isbn";
            this.LI_ISBN.FieldName = "LI_ISBN";
            this.LI_ISBN.Name = "LI_ISBN";
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
            this.LI_BARRA.VisibleIndex = 6;
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
            // LI_PEDIDOS
            // 
            this.LI_PEDIDOS.Caption = "Pedidos";
            this.LI_PEDIDOS.FieldName = "LI_PEDIDOS";
            this.LI_PEDIDOS.Name = "LI_PEDIDOS";
            this.LI_PEDIDOS.Visible = true;
            this.LI_PEDIDOS.VisibleIndex = 7;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lUEgenero);
            this.panel1.Controls.Add(this.cBEeditorial);
            this.panel1.Controls.Add(this.blimpiar);
            this.panel1.Controls.Add(this.chbpalabra);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.bbuscar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txttitulo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(321, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 108);
            this.panel1.TabIndex = 17;
            // 
            // lUEgenero
            // 
            this.lUEgenero.Location = new System.Drawing.Point(356, 8);
            this.lUEgenero.Name = "lUEgenero";
            this.lUEgenero.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.lUEgenero.Properties.Appearance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lUEgenero.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUEgenero.Properties.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lUEgenero.Properties.Appearance.Options.UseBackColor = true;
            this.lUEgenero.Properties.Appearance.Options.UseFont = true;
            this.lUEgenero.Properties.Appearance.Options.UseForeColor = true;
            this.lUEgenero.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lUEgenero.Properties.DropDownRows = 5;
            this.lUEgenero.Properties.HideSelection = false;
            this.lUEgenero.Properties.NullText = "";
            this.lUEgenero.Properties.ShowHeader = false;
            this.lUEgenero.Size = new System.Drawing.Size(159, 22);
            this.lUEgenero.TabIndex = 185;
            // 
            // cBEeditorial
            // 
            this.cBEeditorial.Location = new System.Drawing.Point(58, 51);
            this.cBEeditorial.Name = "cBEeditorial";
            this.cBEeditorial.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.cBEeditorial.Properties.Appearance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cBEeditorial.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBEeditorial.Properties.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cBEeditorial.Properties.Appearance.Options.UseBackColor = true;
            this.cBEeditorial.Properties.Appearance.Options.UseFont = true;
            this.cBEeditorial.Properties.Appearance.Options.UseForeColor = true;
            this.cBEeditorial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cBEeditorial.Properties.DropDownRows = 5;
            this.cBEeditorial.Properties.HideSelection = false;
            this.cBEeditorial.Properties.NullText = "";
            this.cBEeditorial.Properties.ShowHeader = false;
            this.cBEeditorial.Size = new System.Drawing.Size(243, 22);
            this.cBEeditorial.TabIndex = 184;
            // 
            // blimpiar
            // 
            this.blimpiar.Image = global::Presentacion.Properties.Resources.limpiar32;
            this.blimpiar.Location = new System.Drawing.Point(438, 58);
            this.blimpiar.Name = "blimpiar";
            this.blimpiar.Size = new System.Drawing.Size(60, 39);
            this.blimpiar.TabIndex = 24;
            this.blimpiar.UseVisualStyleBackColor = true;
            this.blimpiar.Click += new System.EventHandler(this.blimpiar_Click);
            // 
            // chbpalabra
            // 
            this.chbpalabra.AutoSize = true;
            this.chbpalabra.Location = new System.Drawing.Point(352, 40);
            this.chbpalabra.Name = "chbpalabra";
            this.chbpalabra.Size = new System.Drawing.Size(143, 17);
            this.chbpalabra.TabIndex = 23;
            this.chbpalabra.Text = "Que contenga la palabra";
            this.chbpalabra.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(323, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tipo:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bbuscar
            // 
            this.bbuscar.Image = global::Presentacion.Properties.Resources.buscar32;
            this.bbuscar.Location = new System.Drawing.Point(372, 58);
            this.bbuscar.Name = "bbuscar";
            this.bbuscar.Size = new System.Drawing.Size(60, 39);
            this.bbuscar.TabIndex = 19;
            this.bbuscar.UseVisualStyleBackColor = true;
            this.bbuscar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Marca:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(58, 17);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(244, 20);
            this.txttitulo.TabIndex = 12;
            this.txttitulo.Enter += new System.EventHandler(this.txttitulo_Enter);
            this.txttitulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttitulo_KeyPress);
            this.txttitulo.Leave += new System.EventHandler(this.txttitulo_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Título:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(46, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cierre X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Image = global::Presentacion.Properties.Resources.exit48;
            this.btnSalir.Location = new System.Drawing.Point(933, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(48, 48);
            this.btnSalir.TabIndex = 181;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtprovee);
            this.panel8.Controls.Add(this.label23);
            this.panel8.Controls.Add(this.txtcodigo);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.txtbarra);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Location = new System.Drawing.Point(136, 12);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(174, 108);
            this.panel8.TabIndex = 186;
            // 
            // txtprovee
            // 
            this.txtprovee.BackColor = System.Drawing.Color.White;
            this.txtprovee.Location = new System.Drawing.Point(49, 79);
            this.txtprovee.Name = "txtprovee";
            this.txtprovee.Size = new System.Drawing.Size(73, 20);
            this.txtprovee.TabIndex = 26;
            this.txtprovee.TextChanged += new System.EventHandler(this.txtprovee_TextChanged);
            this.txtprovee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtprovee_KeyPress);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(2, 81);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 13);
            this.label23.TabIndex = 27;
            this.label23.Text = "Provee:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtcodigo.Location = new System.Drawing.Point(49, 41);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(55, 20);
            this.txtcodigo.TabIndex = 22;
            this.txtcodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodigo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Código:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbarra
            // 
            this.txtbarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtbarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbarra.ForeColor = System.Drawing.Color.Maroon;
            this.txtbarra.Location = new System.Drawing.Point(49, 5);
            this.txtbarra.Name = "txtbarra";
            this.txtbarra.Size = new System.Drawing.Size(121, 22);
            this.txtbarra.TabIndex = 20;
            this.txtbarra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbarra_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Barra:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtporcentaje
            // 
            this.txtporcentaje.BackColor = System.Drawing.Color.MintCream;
            this.txtporcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtporcentaje.Location = new System.Drawing.Point(401, 578);
            this.txtporcentaje.Name = "txtporcentaje";
            this.txtporcentaje.Size = new System.Drawing.Size(62, 31);
            this.txtporcentaje.TabIndex = 187;
            this.txtporcentaje.Tag = "";
            this.txtporcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 562);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 188;
            this.label2.Text = "Porcentaje";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Image = global::Presentacion.Properties.Resources.editar321;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(496, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 47);
            this.button1.TabIndex = 189;
            this.button1.Text = "Cambiar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // ConsultaProductosPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtporcentaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gConsulta);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaProductosPrecio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de productos...";
            this.Load += new System.EventHandler(this.ConsultaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lUEgenero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBEeditorial.Properties)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bbuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckBox chbpalabra;
        private System.Windows.Forms.Button blimpiar;
        private DevExpress.XtraEditors.LookUpEdit cBEeditorial;
        private DevExpress.XtraEditors.LookUpEdit lUEgenero;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbarra;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn LI_CODIGO;
        private DevExpress.XtraGrid.Columns.GridColumn LI_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn LI_AUTOR;
        private DevExpress.XtraGrid.Columns.GridColumn EDI_EDITORIAL;
        private DevExpress.XtraGrid.Columns.GridColumn GEN_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn LI_PRECIO;
        private DevExpress.XtraGrid.Columns.GridColumn LI_PROPIO;
        private DevExpress.XtraGrid.Columns.GridColumn LI_ISBN;
        private DevExpress.XtraGrid.Columns.GridColumn LI_STOCK;
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
        private DevExpress.XtraGrid.Columns.GridColumn LI_PEDIDOS;
        private DevExpress.XtraGrid.Columns.GridColumn LI_PRECIOARTDI;
        private System.Windows.Forms.TextBox txtprovee;
        private System.Windows.Forms.Label label23;
        private DevExpress.XtraGrid.Columns.GridColumn LI_PRECIOAN;
        private DevExpress.XtraGrid.Columns.GridColumn LI_INVENTA;
        private DevExpress.XtraGrid.Columns.GridColumn LI_FEC_INVEN;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtporcentaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}