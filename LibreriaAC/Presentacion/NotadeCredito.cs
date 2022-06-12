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

namespace Presentacion
{
    public partial class NotadeCredito : Form, IForm, IClientes
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

        /* Globa variable */
       // private bool _WorkThreadRunning = false;



        double totalg, valorcondescuento, totalanterior,ivacondescuento,importeivacondescuento;
        double vivavalor21, vivaimporte21, vivavalor105, vivaimporte105,vivaexcento;
        double pvenimp21, pveniva21, pvenimp10, pveniva10;
        //para cargar pedidos
        string pcantidadelegida,pcodigo, pnombre, peditorialu,ppreciou, psubtotal, ppreciouc,psubtotalc, pivavalor, pimportedeliva, piva, ppivavalor, ppimportedeliva, ppivavalor10, ppimportedeliva10,
pnombrecli, pcuit, pdire, ptipo;
        string ptipofactu, ptipopag;
        int ptipopagide, ptipopagideNuevo=0, retornar,pusuariopedidoide, pventemporalaborrar = 0, _notaparcial;
        double pventotal,pexento;
        string nroticket=string.Empty, _puntodev;
        public static int clientecuentacorriente;
        int _tipopago, _ultimavta, _ultimanota, nopedirclienteA = 0;
        object[] rowsenviar;
        Venta vta;
        //private static IFUniversal.ModeloPrn MODELO = IFUniversal.ModeloPrn.modEpsonTMT900FA;
        //private static int PUERTO = 0;
        public NotadeCredito()
        {
            InitializeComponent();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }
        public void Bloquearbotones()
        {
            if (this.NotaParcial == 0)
            {
                btneliminaele.Enabled = false;
            }
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

            buscarnumeroped();
            Bloquearbotones();
            lbpuntovta.Text = this.Puntodev;
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
    
        }

        private void btnagregap_Click(object sender, EventArgs e)
        {
            ConsultaProductosAgrega cpa = new ConsultaProductosAgrega();
            
            cpa.ShowDialog(this);
        }
        private void button2_Click(object sender, EventArgs e)
        {
         /*   Boolean respuesta;
            string x = "X";
            string p = "P";
            respuesta = this.axPrinterFiscal1.CloseJournal(ref x, ref p);*/
        }

        private void imprimirticket()
        {

           // Boolean respuesta;
           // string x = "X";
           // string p = "P";
            //string cantiarti = "Cant. Articulos: 1";
            //string atendido = "Vendedor: Hugo";
            //string controlinterno = "Codigo interno: 1546";

          //  string argumento = "G";
           // respuesta = this.axPrinterFiscal1.OpenTicket(ref argumento);

          //  string estado = "C";
            //respuesta = this.axPrinterFiscal1.Status(ref estado);

           /* string establece = "S";
            string linea11 = "11";
            string linea12 = "12";
            string linea13 = "13";
            */
          /*  this.axPrinterFiscal1.SetGetHeaderTrailer(ref establece, ref linea11, ref controlinterno);
            this.axPrinterFiscal1.SetGetHeaderTrailer(ref establece, ref linea12, ref atendido);
            this.axPrinterFiscal1.SetGetHeaderTrailer(ref establece, ref linea13, ref cantiarti);
            */
           // string articulo = "Mochila negra palo";
         //   string cantidad = Convert.ToString(1 * 1000);
           // string precioUnitario = Convert.ToString(1 * 100);
            //   string iva = Convert.ToString(21 * 100);
          //  string iva = "2100";
          //  string venta = "M";
          //  string bultos = "0";
//string ImpuestosInternos = "0";

         //   string printer = "P";
          //  string texto = "SUB";

//string pago = "Efectivo";
            string importeabona = Convert.ToString(1 * 100);
           // string descripcion = "T";

         /*   this.axPrinterFiscal1.SendTicketItem(ref articulo, ref cantidad, ref precioUnitario, ref iva, ref venta, ref bultos, ref ImpuestosInternos);

            this.axPrinterFiscal1.GetTicketSubtotal(ref printer, ref texto);

            this.axPrinterFiscal1.SendTicketPayment(ref pago, ref importeabona, ref descripcion);

            this.axPrinterFiscal1.CloseTicket();

            this.nroticket = this.axPrinterFiscal1.AnswerField_3;*/
            MessageBox.Show("el número del ticket es:" + nroticket);
           // puntodevta = this.axPrinterFiscal1.AnswerField_4;
           // MessageBox.Show("punto de venta:" + puntodevta);
        }

