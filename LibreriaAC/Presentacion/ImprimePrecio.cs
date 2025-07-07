using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocios;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;
using System.Threading;
using DevExpress.XtraPrinting;

namespace Presentacion
{
    public partial class ImprimePrecio : Form, IFormImprime, IClientes
    {


        /* Globa variable */
        private bool _WorkThreadRunning = false;



        double totalg, valorcondescuento, totalanterior,ivacondescuento,importeivacondescuento;
        double vivavalor21, vivaimporte21, vivavalor105, vivaimporte105,vivaexcento;
        decimal pvenimp21, pveniva21, pvenimp10, pveniva10;
        //para cargar pedidos
        string pcantidadelegida,pcodigo, pnombre, peditorialu,ppreciou, psubtotal, ppreciouc,psubtotalc, pivavalor, pimportedeliva, piva, ppivavalor, ppimportedeliva, ppivavalor10, ppimportedeliva10,
pnombrecli, pcuit, pdire, ptipo;
        string ptipofactu, ptipopag;
        int ptipopagide, ptipopagideNuevo, retornar,pusuariopedidoide, pventemporalaborrar = 0;
        double pventotal,pexento;
       // string nroticket;
        public static int clientecuentacorriente;
        int _tipopago, _ultimavta,nopedirclienteA = 0;

        private void salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
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
            string nombre, nombre2, nombre3, planilla;
            // fecha = "fecha: " + DateTime.Now;
            nombre = lbbarra1.Text;
            nombre2 = lbcodigo1.Text;
            nombre3 = lbdesc1.Text;
            planilla = lbprecio1.Text;
            // edi = "Señores:  ";
            // dom = "Domicilio: ";
            //  tel = "teléfono: ";
            TextBrick brick1 = e.Graph.DrawString(nombre, Color.Black,
            new RectangleF(1, 2, 620, 20), DevExpress.XtraPrinting.BorderSide.None);
            TextBrick brick2 = e.Graph.DrawString(nombre2, Color.Black,
            new RectangleF(0, 25, 900, 40), DevExpress.XtraPrinting.BorderSide.None);
            TextBrick brick3 = e.Graph.DrawString(nombre3, Color.Black,
            new RectangleF(0, 50, 900, 40), DevExpress.XtraPrinting.BorderSide.None);
            TextBrick brick12 = e.Graph.DrawString(planilla, Color.Blue,
             new RectangleF(0, 95, 900, 40), DevExpress.XtraPrinting.BorderSide.None);
            
             
            // TextBrick brick5 = e.Graph.DrawString(dom, Color.Black,
            // new RectangleF(0, 95, 900, 40), DevExpress.XtraPrinting.BorderSide.None);
            //  TextBrick brick6 = e.Graph.DrawString(tel, Color.Black,
            // new RectangleF(0, 110, 900, 40), DevExpress.XtraPrinting.BorderSide.None);
            
            
            //TextBrick brick8 = e.Graph.DrawString("Domicilio: "+domi+" "+dominro, Color.Black,
            //new RectangleF(0, 150, 900, 40), DevExpress.XtraPrinting.BorderSide.None);
            /*TextBrick brick9 = e.Graph.DrawString("Subtotal: "+lbtotal.Text, Color.Red,
            new RectangleF(0, 190, 900, 40), DevExpress.XtraPrinting.BorderSide.None);
            TextBrick brick10 = e.Graph.DrawString("Porcentaje: "+lbporcentaje.Text, Color.Red,
            new RectangleF(0, 210, 900, 40), DevExpress.XtraPrinting.BorderSide.None);
            TextBrick brick11 = e.Graph.DrawString("Total a Rendir: "+lbtotalg.Text, Color.Red,
            new RectangleF(0, 230, 900, 40), DevExpress.XtraPrinting.BorderSide.None);
            */
            //  TextBrick brick2 = e.Graph.DrawString(fecha, Color.Black,
            //  new RectangleF(0, 0, 820, 40), DevExpress.XtraPrinting.BorderSide.None);
            //brick2.HorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            //   brick1.HorzAlignment = HorzAlignment.Center;
            brick1.Font = new Font(FontFamily.GenericSansSerif, 16, FontStyle.Bold);
            brick2.Font = new Font(FontFamily.GenericSansSerif, 16, FontStyle.Bold);
            brick3.Font = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold);
            
            // brick5.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
            // brick6.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
            
