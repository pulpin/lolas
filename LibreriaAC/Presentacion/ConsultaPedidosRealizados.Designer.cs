namespace Presentacion
{
    partial class ConsultaPedidosRealizados
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.btncancelar = new System.Windows.Forms.Button();
            this.cmdmenugrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportarAExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarAPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.sfdRuta = new System.Windows.Forms.SaveFileDialog();
            this.sfdRuta1 = new System.Windows.Forms.SaveFileDialog();
            this.chbTitulo = new System.Windows.Forms.CheckBox();
            this.gConsulta1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PROV_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PED_FECHA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PEDD_CANTIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdmenugrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancel48;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(539, 356);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(87, 67);
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
            // chbTitulo
            // 
            this.chbTitulo.AutoSize = true;
            this.chbTitulo.Checked = true;
            this.chbTitulo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTitulo.Location = new System.Drawing.Point(669, 17);
            this.chbTitulo.Name = "chbTitulo";
            this.chbTitulo.Size = new System.Drawing.Size(56, 17);
            this.chbTitulo.TabIndex = 244;
            this.chbTitulo.Text = "Todos";
            this.chbTitulo.UseVisualStyleBackColor = true;
            this.chbTitulo.CheckedChanged += new System.EventHandler(this.chbTitulo_CheckedChanged);
            // 
            // gConsulta1
            // 
            this.gConsulta1.ContextMenuStrip = this.cmdmenugrid;
            gridLevelNode1.RelationName = "Level1";
            this.gConsulta1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gConsulta1.Location = new System.Drawing.Point(15, 53);
            this.gConsulta1.MainView = this.gridView1;
            this.gConsulta1.Name = "gConsulta1";
            this.gConsulta1.Size = new System.Drawing.Size(435, 287);
            this.gConsulta1.TabIndex = 250;
            this.gConsulta1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PROV_DESC,
            this.PED_FECHA,
            this.PEDD_CANTIDAD});
            this.gridView1.GridControl = this.gConsulta1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Cantidad", null, "(Cantidad: Recuento={0})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // PROV_DESC
            // 
            this.PROV_DESC.Caption = "Proveedor";
            this.PROV_DESC.FieldName = "PROV_DESC";
            this.PROV_DESC.MaxWidth = 80;
            this.PROV_DESC.MinWidth = 80;
            this.PROV_DESC.Name = "PROV_DESC";
            this.PROV_DESC.Visible = true;
            this.PROV_DESC.VisibleIndex = 0;
            this.PROV_DESC.Width = 80;
            // 
            // PED_FECHA
            // 
            this.PED_FECHA.Caption = "Fecha";
            this.PED_FECHA.FieldName = "PED_FECHA";
            this.PED_FECHA.MaxWidth = 200;
            this.PED_FECHA.MinWidth = 200;
            this.PED_FECHA.Name = "PED_FECHA";
            this.PED_FECHA.Visible = true;
            this.PED_FECHA.VisibleIndex = 1;
            this.PED_FECHA.Width = 200;
            // 
            // PEDD_CANTIDAD
            // 
            this.PEDD_CANTIDAD.Caption = "Cantidad";
            this.PEDD_CANTIDAD.FieldName = "PEDD_CANTIDAD";
            this.PEDD_CANTIDAD.MaxWidth = 70;
            this.PEDD_CANTIDAD.MinWidth = 70;
            this.PEDD_CANTIDAD.Name = "PEDD_CANTIDAD";
            this.PEDD_CANTIDAD.Visible = true;
            this.PEDD_CANTIDAD.VisibleIndex = 2;
            this.PEDD_CANTIDAD.Width = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 251;
            this.label1.Text = "Productos pedidos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Image = global::Presentacion.Properties.Resources.salir48;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(363, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 67);
            this.button1.TabIndex = 252;
            this.button1.Text = "Salir";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ConsultaPedidosRealizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(471, 419);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gConsulta1);
            this.Controls.Add(this.chbTitulo);
            this.Controls.Add(this.btncancelar);
            this.Name = "ConsultaPedidosRealizados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos realizados...";
            this.Load += new System.EventHandler(this.ConsultasConsignas_Load);
            this.cmdmenugrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.ContextMenuStrip cmdmenugrid;
        private System.Windows.Forms.ToolStripMenuItem exportarAExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarAPDFToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.SaveFileDialog sfdRuta;
        private System.Windows.Forms.SaveFileDialog sfdRuta1;
        private System.Windows.Forms.CheckBox chbTitulo;
        private DevExpress.XtraGrid.GridControl gConsulta1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn PROV_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn PED_FECHA;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn PEDD_CANTIDAD;
        private System.Windows.Forms.Button button1;
    }
}