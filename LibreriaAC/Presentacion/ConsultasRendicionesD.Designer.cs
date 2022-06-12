namespace Presentacion
{
    partial class ConsultasRendicionesD
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
            this.gConsulta = new DevExpress.XtraGrid.GridControl();
            this.cmdmenugrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportarAExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarAPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewPintarFilas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PREN_FACTU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PREN_LI_CODIGOVIEJO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_BARRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_AUTOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PREN_CONSIGNA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PREN_CANTIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PREN_FECHAVTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PREN_IMPORTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EDI_EDITORIAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EDI_CALLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EDI_NRO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EDI_PORCEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btneliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbrendicion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.sfdRuta = new System.Windows.Forms.SaveFileDialog();
            this.sfdRuta1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.lbtotal = new System.Windows.Forms.Label();
            this.lbporcentaje = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbtotalg = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gConsulta2 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_CODIGOPROVEE = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            this.cmdmenugrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancelar64;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(423, 384);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(102, 87);
            this.btncancelar.TabIndex = 197;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // gConsulta
            // 
            this.gConsulta.ContextMenuStrip = this.cmdmenugrid;
            this.gConsulta.Location = new System.Drawing.Point(12, 36);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(810, 342);
            this.gConsulta.TabIndex = 195;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
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
            // gridViewPintarFilas
            // 
            this.gridViewPintarFilas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PREN_FACTU,
            this.PREN_LI_CODIGOVIEJO,
            this.LI_BARRA,
            this.LI_DESC,
            this.LI_AUTOR,
            this.PREN_CONSIGNA,
            this.PREN_CANTIDAD,
            this.PREN_FECHAVTA,
            this.PREN_IMPORTE,
            this.EDI_EDITORIAL,
            this.EDI_CALLE,
            this.EDI_NRO,
            this.EDI_PORCEN,
            this.LI_CODIGOPROVEE});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Max, null, this.EDI_PORCEN, "(Cantidad: Recuento={0})")});
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            // 
            // PREN_FACTU
            // 
            this.PREN_FACTU.Caption = "Factura";
            this.PREN_FACTU.FieldName = "PREN_FACTU";
            this.PREN_FACTU.MaxWidth = 70;
            this.PREN_FACTU.MinWidth = 70;
            this.PREN_FACTU.Name = "PREN_FACTU";
            this.PREN_FACTU.Visible = true;
            this.PREN_FACTU.VisibleIndex = 0;
            this.PREN_FACTU.Width = 70;
            // 
            // PREN_LI_CODIGOVIEJO
            // 
            this.PREN_LI_CODIGOVIEJO.Caption = "Código";
            this.PREN_LI_CODIGOVIEJO.FieldName = "PREN_LI_CODIGOVIEJO";
            this.PREN_LI_CODIGOVIEJO.MaxWidth = 70;
            this.PREN_LI_CODIGOVIEJO.MinWidth = 70;
            this.PREN_LI_CODIGOVIEJO.Name = "PREN_LI_CODIGOVIEJO";
            this.PREN_LI_CODIGOVIEJO.Visible = true;
            this.PREN_LI_CODIGOVIEJO.VisibleIndex = 1;
            this.PREN_LI_CODIGOVIEJO.Width = 70;
            // 
            // LI_BARRA
            // 
            this.LI_BARRA.Caption = "Barra";
            this.LI_BARRA.FieldName = "LI_BARRA";
            this.LI_BARRA.MaxWidth = 95;
            this.LI_BARRA.MinWidth = 95;
            this.LI_BARRA.Name = "LI_BARRA";
            this.LI_BARRA.Visible = true;
            this.LI_BARRA.VisibleIndex = 3;
            this.LI_BARRA.Width = 95;
            // 
            // LI_DESC
            // 
            this.LI_DESC.Caption = "Nombre";
            this.LI_DESC.FieldName = "LI_DESC";
            this.LI_DESC.MaxWidth = 300;
            this.LI_DESC.MinWidth = 300;
            this.LI_DESC.Name = "LI_DESC";
            this.LI_DESC.Visible = true;
            this.LI_DESC.VisibleIndex = 4;
            this.LI_DESC.Width = 300;
            // 
            // LI_AUTOR
            // 
            this.LI_AUTOR.Caption = "Autor";
            this.LI_AUTOR.FieldName = "LI_AUTOR";
            this.LI_AUTOR.MaxWidth = 120;
            this.LI_AUTOR.MinWidth = 120;
            this.LI_AUTOR.Name = "LI_AUTOR";
            this.LI_AUTOR.Visible = true;
            this.LI_AUTOR.VisibleIndex = 5;
            this.LI_AUTOR.Width = 120;
            // 
            // PREN_CONSIGNA
            // 
            this.PREN_CONSIGNA.Caption = "Consigna";
            this.PREN_CONSIGNA.FieldName = "PREN_CONSIGNA";
            this.PREN_CONSIGNA.MaxWidth = 70;
            this.PREN_CONSIGNA.MinWidth = 70;
            this.PREN_CONSIGNA.Name = "PREN_CONSIGNA";
            this.PREN_CONSIGNA.Visible = true;
            this.PREN_CONSIGNA.VisibleIndex = 6;
            this.PREN_CONSIGNA.Width = 70;
            // 
            // PREN_CANTIDAD
            // 
            this.PREN_CANTIDAD.Caption = "Cantidad";
            this.PREN_CANTIDAD.FieldName = "PREN_CANTIDAD";
            this.PREN_CANTIDAD.MaxWidth = 90;
            this.PREN_CANTIDAD.MinWidth = 90;
            this.PREN_CANTIDAD.Name = "PREN_CANTIDAD";
            this.PREN_CANTIDAD.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "PREN_CANTIDAD", "{0}")});
            this.PREN_CANTIDAD.Visible = true;
            this.PREN_CANTIDAD.VisibleIndex = 7;
            this.PREN_CANTIDAD.Width = 90;
            // 
            // PREN_FECHAVTA
            // 
            this.PREN_FECHAVTA.Caption = "Fecha_Venta";
            this.PREN_FECHAVTA.FieldName = "PREN_FECHAVTA";
            this.PREN_FECHAVTA.Name = "PREN_FECHAVTA";
            // 
            // PREN_IMPORTE
            // 
            this.PREN_IMPORTE.Caption = "Importe";
            this.PREN_IMPORTE.FieldName = "PREN_IMPORTE";
            this.PREN_IMPORTE.MinWidth = 50;
            this.PREN_IMPORTE.Name = "PREN_IMPORTE";
            this.PREN_IMPORTE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PREN_IMPORTE", "{0:#.##}")});
            this.PREN_IMPORTE.Visible = true;
            this.PREN_IMPORTE.VisibleIndex = 8;
            this.PREN_IMPORTE.Width = 50;
            // 
            // EDI_EDITORIAL
            // 
            this.EDI_EDITORIAL.Caption = "Editorial";
            this.EDI_EDITORIAL.FieldName = "EDI_EDITORIAL";
            this.EDI_EDITORIAL.Name = "EDI_EDITORIAL";
            // 
            // EDI_CALLE
            // 
            this.EDI_CALLE.Caption = "Calle";
            this.EDI_CALLE.FieldName = "EDI_CALLE";
            this.EDI_CALLE.Name = "EDI_CALLE";
            // 
            // EDI_NRO
            // 
            this.EDI_NRO.Caption = "Nro";
            this.EDI_NRO.FieldName = "EDI_NRO";
            this.EDI_NRO.Name = "EDI_NRO";
            // 
            // EDI_PORCEN
            // 
            this.EDI_PORCEN.Caption = "Porcentaje";
            this.EDI_PORCEN.FieldName = "EDI_PORCEN";
            this.EDI_PORCEN.Name = "EDI_PORCEN";
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::Presentacion.Properties.Resources.Impresora64;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneliminar.Location = new System.Drawing.Point(275, 384);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(102, 87);
            this.btneliminar.TabIndex = 200;
            this.btneliminar.Text = "Imprimir";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 201;
            this.label1.Text = "Número de Rendición:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbrendicion
            // 
            this.lbrendicion.AutoSize = true;
            this.lbrendicion.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrendicion.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbrendicion.Location = new System.Drawing.Point(174, 9);
            this.lbrendicion.Name = "lbrendicion";
            this.lbrendicion.Size = new System.Drawing.Size(0, 17);
            this.lbrendicion.TabIndex = 202;
            this.lbrendicion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Presentacion.Properties.Resources.excel32;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(175, 397);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(38, 35);
            this.panel2.TabIndex = 239;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Presentacion.Properties.Resources.pdf32;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(216, 397);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(38, 35);
            this.panel1.TabIndex = 238;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(32, 399);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(574, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 240;
            this.label2.Text = "SUBTOTAL";
            // 
            // lbtotal
            // 
            this.lbtotal.AutoSize = true;
            this.lbtotal.ForeColor = System.Drawing.Color.Firebrick;
            this.lbtotal.Location = new System.Drawing.Point(644, 397);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(13, 13);
            this.lbtotal.TabIndex = 241;
            this.lbtotal.Text = "0";
            // 
            // lbporcentaje
            // 
            this.lbporcentaje.AutoSize = true;
            this.lbporcentaje.ForeColor = System.Drawing.Color.Firebrick;
            this.lbporcentaje.Location = new System.Drawing.Point(644, 419);
            this.lbporcentaje.Name = "lbporcentaje";
            this.lbporcentaje.Size = new System.Drawing.Size(13, 13);
            this.lbporcentaje.TabIndex = 243;
            this.lbporcentaje.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(561, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 242;
            this.label4.Text = "PORCENTAJE";
            // 
            // lbtotalg
            // 
            this.lbtotalg.AutoSize = true;
            this.lbtotalg.ForeColor = System.Drawing.Color.Firebrick;
            this.lbtotalg.Location = new System.Drawing.Point(644, 441);
            this.lbtotalg.Name = "lbtotalg";
            this.lbtotalg.Size = new System.Drawing.Size(13, 13);
            this.lbtotalg.TabIndex = 245;
            this.lbtotalg.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(597, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 244;
            this.label6.Text = "TOTAL";
            // 
            // gConsulta2
            // 
            this.gConsulta2.ContextMenuStrip = this.cmdmenugrid;
            this.gConsulta2.Location = new System.Drawing.Point(52, 195);
            this.gConsulta2.MainView = this.gridView1;
            this.gConsulta2.Name = "gConsulta2";
            this.gConsulta2.Size = new System.Drawing.Size(493, 176);
            this.gConsulta2.TabIndex = 246;
            this.gConsulta2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gConsulta2.Visible = false;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13});
            this.gridView1.GridControl = this.gConsulta2;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Max, null, this.gridColumn13, "(Cantidad: Recuento={0})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Código";
            this.gridColumn2.FieldName = "PREN_LI_CODIGOVIEJO";
            this.gridColumn2.MaxWidth = 70;
            this.gridColumn2.MinWidth = 70;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 70;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Barra";
            this.gridColumn3.FieldName = "LI_BARRA";
            this.gridColumn3.MaxWidth = 85;
            this.gridColumn3.MinWidth = 85;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 85;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Nombre";
            this.gridColumn4.FieldName = "LI_DESC";
            this.gridColumn4.MaxWidth = 300;
            this.gridColumn4.MinWidth = 300;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 300;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Autor";
            this.gridColumn5.FieldName = "LI_AUTOR";
            this.gridColumn5.MaxWidth = 120;
            this.gridColumn5.MinWidth = 120;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 120;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Consigna";
            this.gridColumn6.FieldName = "PREN_CONSIGNA";
            this.gridColumn6.MaxWidth = 70;
            this.gridColumn6.MinWidth = 70;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 70;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Cantidad";
            this.gridColumn7.FieldName = "PREN_CANTIDAD";
            this.gridColumn7.MaxWidth = 90;
            this.gridColumn7.MinWidth = 90;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "PREN_CANTIDAD", "{0}")});
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            this.gridColumn7.Width = 90;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Fecha_Venta";
            this.gridColumn8.FieldName = "PREN_FECHAVTA";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Importe";
            this.gridColumn9.FieldName = "PREN_IMPORTE";
            this.gridColumn9.MinWidth = 50;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PREN_IMPORTE", "{0:#.##}")});
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 6;
            this.gridColumn9.Width = 50;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Editorial";
            this.gridColumn10.FieldName = "EDI_EDITORIAL";
            this.gridColumn10.Name = "gridColumn10";
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Calle";
            this.gridColumn11.FieldName = "EDI_CALLE";
            this.gridColumn11.Name = "gridColumn11";
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Nro";
            this.gridColumn12.FieldName = "EDI_NRO";
            this.gridColumn12.Name = "gridColumn12";
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Porcentaje";
            this.gridColumn13.FieldName = "EDI_PORCEN";
            this.gridColumn13.Name = "gridColumn13";
            // 
            // LI_CODIGOPROVEE
            // 
            this.LI_CODIGOPROVEE.Caption = "CodigoProvee";
            this.LI_CODIGOPROVEE.FieldName = "LI_CODIGOPROVEE";
            this.LI_CODIGOPROVEE.MaxWidth = 90;
            this.LI_CODIGOPROVEE.MinWidth = 90;
            this.LI_CODIGOPROVEE.Name = "LI_CODIGOPROVEE";
            this.LI_CODIGOPROVEE.Visible = true;
            this.LI_CODIGOPROVEE.VisibleIndex = 2;
            this.LI_CODIGOPROVEE.Width = 90;
            // 
            // ConsultasRendicionesD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(834, 482);
            this.Controls.Add(this.gConsulta2);
            this.Controls.Add(this.lbtotalg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbporcentaje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbtotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbrendicion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.gConsulta);
            this.Name = "ConsultasRendicionesD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles de la Rendición";
            this.Load += new System.EventHandler(this.ConsultasConsignas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            this.cmdmenugrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncancelar;
        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private DevExpress.XtraGrid.Columns.GridColumn PREN_FACTU;
        private DevExpress.XtraGrid.Columns.GridColumn PREN_LI_CODIGOVIEJO;
        private DevExpress.XtraGrid.Columns.GridColumn LI_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn LI_AUTOR;
        private DevExpress.XtraGrid.Columns.GridColumn PREN_CONSIGNA;
        private DevExpress.XtraGrid.Columns.GridColumn PREN_CANTIDAD;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbrendicion;
        private DevExpress.XtraGrid.Columns.GridColumn PREN_FECHAVTA;
        private DevExpress.XtraGrid.Columns.GridColumn PREN_IMPORTE;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip cmdmenugrid;
        private System.Windows.Forms.ToolStripMenuItem exportarAExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarAPDFToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.SaveFileDialog sfdRuta;
        private System.Windows.Forms.SaveFileDialog sfdRuta1;
        private DevExpress.XtraGrid.Columns.GridColumn EDI_EDITORIAL;
        private DevExpress.XtraGrid.Columns.GridColumn EDI_CALLE;
        private DevExpress.XtraGrid.Columns.GridColumn EDI_NRO;
        private DevExpress.XtraGrid.Columns.GridColumn EDI_PORCEN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbtotal;
        private System.Windows.Forms.Label lbporcentaje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbtotalg;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.Columns.GridColumn LI_BARRA;
        private DevExpress.XtraGrid.GridControl gConsulta2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn LI_CODIGOPROVEE;
    }
}