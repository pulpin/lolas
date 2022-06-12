namespace Presentacion
{
    partial class MovimientosdeProducto
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
            this.cmdmenugrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportarAExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarAPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btneliminar = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.sfdRuta = new System.Windows.Forms.SaveFileDialog();
            this.sfdRuta1 = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbcodigo = new System.Windows.Forms.Label();
            this.gConsulta1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PREN_LI_CODIGOVIEJO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.gConsulta3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PREN_FACTU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PREN_CANTIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PREN_FECHAVTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PREN_IMPORTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PREN_CONSIGNA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PREN_NRORENDICION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PREN_FECHARENDI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gConsulta2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DEV_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEV_REMITO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEV_NROCONSIGNA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEV_CANTIORIGINAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEV_CANTIDEVOL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEV_IMPORTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEVM_FECHA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEVM_OBS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnmovvtas = new System.Windows.Forms.Button();
            this.lbbaja = new System.Windows.Forms.Label();
            this.cmdmenugrid.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cBEeditorial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
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
            this.btneliminar.Location = new System.Drawing.Point(885, 519);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(87, 67);
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
            this.button2.Location = new System.Drawing.Point(885, 592);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 67);
            this.button2.TabIndex = 245;
            this.button2.Text = "Salir";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.panel8.Size = new System.Drawing.Size(147, 87);
            this.panel8.TabIndex = 255;
            // 
            // txtisbn
            // 
            this.txtisbn.Location = new System.Drawing.Point(49, 32);
            this.txtisbn.Name = "txtisbn";
            this.txtisbn.Size = new System.Drawing.Size(73, 20);
            this.txtisbn.TabIndex = 24;
            this.txtisbn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtisbn_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "ISBN:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(50, 60);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(55, 20);
            this.txtcodigo.TabIndex = 22;
            this.txtcodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodigo_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 62);
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
            this.cBEeditorial.Size = new System.Drawing.Size(339, 22);
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
            // gConsulta1
            // 
            this.gConsulta1.ContextMenuStrip = this.cmdmenugrid;
            this.gConsulta1.Location = new System.Drawing.Point(12, 166);
            this.gConsulta1.MainView = this.gridView1;
            this.gConsulta1.Name = "gConsulta1";
            this.gConsulta1.Size = new System.Drawing.Size(820, 153);
            this.gConsulta1.TabIndex = 276;
            this.gConsulta1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gConsulta1.Click += new System.EventHandler(this.gConsulta1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.PREN_LI_CODIGOVIEJO});
            this.gridView1.GridControl = this.gConsulta1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Cantidad", null, "(Cantidad: Recuento={0})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Consigna";
            this.gridColumn5.FieldName = "CONS_NROCONSIG";
            this.gridColumn5.MaxWidth = 70;
            this.gridColumn5.MinWidth = 70;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            this.gridColumn5.Width = 70;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Remito";
            this.gridColumn6.FieldName = "CONS_REMITO";
            this.gridColumn6.MaxWidth = 70;
            this.gridColumn6.MinWidth = 70;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 70;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Fecha_envio";
            this.gridColumn7.FieldName = "CONS_FECENVIO";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Fecha_recepción";
            this.gridColumn8.FieldName = "CONS_FECRECEP";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 3;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Cantidad";
            this.gridColumn9.FieldName = "CONS_CANTIDAD";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 4;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Importe";
            this.gridColumn10.FieldName = "CONS_IMPORTE";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 5;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Original";
            this.gridColumn11.FieldName = "CONS_ORIGINAL";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 6;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Rendido";
            this.gridColumn12.FieldName = "CONS_RENDIDO";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 7;
            // 
            // PREN_LI_CODIGOVIEJO
            // 
            this.PREN_LI_CODIGOVIEJO.Caption = "PREN_LI_CODIGOVIEJO";
            this.PREN_LI_CODIGOVIEJO.FieldName = "PREN_LI_CODIGOVIEJO";
            this.PREN_LI_CODIGOVIEJO.Name = "PREN_LI_CODIGOVIEJO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(12, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 275;
            this.label2.Text = "Rendiciones";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gConsulta3
            // 
            this.gConsulta3.ContextMenuStrip = this.cmdmenugrid;
            this.gConsulta3.Location = new System.Drawing.Point(12, 522);
            this.gConsulta3.MainView = this.gridView3;
            this.gConsulta3.Name = "gConsulta3";
            this.gConsulta3.Size = new System.Drawing.Size(820, 137);
            this.gConsulta3.TabIndex = 274;
            this.gConsulta3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PREN_FACTU,
            this.PREN_CANTIDAD,
            this.PREN_FECHAVTA,
            this.PREN_IMPORTE,
            this.PREN_CONSIGNA,
            this.PREN_NRORENDICION,
            this.PREN_FECHARENDI});
            this.gridView3.GridControl = this.gConsulta3;
            this.gridView3.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Cantidad", null, "(Cantidad: Recuento={0})")});
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridView3.OptionsView.ShowFooter = true;
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
            // PREN_CANTIDAD
            // 
            this.PREN_CANTIDAD.Caption = "Cantidad";
            this.PREN_CANTIDAD.FieldName = "PREN_CANTIDAD";
            this.PREN_CANTIDAD.MaxWidth = 70;
            this.PREN_CANTIDAD.MinWidth = 70;
            this.PREN_CANTIDAD.Name = "PREN_CANTIDAD";
            this.PREN_CANTIDAD.Visible = true;
            this.PREN_CANTIDAD.VisibleIndex = 1;
            this.PREN_CANTIDAD.Width = 70;
            // 
            // PREN_FECHAVTA
            // 
            this.PREN_FECHAVTA.Caption = "Fecha_vta";
            this.PREN_FECHAVTA.FieldName = "PREN_FECHAVTA";
            this.PREN_FECHAVTA.Name = "PREN_FECHAVTA";
            this.PREN_FECHAVTA.Visible = true;
            this.PREN_FECHAVTA.VisibleIndex = 2;
            // 
            // PREN_IMPORTE
            // 
            this.PREN_IMPORTE.Caption = "Importe";
            this.PREN_IMPORTE.FieldName = "PREN_IMPORTE";
            this.PREN_IMPORTE.Name = "PREN_IMPORTE";
            // 
            // PREN_CONSIGNA
            // 
            this.PREN_CONSIGNA.Caption = "Consigna";
            this.PREN_CONSIGNA.FieldName = "PREN_CONSIGNA";
            this.PREN_CONSIGNA.Name = "PREN_CONSIGNA";
            this.PREN_CONSIGNA.Visible = true;
            this.PREN_CONSIGNA.VisibleIndex = 3;
            // 
            // PREN_NRORENDICION
            // 
            this.PREN_NRORENDICION.Caption = "Rendición";
            this.PREN_NRORENDICION.FieldName = "PREN_NRORENDICION";
            this.PREN_NRORENDICION.Name = "PREN_NRORENDICION";
            this.PREN_NRORENDICION.Visible = true;
            this.PREN_NRORENDICION.VisibleIndex = 4;
            // 
            // PREN_FECHARENDI
            // 
            this.PREN_FECHARENDI.Caption = "Fecha_rendición";
            this.PREN_FECHARENDI.FieldName = "PREN_FECHARENDI";
            this.PREN_FECHARENDI.Name = "PREN_FECHARENDI";
            this.PREN_FECHARENDI.Visible = true;
            this.PREN_FECHARENDI.VisibleIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(11, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 273;
            this.label1.Text = "Devoluciones";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(11, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 272;
            this.label3.Text = "Consignas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gConsulta2
            // 
            this.gConsulta2.ContextMenuStrip = this.cmdmenugrid;
            this.gConsulta2.Location = new System.Drawing.Point(12, 342);
            this.gConsulta2.MainView = this.gridView2;
            this.gConsulta2.Name = "gConsulta2";
            this.gConsulta2.Size = new System.Drawing.Size(820, 154);
            this.gConsulta2.TabIndex = 271;
            this.gConsulta2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gConsulta2.DoubleClick += new System.EventHandler(this.gConsulta2_DoubleClick);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DEV_IDE,
            this.DEV_REMITO,
            this.DEV_NROCONSIGNA,
            this.DEV_CANTIORIGINAL,
            this.DEV_CANTIDEVOL,
            this.DEV_IMPORTE,
            this.DEVM_FECHA,
            this.DEVM_OBS});
            this.gridView2.GridControl = this.gConsulta2;
            this.gridView2.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Cantidad", null, "(Cantidad: Recuento={0})")});
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridView2.OptionsView.ShowFooter = true;
            // 
            // DEV_IDE
            // 
            this.DEV_IDE.Caption = "Devolución";
            this.DEV_IDE.FieldName = "DEV_IDE";
            this.DEV_IDE.MaxWidth = 70;
            this.DEV_IDE.MinWidth = 70;
            this.DEV_IDE.Name = "DEV_IDE";
            this.DEV_IDE.Visible = true;
            this.DEV_IDE.VisibleIndex = 0;
            this.DEV_IDE.Width = 70;
            // 
            // DEV_REMITO
            // 
            this.DEV_REMITO.Caption = "Remito";
            this.DEV_REMITO.FieldName = "DEV_REMITO";
            this.DEV_REMITO.MaxWidth = 70;
            this.DEV_REMITO.MinWidth = 70;
            this.DEV_REMITO.Name = "DEV_REMITO";
            this.DEV_REMITO.Visible = true;
            this.DEV_REMITO.VisibleIndex = 1;
            this.DEV_REMITO.Width = 70;
            // 
            // DEV_NROCONSIGNA
            // 
            this.DEV_NROCONSIGNA.Caption = "Consigna";
            this.DEV_NROCONSIGNA.FieldName = "DEV_NROCONSIGNA";
            this.DEV_NROCONSIGNA.Name = "DEV_NROCONSIGNA";
            this.DEV_NROCONSIGNA.Visible = true;
            this.DEV_NROCONSIGNA.VisibleIndex = 2;
            // 
            // DEV_CANTIORIGINAL
            // 
            this.DEV_CANTIORIGINAL.Caption = "Original";
            this.DEV_CANTIORIGINAL.FieldName = "DEV_CANTIORIGINAL";
            this.DEV_CANTIORIGINAL.Name = "DEV_CANTIORIGINAL";
            // 
            // DEV_CANTIDEVOL
            // 
            this.DEV_CANTIDEVOL.Caption = "Devueltos";
            this.DEV_CANTIDEVOL.FieldName = "DEV_CANTIDEVOL";
            this.DEV_CANTIDEVOL.Name = "DEV_CANTIDEVOL";
            this.DEV_CANTIDEVOL.Visible = true;
            this.DEV_CANTIDEVOL.VisibleIndex = 3;
            // 
            // DEV_IMPORTE
            // 
            this.DEV_IMPORTE.Caption = "Importe";
            this.DEV_IMPORTE.FieldName = "DEV_IMPORTE";
            this.DEV_IMPORTE.Name = "DEV_IMPORTE";
            this.DEV_IMPORTE.Visible = true;
            this.DEV_IMPORTE.VisibleIndex = 4;
            // 
            // DEVM_FECHA
            // 
            this.DEVM_FECHA.Caption = "Fecha";
            this.DEVM_FECHA.FieldName = "DEVM_FECHA";
            this.DEVM_FECHA.Name = "DEVM_FECHA";
            this.DEVM_FECHA.Visible = true;
            this.DEVM_FECHA.VisibleIndex = 5;
            // 
            // DEVM_OBS
            // 
            this.DEVM_OBS.Caption = "Observación";
            this.DEVM_OBS.FieldName = "DEVM_OBS";
            this.DEVM_OBS.Name = "DEVM_OBS";
            this.DEVM_OBS.Visible = true;
            this.DEVM_OBS.VisibleIndex = 6;
            // 
            // btnmovvtas
            // 
            this.btnmovvtas.Image = global::Presentacion.Properties.Resources.historico32;
            this.btnmovvtas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmovvtas.Location = new System.Drawing.Point(805, 43);
            this.btnmovvtas.Name = "btnmovvtas";
            this.btnmovvtas.Size = new System.Drawing.Size(84, 52);
            this.btnmovvtas.TabIndex = 277;
            this.btnmovvtas.Text = "Movimientos";
            this.btnmovvtas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmovvtas.UseVisualStyleBackColor = true;
            this.btnmovvtas.Click += new System.EventHandler(this.btnmovvtas_Click);
            // 
            // lbbaja
            // 
            this.lbbaja.AutoSize = true;
            this.lbbaja.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbaja.ForeColor = System.Drawing.Color.Red;
            this.lbbaja.Location = new System.Drawing.Point(416, 15);
            this.lbbaja.Name = "lbbaja";
            this.lbbaja.Size = new System.Drawing.Size(247, 17);
            this.lbbaja.TabIndex = 278;
            this.lbbaja.Text = "Atención! producto dado de BAJA.";
            this.lbbaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbbaja.Visible = false;
            // 
            // MovimientosdeProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 671);
            this.Controls.Add(this.lbbaja);
            this.Controls.Add(this.btnmovvtas);
            this.Controls.Add(this.gConsulta1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gConsulta3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gConsulta2);
            this.Controls.Add(this.lbcodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbautor);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbdesc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cBEeditorial);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btneliminar);
            this.Name = "MovimientosdeProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimientos de un producto...";
            this.Load += new System.EventHandler(this.ConsultasConsignas_Load);
            this.cmdmenugrid.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cBEeditorial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbcodigo;
        private DevExpress.XtraGrid.GridControl gConsulta1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gConsulta3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn PREN_FACTU;
        private DevExpress.XtraGrid.Columns.GridColumn PREN_CANTIDAD;
        private DevExpress.XtraGrid.Columns.GridColumn PREN_FECHAVTA;
        private DevExpress.XtraGrid.Columns.GridColumn PREN_IMPORTE;
        private DevExpress.XtraGrid.Columns.GridColumn PREN_CONSIGNA;
        private DevExpress.XtraGrid.Columns.GridColumn PREN_NRORENDICION;
        private DevExpress.XtraGrid.Columns.GridColumn PREN_FECHARENDI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl gConsulta2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn DEV_IDE;
        private DevExpress.XtraGrid.Columns.GridColumn DEV_REMITO;
        private DevExpress.XtraGrid.Columns.GridColumn DEV_NROCONSIGNA;
        private DevExpress.XtraGrid.Columns.GridColumn DEV_CANTIORIGINAL;
        private DevExpress.XtraGrid.Columns.GridColumn DEV_CANTIDEVOL;
        private DevExpress.XtraGrid.Columns.GridColumn DEV_IMPORTE;
        private System.Windows.Forms.Button btnmovvtas;
        private System.Windows.Forms.Label lbbaja;
        private DevExpress.XtraGrid.Columns.GridColumn PREN_LI_CODIGOVIEJO;
        private DevExpress.XtraGrid.Columns.GridColumn DEVM_FECHA;
        private DevExpress.XtraGrid.Columns.GridColumn DEVM_OBS;
    }
}