﻿namespace Presentacion
{
    partial class CambiarPorcentajePrecio
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
            this.btnaceptar = new System.Windows.Forms.Button();
            this.lUEditorial = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtporcentaje = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.chfechadesde = new DevExpress.XtraEditors.CheckEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.fechahasta = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lUEditorial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chfechadesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechahasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechahasta.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnaceptar
            // 
            this.btnaceptar.Image = global::Presentacion.Properties.Resources.guardar64;
            this.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnaceptar.Location = new System.Drawing.Point(70, 212);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(105, 79);
            this.btnaceptar.TabIndex = 11;
            this.btnaceptar.Text = "Guardar";
            this.btnaceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // lUEditorial
            // 
            this.lUEditorial.Location = new System.Drawing.Point(36, 42);
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
            this.lUEditorial.Size = new System.Drawing.Size(302, 22);
            this.lUEditorial.TabIndex = 193;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(155, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 194;
            this.label3.Text = "Editorial:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label16.Location = new System.Drawing.Point(257, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 17);
            this.label16.TabIndex = 215;
            this.label16.Text = "%";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtporcentaje
            // 
            this.txtporcentaje.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtporcentaje.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtporcentaje.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtporcentaje.Location = new System.Drawing.Point(192, 89);
            this.txtporcentaje.Name = "txtporcentaje";
            this.txtporcentaje.Size = new System.Drawing.Size(64, 24);
            this.txtporcentaje.TabIndex = 214;
            this.txtporcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label8.Location = new System.Drawing.Point(62, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 17);
            this.label8.TabIndex = 213;
            this.label8.Text = "Porcentaje Costo:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancelar64;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(199, 212);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(105, 79);
            this.btncancelar.TabIndex = 216;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // chfechadesde
            // 
            this.chfechadesde.Location = new System.Drawing.Point(69, 140);
            this.chfechadesde.Name = "chfechadesde";
            this.chfechadesde.Properties.Caption = "";
            this.chfechadesde.Size = new System.Drawing.Size(24, 20);
            this.chfechadesde.TabIndex = 252;
            this.chfechadesde.CheckedChanged += new System.EventHandler(this.chfechadesde_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(133, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 251;
            this.label1.Text = "Fecha:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Visible = false;
            // 
            // fechahasta
            // 
            this.fechahasta.EditValue = null;
            this.fechahasta.Location = new System.Drawing.Point(186, 164);
            this.fechahasta.Name = "fechahasta";
            this.fechahasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fechahasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fechahasta.Size = new System.Drawing.Size(100, 20);
            this.fechahasta.TabIndex = 250;
            this.fechahasta.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(86, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 17);
            this.label2.TabIndex = 253;
            this.label2.Text = "Sin actualización de precios hasta";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CambiarPorcentajePrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 298);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chfechadesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fechahasta);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtporcentaje);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lUEditorial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnaceptar);
            this.Name = "CambiarPorcentajePrecio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar el precio de costo y calcula el precio...";
            this.Load += new System.EventHandler(this.Elegirpto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lUEditorial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chfechadesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechahasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechahasta.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaceptar;
        private DevExpress.XtraEditors.LookUpEdit lUEditorial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtporcentaje;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btncancelar;
        private DevExpress.XtraEditors.CheckEdit chfechadesde;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit fechahasta;
        private System.Windows.Forms.Label label2;
    }
}