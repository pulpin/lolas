using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocios;

namespace Presentacion
{
    public partial class CantiInte : Form
    {
        int _codigo;
        string _titulo, _interes;
        public CantiInte()
        {
            InitializeComponent();
        }
        public int Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }
        public string Titulo
        {
            get { return this._titulo; }
            set { this._titulo = value; }
        }
        public string Interes
        {
            get { return this._interes; }
            set { this._interes = value; }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Tipodepago tp = new Tipodepago();
            tp.Intereside = this.Codigo;
            tp.Porcentaje = Convert.ToInt32(txtinteres.Text);
            int valor = tp.spModificarInteres();
            if (valor != 0)
            {
                MessageBox.Show("Hubo un error con la modificación.");
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Dispose();
                this.Hide();
            }
        }

        public void colocardatos()
        {
            lbtitulo.Text = this.Titulo;
            txtinteres.Text = this.Interes;
        }
    }
}
