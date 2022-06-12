namespace Presentacion
{
    partial class ArqueodeCaja
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
            this.descrip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btneliminar = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.sfdRuta = new System.Windows.Forms.SaveFileDialog();
            this.sfdRuta1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.fechadesde = new DevExpress.XtraEditors.DateEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chbTitulo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LUpunto = new DevExpress.XtraEditors.LookUpEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.LUusuarios = new DevExpress.XtraEditors.LookUpEdit();
            this.gBtipopro = new System.Windows.Forms.GroupBox();
            this.txtdinerocaja = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtajustes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttotalventas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttarjeta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtefectivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttotalencaja = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txttarjetascaja = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtingresototal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtdiferencia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            this.cmdmenugrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechadesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechadesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUpunto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUusuarios.Properties)).BeginInit();
            this.gBtipopro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancelar64;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(531, 555);
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
            this.gConsulta.Location = new System.Drawing.Point(548, 56);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(310, 102);
            this.gConsulta.TabIndex = 195;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            this.gConsulta.Visible = false;
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
            this.descrip,
            this.total});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total", this.total, "")});
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            // 
            // descrip
            // 
            this.descrip.Caption = "descrip";
            this.descrip.FieldName = "descrip";
            this.descrip.MaxWidth = 300;
            this.descrip.MinWidth = 300;
            this.descrip.Name = "descrip";
            this.descrip.Visible = true;
            this.descrip.VisibleIndex = 0;
            this.descrip.Width = 300;
            // 
            // total
            // 
            this.total.Caption = "total";
            this.total.FieldName = "total";
            this.total.Name = "total";
            this.total.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total", "{0:#.##}")});
            this.total.Visible = true;
            this.total.VisibleIndex = 1;
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::Presentacion.Properties.Resources.Impresora64;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneliminar.Location = new System.Drawing.Point(385, 555);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(102, 87);
            this.btneliminar.TabIndex = 200;
            this.btneliminar.Text = "Imprimir";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(612, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 206;
            this.label2.Text = "Fecha:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fechadesde
            // 
            this.fechadesde.EditValue = null;
            this.fechadesde.Location = new System.Drawing.Point(665, 18);
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
            this.button1.Image = global::Presentacion.Properties.Resources.cobrar48;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(304, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 70);
            this.button1.TabIndex = 246;
            this.button1.Text = "Arqueo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Presentacion.Properties.Resources.salir48;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(435, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 70);
            this.button2.TabIndex = 245;
            this.button2.Text = "Salir";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // chbTitulo
            // 
            this.chbTitulo.AutoSize = true;
            this.chbTitulo.Checked = true;
            this.chbTitulo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTitulo.Location = new System.Drawing.Point(548, 19);
            this.chbTitulo.Name = "chbTitulo";
            this.chbTitulo.Size = new System.Drawing.Size(56, 17);
            this.chbTitulo.TabIndex = 244;
            this.chbTitulo.Text = "Todos";
            this.chbTitulo.UseVisualStyleBackColor = true;
            this.chbTitulo.CheckedChanged += new System.EventHandler(this.chbTitulo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(305, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 243;
            this.label1.Text = "Usuarios:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LUpunto
            // 
            this.LUpunto.Location = new System.Drawing.Point(134, 13);
            this.LUpunto.Name = "LUpunto";
            this.LUpunto.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.LUpunto.Properties.Appearance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LUpunto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUpunto.Properties.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LUpunto.Properties.Appearance.Options.UseBackColor = true;
            this.LUpunto.Properties.Appearance.Options.UseFont = true;
            this.LUpunto.Properties.Appearance.Options.UseForeColor = true;
            this.LUpunto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUpunto.Properties.DropDownRows = 5;
            this.LUpunto.Properties.HideSelection = false;
            this.LUpunto.Properties.NullText = "";
            this.LUpunto.Properties.ShowHeader = false;
            this.LUpunto.Size = new System.Drawing.Size(159, 22);
            this.LUpunto.TabIndex = 240;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Location = new System.Drawing.Point(16, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 241;
            this.label4.Text = "Punto de venta:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LUusuarios
            // 
            this.LUusuarios.Enabled = false;
            this.LUusuarios.Location = new System.Drawing.Point(374, 16);
            this.LUusuarios.Name = "LUusuarios";
            this.LUusuarios.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.LUusuarios.Properties.Appearance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LUusuarios.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUusuarios.Properties.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LUusuarios.Properties.Appearance.Options.UseBackColor = true;
            this.LUusuarios.Properties.Appearance.Options.UseFont = true;
            this.LUusuarios.Properties.Appearance.Options.UseForeColor = true;
            this.LUusuarios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUusuarios.Properties.DropDownRows = 5;
            this.LUusuarios.Properties.HideSelection = false;
            this.LUusuarios.Properties.NullText = "";
            this.LUusuarios.Properties.ShowHeader = false;
            this.LUusuarios.Size = new System.Drawing.Size(159, 22);
            this.LUusuarios.TabIndex = 248;
            // 
            // gBtipopro
            // 
            this.gBtipopro.Controls.Add(this.txtdinerocaja);
            this.gBtipopro.Controls.Add(this.label12);
            this.gBtipopro.Location = new System.Drawing.Point(77, 145);
            this.gBtipopro.Name = "gBtipopro";
            this.gBtipopro.Size = new System.Drawing.Size(703, 53);
            this.gBtipopro.TabIndex = 252;
            this.gBtipopro.TabStop = false;
            this.gBtipopro.Text = "Dinero entregado en la caja";
            // 
            // txtdinerocaja
            // 
            this.txtdinerocaja.BackColor = System.Drawing.Color.Cornsilk;
            this.txtdinerocaja.Enabled = false;
            this.txtdinerocaja.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdinerocaja.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtdinerocaja.Location = new System.Drawing.Point(139, 19);
            this.txtdinerocaja.Name = "txtdinerocaja";
            this.txtdinerocaja.Size = new System.Drawing.Size(129, 27);
            this.txtdinerocaja.TabIndex = 221;
            this.txtdinerocaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Ivory;
            this.label12.Location = new System.Drawing.Point(4, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 17);
            this.label12.TabIndex = 222;
            this.label12.Text = "Dinero entregado:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtajustes);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txttotalventas);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txttarjeta);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtefectivo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(77, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 111);
            this.groupBox1.TabIndex = 253;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ventas realizadas en el día y ajustes de caja";
            // 
            // txtajustes
            // 
            this.txtajustes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtajustes.Enabled = false;
            this.txtajustes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtajustes.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtajustes.Location = new System.Drawing.Point(584, 19);
            this.txtajustes.Name = "txtajustes";
            this.txtajustes.Size = new System.Drawing.Size(113, 27);
            this.txtajustes.TabIndex = 227;
            this.txtajustes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Ivory;
            this.label6.Location = new System.Drawing.Point(474, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 228;
            this.label6.Text = "Total Ajustes:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txttotalventas
            // 
            this.txttotalventas.BackColor = System.Drawing.Color.Moccasin;
            this.txttotalventas.Enabled = false;
            this.txttotalventas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalventas.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txttotalventas.Location = new System.Drawing.Point(322, 66);
            this.txttotalventas.Name = "txttotalventas";
            this.txttotalventas.Size = new System.Drawing.Size(153, 27);
            this.txttotalventas.TabIndex = 225;
            this.txttotalventas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Ivory;
            this.label8.Location = new System.Drawing.Point(268, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 226;
            this.label8.Text = "Total:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txttarjeta
            // 
            this.txttarjeta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txttarjeta.Enabled = false;
            this.txttarjeta.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttarjeta.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txttarjeta.Location = new System.Drawing.Point(362, 19);
            this.txttarjeta.Name = "txttarjeta";
            this.txttarjeta.Size = new System.Drawing.Size(113, 27);
            this.txttarjeta.TabIndex = 223;
            this.txttarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Ivory;
            this.label7.Location = new System.Drawing.Point(260, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 224;
            this.label7.Text = "Total Tarjeta:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtefectivo
            // 
            this.txtefectivo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtefectivo.Enabled = false;
            this.txtefectivo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtefectivo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtefectivo.Location = new System.Drawing.Point(141, 19);
            this.txtefectivo.Name = "txtefectivo";
            this.txtefectivo.Size = new System.Drawing.Size(113, 27);
            this.txtefectivo.TabIndex = 221;
            this.txtefectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Ivory;
            this.label3.Location = new System.Drawing.Point(31, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 222;
            this.label3.Text = "Total Efectivo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txttotalencaja);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txttarjetascaja);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtingresototal);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(77, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(703, 112);
            this.groupBox2.TabIndex = 254;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "En la caja";
            // 
            // txttotalencaja
            // 
            this.txttotalencaja.BackColor = System.Drawing.Color.Moccasin;
            this.txttotalencaja.Enabled = false;
            this.txttotalencaja.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalencaja.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txttotalencaja.Location = new System.Drawing.Point(322, 68);
            this.txttotalencaja.Name = "txttotalencaja";
            this.txttotalencaja.Size = new System.Drawing.Size(153, 27);
            this.txttotalencaja.TabIndex = 225;
            this.txttotalencaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Ivory;
            this.label11.Location = new System.Drawing.Point(266, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 226;
            this.label11.Text = "Total:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txttarjetascaja
            // 
            this.txttarjetascaja.BackColor = System.Drawing.Color.Honeydew;
            this.txttarjetascaja.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttarjetascaja.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txttarjetascaja.Location = new System.Drawing.Point(355, 20);
            this.txttarjetascaja.Name = "txttarjetascaja";
            this.txttarjetascaja.Size = new System.Drawing.Size(113, 27);
            this.txttarjetascaja.TabIndex = 223;
            this.txttarjetascaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Ivory;
            this.label9.Location = new System.Drawing.Point(282, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 224;
            this.label9.Text = "Tarjetas:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtingresototal
            // 
            this.txtingresototal.BackColor = System.Drawing.Color.Honeydew;
            this.txtingresototal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtingresototal.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtingresototal.Location = new System.Drawing.Point(141, 19);
            this.txtingresototal.Name = "txtingresototal";
            this.txtingresototal.Size = new System.Drawing.Size(113, 27);
            this.txtingresototal.TabIndex = 0;
            this.txtingresototal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Ivory;
            this.label10.Location = new System.Drawing.Point(27, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 17);
            this.label10.TabIndex = 222;
            this.label10.Text = "Dinero en caja:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtdiferencia);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(77, 473);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(703, 72);
            this.groupBox3.TabIndex = 255;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DIFERENCIA (ingreso total menos total de ventas)";
            // 
            // txtdiferencia
            // 
            this.txtdiferencia.BackColor = System.Drawing.Color.Cornsilk;
            this.txtdiferencia.Enabled = false;
            this.txtdiferencia.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiferencia.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtdiferencia.Location = new System.Drawing.Point(139, 23);
            this.txtdiferencia.Name = "txtdiferencia";
            this.txtdiferencia.Size = new System.Drawing.Size(175, 36);
            this.txtdiferencia.TabIndex = 221;
            this.txtdiferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Ivory;
            this.label5.Location = new System.Drawing.Point(54, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 222;
            this.label5.Text = "Diferencia:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::Presentacion.Properties.Resources.generar64;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(243, 555);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 87);
            this.btnGuardar.TabIndex = 256;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.button3_Click);
            // 
            // ArqueodeCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(875, 654);
            this.ControlBox = false;
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBtipopro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fechadesde);
            this.Controls.Add(this.LUusuarios);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chbTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LUpunto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.gConsulta);
            this.Name = "ArqueodeCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arqueo de caja...";
            this.Load += new System.EventHandler(this.ConsultasConsignas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            this.cmdmenugrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechadesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechadesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUpunto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUusuarios.Properties)).EndInit();
            this.gBtipopro.ResumeLayout(false);
            this.gBtipopro.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncancelar;
        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private DevExpress.XtraGrid.Columns.GridColumn descrip;
        private System.Windows.Forms.Button btneliminar;
        private DevExpress.XtraGrid.Columns.GridColumn total;
        private System.Windows.Forms.ContextMenuStrip cmdmenugrid;
        private System.Windows.Forms.ToolStripMenuItem exportarAExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarAPDFToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.SaveFileDialog sfdRuta;
        private System.Windows.Forms.SaveFileDialog sfdRuta1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit fechadesde;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chbTitulo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit LUpunto;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.LookUpEdit LUusuarios;
        private System.Windows.Forms.GroupBox gBtipopro;
        private System.Windows.Forms.TextBox txtdinerocaja;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttotalventas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttarjeta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtefectivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtingresototal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtdiferencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtajustes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txttarjetascaja;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txttotalencaja;
        private System.Windows.Forms.Label label11;
    }
}