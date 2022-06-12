namespace Presentacion
{
    partial class reservasentrefecha
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
            this.btncancelar = new System.Windows.Forms.Button();
            this.cmdmenugrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportarAExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarAPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btneliminar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.sfdRuta = new System.Windows.Forms.SaveFileDialog();
            this.sfdRuta1 = new System.Windows.Forms.SaveFileDialog();
            this.gBtipopro = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fechahasta = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.fechadesde = new DevExpress.XtraEditors.DateEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chbTitulo = new System.Windows.Forms.CheckBox();
            this.gConsulta = new DevExpress.XtraGrid.GridControl();
            this.gridViewPintarFilas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RESE_EDITORIAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_LI_CODIGOVIEJO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_AUTOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_CANTIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_FECHA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gConsulta1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MOV_FECHA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MOV_CANTIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MOV_REMITO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PROV_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.usuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gConsulta2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.REGV_FECHAVTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.REGV_CANTIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.REGV_NROVTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbpedidos = new System.Windows.Forms.LinkLabel();
            this.gConsulta4 = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdmenugrid.SuspendLayout();
            this.gBtipopro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fechahasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechahasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechadesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechadesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancel48;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(484, 493);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(87, 78);
            this.btncancelar.TabIndex = 197;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // cmdmenugrid
            // 
            this.cmdmenugrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarAExcelToolStripMenuItem,
            this.exportarAPDFToolStripMenuItem});
            this.cmdmenugrid.Name = "contextMenuStrip1";
            this.cmdmenugrid.Size = new System.Drawing.Size(158, 48);
            // 
            // exportarAExcelToolStripMenuItem
            // 
            this.exportarAExcelToolStripMenuItem.Name = "exportarAExcelToolStripMenuItem";
            this.exportarAExcelToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exportarAExcelToolStripMenuItem.Text = "Exportar a Excel";
            this.exportarAExcelToolStripMenuItem.Click += new System.EventHandler(this.exportarAExcelToolStripMenuItem_Click);
            // 
            // exportarAPDFToolStripMenuItem
            // 
            this.exportarAPDFToolStripMenuItem.Name = "exportarAPDFToolStripMenuItem";
            this.exportarAPDFToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exportarAPDFToolStripMenuItem.Text = "Exportar a PDF";
            this.exportarAPDFToolStripMenuItem.Click += new System.EventHandler(this.exportarAPDFToolStripMenuItem_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::Presentacion.Properties.Resources.prin48;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneliminar.Location = new System.Drawing.Point(386, 493);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(87, 78);
            this.btneliminar.TabIndex = 200;
            this.btneliminar.Text = "Imprimir";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Presentacion.Properties.Resources.excel32;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(155, 461);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(38, 35);
            this.panel2.TabIndex = 239;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Presentacion.Properties.Resources.pdf32;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(196, 461);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(38, 35);
            this.panel1.TabIndex = 238;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(12, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 237;
            this.label5.Text = "[click derecho para exportar]";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // sfdRuta
            // 
            this.sfdRuta.Filter = "Archivos Excel | *.xlsx";
            // 
            // sfdRuta1
            // 
            this.sfdRuta1.Filter = "Archivos PDF | *.pdf";
            // 
            // gBtipopro
            // 
            this.gBtipopro.Controls.Add(this.label3);
            this.gBtipopro.Controls.Add(this.fechahasta);
            this.gBtipopro.Controls.Add(this.label2);
            this.gBtipopro.Controls.Add(this.fechadesde);
            this.gBtipopro.Location = new System.Drawing.Point(221, 3);
            this.gBtipopro.Name = "gBtipopro";
            this.gBtipopro.Size = new System.Drawing.Size(440, 53);
            this.gBtipopro.TabIndex = 247;
            this.gBtipopro.TabStop = false;
            this.gBtipopro.Text = "Elegir las fechas...";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(225, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 208;
            this.label3.Text = "Fecha hasta:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fechahasta
            // 
            this.fechahasta.EditValue = null;
            this.fechahasta.Location = new System.Drawing.Point(327, 27);
            this.fechahasta.Name = "fechahasta";
            this.fechahasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fechahasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fechahasta.Size = new System.Drawing.Size(100, 20);
            this.fechahasta.TabIndex = 207;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(14, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 206;
            this.label2.Text = "Fecha desde:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fechadesde
            // 
            this.fechadesde.EditValue = null;
            this.fechadesde.Location = new System.Drawing.Point(116, 27);
            this.fechadesde.Name = "fechadesde";
            this.fechadesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fechadesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fechadesde.Size = new System.Drawing.Size(100, 20);
            this.fechadesde.TabIndex = 205;
            // 
            // button1
            // 
            this.button1.Image = global::Presentacion.Properties.Resources.buscar48;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(358, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 70);
            this.button1.TabIndex = 246;
            this.button1.Text = "Ver reservas";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Presentacion.Properties.Resources.salir48;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(489, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 70);
            this.button2.TabIndex = 245;
            this.button2.Text = "Salir";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // chbTitulo
            // 
            this.chbTitulo.AutoSize = true;
            this.chbTitulo.Checked = true;
            this.chbTitulo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTitulo.Location = new System.Drawing.Point(669, 17);
            this.chbTitulo.Name = "chbTitulo";
            this.chbTitulo.Size = new System.Drawing.Size(56, 17);
            this.chbTitulo.TabIndex = 244;
            this.chbTitulo.Text = "Todos";
            this.chbTitulo.UseVisualStyleBackColor = true;
            this.chbTitulo.CheckedChanged += new System.EventHandler(this.chbTitulo_CheckedChanged);
            // 
            // gConsulta
            // 
            this.gConsulta.Location = new System.Drawing.Point(12, 159);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(618, 301);
            this.gConsulta.TabIndex = 248;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            this.gConsulta.Click += new System.EventHandler(this.gConsulta_Click);
            // 
            // gridViewPintarFilas
            // 
            this.gridViewPintarFilas.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent;
            this.gridViewPintarFilas.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.Transparent;
            this.gridViewPintarFilas.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Transparent;
            this.gridViewPintarFilas.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridViewPintarFilas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewPintarFilas.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridViewPintarFilas.Appearance.SelectedRow.Options.UseFont = true;
            this.gridViewPintarFilas.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewPintarFilas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.RESE_EDITORIAL,
            this.RESE_LI_CODIGOVIEJO,
            this.RESE_DESC,
            this.RESE_AUTOR,
            this.RESE_CANTIDAD,
            this.RESE_FECHA,
            this.RESE_IDE,
            this.LI_IDE});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            this.gridViewPintarFilas.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewPintarFilas_FocusedRowChanged);
            // 
            // RESE_EDITORIAL
            // 
            this.RESE_EDITORIAL.Caption = "Editorial";
            this.RESE_EDITORIAL.FieldName = "RESE_EDITORIAL";
            this.RESE_EDITORIAL.MaxWidth = 120;
            this.RESE_EDITORIAL.MinWidth = 120;
            this.RESE_EDITORIAL.Name = "RESE_EDITORIAL";
            this.RESE_EDITORIAL.Visible = true;
            this.RESE_EDITORIAL.VisibleIndex = 0;
            this.RESE_EDITORIAL.Width = 120;
            // 
            // RESE_LI_CODIGOVIEJO
            // 
            this.RESE_LI_CODIGOVIEJO.Caption = "Código";
            this.RESE_LI_CODIGOVIEJO.FieldName = "RESE_LI_CODIGOVIEJO";
            this.RESE_LI_CODIGOVIEJO.MaxWidth = 60;
            this.RESE_LI_CODIGOVIEJO.MinWidth = 60;
            this.RESE_LI_CODIGOVIEJO.Name = "RESE_LI_CODIGOVIEJO";
            this.RESE_LI_CODIGOVIEJO.Visible = true;
            this.RESE_LI_CODIGOVIEJO.VisibleIndex = 1;
            this.RESE_LI_CODIGOVIEJO.Width = 60;
            // 
            // RESE_DESC
            // 
            this.RESE_DESC.Caption = "Descripción";
            this.RESE_DESC.FieldName = "RESE_DESC";
            this.RESE_DESC.MaxWidth = 200;
            this.RESE_DESC.MinWidth = 200;
            this.RESE_DESC.Name = "RESE_DESC";
            this.RESE_DESC.Visible = true;
            this.RESE_DESC.VisibleIndex = 2;
            this.RESE_DESC.Width = 200;
            // 
            // RESE_AUTOR
            // 
            this.RESE_AUTOR.Caption = "Autor";
            this.RESE_AUTOR.FieldName = "RESE_AUTOR";
            this.RESE_AUTOR.Name = "RESE_AUTOR";
            this.RESE_AUTOR.Visible = true;
            this.RESE_AUTOR.VisibleIndex = 3;
            // 
            // RESE_CANTIDAD
            // 
            this.RESE_CANTIDAD.Caption = "Cantidad";
            this.RESE_CANTIDAD.FieldName = "RESE_CANTIDAD";
            this.RESE_CANTIDAD.MaxWidth = 80;
            this.RESE_CANTIDAD.Name = "RESE_CANTIDAD";
            this.RESE_CANTIDAD.Visible = true;
            this.RESE_CANTIDAD.VisibleIndex = 4;
            this.RESE_CANTIDAD.Width = 80;
            // 
            // RESE_FECHA
            // 
            this.RESE_FECHA.Caption = "Fecha";
            this.RESE_FECHA.FieldName = "RESE_FECHA";
            this.RESE_FECHA.MaxWidth = 70;
            this.RESE_FECHA.MinWidth = 70;
            this.RESE_FECHA.Name = "RESE_FECHA";
            this.RESE_FECHA.Visible = true;
            this.RESE_FECHA.VisibleIndex = 5;
            this.RESE_FECHA.Width = 70;
            // 
            // RESE_IDE
            // 
            this.RESE_IDE.Caption = "RESE_IDE";
            this.RESE_IDE.FieldName = "RESE_IDE";
            this.RESE_IDE.Name = "RESE_IDE";
            // 
            // LI_IDE
            // 
            this.LI_IDE.Caption = "LI_IDE";
            this.LI_IDE.FieldName = "LI_IDE";
            this.LI_IDE.Name = "LI_IDE";
            // 
            // gConsulta1
            // 
            this.gConsulta1.ContextMenuStrip = this.cmdmenugrid;
            this.gConsulta1.Location = new System.Drawing.Point(636, 159);
            this.gConsulta1.MainView = this.gridView1;
            this.gConsulta1.Name = "gConsulta1";
            this.gConsulta1.Size = new System.Drawing.Size(275, 191);
            this.gConsulta1.TabIndex = 250;
            this.gConsulta1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MOV_FECHA,
            this.MOV_CANTIDAD,
            this.MOV_REMITO,
            this.PROV_DESC,
            this.usuario});
            this.gridView1.GridControl = this.gConsulta1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Cantidad", null, "(Cantidad: Recuento={0})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // MOV_FECHA
            // 
            this.MOV_FECHA.Caption = "Fecha";
            this.MOV_FECHA.FieldName = "MOV_FECHA";
            this.MOV_FECHA.MaxWidth = 80;
            this.MOV_FECHA.MinWidth = 80;
            this.MOV_FECHA.Name = "MOV_FECHA";
            this.MOV_FECHA.Visible = true;
            this.MOV_FECHA.VisibleIndex = 0;
            this.MOV_FECHA.Width = 80;
            // 
            // MOV_CANTIDAD
            // 
            this.MOV_CANTIDAD.Caption = "Cantidad";
            this.MOV_CANTIDAD.FieldName = "MOV_CANTIDAD";
            this.MOV_CANTIDAD.MaxWidth = 65;
            this.MOV_CANTIDAD.MinWidth = 65;
            this.MOV_CANTIDAD.Name = "MOV_CANTIDAD";
            this.MOV_CANTIDAD.Visible = true;
            this.MOV_CANTIDAD.VisibleIndex = 1;
            this.MOV_CANTIDAD.Width = 65;
            // 
            // MOV_REMITO
            // 
            this.MOV_REMITO.Caption = "Remito";
            this.MOV_REMITO.FieldName = "MOV_REMITO";
            this.MOV_REMITO.MaxWidth = 70;
            this.MOV_REMITO.MinWidth = 70;
            this.MOV_REMITO.Name = "MOV_REMITO";
            this.MOV_REMITO.Visible = true;
            this.MOV_REMITO.VisibleIndex = 2;
            this.MOV_REMITO.Width = 70;
            // 
            // PROV_DESC
            // 
            this.PROV_DESC.Caption = "Proveedor";
            this.PROV_DESC.FieldName = "PROV_DESC";
            this.PROV_DESC.Name = "PROV_DESC";
            this.PROV_DESC.Visible = true;
            this.PROV_DESC.VisibleIndex = 3;
            this.PROV_DESC.Width = 180;
            // 
            // usuario
            // 
            this.usuario.Caption = "Usuario";
            this.usuario.FieldName = "usuario";
            this.usuario.Name = "usuario";
            this.usuario.Visible = true;
            this.usuario.VisibleIndex = 4;
            this.usuario.Width = 90;
            // 
            // gConsulta2
            // 
            this.gConsulta2.ContextMenuStrip = this.cmdmenugrid;
            this.gConsulta2.Location = new System.Drawing.Point(636, 376);
            this.gConsulta2.MainView = this.gridView2;
            this.gConsulta2.Name = "gConsulta2";
            this.gConsulta2.Size = new System.Drawing.Size(275, 154);
            this.gConsulta2.TabIndex = 249;
            this.gConsulta2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.REGV_FECHAVTA,
            this.REGV_CANTIDAD,
            this.REGV_NROVTA,
            this.tipo});
            this.gridView2.GridControl = this.gConsulta2;
            this.gridView2.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Cantidad", null, "(Cantidad: Recuento={0})")});
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridView2.OptionsView.ShowFooter = true;
            // 
            // REGV_FECHAVTA
            // 
            this.REGV_FECHAVTA.Caption = "Fecha";
            this.REGV_FECHAVTA.FieldName = "REGV_FECHAVTA";
            this.REGV_FECHAVTA.MaxWidth = 70;
            this.REGV_FECHAVTA.MinWidth = 70;
            this.REGV_FECHAVTA.Name = "REGV_FECHAVTA";
            this.REGV_FECHAVTA.Visible = true;
            this.REGV_FECHAVTA.VisibleIndex = 0;
            this.REGV_FECHAVTA.Width = 70;
            // 
            // REGV_CANTIDAD
            // 
            this.REGV_CANTIDAD.Caption = "Cantidad";
            this.REGV_CANTIDAD.FieldName = "REGV_CANTIDAD";
            this.REGV_CANTIDAD.MaxWidth = 70;
            this.REGV_CANTIDAD.MinWidth = 70;
            this.REGV_CANTIDAD.Name = "REGV_CANTIDAD";
            this.REGV_CANTIDAD.Visible = true;
            this.REGV_CANTIDAD.VisibleIndex = 1;
            this.REGV_CANTIDAD.Width = 70;
            // 
            // REGV_NROVTA
            // 
            this.REGV_NROVTA.Caption = "Nro_Venta";
            this.REGV_NROVTA.FieldName = "REGV_NROVTA";
            this.REGV_NROVTA.Name = "REGV_NROVTA";
            this.REGV_NROVTA.Visible = true;
            this.REGV_NROVTA.VisibleIndex = 2;
            // 
            // tipo
            // 
            this.tipo.Caption = "Tipo";
            this.tipo.FieldName = "tipo";
            this.tipo.Name = "tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(636, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 17);
            this.label1.TabIndex = 251;
            this.label1.Text = "Movimientos (altas y bajas)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(636, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 252;
            this.label4.Text = "Ventas";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button3
            // 
            this.button3.Image = global::Presentacion.Properties.Resources.proforma48;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(287, 493);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 78);
            this.button3.TabIndex = 253;
            this.button3.Text = "Cargar al pedido";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.AliceBlue;
            this.label6.Location = new System.Drawing.Point(12, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 254;
            this.label6.Text = "Reservas";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbpedidos
            // 
            this.lbpedidos.AutoSize = true;
            this.lbpedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpedidos.ForeColor = System.Drawing.Color.SeaShell;
            this.lbpedidos.LinkColor = System.Drawing.Color.SeaShell;
            this.lbpedidos.Location = new System.Drawing.Point(636, 102);
            this.lbpedidos.Name = "lbpedidos";
            this.lbpedidos.Size = new System.Drawing.Size(153, 16);
            this.lbpedidos.TabIndex = 265;
            this.lbpedidos.TabStop = true;
            this.lbpedidos.Text = "Histórico de pedidos";
            this.lbpedidos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbpedidos_LinkClicked);
            // 
            // gConsulta4
            // 
            this.gConsulta4.Location = new System.Drawing.Point(634, 159);
            this.gConsulta4.MainView = this.gridView4;
            this.gConsulta4.Name = "gConsulta4";
            this.gConsulta4.Size = new System.Drawing.Size(277, 402);
            this.gConsulta4.TabIndex = 266;
            this.gConsulta4.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            this.gConsulta4.Visible = false;
            // 
            // gridView4
            // 
            this.gridView4.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent;
            this.gridView4.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.Transparent;
            this.gridView4.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Transparent;
            this.gridView4.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridView4.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridView4.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView4.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView4.GridControl = this.gConsulta4;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.Editable = false;
            this.gridView4.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridView4.OptionsView.ShowFooter = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Proveedor";
            this.gridColumn1.FieldName = "PROV_DESC";
            this.gridColumn1.MaxWidth = 120;
            this.gridColumn1.MinWidth = 120;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 120;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Fecha";
            this.gridColumn2.FieldName = "PED_FECHA";
            this.gridColumn2.MaxWidth = 60;
            this.gridColumn2.MinWidth = 60;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 60;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Cantidad";
            this.gridColumn3.FieldName = "PEDD_CANTIDAD";
            this.gridColumn3.MaxWidth = 50;
            this.gridColumn3.MinWidth = 50;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.AliceBlue;
            this.label7.Location = new System.Drawing.Point(649, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 17);
            this.label7.TabIndex = 267;
            this.label7.Text = "Pedidos realizados";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // reservasentrefecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(923, 581);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gConsulta4);
            this.Controls.Add(this.lbpedidos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gConsulta1);
            this.Controls.Add(this.gConsulta2);
            this.Controls.Add(this.gConsulta);
            this.Controls.Add(this.gBtipopro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chbTitulo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btncancelar);
            this.Name = "reservasentrefecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservas por fecha...";
            this.Load += new System.EventHandler(this.ConsultasConsignas_Load);
            this.cmdmenugrid.ResumeLayout(false);
            this.gBtipopro.ResumeLayout(false);
            this.gBtipopro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fechahasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechahasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechadesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechadesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip cmdmenugrid;
        private System.Windows.Forms.ToolStripMenuItem exportarAExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarAPDFToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.SaveFileDialog sfdRuta;
        private System.Windows.Forms.SaveFileDialog sfdRuta1;
        private System.Windows.Forms.GroupBox gBtipopro;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit fechahasta;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit fechadesde;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chbTitulo;
        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_LI_CODIGOVIEJO;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_AUTOR;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_EDITORIAL;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_CANTIDAD;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_FECHA;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_IDE;
        private DevExpress.XtraGrid.GridControl gConsulta1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MOV_FECHA;
        private DevExpress.XtraGrid.Columns.GridColumn MOV_CANTIDAD;
        private DevExpress.XtraGrid.Columns.GridColumn MOV_REMITO;
        private DevExpress.XtraGrid.Columns.GridColumn PROV_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn usuario;
        private DevExpress.XtraGrid.GridControl gConsulta2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn REGV_FECHAVTA;
        private DevExpress.XtraGrid.Columns.GridColumn REGV_CANTIDAD;
        private DevExpress.XtraGrid.Columns.GridColumn REGV_NROVTA;
        private DevExpress.XtraGrid.Columns.GridColumn tipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.Columns.GridColumn LI_IDE;
        private System.Windows.Forms.LinkLabel lbpedidos;
        private DevExpress.XtraGrid.GridControl gConsulta4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.Label label7;
    }
}