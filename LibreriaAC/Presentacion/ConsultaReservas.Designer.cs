namespace Presentacion
{
    partial class ConsultaReservas
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
            this.gConsulta = new DevExpress.XtraGrid.GridControl();
            this.gridViewPintarFilas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CLIEN_NOMBRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CLIEN_TELEFONO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_LI_CODIGOVIEJO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_AUTOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_EDITORIAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_PRECIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_CANTIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_FECHA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cargado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.paraavisar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Avisado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Entregado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_ESTADO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_CLIE_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Alaventa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_USUV_FE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_OBS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_USUP_FE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.usumodificar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_USUM_FE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_USUL_FE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_USUE_FE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.usualta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_USUA_FE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnparaavisar = new System.Windows.Forms.Button();
            this.btnavisado = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnalaventa = new System.Windows.Forms.Button();
            this.btntodos = new System.Windows.Forms.Button();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlibro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbmarcar = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            this.gbmarcar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gConsulta
            // 
            this.gConsulta.Location = new System.Drawing.Point(12, 81);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(960, 332);
            this.gConsulta.TabIndex = 1;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            this.gConsulta.DoubleClick += new System.EventHandler(this.gConsulta_DoubleClick);
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
            this.CLIEN_NOMBRE,
            this.CLIEN_TELEFONO,
            this.RESE_LI_CODIGOVIEJO,
            this.RESE_DESC,
            this.RESE_AUTOR,
            this.RESE_EDITORIAL,
            this.RESE_PRECIO,
            this.RESE_CANTIDAD,
            this.RESE_FECHA,
            this.RESE_IDE,
            this.Cargado,
            this.paraavisar,
            this.Avisado,
            this.Entregado,
            this.RESE_ESTADO,
            this.RESE_CLIE_IDE,
            this.Alaventa,
            this.RESE_USUV_FE,
            this.RESE_OBS,
            this.RESE_USUP_FE,
            this.usumodificar,
            this.RESE_USUM_FE,
            this.RESE_USUL_FE,
            this.RESE_USUE_FE,
            this.usualta,
            this.RESE_USUA_FE});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            this.gridViewPintarFilas.RowStyle += gridViewPintarFilas_RowStyle;
            // 
            // CLIEN_NOMBRE
            // 
            this.CLIEN_NOMBRE.Caption = "Cliente";
            this.CLIEN_NOMBRE.FieldName = "CLIEN_NOMBRE";
            this.CLIEN_NOMBRE.MaxWidth = 150;
            this.CLIEN_NOMBRE.MinWidth = 150;
            this.CLIEN_NOMBRE.Name = "CLIEN_NOMBRE";
            this.CLIEN_NOMBRE.Visible = true;
            this.CLIEN_NOMBRE.VisibleIndex = 0;
            this.CLIEN_NOMBRE.Width = 150;
            // 
            // CLIEN_TELEFONO
            // 
            this.CLIEN_TELEFONO.Caption = "Teléfono";
            this.CLIEN_TELEFONO.FieldName = "CLIEN_TELEFONO";
            this.CLIEN_TELEFONO.MaxWidth = 85;
            this.CLIEN_TELEFONO.MinWidth = 85;
            this.CLIEN_TELEFONO.Name = "CLIEN_TELEFONO";
            this.CLIEN_TELEFONO.Visible = true;
            this.CLIEN_TELEFONO.VisibleIndex = 9;
            this.CLIEN_TELEFONO.Width = 85;
            // 
            // RESE_LI_CODIGOVIEJO
            // 
            this.RESE_LI_CODIGOVIEJO.Caption = "Código";
            this.RESE_LI_CODIGOVIEJO.FieldName = "RESE_LI_CODIGOVIEJO";
            this.RESE_LI_CODIGOVIEJO.MaxWidth = 60;
            this.RESE_LI_CODIGOVIEJO.MinWidth = 60;
            this.RESE_LI_CODIGOVIEJO.Name = "RESE_LI_CODIGOVIEJO";
            this.RESE_LI_CODIGOVIEJO.Visible = true;
            this.RESE_LI_CODIGOVIEJO.VisibleIndex = 1;
            this.RESE_LI_CODIGOVIEJO.Width = 60;
            // 
            // RESE_DESC
            // 
            this.RESE_DESC.Caption = "Descripción";
            this.RESE_DESC.FieldName = "RESE_DESC";
            this.RESE_DESC.MaxWidth = 200;
            this.RESE_DESC.MinWidth = 200;
            this.RESE_DESC.Name = "RESE_DESC";
            this.RESE_DESC.Visible = true;
            this.RESE_DESC.VisibleIndex = 2;
            this.RESE_DESC.Width = 200;
            // 
            // RESE_AUTOR
            // 
            this.RESE_AUTOR.Caption = "Autor";
            this.RESE_AUTOR.FieldName = "RESE_AUTOR";
            this.RESE_AUTOR.MaxWidth = 80;
            this.RESE_AUTOR.MinWidth = 80;
            this.RESE_AUTOR.Name = "RESE_AUTOR";
            this.RESE_AUTOR.Visible = true;
            this.RESE_AUTOR.VisibleIndex = 3;
            this.RESE_AUTOR.Width = 80;
            // 
            // RESE_EDITORIAL
            // 
            this.RESE_EDITORIAL.Caption = "Editorial";
            this.RESE_EDITORIAL.FieldName = "RESE_EDITORIAL";
            this.RESE_EDITORIAL.MaxWidth = 85;
            this.RESE_EDITORIAL.MinWidth = 85;
            this.RESE_EDITORIAL.Name = "RESE_EDITORIAL";
            this.RESE_EDITORIAL.Visible = true;
            this.RESE_EDITORIAL.VisibleIndex = 4;
            this.RESE_EDITORIAL.Width = 85;
            // 
            // RESE_PRECIO
            // 
            this.RESE_PRECIO.Caption = "Precio";
            this.RESE_PRECIO.FieldName = "RESE_PRECIO";
            this.RESE_PRECIO.MaxWidth = 45;
            this.RESE_PRECIO.MinWidth = 45;
            this.RESE_PRECIO.Name = "RESE_PRECIO";
            this.RESE_PRECIO.Visible = true;
            this.RESE_PRECIO.VisibleIndex = 5;
            this.RESE_PRECIO.Width = 45;
            // 
            // RESE_CANTIDAD
            // 
            this.RESE_CANTIDAD.Caption = "Cantidad";
            this.RESE_CANTIDAD.FieldName = "RESE_CANTIDAD";
            this.RESE_CANTIDAD.MaxWidth = 30;
            this.RESE_CANTIDAD.MinWidth = 30;
            this.RESE_CANTIDAD.Name = "RESE_CANTIDAD";
            this.RESE_CANTIDAD.Visible = true;
            this.RESE_CANTIDAD.VisibleIndex = 6;
            this.RESE_CANTIDAD.Width = 30;
            // 
            // RESE_FECHA
            // 
            this.RESE_FECHA.Caption = "Fecha";
            this.RESE_FECHA.FieldName = "RESE_FECHA";
            this.RESE_FECHA.MaxWidth = 70;
            this.RESE_FECHA.MinWidth = 70;
            this.RESE_FECHA.Name = "RESE_FECHA";
            this.RESE_FECHA.Visible = true;
            this.RESE_FECHA.VisibleIndex = 7;
            this.RESE_FECHA.Width = 70;
            // 
            // RESE_IDE
            // 
            this.RESE_IDE.Caption = "RESE_IDE";
            this.RESE_IDE.FieldName = "RESE_IDE";
            this.RESE_IDE.Name = "RESE_IDE";
            // 
            // Cargado
            // 
            this.Cargado.Caption = "Cargado";
            this.Cargado.FieldName = "Cargado";
            this.Cargado.Name = "Cargado";
            this.Cargado.Width = 20;
            // 
            // paraavisar
            // 
            this.paraavisar.Caption = "Para_avisar";
            this.paraavisar.FieldName = "paraavisar";
            this.paraavisar.Name = "paraavisar";
            this.paraavisar.Width = 20;
            // 
            // Avisado
            // 
            this.Avisado.Caption = "Avisado";
            this.Avisado.FieldName = "Avisado";
            this.Avisado.Name = "Avisado";
            this.Avisado.Width = 20;
            // 
            // Entregado
            // 
            this.Entregado.Caption = "Entregado";
            this.Entregado.FieldName = "Entregado";
            this.Entregado.Name = "Entregado";
            this.Entregado.Width = 20;
            // 
            // RESE_ESTADO
            // 
            this.RESE_ESTADO.Caption = "RESE_ESTADO";
            this.RESE_ESTADO.FieldName = "RESE_ESTADO";
            this.RESE_ESTADO.Name = "RESE_ESTADO";
            // 
            // RESE_CLIE_IDE
            // 
            this.RESE_CLIE_IDE.Caption = "RESE_CLIE_IDE";
            this.RESE_CLIE_IDE.FieldName = "RESE_CLIE_IDE";
            this.RESE_CLIE_IDE.Name = "RESE_CLIE_IDE";
            this.RESE_CLIE_IDE.Width = 20;
            // 
            // Alaventa
            // 
            this.Alaventa.Caption = "Alaventa";
            this.Alaventa.FieldName = "Alaventa";
            this.Alaventa.Name = "Alaventa";
            // 
            // RESE_USUV_FE
            // 
            this.RESE_USUV_FE.Caption = "RESE_USUV_FE";
            this.RESE_USUV_FE.FieldName = "RESE_USUV_FE";
            this.RESE_USUV_FE.Name = "RESE_USUV_FE";
            // 
            // RESE_OBS
            // 
            this.RESE_OBS.Caption = "RESE_OBS";
            this.RESE_OBS.FieldName = "RESE_OBS";
            this.RESE_OBS.MaxWidth = 100;
            this.RESE_OBS.MinWidth = 100;
            this.RESE_OBS.Name = "RESE_OBS";
            this.RESE_OBS.Visible = true;
            this.RESE_OBS.VisibleIndex = 8;
            this.RESE_OBS.Width = 100;
            // 
            // RESE_USUP_FE
            // 
            this.RESE_USUP_FE.Caption = "RESE_USUP_FE";
            this.RESE_USUP_FE.FieldName = "RESE_USUP_FE";
            this.RESE_USUP_FE.MaxWidth = 50;
            this.RESE_USUP_FE.MinWidth = 50;
            this.RESE_USUP_FE.Name = "RESE_USUP_FE";
            this.RESE_USUP_FE.Width = 50;
            // 
            // usumodificar
            // 
            this.usumodificar.Caption = "usumodificar";
            this.usumodificar.FieldName = "usumodificar";
            this.usumodificar.Name = "usumodificar";
            // 
            // RESE_USUM_FE
            // 
            this.RESE_USUM_FE.Caption = "RESE_USUM_FE";
            this.RESE_USUM_FE.FieldName = "RESE_USUM_FE";
            this.RESE_USUM_FE.Name = "RESE_USUM_FE";
            // 
            // RESE_USUL_FE
            // 
            this.RESE_USUL_FE.Caption = "RESE_USUL_FE";
            this.RESE_USUL_FE.FieldName = "RESE_USUL_FE";
            this.RESE_USUL_FE.Name = "RESE_USUL_FE";
            // 
            // RESE_USUE_FE
            // 
            this.RESE_USUE_FE.Caption = "RESE_USUE_FE";
            this.RESE_USUE_FE.FieldName = "RESE_USUE_FE";
            this.RESE_USUE_FE.Name = "RESE_USUE_FE";
            // 
            // usualta
            // 
            this.usualta.Caption = "usualta";
            this.usualta.FieldName = "usualta";
            this.usualta.Name = "usualta";
            // 
            // RESE_USUA_FE
            // 
            this.RESE_USUA_FE.Caption = "RESE_USUA_FE";
            this.RESE_USUA_FE.FieldName = "RESE_USUA_FE";
            this.RESE_USUA_FE.Name = "RESE_USUA_FE";
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.Cancel64;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(853, 435);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(102, 87);
            this.btncancelar.TabIndex = 12;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Enabled = false;
            this.btnmodificar.Image = global::Presentacion.Properties.Resources.editar641;
            this.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmodificar.Location = new System.Drawing.Point(513, 431);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(102, 87);
            this.btnmodificar.TabIndex = 11;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnparaavisar
            // 
            this.btnparaavisar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnparaavisar.Location = new System.Drawing.Point(163, 450);
            this.btnparaavisar.Name = "btnparaavisar";
            this.btnparaavisar.Size = new System.Drawing.Size(108, 21);
            this.btnparaavisar.TabIndex = 22;
            this.btnparaavisar.Text = "Para avisar";
            this.btnparaavisar.UseVisualStyleBackColor = false;
            this.btnparaavisar.Click += new System.EventHandler(this.btnparaavisar_Click);
            // 
            // btnavisado
            // 
            this.btnavisado.BackColor = System.Drawing.Color.SkyBlue;
            this.btnavisado.Location = new System.Drawing.Point(277, 450);
            this.btnavisado.Name = "btnavisado";
            this.btnavisado.Size = new System.Drawing.Size(108, 21);
            this.btnavisado.TabIndex = 23;
            this.btnavisado.Text = "Avisado";
            this.btnavisado.UseVisualStyleBackColor = false;
            this.btnavisado.Click += new System.EventHandler(this.btnavisado_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.Location = new System.Drawing.Point(49, 480);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 21);
            this.button4.TabIndex = 24;
            this.button4.Text = "Entregado";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnalaventa
            // 
            this.btnalaventa.BackColor = System.Drawing.Color.LightSalmon;
            this.btnalaventa.Location = new System.Drawing.Point(163, 480);
            this.btnalaventa.Name = "btnalaventa";
            this.btnalaventa.Size = new System.Drawing.Size(108, 21);
            this.btnalaventa.TabIndex = 25;
            this.btnalaventa.Text = "A la venta";
            this.btnalaventa.UseVisualStyleBackColor = false;
            this.btnalaventa.Click += new System.EventHandler(this.btnalaventa_Click);
            // 
            // btntodos
            // 
            this.btntodos.BackColor = System.Drawing.Color.White;
            this.btntodos.Location = new System.Drawing.Point(277, 482);
            this.btntodos.Name = "btntodos";
            this.btntodos.Size = new System.Drawing.Size(108, 21);
            this.btntodos.TabIndex = 26;
            this.btntodos.Text = "Todos";
            this.btntodos.UseVisualStyleBackColor = false;
            this.btntodos.Click += new System.EventHandler(this.btntodos_Click);
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(109, 12);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(140, 20);
            this.txttitulo.TabIndex = 253;
            this.txttitulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttitulo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 254;
            this.label2.Text = "Apellido y nombre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(319, 12);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(110, 20);
            this.txttelefono.TabIndex = 255;
            this.txttelefono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttelefono_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 256;
            this.label1.Text = "Teléfono:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtlibro
            // 
            this.txtlibro.Location = new System.Drawing.Point(500, 12);
            this.txtlibro.Name = "txtlibro";
            this.txtlibro.Size = new System.Drawing.Size(204, 20);
            this.txtlibro.TabIndex = 257;
            this.txtlibro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtlibro_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 258;
            this.label3.Text = "Título:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(49, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 21);
            this.button1.TabIndex = 259;
            this.button1.Text = "Cargados";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkKhaki;
            this.button2.Location = new System.Drawing.Point(391, 467);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 21);
            this.button2.TabIndex = 260;
            this.button2.Text = "Modificado";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gbmarcar
            // 
            this.gbmarcar.BackColor = System.Drawing.Color.SeaShell;
            this.gbmarcar.Controls.Add(this.btnAceptar);
            this.gbmarcar.Controls.Add(this.label4);
            this.gbmarcar.Controls.Add(this.txtcantidad);
            this.gbmarcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbmarcar.Location = new System.Drawing.Point(733, 8);
            this.gbmarcar.Name = "gbmarcar";
            this.gbmarcar.Size = new System.Drawing.Size(206, 65);
            this.gbmarcar.TabIndex = 261;
            this.gbmarcar.TabStop = false;
            this.gbmarcar.Text = "Marcar para avisar";
            this.gbmarcar.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptar.Location = new System.Drawing.Point(139, 22);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(56, 34);
            this.btnAceptar.TabIndex = 260;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 259;
            this.label4.Text = "Cantidad:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.ForeColor = System.Drawing.Color.Red;
            this.txtcantidad.Location = new System.Drawing.Point(74, 27);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(53, 26);
            this.txtcantidad.TabIndex = 258;
            this.txtcantidad.Text = "1";
            this.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConsultaReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 534);
            this.ControlBox = false;
            this.Controls.Add(this.gbmarcar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtlibro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btntodos);
            this.Controls.Add(this.btnalaventa);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnavisado);
            this.Controls.Add(this.btnparaavisar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.gConsulta);
            this.Name = "ConsultaReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Reservas";
            this.Load += new System.EventHandler(this.ConsultaInteres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            this.gbmarcar.ResumeLayout(false);
            this.gbmarcar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnmodificar;
        private DevExpress.XtraGrid.Columns.GridColumn CLIEN_NOMBRE;
        private DevExpress.XtraGrid.Columns.GridColumn CLIEN_TELEFONO;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_LI_CODIGOVIEJO;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_EDITORIAL;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_PRECIO;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_FECHA;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_IDE;
        private DevExpress.XtraGrid.Columns.GridColumn Cargado;
        private DevExpress.XtraGrid.Columns.GridColumn paraavisar;
        private DevExpress.XtraGrid.Columns.GridColumn Avisado;
        private DevExpress.XtraGrid.Columns.GridColumn Entregado;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_ESTADO;
        private System.Windows.Forms.Button btnparaavisar;
        private System.Windows.Forms.Button btnavisado;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnalaventa;
        private System.Windows.Forms.Button btntodos;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_AUTOR;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_CANTIDAD;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_CLIE_IDE;
        private DevExpress.XtraGrid.Columns.GridColumn Alaventa;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_USUV_FE;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_OBS;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_USUP_FE;
        private DevExpress.XtraGrid.Columns.GridColumn usumodificar;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_USUM_FE;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlibro;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_USUL_FE;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_USUE_FE;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.Columns.GridColumn usualta;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_USUA_FE;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbmarcar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcantidad;
    }
}