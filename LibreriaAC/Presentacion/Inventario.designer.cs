namespace Presentacion
{
    partial class Inventario
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
            this.btnagregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtimporte = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkinventariado = new DevExpress.XtraEditors.CheckEdit();
            this.lbdeposito = new System.Windows.Forms.Label();
            this.lbstock = new System.Windows.Forms.Label();
            this.lbsalon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chkinventariado.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancelar64;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(258, 247);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(102, 79);
            this.btncancelar.TabIndex = 10;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Image = global::Presentacion.Properties.Resources.guardar64;
            this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnagregar.Location = new System.Drawing.Point(122, 247);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(102, 79);
            this.btnagregar.TabIndex = 9;
            this.btnagregar.Text = "Modificar";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(145, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 229;
            this.label1.Text = "Cantidad:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(169, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 239;
            this.label2.Text = "Stock:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Location = new System.Drawing.Point(89, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 240;
            this.label4.Text = "Total en depósito:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtimporte
            // 
            this.txtimporte.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtimporte.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtimporte.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtimporte.Location = new System.Drawing.Point(244, 125);
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.Size = new System.Drawing.Size(92, 30);
            this.txtimporte.TabIndex = 254;
            this.txtimporte.Text = "0";
            this.txtimporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(150, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 256;
            this.label3.Text = "En salón:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkinventariado
            // 
            this.chkinventariado.Location = new System.Drawing.Point(186, 182);
            this.chkinventariado.Name = "chkinventariado";
            this.chkinventariado.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkinventariado.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.chkinventariado.Properties.Appearance.Options.UseFont = true;
            this.chkinventariado.Properties.Appearance.Options.UseForeColor = true;
            this.chkinventariado.Properties.Caption = "Inventariado";
            this.chkinventariado.Size = new System.Drawing.Size(135, 23);
            this.chkinventariado.TabIndex = 257;
            // 
            // lbdeposito
            // 
            this.lbdeposito.AutoSize = true;
            this.lbdeposito.BackColor = System.Drawing.Color.Beige;
            this.lbdeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdeposito.Location = new System.Drawing.Point(244, 22);
            this.lbdeposito.Name = "lbdeposito";
            this.lbdeposito.Size = new System.Drawing.Size(20, 24);
            this.lbdeposito.TabIndex = 258;
            this.lbdeposito.Text = "0";
            // 
            // lbstock
            // 
            this.lbstock.AutoSize = true;
            this.lbstock.BackColor = System.Drawing.Color.Khaki;
            this.lbstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstock.Location = new System.Drawing.Point(244, 53);
            this.lbstock.Name = "lbstock";
            this.lbstock.Size = new System.Drawing.Size(20, 24);
            this.lbstock.TabIndex = 259;
            this.lbstock.Text = "0";
            // 
            // lbsalon
            // 
            this.lbsalon.AutoSize = true;
            this.lbsalon.BackColor = System.Drawing.Color.GreenYellow;
            this.lbsalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsalon.Location = new System.Drawing.Point(244, 85);
            this.lbsalon.Name = "lbsalon";
            this.lbsalon.Size = new System.Drawing.Size(20, 24);
            this.lbsalon.TabIndex = 260;
            this.lbsalon.Text = "0";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(487, 338);
            this.ControlBox = false;
            this.Controls.Add(this.lbsalon);
            this.Controls.Add(this.lbstock);
            this.Controls.Add(this.lbdeposito);
            this.Controls.Add(this.chkinventariado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtimporte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Name = "Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario de productos...";
            this.Load += new System.EventHandler(this.AltaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chkinventariado.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtimporte;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.CheckEdit chkinventariado;
        private System.Windows.Forms.Label lbdeposito;
        private System.Windows.Forms.Label lbstock;
        private System.Windows.Forms.Label lbsalon;
    }
}