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
    public partial class AltaRendicionMae : Form
    {
        int rendicionide;
        public AltaRendicionMae()
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
            //lUEditorial.Properties.Columns[0].Visible = false;

            desde.EditValue = DateTime.Today;
            hasta.EditValue = DateTime.Today;
        }


        private void guardarrendicion()
        {
            string pcantidad = PREN_CANTIDAD.SummaryText;
            string pprecio = PREN_IMPORTE.SummaryText;

            if (MessageBox.Show("¿Está seguro que desea generar la rendición de: " + lUEditorial.Text + " entre las fechas " + desde.Text + " hasta " + hasta.Text + " ?", "Rendición", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Rendiciones ren = new Rendiciones();
                ren.editorialide = Convert.ToInt32(lUEditorial.EditValue);
                DateTime fdesde = Convert.ToDateTime(desde.EditValue);
                string fdesdee = fdesde.ToString("yyyy-MM-dd");

                DateTime fhasta = Convert.ToDateTime(hasta.EditValue);
                string fhastae = fhasta.ToString("yyyy-MM-dd");

                ren.Cantidad = Convert.ToInt32(pcantidad);

                pprecio = pprecio.Replace(",", ".");
                ren.Importe = pprecio;
                ren.Fechad = fdesdee;
                ren.Fechah = fhastae;

                rendicionide = ren.spNuevaRendicion();
                //acá guardar todos el detalle

                for (int i = 0; i < gridViewPintarFilas.DataRowCount; i++)
                {
                    // ren.Factura = gridViewPintarFilas.GetRowCellValue(i, "PREN_FACTU").ToString();
                    ren.Codigo = gridViewPintarFilas.GetRowCellValue(i, "PREN_IDE").ToString();
                    // ren.editorialide = Convert.ToInt32(lUEditorial.EditValue);
                    //ren.Consigna = Convert.ToInt32(gridViewPintarFilas.GetRowCellValue(i, "PREN_CONSIGNA").ToString());
                    //ren.Cantidad = Convert.ToInt32(gridViewPintarFilas.GetRowCellValue(i, "PREN_CANTIDAD").ToString());

                    //DateTime fvta = Convert.ToDateTime(gridViewPintarFilas.GetRowCellValue(i, "PREN_FECHAVTA").ToString());
                    //string fechaventa = fvta.ToString("yyyy-MM-dd");
                    //ren.Fechavta = fechaventa;

                    //ren.Importe = gridViewPintarFilas.GetRowCellValue(i, "PREN_IMPORTE").ToString();
                    ren.Nrorendi = rendicionide;


                    int envio = ren.spNuevaRendiciondetalle();

                }
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                MessageBox.Show("se ha registrado la rendición nro: " + rendicionide + "");
                this.Dispose();
                this.Hide();
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (gridViewPintarFilas.DataRowCount == 0)
            {
                MessageBox.Show("No existen libros para poder realizar una rendición");
            }
            else
            {
                this.guardarrendicion();
            }
        }
        private void btnbuscarventas_Click(object sender, EventArgs e)
        {
            Venta ve = new Venta();
            int codedi = Convert.ToInt32(lUEditorial.EditValue);

            DateTime fdesde = Convert.ToDateTime(desde.EditValue);
            string fdesdee = fdesde.ToString("yyyy-MM-dd");

            DateTime fhasta = Convert.ToDateTime(hasta.EditValue);
            string fhastae = fhasta.ToString("yyyy-MM-dd");

            
            gConsulta.DataSource = ve.Mostrar_ventasentrefechas(codedi,fdesdee,fhastae);
            if (gridViewPintarFilas.DataRowCount == 0)
            {
                MessageBox.Show("No existen ventas de libros consignados en esas fechas...");
            }

        }

        private void exportarAExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdRuta.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                
                gConsulta.ExportToXlsx(sfdRuta.FileName);
                
            }
        }

        private void exportarAPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdRuta1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                gConsulta.ExportToPdf(sfdRuta1.FileName);
            }
        }

        private void exportarAExcelToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (sfdRuta.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {

                gConsulta.ExportToXlsx(sfdRuta.FileName);

            }
        }

        private void exportarAPDFToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (sfdRuta1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                gConsulta.ExportToPdf(sfdRuta1.FileName);
            }
        }
    }
}
