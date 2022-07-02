namespace Presentacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panelColor = new System.Windows.Forms.Panel();
            this.colorEdit1 = new DevExpress.XtraEditors.ColorEdit();
            this.LUEusuario = new DevExpress.XtraEditors.LookUpEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIngreso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.colorEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEusuario.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(182, 51);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '*';
            this.txtcontraseña.Size = new System.Drawing.Size(134, 20);
            this.txtcontraseña.TabIndex = 1;
            this.txtcontraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcontraseña_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Color:";
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelColor.Location = new System.Drawing.Point(255, 97);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(46, 46);
            this.panelColor.TabIndex = 15;
            // 
            // colorEdit1
            // 
            this.colorEdit1.EditValue = System.Drawing.Color.WhiteSmoke;
            this.colorEdit1.Location = new System.Drawing.Point(128, 108);
            this.colorEdit1.Name = "colorEdit1";
            this.colorEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.colorEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.colorEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorEdit1.Size = new System.Drawing.Size(121, 20);
            this.colorEdit1.TabIndex = 16;
            this.colorEdit1.EditValueChanged += new System.EventHandler(this.colorEdit1_EditValueChanged);
            // 
            // LUEusuario
            // 
            this.LUEusuario.Location = new System.Drawing.Point(182, 12);
            this.LUEusuario.Name = "LUEusuario";
            this.LUEusuario.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.LUEusuario.Properties.Appearance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LUEusuario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUEusuario.Properties.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LUEusuario.Properties.Appearance.Options.UseBackColor = true;
            this.LUEusuario.Properties.Appearance.Options.UseFont = true;
            this.LUEusuario.Properties.Appearance.Options.UseForeColor = true;
            this.LUEusuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEusuario.Properties.DropDownRows = 5;
            this.LUEusuario.Properties.HideSelection = false;
            this.LUEusuario.Properties.NullText = "";
            this.LUEusuario.Properties.ShowHeader = false;
            this.LUEusuario.Size = new System.Drawing.Size(204, 22);
            this.LUEusuario.TabIndex = 0;
            this.LUEusuario.EditValueChanged += new System.EventHandler(this.LUEusuario_EditValueChanged);
            this.LUEusuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LUEusuario_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(26, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(57, 59);
            this.panel2.TabIndex = 11;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Presentacion.Properties.Resources.salir48;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(211, 172);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 69);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnIngreso
            // 
            this.btnIngreso.Image = global::Presentacion.Properties.Resources.entrar48;
            this.btnIngreso.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIngreso.Location = new System.Drawing.Point(79, 172);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(102, 69);
            this.btnIngreso.TabIndex = 2;
            this.btnIngreso.Text = "Ingresar";
            this.btnIngreso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(389, 253);
            this.ControlBox = false;
            this.Controls.Add(this.LUEusuario);
            this.Controls.Add(this.colorEdit1);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIngreso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso al Sistema de Lolas Lencería";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.colorEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEusuario.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panelColor;
        private DevExpress.XtraEditors.ColorEdit colorEdit1;
        private DevExpress.XtraEditors.LookUpEdit LUEusuario;
    }
}