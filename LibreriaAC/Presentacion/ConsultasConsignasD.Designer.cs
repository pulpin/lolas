namespace Presentacion
{
    partial class ConsultasConsignasD
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
            this.CONS_LI_CODIGOVIEJO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_AUTOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CONS_CANTIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CONS_IMPORTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CONS_RENDIDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CONS_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnagregapro = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbconsigna = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.sfdRuta1 = new System.Windows.Forms.SaveFileDialog();
            this.sfdRuta = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbeditorial = new System.Windows.Forms.Label();
            this.lbremito = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            this.cmdmenugrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancelar64;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(538, 388);
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
            this.gConsulta.Size = new System.Drawing.Size(772, 342);
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
            this.CONS_LI_CODIGOVIEJO,
            this.LI_DESC,
            this.LI_AUTOR,
            this.CONS_CANTIDAD,
            this.CONS_IMPORTE,
            this.CONS_RENDIDO,
            this.CONS_IDE});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            // 
            // CONS_LI_CODIGOVIEJO
            // 
            this.CONS_LI_CODIGOVIEJO.Caption = "Código";
            this.CONS_LI_CODIGOVIEJO.FieldName = "CONS_LI_CODIGOVIEJO";
            this.CONS_LI_CODIGOVIEJO.MaxWidth = 70;
            this.CONS_LI_CODIGOVIEJO.MinWidth = 70;
            this.CONS_LI_CODIGOVIEJO.Name = "CONS_LI_CODIGOVIEJO";
            this.CONS_LI_CODIGOVIEJO.Visible = true;
            this.CONS_LI_CODIGOVIEJO.VisibleIndex = 0;
            this.CONS_LI_CODIGOVIEJO.Width = 70;
            // 
            // LI_DESC
            // 
            this.LI_DESC.Caption = "Producto";
            this.LI_DESC.FieldName = "LI_DESC";
            this.LI_DESC.MaxWidth = 300;
            this.LI_DESC.MinWidth = 300;
            this.LI_DESC.Name = "LI_DESC";
            this.LI_DESC.Visible = true;
            this.LI_DESC.VisibleIndex = 1;
            this.LI_DESC.Width = 300;
            // 
            // LI_AUTOR
            // 
            this.LI_AUTOR.Caption = "Autor";
            this.LI_AUTOR.FieldName = "LI_AUTOR";
            this.LI_AUTOR.MaxWidth = 100;
            this.LI_AUTOR.MinWidth = 100;
            this.LI_AUTOR.Name = "LI_AUTOR";
            this.LI_AUTOR.Visible = true;
            this.LI_AUTOR.VisibleIndex = 2;
            this.LI_AUTOR.Width = 100;
            // 
            // CONS_CANTIDAD
            // 
            this.CONS_CANTIDAD.Caption = "Cantidad";
            this.CONS_CANTIDAD.FieldName = "CONS_CANTIDAD";
            this.CONS_CANTIDAD.MaxWidth = 70;
            this.CONS_CANTIDAD.MinWidth = 70;
            this.CONS_CANTIDAD.Name = "CONS_CANTIDAD";
            this.CONS_CANTIDAD.Visible = true;
            this.CONS_CANTIDAD.VisibleIndex = 3;
            this.CONS_CANTIDAD.Width = 70;
            // 
            // CONS_IMPORTE
            // 
            this.CONS_IMPORTE.Caption = "Importe";
            this.CONS_IMPORTE.FieldName = "CONS_IMPORTE";
            this.CONS_IMPORTE.MaxWidth = 70;
            this.CONS_IMPORTE.MinWidth = 70;
            this.CONS_IMPORTE.Name = "CONS_IMPORTE";
            this.CONS_IMPORTE.Visible = true;
            this.CONS_IMPORTE.VisibleIndex = 4;
            this.CONS_IMPORTE.Width = 70;
            // 
            // CONS_RENDIDO
            // 
            this.CONS_RENDIDO.Caption = "Rendido";
            this.CONS_RENDIDO.FieldName = "CONS_RENDIDO";
            this.CONS_RENDIDO.MaxWidth = 90;
            this.CONS_RENDIDO.MinWidth = 90;
            this.CONS_RENDIDO.Name = "CONS_RENDIDO";
            this.CONS_RENDIDO.Visible = true;
            this.CONS_RENDIDO.VisibleIndex = 5;
            this.CONS_RENDIDO.Width = 90;
            // 
            // CONS_IDE
            // 
            this.CONS_IDE.Caption = "CONS_IDE";
            this.CONS_IDE.FieldName = "CONS_IDE";
            this.CONS_IDE.Name = "CONS_IDE";
            // 
            // btnagregapro
            // 
            this.btnagregapro.Image = global::Presentacion.Properties.Resources.agregali64;
            this.btnagregapro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnagregapro.Location = new System.Drawing.Point(288, 388);
            this.btnagregapro.Name = "btnagregapro";
            this.btnagregapro.Size = new System.Drawing.Size(102, 87);
            this.btnagregapro.TabIndex = 0;
            this.btnagregapro.Text = "Nuevo producto";
            this.btnagregapro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnagregapro.UseVisualStyleBackColor = true;
            this.btnagregapro.Click += new System.EventHandler(this.btnagregacon_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::Presentacion.Properties.Resources.borrar64;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneliminar.Location = new System.Drawing.Point(413, 388);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(102, 87);
            this.btneliminar.TabIndex = 200;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 201;
            this.label1.Text = "Número de consigna:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbconsigna
            // 
            this.lbconsigna.AutoSize = true;
            this.lbconsigna.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbconsigna.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbconsigna.Location = new System.Drawing.Point(167, 9);
            this.lbconsigna.Name = "lbconsigna";
            this.lbconsigna.Size = new System.Drawing.Size(0, 17);
            this.lbconsigna.TabIndex = 202;
            this.lbconsigna.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Presentacion.Properties.Resources.excel32;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(45, 420);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(38, 35);
            this.panel2.TabIndex = 242;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Presentacion.Properties.Resources.pdf32;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(86, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(38, 35);
            this.panel1.TabIndex = 241;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(15, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 240;
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
            // button1
            // 
            this.button1.Image = global::Presentacion.Properties.Resources.Impresora64;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(163, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 87);
            this.button1.TabIndex = 244;
            this.button1.Text = "Imprimir";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(285, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 245;
            this.label2.Text = "Editorial: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbeditorial
            // 
            this.lbeditorial.AutoSize = true;
            this.lbeditorial.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbeditorial.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbeditorial.Location = new System.Drawing.Point(349, 9);
            this.lbeditorial.Name = "lbeditorial";
            this.lbeditorial.Size = new System.Drawing.Size(73, 17);
            this.lbeditorial.TabIndex = 246;
            this.lbeditorial.Text = "Editorial: ";
            this.lbeditorial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbremito
            // 
            this.lbremito.AutoSize = true;
            this.lbremito.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbremito.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbremito.Location = new System.Drawing.Point(607, 9);
            this.lbremito.Name = "lbremito";
            this.lbremito.Size = new System.Drawing.Size(73, 17);
            this.lbremito.TabIndex = 248;
            this.lbremito.Text = "Editorial: ";
            this.lbremito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label6.Location = new System.Drawing.Point(543, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 247;
            this.label6.Text = "Remito:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConsultasConsignasD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(796, 482);
            this.Controls.Add(this.lbremito);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbeditorial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbconsigna);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnagregapro);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.gConsulta);
            this.Name = "ConsultasConsignasD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles de la consigna";
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
        private DevExpress.XtraGrid.Columns.GridColumn CONS_LI_CODIGOVIEJO;
        private DevExpress.XtraGrid.Columns.GridColumn LI_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn LI_AUTOR;
        private DevExpress.XtraGrid.Columns.GridColumn CONS_CANTIDAD;
        private DevExpress.XtraGrid.Columns.GridColumn CONS_IMPORTE;
        private DevExpress.XtraGrid.Columns.GridColumn CONS_RENDIDO;
        private System.Windows.Forms.Button btnagregapro;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbconsigna;
        private DevExpress.XtraGrid.Columns.GridColumn CONS_IDE;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SaveFileDialog sfdRuta1;
        private System.Windows.Forms.SaveFileDialog sfdRuta;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ContextMenuStrip cmdmenugrid;
        private System.Windows.Forms.ToolStripMenuItem exportarAExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarAPDFToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbeditorial;
        private System.Windows.Forms.Label lbremito;
        private System.Windows.Forms.Label label6;
    }
}