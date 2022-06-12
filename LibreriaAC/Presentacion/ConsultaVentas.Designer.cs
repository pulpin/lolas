namespace Presentacion
{
    partial class ConsultaVentas
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
            this.VEN_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_TIPOFACTU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_NROTICKET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_FECHA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_NOMBRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_TOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_ANULADO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TIP_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_PTOVTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnnotadecredito = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gBtipopro = new System.Windows.Forms.GroupBox();
            this.bbuscar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.LUpunto = new DevExpress.XtraEditors.LookUpEdit();
            this.txtticket = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnrofactu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fechahasta = new DevExpress.XtraEditors.DateEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.fechadesde = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            this.gBtipopro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUpunto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechahasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechahasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechadesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechadesde.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gConsulta
            // 
            this.gConsulta.Location = new System.Drawing.Point(29, 88);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(812, 315);
            this.gConsulta.TabIndex = 1;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            this.gConsulta.DoubleClick += new System.EventHandler(this.gConsulta_DoubleClick);
            // 
            // gridViewPintarFilas
            // 
            this.gridViewPintarFilas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.VEN_IDE,
            this.VEN_TIPOFACTU,
            this.VEN_NROTICKET,
            this.VEN_FECHA,
            this.VEN_NOMBRE,
            this.VEN_TOTAL,
            this.VEN_ANULADO,
            this.TIP_DESC,
            this.VEN_PTOVTA});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            this.gridViewPintarFilas.RowStyle += gridViewPintarFilas_RowStyle;
            // 
            // VEN_IDE
            // 
            this.VEN_IDE.Caption = "Factura";
            this.VEN_IDE.FieldName = "VEN_IDE";
            this.VEN_IDE.MaxWidth = 90;
            this.VEN_IDE.MinWidth = 90;
            this.VEN_IDE.Name = "VEN_IDE";
            this.VEN_IDE.Visible = true;
            this.VEN_IDE.VisibleIndex = 0;
            this.VEN_IDE.Width = 90;
            // 
            // VEN_TIPOFACTU
            // 
            this.VEN_TIPOFACTU.Caption = "Tipo";
            this.VEN_TIPOFACTU.FieldName = "VEN_TIPOFACTU";
            this.VEN_TIPOFACTU.Name = "VEN_TIPOFACTU";
            this.VEN_TIPOFACTU.Visible = true;
            this.VEN_TIPOFACTU.VisibleIndex = 1;
            // 
            // VEN_NROTICKET
            // 
            this.VEN_NROTICKET.Caption = "Tickets";
            this.VEN_NROTICKET.FieldName = "VEN_NROTICKET";
            this.VEN_NROTICKET.Name = "VEN_NROTICKET";
            this.VEN_NROTICKET.Visible = true;
            this.VEN_NROTICKET.VisibleIndex = 2;
            // 
            // VEN_FECHA
            // 
            this.VEN_FECHA.Caption = "Fecha";
            this.VEN_FECHA.FieldName = "VEN_FECHA";
            this.VEN_FECHA.Name = "VEN_FECHA";
            this.VEN_FECHA.Visible = true;
            this.VEN_FECHA.VisibleIndex = 3;
            // 
            // VEN_NOMBRE
            // 
            this.VEN_NOMBRE.Caption = "Cliente";
            this.VEN_NOMBRE.FieldName = "VEN_NOMBRE";
            this.VEN_NOMBRE.Name = "VEN_NOMBRE";
            this.VEN_NOMBRE.Visible = true;
            this.VEN_NOMBRE.VisibleIndex = 4;
            // 
            // VEN_TOTAL
            // 
            this.VEN_TOTAL.Caption = "Importe";
            this.VEN_TOTAL.FieldName = "VEN_TOTAL";
            this.VEN_TOTAL.Name = "VEN_TOTAL";
            this.VEN_TOTAL.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VEN_TOTAL", "TOTAL={0:#.##}")});
            this.VEN_TOTAL.Visible = true;
            this.VEN_TOTAL.VisibleIndex = 5;
            // 
            // VEN_ANULADO
            // 
            this.VEN_ANULADO.Caption = "VEN_ANULADO";
            this.VEN_ANULADO.FieldName = "VEN_ANULADO";
            this.VEN_ANULADO.Name = "VEN_ANULADO";
            // 
            // TIP_DESC
            // 
            this.TIP_DESC.Caption = "Tipo_pago";
            this.TIP_DESC.FieldName = "TIP_DESC";
            this.TIP_DESC.Name = "TIP_DESC";
            this.TIP_DESC.Visible = true;
            this.TIP_DESC.VisibleIndex = 6;
            // 
            // VEN_PTOVTA
            // 
            this.VEN_PTOVTA.Caption = "Punto";
            this.VEN_PTOVTA.FieldName = "VEN_PTOVTA";
            this.VEN_PTOVTA.MaxWidth = 30;
            this.VEN_PTOVTA.MinWidth = 30;
            this.VEN_PTOVTA.Name = "VEN_PTOVTA";
            this.VEN_PTOVTA.Visible = true;
            this.VEN_PTOVTA.VisibleIndex = 7;
            this.VEN_PTOVTA.Width = 30;
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancelar32;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(563, 410);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(104, 59);
            this.btncancelar.TabIndex = 12;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnnotadecredito
            // 
            this.btnnotadecredito.BackColor = System.Drawing.SystemColors.Control;
            this.btnnotadecredito.Image = global::Presentacion.Properties.Resources.agregarE322;
            this.btnnotadecredito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnotadecredito.Location = new System.Drawing.Point(200, 410);
            this.btnnotadecredito.Name = "btnnotadecredito";
            this.btnnotadecredito.Size = new System.Drawing.Size(104, 59);
            this.btnnotadecredito.TabIndex = 15;
            this.btnnotadecredito.Text = "Crear parcial";
            this.btnnotadecredito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnotadecredito.UseVisualStyleBackColor = false;
            this.btnnotadecredito.Click += new System.EventHandler(this.btnnotadecredito_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Image = global::Presentacion.Properties.Resources.ajuste32;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(321, 410);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 59);
            this.button3.TabIndex = 16;
            this.button3.Text = "Crear total";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(682, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nota de crédito PARCIAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(682, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nota de crédito TOTAL";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::Presentacion.Properties.Resources.buscar32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(442, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 59);
            this.button1.TabIndex = 19;
            this.button1.Text = "Ver nota de crédito";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gBtipopro
            // 
            this.gBtipopro.Controls.Add(this.bbuscar);
            this.gBtipopro.Controls.Add(this.label7);
            this.gBtipopro.Controls.Add(this.LUpunto);
            this.gBtipopro.Controls.Add(this.txtticket);
            this.gBtipopro.Controls.Add(this.label6);
            this.gBtipopro.Controls.Add(this.label5);
            this.gBtipopro.Controls.Add(this.txtnrofactu);
            this.gBtipopro.Controls.Add(this.label3);
            this.gBtipopro.Controls.Add(this.fechahasta);
            this.gBtipopro.Controls.Add(this.label4);
            this.gBtipopro.Controls.Add(this.fechadesde);
            this.gBtipopro.Location = new System.Drawing.Point(29, 1);
            this.gBtipopro.Name = "gBtipopro";
            this.gBtipopro.Size = new System.Drawing.Size(807, 82);
            this.gBtipopro.TabIndex = 248;
            this.gBtipopro.TabStop = false;
            this.gBtipopro.Text = "Seleccionar filtro";
            this.gBtipopro.Enter += new System.EventHandler(this.gBtipopro_Enter);
            // 
            // bbuscar
            // 
            this.bbuscar.Image = global::Presentacion.Properties.Resources.buscar32;
            this.bbuscar.Location = new System.Drawing.Point(741, 21);
            this.bbuscar.Name = "bbuscar";
            this.bbuscar.Size = new System.Drawing.Size(60, 39);
            this.bbuscar.TabIndex = 250;
            this.bbuscar.UseVisualStyleBackColor = true;
            this.bbuscar.Click += new System.EventHandler(this.bbuscar_Click);
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label7.Location = new System.Drawing.Point(401, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 254;
            this.label7.Text = "Ticket:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LUpunto
            // 
            this.LUpunto.Location = new System.Drawing.Point(130, 18);
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
            this.LUpunto.TabIndex = 253;
            // 
            // txtticket
            // 
            this.txtticket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtticket.ForeColor = System.Drawing.Color.Maroon;
            this.txtticket.Location = new System.Drawing.Point(458, 53);
            this.txtticket.Name = "txtticket";
            this.txtticket.Size = new System.Drawing.Size(66, 22);
            this.txtticket.TabIndex = 253;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label6.Location = new System.Drawing.Point(12, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 254;
            this.label6.Text = "Punto de venta:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label5.Location = new System.Drawing.Point(246, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 252;
            this.label5.Text = "Factura:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtnrofactu
            // 
            this.txtnrofactu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtnrofactu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnrofactu.ForeColor = System.Drawing.Color.Maroon;
            this.txtnrofactu.Location = new System.Drawing.Point(313, 53);
            this.txtnrofactu.Name = "txtnrofactu";
            this.txtnrofactu.Size = new System.Drawing.Size(74, 22);
            this.txtnrofactu.TabIndex = 251;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(516, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 208;
            this.label3.Text = "Fecha hasta:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fechahasta
            // 
            this.fechahasta.EditValue = null;
            this.fechahasta.Location = new System.Drawing.Point(618, 18);
            this.fechahasta.Name = "fechahasta";
            this.fechahasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fechahasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fechahasta.Size = new System.Drawing.Size(100, 20);
            this.fechahasta.TabIndex = 207;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Location = new System.Drawing.Point(305, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 206;
            this.label4.Text = "Fecha desde:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fechadesde
            // 
            this.fechadesde.EditValue = null;
            this.fechadesde.Location = new System.Drawing.Point(407, 18);
            this.fechadesde.Name = "fechadesde";
            this.fechadesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fechadesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fechadesde.Size = new System.Drawing.Size(100, 20);
            this.fechadesde.TabIndex = 205;
            // 
            // ConsultaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 474);
            this.ControlBox = false;
            this.Controls.Add(this.gBtipopro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnnotadecredito);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.gConsulta);
            this.Name = "ConsultaVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas...";
            this.Load += new System.EventHandler(this.ConsultaInteres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            this.gBtipopro.ResumeLayout(false);
            this.gBtipopro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUpunto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechahasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechahasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechadesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechadesde.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_IDE;
        private System.Windows.Forms.Button btncancelar;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_TIPOFACTU;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_NROTICKET;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_FECHA;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_NOMBRE;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_TOTAL;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_ANULADO;
        private System.Windows.Forms.Button btnnotadecredito;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gBtipopro;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit fechahasta;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.DateEdit fechadesde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnrofactu;
        private System.Windows.Forms.Button bbuscar;
        private DevExpress.XtraGrid.Columns.GridColumn TIP_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_PTOVTA;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.LookUpEdit LUpunto;
        private System.Windows.Forms.TextBox txtticket;
        private System.Windows.Forms.Label label6;
    }
}