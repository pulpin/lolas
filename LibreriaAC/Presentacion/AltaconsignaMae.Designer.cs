namespace Presentacion
{
    partial class AltaconsignaMae
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
            this.lUEditorial = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.dateEnvio = new DevExpress.XtraEditors.DateEdit();
            this.dateRecepcion = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtremito = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lUEditorial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnvio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnvio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecepcion.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecepcion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lUEditorial
            // 
            this.lUEditorial.Location = new System.Drawing.Point(42, 34);
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
            this.lUEditorial.Size = new System.Drawing.Size(327, 22);
            this.lUEditorial.TabIndex = 193;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(168, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 194;
            this.label3.Text = "Editorial:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancelar64;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(218, 300);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(73, 79);
            this.btncancelar.TabIndex = 203;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Image = global::Presentacion.Properties.Resources.guardar64;
            this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnagregar.Location = new System.Drawing.Point(125, 300);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(73, 79);
            this.btnagregar.TabIndex = 202;
            this.btnagregar.Text = "Guardar";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // dateEnvio
            // 
            this.dateEnvio.EditValue = null;
            this.dateEnvio.Location = new System.Drawing.Point(142, 100);
            this.dateEnvio.Name = "dateEnvio";
            this.dateEnvio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEnvio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEnvio.Size = new System.Drawing.Size(122, 20);
            this.dateEnvio.TabIndex = 204;
            // 
            // dateRecepcion
            // 
            this.dateRecepcion.EditValue = null;
            this.dateRecepcion.Location = new System.Drawing.Point(142, 164);
            this.dateRecepcion.Name = "dateRecepcion";
            this.dateRecepcion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateRecepcion.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateRecepcion.Size = new System.Drawing.Size(122, 20);
            this.dateRecepcion.TabIndex = 207;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(175, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 208;
            this.label1.Text = "Envío";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(157, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 209;
            this.label2.Text = "Recepción";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtremito
            // 
            this.txtremito.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtremito.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtremito.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtremito.Location = new System.Drawing.Point(110, 228);
            this.txtremito.Name = "txtremito";
            this.txtremito.Size = new System.Drawing.Size(184, 24);
            this.txtremito.TabIndex = 210;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Location = new System.Drawing.Point(171, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 211;
            this.label4.Text = "Remito";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AltaconsignaMae
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 395);
            this.ControlBox = false;
            this.Controls.Add(this.txtremito);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateRecepcion);
            this.Controls.Add(this.dateEnvio);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.lUEditorial);
            this.Controls.Add(this.label3);
            this.Name = "AltaconsignaMae";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta consigna";
            this.Load += new System.EventHandler(this.AltaconsignaMae_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lUEditorial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnvio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnvio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecepcion.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRecepcion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lUEditorial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnagregar;
        private DevExpress.XtraEditors.DateEdit dateEnvio;
        private DevExpress.XtraEditors.DateEdit dateRecepcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtremito;
        private System.Windows.Forms.Label label4;
    }
}