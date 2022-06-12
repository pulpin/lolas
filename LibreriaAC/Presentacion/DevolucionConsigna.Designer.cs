namespace Presentacion
{
    partial class DevolucionConsigna
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmdmenugrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportarAExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarAPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btneliminar = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.sfdRuta = new System.Windows.Forms.SaveFileDialog();
            this.sfdRuta1 = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtisbn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbarra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cBEeditorial = new DevExpress.XtraEditors.LookUpEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbdesc = new System.Windows.Forms.Label();
            this.lbautor = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gConsulta = new DevExpress.XtraGrid.GridControl();
            this.gridViewPintarFilas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CONS_REMITO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CONS_IMPORTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CONS_RENDIDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CONS_NROCONSIG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CONS_ORIGINAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CONS_FECCARGA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CONS_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtcantidaddev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttotalconsignado = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbcodigo = new System.Windows.Forms.Label();
            this.btngenerardevolucion = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DEV_REMITO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEV_CODIGOVIEJO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEV_CANTIORIGINAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEV_CANTIDEVOL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEV_IMPORTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.subtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_BARRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.txtobs = new System.Windows.Forms.RichTextBox();
            this.cmdmenugrid.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cBEeditorial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdmenugrid
            // 
            this.cmdmenugrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarAExcelToolStripMenuItem,
            this.exportarAPDFToolStripMenuItem});
            this.cmdmenugrid.Name = "contextMenuStrip1";
            this.cmdmenugrid.Size = new System.Drawing.Size(156, 48);
            // 
            // exportarAExcelToolStripMenuItem
            // 
            this.exportarAExcelToolStripMenuItem.Name = "exportarAExcelToolStripMenuItem";
            this.exportarAExcelToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exportarAExcelToolStripMenuItem.Text = "Exportar a Excel";
            this.exportarAExcelToolStripMenuItem.Click += new System.EventHandler(this.exportarAExcelToolStripMenuItem_Click);
            // 
            // exportarAPDFToolStripMenuItem
            // 
            this.exportarAPDFToolStripMenuItem.Name = "exportarAPDFToolStripMenuItem";
            this.exportarAPDFToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exportarAPDFToolStripMenuItem.Text = "Exportar a PDF";
            this.exportarAPDFToolStripMenuItem.Click += new System.EventHandler(this.exportarAPDFToolStripMenuItem_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::Presentacion.Properties.Resources.prin48;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneliminar.Location = new System.Drawing.Point(484, 502);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(90, 67);
            this.btneliminar.TabIndex = 200;
            this.btneliminar.Text = "Imprimir";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Visible = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
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
            // button2
            // 
            this.button2.Image = global::Presentacion.Properties.Resources.salir48;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(772, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 67);
            this.button2.TabIndex = 245;
            this.button2.Text = "Salir";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(601, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 251;
            this.label1.Text = "Detalle a devolver";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button3
            // 
            this.button3.Image = global::Presentacion.Properties.Resources.ok32;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(285, 465);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 57);
            this.button3.TabIndex = 253;
            this.button3.Text = "Aceptar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label6.Location = new System.Drawing.Point(12, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 254;
            this.label6.Text = "Consignas";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtisbn);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.txtcodigo);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.txtbarra);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Location = new System.Drawing.Point(12, 36);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(147, 100);
            this.panel8.TabIndex = 255;
            // 
            // txtisbn
            // 
            this.txtisbn.Location = new System.Drawing.Point(49, 40);
            this.txtisbn.Name = "txtisbn";
            this.txtisbn.Size = new System.Drawing.Size(73, 20);
            this.txtisbn.TabIndex = 24;
            this.txtisbn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtisbn_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "ISBN:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(49, 75);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(55, 20);
            this.txtcodigo.TabIndex = 22;
            this.txtcodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodigo_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Código:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbarra
            // 
            this.txtbarra.Location = new System.Drawing.Point(49, 5);
            this.txtbarra.Name = "txtbarra";
            this.txtbarra.Size = new System.Drawing.Size(94, 20);
            this.txtbarra.TabIndex = 20;
            this.txtbarra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbarra_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Barra:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cBEeditorial
            // 
            this.cBEeditorial.Location = new System.Drawing.Point(61, 12);
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
            this.cBEeditorial.Size = new System.Drawing.Size(355, 22);
            this.cBEeditorial.TabIndex = 257;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 256;
            this.label10.Text = "Editorial:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(183, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 258;
            this.label11.Text = "Producto:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbdesc
            // 
            this.lbdesc.AutoSize = true;
            this.lbdesc.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdesc.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbdesc.Location = new System.Drawing.Point(183, 76);
            this.lbdesc.Name = "lbdesc";
            this.lbdesc.Size = new System.Drawing.Size(0, 17);
            this.lbdesc.TabIndex = 259;
            this.lbdesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbautor
            // 
            this.lbautor.AutoSize = true;
            this.lbautor.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbautor.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbautor.Location = new System.Drawing.Point(183, 115);
            this.lbautor.Name = "lbautor";
            this.lbautor.Size = new System.Drawing.Size(0, 17);
            this.lbautor.TabIndex = 261;
            this.lbautor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(183, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 260;
            this.label14.Text = "Autor:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gConsulta
            // 
            this.gConsulta.ContextMenuStrip = this.cmdmenugrid;
            this.gConsulta.Location = new System.Drawing.Point(9, 159);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(446, 288);
            this.gConsulta.TabIndex = 262;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            // 
            // gridViewPintarFilas
            // 
            this.gridViewPintarFilas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CONS_REMITO,
            this.total,
            this.CONS_IMPORTE,
            this.CONS_RENDIDO,
            this.CONS_NROCONSIG,
            this.CONS_ORIGINAL,
            this.CONS_FECCARGA,
            this.CONS_IDE,
            this.barra});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Cantidad", null, "(Cantidad: Recuento={0})")});
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            // 
            // CONS_REMITO
            // 
            this.CONS_REMITO.Caption = "Remito";
            this.CONS_REMITO.FieldName = "CONS_REMITO";
            this.CONS_REMITO.MaxWidth = 80;
            this.CONS_REMITO.MinWidth = 80;
            this.CONS_REMITO.Name = "CONS_REMITO";
            this.CONS_REMITO.Visible = true;
            this.CONS_REMITO.VisibleIndex = 0;
            this.CONS_REMITO.Width = 80;
            // 
            // total
            // 
            this.total.Caption = "Cantidad";
            this.total.FieldName = "CONS_CANTIDAD";
            this.total.MaxWidth = 80;
            this.total.MinWidth = 80;
            this.total.Name = "total";
            this.total.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CONS_CANTIDAD", "{0:#.##}")});
            this.total.Visible = true;
            this.total.VisibleIndex = 1;
            this.total.Width = 80;
            // 
            // CONS_IMPORTE
            // 
            this.CONS_IMPORTE.Caption = "Importe";
            this.CONS_IMPORTE.FieldName = "CONS_IMPORTE";
            this.CONS_IMPORTE.MaxWidth = 80;
            this.CONS_IMPORTE.MinWidth = 80;
            this.CONS_IMPORTE.Name = "CONS_IMPORTE";
            this.CONS_IMPORTE.Visible = true;
            this.CONS_IMPORTE.VisibleIndex = 2;
            this.CONS_IMPORTE.Width = 80;
            // 
            // CONS_RENDIDO
            // 
            this.CONS_RENDIDO.Caption = "Rendido";
            this.CONS_RENDIDO.FieldName = "CONS_RENDIDO";
            this.CONS_RENDIDO.MaxWidth = 60;
            this.CONS_RENDIDO.MinWidth = 60;
            this.CONS_RENDIDO.Name = "CONS_RENDIDO";
            this.CONS_RENDIDO.Visible = true;
            this.CONS_RENDIDO.VisibleIndex = 3;
            this.CONS_RENDIDO.Width = 60;
            // 
            // CONS_NROCONSIG
            // 
            this.CONS_NROCONSIG.Caption = "Consigna";
            this.CONS_NROCONSIG.FieldName = "CONS_NROCONSIG";
            this.CONS_NROCONSIG.MaxWidth = 60;
            this.CONS_NROCONSIG.MinWidth = 60;
            this.CONS_NROCONSIG.Name = "CONS_NROCONSIG";
            this.CONS_NROCONSIG.Visible = true;
            this.CONS_NROCONSIG.VisibleIndex = 4;
            this.CONS_NROCONSIG.Width = 60;
            // 
            // CONS_ORIGINAL
            // 
            this.CONS_ORIGINAL.Caption = "Original";
            this.CONS_ORIGINAL.FieldName = "CONS_ORIGINAL";
            this.CONS_ORIGINAL.MaxWidth = 45;
            this.CONS_ORIGINAL.MinWidth = 45;
            this.CONS_ORIGINAL.Name = "CONS_ORIGINAL";
            this.CONS_ORIGINAL.Visible = true;
            this.CONS_ORIGINAL.VisibleIndex = 5;
            this.CONS_ORIGINAL.Width = 45;
            // 
            // CONS_FECCARGA
            // 
            this.CONS_FECCARGA.Caption = "Fecha_carga";
            this.CONS_FECCARGA.FieldName = "CONS_FECCARGA";
            this.CONS_FECCARGA.Name = "CONS_FECCARGA";
            this.CONS_FECCARGA.Visible = true;
            this.CONS_FECCARGA.VisibleIndex = 6;
            this.CONS_FECCARGA.Width = 41;
            // 
            // CONS_IDE
            // 
            this.CONS_IDE.Caption = "CONS_IDE";
            this.CONS_IDE.FieldName = "CONS_IDE";
            this.CONS_IDE.Name = "CONS_IDE";
            // 
            // barra
            // 
            this.barra.Caption = "barra";
            this.barra.FieldName = "barra";
            this.barra.Name = "barra";
            this.barra.Visible = true;
            this.barra.VisibleIndex = 7;
            // 
            // txtcantidaddev
            // 
            this.txtcantidaddev.Location = new System.Drawing.Point(183, 490);
            this.txtcantidaddev.Name = "txtcantidaddev";
            this.txtcantidaddev.Size = new System.Drawing.Size(55, 20);
            this.txtcantidaddev.TabIndex = 263;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 264;
            this.label2.Text = "Cantidad a devolver";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 265;
            this.label3.Text = "Total consignado";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txttotalconsignado
            // 
            this.txttotalconsignado.Enabled = false;
            this.txttotalconsignado.Location = new System.Drawing.Point(70, 490);
            this.txttotalconsignado.Name = "txttotalconsignado";
            this.txttotalconsignado.Size = new System.Drawing.Size(55, 20);
            this.txttotalconsignado.TabIndex = 266;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(480, 159);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(431, 288);
            this.dgvProductos.TabIndex = 267;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 268;
            this.label4.Text = "Código:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.AliceBlue;
            this.label5.Location = new System.Drawing.Point(461, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 269;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbcodigo
            // 
            this.lbcodigo.AutoSize = true;
            this.lbcodigo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcodigo.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbcodigo.Location = new System.Drawing.Point(226, 36);
            this.lbcodigo.Name = "lbcodigo";
            this.lbcodigo.Size = new System.Drawing.Size(0, 17);
            this.lbcodigo.TabIndex = 270;
            this.lbcodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btngenerardevolucion
            // 
            this.btngenerardevolucion.Image = global::Presentacion.Properties.Resources.ajuste32;
            this.btngenerardevolucion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btngenerardevolucion.Location = new System.Drawing.Point(592, 502);
            this.btngenerardevolucion.Name = "btngenerardevolucion";
            this.btngenerardevolucion.Size = new System.Drawing.Size(90, 67);
            this.btngenerardevolucion.TabIndex = 271;
            this.btngenerardevolucion.Text = "Generar devolución";
            this.btngenerardevolucion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btngenerardevolucion.UseVisualStyleBackColor = true;
            this.btngenerardevolucion.Click += new System.EventHandler(this.btngenerardevolucion_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.cmdmenugrid;
            this.gridControl1.Location = new System.Drawing.Point(379, 192);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(382, 194);
            this.gridControl1.TabIndex = 272;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Visible = false;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DEV_REMITO,
            this.DEV_CODIGOVIEJO,
            this.LI_DESC,
            this.DEV_CANTIORIGINAL,
            this.DEV_CANTIDEVOL,
            this.DEV_IMPORTE,
            this.subtotal,
            this.LI_BARRA});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Cantidad", null, "(Cantidad: Recuento={0})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // DEV_REMITO
            // 
            this.DEV_REMITO.Caption = "Remito";
            this.DEV_REMITO.FieldName = "DEV_REMITO";
            this.DEV_REMITO.MaxWidth = 120;
            this.DEV_REMITO.MinWidth = 120;
            this.DEV_REMITO.Name = "DEV_REMITO";
            this.DEV_REMITO.Visible = true;
            this.DEV_REMITO.VisibleIndex = 0;
            this.DEV_REMITO.Width = 120;
            // 
            // DEV_CODIGOVIEJO
            // 
            this.DEV_CODIGOVIEJO.Caption = "Código";
            this.DEV_CODIGOVIEJO.FieldName = "DEV_CODIGOVIEJO";
            this.DEV_CODIGOVIEJO.MaxWidth = 120;
            this.DEV_CODIGOVIEJO.MinWidth = 120;
            this.DEV_CODIGOVIEJO.Name = "DEV_CODIGOVIEJO";
            this.DEV_CODIGOVIEJO.Visible = true;
            this.DEV_CODIGOVIEJO.VisibleIndex = 2;
            this.DEV_CODIGOVIEJO.Width = 120;
            // 
            // LI_DESC
            // 
            this.LI_DESC.Caption = "Desc";
            this.LI_DESC.FieldName = "LI_DESC";
            this.LI_DESC.MaxWidth = 200;
            this.LI_DESC.MinWidth = 200;
            this.LI_DESC.Name = "LI_DESC";
            this.LI_DESC.Visible = true;
            this.LI_DESC.VisibleIndex = 3;
            this.LI_DESC.Width = 200;
            // 
            // DEV_CANTIORIGINAL
            // 
            this.DEV_CANTIORIGINAL.Caption = "Cantidad";
            this.DEV_CANTIORIGINAL.FieldName = "DEV_CANTIORIGINAL";
            this.DEV_CANTIORIGINAL.MaxWidth = 85;
            this.DEV_CANTIORIGINAL.MinWidth = 85;
            this.DEV_CANTIORIGINAL.Name = "DEV_CANTIORIGINAL";
            this.DEV_CANTIORIGINAL.Visible = true;
            this.DEV_CANTIORIGINAL.VisibleIndex = 4;
            this.DEV_CANTIORIGINAL.Width = 85;
            // 
            // DEV_CANTIDEVOL
            // 
            this.DEV_CANTIDEVOL.Caption = "Devolución";
            this.DEV_CANTIDEVOL.FieldName = "DEV_CANTIDEVOL";
            this.DEV_CANTIDEVOL.MaxWidth = 95;
            this.DEV_CANTIDEVOL.MinWidth = 95;
            this.DEV_CANTIDEVOL.Name = "DEV_CANTIDEVOL";
            this.DEV_CANTIDEVOL.Visible = true;
            this.DEV_CANTIDEVOL.VisibleIndex = 5;
            this.DEV_CANTIDEVOL.Width = 95;
            // 
            // DEV_IMPORTE
            // 
            this.DEV_IMPORTE.Caption = "Importe";
            this.DEV_IMPORTE.FieldName = "DEV_IMPORTE";
            this.DEV_IMPORTE.MaxWidth = 130;
            this.DEV_IMPORTE.MinWidth = 130;
            this.DEV_IMPORTE.Name = "DEV_IMPORTE";
            this.DEV_IMPORTE.Visible = true;
            this.DEV_IMPORTE.VisibleIndex = 6;
            this.DEV_IMPORTE.Width = 130;
            // 
            // subtotal
            // 
            this.subtotal.Caption = "subtotal";
            this.subtotal.FieldName = "subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "subtotal", "Total={0:#.##}")});
            this.subtotal.Visible = true;
            this.subtotal.VisibleIndex = 7;
            // 
            // LI_BARRA
            // 
            this.LI_BARRA.Caption = "Barra";
            this.LI_BARRA.FieldName = "LI_BARRA";
            this.LI_BARRA.MaxWidth = 100;
            this.LI_BARRA.MinWidth = 100;
            this.LI_BARRA.Name = "LI_BARRA";
            this.LI_BARRA.Visible = true;
            this.LI_BARRA.VisibleIndex = 1;
            this.LI_BARRA.Width = 100;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(480, 454);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 17);
            this.label12.TabIndex = 274;
            this.label12.Text = "Observación:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtobs
            // 
            this.txtobs.Location = new System.Drawing.Point(573, 453);
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(338, 43);
            this.txtobs.TabIndex = 275;
            this.txtobs.Text = "";
            // 
            // DevolucionConsigna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(923, 581);
            this.Controls.Add(this.txtobs);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btngenerardevolucion);
            this.Controls.Add(this.lbcodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.txttotalconsignado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcantidaddev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gConsulta);
            this.Controls.Add(this.lbautor);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbdesc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cBEeditorial);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btneliminar);
            this.Name = "DevolucionConsigna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolución de consigna...";
            this.Load += new System.EventHandler(this.ConsultasConsignas_Load);
            this.cmdmenugrid.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cBEeditorial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.ContextMenuStrip cmdmenugrid;
        private System.Windows.Forms.ToolStripMenuItem exportarAExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarAPDFToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.SaveFileDialog sfdRuta;
        private System.Windows.Forms.SaveFileDialog sfdRuta1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtisbn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbarra;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.LookUpEdit cBEeditorial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbdesc;
        private System.Windows.Forms.Label lbautor;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private DevExpress.XtraGrid.Columns.GridColumn CONS_REMITO;
        private DevExpress.XtraGrid.Columns.GridColumn total;
        private DevExpress.XtraGrid.Columns.GridColumn CONS_IMPORTE;
        private DevExpress.XtraGrid.Columns.GridColumn CONS_RENDIDO;
        private DevExpress.XtraGrid.Columns.GridColumn CONS_NROCONSIG;
        private DevExpress.XtraGrid.Columns.GridColumn CONS_ORIGINAL;
        private DevExpress.XtraGrid.Columns.GridColumn CONS_FECCARGA;
        private System.Windows.Forms.TextBox txtcantidaddev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttotalconsignado;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbcodigo;
        private System.Windows.Forms.Button btngenerardevolucion;
        private DevExpress.XtraGrid.Columns.GridColumn CONS_IDE;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn DEV_REMITO;
        private DevExpress.XtraGrid.Columns.GridColumn DEV_CODIGOVIEJO;
        private DevExpress.XtraGrid.Columns.GridColumn LI_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn DEV_CANTIORIGINAL;
        private DevExpress.XtraGrid.Columns.GridColumn DEV_CANTIDEVOL;
        private DevExpress.XtraGrid.Columns.GridColumn DEV_IMPORTE;
        private DevExpress.XtraGrid.Columns.GridColumn subtotal;
        private DevExpress.XtraGrid.Columns.GridColumn barra;
        private DevExpress.XtraGrid.Columns.GridColumn LI_BARRA;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox txtobs;
    }
}