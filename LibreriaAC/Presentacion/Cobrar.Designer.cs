namespace Presentacion
{
    partial class Cobrar
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
            this.lbimporte = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LUTipopago = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.lbdescuento = new System.Windows.Forms.Label();
            this.txtdescuento = new System.Windows.Forms.TextBox();
            this.txtabona = new System.Windows.Forms.TextBox();
            this.lbabona = new System.Windows.Forms.Label();
            this.lbvuelto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbvuelto1 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btncobrarvta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LUTipopago.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbimporte
            // 
            this.lbimporte.AutoSize = true;
            this.lbimporte.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbimporte.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbimporte.Location = new System.Drawing.Point(177, 26);
            this.lbimporte.Name = "lbimporte";
            this.lbimporte.Size = new System.Drawing.Size(69, 35);
            this.lbimporte.TabIndex = 225;
            this.lbimporte.Text = "105";
            this.lbimporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(38, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 224;
            this.label1.Text = "TOTAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(37, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 226;
            this.label2.Text = "Tipo de pago";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LUTipopago
            // 
            this.LUTipopago.Location = new System.Drawing.Point(185, 86);
            this.LUTipopago.Name = "LUTipopago";
            this.LUTipopago.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.LUTipopago.Properties.Appearance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LUTipopago.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUTipopago.Properties.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LUTipopago.Properties.Appearance.Options.UseBackColor = true;
            this.LUTipopago.Properties.Appearance.Options.UseFont = true;
            this.LUTipopago.Properties.Appearance.Options.UseForeColor = true;
            this.LUTipopago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUTipopago.Properties.DropDownRows = 5;
            this.LUTipopago.Properties.HideSelection = false;
            this.LUTipopago.Properties.NullText = "";
            this.LUTipopago.Properties.ShowHeader = false;
            this.LUTipopago.Size = new System.Drawing.Size(179, 22);
            this.LUTipopago.TabIndex = 227;
            this.LUTipopago.EditValueChanged += new System.EventHandler(this.LUTipopago_EditValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Location = new System.Drawing.Point(149, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 23);
            this.label3.TabIndex = 228;
            this.label3.Text = "$";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbdescuento
            // 
            this.lbdescuento.AutoSize = true;
            this.lbdescuento.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdescuento.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lbdescuento.Location = new System.Drawing.Point(61, 131);
            this.lbdescuento.Name = "lbdescuento";
            this.lbdescuento.Size = new System.Drawing.Size(110, 23);
            this.lbdescuento.TabIndex = 231;
            this.lbdescuento.Text = "Descuento";
            this.lbdescuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtdescuento
            // 
            this.txtdescuento.BackColor = System.Drawing.SystemColors.Info;
            this.txtdescuento.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescuento.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtdescuento.Location = new System.Drawing.Point(185, 130);
            this.txtdescuento.Name = "txtdescuento";
            this.txtdescuento.Size = new System.Drawing.Size(89, 30);
            this.txtdescuento.TabIndex = 232;
            this.txtdescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdescuento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdescuento_KeyPress);
            // 
            // txtabona
            // 
            this.txtabona.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtabona.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtabona.Location = new System.Drawing.Point(185, 174);
            this.txtabona.Name = "txtabona";
            this.txtabona.Size = new System.Drawing.Size(89, 30);
            this.txtabona.TabIndex = 234;
            this.txtabona.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtabona.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtabona_KeyPress);
            // 
            // lbabona
            // 
            this.lbabona.AutoSize = true;
            this.lbabona.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbabona.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lbabona.Location = new System.Drawing.Point(101, 177);
            this.lbabona.Name = "lbabona";
            this.lbabona.Size = new System.Drawing.Size(70, 23);
            this.lbabona.TabIndex = 233;
            this.lbabona.Text = "Abona";
            this.lbabona.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbvuelto
            // 
            this.lbvuelto.AutoSize = true;
            this.lbvuelto.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvuelto.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lbvuelto.Location = new System.Drawing.Point(39, 220);
            this.lbvuelto.Name = "lbvuelto";
            this.lbvuelto.Size = new System.Drawing.Size(72, 23);
            this.lbvuelto.TabIndex = 235;
            this.lbvuelto.Text = "Vuelto";
            this.lbvuelto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Location = new System.Drawing.Point(149, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 23);
            this.label4.TabIndex = 237;
            this.label4.Text = "$";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbvuelto1
            // 
            this.lbvuelto1.AutoSize = true;
            this.lbvuelto1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvuelto1.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbvuelto1.Location = new System.Drawing.Point(177, 217);
            this.lbvuelto1.Name = "lbvuelto1";
            this.lbvuelto1.Size = new System.Drawing.Size(33, 35);
            this.lbvuelto1.TabIndex = 236;
            this.lbvuelto1.Text = "0";
            this.lbvuelto1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnsalir
            // 
            this.btnsalir.Image = global::Presentacion.Properties.Resources.salir;
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsalir.Location = new System.Drawing.Point(211, 306);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(114, 57);
            this.btnsalir.TabIndex = 230;
            this.btnsalir.Text = "Salir";
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btncobrarvta
            // 
            this.btncobrarvta.Image = global::Presentacion.Properties.Resources.pagar;
            this.btncobrarvta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncobrarvta.Location = new System.Drawing.Point(65, 306);
            this.btncobrarvta.Name = "btncobrarvta";
            this.btncobrarvta.Size = new System.Drawing.Size(114, 57);
            this.btncobrarvta.TabIndex = 0;
            this.btncobrarvta.Text = "Cobrar";
            this.btncobrarvta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncobrarvta.UseVisualStyleBackColor = true;
            this.btncobrarvta.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 377);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbvuelto1);
            this.Controls.Add(this.lbvuelto);
            this.Controls.Add(this.txtabona);
            this.Controls.Add(this.lbabona);
            this.Controls.Add(this.txtdescuento);
            this.Controls.Add(this.lbdescuento);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btncobrarvta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LUTipopago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbimporte);
            this.Controls.Add(this.label1);
            this.Name = "Cobrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobrar";
            this.Load += new System.EventHandler(this.Cobrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LUTipopago.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbimporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LookUpEdit LUTipopago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncobrarvta;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label lbdescuento;
        private System.Windows.Forms.TextBox txtdescuento;
        private System.Windows.Forms.TextBox txtabona;
        private System.Windows.Forms.Label lbabona;
        private System.Windows.Forms.Label lbvuelto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbvuelto1;
    }
}