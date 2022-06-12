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
    public partial class Elegirpto : Form
    {
        public Elegirpto()
        {
            InitializeComponent();
            iniciar();
        }
        private void iniciar()
        {
            
            Puntodevta ptovta = new Puntodevta();
            lUPuntovta.Properties.DisplayMember = "PTOVTA_DESC";
            lUPuntovta.Properties.ValueMember = "PTOVTA_NUMERO";
            lUPuntovta.Properties.DataSource = ptovta.Tabladedatos_ptodevta();
            lUPuntovta.Properties.PopulateColumns();
            //lUPuntovta.EditValue = 4;
            lUPuntovta.EditValue = LogicaNegocios.Globales.gbpuntodeventapredetermindado;
            //lUPuntovta.Properties.Columns[0].Visible = false;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            Globales.puntodeventa = Convert.ToInt32(lUPuntovta.EditValue);
            this.Dispose();
            this.Hide();
        }

        private void Elegirpto_Load(object sender, EventArgs e)
        {

        }
    }
}
