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

namespace Presentacion
{
    public partial class Facturar : Form, IForm, ICobrar, IClientes
    {
        /* -----------------------------------------------------------------------------
Typedef from exported Prototypes of "EpsonFiscalInterface.h"
----------------------------------------------------------------------------- */
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                    CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int AbrirComprobante(int tipocomrobante);
        // ConfigurarVelocidad()
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]

        public static extern int CargarDatosCliente(string nombre, string nombre2, string domicilio1, string domicilio2, string domicilio3, int id_tipodocumento, string numero_documento, int id_responsableiva);
        // ConfigurarVelocidad()
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                    CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]

        public static extern int ImprimirItem(int id_modificador, string descripcion, string cantidad, string precio, int id_tasa_iva, int ii_id, string ii_valor, int id_codigo, string codigo, string codigo_unidad_matrix, int codigo_unidad_medida);
        // ConfigurarVelocidad()
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]

        public static extern int CargarComprobanteAsociado(string descripcion);
        // ConfigurarVelocidad()
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]

        public static extern int ImprimirSubtotal();
        // ConfigurarVelocidad()
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]

        public static extern int CargarPago(int id_modificador, int codigo_formato_pago, int cantidad_cuotas, string monto, string descripcion_cupones, string descripcion, string descripcion_extra1, string descripcion_extra2);
        // ConfigurarVelocidad()
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]


        public static extern int CerrarComprobante();
        // ConfigurarVelocidad()
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]


        public static extern int ConfigurarVelocidad(int velocidad);

        // ConfigurarPuerto()
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int ConfigurarPuerto(string puerto);

        // Conectar()
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int Conectar();

        // Desconectar()
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int Desconectar();

        // Conectar()
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int ReConectar();

        // Consultar()
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int ConsultarVersionDll(StringBuilder descripcion, int descripcion_largo_maximo, ref int mayor, ref int menor);

        // ImprimirCierreX() 
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int ImprimirCierreX();

        // ImprimirCierreZ() 
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                               CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int ImprimirCierreZ();

        // DescargarPeriodoPendiente
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                           CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int DescargarPeriodoPendiente(string directorio_de_descarga);


        // EnviarComando
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                       CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int EnviarComando(string comando);


        // ComenzarLog
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                       CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int ComenzarLog(bool incluir_tramas);


        // DetenerLog
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                       CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int DetenerLog();


        // PausarLog
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                       CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int PausarLog();


        // ReanudarLog
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                       CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int ReanudarLog();

        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                      CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int ConsultarNumeroPuntoDeVenta(StringBuilder respuesta, int respuesta_largo_maximo);
        /*ver si esta bien el StringBuilder o sólo String */
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                             CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int ConsultarNumeroComprobanteUltimo(string tipo_de_comprobante, StringBuilder respuesta, int respuesta_largo_maximo);


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
        object[] rowsenviar;
        Venta vta;
        //private static IFUniversal.ModeloPrn MODELO = IFUniversal.ModeloPrn.modEpsonTMT900FA;
        //private static int PUERTO = 0;
        public Facturar()
        {
            InitializeComponent();
            this.puedeimprimir();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void Facturar_Load(object sender, EventArgs e)
        {
            List<Comprobantes> comprobante = new List<Comprobantes>();

            comprobante.Add(new Comprobantes() { ComprobantesNombre = "Tickets", ComprobantesIde = 1});
            comprobante.Add(new Comprobantes() { ComprobantesNombre = "Factura A", ComprobantesIde = 2 });
            comprobante.Add(new Comprobantes() { ComprobantesNombre = "Factura B", ComprobantesIde = 3 });


            LUComprobante.Properties.DisplayMember = "ComprobantesNombre";
            LUComprobante.Properties.ValueMember = "ComprobantesIde";
            LUComprobante.Properties.DataSource = comprobante;

            LUComprobante.Properties.PopulateColumns();
            LUComprobante.Properties.Columns[1].Visible = false;

            LUComprobante.EditValue = 1;

            lbfecha.Text = DateTime.Now.ToShortDateString();

            InitializeDataGridView();


        }


        private void InitializeDataGridView()
        {
            // Create an unbound DataGridView by declaring a column count.
            dgvProductos.ColumnCount = 15;
            dgvProductos.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dgvProductos.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Set the column header names.
            dgvProductos.Columns[0].Name = "Cantidad";
            dgvProductos.Columns[1].Name = "Código";
            dgvProductos.Columns[2].Name = "Producto";
            dgvProductos.Columns[3].Name = "Editorial";
            dgvProductos.Columns[4].Name = "Precio Unitario";
            dgvProductos.Columns[5].Name = "Subtotal";
            dgvProductos.Columns[6].Name = "Preciouc";
            dgvProductos.Columns[7].Name = "Subtotalc";
            dgvProductos.Columns[8].Name = "valoriva";
            dgvProductos.Columns[9].Name = "importeiva";
            dgvProductos.Columns[10].Name = "iva";
            dgvProductos.Columns[11].Name = "valorivac";
            dgvProductos.Columns[12].Name = "importeivac";
            dgvProductos.Columns[13].Name = "preciu2";
            dgvProductos.Columns[14].Name = "subtotal2";

            dgvProductos.Columns[0].Width = 70;
            dgvProductos.Columns[0].DefaultCellStyle.Alignment =
        DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.Columns[1].DefaultCellStyle.Alignment =
       DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.Columns[2].Width = 300;
            dgvProductos.Columns[3].Width = 190;
            dgvProductos.Columns[4].Width = 100;
            dgvProductos.Columns[4].DefaultCellStyle.Alignment =
        DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.Columns[5].DefaultCellStyle.Alignment =
        DataGridViewContentAlignment.MiddleCenter;

            //  dgvProductos.Columns[6].Visible = false;
            //  dgvProductos.Columns[7].Visible = false;
            if ((Globales.accessoventacredito == 1)|| (Globales.accessoventacredito == 2))
            {
                btncreditop.Enabled = true;
            }
        }

        private void btnagregap_Click(object sender, EventArgs e)
        {
            ConsultaProductosAgrega cpa = new ConsultaProductosAgrega();
            
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

        private void imprimirticket()
        {

           // Boolean respuesta;
           // string x = "X";
           // string p = "P";
           /* string cantiarti = "Cant. Articulos: 1";
            string atendido = "Vendedor: Hugo";
            string controlinterno = "Codigo interno: 1546";

            string argumento = "G";*/
         //   respuesta = this.axPrinterFiscal1.OpenTicket(ref argumento);

           // string estado = "C";
           // respuesta = this.axPrinterFiscal1.Status(ref estado);

           /* string establece = "S";
            string linea11 = "11";
            string linea12 = "12";
            string linea13 = "13";*/

          /*  this.axPrinterFiscal1.SetGetHeaderTrailer(ref establece, ref linea11, ref controlinterno);
            this.axPrinterFiscal1.SetGetHeaderTrailer(ref establece, ref linea12, ref atendido);
            this.axPrinterFiscal1.SetGetHeaderTrailer(ref establece, ref linea13, ref cantiarti);
            */
          /*  string articulo = "Mochila negra palo";
            string cantidad = Convert.ToString(1 * 1000);
            string precioUnitario = Convert.ToString(1 * 100);
            //   string iva = Convert.ToString(21 * 100);
            string iva = "2100";
            string venta = "M";
            string bultos = "0";
            string ImpuestosInternos = "0";

            string printer = "P";
            string texto = "SUB";

            string pago = "Efectivo";
            string importeabona = Convert.ToString(1 * 100);
            string descripcion = "T";
            */
        /*    this.axPrinterFiscal1.SendTicketItem(ref articulo, ref cantidad, ref precioUnitario, ref iva, ref venta, ref bultos, ref ImpuestosInternos);

            this.axPrinterFiscal1.GetTicketSubtotal(ref printer, ref texto);

            this.axPrinterFiscal1.SendTicketPayment(ref pago, ref importeabona, ref descripcion);

            this.axPrinterFiscal1.CloseTicket();

            this.nroticket = this.axPrinterFiscal1.AnswerField_3;*/
           // MessageBox.Show("el número del ticket es:" + nroticket);
           // puntodevta = this.axPrinterFiscal1.AnswerField_4;
           // MessageBox.Show("punto de venta:" + puntodevta);
        }

        private void imprimirticketNueva()
        {
            int tipocomprobante = 1, id_modificador = 200; //1 es ticket 200 agregar venta
            string productodesc = string.Empty; //descripción del producto
            string cantidad, precio, iva, codigointerno;
            double preciod;
            const int ERROR_NINGUNO = 0;
            int error, tasaiva,tipodepago=0,cuotas=1;

           // cantidad = Convert.ToString(1 * 1000);
           // precio = Convert.ToString(201 * 1000);
            ConfigurarVelocidad(9600);
            ConfigurarPuerto("0"); //USB
            error = Conectar();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al conectar: " + error.ToString());
            }
            AbrirComprobante(tipocomprobante); //1 es ticket, ver tabla
            error = Desconectar();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al desconectar impresora: " + error.ToString());
            }

            //Tipo de pago
            if (ptipopagide == 1)
            {
                tipodepago = 8;
                cuotas = 1;
            }
            else if (ptipopagide == 2 || ptipopagide == 3)
            {
                tipodepago = 21;
                cuotas = 1;
            }
            else if (ptipopagide == 4 || ptipopagide == 5 || ptipopagide == 6 || ptipopagide == 8 || ptipopagide == 9 )
            {
                tipodepago = 20;
                cuotas = 1;
            }
            else if (ptipopagide == 7) //Plan z
            {
                tipodepago = 20;
                cuotas = 11;
            }
            else if (ptipopagide == 10) //2 cuotas
            {
                tipodepago = 20;
                cuotas = 2;
            }
            else if (ptipopagide == 11) //3 cuotas
            {
                tipodepago = 20;
                cuotas = 3;
            }
            else if (ptipopagide == 14) //12 cuotas
            {
                tipodepago = 20;
                cuotas = 12;
            }
            else if(ptipopagide == 15) //6 cuotas
            {
                tipodepago = 20;
                cuotas = 6;
            }
            else if (ptipopagide == 16) //ahora 3
            {
                tipodepago = 20;
                cuotas = 3;
            }
            else if (ptipopagide == 17) //ahora 6
            {
                tipodepago = 20;
                cuotas = 3;
            }

            foreach (DataGridViewRow row in dgvProductos.Rows)
            {

                productodesc = Convert.ToString(row.Cells[2].Value);
                cantidad = Convert.ToString(row.Cells[0].Value);
                preciod = Convert.ToDouble(row.Cells[4].Value);
                precio = string.Format("{0:N4}", preciod);
                //precio = Convert.ToString(preciod);
                precio = precio.Replace(".", String.Empty);
                precio = precio.Replace(',', '.');
                iva = Convert.ToString(row.Cells[10].Value);
                codigointerno = Convert.ToString(row.Cells[1].Value);

                if (iva == "21" || iva == "21.00" || iva == "21,00")
                {
                    tasaiva = 5;
                }
                else if (iva == "0" || iva=="0.00" || iva == "0,00")
                {
                    tasaiva = 1;
                }
                else
                {
                    tasaiva = 4;
                }
                //productodesc = MySql.Data.MySqlClient.MySqlHelper.EscapeString(productodesc);
                //productodesc = Rege

                error = Conectar();
                if (error != ERROR_NINGUNO)
                {
                    MessageBox.Show("Error al conectar: " + error.ToString());
                }
                error = ImprimirItem(id_modificador, productodesc, cantidad,precio, tasaiva, 0, "", 1, codigointerno, "", 7);
                //error = ImprimirItem(id_modificador, productodesc, cantidad, "231.80", 5, 0, "", 1, "CodigoInterno154", "", 7);

                if (error != ERROR_NINGUNO)
                {
                    MessageBox.Show("Error al imprimir productos1: " + error.ToString());
                }
                error = Desconectar();
                if (error != ERROR_NINGUNO)
                {
                    MessageBox.Show("Error al desconectar impresora: " + error.ToString());
                }

               // Thread.Sleep(1000); 
            }

            error = Conectar();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al conectar: " + error.ToString());
            }
            error = ImprimirSubtotal();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al imprimir subtotal: " + error.ToString());
            }
            error = Desconectar();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al desconectar impresora: " + error.ToString());
            }
            error = Conectar();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al conectar: " + error.ToString());
            }
            error = CargarPago(id_modificador, tipodepago, cuotas, lbtotalg.Text, "", "Efectivo", "", "");
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al cargar pagos: " + error.ToString());
            }
            error = Desconectar();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al desconectar impresora: " + error.ToString());
            }
            error = Conectar();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al conectar: " + error.ToString());
            }
            error = CerrarComprobante();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al cerrar comprobante: " + error.ToString());
            }
            error = Desconectar();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al desconectar impresora: " + error.ToString());
            }

            error = Conectar();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al conectar: " + error.ToString());
            }
            
            const int str_len = 20;
            StringBuilder str = new StringBuilder(str_len);
            
            ConsultarNumeroComprobanteUltimo("83", str, str_len);
            int comprobanteaguardar = Convert.ToInt32(str.ToString());
            error = Desconectar();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al desconectar impresora: " + error.ToString());
            }
            //ConsultarNumeroComprobanteUltimo
            int valor1 = vta.spGuardarTicketFiscal(this.Ultimavta, comprobanteaguardar);
            if (valor1 != 0)
            {
                MessageBox.Show("Hubo un error al guardar el número del comprobante fiscal");
            }
            
        }
        /*
        private void ImprimirComprobante(IFUniversal.TipoDeComprobante Tipo, Boolean EnviaDatosCliente)
        {

            try
            {

                IFUniversal.IDriver Fiscal = new IFUniversal.Driver();
                Fiscal.Modelo = MODELO;

                if (Fiscal.Error != 0)
                {
                    MessageBox.Show(Fiscal.ErrorDesc);
                }

                Fiscal.Puerto = PUERTO;
                Fiscal.Baudios = IFUniversal.Baudio.bd9600;

                if (!Fiscal.Inicializar())
                    throw new Exception(Fiscal.ErrorDesc);

                Fiscal.CancelarComprobante();

                //Si el ticket supera 1000 pesos debe enviarse
                if (EnviaDatosCliente)
                {
                    if (!Fiscal.DatosCliente("Abel Miranda", IFUniversal.TipoDeDocumento.tdCUIT, "20939802593", IFUniversal.ResponsabilidadIVA.riResponsableInscripto, "Blanco Encalada 1204 5to A"))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }

                if (!Fiscal.AbrirComprobante(Tipo))
                {
                    throw new Exception(Fiscal.ErrorDesc);
                }
                if (!Fiscal.ImprimirTextoFiscal("Devolucion Item"))
                {
                    throw new Exception(Fiscal.ErrorDesc);
                }

                if (!Fiscal.ImprimirItem2g("Item 1", 1, 0.1, 21, 0, IFUniversal.CondicionesIVA.Gravado, 0, 1, "7790001001054", "", IFUniversal.UnidadesMedida.Unidad))
                {
                    throw new Exception(Fiscal.ErrorDesc);
                }

                if (!Fiscal.ImprimirDescuentoUltimoItem("Descuento Item", 0.01))
                {
                    throw new Exception(Fiscal.ErrorDesc);
                }

                if (!Fiscal.ImprimirDescuentoGeneral("Item 1", 0.01))
                {
                    throw new Exception(Fiscal.ErrorDesc);
                }

                if (!Fiscal.ImprimirPago2g("Efectivo", 5, "", IFUniversal.TiposPago.Efectivo, 1, "", ""))
                {
                    throw new Exception(Fiscal.ErrorDesc);
                }


                Fiscal.CerrarComprobante();

                MessageBox.Show("Comprobante impreso exitosamente");

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
        */
        /*
        private void imprimirticketNuevaIFU()
        {
            string productodesc = string.Empty; //descripción del producto
            string iva, codigointerno;
            double cantidad, tasaiva,montopago, precio;
            
            try
            {

                IFUniversal.IDriver Fiscal = new IFUniversal.Driver();
                Fiscal.Modelo = MODELO;

               
                if (Fiscal.Error != 0)
                {
                    MessageBox.Show(Fiscal.ErrorDesc);
                }

                Fiscal.Puerto = PUERTO;
                Fiscal.Baudios = IFUniversal.Baudio.bd9600;

                if (!Fiscal.Inicializar())
                    throw new Exception(Fiscal.ErrorDesc);

                Fiscal.CancelarComprobante();

                if (!Fiscal.AbrirComprobante(IFUniversal.TipoDeComprobante.tcTique))
                {
                    throw new Exception(Fiscal.ErrorDesc);
                }
              
                
                foreach (DataGridViewRow row in dgvProductos.Rows)
                {

                    productodesc = Convert.ToString(row.Cells[2].Value);
                    cantidad = Convert.ToDouble(row.Cells[0].Value);
                    precio = Convert.ToDouble(row.Cells[4].Value);
                    iva = Convert.ToString(row.Cells[10].Value);
                    codigointerno = Convert.ToString(row.Cells[1].Value);

                    if (iva == "21" || iva == "21.00" || iva == "21,00")
                    {
                        tasaiva = 21;
                    }
                    else if (iva == "0" || iva == "0.00" || iva == "0,00")
                    {
                        tasaiva = 0;
                    }
                    else
                    {
                        tasaiva = 10.5;
                    }
             
                    if (!Fiscal.ImprimirItem2g(productodesc, cantidad, precio, tasaiva, 0, IFUniversal.CondicionesIVA.Gravado, 0, 1, codigointerno, "", IFUniversal.UnidadesMedida.Unidad))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }

                string montoin = lbtotalg.Text;

                montopago = Convert.ToDouble(montoin);

                if (ptipopagide == 1)
                {
                    //tipodepago = 8;
                    //cuotas = 1;
                    if (!Fiscal.ImprimirPago2g("Efectivo", montopago, "", IFUniversal.TiposPago.Efectivo, 1, "", ""))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (ptipopagide == 2 || ptipopagide == 3)
                {
                    //tipodepago = 21;
                    //cuotas = 1;
                    if (!Fiscal.ImprimirPago2g("Maestro", montopago, "", IFUniversal.TiposPago.TarjetaDeDebito, 1, "", ""))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (ptipopagide == 4 || ptipopagide == 5 || ptipopagide == 6 || ptipopagide == 8 || ptipopagide == 9)
                {
                    //tipodepago = 20;
                    //cuotas = 1;
                    if (!Fiscal.ImprimirPago2g("Crédito", montopago, "", IFUniversal.TiposPago.TarjetaDeCredito, 1, "", ""))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (ptipopagide == 7) //Plan z
                {
                   // tipodepago = 20;
                    //cuotas = 11;
                    if (!Fiscal.ImprimirPago2g("Plan Z", montopago, "", IFUniversal.TiposPago.TarjetaDeCredito, 11, "", ""))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (ptipopagide == 10) //2 cuotas
                {
                    //tipodepago = 20;
                    //cuotas = 2;
                    if (!Fiscal.ImprimirPago2g("Crédito", montopago, "", IFUniversal.TiposPago.TarjetaDeCredito, 2, "", ""))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (ptipopagide == 11) //3 cuotas
                {
                    if (!Fiscal.ImprimirPago2g("Crédito", montopago, "", IFUniversal.TiposPago.TarjetaDeCredito, 3, "", ""))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (ptipopagide == 14) //12 cuotas
                {
                    if (!Fiscal.ImprimirPago2g("Crédito", montopago, "", IFUniversal.TiposPago.TarjetaDeCredito, 12, "", ""))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (ptipopagide == 15) //6 cuotas
                {
                    if (!Fiscal.ImprimirPago2g("Crédito", montopago, "", IFUniversal.TiposPago.TarjetaDeCredito, 6, "", ""))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (ptipopagide == 16) //ahora 3
                {
                    if (!Fiscal.ImprimirPago2g("Ahora 3", montopago, "", IFUniversal.TiposPago.TarjetaDeCredito, 3, "", ""))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (ptipopagide == 17) //ahora 6
                {
                    if (!Fiscal.ImprimirPago2g("Ahora 6", montopago, "", IFUniversal.TiposPago.TarjetaDeCredito, 6, "", ""))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }

               
                Fiscal.CerrarComprobante();
                
                int comprobanteaguardar = Fiscal.UltimoComprobante(IFUniversal.TipoDeComprobante.tcTique);
                int valor1 = vta.spGuardarTicketFiscal(this.Ultimavta, comprobanteaguardar);
                if (valor1 != 0)
                {
                    MessageBox.Show("Hubo un error al guardar el número del comprobante fiscal");
                }

           



                MessageBox.Show("Comprobante impreso exitosamente");

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }

        }
*/
        private void imprimirticketNuevaB()
        {
            int tipocomprobante = 2, id_modificador = 200, ptipodeiva=0; //1 es ticket 200 agregar venta
            string productodesc = string.Empty; //descripción del producto
            string cantidad, precio, iva, codigointerno;
            double preciod;
            const int ERROR_NINGUNO = 0;
            int error, tasaiva, tipodepago = 0, cuotas = 1;

            // cantidad = Convert.ToString(1 * 1000);
            // precio = Convert.ToString(201 * 1000);
            ConfigurarVelocidad(9600);
            ConfigurarPuerto("0"); //USB
            error = Conectar();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al conectar: " + error.ToString());
            }
            
            if (lbtipoiva.Text == "I")
            {
                ptipodeiva = 1;
            }
            else if (lbtipoiva.Text == "E")
            {
                ptipodeiva = 6;
            }
            else if (lbtipoiva.Text == "M")
            {
                ptipodeiva = 4;
            }
            else if (lbtipoiva.Text == "N")
            {
                ptipodeiva = 3;
            }
            else if (lbtipoiva.Text == "S")
            {
                ptipodeiva = 7;
            }
            else 
            {
                ptipodeiva = 5;
            }
            error = CargarDatosCliente(lbcomprador.Text, "", lbcomdire.Text, "", "", 3, lbcomcuit.Text, ptipodeiva);
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al conectar: " + error.ToString());
            }
            AbrirComprobante(tipocomprobante); //2 FACTURA B

            error = Desconectar();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al desconectar impresora: " + error.ToString());
            }

            //Tipo de pago
            if (ptipopagide == 1)
            {
                tipodepago = 8;
                cuotas = 1;
            }
            else if (ptipopagide == 2 || ptipopagide == 3)
            {
                tipodepago = 21;
                cuotas = 1;
            }
            else if (ptipopagide == 4 || ptipopagide == 5 || ptipopagide == 6 || ptipopagide == 8 || ptipopagide == 9)
            {
                tipodepago = 20;
                cuotas = 1;
            }
            else if (ptipopagide == 7) //Plan z
            {
                tipodepago = 20;
                cuotas = 11;
            }
            else if (ptipopagide == 10) //2 cuotas
            {
                tipodepago = 20;
                cuotas = 2;
            }
            else if (ptipopagide == 11) //3 cuotas
            {
                tipodepago = 20;
                cuotas = 3;
            }
            else if (ptipopagide == 14) //12 cuotas
            {
                tipodepago = 20;
                cuotas = 12;
            }
            else if (ptipopagide == 15) //6 cuotas
            {
                tipodepago = 20;
                cuotas = 6;
            }
            else if (ptipopagide == 16) //ahora 3
            {
                tipodepago = 20;
                cuotas = 3;
            }
            else if (ptipopagide == 17) //ahora 6
            {
                tipodepago = 20;
                cuotas = 3;
            }
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {

                productodesc = Convert.ToString(row.Cells[2].Value);
                cantidad = Convert.ToString(row.Cells[0].Value);
                preciod = Convert.ToDouble(row.Cells[4].Value);
                precio = string.Format("{0:N4}", preciod);
                //precio = Convert.ToString(preciod);
                precio = precio.Replace(".", String.Empty);
                precio = precio.Replace(',', '.');
                iva = Convert.ToString(row.Cells[10].Value);
                codigointerno = Convert.ToString(row.Cells[1].Value);

                tasaiva = 1;
                /*if (iva == "21" || iva == "21.00" || iva == "21,00")
                {
                    tasaiva = 5;
                }
                else if (iva == "0" || iva == "0.00" || iva == "0,00")
                {
                    tasaiva = 1;
                }
                else
                {
                    tasaiva = 4;
                }*/
                //productodesc = MySql.Data.MySqlClient.MySqlHelper.EscapeString(productodesc);
                //productodesc = Rege
                error = Conectar();
                if (error != ERROR_NINGUNO)
                {
                    MessageBox.Show("Error al conectar: " + error.ToString());
                }
                error = ImprimirItem(id_modificador, productodesc, cantidad, precio, tasaiva, 0, "", 1, codigointerno, "", 7);
                //error = ImprimirItem(id_modificador, productodesc, cantidad, "231.80", 5, 0, "", 1, "CodigoInterno154", "", 7);

                if (error != ERROR_NINGUNO)
                {
                    MessageBox.Show("Error al imprimir productos: " + error.ToString());
                }
                error = Desconectar();
                if (error != ERROR_NINGUNO)
                {
                    MessageBox.Show("Error al desconectar impresora: " + error.ToString());
                }
            }
            error = Conectar();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al conectar: " + error.ToString());
            }
            error = ImprimirSubtotal();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al imprimir subtotal: " + error.ToString());
            }

            error = Desconectar();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al desconectar impresora: " + error.ToString());
            }
            error = Conectar();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al conectar: " + error.ToString());
            }
            error = CargarPago(id_modificador, tipodepago, cuotas, lbtotalg.Text, "", "Efectivo", "", "");
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al cargar pagos: " + error.ToString());
            }
            error = Desconectar();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al desconectar impresora: " + error.ToString());
            }
            error = Conectar();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al conectar: " + error.ToString());
            }
            error = CerrarComprobante();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al cerrar comprobante: " + error.ToString());
            }
            error = Desconectar();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al desconectar impresora: " + error.ToString());
            }

            error = Conectar();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al conectar: " + error.ToString());
            }
            
            const int str_len = 20;
            StringBuilder str = new StringBuilder(str_len);
            //int ulticompro = ConsultarNumeroPuntoDeVenta("83", str, ref mayor);
            ConsultarNumeroComprobanteUltimo("82", str, str_len);
            int comprobanteaguardar = Convert.ToInt32(str.ToString());
            error = Desconectar();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al desconectar impresora: " + error.ToString());
            }
            //ConsultarNumeroComprobanteUltimo
            int valor1 = vta.spGuardarTicketFiscal(this.Ultimavta, comprobanteaguardar);
            if (valor1 != 0)
            {
                MessageBox.Show("Hubo un error al guardar el número del comprobante fiscal");
            }
            
        }
        /*
        private void imprimirticketNuevaBIFU()
        {
            string productodesc = string.Empty; //descripción del producto
            string iva, codigointerno;
            double cantidad, tasaiva, montopago, precio;

            try
            {

                IFUniversal.IDriver Fiscal = new IFUniversal.Driver();
                Fiscal.Modelo = MODELO;


                if (Fiscal.Error != 0)
                {
                    MessageBox.Show(Fiscal.ErrorDesc);
                }

                Fiscal.Puerto = PUERTO;
                Fiscal.Baudios = IFUniversal.Baudio.bd9600;

                if (!Fiscal.Inicializar())
                    throw new Exception(Fiscal.ErrorDesc);

                Fiscal.CancelarComprobante();


                if (lbtipoiva.Text == "I")
                {
                    if (!Fiscal.DatosCliente(lbcomprador.Text, IFUniversal.TipoDeDocumento.tdCUIT, lbcomcuit.Text, IFUniversal.ResponsabilidadIVA.riResponsableInscripto, lbcomdire.Text))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (lbtipoiva.Text == "E")
                {
                    if (!Fiscal.DatosCliente(lbcomprador.Text, IFUniversal.TipoDeDocumento.tdCUIT, lbcomcuit.Text, IFUniversal.ResponsabilidadIVA.riExento, lbcomdire.Text))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (lbtipoiva.Text == "M")
                {
                    if (!Fiscal.DatosCliente(lbcomprador.Text, IFUniversal.TipoDeDocumento.tdCUIT, lbcomcuit.Text, IFUniversal.ResponsabilidadIVA.riMonotributo, lbcomdire.Text))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (lbtipoiva.Text == "N")
                {
                    if (!Fiscal.DatosCliente(lbcomprador.Text, IFUniversal.TipoDeDocumento.tdCUIT, lbcomcuit.Text, IFUniversal.ResponsabilidadIVA.riNoResponsable, lbcomdire.Text))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (lbtipoiva.Text == "S")
                {
                    if (!Fiscal.DatosCliente(lbcomprador.Text, IFUniversal.TipoDeDocumento.tdCUIT, lbcomcuit.Text, IFUniversal.ResponsabilidadIVA.riNoCategorizado, lbcomdire.Text))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else
                {
                    if (!Fiscal.DatosCliente(lbcomprador.Text, IFUniversal.TipoDeDocumento.tdCUIT, lbcomcuit.Text, IFUniversal.ResponsabilidadIVA.riConsumidorFinal, lbcomdire.Text))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }

              
                if (!Fiscal.AbrirComprobante(IFUniversal.TipoDeComprobante.tcFactura_B))
                {
                    throw new Exception(Fiscal.ErrorDesc);
                }
              
                foreach (DataGridViewRow row in dgvProductos.Rows)
                {

                    productodesc = Convert.ToString(row.Cells[2].Value);
                    cantidad = Convert.ToDouble(row.Cells[0].Value);
                    precio = Convert.ToDouble(row.Cells[4].Value);
                    iva = Convert.ToString(row.Cells[10].Value);
                    codigointerno = Convert.ToString(row.Cells[1].Value);

                    if (iva == "21" || iva == "21.00" || iva == "21,00")
                    {
                        tasaiva = 21;
                    }
                    else if (iva == "0" || iva == "0.00" || iva == "0,00")
                    {
                        tasaiva = 0;
                    }
                    else
                    {
                        tasaiva = 10.5;
                    }

                    if (!Fiscal.ImprimirItem2g(productodesc, cantidad, precio, tasaiva, 0, IFUniversal.CondicionesIVA.Gravado, 0, 1, codigointerno, "", IFUniversal.UnidadesMedida.Unidad))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }

                string montoin = lbtotalg.Text;

                montopago = Convert.ToDouble(montoin);

                if (ptipopagide == 1)
                {
                    //tipodepago = 8;
                    //cuotas = 1;
                    if (!Fiscal.ImprimirPago2g("Efectivo", montopago, "", IFUniversal.TiposPago.Efectivo, 1, "", ""))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (ptipopagide == 2 || ptipopagide == 3)
                {
                    //tipodepago = 21;
                    //cuotas = 1;
                    if (!Fiscal.ImprimirPago2g("Maestro", montopago, "", IFUniversal.TiposPago.TarjetaDeDebito, 1, "", ""))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (ptipopagide == 4 || ptipopagide == 5 || ptipopagide == 6 || ptipopagide == 8 || ptipopagide == 9)
                {
                    //tipodepago = 20;
                    //cuotas = 1;
                    if (!Fiscal.ImprimirPago2g("Crédito", montopago, "", IFUniversal.TiposPago.TarjetaDeCredito, 1, "", ""))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (ptipopagide == 7) //Plan z
                {
                    // tipodepago = 20;
                    //cuotas = 11;
                    if (!Fiscal.ImprimirPago2g("Plan Z", montopago, "", IFUniversal.TiposPago.TarjetaDeCredito, 11, "", ""))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (ptipopagide == 10) //2 cuotas
                {
                    //tipodepago = 20;
                    //cuotas = 2;
                    if (!Fiscal.ImprimirPago2g("Crédito", montopago, "", IFUniversal.TiposPago.TarjetaDeCredito, 2, "", ""))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (ptipopagide == 11) //3 cuotas
                {
                    if (!Fiscal.ImprimirPago2g("Crédito", montopago, "", IFUniversal.TiposPago.TarjetaDeCredito, 3, "", ""))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (ptipopagide == 14) //12 cuotas
                {
                    if (!Fiscal.ImprimirPago2g("Crédito", montopago, "", IFUniversal.TiposPago.TarjetaDeCredito, 12, "", ""))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (ptipopagide == 15) //6 cuotas
                {
                    if (!Fiscal.ImprimirPago2g("Crédito", montopago, "", IFUniversal.TiposPago.TarjetaDeCredito, 6, "", ""))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (ptipopagide == 16) //ahora 3
                {
                    if (!Fiscal.ImprimirPago2g("Ahora 3", montopago, "", IFUniversal.TiposPago.TarjetaDeCredito, 3, "", ""))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (ptipopagide == 17) //ahora 6
                {
                    if (!Fiscal.ImprimirPago2g("Ahora 6", montopago, "", IFUniversal.TiposPago.TarjetaDeCredito, 6, "", ""))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }


                Fiscal.CerrarComprobante();

                int comprobanteaguardar = Fiscal.UltimoComprobante(IFUniversal.TipoDeComprobante.tcTique);
                int valor1 = vta.spGuardarTicketFiscal(this.Ultimavta, comprobanteaguardar);
                if (valor1 != 0)
                {
                    MessageBox.Show("Hubo un error al guardar el número del comprobante fiscal");
                }

              


                MessageBox.Show("Comprobante impreso exitosamente");

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }

        }
*/

        private void imprimirticketNuevaA()
        {
            int tipocomprobante = 2, id_modificador = 200, ptipodeiva = 0; //1 es ticket 200 agregar venta
            string productodesc = string.Empty; //descripción del producto
            string cantidad, precio, iva, codigointerno;
            double preciod;
            const int ERROR_NINGUNO = 0;
            int error, tasaiva, tipodepago = 0, cuotas = 1;

            // cantidad = Convert.ToString(1 * 1000);
            // precio = Convert.ToString(201 * 1000);
            ConfigurarVelocidad(9600);
            ConfigurarPuerto("0"); //USB
            error = Conectar();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al conectar: " + error.ToString());
            }

            if (lbtipoiva.Text == "I")
            {
                ptipodeiva = 1;
            }
            else if (lbtipoiva.Text == "E")
            {
                ptipodeiva = 6;
            }
            else if (lbtipoiva.Text == "M")
            {
                ptipodeiva = 4;
            }
            else if (lbtipoiva.Text == "N")
            {
                ptipodeiva = 3;
            }
            else if (lbtipoiva.Text == "S")
            {
                ptipodeiva = 7;
            }
            else
            {
                ptipodeiva = 5;
            }
            error = CargarDatosCliente(lbcomprador.Text, "", lbcomdire.Text, "", "", 3, lbcomcuit.Text, ptipodeiva);
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al conectar: " + error.ToString());
            }
            AbrirComprobante(tipocomprobante); //2 FACTURA B
            error = Desconectar();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al desconectar impresora: " + error.ToString());
            }

            
            //Tipo de pago
            if (ptipopagide == 1)
            {
                tipodepago = 8;
                cuotas = 1;
            }
            else if (ptipopagide == 2 || ptipopagide == 3)
            {
                tipodepago = 21;
                cuotas = 1;
            }
            else if (ptipopagide == 4 || ptipopagide == 5 || ptipopagide == 6 || ptipopagide == 8 || ptipopagide == 9)
            {
                tipodepago = 20;
                cuotas = 1;
            }
            else if (ptipopagide == 7) //Plan z
            {
                tipodepago = 20;
                cuotas = 11;
            }
            else if (ptipopagide == 10) //2 cuotas
            {
                tipodepago = 20;
                cuotas = 2;
            }
            else if (ptipopagide == 11) //3 cuotas
            {
                tipodepago = 20;
                cuotas = 3;
            }
            else if (ptipopagide == 14) //12 cuotas
            {
                tipodepago = 20;
                cuotas = 12;
            }
            else if (ptipopagide == 15) //6 cuotas
            {
                tipodepago = 20;
                cuotas = 6;
            }
            else if (ptipopagide == 16) //ahora 3
            {
                tipodepago = 20;
                cuotas = 3;
            }
            else if (ptipopagide == 17) //ahora 6
            {
                tipodepago = 20;
                cuotas = 3;
            }
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                
                productodesc = Convert.ToString(row.Cells[2].Value);
                cantidad = Convert.ToString(row.Cells[0].Value);
                
                iva = Convert.ToString(row.Cells[10].Value);
                codigointerno = Convert.ToString(row.Cells[1].Value);
                //preciotemporal = Convert.ToString(row.Cells[4].Value);
                //preciotemporal = preciotemporal.Replace(',', '.');
                preciod = Convert.ToDouble(row.Cells[4].Value);
               
                
                if (iva == "21" || iva == "21.00" || iva == "21,00")
                {
                    tasaiva = 5;
                    preciod = (preciod / 1.21);


                }
                else if (iva == "0" || iva == "0.00" || iva == "0,00")
                {
                    tasaiva = 1;
                    
                }
                else
                {
                    tasaiva = 4;
                    preciod = (preciod / 1.105);

                }
                precio = string.Format("{0:N4}", preciod);
                //precio = Convert.ToString(preciod);
                precio = precio.Replace(".", String.Empty);
                precio = precio.Replace(',', '.');

                //productodesc = MySql.Data.MySqlClient.MySqlHelper.EscapeString(productodesc);
                //productodesc = Rege
                error = Conectar();
                if (error != ERROR_NINGUNO)
                {
                    MessageBox.Show("Error al conectar: " + error.ToString());
                }
                error = ImprimirItem(id_modificador, productodesc, cantidad, precio, tasaiva, 0, "", 1, codigointerno, "", 7);
                //error = ImprimirItem(id_modificador, productodesc, cantidad, "231.80", 5, 0, "", 1, "CodigoInterno154", "", 7);

                if (error != ERROR_NINGUNO)
                {
                    MessageBox.Show("Error al imprimir productos: " + error.ToString());
                }
                error = Desconectar();
                if (error != ERROR_NINGUNO)
                {
                    MessageBox.Show("Error al desconectar impresora: " + error.ToString());
                }

            }
            error = Conectar();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al conectar: " + error.ToString());
            }
            error = ImprimirSubtotal();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al imprimir subtotal: " + error.ToString());
            }
            error = Desconectar();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al desconectar impresora: " + error.ToString());
            }
            error = Conectar();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al conectar: " + error.ToString());
            }
            error = CargarPago(id_modificador, tipodepago, cuotas, lbtotalg.Text, "", "Efectivo", "", "");
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al cargar pagos: " + error.ToString());
            }
            error = Desconectar();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al desconectar impresora: " + error.ToString());
            }
            error = Conectar();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al conectar: " + error.ToString());
            }
            error = CerrarComprobante();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al cerrar comprobante: " + error.ToString());
            }
            error = Desconectar();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al desconectar impresora: " + error.ToString());
            }

            error = Conectar();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al conectar: " + error.ToString());
            }
            
            const int str_len = 20;
            StringBuilder str = new StringBuilder(str_len);
            //int ulticompro = ConsultarNumeroPuntoDeVenta("83", str, ref mayor);
            ConsultarNumeroComprobanteUltimo("81", str, str_len);
            int comprobanteaguardar = Convert.ToInt32(str.ToString());
            error = Desconectar();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al desconectar impresora: " + error.ToString());
            }
            //ConsultarNumeroComprobanteUltimo
            int valor1 = vta.spGuardarTicketFiscal(this.Ultimavta, comprobanteaguardar);
            if (valor1 != 0)
            {
                MessageBox.Show("Hubo un error al guardar el número del comprobante fiscal");
            }
            
        }

        /*
        private void imprimirticketNuevaAIFU()
        {
            string productodesc = string.Empty; //descripción del producto
            string iva, codigointerno;
            double cantidad, tasaiva, montopago, precio;

            try
            {

                IFUniversal.IDriver Fiscal = new IFUniversal.Driver();
                Fiscal.Modelo = MODELO;


                if (Fiscal.Error != 0)
                {
                    MessageBox.Show(Fiscal.ErrorDesc);
                }

                Fiscal.Puerto = PUERTO;
                Fiscal.Baudios = IFUniversal.Baudio.bd9600;

                if (!Fiscal.Inicializar())
                    throw new Exception(Fiscal.ErrorDesc);

                Fiscal.CancelarComprobante();


                if (lbtipoiva.Text == "I")
                {
                    if (!Fiscal.DatosCliente(lbcomprador.Text, IFUniversal.TipoDeDocumento.tdCUIT, lbcomcuit.Text, IFUniversal.ResponsabilidadIVA.riResponsableInscripto, lbcomdire.Text))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (lbtipoiva.Text == "E")
                {
                    if (!Fiscal.DatosCliente(lbcomprador.Text, IFUniversal.TipoDeDocumento.tdCUIT, lbcomcuit.Text, IFUniversal.ResponsabilidadIVA.riExento, lbcomdire.Text))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (lbtipoiva.Text == "M")
                {
                    if (!Fiscal.DatosCliente(lbcomprador.Text, IFUniversal.TipoDeDocumento.tdCUIT, lbcomcuit.Text, IFUniversal.ResponsabilidadIVA.riMonotributo, lbcomdire.Text))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (lbtipoiva.Text == "N")
                {
                    if (!Fiscal.DatosCliente(lbcomprador.Text, IFUniversal.TipoDeDocumento.tdCUIT, lbcomcuit.Text, IFUniversal.ResponsabilidadIVA.riNoResponsable, lbcomdire.Text))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (lbtipoiva.Text == "S")
                {
                    if (!Fiscal.DatosCliente(lbcomprador.Text, IFUniversal.TipoDeDocumento.tdCUIT, lbcomcuit.Text, IFUniversal.ResponsabilidadIVA.riNoCategorizado, lbcomdire.Text))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else
                {
                    if (!Fiscal.DatosCliente(lbcomprador.Text, IFUniversal.TipoDeDocumento.tdCUIT, lbcomcuit.Text, IFUniversal.ResponsabilidadIVA.riConsumidorFinal, lbcomdire.Text))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }


                if (!Fiscal.AbrirComprobante(IFUniversal.TipoDeComprobante.tcFactura_A))
                {
                    throw new Exception(Fiscal.ErrorDesc);
                }

                foreach (DataGridViewRow row in dgvProductos.Rows)
                {

                    productodesc = Convert.ToString(row.Cells[2].Value);
                    cantidad = Convert.ToDouble(row.Cells[0].Value);
                    precio = Convert.ToDouble(row.Cells[4].Value);
                    iva = Convert.ToString(row.Cells[10].Value);
                    codigointerno = Convert.ToString(row.Cells[1].Value);

                    if (iva == "21" || iva == "21.00" || iva == "21,00")
                    {
                        tasaiva = 21;
                    }
                    else if (iva == "0" || iva == "0.00" || iva == "0,00")
                    {
                        tasaiva = 0;
                    }
                    else
                    {
                        tasaiva = 10.5;
                    }

                    if (!Fiscal.ImprimirItem2g(productodesc, cantidad, precio, tasaiva, 0, IFUniversal.CondicionesIVA.Gravado, 0, 1, codigointerno, "", IFUniversal.UnidadesMedida.Unidad))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }

                string montoin = lbtotalg.Text;

                montopago = Convert.ToDouble(montoin);

                if (ptipopagide == 1)
                {
                    //tipodepago = 8;
                    //cuotas = 1;
                    if (!Fiscal.ImprimirPago2g("Efectivo", montopago, "", IFUniversal.TiposPago.Efectivo, 1, "", ""))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (ptipopagide == 2 || ptipopagide == 3)
                {
                    //tipodepago = 21;
                    //cuotas = 1;
                    if (!Fiscal.ImprimirPago2g("Maestro", montopago, "", IFUniversal.TiposPago.TarjetaDeDebito, 1, "", ""))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (ptipopagide == 4 || ptipopagide == 5 || ptipopagide == 6 || ptipopagide == 8 || ptipopagide == 9)
                {
                    //tipodepago = 20;
                    //cuotas = 1;
                    if (!Fiscal.ImprimirPago2g("Crédito", montopago, "", IFUniversal.TiposPago.TarjetaDeCredito, 1, "", ""))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (ptipopagide == 7) //Plan z
                {
                    // tipodepago = 20;
                    //cuotas = 11;
                    if (!Fiscal.ImprimirPago2g("Plan Z", montopago, "", IFUniversal.TiposPago.TarjetaDeCredito, 11, "", ""))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (ptipopagide == 10) //2 cuotas
                {
                    //tipodepago = 20;
                    //cuotas = 2;
                    if (!Fiscal.ImprimirPago2g("Crédito", montopago, "", IFUniversal.TiposPago.TarjetaDeCredito, 2, "", ""))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (ptipopagide == 11) //3 cuotas
                {
                    if (!Fiscal.ImprimirPago2g("Crédito", montopago, "", IFUniversal.TiposPago.TarjetaDeCredito, 3, "", ""))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (ptipopagide == 14) //12 cuotas
                {
                    if (!Fiscal.ImprimirPago2g("Crédito", montopago, "", IFUniversal.TiposPago.TarjetaDeCredito, 12, "", ""))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (ptipopagide == 15) //6 cuotas
                {
                    if (!Fiscal.ImprimirPago2g("Crédito", montopago, "", IFUniversal.TiposPago.TarjetaDeCredito, 6, "", ""))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (ptipopagide == 16) //ahora 3
                {
                    if (!Fiscal.ImprimirPago2g("Ahora 3", montopago, "", IFUniversal.TiposPago.TarjetaDeCredito, 3, "", ""))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }
                else if (ptipopagide == 17) //ahora 6
                {
                    if (!Fiscal.ImprimirPago2g("Ahora 6", montopago, "", IFUniversal.TiposPago.TarjetaDeCredito, 6, "", ""))
                    {
                        throw new Exception(Fiscal.ErrorDesc);
                    }
                }


                Fiscal.CerrarComprobante();

                int comprobanteaguardar = Fiscal.UltimoComprobante(IFUniversal.TipoDeComprobante.tcTique);
                int valor1 = vta.spGuardarTicketFiscal(this.Ultimavta, comprobanteaguardar);
                if (valor1 != 0)
                {
                    MessageBox.Show("Hubo un error al guardar el número del comprobante fiscal");
                }

              



                MessageBox.Show("Comprobante impreso exitosamente");

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }

        }

*/
        private void imprimirtiqueadora()
        {
            string cabecera = "LOLAS´S";
            string dire = "Fagnano 151  Tel. 02966437670 int 34";
            string dire2 = "(9400) Rio Gallegos - Santa Cruz";
            string dire3 = "e-mail lolasdbacsantacruz@gmail.com";
            string dire4 = "ALVADO JUAN CARLOS";
            string dire5 = "CUIT Nro.: 20-13393350-7 Ing. Brutos: 1/9093";
            string dire6 = "IVA RESPONSABLE INSCRIPTO";
            string dire7 = "Inic Act: 12/06/10 - Municipal: 1600248A A CONSUMIDOR FINAL";
            string dire8 = "P.V. Nro.:0006 ";
            string dire9 = "Nro.                             0000" + this.Ultimavta;
            string dire10 = "Fecha: " + DateTime.Now;
            

            PrintDocument p = new PrintDocument();
            p.PrintPage += (s, e) =>
            {
                e.Graphics.DrawString(cabecera,
                                         new Font("Times New Roman", 12),
                                         new SolidBrush(Color.Black),
                                         new RectangleF(15, 5, p.DefaultPageSettings.PrintableArea.Width,
                                                         p.DefaultPageSettings.PrintableArea.Height));

                e.Graphics.DrawString(dire,
                                     new Font("Times New Roman", 11),
                                     new SolidBrush(Color.Black),
                                     new RectangleF(5, 35, p.DefaultPageSettings.PrintableArea.Width,
                                                     p.DefaultPageSettings.PrintableArea.Height));

                e.Graphics.DrawString(dire2,
                                     new Font("Times New Roman", 11),
                                     new SolidBrush(Color.Black),
                                     new RectangleF(5, 60, p.DefaultPageSettings.PrintableArea.Width,
                                                     p.DefaultPageSettings.PrintableArea.Height));
                e.Graphics.DrawString(dire3,
                                     new Font("Times New Roman", 11),
                                     new SolidBrush(Color.Black),
                                     new RectangleF(5, 85, p.DefaultPageSettings.PrintableArea.Width,
                                                     p.DefaultPageSettings.PrintableArea.Height));
                e.Graphics.DrawString(dire4,
                                     new Font("Times New Roman", 11),
                                     new SolidBrush(Color.Black),
                                     new RectangleF(5, 110, p.DefaultPageSettings.PrintableArea.Width,
                                                     p.DefaultPageSettings.PrintableArea.Height));
                e.Graphics.DrawString(dire5,
                                    new Font("Times New Roman", 11),
                                    new SolidBrush(Color.Black),
                                    new RectangleF(5, 135, p.DefaultPageSettings.PrintableArea.Width,
                                                    p.DefaultPageSettings.PrintableArea.Height));

                e.Graphics.DrawString(dire6,
                                   new Font("Times New Roman", 11),
                                   new SolidBrush(Color.Black),
                                   new RectangleF(5, 160, p.DefaultPageSettings.PrintableArea.Width,
                                                   p.DefaultPageSettings.PrintableArea.Height));

                e.Graphics.DrawString(dire7,
                                   new Font("Times New Roman", 11),
                                   new SolidBrush(Color.Black),
                                   new RectangleF(5, 185, p.DefaultPageSettings.PrintableArea.Width,
                                                   p.DefaultPageSettings.PrintableArea.Height));

                e.Graphics.DrawString(dire8,
                                   new Font("Times New Roman", 11),
                                   new SolidBrush(Color.Black),
                                   new RectangleF(5, 210, p.DefaultPageSettings.PrintableArea.Width,
                                                   p.DefaultPageSettings.PrintableArea.Height));

                e.Graphics.DrawString(dire9,
                                   new Font("Times New Roman", 11),
                                   new SolidBrush(Color.Black),
                                   new RectangleF(5, 235, p.DefaultPageSettings.PrintableArea.Width,
                                                   p.DefaultPageSettings.PrintableArea.Height));

                e.Graphics.DrawString(dire10,
                                   new Font("Times New Roman", 11),
                                   new SolidBrush(Color.Black),
                                   new RectangleF(5, 260, p.DefaultPageSettings.PrintableArea.Width,
                                                   p.DefaultPageSettings.PrintableArea.Height));


                //imprime productos
                string productodesc, cantidad , precio, iva, codigointerno, imprimeproducto, imprimeprecioporcanti, preciosubim,preciototalim;
                double preciod,preciosub,preciototal;
                int linea = 310;
                int linea2 = 0;
                foreach (DataGridViewRow row in dgvProductos.Rows)
                {

                    productodesc = Convert.ToString(row.Cells[2].Value);
                    cantidad = Convert.ToString(row.Cells[0].Value);
                    preciod = Convert.ToDouble(row.Cells[4].Value);
                    preciosub = Convert.ToDouble(row.Cells[5].Value);
                    precio = string.Format("{0:N4}", preciod);
                    preciosubim = string.Format("{0:N2}", preciosub);
                    //precio = Convert.ToString(preciod);
                    // precio = precio.Replace(',', '.');
                    iva = Convert.ToString(row.Cells[10].Value);
                    codigointerno = Convert.ToString(row.Cells[1].Value);

                    int cantidadcaracteres = productodesc.Length;
                    if (cantidadcaracteres > 19)
                    {
                        imprimeproducto = productodesc.Substring(0, 20);
                    }
                    else
                    {
                        imprimeproducto = productodesc;
                    }
                    

                    imprimeprecioporcanti = cantidad + ",0000 X " + precio;

                    e.Graphics.DrawString(imprimeprecioporcanti,
                                   new Font("Times New Roman", 10),
                                   new SolidBrush(Color.Black),
                                   new RectangleF(5, linea, p.DefaultPageSettings.PrintableArea.Width,
                                                   p.DefaultPageSettings.PrintableArea.Height));

                    linea2 = linea + 15;

                    e.Graphics.DrawString(imprimeproducto,
                                  new Font("Times New Roman", 10),
                                  new SolidBrush(Color.Black),
                                  new RectangleF(5, linea2, p.DefaultPageSettings.PrintableArea.Width,
                                                  p.DefaultPageSettings.PrintableArea.Height));
                    e.Graphics.DrawString(preciosubim,
                                  new Font("Times New Roman", 10),
                                  new SolidBrush(Color.Black),
                                  new RectangleF(210, linea2, p.DefaultPageSettings.PrintableArea.Width,
                                                  p.DefaultPageSettings.PrintableArea.Height));

                    
                   

                    linea = linea + 35;
                    

                }
                linea = linea + 10;
                preciototal = Convert.ToDouble(lbtotalg.Text);
                preciototalim = string.Format("{0:N2}", preciototal);
                e.Graphics.DrawString("TOTAL",
                                  new Font("Times New Roman", 11),
                                  new SolidBrush(Color.Black),
                                  new RectangleF(10, linea, p.DefaultPageSettings.PrintableArea.Width,
                                                  p.DefaultPageSettings.PrintableArea.Height));

                e.Graphics.DrawString(preciototalim,
                                  new Font("Times New Roman", 11),
                                  new SolidBrush(Color.Black),
                                  new RectangleF(210, linea, p.DefaultPageSettings.PrintableArea.Width,
                                                  p.DefaultPageSettings.PrintableArea.Height));

                linea = linea + 40;
                e.Graphics.DrawString("Efectivo",
                                 new Font("Times New Roman", 10),
                                 new SolidBrush(Color.Black),
                                 new RectangleF(5, linea, p.DefaultPageSettings.PrintableArea.Width,
                                                 p.DefaultPageSettings.PrintableArea.Height));

                e.Graphics.DrawString(preciototalim,
                                 new Font("Times New Roman", 10),
                                 new SolidBrush(Color.Black),
                                 new RectangleF(210, linea, p.DefaultPageSettings.PrintableArea.Width,
                                                 p.DefaultPageSettings.PrintableArea.Height));

                linea += 30;
                e.Graphics.DrawString("La suma de sus pagos",
                                 new Font("Times New Roman", 10),
                                 new SolidBrush(Color.Black),
                                 new RectangleF(5, linea, p.DefaultPageSettings.PrintableArea.Width,
                                                 p.DefaultPageSettings.PrintableArea.Height));

                e.Graphics.DrawString(preciototalim,
                                 new Font("Times New Roman", 10),
                                 new SolidBrush(Color.Black),
                                 new RectangleF(210, linea, p.DefaultPageSettings.PrintableArea.Width,
                                                 p.DefaultPageSettings.PrintableArea.Height));

                linea += 30;
                e.Graphics.DrawString("Su vuelto",
                                 new Font("Times New Roman", 10),
                                 new SolidBrush(Color.Black),
                                 new RectangleF(5, linea, p.DefaultPageSettings.PrintableArea.Width,
                                                 p.DefaultPageSettings.PrintableArea.Height));

                e.Graphics.DrawString("0,00",
                                 new Font("Times New Roman", 10),
                                 new SolidBrush(Color.Black),
                                 new RectangleF(210, linea, p.DefaultPageSettings.PrintableArea.Width,
                                                 p.DefaultPageSettings.PrintableArea.Height));

                linea += 30;
                e.Graphics.DrawString("Vendedor: Hugo",
                                 new Font("Times New Roman", 10),
                                 new SolidBrush(Color.Black),
                                 new RectangleF(5, linea, p.DefaultPageSettings.PrintableArea.Width,
                                                 p.DefaultPageSettings.PrintableArea.Height));
                linea = linea + 30;
                e.Graphics.DrawString("Cant. Artículos: " + lbcantidadpro.Text,
                                 new Font("Times New Roman", 10),
                                 new SolidBrush(Color.Black),
                                 new RectangleF(5, linea, p.DefaultPageSettings.PrintableArea.Width,
                                                 p.DefaultPageSettings.PrintableArea.Height));
                linea = linea + 30;
                e.Graphics.DrawString("Gracias por su compra",
                                 new Font("Times New Roman", 12),
                                 new SolidBrush(Color.Black),
                                 new RectangleF(5, linea, p.DefaultPageSettings.PrintableArea.Width,
                                                 p.DefaultPageSettings.PrintableArea.Height));

            };
            
        p.Print();
        }

        private void LUComprobante_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(LUComprobante.EditValue) == 1)
            {
              // if (lbtipoiva.Text == "I")
              //  {
                    lbcomprador.Text = "Consumidor final";
                    lbcomdire.Text = "Dirección";
                    lbcomcuit.Text = "CUIT";
                    lbcomtipo.Text = "Consumidor final";
                    lbtipoiva.Text = "F";
                    //ConsultaCliente cc = new ConsultaCliente();
                    //cc.ShowDialog(this);
                //}
                this.BackColor = System.Drawing.Color.FromName("Control");
            }
            else if (Convert.ToInt32(LUComprobante.EditValue) == 2)
            {

                if (lbtipoiva.Text != "I" && nopedirclienteA == 0)
                {
                    MessageBox.Show("Debe seleccionar un Cliente con IVA RESPONSABLE INSCRIPTO");
                    ConsultaCliente cc = new ConsultaCliente();
                    cc.ShowDialog(this);
                }

                this.BackColor = System.Drawing.Color.FromName("AntiqueWhite");
            }
            else
            {
                if (lbtipoiva.Text == "I" && nopedirclienteA == 0)
                {
                    MessageBox.Show("Debe seleccionar un Cliente que no sea IVA RESPONSABLE INSCRIPTO para el ticket/factura B");
                    ConsultaCliente cc = new ConsultaCliente();
                    cc.ShowDialog(this);
                }
                this.BackColor = System.Drawing.Color.FromName("Ivory");
            }
        }

        private void btneliminaele_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar éste producto?", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                double precioasacar = Convert.ToDouble(dgvProductos.CurrentRow.Cells[5].Value);

                double ivaasacar = Convert.ToDouble(dgvProductos.CurrentRow.Cells[8].Value);
                double ivavalorasacar = Convert.ToDouble(dgvProductos.CurrentRow.Cells[9].Value);
                double iva = Convert.ToDouble(dgvProductos.CurrentRow.Cells[10].Value);
                totalg = Math.Round(totalg, 2, MidpointRounding.AwayFromZero);

                totalg = totalg - precioasacar;

                int canti = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
                lbcantidadpro.Text = Convert.ToString(Convert.ToInt32(lbcantidadpro.Text) - canti);

                if (iva == 0)
                {
                    lbexcento.Text = Convert.ToString(Convert.ToDouble(lbexcento.Text) - precioasacar);
                }
                else if (iva == 21)
                {
                    lbimp21.Text = Convert.ToString(Convert.ToDouble(lbimp21.Text) - ivaasacar);
                    lbiva21.Text = Convert.ToString(Convert.ToDouble(lbiva21.Text) - ivavalorasacar);
                }
                else
                {
                    lbimp10.Text = Convert.ToString(Convert.ToDouble(lbimp10.Text) - ivaasacar);
                    lbiva10.Text = Convert.ToString(Convert.ToDouble(lbiva10.Text) - ivavalorasacar);
                }
                lbtotalg.Text = Convert.ToString(totalg);


                dgvProductos.Rows.RemoveAt(dgvProductos.CurrentRow.Index);

            }
        }

        private void btndebito_Click(object sender, EventArgs e)
        {
            //            btndebito.ContextMenuStrip = contextMenuStrip1;
            conMSdebito.Show();
            conMSdebito.Left = Cursor.Position.X;
            conMSdebito.Top = Cursor.Position.Y;
        }

        private void TSMImaestro_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {
                Tipodepago tp = new Tipodepago();
                int valor = tp.spConsultaInteres(2);
                this.aplicadescuento(valor," con Débito Maestro?",2);
                //this.eliminardatosdelformulario();
            }
        }

        private void TSMIvisaelectron_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {
                Tipodepago tp = new Tipodepago();
                int valor = tp.spConsultaInteres(3);
                this.aplicadescuento(valor, " con Débito Visa Electrón?",3);
               // this.eliminardatosdelformulario();
            }
        }

        private void btncredito_Click(object sender, EventArgs e)
        {
            conMScredito.Show();
            conMScredito.Left = Cursor.Position.X;
            conMScredito.Top = Cursor.Position.Y;
        }

        private void btncuotas_Click(object sender, EventArgs e)
        {
            conMScuotas.Show();
            conMScuotas.Left = Cursor.Position.X;
            conMScuotas.Top = Cursor.Position.Y;
        }

        private void tSMIeficaz_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {
                Tipodepago tp = new Tipodepago();
                int valor = tp.spConsultaInteres(4);
                this.aplicadescuento(valor, " con tarjeta Eficaz?",4);
                //this.eliminardatosdelformulario();
            }
        }

        private void tSMImaster_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {
                Tipodepago tp = new Tipodepago();
                int valor = tp.spConsultaInteres(5);
                this.aplicadescuento(valor, " con tarjeta Master?",5);
               // this.eliminardatosdelformulario();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int tipocomprobante = 2, id_modificador = 200, ptipodeiva = 0; //1 es ticket 200 agregar venta
            string productodesc = string.Empty; //descripción del producto
            string cantidad, precio, iva, codigointerno;
            double preciod;
           // const int ERROR_NINGUNO = 0;
            //int error, tasaiva, tipodepago = 0, cuotas = 1;

            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                //string preciotemporal;
                productodesc = Convert.ToString(row.Cells[2].Value);
                cantidad = Convert.ToString(row.Cells[0].Value);

                iva = Convert.ToString(row.Cells[10].Value);
                codigointerno = Convert.ToString(row.Cells[1].Value);
                //preciotemporal = Convert.ToString(row.Cells[4].Value);
                //preciotemporal = preciotemporal.Replace(',', '.');
                preciod = Convert.ToDouble(row.Cells[4].Value);
                preciod = (preciod / 1.21);
                // preciotemporal = Convert.ToString(preciod);
                // preciotemporal = preciotemporal.Replace(',', '.');

                //preciod = Convert.ToDouble(preciotemporal);
                //preciod = (15.2 / 1.21);

                precio = string.Format("{0:N4}", preciod);
                //precio = Convert.ToString(preciod);
                precio = precio.Replace(',', '.');
                // string format = String.Format("{{0:N{0}}}", 4);
                
                //string preciomostrar = String.Format(format, precio);
                //productodesc = MySql.Data.MySqlClient.MySqlHelper.EscapeString(productodesc);
                //productodesc = Rege
                //error = ImprimirItem(id_modificador, productodesc, cantidad, precio, tasaiva, 0, "", 1, codigointerno, "", 7);
                //error = ImprimirItem(id_modificador, productodesc, cantidad, "231.80", 5, 0, "", 1, "CodigoInterno154", "", 7);
                MessageBox.Show(precio);
                
            }

        }

        private void btnajuste_Click(object sender, EventArgs e)
        {
            ConsultaAjustes ca = new ConsultaAjustes();
            ca.Show();
        }

        private void tSMInaranja_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {
                Tipodepago tp = new Tipodepago();
                int valor = tp.spConsultaInteres(6);
                this.aplicadescuento(valor, " con tarjeta Naranja?",6);
               // this.eliminardatosdelformulario();
            }
        }

        private void tSMIplanz_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {
                Tipodepago tp = new Tipodepago();
                int valor = tp.spConsultaInteres(7);
                this.aplicadescuento(valor, " en plan Z?",7);
               // this.eliminardatosdelformulario();
            }
        }

        private void tSMItdf_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {
                Tipodepago tp = new Tipodepago();
                int valor = tp.spConsultaInteres(8);
                this.aplicadescuento(valor, " con tarjeta TDF?",8);
              //  this.eliminardatosdelformulario();
            }
        }

        private void btncreditop_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {
                
                ConsultaCC cc = new ConsultaCC();
                cc.valor = 1;
                cc.ShowDialog();
                MessageBox.Show(clientecuentacorriente.ToString());
                if (clientecuentacorriente != 0)
                {
                    Tipodepago tp = new Tipodepago();
                    int valor = tp.spConsultaInteres(12);
                    this.aplicadescuento(valor, " con crédito personal?", 12);
                    //this.eliminardatosdelformulario();
                }
                /*
                Tipodepago tp = new Tipodepago();
                int valor = tp.spConsultaInteres(12);
                this.aplicadescuento(valor, " Crédito personal?", 12);
                */

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
  
        }

        private void btnproforma_Click(object sender, EventArgs e)
        {

            if (dgvProductos.Rows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro/a que desea realizar la proforma?", "Proforma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.guardarlaproformamaestro(1);
                    
                    Proforma pro = new Proforma();
                    pro.cargardatoscliente(lbcomprador.Text, lbcomcuit.Text, lbcomdire.Text, lbtipoiva.Text);
                    this.eliminardatosdelformulario();
                    pro.Ide = this.Ultimavta;
                    pro.recorrergrilla();
                    pro.ShowDialog();
                }
            }
           
        }

        private void btnplatacaja_Click(object sender, EventArgs e)
        {
            ConsultaPlataCaja cpc = new ConsultaPlataCaja();
            cpc.ShowDialog();
        }

        private void ahora3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {
                Tipodepago tp = new Tipodepago();
                int valor = tp.spConsultaInteres(16);
                this.aplicadescuento(valor, " Ahora 3?", 16);
                // this.eliminardatosdelformulario();
            }
        }

        private void ahora6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {
                Tipodepago tp = new Tipodepago();
                int valor = tp.spConsultaInteres(17);
                this.aplicadescuento(valor, " Ahora 6?", 17);
                // this.eliminardatosdelformulario();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btncargapedido_Click(object sender, EventArgs e)
        {
            ConsultasPedidosVta cpv = new ConsultasPedidosVta();
            cpv.ShowDialog();
        }

        private void btncobrar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count <= 0)
            { 
                MessageBox.Show("Debe seleccionar algún producto para cobrar");
            }else
            { 
                Cobrar co = new Cobrar();
                co.seteartipopago(ptipopagide);
                co.setearimporte(lbtotalg.Text);
                co.inicio();
                co.ShowDialog(this);
                this.eliminardatosdelformulario();
            }
        }

        private void tSMIvisa_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {
                Tipodepago tp = new Tipodepago();
                int valor = tp.spConsultaInteres(9);
                this.aplicadescuento(valor, " con tarjeta Visa?",9);
               // this.eliminardatosdelformulario();
            }
        }

        private void tSMI2cuotas_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {
                Tipodepago tp = new Tipodepago();
                int valor = tp.spConsultaInteres(10);
                this.aplicadescuento(valor, " En 2 cuotas?",10);
               // this.eliminardatosdelformulario();
            }
        }

        private void tSMI3cuotas_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {
                Tipodepago tp = new Tipodepago();
                int valor = tp.spConsultaInteres(11);
                this.aplicadescuento(valor, " En 3 cuotas?",11);
               // this.eliminardatosdelformulario();
            }
        }

        private void btnahora12_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {
                Tipodepago tp = new Tipodepago();
                int valor = tp.spConsultaInteres(14);
                this.aplicadescuento(valor, " con ahora 12?",14);
            }
        }

        private void aplicades(int descuento)
        {
                        importeivacondescuento = 0;
                        double totaltemporal = 0, totalivacondescuento = 0, totalivaimportecondes = 0, pvalorivaviene = 0;
                        double _valoriva21 = 0, _valoriva10 = 0, _importeiva21 = 0, _importeiva10 = 0, _exento = 0;
                        string ivavalor1;
                        foreach (DataGridViewRow row in dgvProductos.Rows)
                        {
            
                            double valorviejo = Convert.ToDouble(row.Cells[4].Value);
                            this.valorcondescuento = (valorviejo * descuento) / 100;
                            this.valorcondescuento = valorviejo  + valorcondescuento;
                            this.valorcondescuento = Math.Round(valorcondescuento, 1);
                            row.Cells[4].Value = this.valorcondescuento;
            
                            double subcondescuento = this.valorcondescuento * Convert.ToDouble(row.Cells[0].Value);
                            row.Cells[5].Value = subcondescuento;

                            
                            double ivavalorviejo = Convert.ToDouble(row.Cells[8].Value);//(subcondescuento * Convert.ToDouble(row.Cells[10].Value) / 100);

                            if (Convert.ToDouble(row.Cells[10].Value) == 21)
                            {
                                this.ivacondescuento = (subcondescuento / 1.21);
                                ivavalor1 = string.Format("{0:N4}", ivacondescuento);
                                this.ivacondescuento = Convert.ToDouble(ivavalor1);
                            }
                            else
                            {
                                this.ivacondescuento = (subcondescuento * Convert.ToDouble(row.Cells[10].Value) / 100);
                                ivavalor1 = string.Format("{0:N4}", ivacondescuento);
                                this.ivacondescuento = Convert.ToDouble(ivavalor1);
                                //this.ivacondescuento = Math.Round(ivacondescuento, 2);
                            }

                            row.Cells[8].Value = this.ivacondescuento;

                            pvalorivaviene = Convert.ToDouble(row.Cells[10].Value);
                            if (Convert.ToString(pvalorivaviene) != "0")
                            {
                                double importedelivaviejo = Convert.ToDouble(row.Cells[9].Value);
                                this.importeivacondescuento = subcondescuento - ivacondescuento;
                                importeivacondescuento = Math.Round(importeivacondescuento, 2);
                                row.Cells[9].Value = importeivacondescuento;
                            }

                            if (Convert.ToString(pvalorivaviene) == "21")
                            {
                                _valoriva21 = _valoriva21 + Convert.ToDouble(row.Cells[8].Value);
                                _importeiva21 = _importeiva21 + Convert.ToDouble(row.Cells[9].Value);
    
                            }
                            else if (Convert.ToString(pvalorivaviene) == "0")
                            {
                                _exento = _exento + Convert.ToDouble(row.Cells[5].Value);
                            }
                            else 
                            {
                                _valoriva10 = _valoriva10 + Convert.ToDouble(row.Cells[8].Value);
                                _importeiva10 = _importeiva10 + Convert.ToDouble(row.Cells[9].Value);
                            }

                            totaltemporal = totaltemporal + subcondescuento;
                            totalivacondescuento = totalivacondescuento + this.ivacondescuento;
                            totalivaimportecondes = totalivaimportecondes + importeivacondescuento;
                        }
                        totalanterior = Convert.ToDouble(lbtotalg.Text);
                        lbtotalg.Text = Convert.ToString(totaltemporal);
                        lbimp21.Text = Convert.ToString(_valoriva21);
                        lbiva21.Text = Convert.ToString(_importeiva21);
                        lbimp10.Text = Convert.ToString(_valoriva10);
                        lbiva10.Text = Convert.ToString(_importeiva10);
                        lbexcento.Text = Convert.ToString(_exento);


        }

        private void guardarlaventamaestro(int tipop2)
        {
            vta = new Venta();
            if (Convert.ToInt32(LUComprobante.EditValue) != 1)
            {
                vta.Vennombre = lbcomprador.Text;
                vta.Vencuit = lbcomcuit.Text;
                vta.Vendireccion = lbcomdire.Text;
            }
            vta.Ventipoiva = lbtipoiva.Text;
            vta.venimporte = lbtotalg.Text;
            vta.ventipopago = tipop2;
            vta.ventotal = lbtotalg.Text;
            if (Convert.ToInt32(LUComprobante.EditValue) == 1)
            {
                vta.ventipofactura = "T";
            }
            else if (Convert.ToInt32(LUComprobante.EditValue) == 2)
            {
                vta.ventipofactura = "A";
            }
            else
            {
                vta.ventipofactura = "B";
            }
            //truncar aca
            //hugo
            string importetem = lbimp21.Text;
            decimal valortem = Convert.ToDecimal(importetem);
            valortem = Math.Floor(valortem * 10000) / 10000;
            lbimp21.Text = Convert.ToString(valortem);

            vta.venimp21 = lbimp21.Text;

            string importetemI = lbiva21.Text;
            decimal valortemI = Convert.ToDecimal(importetemI);
            valortemI = Math.Floor(valortemI * 10000) / 10000;
            lbiva21.Text = Convert.ToString(valortemI);

            vta.venIVA21 = lbiva21.Text;


            string importetemI10 = lbiva21.Text;
            decimal valortemI10 = Convert.ToDecimal(importetemI10);
            valortemI10 = Math.Floor(valortemI10 * 10000) / 10000;
            lbimp10.Text = Convert.ToString(valortemI10);
            
            vta.venimp105 = lbimp10.Text;


            string importetemI105 = lbiva21.Text;
            decimal valortemI105 = Convert.ToDecimal(importetemI105);
            valortemI105 = Math.Floor(valortemI105 * 10000) / 10000;
            lbiva10.Text = Convert.ToString(valortemI105);
            
            vta.venIVA105 = lbiva10.Text;

            //hugo

            vta.venimpexcento = lbexcento.Text;

            vta.vendescuento = txtdescuento.Text;

            //Si es tipo crédito
            if (tipop2 == 12)
            {

                vta.venccorriente = Facturar.clientecuentacorriente;
                vta.venptodeventa = Globales.puntodeventa;
                int valor2 = vta.spVentaProducto();
                MessageBox.Show("El número de la venta es: " + valor2);
                this.Ultimavta = valor2;
                this.guardarventadetalledefinitiva();

            }
            else
            {
                //faltan los parámetros de la tabla cuentacorriente.
                int valor = vta.spVentaProducto();
                MessageBox.Show("El número del pedido es: " + valor);
                this.Ultimavta = valor;
                this.guardarventadetalle();
            }
        }

        private void guardarlaproformamaestro(int tipop2)
        {
            vta = new Venta();
            if (Convert.ToInt32(LUComprobante.EditValue) != 1)
            {
                vta.Vennombre = lbcomprador.Text;
                vta.Vencuit = lbcomcuit.Text;
                vta.Vendireccion = lbcomdire.Text;
            }
            vta.Ventipoiva = lbtipoiva.Text;
            vta.venimporte = lbtotalg.Text;
            vta.ventipopago = tipop2;
            vta.ventotal = lbtotalg.Text;
            if (Convert.ToInt32(LUComprobante.EditValue) == 1)
            {
                vta.ventipofactura = "T";
            }
            else if (Convert.ToInt32(LUComprobante.EditValue) == 2)
            {
                vta.ventipofactura = "A";
            }
            else
            {
                vta.ventipofactura = "B";
            }
            vta.venimp21 = lbimp21.Text;
            vta.venIVA21 = lbiva21.Text;
            vta.venimp105 = lbimp10.Text;
            vta.venIVA105 = lbiva10.Text;
            vta.venimpexcento = lbexcento.Text;

            vta.vendescuento = txtdescuento.Text;

            //Si es tipo crédito
            if (tipop2 == 12)
            {
                vta.venccorriente = Facturar.clientecuentacorriente;
            }


            int valor = vta.spProformaMaestro();
            
            this.Ultimavta = valor;
            this.guardarproformadetalle();
        }

        private void guardarventamaestro(int tipop1)
        {
            Globales.usuventaide = 0;
            IngresoClave ic = new IngresoClave();
            ic.ShowDialog();
            if (Globales.usuventaide != 0)
            {
                
                this.guardarlaventamaestro(tipop1);
            }
            else
            {
                MessageBox.Show("Debe ingresar una clave válida!");

            }
        }

        private void guardarventadefinitiva()
        {
            
           // MessageBox.Show("realizar la Venta definitiva y borrar el temporal");
           vta = new Venta();
            if (Convert.ToInt32(LUComprobante.EditValue) != 1)
            {
                vta.Vennombre = lbcomprador.Text;
                vta.Vencuit = lbcomcuit.Text;
                vta.Vendireccion = lbcomdire.Text;

            }
            vta.Ventipoiva = lbtipoiva.Text;
          //  vta.Ventipoiva = lbtipoiva.Text;
            vta.venimporte = lbtotalg.Text;
            vta.ventipopago = ptipopagide;
            vta.ventotal = lbtotalg.Text;
            if (Convert.ToInt32(LUComprobante.EditValue) == 1)
            {
                vta.ventipofactura = "T";
            }
            else if (Convert.ToInt32(LUComprobante.EditValue) == 2)
            {
                vta.ventipofactura = "A";
            }
            else
            {
                vta.ventipofactura = "B";
            }
            //setear aca tambien
            /*vta.venimp21 = lbimp21.Text;
            vta.venIVA21 = lbiva21.Text;
            vta.venimp105 = lbimp10.Text;
            vta.venIVA105 = lbiva10.Text;
            */
            string importetem = lbimp21.Text;
            decimal valortem = Convert.ToDecimal(importetem);
            valortem = Math.Floor(valortem * 10000) / 10000;
            lbimp21.Text = Convert.ToString(valortem);

            vta.venimp21 = lbimp21.Text;

            string importetemI = lbiva21.Text;
            decimal valortemI = Convert.ToDecimal(importetemI);
            valortemI = Math.Floor(valortemI * 10000) / 10000;
            lbiva21.Text = Convert.ToString(valortemI);

            vta.venIVA21 = lbiva21.Text;


            string importetemI10 = lbiva21.Text;
            decimal valortemI10 = Convert.ToDecimal(importetemI10);
            valortemI10 = Math.Floor(valortemI10 * 10000) / 10000;
            lbimp10.Text = Convert.ToString(valortemI10);

            //vta.venimp105 = lbimp10.Text;
            vta.venimp105 = "0";


            string importetemI105 = lbiva21.Text;
            decimal valortemI105 = Convert.ToDecimal(importetemI105);
            valortemI105 = Math.Floor(valortemI105 * 10000) / 10000;
            lbiva10.Text = Convert.ToString(valortemI105);

            //vta.venIVA105 = lbiva10.Text;
            vta.venIVA105 = "0";

            vta.venimpexcento = lbexcento.Text;
            vta.venusuventapedido = this.pusuariopedidoide;

            vta.vendescuento = txtdescuento.Text;
            int valor = vta.spVentaProductodefinitiva();
            if (valor == 0)
            {
                MessageBox.Show("No se guardó la venta");
                string valores = string.Empty;
                valores = "nombre: " + vta.Vennombre + " Cuit: " + vta.Vencuit + "direccion: " + vta.Vendireccion;
                valores = valores + "Iva: " + vta.Ventipoiva + "Importe: " + vta.venimporte + "pago: " + vta.ventipopago + "Total: " + vta.ventotal;
                valores = valores + "Tipo: " + vta.ventipofactura + "Importe 21: " + vta.venimp21;
                valores = valores + "Iva 21: " + vta.venIVA21 + "Importe10: " + vta.venimp105 + "Iva10: "+ vta.venIVA105 + "Importe excento: " + vta.venimpexcento + "tipo Usuario: " + vta.venusuventapedido + "descuento: " + vta.vendescuento;
                valores = valores + "Imprimir: " + Globales.imprimirfactura;
                MessageBox.Show(valores);
            }

            MessageBox.Show("El número de venta es: " + valor);
            this.Ultimavta = valor;
            this.guardarventadetalledefinitiva();
            //borrar el temporal
            

            vta.Vendide = this.pventemporalaborrar;
            int resultado = vta.spEliminarventatemporal();
            if (resultado != 0)
            {
                MessageBox.Show("Se produjo un error al eliminar el pedido!.");
            }

            if (vta.ventipofactura == "A")
            {
                this.imprimirticketNuevaA();
                //this.imprimirticketNuevaAIFU();
            }
            else if(vta.ventipofactura == "B")
            {
                this.imprimirticketNuevaB();
                //this.imprimirticketNuevaBIFU();
            }
            else
            { 
                if (MessageBox.Show("¿Desea imprimir la venta?", "Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                   // if (vta.ventipofactura == "T")
                   // {//hugohugo
                        this.imprimirticketNueva();
                        //this.imprimirticketNuevaIFU();
                   // }
                   /* else if (vta.ventipofactura == "A")
                    {
                         this.imprimirticketNuevaA();
                        //this.imprimirticketNuevaAIFU();
                    }
                    else
                    {
                        this.imprimirticketNuevaB();
                        //this.imprimirticketNuevaBIFU();
                    }*/

                    //guardar el número de ticket de la impresora fiscal
                
                
                    //this.Ultimavta

                }
                else //imprimir en la tiqueadora
                {
                    this.imprimirtiqueadora();
                }
            }
            this.resetearloscontroles();
        }


        private void resetearloscontroles()
        {

        }

        private void guardarventadetalle()
        {
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                
                vta.Vendide = this.Ultimavta;
                vta.Vendliide = Convert.ToString(row.Cells[1].Value);
                vta.vendimporteu = Convert.ToString(row.Cells[4].Value);
                vta.vendimporteuC = Convert.ToString(row.Cells[6].Value);
                vta.vendimporte = Convert.ToString(row.Cells[5].Value);
                vta.vendimporteC = Convert.ToString(row.Cells[7].Value);
                vta.Vendcantidad = Convert.ToInt32(row.Cells[0].Value);

                vta.vendvaloriva = Convert.ToString(row.Cells[8].Value);
                vta.vendvalorivaC = Convert.ToString(row.Cells[11].Value);
                vta.vendimporteiva = Convert.ToString(row.Cells[9].Value);
                vta.vendimporteivaC = Convert.ToString(row.Cells[12].Value);

                vta.vendiva = Convert.ToString(row.Cells[10].Value);

                if (Convert.ToString(row.Cells[10].Value) == "0")
                {
                    vta.vendtieneiva = 0;
                    //vta.vendimporteiva21 = Convert.ToString(row.Cells[10].Value);
                }
                else if (Convert.ToString(row.Cells[10].Value) == "21")
                {
                    vta.vendtieneiva = 1;
                    vta.vendimporteiva21 = Convert.ToString(row.Cells[10].Value);
                }
                else
                {
                    vta.vendtieneiva = 1;
                    vta.vendimporteiva1050 = Convert.ToString(row.Cells[10].Value);
                }
                

                int valord = vta.spVentaProductoDetalle();


            }
        }


        private void guardarproformadetalle()
        {
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {

                vta.Vendide = this.Ultimavta;
                vta.Vendliide = Convert.ToString(row.Cells[1].Value);
                vta.vendimporteu = Convert.ToString(row.Cells[4].Value);
                vta.vendimporteuC = Convert.ToString(row.Cells[6].Value);
                vta.vendimporte = Convert.ToString(row.Cells[5].Value);
                vta.vendimporteC = Convert.ToString(row.Cells[7].Value);
                vta.Vendcantidad = Convert.ToInt32(row.Cells[0].Value);

                vta.vendvaloriva = Convert.ToString(row.Cells[8].Value);
                vta.vendvalorivaC = Convert.ToString(row.Cells[11].Value);
                vta.vendimporteiva = Convert.ToString(row.Cells[9].Value);
                vta.vendimporteivaC = Convert.ToString(row.Cells[12].Value);

                vta.vendiva = Convert.ToString(row.Cells[10].Value);

                if (Convert.ToString(row.Cells[10].Value) == "0")
                {
                    vta.vendtieneiva = 0;
                    //vta.vendimporteiva21 = Convert.ToString(row.Cells[10].Value);
                }
                else if (Convert.ToString(row.Cells[10].Value) == "21")
                {
                    vta.vendtieneiva = 1;
                    vta.vendimporteiva21 = Convert.ToString(row.Cells[10].Value);
                }
                else
                {
                    vta.vendtieneiva = 1;
                    vta.vendimporteiva1050 = Convert.ToString(row.Cells[10].Value);
                }


                int valord = vta.spProformaDetalle();


            }
        }

        private void guardarventadetalledefinitiva()
        {
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                /*double valorantiguo = Convert.ToDouble(row.Cells[6].Value);
                row.Cells[4].Value = valorantiguo;

                double valorantiguo1 = Convert.ToDouble(row.Cells[7].Value);
                row.Cells[5].Value = valorantiguo1;
                */
               
                vta.Vendide = this.Ultimavta;
                vta.Vendliide = Convert.ToString(row.Cells[1].Value);
                vta.vendimporteu = Convert.ToString(row.Cells[4].Value);
                vta.vendimporteuC = Convert.ToString(row.Cells[6].Value);
                vta.vendimporte = Convert.ToString(row.Cells[5].Value);
                vta.vendimporteC = Convert.ToString(row.Cells[7].Value);
                vta.Vendcantidad = Convert.ToInt32(row.Cells[0].Value);

                vta.vendvaloriva = Convert.ToString(row.Cells[8].Value);
                vta.vendvalorivaC = Convert.ToString(row.Cells[11].Value);
                vta.vendimporteiva = Convert.ToString(row.Cells[9].Value);
                vta.vendimporteivaC = Convert.ToString(row.Cells[12].Value);

                vta.vendiva = Convert.ToString(row.Cells[10].Value);

                if (Convert.ToString(row.Cells[10].Value) == "0")
                {
                    vta.vendtieneiva = 0;
                    //vta.vendimporteiva21 = Convert.ToString(row.Cells[10].Value);
                }
                vta.vendtieneiva = 1;
                vta.vendimporteiva21 = Convert.ToString(row.Cells[10].Value);
                /*else if (Convert.ToString(row.Cells[10].Value) == "21")
                {
                    vta.vendtieneiva = 1;
                    vta.vendimporteiva21 = Convert.ToString(row.Cells[10].Value);
                }
                else
                {
                    vta.vendtieneiva = 1;
                    vta.vendimporteiva1050 = Convert.ToString(row.Cells[10].Value);
                }*/


                int valord = vta.spVentaProductoDetalledefinitiva();

                //descontar del stock
                Productos pro = new Productos();
                pro.Cantidad = vta.Vendcantidad;
                pro.Codigo = vta.Vendliide;
                pro.Importevta = vta.venimporte;
                pro.NrodeVta = this.Ultimavta;
                pro.DescontarStock();
                /*int descuentodels = vta.spDescuentodelStockproducto();
                if (descuentodels != 0)
                {
                    MessageBox.Show("Hubo un error al descontar el stock");
                }*/
            }
        }
        private void eliminardatosdelformulario()
        {
            dgvProductos.Rows.Clear();
            dgvProductos.Refresh();
            lbcantidadpro.Text = "0";
            lbimp21.Text = "0";
            lbiva21.Text = "0";
            lbimp10.Text = "0";
            lbiva10.Text = "0";
            lbexcento.Text = "0";
            
            LUComprobante.EditValue = 1;
            lbcomprador.Text = "Consumidor final";
            lbcomdire.Text = "Dirección";
            lbcomcuit.Text = "CUIT";
            lbcomtipo.Text = "Consumidor final";
            lbtipoiva.Text = "F";
            btncobrar.Enabled = false;
            button1.Enabled = true;
            btndebito.Enabled = true;
            btncredito.Enabled = true;
            btncuotas.Enabled = true;
            btnahora12.Enabled = true;
            btncreditop.Enabled = true;
            btnproforma.Enabled = true;
            LUComprobante.Enabled = true;
            lbtotalg.Text = "0";
            totalg = 0;
        }

        public void aplicadescuento(int descuent,string tipopag, int tipop)
        {
            double _valoriva21 = 0, _importeiva21 = 0, _exento = 0, _valoriva10 = 0, _importeiva10 = 0;
            double ivaval=0, ivaimpor=0;
            this.aplicades(descuent);
            if (MessageBox.Show("¿Está seguro/a que desea realizar el pedido "+ tipopag +"", "Realizar Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.guardarventamaestro(tipop);
                this.eliminardatosdelformulario();
            }
            else
            {
                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    double valorantiguo = Convert.ToDouble(row.Cells[6].Value);
                    row.Cells[4].Value = valorantiguo;

                    double valorantiguo1 = Convert.ToDouble(row.Cells[7].Value);
                    row.Cells[5].Value = valorantiguo1;

                    row.Cells[8].Value = Convert.ToDouble(row.Cells[11].Value);
                    row.Cells[9].Value = Convert.ToDouble(row.Cells[12].Value);

                    ivaval = ivaval + Convert.ToDouble(row.Cells[8].Value);
                    ivaimpor = ivaimpor + Convert.ToDouble(row.Cells[9].Value);
                    
                    if (Convert.ToString(row.Cells[10].Value) == "21")
                    {
                        _valoriva21 = _valoriva21 + Convert.ToDouble(row.Cells[8].Value);
                        _importeiva21 = _importeiva21 + Convert.ToDouble(row.Cells[9].Value);

                    }
                    else if (Convert.ToString(row.Cells[10].Value) == "0")
                    {
                        _exento = _exento + Convert.ToDouble(row.Cells[7].Value);
                    }
                    else
                    {
                        _valoriva10 = _valoriva10 + Convert.ToDouble(row.Cells[8].Value);
                        _importeiva10 = _importeiva10 + Convert.ToDouble(row.Cells[9].Value);
                    }

                }
                lbtotalg.Text = Convert.ToString(this.totalanterior);
                lbimp21.Text = Convert.ToString(_valoriva21);
                lbiva21.Text = Convert.ToString(_importeiva21);
                lbimp10.Text = Convert.ToString(_valoriva10);
                lbiva10.Text = Convert.ToString(_importeiva10);
                lbexcento.Text = Convert.ToString(_exento);
            }
        }

        public void aplicadescuentoCobrar(int descuent, int tipop)
        {
            double _valoriva21 = 0, _importeiva21 = 0, _exento = 0, _valoriva10 = 0, _importeiva10 = 0;
            double ivaval = 0, ivaimpor = 0;
            this.aplicades(descuent);
            if (MessageBox.Show("¿Está seguro/a que desea modificar el tipo de pago?", "Realizar Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                //acá no hacer nada
                retornar = 1;
                ptipopagide = ptipopagideNuevo;
            }
            else
            {
                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    double valorantiguo = Convert.ToDouble(row.Cells[13].Value);
                    row.Cells[4].Value = valorantiguo;

                    double valorantiguo1 = Convert.ToDouble(row.Cells[14].Value);
                    row.Cells[5].Value = valorantiguo1;

                    row.Cells[8].Value = Convert.ToDouble(row.Cells[11].Value);
                    row.Cells[9].Value = Convert.ToDouble(row.Cells[12].Value);

                    ivaval = ivaval + Convert.ToDouble(row.Cells[8].Value);
                    ivaimpor = ivaimpor + Convert.ToDouble(row.Cells[9].Value);

                    if (Convert.ToString(row.Cells[10].Value) == "21")
                    {
                        _valoriva21 = _valoriva21 + Convert.ToDouble(row.Cells[8].Value);
                        _importeiva21 = _importeiva21 + Convert.ToDouble(row.Cells[9].Value);

                    }
                    else if (Convert.ToString(row.Cells[10].Value) == "0")
                    {
                        _exento = _exento + Convert.ToDouble(row.Cells[7].Value);
                    }
                    else
                    {
                        _valoriva10 = _valoriva10 + Convert.ToDouble(row.Cells[8].Value);
                        _importeiva10 = _importeiva10 + Convert.ToDouble(row.Cells[9].Value);
                    }

                }
                lbtotalg.Text = Convert.ToString(this.totalanterior);
                lbimp21.Text = Convert.ToString(_valoriva21);
                lbiva21.Text = Convert.ToString(_importeiva21);
                lbimp10.Text = Convert.ToString(_valoriva10);
                lbiva10.Text = Convert.ToString(_importeiva10);
                lbexcento.Text = Convert.ToString(_exento);
            }
        }


        public void aplicadescuento1(int descuent)
        {
            this.aplicades(descuent);
            if (MessageBox.Show("¿Está seguro/a que desea modificar el tipo de pago?", "Modifica tipo de pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                //acá no hacer nada
                retornar = 1;
                ptipopagide = ptipopagideNuevo;
            }
            else
            {
                retornar = 0;
                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    double valorantiguo = Convert.ToDouble(row.Cells[6].Value);
                    row.Cells[4].Value = valorantiguo;

                    double valorantiguo1 = Convert.ToDouble(row.Cells[7].Value);
                    row.Cells[5].Value = valorantiguo1;

                    row.Cells[8].Value = Convert.ToDouble(row.Cells[11].Value);
                    row.Cells[9].Value = Convert.ToDouble(row.Cells[12].Value);
                }
                lbtotalg.Text = Convert.ToString(this.totalanterior);
            }

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
            if (e.KeyCode == Keys.Enter)
            {
                this.aplicades(Convert.ToInt32(txtdescuento.Text));
            }
        }

        private void puedeimprimir()
        {
            if (Globales.imprimirfactura != 2)
            {
                MessageBox.Show("Recuerde que no puede imprimir, sólo hacer un pedido!");
                this.deshabilitarimprime();
            }
            else
            {
                Elegirpto ele = new Elegirpto();
                ele.ShowDialog();
                lbpuntovta.Text = Convert.ToString(Globales.puntodeventa);
                DineroCaja dc = new DineroCaja();
                int cargocaja = dc.spVerDineroCaja();
                if (cargocaja == 0)
                {
                    ConsultaPlataCaja cpc = new ConsultaPlataCaja();
                    cpc.Verhoy = 1;
                    cpc.ShowDialog();
                }
            }   
        }

        private int buscarnumeroped()
        {
            double contariva=0,contarivaimporte = 0;
            MySqlDataReader reader = null;

            TempVenta tv = new TempVenta();
            tv.Venide = Convert.ToInt32(txtnumeropedido.Text);
            reader = tv.Mostrarpedidos();

            //elimina todos los productos!
            this.eliminarTodosproductos();

            if (reader.HasRows != false)
            {
                while (reader.Read())
                {

                    pcantidadelegida = reader["VEND_CANTIDAD"].ToString();
                    pcodigo = reader["VEND_LI_IDE"].ToString();
                    pnombre = reader["LI_DESC"].ToString();
                    peditorialu = reader["EDI_EDITORIAL"].ToString();
                    ppreciou = reader["VEND_IMPORTEU"].ToString();
                    psubtotal = reader["VEND_IMPORTE"].ToString();
                    ppreciouc = reader["VEND_IMPORTEUC"].ToString();
                    psubtotalc = reader["VEND_IMPORTEC"].ToString();
                    pivavalor = reader["VEND_VALORIVA"].ToString();
                    pimportedeliva = reader["VEND_IMPORTEIVA"].ToString();
                    piva = reader["VEND_IVA"].ToString();

                    ppivavalor = reader["VEND_VALORIVAC"].ToString();
                    ppimportedeliva = reader["VEND_IMPORTEIVAC"].ToString();
                    ppivavalor10 = reader["VEN_IMP1050"].ToString();
                    ppimportedeliva10 = reader["VEN_IMPIVA1050"].ToString();

                    ptipofactu = reader["VEN_TIPOFACTU"].ToString();
                    ptipopag = reader["TIP_DESC"].ToString();
                    ptipopagide = Convert.ToInt32(reader["VEN_TIP_IDE"]);

                    pventotal = Convert.ToDouble(reader["VEN_TOTAL"]);

                    pventemporalaborrar = Convert.ToInt32(reader["VEN_IDE"]);

                    pusuariopedidoide = Convert.ToInt32(reader["VEN_VENUSU_IDE"]);

                    pvenimp21 = Convert.ToDecimal(reader["VEN_IMP21"]);
                    pveniva21 = Convert.ToDecimal(reader["VEN_IVA21"]);
                    pvenimp10 = Convert.ToDecimal(reader["VEN_IMP1050"]);
                    pveniva10 = Convert.ToDecimal(reader["VEN_IMPIVA1050"]);
                    pexento = Convert.ToDouble(reader["VEN_EXENTO"]);
                    pnombrecli = reader["VEN_NOMBRE"].ToString();
                    pcuit = reader["VEN_CUIT"].ToString();
                    pdire = reader["VEN_DIRE"].ToString();
                    ptipo = reader["VEN_TIPI_IDE"].ToString();

                    string[] row1 = new string[] { pcantidadelegida, pcodigo, pnombre, peditorialu, ppreciou, psubtotal, ppreciouc, psubtotalc, pivavalor, pimportedeliva, piva, ppivavalor, ppimportedeliva, ppreciou, psubtotal };
                    rowsenviar = new object[] { row1 };
                    
                    AgregarProducto(rowsenviar, pventotal, Convert.ToDouble(pivavalor), Convert.ToDouble(pimportedeliva), Convert.ToDouble(piva),Convert.ToInt32(pcantidadelegida));
                    lbtotalg.Text = Convert.ToString(pventotal);
                    lbimp21.Text = Convert.ToString(pvenimp21);
                    lbiva21.Text = Convert.ToString(pveniva21);
                    lbimp10.Text = Convert.ToString(pvenimp10);
                    lbiva10.Text = Convert.ToString(pveniva10);
                    totalg = Convert.ToDouble(lbtotalg.Text);
                    //vivavalor = Convert.ToDouble(lbimp21.Text);
                    //vivaimporte = Convert.ToDouble(lbiva21.Text);


                    
                    contariva = contariva + Convert.ToDouble(pivavalor);
                    contarivaimporte = contarivaimporte + Convert.ToDouble(pimportedeliva);
                    /*
                        
                        string[] row1 = new string[] { cantidadelegida , codigo, nombre,
                        editorialu,preciou,subtotal,preciouc,subtotalc,Convert.ToString(ivavalor),Convert.ToString(importedeliva),Convert.ToString(iva),Convert.ToString(ivavalor),Convert.ToString(importedeliva)};
                        object[] rowsenviar = new object[] { row1 };

                        formdeInterface1.AgregarProducto(rowsenviar,Convert.ToDouble(subtotal));*/
                }
                nopedirclienteA = 1;
                if (ptipofactu == "T")
                {
                    LUComprobante.EditValue = 1;
                }
                else if (ptipofactu == "B")
                {
                    LUComprobante.EditValue = 3;
                    lbcomprador.Text = pnombrecli;
                    lbcomdire.Text = pdire;
                    // lbcomtipo.Text = ptipo;
                    lbcomcuit.Text = pcuit;
                    lbtipoiva.Text = ptipo;
                }
                else
                {
                    LUComprobante.EditValue = 2;
                    lbcomprador.Text = pnombrecli;
                    lbcomdire.Text = pdire;
                    lbcomtipo.Text = "RESP. INSCRIPTO";
                    lbtipoiva.Text = ptipo;
                    lbcomcuit.Text = pcuit;
                }
                LUComprobante.Enabled = false;
                nopedirclienteA = 0;
                lbtipopago.Text = ptipopag;
                lbexcento.Text = Convert.ToString(pexento);
               // lbimp21.Text = Convert.ToString(contariva);
               // lbiva21.Text = Convert.ToString(contarivaimporte);
                btncobrar.Focus();
                return 1;
            }
            else
            {
                MessageBox.Show("No existe el número de pedido!");
                return 0;
                
            }

        }


        private int buscarnumeroprof()
        {
            double contariva = 0, contarivaimporte = 0;
            MySqlDataReader reader = null;

            TempVenta tv = new TempVenta();
            tv.Venide = Convert.ToInt32(txtproforma.Text);
            reader = tv.Mostrarproforma();

            //elimina todos los productos!
            this.eliminarTodosproductos();

            if (reader.HasRows != false)
            {
                while (reader.Read())
                {

                    pcantidadelegida = reader["VEND_CANTIDAD"].ToString();
                    pcodigo = reader["VEND_LI_IDE"].ToString();
                    pnombre = reader["LI_DESC"].ToString();
                    peditorialu = reader["EDI_EDITORIAL"].ToString();
                    ppreciou = reader["VEND_IMPORTEU"].ToString();
                    psubtotal = reader["VEND_IMPORTE"].ToString();
                    ppreciouc = reader["VEND_IMPORTEUC"].ToString();
                    psubtotalc = reader["VEND_IMPORTEC"].ToString();
                    pivavalor = reader["VEND_VALORIVA"].ToString();
                    pimportedeliva = reader["VEND_IMPORTEIVA"].ToString();
                    piva = reader["VEND_IVA"].ToString();

                    ppivavalor = reader["VEND_VALORIVAC"].ToString();
                    ppimportedeliva = reader["VEND_IMPORTEIVAC"].ToString();
                    ppivavalor10 = reader["VEN_IMP1050"].ToString();
                    ppimportedeliva10 = reader["VEN_IMPIVA1050"].ToString();

                    ptipofactu = reader["VEN_TIPOFACTU"].ToString();
                    ptipopag = reader["TIP_DESC"].ToString();
                    ptipopagide = Convert.ToInt32(reader["VEN_TIP_IDE"]);

                    pventotal = Convert.ToDouble(reader["VEN_TOTAL"]);

                    pventemporalaborrar = Convert.ToInt32(reader["VEN_IDE"]);

                    pusuariopedidoide = Convert.ToInt32(reader["VEN_VENUSU_IDE"]);

                    pvenimp21 = Convert.ToDecimal(reader["VEN_IMP21"]);
                    pveniva21 = Convert.ToDecimal(reader["VEN_IVA21"]);
                    pvenimp10 = Convert.ToDecimal(reader["VEN_IMP1050"]);
                    pveniva10 = Convert.ToDecimal(reader["VEN_IMPIVA1050"]);
                    pexento = Convert.ToDouble(reader["VEN_EXENTO"]);
                    pnombrecli = reader["VEN_NOMBRE"].ToString();
                    pcuit = reader["VEN_CUIT"].ToString();
                    pdire = reader["VEN_DIRE"].ToString();
                    ptipo = reader["VEN_TIPI_IDE"].ToString();

                    string[] row1 = new string[] { pcantidadelegida, pcodigo, pnombre, peditorialu, ppreciou, psubtotal, ppreciouc, psubtotalc, pivavalor, pimportedeliva, piva, ppivavalor, ppimportedeliva };
                    rowsenviar = new object[] { row1 };

                    AgregarProducto(rowsenviar, pventotal, Convert.ToDouble(pivavalor), Convert.ToDouble(pimportedeliva), Convert.ToDouble(piva), Convert.ToInt32(pcantidadelegida));
                    lbtotalg.Text = Convert.ToString(pventotal);
                    lbimp21.Text = Convert.ToString(pvenimp21);
                    lbiva21.Text = Convert.ToString(pveniva21);
                    lbimp10.Text = Convert.ToString(pvenimp10);
                    lbiva10.Text = Convert.ToString(pveniva10);
                    totalg = Convert.ToDouble(lbtotalg.Text);
                    //vivavalor = Convert.ToDouble(lbimp21.Text);
                    //vivaimporte = Convert.ToDouble(lbiva21.Text);



                    contariva = contariva + Convert.ToDouble(pivavalor);
                    contarivaimporte = contarivaimporte + Convert.ToDouble(pimportedeliva);
                    /*
                        
                        string[] row1 = new string[] { cantidadelegida , codigo, nombre,
                        editorialu,preciou,subtotal,preciouc,subtotalc,Convert.ToString(ivavalor),Convert.ToString(importedeliva),Convert.ToString(iva),Convert.ToString(ivavalor),Convert.ToString(importedeliva)};
                        object[] rowsenviar = new object[] { row1 };

                        formdeInterface1.AgregarProducto(rowsenviar,Convert.ToDouble(subtotal));*/
                }
                nopedirclienteA = 1;
                if (ptipofactu == "T")
                {
                    LUComprobante.EditValue = 1;
                }
                else if (ptipofactu == "B")
                {
                    LUComprobante.EditValue = 3;
                    lbcomprador.Text = pnombrecli;
                    lbcomdire.Text = pdire;
                    // lbcomtipo.Text = ptipo;
                    lbcomcuit.Text = pcuit;
                    lbtipoiva.Text = ptipo;
                }
                else
                {
                    LUComprobante.EditValue = 2;
                    lbcomprador.Text = pnombrecli;
                    lbcomdire.Text = pdire;
                    lbcomtipo.Text = "RESP. INSCRIPTO";
                    lbtipoiva.Text = ptipo;
                    lbcomcuit.Text = pcuit;
                }
                //LUComprobante.Enabled = false;
                nopedirclienteA = 0;
                lbtipopago.Text = ptipopag;
                lbexcento.Text = Convert.ToString(pexento);
                // lbimp21.Text = Convert.ToString(contariva);
                // lbiva21.Text = Convert.ToString(contarivaimporte);
                btncobrar.Focus();
                return 1;
            }
            else
            {
                MessageBox.Show("No existe el número de proforma!");
                return 0;

            }

        }
        private void deshabilitarbotones()
        {
            button1.Enabled = false;
            btndebito.Enabled = false;
            btncredito.Enabled = false;
            btncuotas.Enabled = false;
            btnahora12.Enabled = false;
            btncredito.Enabled = false;
            btncreditop.Enabled = false;
            btnproforma.Enabled = false;
        }
        
        private void txtnumeropedido_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            
            if (e.KeyCode == Keys.Enter)
            {
                if (txtnumeropedido.Text != string.Empty)
                {
                    //   lbvivavalor.Text = "0";
                    //   lbvivaimporte.Text = "0";

                    int valor = this.buscarnumeroped();
                    if (valor == 1)
                    { 
                        this.deshabilitarbotones();
                        this.btncobrar.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar el número a buscar");   
                }

            }
        }

        private void txtproforma_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {
                if (txtproforma.Text != string.Empty)
                {
                    //   lbvivavalor.Text = "0";
                    //   lbvivaimporte.Text = "0";

                    int valor = this.buscarnumeroprof();
                    if (valor == 1)
                    {
                        this.deshabilitarbotones();
                        this.btnproforma.Enabled = true;
                        this.btncobrar.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar el número a buscar");
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            { 
                Tipodepago tp = new Tipodepago();
                int valor = tp.spConsultaInteres(1);
                this.aplicadescuento(valor," En Efectivo?",1);
            }

        }

        private void deshabilitarimprime()
        {
            txtdescuento.Enabled = false;
            btncargapedido.Enabled = false;
            lbpunto.Visible = false;
            lbpuntovta.Visible = false;
            btncobrar.Visible = false;
            txtnumeropedido.Enabled = false;
            btncreditop.Enabled = false;
            txtproforma.Enabled = false;
            btnplatacaja.Enabled = false;
            btnajuste.Enabled = false;
        }



        public void eliminarTodosproductos()
        {
            
              dgvProductos.Rows.Clear();
            
        }

        

        public void aplicadescuentoC(int descu)
        {
            //acá se modificó el tipo de pago
            //ver si se usar
            /*foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                row.Cells[4].Value = row.Cells[6].Value;
                row.Cells[5].Value = row.Cells[7].Value;
            }*/
                this.aplicades(descu);
            Cobrar.totalapag = lbtotalg.Text;
        }

        public void guardarventa()
        {
            this.guardarventadefinitiva();
        }

        int ICobrar.tipodepagoelegidoC(int tippag)
        {
            Tipodepago tp = new Tipodepago();
            int valordes = tp.spConsultaInteres(tippag);
            ptipopagideNuevo = tippag;
            
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                row.Cells[4].Value = row.Cells[6].Value;
                row.Cells[5].Value = row.Cells[7].Value;
            }
            this.aplicadescuentoCobrar(valordes, tippag);
           // this.aplicadescuento1(valordes);
            Cobrar.totalapag = lbtotalg.Text;
            
            return retornar;
        }


        
        public void selecciondecliente(string cuit, string nombre, string dire, string tipo, string tipoletra)
        {
            lbcomcuit.Text = cuit;
            lbcomprador.Text = nombre;
            lbcomdire.Text = dire;
            lbcomtipo.Text = tipo;
            lbtipoiva.Text = tipoletra;

            if (tipoletra == "I")
            {
                MessageBox.Show("El cliente es RESPONSABLE INSCRIPTO, se realizará la impresión de Ticket/Factura A");
                LUComprobante.EditValue = 2;
            }
            else
            {
                if (Convert.ToInt32(LUComprobante.EditValue) == 2)
                {
                    LUComprobante.EditValue = 1;
                }
            }
        }

        public void AgregarProducto(object[] rows, double subtotalg, double valoriv, double importeiv, double niva, int cantidadeleg)
        {
            foreach (string[] rowArray in rows)
            {
                dgvProductos.Rows.Add(rowArray);
            }

            totalg = totalg + subtotalg;
            // vivavalor = vivavalor + valoriv;
            // vivaimporte = vivaimporte + importeiv;



            lbtotalg.Text = Convert.ToString(totalg);
            if (niva == 0)
            {
                // MessageBox.Show("0");

                vivaexcento = vivaexcento + subtotalg;
                lbexcento.Text = Convert.ToString(vivaexcento);
                // lbiva21.Text = Convert.ToString(vivaimporte);

            }
            else if (niva == 21)
            {
                // MessageBox.Show("21");
                vivavalor21 = vivavalor21 + valoriv;
                vivaimporte21 = vivaimporte21 + importeiv;

                lbiva21.Text = Convert.ToString(vivaimporte21);
                lbimp21.Text = Convert.ToString(vivavalor21);
            }
            else
            {
                // MessageBox.Show("105");
                vivavalor105 = vivavalor105 + valoriv;
                vivaimporte105 = vivaimporte105 + importeiv;
                lbimp10.Text = Convert.ToString(vivavalor105);
                lbiva10.Text = Convert.ToString(vivaimporte105);

            }
            lbcantidadpro.Text = Convert.ToString(Convert.ToInt32(lbcantidadpro.Text) + cantidadeleg);
        }

        public void AgregarProducto(object[] rows, double subtotalg, double valoriv, double importeiv, double niva, int cantidadeleg, string barra)
        {
            throw new NotImplementedException();
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
