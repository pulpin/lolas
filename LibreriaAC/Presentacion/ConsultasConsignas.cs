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
    public partial class ConsultasConsignas : Form
    {
        Consignas con = new Consignas();
        public ConsultasConsignas()
        {
            InitializeComponent();
        }

        private void ConsultasConsignas_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            gConsulta.DataSource = con.Mostrar_consignas();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void btnagregacon_Click(object sender, EventArgs e)
        {
            AltaconsignaMae ac = new AltaconsignaMae();
            //ac.ShowDialog();
            if (ac.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.cargar();
            }
        }

        private void btnseleccionado_Click(object sender, EventArgs e)
        {
            ConsultasConsignasD ccd = new ConsultasConsignasD();
            ccd.Codigo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CONMA_IDE"]));
            ccd.Editorial = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["EDI_EDITORIAL"]));
            ccd.Remito = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CONMA_REMITO"]));
            ccd.CodigoEdi = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CONMA_EDI_CODIGO"]));
            ccd.colocarconsignamae();
            ccd.ShowDialog();
        }
    }
}
