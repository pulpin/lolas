namespace Presentacion
{
    partial class ConsultasHistoricoD
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
            this.DEV_REMITO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEV_CODIGOVIEJO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEV_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEV_NROCONSIGNA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEV_CANTIORIGINAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEV_CANTIDEVOL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEV_IMPORTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.subtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btneliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbrendicion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.sfdRuta = new System.Windows.Forms.SaveFileDialog();
            this.sfdRuta1 = new System.Windows.Forms.SaveFileDialog();
            this.lbfecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            this.cmdmenugrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
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
            this.gConsulta.Click += new System.EventHandler(this.gConsulta_Click);
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
            this.DEV_REMITO,
            this.DEV_CODIGOVIEJO,
            this.DEV_DESC,
            this.DEV_NROCONSIGNA,
            this.DEV_CANTIORIGINAL,
            this.DEV_CANTIDEVOL,
            this.DEV_IMPORTE,
            this.subtotal});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            // 
            // DEV_REMITO
            // 
            this.DEV_REMITO.Caption = "Remito";
            this.DEV_REMITO.FieldName = "DEV_REMITO";
            this.DEV_REMITO.MaxWidth = 70;
            this.DEV_REMITO.MinWidth = 70;
            this.DEV_REMITO.Name = "DEV_REMITO";
            this.DEV_REMITO.Visible = true;
            this.DEV_REMITO.VisibleIndex = 0;
            this.DEV_REMITO.Width = 70;
            // 
            // DEV_CODIGOVIEJO
            // 
            this.DEV_CODIGOVIEJO.Caption = "Código";
            this.DEV_CODIGOVIEJO.FieldName = "DEV_CODIGOVIEJO";
            this.DEV_CODIGOVIEJO.MaxWidth = 70;
            this.DEV_CODIGOVIEJO.MinWidth = 70;
            this.DEV_CODIGOVIEJO.Name = "DEV_CODIGOVIEJO";
            this.DEV_CODIGOVIEJO.Visible = true;
            this.DEV_CODIGOVIEJO.VisibleIndex = 1;
            this.DEV_CODIGOVIEJO.Width = 70;
            // 
            // DEV_DESC
            // 
            this.DEV_DESC.Caption = "Título";
            this.DEV_DESC.FieldName = "DEV_DESC";
            this.DEV_DESC.MaxWidth = 230;
            this.DEV_DESC.MinWidth = 230;
            this.DEV_DESC.Name = "DEV_DESC";
            this.DEV_DESC.Visible = true;
            this.DEV_DESC.VisibleIndex = 2;
            this.DEV_DESC.Width = 230;
            // 
            // DEV_NROCONSIGNA
            // 
            this.DEV_NROCONSIGNA.Caption = "Consigna";
            this.DEV_NROCONSIGNA.FieldName = "DEV_NROCONSIGNA";
            this.DEV_NROCONSIGNA.MaxWidth = 90;
            this.DEV_NROCONSIGNA.MinWidth = 90;
            this.DEV_NROCONSIGNA.Name = "DEV_NROCONSIGNA";
            this.DEV_NROCONSIGNA.Visible = true;
            this.DEV_NROCONSIGNA.VisibleIndex = 3;
            this.DEV_NROCONSIGNA.Width = 90;
            // 
            // DEV_CANTIORIGINAL
            // 
            this.DEV_CANTIORIGINAL.Caption = "Cantidad";
            this.DEV_CANTIORIGINAL.FieldName = "DEV_CANTIORIGINAL";
            this.DEV_CANTIORIGINAL.MaxWidth = 90;
            this.DEV_CANTIORIGINAL.MinWidth = 90;
            this.DEV_CANTIORIGINAL.Name = "DEV_CANTIORIGINAL";
            this.DEV_CANTIORIGINAL.Visible = true;
            this.DEV_CANTIORIGINAL.VisibleIndex = 4;
            this.DEV_CANTIORIGINAL.Width = 90;
            // 
            // DEV_CANTIDEVOL
            // 
            this.DEV_CANTIDEVOL.Caption = "Devolución";
            this.DEV_CANTIDEVOL.FieldName = "DEV_CANTIDEVOL";
            this.DEV_CANTIDEVOL.MaxWidth = 70;
            this.DEV_CANTIDEVOL.MinWidth = 70;
            this.DEV_CANTIDEVOL.Name = "DEV_CANTIDEVOL";
            this.DEV_CANTIDEVOL.Visible = true;
            this.DEV_CANTIDEVOL.VisibleIndex = 6;
            this.DEV_CANTIDEVOL.Width = 70;
            // 
            // DEV_IMPORTE
            // 
            this.DEV_IMPORTE.Caption = "Importe";
            this.DEV_IMPORTE.FieldName = "DEV_IMPORTE";
            this.DEV_IMPORTE.MaxWidth = 70;
            this.DEV_IMPORTE.MinWidth = 70;
            this.DEV_IMPORTE.Name = "DEV_IMPORTE";
            this.DEV_IMPORTE.Visible = true;
            this.DEV_IMPORTE.VisibleIndex = 5;
            this.DEV_IMPORTE.Width = 70;
            // 
            // subtotal
            // 
            this.subtotal.Caption = "Subtotal";
            this.subtotal.FieldName = "subtotal";
            this.subtotal.MaxWidth = 80;
            this.subtotal.MinWidth = 80;
            this.subtotal.Name = "subtotal";
            this.subtotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "subtotal", "Total={0:#.##}")});
            this.subtotal.Visible = true;
            this.subtotal.VisibleIndex = 7;
            this.subtotal.Width = 80;
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
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 201;
            this.label1.Text = "Editorial:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbrendicion
            // 
            this.lbrendicion.AutoSize = true;
            this.lbrendicion.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrendicion.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbrendicion.Location = new System.Drawing.Point(87, 9);
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
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfecha.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbfecha.Location = new System.Drawing.Point(432, 9);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(0, 17);
            this.lbfecha.TabIndex = 241;
            this.lbfecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(373, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 240;
            this.label3.Text = "Fecha:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConsultasHistoricoD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(834, 482);
            this.Controls.Add(this.lbfecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbrendicion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.gConsulta);
            this.Name = "ConsultasHistoricoD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles de la Devolución";
            this.Load += new System.EventHandler(this.ConsultasConsignas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            this.cmdmenugrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncancelar;
        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private DevExpress.XtraGrid.Columns.GridColumn DEV_REMITO;
        private DevExpress.XtraGrid.Columns.GridColumn DEV_CODIGOVIEJO;
        private DevExpress.XtraGrid.Columns.GridColumn DEV_NROCONSIGNA;
        private DevExpress.XtraGrid.Columns.GridColumn DEV_CANTIORIGINAL;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbrendicion;
        private DevExpress.XtraGrid.Columns.GridColumn DEV_CANTIDEVOL;
        private DevExpress.XtraGrid.Columns.GridColumn DEV_IMPORTE;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip cmdmenugrid;
        private System.Windows.Forms.ToolStripMenuItem exportarAExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarAPDFToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.SaveFileDialog sfdRuta;
        private System.Windows.Forms.SaveFileDialog sfdRuta1;
        private DevExpress.XtraGrid.Columns.GridColumn subtotal;
        private DevExpress.XtraGrid.Columns.GridColumn DEV_DESC;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Label label3;
    }
}