        private void imprimirticketNueva()
        {
            int tipocomprobante = 3, id_modificador = 200; //1 es ticket 200 agregar venta
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
                error = ImprimirItem(id_modificador, productodesc, cantidad,precio, tasaiva, 0, "", 1, codigointerno, "", 7);
                //error = ImprimirItem(id_modificador, productodesc, cantidad, "231.80", 5, 0, "", 1, "CodigoInterno154", "", 7);

                if (error != ERROR_NINGUNO)
                {
                    MessageBox.Show("Error al imprimir productos: " + error.ToString());
                }
            }


            error = ImprimirSubtotal();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al imprimir subtotal: " + error.ToString());
            }
            error = CargarPago(id_modificador, tipodepago, cuotas, lbtotalg.Text, "", "Efectivo", "", "");
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al cargar pagos: " + error.ToString());
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
        }

       /* private void imprimirticketNuevaIFU()
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

                if (!Fiscal.AbrirComprobante(IFUniversal.TipoDeComprobante.tcTiqueNotaCredito))
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
            int tipocomprobante = 3, id_modificador = 200, ptipodeiva=0; //1 es ticket 200 agregar venta
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
                /* if (iva == "21" || iva == "21.00" || iva == "21,00")
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
                error = ImprimirItem(id_modificador, productodesc, cantidad, precio, tasaiva, 0, "", 1, codigointerno, "", 7);
                //error = ImprimirItem(id_modificador, productodesc, cantidad, "231.80", 5, 0, "", 1, "CodigoInterno154", "", 7);

                if (error != ERROR_NINGUNO)
                {
                    MessageBox.Show("Error al imprimir productos: " + error.ToString());
                }
            }
            error = ImprimirSubtotal();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al imprimir subtotal: " + error.ToString());
            }
            error = CargarPago(id_modificador, tipodepago, cuotas, lbtotalg.Text, "", "Efectivo", "", "");
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al cargar pagos: " + error.ToString());
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


                if (!Fiscal.AbrirComprobante(IFUniversal.TipoDeComprobante.tcNota_Credito_B))
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
            int tipocomprobante = 3, id_modificador = 200, ptipodeiva = 0; //1 es ticket 200 agregar venta
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
                error = ImprimirItem(id_modificador, productodesc, cantidad, precio, tasaiva, 0, "", 1, codigointerno, "", 7);
                //error = ImprimirItem(id_modificador, productodesc, cantidad, "231.80", 5, 0, "", 1, "CodigoInterno154", "", 7);

                if (error != ERROR_NINGUNO)
                {
                    MessageBox.Show("Error al imprimir productos: " + error.ToString());
                }
            }
            error = ImprimirSubtotal();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al imprimir subtotal: " + error.ToString());
            }
            error = CargarPago(id_modificador, tipodepago, cuotas, lbtotalg.Text, "", "Efectivo", "", "");
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al cargar pagos: " + error.ToString());
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


                if (!Fiscal.AbrirComprobante(IFUniversal.TipoDeComprobante.tcNota_Credito_A))
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
                
                MessageBox.Show("Comprobante impreso exitosamente");

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }

        }
        */
        private void LUComprobante_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(LUComprobante.EditValue) == 1)
            {
                if (lbtipoiva.Text == "I")
                {
                    lbcomprador.Text = "Consumidor final";
                    lbcomdire.Text = "Dirección";
                    lbcomcuit.Text = "CUIT";
                    lbcomtipo.Text = "Consumidor final";
                    lbtipoiva.Text = "F";
                    //ConsultaCliente cc = new ConsultaCliente();
                    //cc.ShowDialog(this);
                }
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
                

                totalg = totalg - precioasacar;
                totalg = Math.Round(totalg, 2, MidpointRounding.AwayFromZero);

                int canti = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
                lbcantidadpro.Text = Convert.ToString(Convert.ToInt32(lbcantidadpro.Text) - canti);

                if (iva == 0)
                {
                    lbexcento.Text = Convert.ToString(Convert.ToDouble(lbexcento.Text) - precioasacar);
                    lbexcento.Text = Convert.ToString(Math.Round(Convert.ToDouble(lbexcento.Text), 2, MidpointRounding.AwayFromZero));
                    lbexcento.Text = lbexcento.Text.Replace(",", ".");
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
                lbtotalg.Text = lbtotalg.Text.Replace(",", ".");

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
           // int tipocomprobante = 2, id_modificador = 200, ptipodeiva = 0; //1 es ticket 200 agregar venta
            string productodesc = string.Empty; //descripción del producto
            string cantidad, precio, iva, codigointerno;
            double preciod;
            //const int ERROR_NINGUNO = 0;
            //int cuotas = 1;

            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
               // string preciotemporal;
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
                    this.eliminardatosdelformulario();
                    Proforma pro = new Proforma();
                    pro.Ide = this.Ultimavta;
                    pro.recorrergrilla();
                    pro.ShowDialog();
                }
            }
           
        }

        private void btncargapedido_Click(object sender, EventArgs e)
        {

        }

        private void btncobrar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count <= 0)
            { 
                MessageBox.Show("Debe tener algún producto para crear una nota de crédito");
            }else
            {
                /* Cobrar co = new Cobrar();
                 co.seteartipopago(ptipopagide);
                 co.setearimporte(lbtotalg.Text);
                 co.inicio();
                 co.ShowDialog(this);*/
                this.guardarnotadecredito();
                //this.eliminardatosdelformulario();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Dispose();
                this.Hide();
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
            vta.venimp21 = lbimp21.Text;
            vta.venIVA21 = lbiva21.Text;
            vta.venimp105 = lbimp10.Text;
            vta.venIVA105 = lbiva10.Text;
            vta.venimpexcento = lbexcento.Text;

           

            //Si es tipo crédito
            if (tipop2 == 12)
            {
                vta.venccorriente = Facturar.clientecuentacorriente;
            }

            //faltan los parámetros de la tabla cuentacorriente.

            int valor = vta.spVentaProducto();
            MessageBox.Show("El número del pedido es: " + valor);
            this.Ultimavta = valor;
            this.guardarventadetalle();
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

        private void guardarnotadecred()
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
            vta.venimp21 = lbimp21.Text;
            vta.venIVA21 = lbiva21.Text;
            vta.venimp105 = lbimp10.Text;
            vta.venIVA105 = lbiva10.Text;
            vta.venimpexcento = lbexcento.Text;
            vta.venusuventapedido = this.pusuariopedidoide;
            vta.VentaidparaNota = this.Ultimavta;
            vta.Obs = txtobs.Text;
            int valor = vta.spNotadeCredito();
            if (valor == 1)
            {
                MessageBox.Show("No se guardó la nota de crédito");
                string valores = string.Empty;
                valores = "nombre: " + vta.Vennombre + " Cuit: " + vta.Vencuit + "direccion: " + vta.Vendireccion;
                valores = valores + "Iva: " + vta.Ventipoiva + "Importe: " + vta.venimporte + "pago: " + vta.ventipopago + "Total: " + vta.ventotal;
                valores = valores + "Tipo: " + vta.ventipofactura + "Importe 21: " + vta.venimp21;
                valores = valores + "Iva 21: " + vta.venIVA21 + "Importe10: " + vta.venimp105 + "Iva10: "+ vta.venIVA105 + "Importe excento: " + vta.venimpexcento + "tipo Usuario: " + vta.venusuventapedido + "descuento: " + vta.vendescuento;
                valores = valores + "Imprimir: " + Globales.imprimirfactura;
                MessageBox.Show(valores);
            }else
            { 

            MessageBox.Show("El número de la nota de crédito es: " + this.Ultimavta);
            this.UltimaNota = this.Ultimavta;
            this.guardarnotadecreditodetalle();
                //borrar el temporal
                if (MessageBox.Show("¿Desea imprimir la nota de crédito?", "Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (vta.ventipofactura == "T")
                    {
                        this.imprimirticketNueva();
                        //this.imprimirticketNuevaIFU();
                    }
                    else if (vta.ventipofactura == "A")
                    {
                        this.imprimirticketNuevaA();
                        //this.imprimirticketNuevaAIFU();
                    }
                    else
                    {
                        this.imprimirticketNuevaB();
                        //this.imprimirticketNuevaBIFU();
                    }
                    //guardar que se imprimió en la fiscal
                    int valord = vta.spMarcarImprimioNotadeCredito();
                    
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

        private void guardarnotadecreditodetalle()
        {
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                /*double valorantiguo = Convert.ToDouble(row.Cells[6].Value);
                row.Cells[4].Value = valorantiguo;

                double valorantiguo1 = Convert.ToDouble(row.Cells[7].Value);
                row.Cells[5].Value = valorantiguo1;
                */
               
                vta.Vendide = this.UltimaNota;
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


                int valord = vta.spNotadeCreditoDetalle();

                //descontar del stock
                Productos pro = new Productos();
                pro.Cantidad = vta.Vendcantidad;
                pro.Codigo = vta.Vendliide;
                pro.Importevta = vta.venimporte;
                pro.NrodeVta = this.Ultimavta;
                pro.Notaparcial = this.NotaParcial;
                pro.DescontarStockNotadecredito();
                pro.colocarventaanulada();

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
            lbtotalg.Text = "0";
            LUComprobante.EditValue = 1;
            lbcomprador.Text = "Consumidor final";
            lbcomdire.Text = "Dirección";
            lbcomcuit.Text = "CUIT";
            lbcomtipo.Text = "Consumidor final";
            lbtipoiva.Text = "F";
            btncobrar.Enabled = false;
            
            LUComprobante.Enabled = true;
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
            retornar = 0;
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
            retornar = 0;
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
             
            }
        }

        
        private int buscarnumeroped()
        {
            double contariva=0,contarivaimporte = 0;
            MySqlDataReader reader = null;

            TempVenta tv = new TempVenta();
            tv.Venide = Ultimavta;//Convert.ToInt32(txtnumeropedido.Text);
            if (this.NotaParcial == 3)
            {
                reader = tv.MostrarventasparanotaVista();
                btncobrar.Visible = false;
                txtobs.Enabled = false;
                btneliminaele.Visible = false;
            }
            else
            {
                reader = tv.Mostrarventasparanota();
            }
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

                    if (this.NotaParcial == 3)
                    {
                        txtobs.Text = reader["VEN_OBS"].ToString();
                    }

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

                    pvenimp21 = Convert.ToDouble(reader["VEN_IMP21"]);
                    pveniva21 = Convert.ToDouble(reader["VEN_IVA21"]);
                    pvenimp10 = Convert.ToDouble(reader["VEN_IMP1050"]);
                    pveniva10 = Convert.ToDouble(reader["VEN_IMPIVA1050"]);
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


        
       
        private void txtnumeropedido_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            
            if (e.KeyCode == Keys.Enter)
            {
                

            }
        }

        private void txtproforma_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {
                

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
           
            lbpunto.Visible = false;
            lbpuntovta.Visible = false;
            btncobrar.Visible = false;
            
            
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

        public void guardarnotadecredito()
        {
            this.guardarnotadecred();
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

        public string Puntodev
        {
            get { return this._puntodev; }
            set { this._puntodev = value; }
        }
        public int NotaParcial
        {
            get { return this._notaparcial; }
            set { this._notaparcial = value; }
        }
        public int UltimaNota
        {
            get { return this._ultimanota; }
            set { this._ultimanota = value; }
        }
    }
}
