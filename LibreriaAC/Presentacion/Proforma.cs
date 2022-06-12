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
    public partial class Proforma : Form
    {

        string _codigo, _nombre,_direccion,_telefono,_cuit;
        int _ide;
        Pedidos pe = new Pedidos();
        //DataGridView dgvproductos;
        Productos pro = new Productos();
        Venta ven = new Venta();
        public Proforma()
        {
            InitializeComponent();
        }

        private void ConsultasConsignas_Load(object sender, EventArgs e)
        {
            gConsulta.DataSource = ven.Mostrar_paraproforma();
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

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public string Direccion
        {
            get { return this._direccion; }
            set { this._direccion = value; }
        }

        public string Telefono
        {
            get { return this._telefono; }
            set { this._telefono = value; }
        }
        public string Cuit
        {
            get { return this._cuit; }
            set { this._cuit = value; }
        }

        public int Ide
        {
            get { return this._ide; }
            set { this._ide = value; }
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
            string fecha, nombre, dire, telefono, cuit, proformanro;
            //DateTime fec = Convert.ToDateTime(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["PED_FECHA"]));
            DateTime fecha1 = DateTime.Now;
            fecha = "Proforma realizada el : " + fecha1;
            nombre = "Señores: " + ven.Vennombre;
            dire = "Domicilio: " + ven.Vendireccion;
            telefono = "Teléfono: " + ven.telefono;
            cuit = "CUIT: " + ven.Vencuit;
            proformanro = "Proforma número: " + ven.proformaide;
            string pro = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["proveedor"]));
            string proveedor = "Fagnano 195 - lolasdbacsantacruz.com.ar ";
            TextBrick brick3 = e.Graph.DrawString("DISTRIBUIDORA AC. SANTA CRUZ", Color.Black,
            new RectangleF(0, 10, 720, 30), DevExpress.XtraPrinting.BorderSide.None);
            brick3.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
            TextBrick brick4 = e.Graph.DrawString(proveedor, Color.Black,
            new RectangleF(0, 35, 900, 30), DevExpress.XtraPrinting.BorderSide.None);

            TextBrick brick2 = e.Graph.DrawString(fecha, Color.Black,
            new RectangleF(0, 55, 620, 20), DevExpress.XtraPrinting.BorderSide.None);
            brick2.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular);

            TextBrick brick5 = e.Graph.DrawString(nombre, Color.Black,
            new RectangleF(0, 80, 620, 20), DevExpress.XtraPrinting.BorderSide.None);
            brick5.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);

            TextBrick brick6 = e.Graph.DrawString(dire, Color.Black,
            new RectangleF(0, 105, 620, 20), DevExpress.XtraPrinting.BorderSide.None);
            brick6.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);

            TextBrick brick7 = e.Graph.DrawString(telefono, Color.Black,
            new RectangleF(0, 130, 620, 20), DevExpress.XtraPrinting.BorderSide.None);
            brick7.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);

            TextBrick brick8 = e.Graph.DrawString(cuit, Color.Black,
            new RectangleF(0, 160, 620, 20), DevExpress.XtraPrinting.BorderSide.None);
            brick8.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);

            TextBrick brick9 = e.Graph.DrawString(proformanro, Color.Black,
            new RectangleF(0, 185, 620, 20), DevExpress.XtraPrinting.BorderSide.None);
            brick9.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);

            TextBrick brick10 = e.Graph.DrawString("Observación:" + txtobs.Text, Color.Red,
            new RectangleF(0, 210, 620, 100),DevExpress.XtraPrinting.BorderSide.None);
            brick10.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            ven.Vennombre = txtnombre.Text;
            ven.proformaide = this.Ide;
            ven.Vendireccion = txtdomicilio.Text;
            ven.telefono = txttelefono.Text;
            ven.Vencuit = txtcuit.Text;
            ven.Obs = txtobs.Text;
            ven.ventipofactura = lbtipo.Text;
            int valor = ven.spModificaProforma();

            PrintableComponentLink pl = new PrintableComponentLink(new PrintingSystem());
            pl.Component = gConsulta;
            pl.CreateMarginalHeaderArea += new CreateAreaEventHandler(pl_CreateReportHeaderArea);
            pl.CreateReportHeaderArea += new CreateAreaEventHandler(pl_CreateReportHeaderArea2);
            pl.PaperKind = System.Drawing.Printing.PaperKind.A4;
            pl.Margins = new System.Drawing.Printing.Margins(20, 20, 20, 20);
            pl.Landscape = false;
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
        public void Colocardatos(Proforma proforma)
        {
            txtnombre.Text = proforma.Nombre;
            txtdomicilio.Text = proforma.Direccion;
            txttelefono.Text = proforma.Telefono;
            txtcuit.Text = proforma.Cuit;
        }
        public void recorrergrilla()
        {
            // DataColumn column;
            // DataRow row;

            //  this.dgvproductos = dgvProductos1;
            ven.proformaide = this.Ide;
            
        }

        public void cargardatoscliente(string nombre,string cuit, string dire,string tipo)
        {
            txtnombre.Text = nombre;
            txtdomicilio.Text = dire;
            txtcuit.Text = cuit;
            lbtipo.Text = tipo;
        }
        private void cargardatos()
        {
           
            pe.Codigo = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["PED_IDE"]));


            gConsulta.DataSource = pe.Mostrar_pedidosdetalle();
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
    }
}
