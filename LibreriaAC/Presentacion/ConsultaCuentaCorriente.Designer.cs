namespace Presentacion
{
    partial class ConsultaCuentaCorriente
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
            this.CUCO_VEN_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CUCO_FECHAVTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CUCO_APAGAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CUCO_PAGO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CUCO_FECHAPAGO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CUCO_SALDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CUCO_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btneliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbnombre = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.sfdRuta = new System.Windows.Forms.SaveFileDialog();
            this.sfdRuta1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            this.cmdmenugrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancelar64;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(503, 384);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(83, 86);
            this.btncancelar.TabIndex = 197;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // gConsulta
            // 
            this.gConsulta.ContextMenuStrip = this.cmdmenugrid;
            this.gConsulta.Location = new System.Drawing.Point(12, 57);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(810, 321);
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
            this.CUCO_VEN_IDE,
            this.CUCO_FECHAVTA,
            this.CUCO_APAGAR,
            this.CUCO_PAGO,
            this.CUCO_FECHAPAGO,
            this.CUCO_SALDO,
            this.CUCO_IDE});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            // 
            // CUCO_VEN_IDE
            // 
            this.CUCO_VEN_IDE.Caption = "Venta";
            this.CUCO_VEN_IDE.FieldName = "CUCO_VEN_IDE";
            this.CUCO_VEN_IDE.MaxWidth = 70;
            this.CUCO_VEN_IDE.MinWidth = 70;
            this.CUCO_VEN_IDE.Name = "CUCO_VEN_IDE";
            this.CUCO_VEN_IDE.Visible = true;
            this.CUCO_VEN_IDE.VisibleIndex = 0;
            this.CUCO_VEN_IDE.Width = 70;
            // 
            // CUCO_FECHAVTA
            // 
            this.CUCO_FECHAVTA.Caption = "Fecha_Vta";
            this.CUCO_FECHAVTA.FieldName = "CUCO_FECHAVTA";
            this.CUCO_FECHAVTA.MaxWidth = 70;
            this.CUCO_FECHAVTA.MinWidth = 70;
            this.CUCO_FECHAVTA.Name = "CUCO_FECHAVTA";
            this.CUCO_FECHAVTA.Visible = true;
            this.CUCO_FECHAVTA.VisibleIndex = 1;
            this.CUCO_FECHAVTA.Width = 70;
            // 
            // CUCO_APAGAR
            // 
            this.CUCO_APAGAR.Caption = "A_Pagar";
            this.CUCO_APAGAR.FieldName = "CUCO_APAGAR";
            this.CUCO_APAGAR.MaxWidth = 85;
            this.CUCO_APAGAR.MinWidth = 85;
            this.CUCO_APAGAR.Name = "CUCO_APAGAR";
            this.CUCO_APAGAR.Visible = true;
            this.CUCO_APAGAR.VisibleIndex = 2;
            this.CUCO_APAGAR.Width = 85;
            // 
            // CUCO_PAGO
            // 
            this.CUCO_PAGO.Caption = "Pagó";
            this.CUCO_PAGO.FieldName = "CUCO_PAGO";
            this.CUCO_PAGO.MaxWidth = 300;
            this.CUCO_PAGO.MinWidth = 300;
            this.CUCO_PAGO.Name = "CUCO_PAGO";
            this.CUCO_PAGO.Visible = true;
            this.CUCO_PAGO.VisibleIndex = 3;
            this.CUCO_PAGO.Width = 300;
            // 
            // CUCO_FECHAPAGO
            // 
            this.CUCO_FECHAPAGO.Caption = "Fecha_pago";
            this.CUCO_FECHAPAGO.FieldName = "CUCO_FECHAPAGO";
            this.CUCO_FECHAPAGO.MaxWidth = 120;
            this.CUCO_FECHAPAGO.MinWidth = 120;
            this.CUCO_FECHAPAGO.Name = "CUCO_FECHAPAGO";
            this.CUCO_FECHAPAGO.Visible = true;
            this.CUCO_FECHAPAGO.VisibleIndex = 4;
            this.CUCO_FECHAPAGO.Width = 120;
            // 
            // CUCO_SALDO
            // 
            this.CUCO_SALDO.Caption = "Saldo";
            this.CUCO_SALDO.FieldName = "CUCO_SALDO";
            this.CUCO_SALDO.MaxWidth = 100;
            this.CUCO_SALDO.MinWidth = 100;
            this.CUCO_SALDO.Name = "CUCO_SALDO";
            this.CUCO_SALDO.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CUCO_SALDO", "SALDO={0:#.##}")});
            this.CUCO_SALDO.Visible = true;
            this.CUCO_SALDO.VisibleIndex = 5;
            this.CUCO_SALDO.Width = 100;
            // 
            // CUCO_IDE
            // 
            this.CUCO_IDE.Caption = "CUCO_IDE";
            this.CUCO_IDE.FieldName = "CUCO_IDE";
            this.CUCO_IDE.Name = "CUCO_IDE";
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::Presentacion.Properties.Resources.factu64;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneliminar.Location = new System.Drawing.Point(249, 384);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(83, 86);
            this.btneliminar.TabIndex = 200;
            this.btneliminar.Text = "Pagar";
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
            this.label1.Text = "Nombre:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombre.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbnombre.Location = new System.Drawing.Point(87, 9);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(0, 17);
            this.lbnombre.TabIndex = 202;
            this.lbnombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Presentacion.Properties.Resources.excel32;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(15, 419);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(38, 35);
            this.panel2.TabIndex = 239;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Presentacion.Properties.Resources.pdf32;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(56, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(38, 35);
            this.panel1.TabIndex = 238;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(11, 399);
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
            // button1
            // 
            this.button1.Image = global::Presentacion.Properties.Resources.Impresora64;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(376, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 86);
            this.button1.TabIndex = 246;
            this.button1.Text = "Imprimir";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConsultaCuentaCorriente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(834, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.gConsulta);
            this.Name = "ConsultaCuentaCorriente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Cuenta Corriente...";
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
        private DevExpress.XtraGrid.Columns.GridColumn CUCO_VEN_IDE;
        private DevExpress.XtraGrid.Columns.GridColumn CUCO_FECHAVTA;
        private DevExpress.XtraGrid.Columns.GridColumn CUCO_PAGO;
        private DevExpress.XtraGrid.Columns.GridColumn CUCO_FECHAPAGO;
        private DevExpress.XtraGrid.Columns.GridColumn CUCO_SALDO;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbnombre;
        private DevExpress.XtraGrid.Columns.GridColumn CUCO_IDE;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip cmdmenugrid;
        private System.Windows.Forms.ToolStripMenuItem exportarAExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarAPDFToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.SaveFileDialog sfdRuta;
        private System.Windows.Forms.SaveFileDialog sfdRuta1;
        private DevExpress.XtraGrid.Columns.GridColumn CUCO_APAGAR;
        private System.Windows.Forms.Button button1;
    }
}