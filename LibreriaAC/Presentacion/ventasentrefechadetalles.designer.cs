namespace Presentacion
{
    partial class ventasentrefechadetalles
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
            this.gConsultaPed = new DevExpress.XtraGrid.GridControl();
            this.gridViewPintarFilas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LI_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TIP_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEND_CANTIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EDI_EDITORIAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEND_IMPORTEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEND_IMPORTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rBlolasdb = new System.Windows.Forms.RadioButton();
            this.rBlibros = new System.Windows.Forms.RadioButton();
            this.lUEditorial = new DevExpress.XtraEditors.LookUpEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdmenugrid.SuspendLayout();
            this.gBtipopro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fechahasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechahasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechadesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechadesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gConsultaPed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lUEditorial.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancel48;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(468, 493);
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
            this.btneliminar.Location = new System.Drawing.Point(370, 493);
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
            this.panel2.Location = new System.Drawing.Point(155, 480);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(38, 35);
            this.panel2.TabIndex = 239;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Presentacion.Properties.Resources.pdf32;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(196, 480);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(38, 35);
            this.panel1.TabIndex = 238;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(12, 482);
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
            this.gBtipopro.Location = new System.Drawing.Point(13, 13);
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
            this.button1.Location = new System.Drawing.Point(709, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 70);
            this.button1.TabIndex = 246;
            this.button1.Text = "Ver ventas";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Presentacion.Properties.Resources.salir48;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(818, 12);
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
            this.chbTitulo.Location = new System.Drawing.Point(405, 0);
            this.chbTitulo.Name = "chbTitulo";
            this.chbTitulo.Size = new System.Drawing.Size(56, 17);
            this.chbTitulo.TabIndex = 244;
            this.chbTitulo.Text = "Todos";
            this.chbTitulo.UseVisualStyleBackColor = true;
            this.chbTitulo.Visible = false;
            this.chbTitulo.CheckedChanged += new System.EventHandler(this.chbTitulo_CheckedChanged);
            // 
            // gConsultaPed
            // 
            this.gConsultaPed.ContextMenuStrip = this.cmdmenugrid;
            this.gConsultaPed.Location = new System.Drawing.Point(12, 107);
            this.gConsultaPed.MainView = this.gridViewPintarFilas;
            this.gConsultaPed.Name = "gConsultaPed";
            this.gConsultaPed.Size = new System.Drawing.Size(897, 367);
            this.gConsultaPed.TabIndex = 248;
            this.gConsultaPed.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            this.gConsultaPed.Click += new System.EventHandler(this.gConsulta_Click);
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
            this.LI_IDE,
            this.codigo,
            this.LI_DESC,
            this.TIP_DESC,
            this.VEND_CANTIDAD,
            this.valor,
            this.EDI_EDITORIAL,
            this.VEND_IMPORTEU,
            this.VEND_IMPORTE});
            this.gridViewPintarFilas.GridControl = this.gConsultaPed;
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            this.gridViewPintarFilas.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewPintarFilas_FocusedRowChanged);
            // 
            // LI_IDE
            // 
            this.LI_IDE.Caption = "LI_IDE";
            this.LI_IDE.FieldName = "LI_IDE";
            this.LI_IDE.MaxWidth = 120;
            this.LI_IDE.MinWidth = 120;
            this.LI_IDE.Name = "LI_IDE";
            this.LI_IDE.Width = 120;
            // 
            // codigo
            // 
            this.codigo.Caption = "Código";
            this.codigo.FieldName = "codigo";
            this.codigo.MaxWidth = 60;
            this.codigo.MinWidth = 60;
            this.codigo.Name = "codigo";
            this.codigo.Visible = true;
            this.codigo.VisibleIndex = 0;
            this.codigo.Width = 60;
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
            // TIP_DESC
            // 
            this.TIP_DESC.Caption = "Pago";
            this.TIP_DESC.FieldName = "TIP_DESC";
            this.TIP_DESC.Name = "TIP_DESC";
            this.TIP_DESC.Visible = true;
            this.TIP_DESC.VisibleIndex = 2;
            // 
            // VEND_CANTIDAD
            // 
            this.VEND_CANTIDAD.Caption = "Cantidad";
            this.VEND_CANTIDAD.FieldName = "VEND_CANTIDAD";
            this.VEND_CANTIDAD.MaxWidth = 80;
            this.VEND_CANTIDAD.Name = "VEND_CANTIDAD";
            this.VEND_CANTIDAD.Visible = true;
            this.VEND_CANTIDAD.VisibleIndex = 4;
            this.VEND_CANTIDAD.Width = 80;
            // 
            // valor
            // 
            this.valor.Caption = "valor";
            this.valor.FieldName = "valor";
            this.valor.Name = "valor";
            // 
            // EDI_EDITORIAL
            // 
            this.EDI_EDITORIAL.Caption = "Marca";
            this.EDI_EDITORIAL.FieldName = "EDI_EDITORIAL";
            this.EDI_EDITORIAL.Name = "EDI_EDITORIAL";
            this.EDI_EDITORIAL.Visible = true;
            this.EDI_EDITORIAL.VisibleIndex = 3;
            // 
            // VEND_IMPORTEU
            // 
            this.VEND_IMPORTEU.Caption = "PrecioU";
            this.VEND_IMPORTEU.FieldName = "VEND_IMPORTEU";
            this.VEND_IMPORTEU.Name = "VEND_IMPORTEU";
            this.VEND_IMPORTEU.Visible = true;
            this.VEND_IMPORTEU.VisibleIndex = 5;
            // 
            // VEND_IMPORTE
            // 
            this.VEND_IMPORTE.Caption = "SUBTOTAL";
            this.VEND_IMPORTE.FieldName = "VEND_IMPORTE";
            this.VEND_IMPORTE.Name = "VEND_IMPORTE";
            this.VEND_IMPORTE.Visible = true;
            this.VEND_IMPORTE.VisibleIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.AliceBlue;
            this.label6.Location = new System.Drawing.Point(9, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 254;
            this.label6.Text = "Ventas";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rBlolasdb);
            this.groupBox2.Controls.Add(this.rBlibros);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(120, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 33);
            this.groupBox2.TabIndex = 266;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // rBlolasdb
            // 
            this.rBlolasdb.AutoSize = true;
            this.rBlolasdb.Checked = true;
            this.rBlolasdb.ForeColor = System.Drawing.Color.Maroon;
            this.rBlolasdb.Location = new System.Drawing.Point(87, 8);
            this.rBlolasdb.Name = "rBlolasdb";
            this.rBlolasdb.Size = new System.Drawing.Size(87, 18);
            this.rBlolasdb.TabIndex = 200;
            this.rBlolasdb.TabStop = true;
            this.rBlolasdb.Text = "Art. librería";
            this.rBlolasdb.UseVisualStyleBackColor = true;
            // 
            // rBlibros
            // 
            this.rBlibros.AutoSize = true;
            this.rBlibros.ForeColor = System.Drawing.Color.Maroon;
            this.rBlibros.Location = new System.Drawing.Point(19, 8);
            this.rBlibros.Name = "rBlibros";
            this.rBlibros.Size = new System.Drawing.Size(61, 18);
            this.rBlibros.TabIndex = 199;
            this.rBlibros.Text = "Libros";
            this.rBlibros.UseVisualStyleBackColor = true;
            this.rBlibros.CheckedChanged += new System.EventHandler(this.rBlibros_CheckedChanged);
            // 
            // lUEditorial
            // 
            this.lUEditorial.Location = new System.Drawing.Point(461, 41);
            this.lUEditorial.Name = "lUEditorial";
            this.lUEditorial.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.lUEditorial.Properties.Appearance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lUEditorial.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUEditorial.Properties.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lUEditorial.Properties.Appearance.Options.UseBackColor = true;
            this.lUEditorial.Properties.Appearance.Options.UseFont = true;
            this.lUEditorial.Properties.Appearance.Options.UseForeColor = true;
            this.lUEditorial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lUEditorial.Properties.DropDownRows = 5;
            this.lUEditorial.Properties.HideSelection = false;
            this.lUEditorial.Properties.NullText = "";
            this.lUEditorial.Properties.ShowHeader = false;
            this.lUEditorial.Size = new System.Drawing.Size(237, 22);
            this.lUEditorial.TabIndex = 267;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.AliceBlue;
            this.label7.Location = new System.Drawing.Point(459, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 268;
            this.label7.Text = "Marcas:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ventasentrefechadetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(923, 581);
            this.ControlBox = false;
            this.Controls.Add(this.lUEditorial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gConsultaPed);
            this.Controls.Add(this.gBtipopro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chbTitulo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btncancelar);
            this.Name = "ventasentrefechadetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de ventas...";
            this.Load += new System.EventHandler(this.ConsultasConsignas_Load);
            this.cmdmenugrid.ResumeLayout(false);
            this.gBtipopro.ResumeLayout(false);
            this.gBtipopro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fechahasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechahasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechadesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechadesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gConsultaPed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lUEditorial.Properties)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gConsultaPed;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private DevExpress.XtraGrid.Columns.GridColumn codigo;
        private DevExpress.XtraGrid.Columns.GridColumn LI_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn TIP_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn LI_IDE;
        private DevExpress.XtraGrid.Columns.GridColumn VEND_CANTIDAD;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.Columns.GridColumn valor;
        private DevExpress.XtraGrid.Columns.GridColumn EDI_EDITORIAL;
        private DevExpress.XtraGrid.Columns.GridColumn VEND_IMPORTEU;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rBlolasdb;
        private System.Windows.Forms.RadioButton rBlibros;
        private DevExpress.XtraEditors.LookUpEdit lUEditorial;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraGrid.Columns.GridColumn VEND_IMPORTE;
    }
}