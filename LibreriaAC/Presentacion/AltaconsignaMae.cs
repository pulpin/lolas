using LogicaNegocios;
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
    public partial class AltaconsignaMae : Form
    {
        int consigmaeide;
        public AltaconsignaMae()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void AltaconsignaMae_Load(object sender, EventArgs e)
        {
            Editorial edi = new Editorial();

            lUEditorial.Properties.DisplayMember = "EDI_EDITORIAL";
            lUEditorial.Properties.ValueMember = "EDI_CODIGO";
            lUEditorial.Properties.DataSource = edi.Tabladedatos_editoriales();
            lUEditorial.Properties.PopulateColumns();
           // lUEditorial.Properties.Columns[0].Visible = false;

            dateEnvio.EditValue = DateTime.Today;
            dateRecepcion.EditValue = DateTime.Today;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Consignas con = new Consignas();
            con.Codigo = Convert.ToString(lUEditorial.EditValue);
            DateTime prueba = Convert.ToDateTime(dateRecepcion.EditValue);
            con.Fecharecep = prueba.ToString("yyyy-MM-dd");
            //con.Fecharecep = Convert.ToString(dateEnvio.EditValue);

            DateTime prueba2 = Convert.ToDateTime(dateEnvio.EditValue);
            con.Fechaenvio = prueba2.ToString("yyyy-MM-dd");
           // con.Fechaenvio = Convert.ToString(dateEnvio.EditValue);
            con.Remito = txtremito.Text;
            consigmaeide = con.spInsertarConsignaMae();
            //MessageBox.Show("Se ha dado de alta la consigna: "+ consigmaeide + " ");
            ConsultasConsignasD ccd = new ConsultasConsignasD();
            ccd.Codigo = Convert.ToString(consigmaeide);
            ccd.CodigoEdi = Convert.ToInt32(con.Codigo);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            ccd.colocarconsignamae();
            ccd.ShowDialog();
        }
    }
}
