namespace Presentacion
{
    partial class Contador_nuevo
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
            this.VEN_PTOVTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_TIPOFACTU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_NROTICKET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_CUIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_DIRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_FECHA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_IMP21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_IVA21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_IMP1050 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_IMPIVA1050 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_EXENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_TOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_NOMBRE = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.LUpunto = new DevExpress.XtraEditors.LookUpEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.Obs = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            this.cmdmenugrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            this.gBtipopro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fechahasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechahasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechadesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechadesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUpunto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancelar64;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(498, 470);
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
            this.gConsulta.Location = new System.Drawing.Point(12, 103);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(937, 334);
            this.gConsulta.TabIndex = 195;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            this.gConsulta.DoubleClick += new System.EventHandler(this.gConsulta_DoubleClick);
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
            this.VEN_PTOVTA,
            this.VEN_TIPOFACTU,
            this.VEN_NROTICKET,
            this.VEN_CUIT,
            this.VEN_DIRE,
            this.VEN_FECHA,
            this.VEN_IMP21,
            this.VEN_IVA21,
            this.VEN_IMP1050,
            this.VEN_IMPIVA1050,
            this.VEN_EXENTO,
            this.VEN_TOTAL,
            this.VEN_NOMBRE,
            this.Obs});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total", this.VEN_TIPOFACTU, "")});
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            this.gridViewPintarFilas.RowStyle += gridViewPintarFilas_RowStyle;
            // 
            // VEN_PTOVTA
            // 
            this.VEN_PTOVTA.AppearanceCell.Options.UseTextOptions = true;
            this.VEN_PTOVTA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VEN_PTOVTA.Caption = "PuntodeVenta";
            this.VEN_PTOVTA.FieldName = "VEN_PTOVTA";
            this.VEN_PTOVTA.MaxWidth = 50;
            this.VEN_PTOVTA.MinWidth = 50;
            this.VEN_PTOVTA.Name = "VEN_PTOVTA";
            this.VEN_PTOVTA.Visible = true;
            this.VEN_PTOVTA.VisibleIndex = 0;
            this.VEN_PTOVTA.Width = 50;
            // 
            // VEN_TIPOFACTU
            // 
            this.VEN_TIPOFACTU.AppearanceCell.Options.UseTextOptions = true;
            this.VEN_TIPOFACTU.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VEN_TIPOFACTU.Caption = "Tipo";
            this.VEN_TIPOFACTU.FieldName = "VEN_TIPOFACTU";
            this.VEN_TIPOFACTU.MaxWidth = 40;
            this.VEN_TIPOFACTU.MinWidth = 40;
            this.VEN_TIPOFACTU.Name = "VEN_TIPOFACTU";
            this.VEN_TIPOFACTU.Visible = true;
            this.VEN_TIPOFACTU.VisibleIndex = 1;
            this.VEN_TIPOFACTU.Width = 40;
            // 
            // VEN_NROTICKET
            // 
            this.VEN_NROTICKET.AppearanceCell.Options.UseTextOptions = true;
            this.VEN_NROTICKET.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VEN_NROTICKET.Caption = "Número";
            this.VEN_NROTICKET.FieldName = "VEN_NROTICKET";
            this.VEN_NROTICKET.MaxWidth = 50;
            this.VEN_NROTICKET.MinWidth = 50;
            this.VEN_NROTICKET.Name = "VEN_NROTICKET";
            this.VEN_NROTICKET.Visible = true;
            this.VEN_NROTICKET.VisibleIndex = 2;
            this.VEN_NROTICKET.Width = 50;
            // 
            // VEN_CUIT
            // 
            this.VEN_CUIT.Caption = "Cuit";
            this.VEN_CUIT.FieldName = "VEN_CUIT";
            this.VEN_CUIT.MaxWidth = 80;
            this.VEN_CUIT.MinWidth = 80;
            this.VEN_CUIT.Name = "VEN_CUIT";
            this.VEN_CUIT.Visible = true;
            this.VEN_CUIT.VisibleIndex = 3;
            this.VEN_CUIT.Width = 80;
            // 
            // VEN_DIRE
            // 
            this.VEN_DIRE.Caption = "Domicilio";
            this.VEN_DIRE.FieldName = "VEN_DIRE";
            this.VEN_DIRE.MaxWidth = 120;
            this.VEN_DIRE.MinWidth = 120;
            this.VEN_DIRE.Name = "VEN_DIRE";
            this.VEN_DIRE.Visible = true;
            this.VEN_DIRE.VisibleIndex = 5;
            this.VEN_DIRE.Width = 120;
            // 
            // VEN_FECHA
            // 
            this.VEN_FECHA.Caption = "Fecha";
            this.VEN_FECHA.FieldName = "VEN_FECHA";
            this.VEN_FECHA.MaxWidth = 70;
            this.VEN_FECHA.MinWidth = 70;
            this.VEN_FECHA.Name = "VEN_FECHA";
            this.VEN_FECHA.Visible = true;
            this.VEN_FECHA.VisibleIndex = 6;
            this.VEN_FECHA.Width = 70;
            // 
            // VEN_IMP21
            // 
            this.VEN_IMP21.Caption = "Imp21";
            this.VEN_IMP21.FieldName = "VEN_IMP21";
            this.VEN_IMP21.MaxWidth = 65;
            this.VEN_IMP21.MinWidth = 65;
            this.VEN_IMP21.Name = "VEN_IMP21";
            this.VEN_IMP21.Visible = true;
            this.VEN_IMP21.VisibleIndex = 7;
            this.VEN_IMP21.Width = 65;
            // 
            // VEN_IVA21
            // 
            this.VEN_IVA21.Caption = "Iva21";
            this.VEN_IVA21.FieldName = "VEN_IVA21";
            this.VEN_IVA21.MaxWidth = 65;
            this.VEN_IVA21.MinWidth = 65;
            this.VEN_IVA21.Name = "VEN_IVA21";
            this.VEN_IVA21.Visible = true;
            this.VEN_IVA21.VisibleIndex = 8;
            this.VEN_IVA21.Width = 65;
            // 
            // VEN_IMP1050
            // 
            this.VEN_IMP1050.Caption = "Imp1050";
            this.VEN_IMP1050.FieldName = "VEN_IMP1050";
            this.VEN_IMP1050.MaxWidth = 65;
            this.VEN_IMP1050.MinWidth = 65;
            this.VEN_IMP1050.Name = "VEN_IMP1050";
            this.VEN_IMP1050.Visible = true;
            this.VEN_IMP1050.VisibleIndex = 9;
            this.VEN_IMP1050.Width = 65;
            // 
            // VEN_IMPIVA1050
            // 
            this.VEN_IMPIVA1050.Caption = "Iva1050";
            this.VEN_IMPIVA1050.FieldName = "VEN_IMPIVA1050";
            this.VEN_IMPIVA1050.MaxWidth = 65;
            this.VEN_IMPIVA1050.MinWidth = 65;
            this.VEN_IMPIVA1050.Name = "VEN_IMPIVA1050";
            this.VEN_IMPIVA1050.Visible = true;
            this.VEN_IMPIVA1050.VisibleIndex = 10;
            this.VEN_IMPIVA1050.Width = 65;
            // 
            // VEN_EXENTO
            // 
            this.VEN_EXENTO.Caption = "Exento";
            this.VEN_EXENTO.FieldName = "VEN_EXENTO";
            this.VEN_EXENTO.MaxWidth = 65;
            this.VEN_EXENTO.MinWidth = 65;
            this.VEN_EXENTO.Name = "VEN_EXENTO";
            this.VEN_EXENTO.Visible = true;
            this.VEN_EXENTO.VisibleIndex = 11;
            this.VEN_EXENTO.Width = 65;
            // 
            // VEN_TOTAL
            // 
            this.VEN_TOTAL.Caption = "Total";
            this.VEN_TOTAL.FieldName = "VEN_TOTAL";
            this.VEN_TOTAL.MaxWidth = 100;
            this.VEN_TOTAL.MinWidth = 100;
            this.VEN_TOTAL.Name = "VEN_TOTAL";
            this.VEN_TOTAL.Visible = true;
            this.VEN_TOTAL.VisibleIndex = 12;
            this.VEN_TOTAL.Width = 100;
            // 
            // VEN_NOMBRE
            // 
            this.VEN_NOMBRE.Caption = "Razón";
            this.VEN_NOMBRE.FieldName = "VEN_NOMBRE";
            this.VEN_NOMBRE.MaxWidth = 120;
            this.VEN_NOMBRE.MinWidth = 120;
            this.VEN_NOMBRE.Name = "VEN_NOMBRE";
            this.VEN_NOMBRE.Visible = true;
            this.VEN_NOMBRE.VisibleIndex = 4;
            this.VEN_NOMBRE.Width = 120;
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::Presentacion.Properties.Resources.Impresora64;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneliminar.Location = new System.Drawing.Point(350, 470);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(102, 87);
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
            this.panel2.Location = new System.Drawing.Point(38, 495);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(38, 35);
            this.panel2.TabIndex = 239;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Presentacion.Properties.Resources.pdf32;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(79, 495);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(38, 35);
            this.panel1.TabIndex = 238;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(12, 479);
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
            this.gBtipopro.Location = new System.Drawing.Point(232, 44);
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
            this.label3.ForeColor = System.Drawing.Color.LightSteelBlue;
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
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
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
            this.button1.Image = global::Presentacion.Properties.Resources.ventas48;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(700, 12);
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
            this.button2.Location = new System.Drawing.Point(831, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 70);
            this.button2.TabIndex = 245;
            this.button2.Text = "Salir";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // LUpunto
            // 
            this.LUpunto.Location = new System.Drawing.Point(428, 12);
            this.LUpunto.Name = "LUpunto";
            this.LUpunto.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.LUpunto.Properties.Appearance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LUpunto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUpunto.Properties.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LUpunto.Properties.Appearance.Options.UseBackColor = true;
            this.LUpunto.Properties.Appearance.Options.UseFont = true;
            this.LUpunto.Properties.Appearance.Options.UseForeColor = true;
            this.LUpunto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUpunto.Properties.DropDownRows = 5;
            this.LUpunto.Properties.HideSelection = false;
            this.LUpunto.Properties.NullText = "";
            this.LUpunto.Properties.ShowHeader = false;
            this.LUpunto.Size = new System.Drawing.Size(159, 22);
            this.LUpunto.TabIndex = 240;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Location = new System.Drawing.Point(310, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 241;
            this.label4.Text = "Punto de venta:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Obs
            // 
            this.Obs.Caption = "Obs";
            this.Obs.FieldName = "Obs";
            this.Obs.MaxWidth = 50;
            this.Obs.MinWidth = 50;
            this.Obs.Name = "Obs";
            this.Obs.Visible = true;
            this.Obs.VisibleIndex = 13;
            this.Obs.Width = 50;
            // 
            // Contador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(961, 569);
            this.ControlBox = false;
            this.Controls.Add(this.gBtipopro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LUpunto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.gConsulta);
            this.Name = "Contador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas para exportar (Contador)";
            this.Load += new System.EventHandler(this.ConsultasConsignas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            this.cmdmenugrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            this.gBtipopro.ResumeLayout(false);
            this.gBtipopro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fechahasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechahasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechadesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechadesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUpunto.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncancelar;
        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_PTOVTA;
        private System.Windows.Forms.Button btneliminar;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_TIPOFACTU;
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
        private DevExpress.XtraEditors.LookUpEdit LUpunto;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_NROTICKET;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_CUIT;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_DIRE;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_FECHA;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_IMP21;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_IVA21;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_IMP1050;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_IMPIVA1050;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_EXENTO;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_TOTAL;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_NOMBRE;
        private DevExpress.XtraGrid.Columns.GridColumn Obs;
    }
}