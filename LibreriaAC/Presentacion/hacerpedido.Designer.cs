namespace Presentacion
{
    partial class hacerpedido
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
            this.btneliminar = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.sfdRuta = new System.Windows.Forms.SaveFileDialog();
            this.sfdRuta1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gConsulta = new DevExpress.XtraGrid.GridControl();
            this.gridViewPintarFilas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.EDI_EDITORIAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EDI_CODIGO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gConsulta1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LI_CODIGOVIEJO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_BARRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_AUTOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.editorial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_PEDIDOS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_CODIGOPROVEE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lUEproveedor = new DevExpress.XtraEditors.LookUpEdit();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rBlolasdb = new System.Windows.Forms.RadioButton();
            this.rBlibros = new System.Windows.Forms.RadioButton();
            this.cmdmenugrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUEproveedor.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            // btneliminar
            // 
            this.btneliminar.Image = global::Presentacion.Properties.Resources.pedido32;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneliminar.Location = new System.Drawing.Point(715, 501);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(80, 68);
            this.btneliminar.TabIndex = 200;
            this.btneliminar.Text = "Generar pedido";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
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
            this.button1.Image = global::Presentacion.Properties.Resources.editar321;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(618, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 68);
            this.button1.TabIndex = 246;
            this.button1.Text = "Modificar cantidad";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Presentacion.Properties.Resources.cancelar32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(812, 501);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 68);
            this.button2.TabIndex = 245;
            this.button2.Text = "Salir";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gConsulta
            // 
            this.gConsulta.Location = new System.Drawing.Point(12, 39);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(222, 460);
            this.gConsulta.TabIndex = 248;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            this.gConsulta.Click += new System.EventHandler(this.gConsulta_Click);
            // 
            // gridViewPintarFilas
            // 
            this.gridViewPintarFilas.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent;
            this.gridViewPintarFilas.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.Transparent;
            this.gridViewPintarFilas.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Transparent;
            this.gridViewPintarFilas.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridViewPintarFilas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewPintarFilas.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridViewPintarFilas.Appearance.SelectedRow.Options.UseFont = true;
            this.gridViewPintarFilas.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewPintarFilas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.EDI_EDITORIAL,
            this.EDI_CODIGO});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsSelection.MultiSelect = true;
            this.gridViewPintarFilas.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            this.gridViewPintarFilas.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewPintarFilas_FocusedRowChanged);
            // 
            // EDI_EDITORIAL
            // 
            this.EDI_EDITORIAL.Caption = "Editorial";
            this.EDI_EDITORIAL.FieldName = "EDI_EDITORIAL";
            this.EDI_EDITORIAL.MaxWidth = 120;
            this.EDI_EDITORIAL.MinWidth = 120;
            this.EDI_EDITORIAL.Name = "EDI_EDITORIAL";
            this.EDI_EDITORIAL.Visible = true;
            this.EDI_EDITORIAL.VisibleIndex = 1;
            this.EDI_EDITORIAL.Width = 120;
            // 
            // EDI_CODIGO
            // 
            this.EDI_CODIGO.Caption = "EDI_CODIGO";
            this.EDI_CODIGO.FieldName = "EDI_CODIGO";
            this.EDI_CODIGO.Name = "EDI_CODIGO";
            // 
            // gConsulta1
            // 
            this.gConsulta1.ContextMenuStrip = this.cmdmenugrid;
            this.gConsulta1.Location = new System.Drawing.Point(256, 40);
            this.gConsulta1.MainView = this.gridView1;
            this.gConsulta1.Name = "gConsulta1";
            this.gConsulta1.Size = new System.Drawing.Size(735, 453);
            this.gConsulta1.TabIndex = 250;
            this.gConsulta1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.LI_CODIGOVIEJO,
            this.LI_BARRA,
            this.LI_DESC,
            this.LI_AUTOR,
            this.editorial,
            this.LI_PEDIDOS,
            this.LI_IDE,
            this.LI_CODIGOPROVEE});
            this.gridView1.GridControl = this.gConsulta1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Cantidad", null, "(Cantidad: Recuento={0})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // LI_CODIGOVIEJO
            // 
            this.LI_CODIGOVIEJO.Caption = "Código";
            this.LI_CODIGOVIEJO.FieldName = "LI_CODIGOVIEJO";
            this.LI_CODIGOVIEJO.MaxWidth = 80;
            this.LI_CODIGOVIEJO.MinWidth = 80;
            this.LI_CODIGOVIEJO.Name = "LI_CODIGOVIEJO";
            this.LI_CODIGOVIEJO.Visible = true;
            this.LI_CODIGOVIEJO.VisibleIndex = 0;
            this.LI_CODIGOVIEJO.Width = 80;
            // 
            // LI_BARRA
            // 
            this.LI_BARRA.Caption = "Barra";
            this.LI_BARRA.FieldName = "LI_BARRA";
            this.LI_BARRA.MaxWidth = 95;
            this.LI_BARRA.MinWidth = 95;
            this.LI_BARRA.Name = "LI_BARRA";
            this.LI_BARRA.Visible = true;
            this.LI_BARRA.VisibleIndex = 2;
            this.LI_BARRA.Width = 95;
            // 
            // LI_DESC
            // 
            this.LI_DESC.Caption = "Descripción";
            this.LI_DESC.FieldName = "LI_DESC";
            this.LI_DESC.MaxWidth = 250;
            this.LI_DESC.MinWidth = 250;
            this.LI_DESC.Name = "LI_DESC";
            this.LI_DESC.Visible = true;
            this.LI_DESC.VisibleIndex = 3;
            this.LI_DESC.Width = 250;
            // 
            // LI_AUTOR
            // 
            this.LI_AUTOR.Caption = "Autor";
            this.LI_AUTOR.FieldName = "LI_AUTOR";
            this.LI_AUTOR.MaxWidth = 80;
            this.LI_AUTOR.MinWidth = 80;
            this.LI_AUTOR.Name = "LI_AUTOR";
            this.LI_AUTOR.Visible = true;
            this.LI_AUTOR.VisibleIndex = 4;
            this.LI_AUTOR.Width = 80;
            // 
            // editorial
            // 
            this.editorial.Caption = "editorial";
            this.editorial.FieldName = "editorial";
            this.editorial.MaxWidth = 80;
            this.editorial.MinWidth = 80;
            this.editorial.Name = "editorial";
            this.editorial.Visible = true;
            this.editorial.VisibleIndex = 5;
            this.editorial.Width = 80;
            // 
            // LI_PEDIDOS
            // 
            this.LI_PEDIDOS.Caption = "Pedidos";
            this.LI_PEDIDOS.FieldName = "LI_PEDIDOS";
            this.LI_PEDIDOS.MaxWidth = 50;
            this.LI_PEDIDOS.MinWidth = 50;
            this.LI_PEDIDOS.Name = "LI_PEDIDOS";
            this.LI_PEDIDOS.Visible = true;
            this.LI_PEDIDOS.VisibleIndex = 6;
            this.LI_PEDIDOS.Width = 50;
            // 
            // LI_IDE
            // 
            this.LI_IDE.Caption = "LI_IDE";
            this.LI_IDE.FieldName = "LI_IDE";
            this.LI_IDE.Name = "LI_IDE";
            // 
            // LI_CODIGOPROVEE
            // 
            this.LI_CODIGOPROVEE.Caption = "Cód_Provee";
            this.LI_CODIGOPROVEE.FieldName = "LI_CODIGOPROVEE";
            this.LI_CODIGOPROVEE.MaxWidth = 80;
            this.LI_CODIGOPROVEE.MinWidth = 80;
            this.LI_CODIGOPROVEE.Name = "LI_CODIGOPROVEE";
            this.LI_CODIGOPROVEE.Visible = true;
            this.LI_CODIGOPROVEE.VisibleIndex = 1;
            this.LI_CODIGOPROVEE.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(258, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 17);
            this.label1.TabIndex = 251;
            this.label1.Text = "Pedidos por editorial seleccionada";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button3
            // 
            this.button3.Image = global::Presentacion.Properties.Resources.entrar48;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(44, 505);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 67);
            this.button3.TabIndex = 253;
            this.button3.Text = "Ver pedidos";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label6.Location = new System.Drawing.Point(12, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 17);
            this.label6.TabIndex = 254;
            this.label6.Text = "Editorial que poseen pedidos";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lUEproveedor
            // 
            this.lUEproveedor.Location = new System.Drawing.Point(308, 532);
            this.lUEproveedor.Name = "lUEproveedor";
            this.lUEproveedor.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.lUEproveedor.Properties.Appearance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lUEproveedor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUEproveedor.Properties.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lUEproveedor.Properties.Appearance.Options.UseBackColor = true;
            this.lUEproveedor.Properties.Appearance.Options.UseFont = true;
            this.lUEproveedor.Properties.Appearance.Options.UseForeColor = true;
            this.lUEproveedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lUEproveedor.Properties.DropDownRows = 5;
            this.lUEproveedor.Properties.HideSelection = false;
            this.lUEproveedor.Properties.NullText = "";
            this.lUEproveedor.Properties.ShowHeader = false;
            this.lUEproveedor.Size = new System.Drawing.Size(237, 22);
            this.lUEproveedor.TabIndex = 255;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label18.Location = new System.Drawing.Point(305, 512);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 17);
            this.label18.TabIndex = 256;
            this.label18.Text = "Proveedor:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rBlolasdb);
            this.groupBox2.Controls.Add(this.rBlibros);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(602, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 33);
            this.groupBox2.TabIndex = 257;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // rBlolasdb
            // 
            this.rBlolasdb.AutoSize = true;
            this.rBlolasdb.Checked = true;
            this.rBlolasdb.ForeColor = System.Drawing.Color.Maroon;
            this.rBlolasdb.Location = new System.Drawing.Point(87, 8);
            this.rBlolasdb.Name = "rBlolasdb";
            this.rBlolasdb.Size = new System.Drawing.Size(87, 18);
            this.rBlolasdb.TabIndex = 200;
            this.rBlolasdb.TabStop = true;
            this.rBlolasdb.Text = "Art. librería";
            this.rBlolasdb.UseVisualStyleBackColor = true;
            this.rBlolasdb.CheckedChanged += new System.EventHandler(this.rBlolasdb_CheckedChanged);
            // 
            // rBlibros
            // 
            this.rBlibros.AutoSize = true;
            this.rBlibros.ForeColor = System.Drawing.Color.Maroon;
            this.rBlibros.Location = new System.Drawing.Point(19, 8);
            this.rBlibros.Name = "rBlibros";
            this.rBlibros.Size = new System.Drawing.Size(61, 18);
            this.rBlibros.TabIndex = 199;
            this.rBlibros.Text = "Libros";
            this.rBlibros.UseVisualStyleBackColor = true;
            this.rBlibros.CheckedChanged += new System.EventHandler(this.rBlibros_CheckedChanged);
            // 
            // hacerpedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1003, 581);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lUEproveedor);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gConsulta1);
            this.Controls.Add(this.gConsulta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btneliminar);
            this.Name = "hacerpedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar el PEDIDO...";
            this.Load += new System.EventHandler(this.ConsultasConsignas_Load);
            this.cmdmenugrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUEproveedor.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.ContextMenuStrip cmdmenugrid;
        private System.Windows.Forms.ToolStripMenuItem exportarAExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarAPDFToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.SaveFileDialog sfdRuta;
        private System.Windows.Forms.SaveFileDialog sfdRuta1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private DevExpress.XtraGrid.Columns.GridColumn EDI_EDITORIAL;
        private DevExpress.XtraGrid.Columns.GridColumn EDI_CODIGO;
        private DevExpress.XtraGrid.GridControl gConsulta1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn LI_CODIGOVIEJO;
        private DevExpress.XtraGrid.Columns.GridColumn LI_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn LI_AUTOR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.Columns.GridColumn editorial;
        private DevExpress.XtraGrid.Columns.GridColumn LI_PEDIDOS;
        private DevExpress.XtraEditors.LookUpEdit lUEproveedor;
        private System.Windows.Forms.Label label18;
        private DevExpress.XtraGrid.Columns.GridColumn LI_IDE;
        private DevExpress.XtraGrid.Columns.GridColumn LI_BARRA;
        private DevExpress.XtraGrid.Columns.GridColumn LI_CODIGOPROVEE;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rBlolasdb;
        private System.Windows.Forms.RadioButton rBlibros;
    }
}