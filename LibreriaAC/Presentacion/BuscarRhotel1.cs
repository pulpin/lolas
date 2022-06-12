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
using MySql.Data.MySqlClient;

namespace Presentacion
{
    public partial class BuscarRhotel1 : Form
    {
        int derid, locid;
        public BuscarRhotel1()
        {
            InitializeComponent();
            
        }

        public void iniciar()
        {
            Derivacion de = new Derivacion();
            //dgvDerivacion.DataSource = de.Mostrar_Datos_derivacionesauto();
          dgvRenoCome.DataSource = null;
            //this.dgvDerivacion.Columns["DER_FECH_INICIO"].DefaultCellStyle.Format = "d";
            //this.dgvDerivacion.Columns["AFI_FECNAC"].DefaultCellStyle.Format = "d";
            
            de = null;
            
        }

        private void txtderinrobus_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MostrarHC(Convert.ToInt32(txtderinrobus.Text), Convert.ToInt32(txtloc1.Text));
            }
        }

        private void txtloc1_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtderinrobus.Focus();
            }
        }
        private void MostrarHC(int nderinro, int nlocide ) {

            HoteCome hc = new HoteCome();
            dgvRenoCome.DataSource = hc.Mostrar_Datos_HC(nderinro,nlocide,0);
            hc = null;
            dgvRenoCome.AutoResizeColumns();
            dgvRenoCome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRenoCome.Columns[3].Visible = false;
            this.dgvRenoCome.Columns[4].Visible = false;
            this.dgvRenoCome.Columns[5].Visible = false;
            this.dgvRenoCome.Columns[6].Visible = false;
            this.dgvRenoCome.Columns[7].Visible = false;
        
        
        }
        private void txtloc_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void tbnselec_Click(object sender, EventArgs e)
        {

        }
    }
}
