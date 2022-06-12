namespace Presentacion
{
    partial class CargarProAdo
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
            this.lbcodigo = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lUArea = new DevExpress.XtraEditors.LookUpEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rBcualquier = new System.Windows.Forms.RadioButton();
            this.rBopcional = new System.Windows.Forms.RadioButton();
            this.rBlibros = new System.Windows.Forms.RadioButton();
            this.lbtitulo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lUArea.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 190;
            this.label1.Text = "Código:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbcodigo
            // 
            this.lbcodigo.AutoSize = true;
            this.lbcodigo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcodigo.ForeColor = System.Drawing.Color.Red;
            this.lbcodigo.Location = new System.Drawing.Point(169, 9);
            this.lbcodigo.Name = "lbcodigo";
            this.lbcodigo.Size = new System.Drawing.Size(22, 23);
            this.lbcodigo.TabIndex = 191;
            this.lbcodigo.Text = "0";
            this.lbcodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancelar64;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(249, 264);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(102, 79);
            this.btncancelar.TabIndex = 194;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Image = global::Presentacion.Properties.Resources.guardar64;
            this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnagregar.Location = new System.Drawing.Point(111, 264);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(102, 79);
            this.btnagregar.TabIndex = 193;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(79, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 251;
            this.label3.Text = "Area:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lUArea
            // 
            this.lUArea.Location = new System.Drawing.Point(126, 143);
            this.lUArea.Name = "lUArea";
            this.lUArea.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.lUArea.Properties.Appearance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lUArea.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUArea.Properties.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lUArea.Properties.Appearance.Options.UseBackColor = true;
            this.lUArea.Properties.Appearance.Options.UseFont = true;
            this.lUArea.Properties.Appearance.Options.UseForeColor = true;
            this.lUArea.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lUArea.Properties.DropDownRows = 5;
            this.lUArea.Properties.HideSelection = false;
            this.lUArea.Properties.NullText = "";
            this.lUArea.Properties.ShowHeader = false;
            this.lUArea.Size = new System.Drawing.Size(294, 22);
            this.lUArea.TabIndex = 250;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rBcualquier);
            this.groupBox2.Controls.Add(this.rBopcional);
            this.groupBox2.Controls.Add(this.rBlibros);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(39, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 33);
            this.groupBox2.TabIndex = 258;
            this.groupBox2.TabStop = false;
            // 
            // rBcualquier
            // 
            this.rBcualquier.AutoSize = true;
            this.rBcualquier.ForeColor = System.Drawing.Color.Maroon;
            this.rBcualquier.Location = new System.Drawing.Point(252, 9);
            this.rBcualquier.Name = "rBcualquier";
            this.rBcualquier.Size = new System.Drawing.Size(126, 18);
            this.rBcualquier.TabIndex = 201;
            this.rBcualquier.Text = "Cualquier editorial";
            this.rBcualquier.UseVisualStyleBackColor = true;
            // 
            // rBopcional
            // 
            this.rBopcional.AutoSize = true;
            this.rBopcional.ForeColor = System.Drawing.Color.Maroon;
            this.rBopcional.Location = new System.Drawing.Point(138, 8);
            this.rBopcional.Name = "rBopcional";
            this.rBopcional.Size = new System.Drawing.Size(103, 18);
            this.rBopcional.TabIndex = 200;
            this.rBopcional.Text = "Libro opcional";
            this.rBopcional.UseVisualStyleBackColor = true;
            // 
            // rBlibros
            // 
            this.rBlibros.AutoSize = true;
            this.rBlibros.Checked = true;
            this.rBlibros.ForeColor = System.Drawing.Color.Maroon;
            this.rBlibros.Location = new System.Drawing.Point(19, 8);
            this.rBlibros.Name = "rBlibros";
            this.rBlibros.Size = new System.Drawing.Size(105, 18);
            this.rBlibros.TabIndex = 199;
            this.rBlibros.TabStop = true;
            this.rBlibros.Text = "Sólo este libro";
            this.rBlibros.UseVisualStyleBackColor = true;
            // 
            // lbtitulo
            // 
            this.lbtitulo.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitulo.ForeColor = System.Drawing.Color.Red;
            this.lbtitulo.Location = new System.Drawing.Point(57, 58);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.ReadOnly = true;
            this.lbtitulo.Size = new System.Drawing.Size(377, 46);
            this.lbtitulo.TabIndex = 259;
            this.lbtitulo.Text = "";
            // 
            // CargarProAdo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 353);
            this.ControlBox = false;
            this.Controls.Add(this.lbtitulo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lUArea);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.lbcodigo);
            this.Controls.Add(this.label1);
            this.Name = "CargarProAdo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar libro a la adopción...";
            this.Load += new System.EventHandler(this.CargarProAdo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lUArea.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbcodigo;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.LookUpEdit lUArea;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rBcualquier;
        private System.Windows.Forms.RadioButton rBopcional;
        private System.Windows.Forms.RadioButton rBlibros;
        private System.Windows.Forms.RichTextBox lbtitulo;
    }
}