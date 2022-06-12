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
    public partial class ConsultasHistoricoDev : Form
    {
        Rendiciones ren = new Rendiciones();
        public ConsultasHistoricoDev()
        {
            InitializeComponent();
        }

        private void ConsultasConsignas_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            gConsulta.DataSource = ren.Mostrar_historicodevoluciones();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void btnagregacon_Click(object sender, EventArgs e)
        {
            AltaRendicionMae arm = new AltaRendicionMae();
            if (arm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cargar();
            }
        }

        private void btnseleccionado_Click(object sender, EventArgs e)
        {
            ConsultasHistoricoD ccd = new ConsultasHistoricoD();
            ccd.Codigo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["DEVM_IDE"]));
            ccd.Editorial = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["EDI_EDITORIAL"]));
            //ccd.Fecha = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["DEVM_FECHA"]));
            ccd.Fecha = Convert.ToDateTime(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["DEVM_FECHA"]));
            ccd.Obs = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["DEVM_OBS"]));
            ccd.colocarrendicionmae();
            ccd.ShowDialog();
        }
    }
}
