﻿namespace Presentacion
{
    partial class ActualizaCatalogo
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
            this.gConsulta = new DevExpress.XtraGrid.GridControl();
            this.gridViewPintarFilas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LI_CODIGO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_AUTOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EDI_EDITORIAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GEN_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_PRECIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_STOCK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_PROPIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_ISBN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_IMAGEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_CUERPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_ESTANTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_FECHAPRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_EDI_CODIGO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_GEN_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_TIPOPRO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_COSTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_PORC_IVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_PORC_GANAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_BARRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.li_precioori = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_CODIGOPROVEE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_PEDIDOS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_PRECIOARTDI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_PRECIOAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_INVENTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LI_FEC_INVEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbmarcar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            this.SuspendLayout();
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
            // gConsulta
            // 
            this.gConsulta.Location = new System.Drawing.Point(12, 92);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(924, 274);
            this.gConsulta.TabIndex = 262;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            // 
            // gridViewPintarFilas
            // 
            this.gridViewPintarFilas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.LI_CODIGO,
            this.LI_DESC,
            this.LI_AUTOR,
            this.EDI_EDITORIAL,
            this.GEN_DESC,
            this.LI_PRECIO,
            this.LI_STOCK,
            this.LI_PROPIO,
            this.LI_ISBN,
            this.LI_IMAGEN,
            this.LI_CUERPO,
            this.LI_ESTANTE,
            this.LI_FECHAPRE,
            this.LI_EDI_CODIGO,
            this.LI_IDE,
            this.LI_GEN_IDE,
            this.LI_TIPOPRO,
            this.LI_COSTO,
            this.LI_PORC_IVA,
            this.LI_PORC_GANAN,
            this.LI_BARRA,
            this.li_precioori,
            this.LI_CODIGOPROVEE,
            this.LI_PEDIDOS,
            this.LI_PRECIOARTDI,
            this.LI_PRECIOAN,
            this.LI_INVENTA,
            this.LI_FEC_INVEN});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LI_CODIGO", this.LI_CODIGO, "")});
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            this.gridViewPintarFilas.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.LI_AUTOR, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // LI_CODIGO
            // 
            this.LI_CODIGO.Caption = "Código";
            this.LI_CODIGO.FieldName = "LI_CODIGO";
            this.LI_CODIGO.Name = "LI_CODIGO";
            this.LI_CODIGO.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "LI_CODIGO", "Productos={0:#.##}")});
            this.LI_CODIGO.Visible = true;
            this.LI_CODIGO.VisibleIndex = 0;
            // 
            // LI_DESC
            // 
            this.LI_DESC.Caption = "Descripción";
            this.LI_DESC.FieldName = "LI_DESC";
            this.LI_DESC.MaxWidth = 200;
            this.LI_DESC.MinWidth = 200;
            this.LI_DESC.Name = "LI_DESC";
            this.LI_DESC.Visible = true;
            this.LI_DESC.VisibleIndex = 1;
            this.LI_DESC.Width = 200;
            // 
            // LI_AUTOR
            // 
            this.LI_AUTOR.Caption = "Autor";
            this.LI_AUTOR.FieldName = "LI_AUTOR";
            this.LI_AUTOR.Name = "LI_AUTOR";
            this.LI_AUTOR.Visible = true;
            this.LI_AUTOR.VisibleIndex = 2;
            // 
            // EDI_EDITORIAL
            // 
            this.EDI_EDITORIAL.Caption = "EDITORIAL";
            this.EDI_EDITORIAL.FieldName = "EDI_EDITORIAL";
            this.EDI_EDITORIAL.Name = "EDI_EDITORIAL";
            this.EDI_EDITORIAL.Visible = true;
            this.EDI_EDITORIAL.VisibleIndex = 3;
            // 
            // GEN_DESC
            // 
            this.GEN_DESC.Caption = "GENERO";
            this.GEN_DESC.FieldName = "GEN_DESC";
            this.GEN_DESC.Name = "GEN_DESC";
            this.GEN_DESC.Visible = true;
            this.GEN_DESC.VisibleIndex = 4;
            // 
            // LI_PRECIO
            // 
            this.LI_PRECIO.AppearanceCell.Options.UseTextOptions = true;
            this.LI_PRECIO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LI_PRECIO.AppearanceHeader.Options.UseTextOptions = true;
            this.LI_PRECIO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LI_PRECIO.Caption = "Precio";
            this.LI_PRECIO.FieldName = "LI_PRECIO";
            this.LI_PRECIO.Name = "LI_PRECIO";
            this.LI_PRECIO.Visible = true;
            this.LI_PRECIO.VisibleIndex = 5;
            // 
            // LI_STOCK
            // 
            this.LI_STOCK.AppearanceCell.Options.UseTextOptions = true;
            this.LI_STOCK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LI_STOCK.AppearanceHeader.Options.UseTextOptions = true;
            this.LI_STOCK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LI_STOCK.Caption = "Stock";
            this.LI_STOCK.FieldName = "LI_STOCK";
            this.LI_STOCK.Name = "LI_STOCK";
            this.LI_STOCK.Visible = true;
            this.LI_STOCK.VisibleIndex = 6;
            // 
            // LI_PROPIO
            // 
            this.LI_PROPIO.AppearanceCell.Options.UseTextOptions = true;
            this.LI_PROPIO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LI_PROPIO.AppearanceHeader.Options.UseTextOptions = true;
            this.LI_PROPIO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LI_PROPIO.Caption = "Propios";
            this.LI_PROPIO.FieldName = "LI_PROPIO";
            this.LI_PROPIO.Name = "LI_PROPIO";
            this.LI_PROPIO.Visible = true;
            this.LI_PROPIO.VisibleIndex = 7;
            // 
            // LI_ISBN
            // 
            this.LI_ISBN.Caption = "Isbn";
            this.LI_ISBN.FieldName = "LI_ISBN";
            this.LI_ISBN.Name = "LI_ISBN";
            this.LI_ISBN.Visible = true;
            this.LI_ISBN.VisibleIndex = 8;
            // 
            // LI_IMAGEN
            // 
            this.LI_IMAGEN.Caption = "IMAGEN";
            this.LI_IMAGEN.FieldName = "LI_IMAGEN";
            this.LI_IMAGEN.Name = "LI_IMAGEN";
            // 
            // LI_CUERPO
            // 
            this.LI_CUERPO.Caption = "Cuerpo";
            this.LI_CUERPO.FieldName = "LI_CUERPO";
            this.LI_CUERPO.Name = "LI_CUERPO";
            // 
            // LI_ESTANTE
            // 
            this.LI_ESTANTE.Caption = "Estante";
            this.LI_ESTANTE.FieldName = "LI_ESTANTE";
            this.LI_ESTANTE.Name = "LI_ESTANTE";
            // 
            // LI_FECHAPRE
            // 
            this.LI_FECHAPRE.Caption = "Fechapres";
            this.LI_FECHAPRE.FieldName = "LI_FECHAPRE";
            this.LI_FECHAPRE.Name = "LI_FECHAPRE";
            // 
            // LI_EDI_CODIGO
            // 
            this.LI_EDI_CODIGO.Caption = "LI_EDI_CODIGO";
            this.LI_EDI_CODIGO.FieldName = "LI_EDI_CODIGO";
            this.LI_EDI_CODIGO.Name = "LI_EDI_CODIGO";
            // 
            // LI_IDE
            // 
            this.LI_IDE.Caption = "LI_IDE";
            this.LI_IDE.FieldName = "LI_IDE";
            this.LI_IDE.Name = "LI_IDE";
            // 
            // LI_GEN_IDE
            // 
            this.LI_GEN_IDE.Caption = "LI_GEN_IDE";
            this.LI_GEN_IDE.FieldName = "LI_GEN_IDE";
            this.LI_GEN_IDE.Name = "LI_GEN_IDE";
            // 
            // LI_TIPOPRO
            // 
            this.LI_TIPOPRO.Caption = "LI_TIPOPRO";
            this.LI_TIPOPRO.FieldName = "LI_TIPOPRO";
            this.LI_TIPOPRO.Name = "LI_TIPOPRO";
            // 
            // LI_COSTO
            // 
            this.LI_COSTO.Caption = "LI_COSTO";
            this.LI_COSTO.FieldName = "LI_COSTO";
            this.LI_COSTO.Name = "LI_COSTO";
            // 
            // LI_PORC_IVA
            // 
            this.LI_PORC_IVA.Caption = "LI_PORC_IVA";
            this.LI_PORC_IVA.FieldName = "LI_PORC_IVA";
            this.LI_PORC_IVA.Name = "LI_PORC_IVA";
            // 
            // LI_PORC_GANAN
            // 
            this.LI_PORC_GANAN.Caption = "LI_PORC_GANAN";
            this.LI_PORC_GANAN.FieldName = "LI_PORC_GANAN";
            this.LI_PORC_GANAN.Name = "LI_PORC_GANAN";
            // 
            // LI_BARRA
            // 
            this.LI_BARRA.Caption = "Barra";
            this.LI_BARRA.FieldName = "LI_BARRA";
            this.LI_BARRA.Name = "LI_BARRA";
            this.LI_BARRA.Visible = true;
            this.LI_BARRA.VisibleIndex = 9;
            // 
            // li_precioori
            // 
            this.li_precioori.Caption = "li_precioori";
            this.li_precioori.FieldName = "li_precioori";
            this.li_precioori.Name = "li_precioori";
            // 
            // LI_CODIGOPROVEE
            // 
            this.LI_CODIGOPROVEE.Caption = "LI_CODIGOPROVEE";
            this.LI_CODIGOPROVEE.FieldName = "LI_CODIGOPROVEE";
            this.LI_CODIGOPROVEE.Name = "LI_CODIGOPROVEE";
            // 
            // LI_PEDIDOS
            // 
            this.LI_PEDIDOS.Caption = "Pedidos";
            this.LI_PEDIDOS.FieldName = "LI_PEDIDOS";
            this.LI_PEDIDOS.Name = "LI_PEDIDOS";
            this.LI_PEDIDOS.Visible = true;
            this.LI_PEDIDOS.VisibleIndex = 10;
            // 
            // LI_PRECIOARTDI
            // 
            this.LI_PRECIOARTDI.Caption = "LI_PRECIOARTDI";
            this.LI_PRECIOARTDI.FieldName = "LI_PRECIOARTDI";
            this.LI_PRECIOARTDI.Name = "LI_PRECIOARTDI";
            // 
            // LI_PRECIOAN
            // 
            this.LI_PRECIOAN.Caption = "LI_PRECIOAN";
            this.LI_PRECIOAN.FieldName = "LI_PRECIOAN";
            this.LI_PRECIOAN.Name = "LI_PRECIOAN";
            // 
            // LI_INVENTA
            // 
            this.LI_INVENTA.Caption = "LI_INVENTA";
            this.LI_INVENTA.FieldName = "LI_INVENTA";
            this.LI_INVENTA.Name = "LI_INVENTA";
            // 
            // LI_FEC_INVEN
            // 
            this.LI_FEC_INVEN.Caption = "LI_FEC_INVEN";
            this.LI_FEC_INVEN.FieldName = "LI_FEC_INVEN";
            this.LI_FEC_INVEN.Name = "LI_FEC_INVEN";
            // 
            // ActualizaCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 534);
            this.ControlBox = false;
            this.Controls.Add(this.gConsulta);
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
            this.Name = "ActualizaCatalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Reservas";
            this.Load += new System.EventHandler(this.ConsultaInteres_Load);
            this.gbmarcar.ResumeLayout(false);
            this.gbmarcar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnparaavisar;
        private System.Windows.Forms.Button btnavisado;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnalaventa;
        private System.Windows.Forms.Button btntodos;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlibro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbmarcar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcantidad;
        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private DevExpress.XtraGrid.Columns.GridColumn LI_CODIGO;
        private DevExpress.XtraGrid.Columns.GridColumn LI_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn LI_AUTOR;
        private DevExpress.XtraGrid.Columns.GridColumn EDI_EDITORIAL;
        private DevExpress.XtraGrid.Columns.GridColumn GEN_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn LI_PRECIO;
        private DevExpress.XtraGrid.Columns.GridColumn LI_STOCK;
        private DevExpress.XtraGrid.Columns.GridColumn LI_PROPIO;
        private DevExpress.XtraGrid.Columns.GridColumn LI_ISBN;
        private DevExpress.XtraGrid.Columns.GridColumn LI_IMAGEN;
        private DevExpress.XtraGrid.Columns.GridColumn LI_CUERPO;
        private DevExpress.XtraGrid.Columns.GridColumn LI_ESTANTE;
        private DevExpress.XtraGrid.Columns.GridColumn LI_FECHAPRE;
        private DevExpress.XtraGrid.Columns.GridColumn LI_EDI_CODIGO;
        private DevExpress.XtraGrid.Columns.GridColumn LI_IDE;
        private DevExpress.XtraGrid.Columns.GridColumn LI_GEN_IDE;
        private DevExpress.XtraGrid.Columns.GridColumn LI_TIPOPRO;
        private DevExpress.XtraGrid.Columns.GridColumn LI_COSTO;
        private DevExpress.XtraGrid.Columns.GridColumn LI_PORC_IVA;
        private DevExpress.XtraGrid.Columns.GridColumn LI_PORC_GANAN;
        private DevExpress.XtraGrid.Columns.GridColumn LI_BARRA;
        private DevExpress.XtraGrid.Columns.GridColumn li_precioori;
        private DevExpress.XtraGrid.Columns.GridColumn LI_CODIGOPROVEE;
        private DevExpress.XtraGrid.Columns.GridColumn LI_PEDIDOS;
        private DevExpress.XtraGrid.Columns.GridColumn LI_PRECIOARTDI;
        private DevExpress.XtraGrid.Columns.GridColumn LI_PRECIOAN;
        private DevExpress.XtraGrid.Columns.GridColumn LI_INVENTA;
        private DevExpress.XtraGrid.Columns.GridColumn LI_FEC_INVEN;
    }
}