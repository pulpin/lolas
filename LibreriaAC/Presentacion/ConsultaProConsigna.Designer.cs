namespace Presentacion
{
    partial class lbstock
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
            this.CONS_NROCONSIG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CONS_REMITO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CONS_FECENVIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CONS_FECRECEP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CONS_CANTIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CONS_IMPORTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CONS_ORIGINAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CONS_RENDIDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btneliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbrendicion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.sfdRuta = new System.Windows.Forms.SaveFileDialog();
            this.sfdRuta1 = new System.Windows.Forms.SaveFileDialog();
            this.gConsulta1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.VEN_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_FECHA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEND_CANTIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEND_IMPORTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbpropio = new System.Windows.Forms.Label();
            this.lbstocks = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            this.cmdmenugrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancelar64;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(469, 383);
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
            this.gConsulta.Size = new System.Drawing.Size(541, 342);
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
            // gridViewPintarFilas
            // 
            this.gridViewPintarFilas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CONS_NROCONSIG,
            this.CONS_REMITO,
            this.CONS_FECENVIO,
            this.CONS_FECRECEP,
            this.CONS_CANTIDAD,
            this.CONS_IMPORTE,
            this.CONS_ORIGINAL,
            this.CONS_RENDIDO});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Cantidad", null, "(Cantidad: Recuento={0})")});
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            // 
            // CONS_NROCONSIG
            // 
            this.CONS_NROCONSIG.Caption = "Consigna";
            this.CONS_NROCONSIG.FieldName = "CONS_NROCONSIG";
            this.CONS_NROCONSIG.MaxWidth = 70;
            this.CONS_NROCONSIG.MinWidth = 70;
            this.CONS_NROCONSIG.Name = "CONS_NROCONSIG";
            this.CONS_NROCONSIG.Visible = true;
            this.CONS_NROCONSIG.VisibleIndex = 0;
            this.CONS_NROCONSIG.Width = 70;
            // 
            // CONS_REMITO
            // 
            this.CONS_REMITO.Caption = "Remito";
            this.CONS_REMITO.FieldName = "CONS_REMITO";
            this.CONS_REMITO.MaxWidth = 70;
            this.CONS_REMITO.MinWidth = 70;
            this.CONS_REMITO.Name = "CONS_REMITO";
            this.CONS_REMITO.Visible = true;
            this.CONS_REMITO.VisibleIndex = 1;
            this.CONS_REMITO.Width = 70;
            // 
            // CONS_FECENVIO
            // 
            this.CONS_FECENVIO.Caption = "Fecha_envio";
            this.CONS_FECENVIO.FieldName = "CONS_FECENVIO";
            this.CONS_FECENVIO.Name = "CONS_FECENVIO";
            this.CONS_FECENVIO.Visible = true;
            this.CONS_FECENVIO.VisibleIndex = 2;
            // 
            // CONS_FECRECEP
            // 
            this.CONS_FECRECEP.Caption = "Fecha_recepción";
            this.CONS_FECRECEP.FieldName = "CONS_FECRECEP";
            this.CONS_FECRECEP.Name = "CONS_FECRECEP";
            this.CONS_FECRECEP.Visible = true;
            this.CONS_FECRECEP.VisibleIndex = 3;
            // 
            // CONS_CANTIDAD
            // 
            this.CONS_CANTIDAD.Caption = "Cantidad";
            this.CONS_CANTIDAD.FieldName = "CONS_CANTIDAD";
            this.CONS_CANTIDAD.Name = "CONS_CANTIDAD";
            this.CONS_CANTIDAD.Visible = true;
            this.CONS_CANTIDAD.VisibleIndex = 4;
            // 
            // CONS_IMPORTE
            // 
            this.CONS_IMPORTE.Caption = "Importe";
            this.CONS_IMPORTE.FieldName = "CONS_IMPORTE";
            this.CONS_IMPORTE.Name = "CONS_IMPORTE";
            this.CONS_IMPORTE.Visible = true;
            this.CONS_IMPORTE.VisibleIndex = 5;
            // 
            // CONS_ORIGINAL
            // 
            this.CONS_ORIGINAL.Caption = "Original";
            this.CONS_ORIGINAL.FieldName = "CONS_ORIGINAL";
            this.CONS_ORIGINAL.Name = "CONS_ORIGINAL";
            this.CONS_ORIGINAL.Visible = true;
            this.CONS_ORIGINAL.VisibleIndex = 6;
            // 
            // CONS_RENDIDO
            // 
            this.CONS_RENDIDO.Caption = "Rendido";
            this.CONS_RENDIDO.FieldName = "CONS_RENDIDO";
            this.CONS_RENDIDO.Name = "CONS_RENDIDO";
            this.CONS_RENDIDO.Visible = true;
            this.CONS_RENDIDO.VisibleIndex = 7;
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::Presentacion.Properties.Resources.Impresora64;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneliminar.Location = new System.Drawing.Point(324, 384);
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
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 201;
            this.label1.Text = "Consignas";
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
            // gConsulta1
            // 
            this.gConsulta1.ContextMenuStrip = this.cmdmenugrid;
            this.gConsulta1.Location = new System.Drawing.Point(571, 36);
            this.gConsulta1.MainView = this.gridView1;
            this.gConsulta1.Name = "gConsulta1";
            this.gConsulta1.Size = new System.Drawing.Size(313, 342);
            this.gConsulta1.TabIndex = 240;
            this.gConsulta1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.VEN_IDE,
            this.VEN_FECHA,
            this.VEND_CANTIDAD,
            this.VEND_IMPORTE});
            this.gridView1.GridControl = this.gConsulta1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Cantidad", null, "(Cantidad: Recuento={0})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // VEN_IDE
            // 
            this.VEN_IDE.Caption = "Venta";
            this.VEN_IDE.FieldName = "VEN_IDE";
            this.VEN_IDE.MaxWidth = 60;
            this.VEN_IDE.MinWidth = 60;
            this.VEN_IDE.Name = "VEN_IDE";
            this.VEN_IDE.Visible = true;
            this.VEN_IDE.VisibleIndex = 0;
            this.VEN_IDE.Width = 60;
            // 
            // VEN_FECHA
            // 
            this.VEN_FECHA.Caption = "Fecha";
            this.VEN_FECHA.FieldName = "VEN_FECHA";
            this.VEN_FECHA.MaxWidth = 70;
            this.VEN_FECHA.MinWidth = 70;
            this.VEN_FECHA.Name = "VEN_FECHA";
            this.VEN_FECHA.Visible = true;
            this.VEN_FECHA.VisibleIndex = 1;
            this.VEN_FECHA.Width = 70;
            // 
            // VEND_CANTIDAD
            // 
            this.VEND_CANTIDAD.Caption = "Cantidad";
            this.VEND_CANTIDAD.FieldName = "VEND_CANTIDAD";
            this.VEND_CANTIDAD.MaxWidth = 35;
            this.VEND_CANTIDAD.MinWidth = 35;
            this.VEND_CANTIDAD.Name = "VEND_CANTIDAD";
            this.VEND_CANTIDAD.Visible = true;
            this.VEND_CANTIDAD.VisibleIndex = 2;
            this.VEND_CANTIDAD.Width = 35;
            // 
            // VEND_IMPORTE
            // 
            this.VEND_IMPORTE.Caption = "Importe";
            this.VEND_IMPORTE.FieldName = "VEND_IMPORTE";
            this.VEND_IMPORTE.Name = "VEND_IMPORTE";
            this.VEND_IMPORTE.Visible = true;
            this.VEND_IMPORTE.VisibleIndex = 3;
            this.VEND_IMPORTE.Width = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(568, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 241;
            this.label2.Text = "Ventas en propio";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(593, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 242;
            this.label3.Text = "Propios:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbpropio
            // 
            this.lbpropio.AutoSize = true;
            this.lbpropio.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbpropio.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpropio.ForeColor = System.Drawing.Color.Crimson;
            this.lbpropio.Location = new System.Drawing.Point(664, 397);
            this.lbpropio.Name = "lbpropio";
            this.lbpropio.Size = new System.Drawing.Size(17, 17);
            this.lbpropio.TabIndex = 243;
            this.lbpropio.Text = "0";
            this.lbpropio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbpropio.Click += new System.EventHandler(this.lbpropio_Click);
            // 
            // lbstocks
            // 
            this.lbstocks.AutoSize = true;
            this.lbstocks.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbstocks.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstocks.ForeColor = System.Drawing.Color.Crimson;
            this.lbstocks.Location = new System.Drawing.Point(664, 426);
            this.lbstocks.Name = "lbstocks";
            this.lbstocks.Size = new System.Drawing.Size(17, 17);
            this.lbstocks.TabIndex = 245;
            this.lbstocks.Text = "0";
            this.lbstocks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(593, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 244;
            this.label6.Text = "Stock:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbstock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(896, 482);
            this.Controls.Add(this.lbstocks);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbpropio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gConsulta1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbrendicion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.gConsulta);
            this.Name = "lbstock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de consignas y ventas en propio...";
            this.Load += new System.EventHandler(this.ConsultasConsignas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            this.cmdmenugrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncancelar;
        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private DevExpress.XtraGrid.Columns.GridColumn CONS_NROCONSIG;
        private DevExpress.XtraGrid.Columns.GridColumn CONS_REMITO;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbrendicion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip cmdmenugrid;
        private System.Windows.Forms.ToolStripMenuItem exportarAExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarAPDFToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.SaveFileDialog sfdRuta;
        private System.Windows.Forms.SaveFileDialog sfdRuta1;
        private DevExpress.XtraGrid.GridControl gConsulta1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_IDE;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_FECHA;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn CONS_FECENVIO;
        private DevExpress.XtraGrid.Columns.GridColumn CONS_FECRECEP;
        private DevExpress.XtraGrid.Columns.GridColumn VEND_CANTIDAD;
        private DevExpress.XtraGrid.Columns.GridColumn VEND_IMPORTE;
        private DevExpress.XtraGrid.Columns.GridColumn CONS_CANTIDAD;
        private DevExpress.XtraGrid.Columns.GridColumn CONS_IMPORTE;
        private DevExpress.XtraGrid.Columns.GridColumn CONS_ORIGINAL;
        private DevExpress.XtraGrid.Columns.GridColumn CONS_RENDIDO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbpropio;
        private System.Windows.Forms.Label lbstocks;
        private System.Windows.Forms.Label label6;
    }
}