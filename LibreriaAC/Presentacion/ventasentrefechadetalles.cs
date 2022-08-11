using DevExpress.XtraGrid.Views.Grid;
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
    public partial class ventasentrefechadetalles : Form
    {
        string _codigo;
        Reservas re = new Reservas();
        Venta ven = new Venta();
        Productos pro = new Productos();


        

        public ventasentrefechadetalles()
        {
            InitializeComponent();
        }

        private void ConsultasConsignas_Load(object sender, EventArgs e)
        {
            fechadesde.EditValue = DateTime.Today;
            fechahasta.EditValue = DateTime.Today;
            //this.tipopro = 1;
            Editorial edi = new Editorial();

            lUEditorial.Properties.DisplayMember = "EDI_EDITORIAL";
            lUEditorial.Properties.ValueMember = "EDI_CODIGO";
            lUEditorial.Properties.DataSource = edi.Tabladedatos_editoriales();
            lUEditorial.Properties.PopulateColumns();
            lUEditorial.Properties.Columns[0].Visible = false;
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
            pl.Component = gConsultaPed;
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
                gConsultaPed.ExportToXlsx(sfdRuta.FileName);

            }
        }

        private void exportarAPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdRuta1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                gConsultaPed.ExportToPdf(sfdRuta1.FileName);
            }
        }
        private void cargar()
        {

            int todos;
            LogicaNegocios.Venta ve = new LogicaNegocios.Venta();

            DateTime fdesde = Convert.ToDateTime(fechadesde.EditValue);
            string fdesdee = fdesde.ToString("yyyy-MM-dd");

            DateTime fhasta = Convert.ToDateTime(fechahasta.EditValue);
            string fhastae = fhasta.ToString("yyyy-MM-dd");
            todos = 0;
            if (chbTitulo.Checked == true)
            {
                todos = 1;
            }
            else
            {
                todos = 0;
            }
            if (rBlibros.Checked == true)
            {
                ve.EsLibro = 1;
            }
            else
            {
                ve.EsLibro = 0;
            }
            if (Convert.ToInt32(lUEditorial.EditValue) > 0) 
            {
                ve.Editorial = Convert.ToInt32(lUEditorial.EditValue);
            }

            gConsultaPed.DataSource = ve.Mostrar_VentasporfechaPedidoPorMarca(fdesdee, fhastae);
            

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
            this.Codigo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["codigo"]));
            ven.venproductoide = this.Codigo;
            //int cantidaddereservas = ven.spConsultaCantiReservas();
            //lbcantidadreserva.Text = Convert.ToString(cantidaddereservas);
            //gConsulta2.DataSource = ven.Mostrar_registrodelasventas();
            //gConsulta1.DataSource = ven.Mostrar_movimientosdeproductos();
            //gConsulta3.DataSource = ven.Mostrar_reservasdeproducto();
            //lbcantidadreserva.Text = Convert.ToString(gridView3.DataRowCount);
            //gConsulta4.DataSource = ven.Mostrar_pedidosrealizados();
           // int cantidadpedidos = gridView4.DataRowCount;
           // lbpedidos.Text = Convert.ToString(cantidadpedidos);
            pro.Codigo = this.Codigo;
            //lbsockactual.Text = Convert.ToString(pro.spConsultastockactual());

        }
        private void gConsulta_Click(object sender, EventArgs e)
        {

        }
        //this.gridViewPintarFilas.RowStyle += gridViewPintarFilas_RowStyle;
        private void gridViewPintarFilas_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                int valorp = Convert.ToInt32(View.GetRowCellDisplayText(e.RowHandle, View.Columns["valor"]));

                //e.Appearance.BackColor = Color.LemonChiffon;
                
                if (valorp == 1)
                {
                    e.Appearance.BackColor = Color.PaleGreen;  
                }
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AltaPedido ap = new AltaPedido();
            ap.Producto = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_DESC"]));
            ap.Ide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_IDE"]));
            ap.colocarnombre();
            ap.CodigoViejo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_CODIGOVIEJO"]));
            ap.Pedidos = 1;
            ap.Cantidad = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["cantidad"]));
            ap.colocarcantidad();
            ap.Alta = 1;
            
            if (ap.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gridViewPintarFilas.SetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["valor"], 1);
                //gConsulta.DataSource = cli.Mostrar_clientes();
                //gConsulta.DataSource = pro.Mostrar_productos();
                // this.cargar();
            }
        }

        private void lbcantidadreserva_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void lbpedidos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void rBlibros_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
