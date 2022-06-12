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
    public partial class ConsultasRendiciones : Form
    {
        Rendiciones ren = new Rendiciones();
        public ConsultasRendiciones()
        {
            InitializeComponent();
        }

        private void ConsultasConsignas_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            gConsulta.DataSource = ren.Mostrar_rendiciones();
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
            ConsultasRendicionesD ccd = new ConsultasRendicionesD();
            ccd.Codigo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["PRENMA_IDE"]));
            ccd.colocarrendicionmae();
            ccd.ShowDialog();
        }
    }
}
