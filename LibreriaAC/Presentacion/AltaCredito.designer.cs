namespace Presentacion
{
    partial class AltaCredito
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
            this.label1 = new System.Windows.Forms.Label();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.paneliva = new System.Windows.Forms.Panel();
            this.txtdiez = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtocho = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtseis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txteditorial = new System.Windows.Forms.TextBox();
            this.txtrubro = new System.Windows.Forms.TextBox();
            this.txtdistribucion = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtcontado = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtfinanciado = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtcaldis = new System.Windows.Forms.TextBox();
            this.txtcalcon = new System.Windows.Forms.TextBox();
            this.txtcalfin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paneliva.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(81, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 187;
            this.label1.Text = "Título:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txttitulo
            // 
            this.txttitulo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txttitulo.Enabled = false;
            this.txttitulo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitulo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txttitulo.Location = new System.Drawing.Point(139, 21);
            this.txttitulo.MaxLength = 60;
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(468, 24);
            this.txttitulo.TabIndex = 0;
            this.txttitulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttitulo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(64, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 192;
            this.label3.Text = "Editorial:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Location = new System.Drawing.Point(70, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 194;
            this.label4.Text = "Rubro:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtcosto
            // 
            this.txtcosto.BackColor = System.Drawing.SystemColors.Info;
            this.txtcosto.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcosto.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtcosto.Location = new System.Drawing.Point(117, 166);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(119, 36);
            this.txtcosto.TabIndex = 4;
            this.txtcosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcosto.TextChanged += new System.EventHandler(this.txtcosto_TextChanged);
            this.txtcosto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcosto_KeyDown);
            this.txtcosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcosto_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label5.Location = new System.Drawing.Point(57, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 196;
            this.label5.Text = "Costo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // paneliva
            // 
            this.paneliva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.paneliva.Controls.Add(this.txtdiez);
            this.paneliva.Controls.Add(this.label16);
            this.paneliva.Controls.Add(this.txtocho);
            this.paneliva.Controls.Add(this.label13);
            this.paneliva.Controls.Add(this.txtseis);
            this.paneliva.Controls.Add(this.label6);
            this.paneliva.Location = new System.Drawing.Point(65, 293);
            this.paneliva.Name = "paneliva";
            this.paneliva.Size = new System.Drawing.Size(536, 40);
            this.paneliva.TabIndex = 205;
            // 
            // txtdiez
            // 
            this.txtdiez.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtdiez.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiez.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtdiez.Location = new System.Drawing.Point(445, 9);
            this.txtdiez.Name = "txtdiez";
            this.txtdiez.Size = new System.Drawing.Size(71, 24);
            this.txtdiez.TabIndex = 210;
            this.txtdiez.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Navy;
            this.label16.Location = new System.Drawing.Point(363, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 17);
            this.label16.TabIndex = 209;
            this.label16.Text = "10 Cuotas:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtocho
            // 
            this.txtocho.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtocho.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtocho.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtocho.Location = new System.Drawing.Point(261, 9);
            this.txtocho.Name = "txtocho";
            this.txtocho.Size = new System.Drawing.Size(71, 24);
            this.txtocho.TabIndex = 208;
            this.txtocho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(184, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 17);
            this.label13.TabIndex = 207;
            this.label13.Text = "8 Cuotas:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtseis
            // 
            this.txtseis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtseis.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtseis.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtseis.Location = new System.Drawing.Point(86, 9);
            this.txtseis.Name = "txtseis";
            this.txtseis.Size = new System.Drawing.Size(71, 24);
            this.txtseis.TabIndex = 206;
            this.txtseis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(9, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 205;
            this.label6.Text = "6 Cuotas:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancelar64;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(349, 374);
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
            this.btnagregar.Enabled = false;
            this.btnagregar.Image = global::Presentacion.Properties.Resources.guardar64;
            this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnagregar.Location = new System.Drawing.Point(211, 374);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(102, 79);
            this.btnagregar.TabIndex = 9;
            this.btnagregar.Text = "Modificar";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txteditorial
            // 
            this.txteditorial.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txteditorial.Enabled = false;
            this.txteditorial.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txteditorial.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txteditorial.Location = new System.Drawing.Point(140, 67);
            this.txteditorial.Name = "txteditorial";
            this.txteditorial.Size = new System.Drawing.Size(194, 24);
            this.txteditorial.TabIndex = 225;
            // 
            // txtrubro
            // 
            this.txtrubro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtrubro.Enabled = false;
            this.txtrubro.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrubro.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtrubro.Location = new System.Drawing.Point(139, 105);
            this.txtrubro.Name = "txtrubro";
            this.txtrubro.Size = new System.Drawing.Size(283, 24);
            this.txtrubro.TabIndex = 226;
            // 
            // txtdistribucion
            // 
            this.txtdistribucion.BackColor = System.Drawing.SystemColors.Info;
            this.txtdistribucion.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdistribucion.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtdistribucion.Location = new System.Drawing.Point(415, 172);
            this.txtdistribucion.Name = "txtdistribucion";
            this.txtdistribucion.Size = new System.Drawing.Size(119, 36);
            this.txtdistribucion.TabIndex = 227;
            this.txtdistribucion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdistribucion.TextChanged += new System.EventHandler(this.txtdistribucion_TextChanged);
            this.txtdistribucion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdistribucion_KeyDown);
            this.txtdistribucion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdistribucion_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label19.Location = new System.Drawing.Point(318, 181);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 17);
            this.label19.TabIndex = 228;
            this.label19.Text = "Distribución:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtcontado
            // 
            this.txtcontado.BackColor = System.Drawing.SystemColors.Info;
            this.txtcontado.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontado.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtcontado.Location = new System.Drawing.Point(117, 219);
            this.txtcontado.Name = "txtcontado";
            this.txtcontado.Size = new System.Drawing.Size(119, 36);
            this.txtcontado.TabIndex = 229;
            this.txtcontado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcontado.TextChanged += new System.EventHandler(this.txtcontado_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label20.Location = new System.Drawing.Point(40, 229);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 17);
            this.label20.TabIndex = 230;
            this.label20.Text = "Contado:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtfinanciado
            // 
            this.txtfinanciado.BackColor = System.Drawing.SystemColors.Info;
            this.txtfinanciado.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfinanciado.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtfinanciado.Location = new System.Drawing.Point(415, 219);
            this.txtfinanciado.Name = "txtfinanciado";
            this.txtfinanciado.Size = new System.Drawing.Size(119, 36);
            this.txtfinanciado.TabIndex = 231;
            this.txtfinanciado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtfinanciado.TextChanged += new System.EventHandler(this.txtfinanciado_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label21.Location = new System.Drawing.Point(327, 229);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(86, 17);
            this.label21.TabIndex = 232;
            this.label21.Text = "Financiado:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtcaldis
            // 
            this.txtcaldis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtcaldis.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcaldis.ForeColor = System.Drawing.Color.Maroon;
            this.txtcaldis.Location = new System.Drawing.Point(544, 176);
            this.txtcaldis.Name = "txtcaldis";
            this.txtcaldis.Size = new System.Drawing.Size(34, 30);
            this.txtcaldis.TabIndex = 233;
            this.txtcaldis.Text = "25";
            this.txtcaldis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtcalcon
            // 
            this.txtcalcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtcalcon.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcalcon.ForeColor = System.Drawing.Color.Maroon;
            this.txtcalcon.Location = new System.Drawing.Point(253, 223);
            this.txtcalcon.Name = "txtcalcon";
            this.txtcalcon.Size = new System.Drawing.Size(34, 30);
            this.txtcalcon.TabIndex = 234;
            this.txtcalcon.Text = "20";
            this.txtcalcon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtcalfin
            // 
            this.txtcalfin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtcalfin.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcalfin.ForeColor = System.Drawing.Color.Maroon;
            this.txtcalfin.Location = new System.Drawing.Point(544, 222);
            this.txtcalfin.Name = "txtcalfin";
            this.txtcalfin.Size = new System.Drawing.Size(34, 30);
            this.txtcalfin.TabIndex = 235;
            this.txtcalfin.Text = "6";
            this.txtcalfin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label7.Location = new System.Drawing.Point(286, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 17);
            this.label7.TabIndex = 236;
            this.label7.Text = "%";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label8.Location = new System.Drawing.Point(582, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 17);
            this.label8.TabIndex = 237;
            this.label8.Text = "%";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(237, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 23);
            this.label2.TabIndex = 238;
            this.label2.Text = "-";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AltaCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 467);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcalfin);
            this.Controls.Add(this.txtcalcon);
            this.Controls.Add(this.txtcaldis);
            this.Controls.Add(this.txtfinanciado);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtcontado);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtdistribucion);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtrubro);
            this.Controls.Add(this.txteditorial);
            this.Controls.Add(this.paneliva);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Name = "AltaCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto de crédito...                                                           " +
    "                                                                                " +
    "";
            this.Load += new System.EventHandler(this.AltaProducto_Load);
            this.paneliva.ResumeLayout(false);
            this.paneliva.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel paneliva;
        private System.Windows.Forms.TextBox txtseis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txteditorial;
        private System.Windows.Forms.TextBox txtrubro;
        private System.Windows.Forms.TextBox txtdiez;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtocho;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtdistribucion;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtcontado;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtfinanciado;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtcaldis;
        private System.Windows.Forms.TextBox txtcalcon;
        private System.Windows.Forms.TextBox txtcalfin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
    }
}