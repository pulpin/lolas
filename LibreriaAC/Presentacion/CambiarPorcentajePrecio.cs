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
    public partial class CambiarPorcentajePrecio : Form
    {
        public CambiarPorcentajePrecio()
        {
            InitializeComponent();
            iniciar();
        }
        private void iniciar()
        {

            CheckForIllegalCrossThreadCalls = false;
            Editorial edi = new Editorial();

            lUEditorial.Properties.DisplayMember = "EDI_EDITORIAL";
            lUEditorial.Properties.ValueMember = "EDI_CODIGO";
            lUEditorial.Properties.DataSource = edi.Tabladedatos_editoriales();
            lUEditorial.Properties.PopulateColumns();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lUEditorial.EditValue) > 0)
            { 
            txtporcentaje.Text = txtporcentaje.Text.Replace(",", ".");
            Productos pro = new Productos();
            pro.Editorial = Convert.ToInt32(lUEditorial.EditValue);
            pro.PorcentajeCosto = Convert.ToInt32(txtporcentaje.Text);
                if (chfechadesde.Checked == true)
                {
                    pro.Poractualizacion = 1;
                }else
                {
                    pro.Poractualizacion = 0;
                }

            int valor = pro.spModificarPorcentajePrecio();
            if (valor == 0)
            {
                MessageBox.Show("Se ha modificado el porcentaje de costo y se calculó el PRECIO con éxito");
                    this.Dispose();
                    this.Hide();
                }
            else
            {
                MessageBox.Show("Hubo un error");
            }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una editorial");
            }
        }

        private void Elegirpto_Load(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void chfechadesde_CheckedChanged(object sender, EventArgs e)
        {
            if (chfechadesde.Checked == true)
            {
                label1.Visible = true;
                fechahasta.Visible = true;
            }
            else
            {
                label1.Visible = false;
                fechahasta.Visible = false;
            }
        }
    }
}
