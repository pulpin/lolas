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
    public partial class ConsultaPrecios : Form
    {
        public ConsultaPrecios()
        {
            InitializeComponent();
        }

        private void enviar(string valor, int tipo)
        {
            barCodeControl1.Text = valor;
            //buscar acá
            Productos pro = new Productos();
            pro.Tipo = tipo;
            pro.spConsultaPrecio(valor);
            lbtitulo.Text = pro.Titulo;
            lbprecio.Text = pro.Precio;
            txtbarra.Text = "";
            txtcodigo.Text = "";
            txtbarra.Focus();
        }

        private void txtbarra_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.enviar(txtbarra.Text,0);
            }
        }

        private void txtcodigo_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.enviar(txtcodigo.Text,1);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }
    }
}