            // brick8.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
            /* brick9.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
             brick10.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
             brick11.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);*/
            brick12.Font = new Font(FontFamily.GenericSansSerif, 16, FontStyle.Bold);

        }
        public void pl_CreateMarginalFooterArea(object sender, CreateAreaEventArgs e)
        {
            string desti = "Listado de derivaciones por Anexo/Item: ";
            TextBrick brick1 = e.Graph.DrawString(desti, Color.Black,
               new RectangleF(0, 0, 620, 20), DevExpress.XtraPrinting.BorderSide.None);
            brick1.HorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            brick1.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);

        }
        public void pl_CreateMarginalFooterArea2(object sender, CreateAreaEventArgs e)
        {
            string desti = "Listado de derivaciones por Anexo/Item: ";
            TextBrick brick1 = e.Graph.DrawString(desti, Color.Black,
               new RectangleF(0, 0, 620, 20), DevExpress.XtraPrinting.BorderSide.None);
            brick1.HorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            brick1.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);

        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            /*PrintableComponentLink pl = new PrintableComponentLink(new PrintingSystem());
            
            pl.Component = gConsulta;
            pl.CreateMarginalHeaderArea += new CreateAreaEventHandler(pl_CreateReportHeaderArea);
            pl.CreateReportHeaderArea += new CreateAreaEventHandler(pl_CreateReportHeaderArea2);
            pl.PaperKind = System.Drawing.Printing.PaperKind.A4;
            pl.Margins = new System.Drawing.Printing.Margins(20, 20, 20, 20);
            pl.Landscape = true;
            pl.CreateDocument();

            // gridViewPintarFilas.OptionsView.ShowFooter = true;
            
            //pl.CreateMarginalFooterArea += new CreateAreaEventHandler(pl_CreateMarginalFooterArea);
            //pl.CreateReportFooterArea += new CreateAreaEventHandler(pl_CreateMarginalFooterArea2);
            // pl. = "algo";

            
            pl.ShowPreview();*/
            btnagregap.Visible = false;
            btneliminar.Visible = false;
            salir.Visible = false;
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirForm);
            
            Margins margins = new Margins(10, 10, 10, 10);
            pd.DefaultPageSettings.Margins = margins;
            //pd.DefaultPageSettings.Landscape = true;
            pd.Print();
            this.Dispose();
            this.Hide();
        }

        void ImprimirForm(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }

        object[] rowsenviar;
        Venta vta;
        //private static IFUniversal.ModeloPrn MODELO = IFUniversal.ModeloPrn.modEpsonTMT900FA;
        //private static int PUERTO = 0;
        public ImprimePrecio()
        {
            InitializeComponent();
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void Facturar_Load(object sender, EventArgs e)
        {
            

            InitializeDataGridView();


        }


        private void InitializeDataGridView()
        {
            // Create an unbound DataGridView by declaring a column count.
            
        }

        private void btnagregap_Click(object sender, EventArgs e)
        {
            ConsultaProductosAgregaI cpa = new ConsultaProductosAgregaI();
            
            cpa.ShowDialog(this);
        }
        private void button2_Click(object sender, EventArgs e)
        {
          /*  Boolean respuesta;
            string x = "X";
            string p = "P";
            respuesta = this.axPrinterFiscal1.CloseJournal(ref x, ref p);
            */
        }

        

       

        private void LUComprobante_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btneliminaele_Click(object sender, EventArgs e)
        {
            
        }

        private void btndebito_Click(object sender, EventArgs e)
        {
            //            btndebito.ContextMenuStrip = contextMenuStrip1;
            
        }

        

       

        private void btncredito_Click(object sender, EventArgs e)
        {
            
        }

        private void btncuotas_Click(object sender, EventArgs e)
        {
          
        }

      
        private void button3_Click(object sender, EventArgs e)
        {
           

        }

        private void btnajuste_Click(object sender, EventArgs e)
        {
            ConsultaAjustes ca = new ConsultaAjustes();
            ca.Show();
        }

       


      

        private void button5_Click(object sender, EventArgs e)
        {
  
        }

       

        private void btnplatacaja_Click(object sender, EventArgs e)
        {
            ConsultaPlataCaja cpc = new ConsultaPlataCaja();
            cpc.ShowDialog();
        }

       

       

        private void button5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btncargapedido_Click(object sender, EventArgs e)
        {
            ConsultasPedidosVta cpv = new ConsultasPedidosVta();
            cpv.ShowDialog();
        }


       

        
        private void resetearloscontroles()
        {

        }

       

       
        private void btnagregar_Click(object sender, EventArgs e)
        {
            /* foreach (DataGridViewRow row in dgvProductos.Rows)
             {
                 double valorantiguo = Convert.ToDouble(row.Cells[6].Value);
                 row.Cells[4].Value = valorantiguo;

                 double valorantiguo1 = Convert.ToDouble(row.Cells[7].Value);
                 row.Cells[5].Value = valorantiguo1;

             }*/
            ConsultaCliente cc = new ConsultaCliente();
            cc.ShowDialog(this);
        }

        private void txtdescuento_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
           
        }

       

       


       
        private void txtnumeropedido_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            
            
        }

        private void txtproforma_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {


           
        }

        

       





        


        
        public void selecciondecliente(string cuit, string nombre, string dire, string tipo, string tipoletra, int cliide)
        {
           
          
        }

        public void AgregarProducto(object[] rows, double subtotalg, double valoriv, double importeiv, double niva, int cantidadeleg, string barra)
        {
            
            // vivavalor = vivavalor + valoriv;
            // vivaimporte = vivaimporte + importeiv;

            lbbarra1.Text = barra;

            
        }

        public void AgregarProducto(object[] rows, double subtotalg, double valoriv, double importeiv, double niva, int cantidadeleg)
        {
            throw new NotImplementedException();
        }

        public void AgregarProducto(string barra, string codigo, string desc, string precio)
        {
            if (lbbarra1.Text == string.Empty)
            {
                lbbarra1.Text = barra;
                lbcodigo1.Text = codigo;
                lbdesc1.Text = desc;
                lbprecio1.Text = precio;
                panelControl1.Visible = true;
            }
            else if (lbbarra2.Text == string.Empty)
            {
                lbbarra2.Text = barra;
                lbcodigo2.Text = codigo;
                lbdesc2.Text = desc;
                lbprecio2.Text = precio;
                panelControl2.Visible = true;
            }
            else if (lbbarra3.Text == string.Empty)
            {
                lbbarra3.Text = barra;
                lbcodigo3.Text = codigo;
                lbdesc3.Text = desc;
                lbprecio3.Text = precio;
                panelControl3.Visible = true;
            }
            else if (lbbarra4.Text == string.Empty)
            {
                lbbarra4.Text = barra;
                lbcodigo4.Text = codigo;
                lbdesc4.Text = desc;
                lbprecio4.Text = precio;
                panelControl4.Visible = true;
            }
            else if (lbbarra5.Text == string.Empty)
            {
                lbbarra5.Text = barra;
                lbcodigo5.Text = codigo;
                lbdesc5.Text = desc;
                lbprecio5.Text = precio;
                panelControl5.Visible = true;
            }
            else if (lbbarra6.Text == string.Empty)
            {
                lbbarra6.Text = barra;
                lbcodigo6.Text = codigo;
                lbdesc6.Text = desc;
                lbprecio6.Text = precio;
                panelControl6.Visible = true;
            }
            else if (lbbarra7.Text == string.Empty)
            {
                lbbarra7.Text = barra;
                lbcodigo7.Text = codigo;
                lbdesc7.Text = desc;
                lbprecio7.Text = precio;
                panelControl7.Visible = true;
            }
            else if (lbbarra8.Text == string.Empty)
            {
                lbbarra8.Text = barra;
                lbcodigo8.Text = codigo;
                lbdesc8.Text = desc;
                lbprecio8.Text = precio;
                panelControl8.Visible = true;
            }
            else if (lbbarra9.Text == string.Empty)
            {
                lbbarra9.Text = barra;
                lbcodigo9.Text = codigo;
                lbdesc9.Text = desc;
                lbprecio9.Text = precio;
                panelControl9.Visible = true;
            }
            else if (lbbarra10.Text == string.Empty)
            {
                lbbarra10.Text = barra;
                lbcodigo10.Text = codigo;
                lbdesc10.Text = desc;
                lbprecio10.Text = precio;
                panelControl10.Visible = true;
            }
            else if (lbbarra11.Text == string.Empty)
            {
                lbbarra11.Text = barra;
                lbcodigo11.Text = codigo;
                lbdesc11.Text = desc;
                lbprecio11.Text = precio;
                panelControl11.Visible = true;
            }
            else if (lbbarra12.Text == string.Empty)
            {
                lbbarra12.Text = barra;
                lbcodigo12.Text = codigo;
                lbdesc12.Text = desc;
                lbprecio12.Text = precio;
                panelControl12.Visible = true;
            }
            else if (lbbarra13.Text == string.Empty)
            {
                lbbarra13.Text = barra;
                lbcodigo13.Text = codigo;
                lbdesc13.Text = desc;
                lbprecio13.Text = precio;
                panelControl13.Visible = true;
            }
            else if (lbbarra14.Text == string.Empty)
            {
                lbbarra14.Text = barra;
                lbcodigo14.Text = codigo;
                lbdesc14.Text = desc;
                lbprecio14.Text = precio;
                panelControl14.Visible = true;
            }
            else if (lbbarra15.Text == string.Empty)
            {
                lbbarra15.Text = barra;
                lbcodigo15.Text = codigo;
                lbdesc15.Text = desc;
                lbprecio15.Text = precio;
                panelControl15.Visible = true;
            }
        }

        public int Tipopago
        {
            get { return this._tipopago; }
            set { this._tipopago = value; }
        }

        public int Ultimavta
        {
            get { return this._ultimavta; }
            set { this._ultimavta = value; }
        }
    }
}
