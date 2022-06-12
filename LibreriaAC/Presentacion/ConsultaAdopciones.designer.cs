namespace Presentacion
{
    partial class ConsultaAdopciones
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
            this.ado_ide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.esc_desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cur_desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ado_division = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tur_desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ado_cantialumnos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.turno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.loc_desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ado_esc_ide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ado_cur_ide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ado_div_ide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ado_tur_ide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ado_loc_ide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ado_obs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaltacliente = new System.Windows.Forms.Button();
            this.btnborrarusu = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LUanio = new DevExpress.XtraEditors.LookUpEdit();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUanio.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gConsulta
            // 
            this.gConsulta.Location = new System.Drawing.Point(18, 86);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(800, 292);
            this.gConsulta.TabIndex = 1;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            this.gConsulta.DoubleClick += new System.EventHandler(this.gConsulta_DoubleClick);
            // 
            // gridViewPintarFilas
            // 
            this.gridViewPintarFilas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ado_ide,
            this.esc_desc,
            this.cur_desc,
            this.ado_division,
            this.tur_desc,
            this.ado_cantialumnos,
            this.turno,
            this.loc_desc,
            this.ado_esc_ide,
            this.ado_cur_ide,
            this.ado_div_ide,
            this.ado_tur_ide,
            this.ado_loc_ide,
            this.ado_obs});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            // 
            // ado_ide
            // 
            this.ado_ide.Caption = "Ide";
            this.ado_ide.FieldName = "ado_ide";
            this.ado_ide.MaxWidth = 90;
            this.ado_ide.MinWidth = 90;
            this.ado_ide.Name = "ado_ide";
            this.ado_ide.Width = 90;
            // 
            // esc_desc
            // 
            this.esc_desc.Caption = "Escuela";
            this.esc_desc.FieldName = "esc_desc";
            this.esc_desc.Name = "esc_desc";
            this.esc_desc.Visible = true;
            this.esc_desc.VisibleIndex = 0;
            this.esc_desc.Width = 176;
            // 
            // cur_desc
            // 
            this.cur_desc.Caption = "Curso";
            this.cur_desc.FieldName = "cur_desc";
            this.cur_desc.Name = "cur_desc";
            this.cur_desc.Visible = true;
            this.cur_desc.VisibleIndex = 1;
            this.cur_desc.Width = 70;
            // 
            // ado_division
            // 
            this.ado_division.Caption = "División";
            this.ado_division.FieldName = "ado_division";
            this.ado_division.Name = "ado_division";
            this.ado_division.Visible = true;
            this.ado_division.VisibleIndex = 2;
            this.ado_division.Width = 30;
            // 
            // tur_desc
            // 
            this.tur_desc.Caption = "Turno";
            this.tur_desc.FieldName = "tur_desc";
            this.tur_desc.Name = "tur_desc";
            this.tur_desc.Visible = true;
            this.tur_desc.VisibleIndex = 3;
            this.tur_desc.Width = 41;
            // 
            // ado_cantialumnos
            // 
            this.ado_cantialumnos.Caption = "Can. Alumnos";
            this.ado_cantialumnos.FieldName = "ado_cantialumnos";
            this.ado_cantialumnos.Name = "ado_cantialumnos";
            this.ado_cantialumnos.Visible = true;
            this.ado_cantialumnos.VisibleIndex = 4;
            this.ado_cantialumnos.Width = 41;
            // 
            // turno
            // 
            this.turno.Caption = "turno";
            this.turno.FieldName = "turno";
            this.turno.Name = "turno";
            // 
            // loc_desc
            // 
            this.loc_desc.Caption = "ado_loc_ide";
            this.loc_desc.FieldName = "loc_desc";
            this.loc_desc.Name = "loc_desc";
            // 
            // ado_esc_ide
            // 
            this.ado_esc_ide.Caption = "ado_esc_ide";
            this.ado_esc_ide.FieldName = "ado_esc_ide";
            this.ado_esc_ide.Name = "ado_esc_ide";
            // 
            // ado_cur_ide
            // 
            this.ado_cur_ide.Caption = "ado_cur_ide";
            this.ado_cur_ide.FieldName = "ado_cur_ide";
            this.ado_cur_ide.Name = "ado_cur_ide";
            // 
            // ado_div_ide
            // 
            this.ado_div_ide.Caption = "ado_div_ide";
            this.ado_div_ide.FieldName = "ado_div_ide";
            this.ado_div_ide.Name = "ado_div_ide";
            // 
            // ado_tur_ide
            // 
            this.ado_tur_ide.Caption = "ado_tur_ide";
            this.ado_tur_ide.FieldName = "ado_tur_ide";
            this.ado_tur_ide.Name = "ado_tur_ide";
            // 
            // ado_loc_ide
            // 
            this.ado_loc_ide.Caption = "ado_loc_ide";
            this.ado_loc_ide.FieldName = "ado_loc_ide";
            this.ado_loc_ide.Name = "ado_loc_ide";
            // 
            // ado_obs
            // 
            this.ado_obs.Caption = "ado_obs";
            this.ado_obs.FieldName = "ado_obs";
            this.ado_obs.Name = "ado_obs";
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancelar32;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(745, 384);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(73, 59);
            this.btncancelar.TabIndex = 12;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaltacliente
            // 
            this.btnaltacliente.Enabled = false;
            this.btnaltacliente.Image = global::Presentacion.Properties.Resources.add32;
            this.btnaltacliente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnaltacliente.Location = new System.Drawing.Point(18, 8);
            this.btnaltacliente.Name = "btnaltacliente";
            this.btnaltacliente.Size = new System.Drawing.Size(58, 57);
            this.btnaltacliente.TabIndex = 193;
            this.btnaltacliente.Text = "Nuevo";
            this.btnaltacliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnaltacliente.UseVisualStyleBackColor = true;
            this.btnaltacliente.Click += new System.EventHandler(this.btnaltacliente_Click);
            // 
            // btnborrarusu
            // 
            this.btnborrarusu.Enabled = false;
            this.btnborrarusu.Image = global::Presentacion.Properties.Resources.delete32;
            this.btnborrarusu.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnborrarusu.Location = new System.Drawing.Point(173, 8);
            this.btnborrarusu.Name = "btnborrarusu";
            this.btnborrarusu.Size = new System.Drawing.Size(58, 57);
            this.btnborrarusu.TabIndex = 195;
            this.btnborrarusu.Text = "Eliminar";
            this.btnborrarusu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnborrarusu.UseVisualStyleBackColor = true;
            this.btnborrarusu.Click += new System.EventHandler(this.btnborrarusu_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Enabled = false;
            this.btnmodificar.Image = global::Presentacion.Properties.Resources.editar321;
            this.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmodificar.Location = new System.Drawing.Point(97, 8);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(58, 57);
            this.btnmodificar.TabIndex = 196;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(323, 29);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(244, 20);
            this.txttitulo.TabIndex = 197;
            this.txttitulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttitulo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 198;
            this.label1.Text = "Buscar:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LUanio
            // 
            this.LUanio.Location = new System.Drawing.Point(581, 28);
            this.LUanio.Name = "LUanio";
            this.LUanio.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.LUanio.Properties.Appearance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LUanio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUanio.Properties.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LUanio.Properties.Appearance.Options.UseBackColor = true;
            this.LUanio.Properties.Appearance.Options.UseFont = true;
            this.LUanio.Properties.Appearance.Options.UseForeColor = true;
            this.LUanio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUanio.Properties.DropDownRows = 5;
            this.LUanio.Properties.HideSelection = false;
            this.LUanio.Properties.NullText = "";
            this.LUanio.Properties.ShowHeader = false;
            this.LUanio.Size = new System.Drawing.Size(87, 22);
            this.LUanio.TabIndex = 229;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Image = global::Presentacion.Properties.Resources.escuela32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(703, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 57);
            this.button1.TabIndex = 230;
            this.button1.Text = "Escuelas";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConsultaAdopciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 443);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LUanio);
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnborrarusu);
            this.Controls.Add(this.btnaltacliente);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.gConsulta);
            this.Name = "ConsultaAdopciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adopciones";
            this.Load += new System.EventHandler(this.ConsultaInteres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUanio.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private DevExpress.XtraGrid.Columns.GridColumn ado_ide;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaltacliente;
        private DevExpress.XtraGrid.Columns.GridColumn esc_desc;
        private System.Windows.Forms.Button btnborrarusu;
        private System.Windows.Forms.Button btnmodificar;
        private DevExpress.XtraGrid.Columns.GridColumn cur_desc;
        private DevExpress.XtraGrid.Columns.GridColumn ado_division;
        private DevExpress.XtraGrid.Columns.GridColumn tur_desc;
        private DevExpress.XtraGrid.Columns.GridColumn ado_cantialumnos;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit LUanio;
        private DevExpress.XtraGrid.Columns.GridColumn turno;
        private DevExpress.XtraGrid.Columns.GridColumn loc_desc;
        private DevExpress.XtraGrid.Columns.GridColumn ado_esc_ide;
        private DevExpress.XtraGrid.Columns.GridColumn ado_cur_ide;
        private DevExpress.XtraGrid.Columns.GridColumn ado_div_ide;
        private DevExpress.XtraGrid.Columns.GridColumn ado_tur_ide;
        private DevExpress.XtraGrid.Columns.GridColumn ado_loc_ide;
        private DevExpress.XtraGrid.Columns.GridColumn ado_obs;
        private System.Windows.Forms.Button button1;
    }
}