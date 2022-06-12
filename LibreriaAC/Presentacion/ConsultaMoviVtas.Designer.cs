namespace Presentacion
{
    partial class ConsultaMoviVtas
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
            this.REGV_FECHAVTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.REGV_CANTIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.REGV_NROVTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tipo = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.MOV_FECHA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MOV_CANTIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MOV_REMITO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PROV_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.usuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
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
            this.gConsulta.Size = new System.Drawing.Size(325, 342);
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
            this.REGV_FECHAVTA,
            this.REGV_CANTIDAD,
            this.REGV_NROVTA,
            this.tipo});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Cantidad", null, "(Cantidad: Recuento={0})")});
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            // 
            // REGV_FECHAVTA
            // 
            this.REGV_FECHAVTA.Caption = "Fecha";
            this.REGV_FECHAVTA.FieldName = "REGV_FECHAVTA";
            this.REGV_FECHAVTA.MaxWidth = 70;
            this.REGV_FECHAVTA.MinWidth = 70;
            this.REGV_FECHAVTA.Name = "REGV_FECHAVTA";
            this.REGV_FECHAVTA.Visible = true;
            this.REGV_FECHAVTA.VisibleIndex = 0;
            this.REGV_FECHAVTA.Width = 70;
            // 
            // REGV_CANTIDAD
            // 
            this.REGV_CANTIDAD.Caption = "Cantidad";
            this.REGV_CANTIDAD.FieldName = "REGV_CANTIDAD";
            this.REGV_CANTIDAD.MaxWidth = 70;
            this.REGV_CANTIDAD.MinWidth = 70;
            this.REGV_CANTIDAD.Name = "REGV_CANTIDAD";
            this.REGV_CANTIDAD.Visible = true;
            this.REGV_CANTIDAD.VisibleIndex = 1;
            this.REGV_CANTIDAD.Width = 70;
            // 
            // REGV_NROVTA
            // 
            this.REGV_NROVTA.Caption = "Nro_Venta";
            this.REGV_NROVTA.FieldName = "REGV_NROVTA";
            this.REGV_NROVTA.Name = "REGV_NROVTA";
            this.REGV_NROVTA.Visible = true;
            this.REGV_NROVTA.VisibleIndex = 2;
            // 
            // tipo
            // 
            this.tipo.Caption = "Tipo";
            this.tipo.FieldName = "tipo";
            this.tipo.Name = "tipo";
            this.tipo.Visible = true;
            this.tipo.VisibleIndex = 3;
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
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 201;
            this.label1.Text = "Ventas";
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
            this.gConsulta1.Location = new System.Drawing.Point(343, 36);
            this.gConsulta1.MainView = this.gridView1;
            this.gConsulta1.Name = "gConsulta1";
            this.gConsulta1.Size = new System.Drawing.Size(495, 342);
            this.gConsulta1.TabIndex = 240;
            this.gConsulta1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MOV_FECHA,
            this.MOV_CANTIDAD,
            this.MOV_REMITO,
            this.PROV_DESC,
            this.usuario});
            this.gridView1.GridControl = this.gConsulta1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Cantidad", null, "(Cantidad: Recuento={0})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // MOV_FECHA
            // 
            this.MOV_FECHA.Caption = "Fecha";
            this.MOV_FECHA.FieldName = "MOV_FECHA";
            this.MOV_FECHA.MaxWidth = 80;
            this.MOV_FECHA.MinWidth = 80;
            this.MOV_FECHA.Name = "MOV_FECHA";
            this.MOV_FECHA.Visible = true;
            this.MOV_FECHA.VisibleIndex = 0;
            this.MOV_FECHA.Width = 80;
            // 
            // MOV_CANTIDAD
            // 
            this.MOV_CANTIDAD.Caption = "Cantidad";
            this.MOV_CANTIDAD.FieldName = "MOV_CANTIDAD";
            this.MOV_CANTIDAD.MaxWidth = 65;
            this.MOV_CANTIDAD.MinWidth = 65;
            this.MOV_CANTIDAD.Name = "MOV_CANTIDAD";
            this.MOV_CANTIDAD.Visible = true;
            this.MOV_CANTIDAD.VisibleIndex = 1;
            this.MOV_CANTIDAD.Width = 65;
            // 
            // MOV_REMITO
            // 
            this.MOV_REMITO.Caption = "Remito";
            this.MOV_REMITO.FieldName = "MOV_REMITO";
            this.MOV_REMITO.MaxWidth = 70;
            this.MOV_REMITO.MinWidth = 70;
            this.MOV_REMITO.Name = "MOV_REMITO";
            this.MOV_REMITO.Visible = true;
            this.MOV_REMITO.VisibleIndex = 2;
            this.MOV_REMITO.Width = 70;
            // 
            // PROV_DESC
            // 
            this.PROV_DESC.Caption = "Proveedor";
            this.PROV_DESC.FieldName = "PROV_DESC";
            this.PROV_DESC.Name = "PROV_DESC";
            this.PROV_DESC.Visible = true;
            this.PROV_DESC.VisibleIndex = 3;
            this.PROV_DESC.Width = 180;
            // 
            // usuario
            // 
            this.usuario.Caption = "Usuario";
            this.usuario.FieldName = "usuario";
            this.usuario.Name = "usuario";
            this.usuario.Visible = true;
            this.usuario.VisibleIndex = 4;
            this.usuario.Width = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(357, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 17);
            this.label2.TabIndex = 241;
            this.label2.Text = "Movimientos (altas y bajas)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConsultaMoviVtas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(850, 482);
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
            this.Name = "ConsultaMoviVtas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles del producto seleccionado...";
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
        private DevExpress.XtraGrid.Columns.GridColumn REGV_FECHAVTA;
        private DevExpress.XtraGrid.Columns.GridColumn REGV_CANTIDAD;
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
        private DevExpress.XtraGrid.Columns.GridColumn MOV_FECHA;
        private DevExpress.XtraGrid.Columns.GridColumn MOV_CANTIDAD;
        private DevExpress.XtraGrid.Columns.GridColumn MOV_REMITO;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn REGV_NROVTA;
        private DevExpress.XtraGrid.Columns.GridColumn tipo;
        private DevExpress.XtraGrid.Columns.GridColumn PROV_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn usuario;
    }
}