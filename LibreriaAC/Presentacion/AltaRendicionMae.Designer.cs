namespace Presentacion
{
    partial class AltaRendicionMae
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
            this.lUEditorial = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.gBtipopro = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hasta = new DevExpress.XtraEditors.DateEdit();
            this.desde = new DevExpress.XtraEditors.DateEdit();
            this.gConsulta = new DevExpress.XtraGrid.GridControl();
            this.cmdmenugrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportarAExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarAPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewPintarFilas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PREN_FACTU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PREN_LI_CODIGOVIEJO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_AUTOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PREN_CONSIGNA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PREN_CANTIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PREN_IMPORTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PREN_FECHAVTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PREN_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnbuscarventas = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.sfdRuta1 = new System.Windows.Forms.SaveFileDialog();
            this.sfdRuta = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.lUEditorial.Properties)).BeginInit();
            this.gBtipopro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            this.cmdmenugrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            this.SuspendLayout();
            // 
            // lUEditorial
            // 
            this.lUEditorial.Location = new System.Drawing.Point(12, 45);
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
            this.lUEditorial.Size = new System.Drawing.Size(320, 22);
            this.lUEditorial.TabIndex = 193;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(115, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 194;
            this.label3.Text = "Editorial:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancelar64;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(401, 463);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(73, 79);
            this.btncancelar.TabIndex = 203;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Image = global::Presentacion.Properties.Resources.generar64;
            this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnagregar.Location = new System.Drawing.Point(308, 463);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(73, 79);
            this.btnagregar.TabIndex = 202;
            this.btnagregar.Text = "Generar";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // gBtipopro
            // 
            this.gBtipopro.Controls.Add(this.label2);
            this.gBtipopro.Controls.Add(this.label1);
            this.gBtipopro.Controls.Add(this.hasta);
            this.gBtipopro.Controls.Add(this.desde);
            this.gBtipopro.Location = new System.Drawing.Point(338, 7);
            this.gBtipopro.Name = "gBtipopro";
            this.gBtipopro.Size = new System.Drawing.Size(333, 76);
            this.gBtipopro.TabIndex = 212;
            this.gBtipopro.TabStop = false;
            this.gBtipopro.Text = "Ventas entre fechas...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(225, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 213;
            this.label2.Text = "Hasta";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(60, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 212;
            this.label1.Text = "Desde";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hasta
            // 
            this.hasta.EditValue = null;
            this.hasta.Location = new System.Drawing.Point(184, 39);
            this.hasta.Name = "hasta";
            this.hasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.hasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.hasta.Size = new System.Drawing.Size(134, 20);
            this.hasta.TabIndex = 211;
            // 
            // desde
            // 
            this.desde.EditValue = null;
            this.desde.Location = new System.Drawing.Point(20, 39);
            this.desde.Name = "desde";
            this.desde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.desde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.desde.Size = new System.Drawing.Size(134, 20);
            this.desde.TabIndex = 210;
            // 
            // gConsulta
            // 
            this.gConsulta.ContextMenuStrip = this.cmdmenugrid;
            this.gConsulta.Location = new System.Drawing.Point(11, 98);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(826, 359);
            this.gConsulta.TabIndex = 213;
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
            this.exportarAExcelToolStripMenuItem.Click += new System.EventHandler(this.exportarAExcelToolStripMenuItem_Click_1);
            // 
            // exportarAPDFToolStripMenuItem
            // 
            this.exportarAPDFToolStripMenuItem.Name = "exportarAPDFToolStripMenuItem";
            this.exportarAPDFToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exportarAPDFToolStripMenuItem.Text = "Exportar a PDF";
            this.exportarAPDFToolStripMenuItem.Click += new System.EventHandler(this.exportarAPDFToolStripMenuItem_Click_1);
            // 
            // gridViewPintarFilas
            // 
            this.gridViewPintarFilas.Appearance.FooterPanel.BackColor = System.Drawing.Color.SeaShell;
            this.gridViewPintarFilas.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewPintarFilas.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.gridViewPintarFilas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PREN_FACTU,
            this.PREN_LI_CODIGOVIEJO,
            this.LI_DESC,
            this.LI_AUTOR,
            this.PREN_CONSIGNA,
            this.PREN_CANTIDAD,
            this.PREN_IMPORTE,
            this.PREN_FECHAVTA,
            this.PREN_IDE});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Cantidad", null, "(Cantidad: Recuento={0})")});
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
            // LI_DESC
            // 
            this.LI_DESC.Caption = "Nombre";
            this.LI_DESC.FieldName = "LI_DESC";
            this.LI_DESC.MaxWidth = 200;
            this.LI_DESC.MinWidth = 200;
            this.LI_DESC.Name = "LI_DESC";
            this.LI_DESC.Visible = true;
            this.LI_DESC.VisibleIndex = 2;
            this.LI_DESC.Width = 200;
            // 
            // LI_AUTOR
            // 
            this.LI_AUTOR.Caption = "Autor";
            this.LI_AUTOR.FieldName = "LI_AUTOR";
            this.LI_AUTOR.MaxWidth = 100;
            this.LI_AUTOR.MinWidth = 100;
            this.LI_AUTOR.Name = "LI_AUTOR";
            this.LI_AUTOR.Visible = true;
            this.LI_AUTOR.VisibleIndex = 3;
            this.LI_AUTOR.Width = 100;
            // 
            // PREN_CONSIGNA
            // 
            this.PREN_CONSIGNA.Caption = "Consigna";
            this.PREN_CONSIGNA.FieldName = "PREN_CONSIGNA";
            this.PREN_CONSIGNA.MaxWidth = 70;
            this.PREN_CONSIGNA.MinWidth = 70;
            this.PREN_CONSIGNA.Name = "PREN_CONSIGNA";
            this.PREN_CONSIGNA.Visible = true;
            this.PREN_CONSIGNA.VisibleIndex = 4;
            this.PREN_CONSIGNA.Width = 70;
            // 
            // PREN_CANTIDAD
            // 
            this.PREN_CANTIDAD.Caption = "Cantidad";
            this.PREN_CANTIDAD.FieldName = "PREN_CANTIDAD";
            this.PREN_CANTIDAD.MaxWidth = 85;
            this.PREN_CANTIDAD.MinWidth = 85;
            this.PREN_CANTIDAD.Name = "PREN_CANTIDAD";
            this.PREN_CANTIDAD.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PREN_CANTIDAD", "{0:#.##}")});
            this.PREN_CANTIDAD.Visible = true;
            this.PREN_CANTIDAD.VisibleIndex = 5;
            this.PREN_CANTIDAD.Width = 85;
            // 
            // PREN_IMPORTE
            // 
            this.PREN_IMPORTE.AppearanceCell.Options.UseTextOptions = true;
            this.PREN_IMPORTE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PREN_IMPORTE.AppearanceHeader.Options.UseTextOptions = true;
            this.PREN_IMPORTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PREN_IMPORTE.Caption = "Importe";
            this.PREN_IMPORTE.FieldName = "PREN_IMPORTE";
            this.PREN_IMPORTE.Name = "PREN_IMPORTE";
            this.PREN_IMPORTE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PREN_IMPORTE", "{0:#.##}")});
            this.PREN_IMPORTE.Visible = true;
            this.PREN_IMPORTE.VisibleIndex = 7;
            this.PREN_IMPORTE.Width = 88;
            // 
            // PREN_FECHAVTA
            // 
            this.PREN_FECHAVTA.Caption = "Fecha_venta";
            this.PREN_FECHAVTA.FieldName = "PREN_FECHAVTA";
            this.PREN_FECHAVTA.MaxWidth = 75;
            this.PREN_FECHAVTA.MinWidth = 75;
            this.PREN_FECHAVTA.Name = "PREN_FECHAVTA";
            this.PREN_FECHAVTA.Visible = true;
            this.PREN_FECHAVTA.VisibleIndex = 6;
            // 
            // PREN_IDE
            // 
            this.PREN_IDE.Caption = "PREN_IDE";
            this.PREN_IDE.FieldName = "PREN_IDE";
            this.PREN_IDE.Name = "PREN_IDE";
            // 
            // btnbuscarventas
            // 
            this.btnbuscarventas.Image = global::Presentacion.Properties.Resources.buscarl64;
            this.btnbuscarventas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnbuscarventas.Location = new System.Drawing.Point(683, 9);
            this.btnbuscarventas.Name = "btnbuscarventas";
            this.btnbuscarventas.Size = new System.Drawing.Size(86, 79);
            this.btnbuscarventas.TabIndex = 214;
            this.btnbuscarventas.Text = "Buscar ventas";
            this.btnbuscarventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnbuscarventas.UseVisualStyleBackColor = true;
            this.btnbuscarventas.Click += new System.EventHandler(this.btnbuscarventas_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Presentacion.Properties.Resources.excel32;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(205, 485);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(38, 35);
            this.panel2.TabIndex = 236;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Presentacion.Properties.Resources.pdf32;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(246, 485);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(38, 35);
            this.panel1.TabIndex = 235;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(62, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 234;
            this.label5.Text = "[click derecho para exportar]";
            // 
            // sfdRuta1
            // 
            this.sfdRuta1.Filter = "Archivos PDF | *.pdf";
            // 
            // sfdRuta
            // 
            this.sfdRuta.Filter = "Archivos Excel | *.xlsx";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // AltaRendicionMae
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 547);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnbuscarventas);
            this.Controls.Add(this.gConsulta);
            this.Controls.Add(this.gBtipopro);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.lUEditorial);
            this.Controls.Add(this.label3);
            this.Name = "AltaRendicionMae";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta rendición...";
            this.Load += new System.EventHandler(this.AltaconsignaMae_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lUEditorial.Properties)).EndInit();
            this.gBtipopro.ResumeLayout(false);
            this.gBtipopro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            this.cmdmenugrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lUEditorial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.GroupBox gBtipopro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit hasta;
        private DevExpress.XtraEditors.DateEdit desde;
        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private DevExpress.XtraGrid.Columns.GridColumn PREN_FACTU;
        private DevExpress.XtraGrid.Columns.GridColumn PREN_LI_CODIGOVIEJO;
        private DevExpress.XtraGrid.Columns.GridColumn LI_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn LI_AUTOR;
        private DevExpress.XtraGrid.Columns.GridColumn PREN_CONSIGNA;
        private DevExpress.XtraGrid.Columns.GridColumn PREN_CANTIDAD;
        private DevExpress.XtraGrid.Columns.GridColumn PREN_IMPORTE;
        private System.Windows.Forms.Button btnbuscarventas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Columns.GridColumn PREN_FECHAVTA;
        private System.Windows.Forms.ContextMenuStrip cmdmenugrid;
        private System.Windows.Forms.ToolStripMenuItem exportarAExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarAPDFToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfdRuta1;
        private System.Windows.Forms.SaveFileDialog sfdRuta;
        private System.Windows.Forms.PrintDialog printDialog1;
        private DevExpress.XtraGrid.Columns.GridColumn PREN_IDE;
    }
}