namespace Presentacion
{
    partial class Elegirpto
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
            this.lUPuntovta = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lUPuntovta.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnaceptar
            // 
            this.btnaceptar.Image = global::Presentacion.Properties.Resources.guardar64;
            this.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnaceptar.Location = new System.Drawing.Point(51, 85);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(74, 79);
            this.btnaceptar.TabIndex = 11;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // lUPuntovta
            // 
            this.lUPuntovta.Location = new System.Drawing.Point(12, 36);
            this.lUPuntovta.Name = "lUPuntovta";
            this.lUPuntovta.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.lUPuntovta.Properties.Appearance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lUPuntovta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUPuntovta.Properties.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lUPuntovta.Properties.Appearance.Options.UseBackColor = true;
            this.lUPuntovta.Properties.Appearance.Options.UseFont = true;
            this.lUPuntovta.Properties.Appearance.Options.UseForeColor = true;
            this.lUPuntovta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lUPuntovta.Properties.DropDownRows = 5;
            this.lUPuntovta.Properties.HideSelection = false;
            this.lUPuntovta.Properties.NullText = "";
            this.lUPuntovta.Properties.ShowHeader = false;
            this.lUPuntovta.Size = new System.Drawing.Size(159, 22);
            this.lUPuntovta.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(47, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 193;
            this.label3.Text = "Elegir caja";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Elegirpto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 176);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lUPuntovta);
            this.Controls.Add(this.btnaceptar);
            this.Name = "Elegirpto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elegir punto de venta!";
            this.Load += new System.EventHandler(this.Elegirpto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lUPuntovta.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaceptar;
        private DevExpress.XtraEditors.LookUpEdit lUPuntovta;
        private System.Windows.Forms.Label label3;
    }
}