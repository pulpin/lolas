namespace Presentacion
{
    partial class BuscarRhotel1
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
            this.txtloc1 = new System.Windows.Forms.TextBox();
            this.txtderinrobus = new System.Windows.Forms.TextBox();
            this.dgvRenoCome = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.tbnselec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenoCome)).BeginInit();
            this.SuspendLayout();
            // 
            // txtloc1
            // 
            this.txtloc1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtloc1.Location = new System.Drawing.Point(233, 20);
            this.txtloc1.Name = "txtloc1";
            this.txtloc1.Size = new System.Drawing.Size(30, 20);
            this.txtloc1.TabIndex = 96;
            // 
            // txtderinrobus
            // 
            this.txtderinrobus.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtderinrobus.Location = new System.Drawing.Point(282, 20);
            this.txtderinrobus.Name = "txtderinrobus";
            this.txtderinrobus.Size = new System.Drawing.Size(82, 20);
            this.txtderinrobus.TabIndex = 95;
            // 
            // dgvRenoCome
            // 
            this.dgvRenoCome.AllowUserToAddRows = false;
            this.dgvRenoCome.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvRenoCome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRenoCome.Location = new System.Drawing.Point(22, 61);
            this.dgvRenoCome.Name = "dgvRenoCome";
            this.dgvRenoCome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRenoCome.Size = new System.Drawing.Size(491, 146);
            this.dgvRenoCome.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 97;
            this.label1.Text = "Nro derivación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 16);
            this.label2.TabIndex = 98;
            this.label2.Text = "/";
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(288, 225);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(98, 36);
            this.btncancelar.TabIndex = 100;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // tbnselec
            // 
            this.tbnselec.Location = new System.Drawing.Point(165, 225);
            this.tbnselec.Name = "tbnselec";
            this.tbnselec.Size = new System.Drawing.Size(98, 36);
            this.tbnselec.TabIndex = 99;
            this.tbnselec.Text = "Seleccionar";
            this.tbnselec.UseVisualStyleBackColor = true;
            // 
            // BuscarRhotel
            // 
            this.ClientSize = new System.Drawing.Size(559, 272);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.tbnselec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtloc1);
            this.Controls.Add(this.txtderinrobus);
            this.Controls.Add(this.dgvRenoCome);
            this.Name = "BuscarRhotel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenoCome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.TextBox txtloc1;
        private System.Windows.Forms.TextBox txtderinrobus;
        private System.Windows.Forms.DataGridView dgvRenoCome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button tbnselec;
    }
}