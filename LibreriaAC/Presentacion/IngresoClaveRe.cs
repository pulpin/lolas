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
    public partial class IngresoClaveRe : Form
    {
        public IngresoClaveRe()
        {
            InitializeComponent();
            iniciar();
        }
        private void iniciar()
        {
            
        }

        private void txtclave_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtclave.Text != string.Empty)
                {
                    this.verificaclave();
                }
                else
                {
                    MessageBox.Show("Debe ingresar una clave!");
                }
            }
                    
        }

        private void verificaclave()
        {
            Usuarios usu = new Usuarios();
            usu.Clavepedido = txtclave.Text;
            int valor = usu.spIngresoclavepedido();
            if (valor != 0)
            {
                Globales.usureservaide = valor;
                usu.Usuide = valor;
                Globales.usureservanombre = usu.spTraerNombreusuario();

                this.Dispose();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Debe ingresar, una clave de pedido válida!");
            }
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            this.verificaclave();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Globales.usuventaide = 0;
            this.Dispose();
            this.Hide();
        }
    }
}
