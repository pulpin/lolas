namespace Presentacion
{
    partial class AltaProductoConsigna
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
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtfactura = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gBtipopro = new System.Windows.Forms.GroupBox();
            this.txttitulo = new System.Windows.Forms.Label();
            this.btnbuscaportitulo = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbarra = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtecodigointed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtautor = new System.Windows.Forms.Label();
            this.txtisbn = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.Label();
            this.txtexistencia = new System.Windows.Forms.Label();
            this.gBtipopro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(23, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 187;
            this.label1.Text = "Título:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(109, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 190;
            this.label2.Text = "Autor:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label5.Location = new System.Drawing.Point(62, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 196;
            this.label5.Text = "Precio actual:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtcantidad
            // 
            this.txtcantidad.BackColor = System.Drawing.Color.Honeydew;
            this.txtcantidad.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtcantidad.Location = new System.Drawing.Point(227, 312);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(71, 40);
            this.txtcantidad.TabIndex = 2;
            this.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcantidad.TextChanged += new System.EventHandler(this.txtcantidad_TextChanged);
            this.txtcantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcantidad_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label9.Location = new System.Drawing.Point(146, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 206;
            this.label9.Text = "Cantidad:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtfactura
            // 
            this.txtfactura.BackColor = System.Drawing.Color.Honeydew;
            this.txtfactura.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfactura.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtfactura.Location = new System.Drawing.Point(408, 312);
            this.txtfactura.Name = "txtfactura";
            this.txtfactura.Size = new System.Drawing.Size(129, 40);
            this.txtfactura.TabIndex = 3;
            this.txtfactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtfactura.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfactura_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label10.Location = new System.Drawing.Point(345, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 208;
            this.label10.Text = "Precio:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Location = new System.Drawing.Point(344, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 220;
            this.label4.Text = "Existencia:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gBtipopro
            // 
            this.gBtipopro.Controls.Add(this.txttitulo);
            this.gBtipopro.Controls.Add(this.btnbuscaportitulo);
            this.gBtipopro.Controls.Add(this.txtcodigo);
            this.gBtipopro.Controls.Add(this.label6);
            this.gBtipopro.Controls.Add(this.txtbarra);
            this.gBtipopro.Controls.Add(this.label12);
            this.gBtipopro.Controls.Add(this.label1);
            this.gBtipopro.Location = new System.Drawing.Point(88, 9);
            this.gBtipopro.Name = "gBtipopro";
            this.gBtipopro.Size = new System.Drawing.Size(534, 124);
            this.gBtipopro.TabIndex = 221;
            this.gBtipopro.TabStop = false;
            this.gBtipopro.Text = "Buscar el producto para agregar...";
            // 
            // txttitulo
            // 
            this.txttitulo.AutoSize = true;
            this.txttitulo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitulo.ForeColor = System.Drawing.Color.Black;
            this.txttitulo.Location = new System.Drawing.Point(121, 80);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(62, 23);
            this.txttitulo.TabIndex = 225;
            this.txttitulo.Text = "titulo";
            this.txttitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnbuscaportitulo
            // 
            this.btnbuscaportitulo.Image = global::Presentacion.Properties.Resources.buscarlibro32;
            this.btnbuscaportitulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnbuscaportitulo.Location = new System.Drawing.Point(76, 71);
            this.btnbuscaportitulo.Name = "btnbuscaportitulo";
            this.btnbuscaportitulo.Size = new System.Drawing.Size(41, 41);
            this.btnbuscaportitulo.TabIndex = 225;
            this.btnbuscaportitulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnbuscaportitulo.UseVisualStyleBackColor = true;
            this.btnbuscaportitulo.Click += new System.EventHandler(this.btnbuscaportitulo_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtcodigo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtcodigo.Location = new System.Drawing.Point(344, 26);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 24);
            this.txtcodigo.TabIndex = 1;
            this.txtcodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodigo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label6.Location = new System.Drawing.Point(282, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 222;
            this.label6.Text = "Código:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbarra
            // 
            this.txtbarra.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbarra.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbarra.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtbarra.Location = new System.Drawing.Point(100, 26);
            this.txtbarra.Name = "txtbarra";
            this.txtbarra.Size = new System.Drawing.Size(126, 24);
            this.txtbarra.TabIndex = 0;
            this.txtbarra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbarra_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label12.Location = new System.Drawing.Point(12, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 17);
            this.label12.TabIndex = 220;
            this.label12.Text = "BARRA:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtecodigointed
            // 
            this.txtecodigointed.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtecodigointed.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtecodigointed.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtecodigointed.Location = new System.Drawing.Point(437, 249);
            this.txtecodigointed.Name = "txtecodigointed";
            this.txtecodigointed.Size = new System.Drawing.Size(100, 24);
            this.txtecodigointed.TabIndex = 223;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label7.Location = new System.Drawing.Point(217, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 17);
            this.label7.TabIndex = 224;
            this.label7.Text = "Código propio de la editorial:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label11.Location = new System.Drawing.Point(376, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 219;
            this.label11.Text = "ISBN:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.producto48;
            this.pictureBox1.Location = new System.Drawing.Point(12, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 52);
            this.pictureBox1.TabIndex = 189;
            this.pictureBox1.TabStop = false;
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancelar64;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(352, 400);
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
            this.btnagregar.Location = new System.Drawing.Point(214, 400);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(102, 79);
            this.btnagregar.TabIndex = 9;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtautor
            // 
            this.txtautor.AutoSize = true;
            this.txtautor.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtautor.ForeColor = System.Drawing.Color.Black;
            this.txtautor.Location = new System.Drawing.Point(167, 148);
            this.txtautor.Name = "txtautor";
            this.txtautor.Size = new System.Drawing.Size(61, 23);
            this.txtautor.TabIndex = 226;
            this.txtautor.Text = "autor";
            this.txtautor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtisbn
            // 
            this.txtisbn.AutoSize = true;
            this.txtisbn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtisbn.ForeColor = System.Drawing.Color.Black;
            this.txtisbn.Location = new System.Drawing.Point(435, 148);
            this.txtisbn.Name = "txtisbn";
            this.txtisbn.Size = new System.Drawing.Size(50, 23);
            this.txtisbn.TabIndex = 227;
            this.txtisbn.Text = "isbn";
            this.txtisbn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtprecio
            // 
            this.txtprecio.AutoSize = true;
            this.txtprecio.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtprecio.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtprecio.Location = new System.Drawing.Point(169, 194);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(76, 25);
            this.txtprecio.TabIndex = 228;
            this.txtprecio.Text = "precio";
            this.txtprecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtexistencia
            // 
            this.txtexistencia.AutoSize = true;
            this.txtexistencia.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtexistencia.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexistencia.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtexistencia.Location = new System.Drawing.Point(436, 195);
            this.txtexistencia.Name = "txtexistencia";
            this.txtexistencia.Size = new System.Drawing.Size(118, 25);
            this.txtexistencia.TabIndex = 229;
            this.txtexistencia.Text = "existencia";
            this.txtexistencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AltaProductoConsigna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 493);
            this.ControlBox = false;
            this.Controls.Add(this.txtexistencia);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtisbn);
            this.Controls.Add(this.txtautor);
            this.Controls.Add(this.txtecodigointed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gBtipopro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtfactura);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Name = "AltaProductoConsigna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar producto a la consiguna...";
            this.Activated += new System.EventHandler(this.AltaProductoConsigna_Activated);
            this.Load += new System.EventHandler(this.AltaProducto_Load);
            this.gBtipopro.ResumeLayout(false);
            this.gBtipopro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtfactura;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gBtipopro;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbarra;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtecodigointed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnbuscaportitulo;
        private System.Windows.Forms.Label txttitulo;
        private System.Windows.Forms.Label txtautor;
        private System.Windows.Forms.Label txtisbn;
        private System.Windows.Forms.Label txtprecio;
        private System.Windows.Forms.Label txtexistencia;
    }
}