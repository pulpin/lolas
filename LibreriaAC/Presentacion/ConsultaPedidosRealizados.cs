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
    public partial class ConsultaPedidosRealizados : Form
    {
        string _codigo;
        int _liide;
        Pedidos pe = new Pedidos();
        
        Productos pro = new Productos();
        
        public ConsultaPedidosRealizados()
        {
            InitializeComponent();
        }

        private void ConsultasConsignas_Load(object sender, EventArgs e)
        {
            //this.cargar();

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

        public int Liide
        {
            get { return this._liide; }
            set { this._liide = value; }
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
            DateTime fec = Convert.ToDateTime(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["PED_FECHA"]));
            fecha = "Pedido realizado el : " + fec;
            string pro = Convert.ToString(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["proveedor"]));
            string proveedor = "Proveedor: " + pro;
            TextBrick brick3 = e.Graph.DrawString("DISTRIBUIDORA AC. SANTA CRUZ", Color.Black,
            new RectangleF(0, 10, 720, 30), DevExpress.XtraPrinting.BorderSide.None);
            brick3.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
            TextBrick brick4 = e.Graph.DrawString(proveedor, Color.Black,
            new RectangleF(0, 35, 900, 30), DevExpress.XtraPrinting.BorderSide.None);

            TextBrick brick2 = e.Graph.DrawString(fecha, Color.Black,
            new RectangleF(0, 55, 620, 20), DevExpress.XtraPrinting.BorderSide.None);
            brick2.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            PrintableComponentLink pl = new PrintableComponentLink(new PrintingSystem());
            pl.Component = gConsulta1;
            pl.CreateMarginalHeaderArea += new CreateAreaEventHandler(pl_CreateReportHeaderArea);
            pl.CreateReportHeaderArea += new CreateAreaEventHandler(pl_CreateReportHeaderArea2);
            pl.PaperKind = System.Drawing.Printing.PaperKind.A4;
            pl.Margins = new System.Drawing.Printing.Margins(20, 20, 20, 20);
            pl.Landscape = false;
            pl.CreateDocument();

            gridView1.OptionsView.ShowFooter = true;
            pl.ShowPreview();
        }

        private void exportarAExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdRuta.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                gConsulta1.ExportToXlsx(sfdRuta.FileName);

            }
        }

        private void exportarAPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdRuta1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                gConsulta1.ExportToPdf(sfdRuta1.FileName);
            }
        }
        public void cargar()
        {


            pe.Codigo = this.Liide;
            gConsulta1.DataSource = pe.Mostrar_PedidosRealizados();


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
           
            pe.Codigo = Convert.ToInt32(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["PED_IDE"]));


            gConsulta1.DataSource = pe.Mostrar_pedidosdetalle();
        }
        private void gConsulta_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }
    }
}
