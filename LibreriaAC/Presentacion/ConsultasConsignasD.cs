using DevExpress.XtraPrinting;
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
    public partial class ConsultasConsignasD : Form
    {
        string _codigo, _editorial,_remito;
        int _codigoedi;
        Consignas con = new Consignas();
        public ConsultasConsignasD()
        {
            InitializeComponent();
        }

        private void ConsultasConsignas_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            con.Codigo = this.Codigo;
            gConsulta.DataSource = con.Mostrar_consignasdetalles();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void btnagregacon_Click(object sender, EventArgs e)
        {
            AltaProductoConsigna apc = new AltaProductoConsigna();
            apc.CodigoConsignaM = Convert.ToInt32(this.Codigo);
            //apc.CodigoConsignaM = Convert.ToInt32(lbconsigna.Text);
            apc.CodigoEditorial = this.CodigoEdi;
            //apc.CodigoEditorial = Convert.ToInt32(lbconsigna.Text);
            apc.posicionarse();
            if (apc.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.cargar();
            }
        }

        public string Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }
        public string Editorial
        {
            get { return this._editorial; }
            set { this._editorial = value; }
        }
        public string Remito
        {
            get { return this._remito; }
            set { this._remito = value; }
        }
        public int CodigoEdi
        {
            get { return this._codigoedi; }
            set { this._codigoedi = value; }
        }
        public void colocarconsignamae()
        {
            lbconsigna.Text = this.Codigo;
            lbeditorial.Text = this.Editorial;
            lbremito.Text = this.Remito;
        }

        private void btnseleccionado_Click(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar éste producto?", "Eliminación en consigna", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {


                Consignas consi = new Consignas();
                consi.Producide = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CONS_LI_CODIGOVIEJO"]));
                consi.Cantidad = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CONS_CANTIDAD"]));
                consi.Consigide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CONS_IDE"]));
                int retorno = consi.spEliminarProducto();
                if (retorno == 0)
                {
                    gConsulta.DataSource = null;
                    MessageBox.Show("Se ha eliminado el producto con éxito!");
                    this.cargar();
                }
                else
                {
                    MessageBox.Show("Hubo un error en la eliminación del producto!");
                }

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

        public void pl_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
        {
            string desti = "Listado de derivaciones por Anexo/Item: ";
            TextBrick brick1 = e.Graph.DrawString(desti, Color.Black,
               new RectangleF(0, 0, 620, 20), DevExpress.XtraPrinting.BorderSide.None);
            brick1.HorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            brick1.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);

        }

        public void pl_CreateReportHeaderArea2(object sender, CreateAreaEventArgs e)
        {
            string fecha;
            fecha = "fecha: " + DateTime.Now;

            TextBrick brick2 = e.Graph.DrawString(fecha, Color.Black,
            new RectangleF(0, 0, 620, 20), DevExpress.XtraPrinting.BorderSide.None);
            //brick2.HorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            //   brick1.HorzAlignment = HorzAlignment.Center;
            brick2.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintableComponentLink pl = new PrintableComponentLink(new PrintingSystem());
            pl.Component = gConsulta;
            pl.CreateMarginalHeaderArea += new CreateAreaEventHandler(pl_CreateReportHeaderArea);
            pl.CreateReportHeaderArea += new CreateAreaEventHandler(pl_CreateReportHeaderArea2);
            pl.PaperKind = System.Drawing.Printing.PaperKind.A4;
            pl.Margins = new System.Drawing.Printing.Margins(20, 20, 20, 20);
            pl.Landscape = true;
            pl.CreateDocument();

            gridViewPintarFilas.OptionsView.ShowFooter = true;
            pl.ShowPreview();
        }
    }
}
