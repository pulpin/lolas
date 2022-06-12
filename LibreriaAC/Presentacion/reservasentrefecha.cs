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
    public partial class reservasentrefecha : Form
    {
        string _codigo;
        Reservas re = new Reservas();
        Venta ven = new Venta();
        Productos pro = new Productos();

        //private static IFUniversal.ModeloPrn MODELO = IFUniversal.ModeloPrn.modEpsonTMT900FA;
        //private static int PUERTO = 0;
        public reservasentrefecha()
        {
            InitializeComponent();
        }

        private void ConsultasConsignas_Load(object sender, EventArgs e)
        {
            fechadesde.EditValue = DateTime.Today;
            fechahasta.EditValue = DateTime.Today;

           


        }


        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void btnagregacon_Click(object sender, EventArgs e)
        {

        }

        public string Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }
        

        private void btnseleccionado_Click(object sender, EventArgs e)
        {

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

        private void btneliminar_Click(object sender, EventArgs e)
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
        private void cargar()
        {

            
            LogicaNegocios.Venta ve = new LogicaNegocios.Venta();

            DateTime fdesde = Convert.ToDateTime(fechadesde.EditValue);
            string fdesdee = fdesde.ToString("yyyy-MM-dd");

            DateTime fhasta = Convert.ToDateTime(fechahasta.EditValue);
            string fhastae = fhasta.ToString("yyyy-MM-dd");
            int todos;
            todos = 0;
            if (chbTitulo.Checked == true)
            {
                todos = 1;
            }
            else
            {
                todos = 0;
            }

            gConsulta.DataSource = re.Mostrar_Reservasporfecha(fdesdee, fhastae);
            gConsulta4.DataSource = ven.Mostrar_pedidosrealizados();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.cargar();

        }
        

        private void chbTitulo_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void gridViewPintarFilas_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.cargardatos();
        }
        private void cargardatos()
        {
            this.Codigo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["RESE_LI_CODIGOVIEJO"]));
            ven.venproductoide = this.Codigo;
            gConsulta2.DataSource = ven.Mostrar_registrodelasventas();

            gConsulta1.DataSource = ven.Mostrar_movimientosdeproductos();
            gConsulta4.DataSource = ven.Mostrar_pedidosrealizados();
        }
        private void gConsulta_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var topRowIndex = gridViewPintarFilas.TopRowIndex;
            var focusedRowHandle = gridViewPintarFilas.FocusedRowHandle;
            AltaPedido ap = new AltaPedido();
            ap.Producto = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["RESE_DESC"]));
            ap.Ide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_IDE"]));
            ap.colocarnombre();
            ap.CodigoViejo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["RESE_LI_CODIGOVIEJO"]));
            ap.Pedidos = 1;
            ap.Cantidad = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["RESE_CANTIDAD"]));
            ap.colocarcantidad();
            ap.Alta = 1;
            if (ap.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //gConsulta.DataSource = cli.Mostrar_clientes();
                //gConsulta.DataSource = pro.Mostrar_productos();
                this.cargar();
                gridViewPintarFilas.FocusedRowHandle = focusedRowHandle;
                gridViewPintarFilas.TopRowIndex = topRowIndex;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                 

                IFUniversal.IDriver Fiscal = new IFUniversal.Driver();
                Fiscal.Modelo = MODELO;

                if (Fiscal.Error != 0)
                    throw new Exception(Fiscal.ErrorDesc);

                Fiscal.Puerto = 0;
                Fiscal.Baudios = IFUniversal.Baudio.bd9600;

                if (!Fiscal.Inicializar())
                    throw new Exception(Fiscal.ErrorDesc);

                Fiscal.CancelarComprobante();

                if (!Fiscal.CierreX())
                    throw new Exception(Fiscal.ErrorDesc);

                MessageBox.Show("Cierre realizado exitosamente");
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            */
        }

        private void lbpedidos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (gConsulta4.Visible == true)
            {
                gConsulta4.Visible = false;
                gConsulta1.Visible = true;
                gConsulta2.Visible = true;
                label1.Visible = true;
                label4.Visible = true;
                label7.Visible = false;
            }
            else
            {
                gConsulta4.Visible = true;
                gConsulta1.Visible = false;
                gConsulta2.Visible = false;
                label1.Visible = false;
                label4.Visible = false;
                label7.Visible = true;
            }
        }
    }
}
