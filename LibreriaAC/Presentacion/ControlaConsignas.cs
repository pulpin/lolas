using DevExpress.XtraPrinting;
using LogicaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class ControlaConsignas : Form
    {
        string _codigo, _barra;
        int _editorialide;
        //Reservas re = new Reservas();
        //Venta ven = new Venta();
        Productos pro = new Productos();
        Consignas con = new Consignas();
        Devolucion dev = new Devolucion();
        Rendiciones ren = new Rendiciones();
        public ControlaConsignas()
        {
            InitializeComponent();
        }

        private void ConsultasConsignas_Load(object sender, EventArgs e)
        {
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
        public string Barra
        {
            get { return this._barra; }
            set { this._barra = value; }
        }
        public int Editorialide
        {
            get { return this._editorialide; }
            set { this._editorialide = value; }
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

           // int todos;
            LogicaNegocios.Venta ve = new LogicaNegocios.Venta();

            
            

            //gConsulta.DataSource = re.Mostrar_Reservasporfecha(fdesdee, fhastae);

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
            this.Editorialide = Convert.ToInt32(lUEditorial.EditValue);
            this.Barra = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["isbn"]));
            //MessageBox.Show(Convert.ToString(this.Editorialide));
            //MessageBox.Show(this.Barra);
            pro.spConsultaCodigoPorBarra(this.Barra);
            this.Codigo = pro.Codigo;
            con.Codigo = this.Codigo;
            con.Codigoeditorial = this.Editorialide;
            gConsulta1.DataSource = con.Mostrar_consignasporproducto();
            dev.Codigo = this.Codigo;
            dev.CodigoEditorial = this.Editorialide;
            gConsulta2.DataSource = dev.Mostrar_devoluciones();
            lbsockactual.Text = Convert.ToString(pro.spConsultastockactual());
            ren.Codigo = this.Codigo;
            ren.editorialide = this.Editorialide;
            gConsulta3.DataSource = ren.Mostrar_rendicionporproducto();
            //gConsulta1.DataSource = ven.Mostrar_movimientosdeproductos();
        }
        private void gConsulta_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
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
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string extension, constr = string.Empty;
            extension = Path.GetExtension(ruta.Text);

            if (extension == ".xlsx")
            {
                constr = "Provider = MicroSoft.ACE.OLEDB.12.0; Data Source=" + ruta.Text + "; Extended Properties =\"Excel 12.0 Xml; HDR=Yes;IMEX=1\";";
            }
            else if (extension == ".xls")
            {
                constr = "Provider = MicroSoft.Jet.OLEDB.4.0; Data Source=" + ruta.Text + "; Extended Properties =\"Excel 8.0; HDR=Yes;\";";
            }
            else
            {
                MessageBox.Show("No se reconoce el tipo de formato del archivo. Debe ser Excel");
            }
            //

            // string constr = "Provider = Microsoft.ACE.OLEDB.12.0; Extended Properties='Excel 12.0 Xml;HDR=Yes;IMEX=1';";
            OleDbConnection con = new OleDbConnection(constr);
            OleDbDataAdapter sda = new OleDbDataAdapter("Select * From [" + textBox2.Text + "$]", con);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            gConsulta.DataSource = dt;

        }

        private void btnabrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = " Archivos Excel (*.xlsx)|*.xlsx|Archivos Excel (*.xls)|*.xls";
            open.Title = "archivos Excel";
            if (open.ShowDialog() == DialogResult.OK)
            {
                ruta.Text = open.FileName;
            }
        }
    }
}
