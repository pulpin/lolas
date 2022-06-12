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
    public partial class Cobrar : Form
    {
        int entra = 0;
        public static string totalapag;
        public int tipopag = 0;
        public Cobrar()
        {
            InitializeComponent();
            
        }
        public void colocarvalorapagar()
        {
            lbimporte.Text = totalapag;
        }
        public void inicio()
        {
            entra = 1;
        }

        private void Cobrar_Load(object sender, EventArgs e)
        {
            Tipodepago tip = new Tipodepago();

            LUTipopago.Properties.DisplayMember = "TIP_DESC";
            LUTipopago.Properties.ValueMember = "TIP_IDE";
            LUTipopago.Properties.DataSource = tip.Mostrar_intereses_caja();
            LUTipopago.Properties.PopulateColumns();
            LUTipopago.Properties.Columns[0].Visible = false;
            LUTipopago.Properties.Columns[2].Visible = false;

        }

        public void setearimporte(string imp)
        {
            lbimporte.Text = imp;
            txtabona.Text = imp;
            lbvuelto1.Text = "0";
        }

        public void seteartipopago(int valor)
        {

            LUTipopago.EditValue = valor;
            this.tipopag = valor;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ICobrar formInterCobrar = this.Owner as ICobrar;

            if (formInterCobrar != null)
            {
                formInterCobrar.guardarventa();
                this.Dispose();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void txtabona_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lbvuelto1.Text = Convert.ToString(Convert.ToDouble(txtabona.Text) - Convert.ToDouble(lbimporte.Text));
            }
        }

        private void LUTipopago_EditValueChanged(object sender, EventArgs e)
        {
            if (entra != 0)
            {
                ICobrar formInterCobrar = this.Owner as ICobrar;

                if (formInterCobrar != null)
                {
                   // entra = 0;
                    int retorn = formInterCobrar.tipodepagoelegidoC(Convert.ToInt32(LUTipopago.EditValue));
                    lbimporte.Text = totalapag;
                    txtabona.Text = totalapag;
                    lbvuelto1.Text = "0";
                    //LUTipopago.Enabled = false;
                    if (retorn == 0)
                    {
                        LUTipopago.EditValue = this.tipopag;
                    }
                }
                    
            }
        }

        private void txtclave_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            MessageBox.Show("presionó acá");
        }

        private void txtdescuento_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ICobrar formInterCobrar = this.Owner as ICobrar;

                if (formInterCobrar != null)
                {
                    formInterCobrar.aplicadescuentoC(Convert.ToInt32(txtdescuento.Text));
                    lbimporte.Text = totalapag;
                    txtabona.Text = totalapag;
                    lbvuelto1.Text = "0";
                    LUTipopago.Enabled = false;
                }
            }
        }


    }
}
