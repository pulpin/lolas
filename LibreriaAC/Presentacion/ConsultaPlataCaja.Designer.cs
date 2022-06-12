namespace Presentacion
{
    partial class ConsultaPlataCaja
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
            this.PC_FECHA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PC_DINERO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PC_OBS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PC_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PC_PUNTODEVTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btneliminar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.sfdRuta = new System.Windows.Forms.SaveFileDialog();
            this.sfdRuta1 = new System.Windows.Forms.SaveFileDialog();
            this.btnborrarusu = new System.Windows.Forms.Button();
            this.btnaltacliente = new System.Windows.Forms.Button();
            this.PC_TOTALEFECTIVO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PC_TOTALTARJETA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PC_TOTALAJUSTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PC_SUBTOTALVENTAS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PC_DINEROENCAJA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PC_TARJETAENCAJA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PC_SUBTOTALENCAJA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PC_DIFERENCIA = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gConsulta.Location = new System.Drawing.Point(12, 67);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(591, 311);
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
            this.PC_FECHA,
            this.PC_DINERO,
            this.PC_OBS,
            this.PC_IDE,
            this.PC_PUNTODEVTA,
            this.PC_TOTALEFECTIVO,
            this.PC_TOTALTARJETA,
            this.PC_TOTALAJUSTE,
            this.PC_SUBTOTALVENTAS,
            this.PC_DINEROENCAJA,
            this.PC_TARJETAENCAJA,
            this.PC_SUBTOTALENCAJA,
            this.PC_DIFERENCIA});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Cantidad", null, "(Cantidad: Recuento={0})")});
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            // 
            // PC_FECHA
            // 
            this.PC_FECHA.Caption = "Fecha";
            this.PC_FECHA.FieldName = "PC_FECHA";
            this.PC_FECHA.MaxWidth = 150;
            this.PC_FECHA.MinWidth = 150;
            this.PC_FECHA.Name = "PC_FECHA";
            this.PC_FECHA.Visible = true;
            this.PC_FECHA.VisibleIndex = 0;
            this.PC_FECHA.Width = 150;
            // 
            // PC_DINERO
            // 
            this.PC_DINERO.Caption = "Importe";
            this.PC_DINERO.FieldName = "PC_DINERO";
            this.PC_DINERO.MaxWidth = 70;
            this.PC_DINERO.MinWidth = 70;
            this.PC_DINERO.Name = "PC_DINERO";
            this.PC_DINERO.Visible = true;
            this.PC_DINERO.VisibleIndex = 1;
            this.PC_DINERO.Width = 70;
            // 
            // PC_OBS
            // 
            this.PC_OBS.Caption = "Observación";
            this.PC_OBS.FieldName = "PC_OBS";
            this.PC_OBS.Name = "PC_OBS";
            this.PC_OBS.Visible = true;
            this.PC_OBS.VisibleIndex = 2;
            this.PC_OBS.Width = 353;
            // 
            // PC_IDE
            // 
            this.PC_IDE.Caption = "PC_IDE";
            this.PC_IDE.FieldName = "PC_IDE";
            this.PC_IDE.Name = "PC_IDE";
            // 
            // PC_PUNTODEVTA
            // 
            this.PC_PUNTODEVTA.Caption = "PuntoDeVenta";
            this.PC_PUNTODEVTA.FieldName = "PC_PUNTODEVTA";
            this.PC_PUNTODEVTA.Name = "PC_PUNTODEVTA";
            this.PC_PUNTODEVTA.Visible = true;
            this.PC_PUNTODEVTA.VisibleIndex = 3;
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
            // btnborrarusu
            // 
            this.btnborrarusu.Image = global::Presentacion.Properties.Resources.delete32;
            this.btnborrarusu.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnborrarusu.Location = new System.Drawing.Point(82, 4);
            this.btnborrarusu.Name = "btnborrarusu";
            this.btnborrarusu.Size = new System.Drawing.Size(58, 57);
            this.btnborrarusu.TabIndex = 241;
            this.btnborrarusu.Text = "Eliminar";
            this.btnborrarusu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnborrarusu.UseVisualStyleBackColor = true;
            this.btnborrarusu.Click += new System.EventHandler(this.btnborrarusu_Click);
            // 
            // btnaltacliente
            // 
            this.btnaltacliente.Image = global::Presentacion.Properties.Resources.add32;
            this.btnaltacliente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnaltacliente.Location = new System.Drawing.Point(15, 4);
            this.btnaltacliente.Name = "btnaltacliente";
            this.btnaltacliente.Size = new System.Drawing.Size(58, 57);
            this.btnaltacliente.TabIndex = 240;
            this.btnaltacliente.Text = "Nuevo";
            this.btnaltacliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnaltacliente.UseVisualStyleBackColor = true;
            this.btnaltacliente.Click += new System.EventHandler(this.btnaltacliente_Click);
            // 
            // PC_TOTALEFECTIVO
            // 
            this.PC_TOTALEFECTIVO.Caption = "PC_TOTALEFECTIVO";
            this.PC_TOTALEFECTIVO.FieldName = "PC_TOTALEFECTIVO";
            this.PC_TOTALEFECTIVO.Name = "PC_TOTALEFECTIVO";
            // 
            // PC_TOTALTARJETA
            // 
            this.PC_TOTALTARJETA.Caption = "PC_TOTALTARJETA";
            this.PC_TOTALTARJETA.FieldName = "PC_TOTALTARJETA";
            this.PC_TOTALTARJETA.Name = "PC_TOTALTARJETA";
            // 
            // PC_TOTALAJUSTE
            // 
            this.PC_TOTALAJUSTE.Caption = "PC_TOTALAJUSTE";
            this.PC_TOTALAJUSTE.FieldName = "PC_TOTALAJUSTE";
            this.PC_TOTALAJUSTE.Name = "PC_TOTALAJUSTE";
            // 
            // PC_SUBTOTALVENTAS
            // 
            this.PC_SUBTOTALVENTAS.Caption = "PC_SUBTOTALVENTAS";
            this.PC_SUBTOTALVENTAS.FieldName = "PC_SUBTOTALVENTAS";
            this.PC_SUBTOTALVENTAS.Name = "PC_SUBTOTALVENTAS";
            // 
            // PC_DINEROENCAJA
            // 
            this.PC_DINEROENCAJA.Caption = "PC_DINEROENCAJA";
            this.PC_DINEROENCAJA.FieldName = "PC_DINEROENCAJA";
            this.PC_DINEROENCAJA.Name = "PC_DINEROENCAJA";
            // 
            // PC_TARJETAENCAJA
            // 
            this.PC_TARJETAENCAJA.Caption = "PC_TARJETAENCAJA";
            this.PC_TARJETAENCAJA.FieldName = "PC_TARJETAENCAJA";
            this.PC_TARJETAENCAJA.Name = "PC_TARJETAENCAJA";
            // 
            // PC_SUBTOTALENCAJA
            // 
            this.PC_SUBTOTALENCAJA.Caption = "PC_SUBTOTALENCAJA";
            this.PC_SUBTOTALENCAJA.FieldName = "PC_SUBTOTALENCAJA";
            this.PC_SUBTOTALENCAJA.Name = "PC_SUBTOTALENCAJA";
            // 
            // PC_DIFERENCIA
            // 
            this.PC_DIFERENCIA.Caption = "PC_DIFERENCIA";
            this.PC_DIFERENCIA.FieldName = "PC_DIFERENCIA";
            this.PC_DIFERENCIA.Name = "PC_DIFERENCIA";
            // 
            // ConsultaPlataCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(616, 482);
            this.Controls.Add(this.btnborrarusu);
            this.Controls.Add(this.btnaltacliente);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.gConsulta);
            this.Name = "ConsultaPlataCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso de efectivo en la caja";
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
        private DevExpress.XtraGrid.Columns.GridColumn PC_FECHA;
        private DevExpress.XtraGrid.Columns.GridColumn PC_DINERO;
        private System.Windows.Forms.Button btneliminar;
        private DevExpress.XtraGrid.Columns.GridColumn PC_OBS;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip cmdmenugrid;
        private System.Windows.Forms.ToolStripMenuItem exportarAExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarAPDFToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.SaveFileDialog sfdRuta;
        private System.Windows.Forms.SaveFileDialog sfdRuta1;
        private System.Windows.Forms.Button btnborrarusu;
        private System.Windows.Forms.Button btnaltacliente;
        private DevExpress.XtraGrid.Columns.GridColumn PC_IDE;
        private DevExpress.XtraGrid.Columns.GridColumn PC_PUNTODEVTA;
        private DevExpress.XtraGrid.Columns.GridColumn PC_TOTALEFECTIVO;
        private DevExpress.XtraGrid.Columns.GridColumn PC_TOTALTARJETA;
        private DevExpress.XtraGrid.Columns.GridColumn PC_TOTALAJUSTE;
        private DevExpress.XtraGrid.Columns.GridColumn PC_SUBTOTALVENTAS;
        private DevExpress.XtraGrid.Columns.GridColumn PC_DINEROENCAJA;
        private DevExpress.XtraGrid.Columns.GridColumn PC_TARJETAENCAJA;
        private DevExpress.XtraGrid.Columns.GridColumn PC_SUBTOTALENCAJA;
        private DevExpress.XtraGrid.Columns.GridColumn PC_DIFERENCIA;
    }
}