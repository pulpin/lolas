using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class CargarCantidad : Form
    {
        int _cantielegida;
        string _titulo, _codigo;
        public CargarCantidad()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        public int Cantielegida
        {
            get { return this._cantielegida; }
            set { this._cantielegida = value; }
        }
        public string Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }

        public string Titulo
        {
            get { return this._titulo; }
            set { this._titulo = value; }
        }
        public void colocartitulo()
        {
            lbcodigo.Text = this.Codigo;
            lbtitulo.Text = this.Titulo;
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            //comprobar acá si es numerico
          //  if ((txtcantidad.Text).i)
            Cantielegida = Convert.ToInt32(txtcantidad.Text);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Dispose();
            this.Hide();
        }

        private void txtcantidad_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnagregar.Focus();
            }
        }
    }
}
