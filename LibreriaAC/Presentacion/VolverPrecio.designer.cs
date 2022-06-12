namespace Presentacion
{
    partial class VolverPrecio
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
            this.label4 = new System.Windows.Forms.Label();
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
            this.gConsulta = new DevExpress.XtraGrid.GridControl();
            this.cBEeditorial = new DevExpress.XtraEditors.LookUpEdit();
            this.button3 = new System.Windows.Forms.Button();
            this.cmdmenugrid.SuspendLayout();
            this.gBtipopro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fechahasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechahasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechadesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechadesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBEeditorial.Properties)).BeginInit();
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
            this.gBtipopro.Location = new System.Drawing.Point(36, 44);
            this.gBtipopro.Name = "gBtipopro";
            this.gBtipopro.Size = new System.Drawing.Size(440, 53);
            this.gBtipopro.TabIndex = 247;
            this.gBtipopro.TabStop = false;
            this.gBtipopro.Text = "Cambio de precios realizado entre las fechas...";
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
            this.button1.Image = global::Presentacion.Properties.Resources.entrar48;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(504, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 70);
            this.button1.TabIndex = 246;
            this.button1.Text = "Ver productos";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Presentacion.Properties.Resources.salir48;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(759, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 70);
            this.button2.TabIndex = 245;
            this.button2.Text = "Salir";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Location = new System.Drawing.Point(104, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 241;
            this.label4.Text = "Editorial:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.VEN_NOMBRE});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total", this.VEN_TIPOFACTU, "")});
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
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
            this.VEN_CUIT.VisibleIndex = 2;
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
            this.VEN_DIRE.VisibleIndex = 4;
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
            this.VEN_FECHA.VisibleIndex = 5;
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
            this.VEN_IMP21.VisibleIndex = 6;
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
            this.VEN_IVA21.VisibleIndex = 7;
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
            this.VEN_IMP1050.VisibleIndex = 8;
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
            this.VEN_IMPIVA1050.VisibleIndex = 9;
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
            this.VEN_EXENTO.VisibleIndex = 10;
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
            this.VEN_TOTAL.VisibleIndex = 11;
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
            this.VEN_NOMBRE.VisibleIndex = 3;
            this.VEN_NOMBRE.Width = 120;
            // 
            // gConsulta
            // 
            this.gConsulta.ContextMenuStrip = this.cmdmenugrid;
            this.gConsulta.Location = new System.Drawing.Point(12, 103);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(937, 440);
            this.gConsulta.TabIndex = 195;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            this.gConsulta.DoubleClick += new System.EventHandler(this.gConsulta_DoubleClick);
            // 
            // cBEeditorial
            // 
            this.cBEeditorial.Location = new System.Drawing.Point(179, 12);
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
            this.cBEeditorial.TabIndex = 248;
            // 
            // button3
            // 
            this.button3.Image = global::Presentacion.Properties.Resources.producto48;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(631, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 70);
            this.button3.TabIndex = 249;
            this.button3.Text = "Volver precio";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // VolverPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(961, 569);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cBEeditorial);
            this.Controls.Add(this.gBtipopro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gConsulta);
            this.Name = "VolverPrecio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volver precio anterior";
            this.Load += new System.EventHandler(this.ConsultasConsignas_Load);
            this.cmdmenugrid.ResumeLayout(false);
            this.gBtipopro.ResumeLayout(false);
            this.gBtipopro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fechahasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechahasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechadesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechadesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBEeditorial.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_PTOVTA;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_TIPOFACTU;
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
        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraEditors.LookUpEdit cBEeditorial;
        private System.Windows.Forms.Button button3;
    }
}