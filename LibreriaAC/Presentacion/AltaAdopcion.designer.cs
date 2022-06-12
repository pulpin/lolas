namespace Presentacion
{
    partial class AltaAdopcion
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
            this.label7 = new System.Windows.Forms.Label();
            this.LUEscuela = new DevExpress.XtraEditors.LookUpEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.lbfecha = new System.Windows.Forms.Label();
            this.conMSdebito = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMImaestro = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIvisaelectron = new System.Windows.Forms.ToolStripMenuItem();
            this.conMScredito = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tSMIeficaz = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMImaster = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMInaranja = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIplanz = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMItdf = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIvisa = new System.Windows.Forms.ToolStripMenuItem();
            this.conMScuotas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tSMI2cuotas = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMI3cuotas = new System.Windows.Forms.ToolStripMenuItem();
            this.ahora3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ahora6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btneliminaele = new System.Windows.Forms.Button();
            this.btnagregap = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gConsulta = new DevExpress.XtraGrid.GridControl();
            this.gridViewPintarFilas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LI_CODIGOVIEJO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EDI_EDITORIAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.area_desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.adod_ide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gConsultaD = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.doc_ayn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.doc_celular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.addc_ide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.luCurso = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.luDivision = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtalumnos = new System.Windows.Forms.TextBox();
            this.luLocalidad = new DevExpress.XtraEditors.LookUpEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.luTurnos = new DevExpress.XtraEditors.LookUpEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnaltadoc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.rTobs = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LUEscuela.Properties)).BeginInit();
            this.conMSdebito.SuspendLayout();
            this.conMScredito.SuspendLayout();
            this.conMScuotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gConsultaD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luCurso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luDivision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luLocalidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luTurnos.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label7.Location = new System.Drawing.Point(14, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 23);
            this.label7.TabIndex = 193;
            this.label7.Text = "Escuela";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LUEscuela
            // 
            this.LUEscuela.Enabled = false;
            this.LUEscuela.Location = new System.Drawing.Point(102, 14);
            this.LUEscuela.Name = "LUEscuela";
            this.LUEscuela.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.LUEscuela.Properties.Appearance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LUEscuela.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUEscuela.Properties.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LUEscuela.Properties.Appearance.Options.UseBackColor = true;
            this.LUEscuela.Properties.Appearance.Options.UseFont = true;
            this.LUEscuela.Properties.Appearance.Options.UseForeColor = true;
            this.LUEscuela.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEscuela.Properties.DropDownRows = 5;
            this.LUEscuela.Properties.HideSelection = false;
            this.LUEscuela.Properties.NullText = "";
            this.LUEscuela.Properties.ShowHeader = false;
            this.LUEscuela.Size = new System.Drawing.Size(179, 22);
            this.LUEscuela.TabIndex = 194;
            this.LUEscuela.EditValueChanged += new System.EventHandler(this.LUComprobante_EditValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label8.Location = new System.Drawing.Point(636, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 23);
            this.label8.TabIndex = 195;
            this.label8.Text = "Fecha";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfecha.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbfecha.Location = new System.Drawing.Point(707, 94);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(128, 23);
            this.lbfecha.TabIndex = 196;
            this.lbfecha.Text = "26/10/2016";
            this.lbfecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // conMSdebito
            // 
            this.conMSdebito.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMImaestro,
            this.TSMIvisaelectron});
            this.conMSdebito.Name = "contextMenuStrip1";
            this.conMSdebito.Size = new System.Drawing.Size(142, 48);
            // 
            // TSMImaestro
            // 
            this.TSMImaestro.Name = "TSMImaestro";
            this.TSMImaestro.Size = new System.Drawing.Size(141, 22);
            this.TSMImaestro.Text = "Maestro";
            this.TSMImaestro.Click += new System.EventHandler(this.TSMImaestro_Click);
            // 
            // TSMIvisaelectron
            // 
            this.TSMIvisaelectron.Name = "TSMIvisaelectron";
            this.TSMIvisaelectron.Size = new System.Drawing.Size(141, 22);
            this.TSMIvisaelectron.Text = "Visa Electrón";
            this.TSMIvisaelectron.Click += new System.EventHandler(this.TSMIvisaelectron_Click);
            // 
            // conMScredito
            // 
            this.conMScredito.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMIeficaz,
            this.tSMImaster,
            this.tSMInaranja,
            this.tSMIplanz,
            this.tSMItdf,
            this.tSMIvisa});
            this.conMScredito.Name = "contextMenuStrip1";
            this.conMScredito.Size = new System.Drawing.Size(116, 136);
            // 
            // tSMIeficaz
            // 
            this.tSMIeficaz.Name = "tSMIeficaz";
            this.tSMIeficaz.Size = new System.Drawing.Size(115, 22);
            this.tSMIeficaz.Text = "Eficaz";
            this.tSMIeficaz.Click += new System.EventHandler(this.tSMIeficaz_Click);
            // 
            // tSMImaster
            // 
            this.tSMImaster.Name = "tSMImaster";
            this.tSMImaster.Size = new System.Drawing.Size(115, 22);
            this.tSMImaster.Text = "Master";
            this.tSMImaster.Click += new System.EventHandler(this.tSMImaster_Click);
            // 
            // tSMInaranja
            // 
            this.tSMInaranja.Name = "tSMInaranja";
            this.tSMInaranja.Size = new System.Drawing.Size(115, 22);
            this.tSMInaranja.Text = "Naranja";
            this.tSMInaranja.Click += new System.EventHandler(this.tSMInaranja_Click);
            // 
            // tSMIplanz
            // 
            this.tSMIplanz.Name = "tSMIplanz";
            this.tSMIplanz.Size = new System.Drawing.Size(115, 22);
            this.tSMIplanz.Text = "Plan Z";
            this.tSMIplanz.Click += new System.EventHandler(this.tSMIplanz_Click);
            // 
            // tSMItdf
            // 
            this.tSMItdf.Name = "tSMItdf";
            this.tSMItdf.Size = new System.Drawing.Size(115, 22);
            this.tSMItdf.Text = "TDF";
            this.tSMItdf.Click += new System.EventHandler(this.tSMItdf_Click);
            // 
            // tSMIvisa
            // 
            this.tSMIvisa.Name = "tSMIvisa";
            this.tSMIvisa.Size = new System.Drawing.Size(115, 22);
            this.tSMIvisa.Text = "Visa";
            this.tSMIvisa.Click += new System.EventHandler(this.tSMIvisa_Click);
            // 
            // conMScuotas
            // 
            this.conMScuotas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMI2cuotas,
            this.tSMI3cuotas,
            this.ahora3ToolStripMenuItem,
            this.ahora6ToolStripMenuItem});
            this.conMScuotas.Name = "contextMenuStrip1";
            this.conMScuotas.Size = new System.Drawing.Size(119, 92);
            // 
            // tSMI2cuotas
            // 
            this.tSMI2cuotas.Name = "tSMI2cuotas";
            this.tSMI2cuotas.Size = new System.Drawing.Size(118, 22);
            this.tSMI2cuotas.Text = "2 cuotas";
            this.tSMI2cuotas.Click += new System.EventHandler(this.tSMI2cuotas_Click);
            // 
            // tSMI3cuotas
            // 
            this.tSMI3cuotas.Name = "tSMI3cuotas";
            this.tSMI3cuotas.Size = new System.Drawing.Size(118, 22);
            this.tSMI3cuotas.Text = "3 cuotas";
            this.tSMI3cuotas.Click += new System.EventHandler(this.tSMI3cuotas_Click);
            // 
            // ahora3ToolStripMenuItem
            // 
            this.ahora3ToolStripMenuItem.Name = "ahora3ToolStripMenuItem";
            this.ahora3ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.ahora3ToolStripMenuItem.Text = "Ahora 3";
            this.ahora3ToolStripMenuItem.Click += new System.EventHandler(this.ahora3ToolStripMenuItem_Click);
            // 
            // ahora6ToolStripMenuItem
            // 
            this.ahora6ToolStripMenuItem.Name = "ahora6ToolStripMenuItem";
            this.ahora6ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.ahora6ToolStripMenuItem.Text = "Ahora 6";
            this.ahora6ToolStripMenuItem.Click += new System.EventHandler(this.ahora6ToolStripMenuItem_Click);
            // 
            // btneliminaele
            // 
            this.btneliminaele.Enabled = false;
            this.btneliminaele.Image = global::Presentacion.Properties.Resources.eliminar32;
            this.btneliminaele.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneliminaele.Location = new System.Drawing.Point(613, 212);
            this.btneliminaele.Name = "btneliminaele";
            this.btneliminaele.Size = new System.Drawing.Size(43, 42);
            this.btneliminaele.TabIndex = 210;
            this.btneliminaele.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneliminaele.UseVisualStyleBackColor = true;
            this.btneliminaele.Click += new System.EventHandler(this.btneliminaele_Click);
            // 
            // btnagregap
            // 
            this.btnagregap.Enabled = false;
            this.btnagregap.Image = global::Presentacion.Properties.Resources.comprar32;
            this.btnagregap.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnagregap.Location = new System.Drawing.Point(856, 395);
            this.btnagregap.Name = "btnagregap";
            this.btnagregap.Size = new System.Drawing.Size(43, 42);
            this.btnagregap.TabIndex = 199;
            this.btnagregap.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnagregap.UseVisualStyleBackColor = true;
            this.btnagregap.Click += new System.EventHandler(this.btnagregap_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Image = global::Presentacion.Properties.Resources.exit48;
            this.btnSalir.Location = new System.Drawing.Point(962, 631);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(44, 48);
            this.btnSalir.TabIndex = 183;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gConsulta
            // 
            this.gConsulta.Location = new System.Drawing.Point(56, 380);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(794, 216);
            this.gConsulta.TabIndex = 231;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            // 
            // gridViewPintarFilas
            // 
            this.gridViewPintarFilas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.LI_CODIGOVIEJO,
            this.LI_DESC,
            this.EDI_EDITORIAL,
            this.area_desc,
            this.adod_ide});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            // 
            // LI_CODIGOVIEJO
            // 
            this.LI_CODIGOVIEJO.Caption = "Código";
            this.LI_CODIGOVIEJO.FieldName = "LI_CODIGOVIEJO";
            this.LI_CODIGOVIEJO.Name = "LI_CODIGOVIEJO";
            this.LI_CODIGOVIEJO.Visible = true;
            this.LI_CODIGOVIEJO.VisibleIndex = 0;
            this.LI_CODIGOVIEJO.Width = 59;
            // 
            // LI_DESC
            // 
            this.LI_DESC.Caption = "Producto";
            this.LI_DESC.FieldName = "LI_DESC";
            this.LI_DESC.Name = "LI_DESC";
            this.LI_DESC.Visible = true;
            this.LI_DESC.VisibleIndex = 1;
            this.LI_DESC.Width = 200;
            // 
            // EDI_EDITORIAL
            // 
            this.EDI_EDITORIAL.Caption = "Editorial";
            this.EDI_EDITORIAL.FieldName = "EDI_EDITORIAL";
            this.EDI_EDITORIAL.Name = "EDI_EDITORIAL";
            this.EDI_EDITORIAL.Visible = true;
            this.EDI_EDITORIAL.VisibleIndex = 3;
            // 
            // area_desc
            // 
            this.area_desc.Caption = "Area";
            this.area_desc.FieldName = "area_desc";
            this.area_desc.Name = "area_desc";
            this.area_desc.Visible = true;
            this.area_desc.VisibleIndex = 2;
            // 
            // adod_ide
            // 
            this.adod_ide.Caption = "adod_ide";
            this.adod_ide.FieldName = "adod_ide";
            this.adod_ide.Name = "adod_ide";
            // 
            // gConsultaD
            // 
            this.gConsultaD.Location = new System.Drawing.Point(56, 164);
            this.gConsultaD.MainView = this.gridView1;
            this.gConsultaD.Name = "gConsultaD";
            this.gConsultaD.Size = new System.Drawing.Size(551, 168);
            this.gConsultaD.TabIndex = 232;
            this.gConsultaD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.doc_ayn,
            this.doc_celular,
            this.addc_ide});
            this.gridView1.GridControl = this.gConsultaD;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // doc_ayn
            // 
            this.doc_ayn.Caption = "Docente";
            this.doc_ayn.FieldName = "doc_ayn";
            this.doc_ayn.Name = "doc_ayn";
            this.doc_ayn.Visible = true;
            this.doc_ayn.VisibleIndex = 0;
            this.doc_ayn.Width = 59;
            // 
            // doc_celular
            // 
            this.doc_celular.Caption = "Celular";
            this.doc_celular.FieldName = "doc_celular";
            this.doc_celular.Name = "doc_celular";
            this.doc_celular.Visible = true;
            this.doc_celular.VisibleIndex = 1;
            this.doc_celular.Width = 200;
            // 
            // addc_ide
            // 
            this.addc_ide.Caption = "addc_ide";
            this.addc_ide.FieldName = "addc_ide";
            this.addc_ide.Name = "addc_ide";
            // 
            // luCurso
            // 
            this.luCurso.Enabled = false;
            this.luCurso.Location = new System.Drawing.Point(102, 54);
            this.luCurso.Name = "luCurso";
            this.luCurso.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.luCurso.Properties.Appearance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.luCurso.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luCurso.Properties.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.luCurso.Properties.Appearance.Options.UseBackColor = true;
            this.luCurso.Properties.Appearance.Options.UseFont = true;
            this.luCurso.Properties.Appearance.Options.UseForeColor = true;
            this.luCurso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luCurso.Properties.DropDownRows = 5;
            this.luCurso.Properties.HideSelection = false;
            this.luCurso.Properties.NullText = "";
            this.luCurso.Properties.ShowHeader = false;
            this.luCurso.Size = new System.Drawing.Size(179, 22);
            this.luCurso.TabIndex = 234;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(31, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 233;
            this.label1.Text = "Curso";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // luDivision
            // 
            this.luDivision.Enabled = false;
            this.luDivision.Location = new System.Drawing.Point(401, 14);
            this.luDivision.Name = "luDivision";
            this.luDivision.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.luDivision.Properties.Appearance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.luDivision.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luDivision.Properties.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.luDivision.Properties.Appearance.Options.UseBackColor = true;
            this.luDivision.Properties.Appearance.Options.UseFont = true;
            this.luDivision.Properties.Appearance.Options.UseForeColor = true;
            this.luDivision.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luDivision.Properties.DropDownRows = 5;
            this.luDivision.Properties.HideSelection = false;
            this.luDivision.Properties.NullText = "";
            this.luDivision.Properties.ShowHeader = false;
            this.luDivision.Size = new System.Drawing.Size(179, 22);
            this.luDivision.TabIndex = 236;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(310, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 235;
            this.label2.Text = "División";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Location = new System.Drawing.Point(304, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 237;
            this.label3.Text = "Alumnos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtalumnos
            // 
            this.txtalumnos.Enabled = false;
            this.txtalumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtalumnos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtalumnos.Location = new System.Drawing.Point(401, 54);
            this.txtalumnos.Name = "txtalumnos";
            this.txtalumnos.Size = new System.Drawing.Size(89, 29);
            this.txtalumnos.TabIndex = 238;
            this.txtalumnos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // luLocalidad
            // 
            this.luLocalidad.Enabled = false;
            this.luLocalidad.Location = new System.Drawing.Point(710, 14);
            this.luLocalidad.Name = "luLocalidad";
            this.luLocalidad.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.luLocalidad.Properties.Appearance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.luLocalidad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luLocalidad.Properties.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.luLocalidad.Properties.Appearance.Options.UseBackColor = true;
            this.luLocalidad.Properties.Appearance.Options.UseFont = true;
            this.luLocalidad.Properties.Appearance.Options.UseForeColor = true;
            this.luLocalidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luLocalidad.Properties.DropDownRows = 5;
            this.luLocalidad.Properties.HideSelection = false;
            this.luLocalidad.Properties.NullText = "";
            this.luLocalidad.Properties.ShowHeader = false;
            this.luLocalidad.Size = new System.Drawing.Size(179, 22);
            this.luLocalidad.TabIndex = 240;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Location = new System.Drawing.Point(604, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 239;
            this.label4.Text = "Localidad";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // luTurnos
            // 
            this.luTurnos.Enabled = false;
            this.luTurnos.Location = new System.Drawing.Point(710, 54);
            this.luTurnos.Name = "luTurnos";
            this.luTurnos.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.luTurnos.Properties.Appearance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.luTurnos.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luTurnos.Properties.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.luTurnos.Properties.Appearance.Options.UseBackColor = true;
            this.luTurnos.Properties.Appearance.Options.UseFont = true;
            this.luTurnos.Properties.Appearance.Options.UseForeColor = true;
            this.luTurnos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luTurnos.Properties.DropDownRows = 5;
            this.luTurnos.Properties.HideSelection = false;
            this.luTurnos.Properties.NullText = "";
            this.luTurnos.Properties.ShowHeader = false;
            this.luTurnos.Size = new System.Drawing.Size(179, 22);
            this.luTurnos.TabIndex = 242;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Location = new System.Drawing.Point(636, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 241;
            this.label5.Text = "Turno";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(55, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 243;
            this.label6.Text = "Docentes";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(55, 361);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 244;
            this.label10.Text = "Libros";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnaltadoc
            // 
            this.btnaltadoc.Enabled = false;
            this.btnaltadoc.Image = global::Presentacion.Properties.Resources.agregar321;
            this.btnaltadoc.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnaltadoc.Location = new System.Drawing.Point(613, 164);
            this.btnaltadoc.Name = "btnaltadoc";
            this.btnaltadoc.Size = new System.Drawing.Size(43, 42);
            this.btnaltadoc.TabIndex = 245;
            this.btnaltadoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnaltadoc.UseVisualStyleBackColor = true;
            this.btnaltadoc.Click += new System.EventHandler(this.btnaltadoc_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Image = global::Presentacion.Properties.Resources.eliminar32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(856, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 42);
            this.button1.TabIndex = 246;
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(55, 613);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(385, 16);
            this.label9.TabIndex = 247;
            this.label9.Text = "Opcional: Se puede elegir un libro de varios que eligió el docente.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label11.Location = new System.Drawing.Point(55, 633);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(396, 16);
            this.label11.TabIndex = 248;
            this.label11.Text = "Cualquier editorial: Se puede elegir cualquier editorial de este libro.";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnagregar
            // 
            this.btnagregar.Image = global::Presentacion.Properties.Resources.guardar64;
            this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnagregar.Location = new System.Drawing.Point(655, 602);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(88, 77);
            this.btnagregar.TabIndex = 249;
            this.btnagregar.Text = "Guardar";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Visible = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click_1);
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancelar64;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(766, 602);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(88, 77);
            this.btncancelar.TabIndex = 250;
            this.btncancelar.Text = "No crear";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Visible = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // rTobs
            // 
            this.rTobs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rTobs.Location = new System.Drawing.Point(707, 164);
            this.rTobs.Name = "rTobs";
            this.rTobs.ReadOnly = true;
            this.rTobs.Size = new System.Drawing.Size(206, 153);
            this.rTobs.TabIndex = 251;
            this.rTobs.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(707, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 16);
            this.label12.TabIndex = 252;
            this.label12.Text = "Observaciones";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AltaAdopcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1008, 682);
            this.ControlBox = false;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.rTobs);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnaltadoc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.luTurnos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.luLocalidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtalumnos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.luDivision);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.luCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gConsultaD);
            this.Controls.Add(this.gConsulta);
            this.Controls.Add(this.btneliminaele);
            this.Controls.Add(this.btnagregap);
            this.Controls.Add(this.lbfecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LUEscuela);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSalir);
            this.Name = "AltaAdopcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adopciones de escuelas...";
            this.Load += new System.EventHandler(this.AltaAdopcion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LUEscuela.Properties)).EndInit();
            this.conMSdebito.ResumeLayout(false);
            this.conMScredito.ResumeLayout(false);
            this.conMScuotas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gConsultaD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luCurso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luDivision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luLocalidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luTurnos.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.LookUpEdit LUEscuela;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Button btnagregap;
        private System.Windows.Forms.Button btneliminaele;
        private System.Windows.Forms.ContextMenuStrip conMSdebito;
        private System.Windows.Forms.ToolStripMenuItem TSMImaestro;
        private System.Windows.Forms.ToolStripMenuItem TSMIvisaelectron;
        private System.Windows.Forms.ContextMenuStrip conMScredito;
        private System.Windows.Forms.ToolStripMenuItem tSMIeficaz;
        private System.Windows.Forms.ToolStripMenuItem tSMImaster;
        private System.Windows.Forms.ToolStripMenuItem tSMInaranja;
        private System.Windows.Forms.ToolStripMenuItem tSMIplanz;
        private System.Windows.Forms.ToolStripMenuItem tSMItdf;
        private System.Windows.Forms.ToolStripMenuItem tSMIvisa;
        private System.Windows.Forms.ContextMenuStrip conMScuotas;
        private System.Windows.Forms.ToolStripMenuItem tSMI2cuotas;
        private System.Windows.Forms.ToolStripMenuItem tSMI3cuotas;
        private System.Windows.Forms.ToolStripMenuItem ahora3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ahora6ToolStripMenuItem;
        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private DevExpress.XtraGrid.Columns.GridColumn LI_CODIGOVIEJO;
        private DevExpress.XtraGrid.Columns.GridColumn LI_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn EDI_EDITORIAL;
        private DevExpress.XtraGrid.Columns.GridColumn area_desc;
        private DevExpress.XtraGrid.GridControl gConsultaD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn doc_ayn;
        private DevExpress.XtraGrid.Columns.GridColumn doc_celular;
        private DevExpress.XtraEditors.LookUpEdit luCurso;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit luDivision;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtalumnos;
        private DevExpress.XtraEditors.LookUpEdit luLocalidad;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.LookUpEdit luTurnos;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Columns.GridColumn addc_ide;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnaltadoc;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.Columns.GridColumn adod_ide;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.RichTextBox rTobs;
        private System.Windows.Forms.Label label12;
    }
}