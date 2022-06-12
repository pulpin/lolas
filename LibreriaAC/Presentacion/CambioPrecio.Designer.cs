namespace Presentacion
{
    partial class CambioPrecio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambioPrecio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.gConsulta = new DevExpress.XtraGrid.GridControl();
            this.cmdmenugrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportarAExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarAPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewPintarFilas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sfdRuta1 = new System.Windows.Forms.SaveFileDialog();
            this.sfdRuta = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.ruta = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnabrir = new System.Windows.Forms.Button();
            this.btndiferencia = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chksinimportarpre = new System.Windows.Forms.CheckBox();
            this.chkprovee = new System.Windows.Forms.CheckBox();
            this.chbEditorial = new System.Windows.Forms.CheckBox();
            this.chbTitulo = new System.Windows.Forms.CheckBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rBlolasdb = new System.Windows.Forms.RadioButton();
            this.rBlibros = new System.Windows.Forms.RadioButton();
            this.btndescontinuados = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbprocesados = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lUEditorial = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.gconsulta2 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LI_CODIGOPROVEE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_CODIGOVIEJO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_COSTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_PRECIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            this.cmdmenugrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lUEditorial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gconsulta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancelar64;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(461, 482);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(97, 84);
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
            this.btnagregar.Location = new System.Drawing.Point(345, 482);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(97, 84);
            this.btnagregar.TabIndex = 202;
            this.btnagregar.Text = "Modificar precios";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // gConsulta
            // 
            this.gConsulta.ContextMenuStrip = this.cmdmenugrid;
            gridLevelNode1.RelationName = "Level1";
            this.gConsulta.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gConsulta.Location = new System.Drawing.Point(-212, -165);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(369, 159);
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
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Cantidad", null, "(Cantidad: Recuento={0})")});
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
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
            // ruta
            // 
            this.ruta.Location = new System.Drawing.Point(14, 16);
            this.ruta.Name = "ruta";
            this.ruta.Size = new System.Drawing.Size(146, 20);
            this.ruta.TabIndex = 237;
            this.ruta.Text = "c:\\PRECIOS\\prueba.xlsx";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(14, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 238;
            this.textBox2.Text = "Hoja1";
            this.textBox2.Visible = false;
            // 
            // button1
            // 
            this.button1.Image = global::Presentacion.Properties.Resources.execute32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(265, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 57);
            this.button1.TabIndex = 239;
            this.button1.Text = "Procesar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnabrir
            // 
            this.btnabrir.Location = new System.Drawing.Point(166, 16);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(93, 23);
            this.btnabrir.TabIndex = 240;
            this.btnabrir.Text = "Elegir archivo...";
            this.btnabrir.UseVisualStyleBackColor = true;
            this.btnabrir.Click += new System.EventHandler(this.btnabrir_Click);
            // 
            // btndiferencia
            // 
            this.btndiferencia.Image = global::Presentacion.Properties.Resources.diferenciapre64;
            this.btndiferencia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btndiferencia.Location = new System.Drawing.Point(227, 482);
            this.btndiferencia.Name = "btndiferencia";
            this.btndiferencia.Size = new System.Drawing.Size(97, 84);
            this.btndiferencia.TabIndex = 242;
            this.btndiferencia.Text = "Ver diferencias";
            this.btndiferencia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndiferencia.UseVisualStyleBackColor = true;
            this.btndiferencia.Visible = false;
            this.btndiferencia.Click += new System.EventHandler(this.btndiferencia_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(177, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(472, 304);
            this.pictureBox1.TabIndex = 243;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chksinimportarpre);
            this.groupBox1.Controls.Add(this.chkprovee);
            this.groupBox1.Controls.Add(this.chbEditorial);
            this.groupBox1.Controls.Add(this.chbTitulo);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(485, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 72);
            this.groupBox1.TabIndex = 242;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Otros items a modificar...";
            // 
            // chksinimportarpre
            // 
            this.chksinimportarpre.AutoSize = true;
            this.chksinimportarpre.ForeColor = System.Drawing.Color.Maroon;
            this.chksinimportarpre.Location = new System.Drawing.Point(137, 48);
            this.chksinimportarpre.Name = "chksinimportarpre";
            this.chksinimportarpre.Size = new System.Drawing.Size(132, 18);
            this.chksinimportarpre.TabIndex = 4;
            this.chksinimportarpre.Text = "Sin importar precio";
            this.chksinimportarpre.UseVisualStyleBackColor = true;
            // 
            // chkprovee
            // 
            this.chkprovee.AutoSize = true;
            this.chkprovee.Location = new System.Drawing.Point(6, 49);
            this.chkprovee.Name = "chkprovee";
            this.chkprovee.Size = new System.Drawing.Size(126, 18);
            this.chkprovee.TabIndex = 3;
            this.chkprovee.Text = "Código proveedor";
            this.chkprovee.UseVisualStyleBackColor = true;
            this.chkprovee.CheckedChanged += new System.EventHandler(this.chkprovee_CheckedChanged);
            // 
            // chbEditorial
            // 
            this.chbEditorial.AutoSize = true;
            this.chbEditorial.Location = new System.Drawing.Point(137, 24);
            this.chbEditorial.Name = "chbEditorial";
            this.chbEditorial.Size = new System.Drawing.Size(70, 18);
            this.chbEditorial.TabIndex = 2;
            this.chbEditorial.Text = "Editorial";
            this.chbEditorial.UseVisualStyleBackColor = true;
            // 
            // chbTitulo
            // 
            this.chbTitulo.AutoSize = true;
            this.chbTitulo.Location = new System.Drawing.Point(6, 25);
            this.chbTitulo.Name = "chbTitulo";
            this.chbTitulo.Size = new System.Drawing.Size(98, 18);
            this.chbTitulo.TabIndex = 0;
            this.chbTitulo.Text = "Titulo y autor";
            this.chbTitulo.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::Presentacion.Properties.Resources.eliminar32;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.Location = new System.Drawing.Point(11, 461);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(79, 43);
            this.btneliminar.TabIndex = 244;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rBlolasdb);
            this.groupBox2.Controls.Add(this.rBlibros);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(32, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 33);
            this.groupBox2.TabIndex = 242;
            this.groupBox2.TabStop = false;
            // 
            // rBlolasdb
            // 
            this.rBlolasdb.AutoSize = true;
            this.rBlolasdb.ForeColor = System.Drawing.Color.Maroon;
            this.rBlolasdb.Location = new System.Drawing.Point(86, 9);
            this.rBlolasdb.Name = "rBlolasdb";
            this.rBlolasdb.Size = new System.Drawing.Size(87, 18);
            this.rBlolasdb.TabIndex = 200;
            this.rBlolasdb.Text = "Art. librería";
            this.rBlolasdb.UseVisualStyleBackColor = true;
            this.rBlolasdb.CheckedChanged += new System.EventHandler(this.rBlolasdb_CheckedChanged);
            // 
            // rBlibros
            // 
            this.rBlibros.AutoSize = true;
            this.rBlibros.Checked = true;
            this.rBlibros.ForeColor = System.Drawing.Color.Maroon;
            this.rBlibros.Location = new System.Drawing.Point(19, 8);
            this.rBlibros.Name = "rBlibros";
            this.rBlibros.Size = new System.Drawing.Size(61, 18);
            this.rBlibros.TabIndex = 199;
            this.rBlibros.TabStop = true;
            this.rBlibros.Text = "Libros";
            this.rBlibros.UseVisualStyleBackColor = true;
            this.rBlibros.CheckedChanged += new System.EventHandler(this.rBlibros_CheckedChanged);
            // 
            // btndescontinuados
            // 
            this.btndescontinuados.Image = global::Presentacion.Properties.Resources.circulorojo30;
            this.btndescontinuados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndescontinuados.Location = new System.Drawing.Point(12, 510);
            this.btndescontinuados.Name = "btndescontinuados";
            this.btndescontinuados.Size = new System.Drawing.Size(124, 43);
            this.btndescontinuados.TabIndex = 245;
            this.btndescontinuados.Text = "Descontinuados";
            this.btndescontinuados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndescontinuados.UseVisualStyleBackColor = true;
            this.btndescontinuados.Visible = false;
            this.btndescontinuados.Click += new System.EventHandler(this.btndescontinuados_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(15, 158);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(608, 292);
            this.dgvProductos.TabIndex = 246;
            this.dgvProductos.DoubleClick += new System.EventHandler(this.dgvProductos_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbprocesados);
            this.groupBox3.Controls.Add(this.gConsulta);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(614, 461);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 53);
            this.groupBox3.TabIndex = 242;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Procesados";
            // 
            // lbprocesados
            // 
            this.lbprocesados.AutoSize = true;
            this.lbprocesados.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprocesados.ForeColor = System.Drawing.Color.Green;
            this.lbprocesados.Location = new System.Drawing.Point(58, 16);
            this.lbprocesados.Name = "lbprocesados";
            this.lbprocesados.Size = new System.Drawing.Size(26, 29);
            this.lbprocesados.TabIndex = 247;
            this.lbprocesados.Text = "0";
            // 
            // button2
            // 
            this.button2.Image = global::Presentacion.Properties.Resources.reservas24;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(633, 513);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 40);
            this.button2.TabIndex = 247;
            this.button2.Text = "Pausar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 150000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lUEditorial
            // 
            this.lUEditorial.Location = new System.Drawing.Point(98, 77);
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
            this.lUEditorial.Size = new System.Drawing.Size(294, 22);
            this.lUEditorial.TabIndex = 248;
            this.lUEditorial.EditValueChanged += new System.EventHandler(this.lUEditorial_EditValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 249;
            this.label3.Text = "Proveedor:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gconsulta2
            // 
            this.gconsulta2.ContextMenuStrip = this.cmdmenugrid;
            this.gconsulta2.Location = new System.Drawing.Point(32, 147);
            this.gconsulta2.MainView = this.gridView1;
            this.gconsulta2.Name = "gconsulta2";
            this.gconsulta2.Size = new System.Drawing.Size(733, 303);
            this.gconsulta2.TabIndex = 251;
            this.gconsulta2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gconsulta2.Visible = false;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.LI_CODIGOPROVEE,
            this.LI_CODIGOVIEJO,
            this.LI_DESC,
            this.LI_COSTO,
            this.LI_PRECIO});
            this.gridView1.GridControl = this.gconsulta2;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // LI_CODIGOPROVEE
            // 
            this.LI_CODIGOPROVEE.Caption = "Código";
            this.LI_CODIGOPROVEE.FieldName = "LI_CODIGOPROVEE";
            this.LI_CODIGOPROVEE.MaxWidth = 120;
            this.LI_CODIGOPROVEE.MinWidth = 120;
            this.LI_CODIGOPROVEE.Name = "LI_CODIGOPROVEE";
            this.LI_CODIGOPROVEE.Visible = true;
            this.LI_CODIGOPROVEE.VisibleIndex = 0;
            this.LI_CODIGOPROVEE.Width = 120;
            // 
            // LI_CODIGOVIEJO
            // 
            this.LI_CODIGOVIEJO.Caption = "Código_Interno";
            this.LI_CODIGOVIEJO.FieldName = "LI_CODIGOVIEJO";
            this.LI_CODIGOVIEJO.MaxWidth = 100;
            this.LI_CODIGOVIEJO.MinWidth = 100;
            this.LI_CODIGOVIEJO.Name = "LI_CODIGOVIEJO";
            this.LI_CODIGOVIEJO.Visible = true;
            this.LI_CODIGOVIEJO.VisibleIndex = 1;
            this.LI_CODIGOVIEJO.Width = 100;
            // 
            // LI_DESC
            // 
            this.LI_DESC.Caption = "Descripción";
            this.LI_DESC.FieldName = "LI_DESC";
            this.LI_DESC.MaxWidth = 300;
            this.LI_DESC.MinWidth = 300;
            this.LI_DESC.Name = "LI_DESC";
            this.LI_DESC.Visible = true;
            this.LI_DESC.VisibleIndex = 2;
            this.LI_DESC.Width = 300;
            // 
            // LI_COSTO
            // 
            this.LI_COSTO.Caption = "Costo";
            this.LI_COSTO.FieldName = "LI_COSTO";
            this.LI_COSTO.MaxWidth = 70;
            this.LI_COSTO.MinWidth = 70;
            this.LI_COSTO.Name = "LI_COSTO";
            this.LI_COSTO.Visible = true;
            this.LI_COSTO.VisibleIndex = 3;
            this.LI_COSTO.Width = 70;
            // 
            // LI_PRECIO
            // 
            this.LI_PRECIO.Caption = "Importe";
            this.LI_PRECIO.FieldName = "LI_PRECIO";
            this.LI_PRECIO.MaxWidth = 70;
            this.LI_PRECIO.MinWidth = 70;
            this.LI_PRECIO.Name = "LI_PRECIO";
            this.LI_PRECIO.Visible = true;
            this.LI_PRECIO.VisibleIndex = 4;
            this.LI_PRECIO.Width = 70;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(166, 477);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 71);
            this.button3.TabIndex = 252;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox4.Location = new System.Drawing.Point(15, 105);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(287, 36);
            this.groupBox4.TabIndex = 243;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Formato del archivo excel...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Khaki;
            this.label7.Location = new System.Drawing.Point(217, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 14);
            this.label7.TabIndex = 5;
            this.label7.Text = "proveedor";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Khaki;
            this.label6.Location = new System.Drawing.Point(135, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 14);
            this.label6.TabIndex = 4;
            this.label6.Text = "edi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Khaki;
            this.label5.Location = new System.Drawing.Point(167, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 14);
            this.label5.TabIndex = 3;
            this.label5.Text = "precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Khaki;
            this.label4.Location = new System.Drawing.Point(91, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(48, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "titulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "isbn";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox5.Location = new System.Drawing.Point(308, 105);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(323, 36);
            this.groupBox5.TabIndex = 244;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Formato del archivo excel...";
            this.groupBox5.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Moccasin;
            this.label12.Location = new System.Drawing.Point(239, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 14);
            this.label12.TabIndex = 4;
            this.label12.Text = "precionuevo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Moccasin;
            this.label8.Location = new System.Drawing.Point(187, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 14);
            this.label8.TabIndex = 3;
            this.label8.Text = "precio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Moccasin;
            this.label9.Location = new System.Drawing.Point(118, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 14);
            this.label9.TabIndex = 2;
            this.label9.Text = "modificar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Moccasin;
            this.label10.Location = new System.Drawing.Point(70, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 14);
            this.label10.TabIndex = 1;
            this.label10.Text = "costo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Moccasin;
            this.label11.Location = new System.Drawing.Point(16, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 14);
            this.label11.TabIndex = 0;
            this.label11.Text = "codigo";
            // 
            // CambioPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 577);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gconsulta2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lUEditorial);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btndescontinuados);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btndiferencia);
            this.Controls.Add(this.btnabrir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ruta);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Name = "CambioPrecio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio de precios...";
            this.Load += new System.EventHandler(this.AltaconsignaMae_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            this.cmdmenugrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lUEditorial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gconsulta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnagregar;
        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private System.Windows.Forms.ContextMenuStrip cmdmenugrid;
        private System.Windows.Forms.ToolStripMenuItem exportarAExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarAPDFToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfdRuta1;
        private System.Windows.Forms.SaveFileDialog sfdRuta;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.TextBox ruta;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnabrir;
        private System.Windows.Forms.Button btndiferencia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbEditorial;
        private System.Windows.Forms.CheckBox chbTitulo;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rBlolasdb;
        private System.Windows.Forms.RadioButton rBlibros;
        private System.Windows.Forms.Button btndescontinuados;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbprocesados;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.LookUpEdit lUEditorial;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl gconsulta2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn LI_CODIGOPROVEE;
        private DevExpress.XtraGrid.Columns.GridColumn LI_CODIGOVIEJO;
        private DevExpress.XtraGrid.Columns.GridColumn LI_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn LI_COSTO;
        private DevExpress.XtraGrid.Columns.GridColumn LI_PRECIO;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkprovee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chksinimportarpre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
    }
}