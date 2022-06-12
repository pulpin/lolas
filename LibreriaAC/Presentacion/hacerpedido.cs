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
    public partial class hacerpedido : Form
    {
        string _codigo;
        Reservas re = new Reservas();
        Venta ven = new Venta();
        Productos pro = new Productos();
        
        public hacerpedido()
        {
            InitializeComponent();
        }

        private void ConsultasConsignas_Load(object sender, EventArgs e)
        {
            
            this.cargar();

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
            fecha = "Pedido realizado el : " + DateTime.Now;
            string proveedor = "Proveedor: "+ lUEproveedor.Text;
            TextBrick brick3 = e.Graph.DrawString("DISTRIBUIDORA AC. SANTA CRUZ", Color.Black,
            new RectangleF(0, 10, 720, 30), DevExpress.XtraPrinting.BorderSide.None);
            brick3.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
            TextBrick brick4 = e.Graph.DrawString(proveedor, Color.Black,
            new RectangleF(0, 35, 900, 30), DevExpress.XtraPrinting.BorderSide.None);

            TextBrick brick2 = e.Graph.DrawString(fecha, Color.Black,
           new RectangleF(0, 55, 620, 20), DevExpress.XtraPrinting.BorderSide.None);
            brick2.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold);

        }

        private void recorreryeliminarpedidos()
        {
            
            if (Convert.ToInt32(lUEproveedor.EditValue) > 0)
            {
                pro.Proveeide = Convert.ToInt32(lUEproveedor.EditValue);
                int resultado = pro.spInsertarPedidoMaestro();
                if (resultado == 0)
                {

                    MessageBox.Show("Se ha producido un error!");
                }
                else
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }

                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    pro.Cantidad = Convert.ToInt32(this.gridView1.GetRowCellValue(i, this.gridView1.Columns["LI_PEDIDOS"]));
                    pro.productoide = Convert.ToInt32(this.gridView1.GetRowCellValue(i, this.gridView1.Columns["LI_IDE"]));
                    pro.Proveeide = resultado;
                    //MessageBox.Show(Convert.ToString(liide));
                    int resultado2 = pro.spInsertarPedidoDetalle();
                    if (resultado2 != 0)
                    {
                        MessageBox.Show("Error al generar el pedido.");
                    }
                }
                this.mandaaimprimir();
            }
            else
            {
                MessageBox.Show("Debe seleccionar el proveedor para el pedido.");
            }
        }
        private void mandaaimprimir()
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
        private void btneliminar_Click(object sender, EventArgs e)
        {
            this.recorreryeliminarpedidos();
           
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
        private void cargar()
        {


            LogicaNegocios.Venta ve = new LogicaNegocios.Venta();
            Proveedor prove = new Proveedor();
            if (rBlibros.Checked == true)
            {
                prove.EsLibro = 1;
            }
            else
            {
                prove.EsLibro = 0;
            }

            gConsulta.DataSource = re.Mostrar_pedidos(prove.EsLibro);
           
            
            lUEproveedor.Properties.DisplayMember = "PROV_DESC";
            lUEproveedor.Properties.ValueMember = "PROV_IDE";
            lUEproveedor.Properties.DataSource = prove.Tabladedatos_proveedores();
            lUEproveedor.Properties.PopulateColumns();
            lUEproveedor.Properties.Columns[0].Visible = false;
            lUEproveedor.Properties.Columns[2].Visible = false;


        }
        private void button1_Click(object sender, EventArgs e)
        {
            //this.cargar();
            AltaPedido ap = new AltaPedido();
            ap.Producto = Convert.ToString(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["LI_DESC"]));
            ap.colocarnombre();
            ap.Ide = Convert.ToInt32(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["LI_IDE"]));
            ap.Alta = 0;
            if (ap.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.recorrergrilla();
            }

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
           // this.Codigo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["RESE_LI_CODIGOVIEJO"]));
           // ven.venproductoide = this.Codigo;
           
           // gConsulta1.DataSource = ven.Mostrar_movimientosdeproductos();
        }
        private void gConsulta_Click(object sender, EventArgs e)
        {

        }
        private void recorrergrilla()
        {
            int entra = 0, vacio = 0;
            string editorialesa = string.Empty;
            editorialesa = "(";
            for (int i = 0; i < gridViewPintarFilas.DataRowCount; i++)
            {
                if (gridViewPintarFilas.IsRowSelected(i))
                {
                    vacio = 1;
                    if (entra == 0)
                    {
                        editorialesa = "( li.LI_EDI_CODIGO = " + Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(i, this.gridViewPintarFilas.Columns["EDI_CODIGO"]));
                        entra = 1;
                    }
                    else
                    {
                        editorialesa = editorialesa + " or li.LI_EDI_CODIGO = " + Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(i, this.gridViewPintarFilas.Columns["EDI_CODIGO"]));
                    }

                }

                /* string algo1 = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(i, this.gridViewPintarFilas.Columns[2]));
                 if (gridViewPintarFilas.GetRowCellValue(i, "EDI_CODIGO").ToString() == "A")
                 {
                     //  Your code here  
                 }*/
            }
            editorialesa = editorialesa + ")";

            if (vacio == 0)
            {
                MessageBox.Show("Debe seleccionar alguna editorial");
            }
            else
            {
                gConsulta1.DataSource = re.Mostrar_pedidosporeditorial(editorialesa);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.recorrergrilla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void rBlibros_CheckedChanged(object sender, EventArgs e)
        {
            this.cargar();
        }

        private void rBlolasdb_CheckedChanged(object sender, EventArgs e)
        {
            this.cargar();
        }
    }
}
