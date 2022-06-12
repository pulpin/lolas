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
    public partial class AltaAdopcion : Form, IForm, IClientes
    {
        /* -----------------------------------------------------------------------------
Typedef from exported Prototypes of "EpsonFiscalInterface.h"
----------------------------------------------------------------------------- */
        Adopcion ado = new Adopcion();
        double totalg;
        int _esc_ide, _cursoide, _division, _turnos, _localidad;
        int ptipopagideNuevo, _adoide=0, _cantidadalu, _alta;
        string _obs;
        public static int clientecuentacorriente;
        int _tipopago, _ultimavta;
        object[] rowsenviar;
        Venta vta;
        //private static IFUniversal.ModeloPrn MODELO = IFUniversal.ModeloPrn.modEpsonTMT900FA;
        //private static int PUERTO = 0;
        public AltaAdopcion()
        {
            InitializeComponent();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }
        private void cargar()
        {
            ado.Ide = this.Adoide;
            LUEscuela.Properties.DisplayMember = "esc_desc";
            LUEscuela.Properties.ValueMember = "esc_ide";
            LUEscuela.Properties.DataSource = ado.Mostrar_escuela();
            LUEscuela.Properties.PopulateColumns();
            LUEscuela.Properties.Columns[0].Visible = false;

            luCurso.Properties.DisplayMember = "cur_desc";
            luCurso.Properties.ValueMember = "cur_ide";
            luCurso.Properties.DataSource = ado.Mostrar_curso();
            luCurso.Properties.PopulateColumns();
            luCurso.Properties.Columns[0].Visible = false;

            luDivision.Properties.DisplayMember = "div_desc";
            luDivision.Properties.ValueMember = "div_ide";
            luDivision.Properties.DataSource = ado.Mostrar_division();
            luDivision.Properties.PopulateColumns();
            luDivision.Properties.Columns[0].Visible = false;

            luLocalidad.Properties.DisplayMember = "loc_desc";
            luLocalidad.Properties.ValueMember = "loc_ide";
            luLocalidad.Properties.DataSource = ado.Mostrar_localidad();
            luLocalidad.Properties.PopulateColumns();
            luLocalidad.Properties.Columns[0].Visible = false;

            luTurnos.Properties.DisplayMember = "tur_desc";
            luTurnos.Properties.ValueMember = "tur_ide";
            luTurnos.Properties.DataSource = ado.Mostrar_turnos();
            luTurnos.Properties.PopulateColumns();
            luTurnos.Properties.Columns[0].Visible = false;

            lbfecha.Text = DateTime.Now.ToShortDateString();
            gConsulta.DataSource = ado.Tabladedatos_adopcionDetalle();
            gConsultaD.DataSource = ado.Tabladedatos_adopcionDocentes();
            if (Globales.accesomodificaradopciones == 2)
            {
                HabilitarBotones();
            }
        }

        private void AltaAdopcion_Load(object sender, EventArgs e)
        {


            //InitializeDataGridView();

            this.cargar();

        }

        private void HabilitarBotones()
        {
            LUEscuela.Enabled = true;
            luCurso.Enabled = true;
            luDivision.Enabled = true;
            luCurso.Enabled = true;
            luTurnos.Enabled = true;
            luLocalidad.Enabled = true;
            txtalumnos.Enabled = true;
            btnaltadoc.Enabled = true;
            btneliminaele.Enabled = true;
            btnagregap.Enabled = true;
            button1.Enabled = true;
            btnagregar.Visible = true;
            rTobs.ReadOnly = false;
        }
        private void InitializeDataGridView()
        {
            // Create an unbound DataGridView by declaring a column count.
            

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
           

            //  dgvProductos.Columns[6].Visible = false;
            //  dgvProductos.Columns[7].Visible = false;
            
        }

        private void btnagregap_Click(object sender, EventArgs e)
        {
            ConsultaProductosAdop cpa = new ConsultaProductosAdop();
            cpa.Adopcione = this.Adoide;
            if (cpa.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gConsulta.DataSource = ado.Tabladedatos_adopcionDetalle();
            }
                
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
        
        private void LUComprobante_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void btneliminaele_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar ésta docente?", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                ado.Adodcide = Convert.ToInt32(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["addc_ide"]));
                // edi.Ide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["DOC_IDE"]));
                int valor = ado.spBajaDocente();
                

                this.cargar();
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
           
        }

        private void TSMIvisaelectron_Click(object sender, EventArgs e)
        {
            
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
            
        }

        private void tSMImaster_Click(object sender, EventArgs e)
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

        private void tSMInaranja_Click(object sender, EventArgs e)
        {
            
        }

        private void tSMIplanz_Click(object sender, EventArgs e)
        {
           
        }

        private void tSMItdf_Click(object sender, EventArgs e)
        {
            
        }

        private void btncreditop_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
  
        }

        private void btnproforma_Click(object sender, EventArgs e)
        {

           
           
        }

        private void btnplatacaja_Click(object sender, EventArgs e)
        {
            ConsultaPlataCaja cpc = new ConsultaPlataCaja();
            cpc.ShowDialog();
        }

        private void ahora3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ahora6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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
            
        }

        private void tSMIvisa_Click(object sender, EventArgs e)
        {
            
        }

        private void tSMI2cuotas_Click(object sender, EventArgs e)
        {
            
        }

        private void tSMI3cuotas_Click(object sender, EventArgs e)
        {
           
        }

        private void btnahora12_Click(object sender, EventArgs e)
        {
           
        }

       

        private void guardarlaventamaestro(int tipop2)
        {
        }

        private void guardarlaproformamaestro(int tipop2)
        {
        }

        private void guardarventamaestro(int tipop1)
        {
        }

        private void guardarventadefinitiva()
        {
        }


        private void resetearloscontroles()
        {

        }

        


        

       

        public void aplicadescuento(int descuent,string tipopag, int tipop)
        {
        }

        public void aplicadescuentoCobrar(int descuent, int tipop)
        {
        }


        public void aplicadescuento1(int descuent)
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
            if (e.KeyCode == Keys.Enter)
            {
                //this.aplicades(Convert.ToInt32(txtdescuento.Text));
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
               
          //  Cobrar.totalapag = lbtotalg.Text;
        }

        public void guardarventa()
        {
            this.guardarventadefinitiva();
        }

        


        
        public void selecciondecliente(string cuit, string nombre, string dire, string tipo, string tipoletra)
        {
        }

        public void AgregarProducto(object[] rows, double subtotalg, double valoriv, double importeiv, double niva, int cantidadeleg)
        {
           
        }

        public void AgregarProducto(object[] rows, double subtotalg, double valoriv, double importeiv, double niva, int cantidadeleg, string barra)
        {
            throw new NotImplementedException();
        }

        public void Colocardatos()
        {
            
            LUEscuela.EditValue = this.Escuide;
            
            luCurso.EditValue = this.Cursoide;
            luDivision.EditValue = this.Division;
            luTurnos.EditValue = this.Turnos;
            luLocalidad.EditValue = this.Localidad;
            txtalumnos.Text = Convert.ToString(this.Cantidadalu);
            rTobs.Text = this.Obs;
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

        private void btnaltadoc_Click(object sender, EventArgs e)
        {
            AltaDocente ad = new AltaDocente();
            ad.Adoide = this.Adoide;
            //ad.ShowDialog();
            if (ad.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //gConsulta.DataSource = cli.Mostrar_clientes();
                this.cargar();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar ésta libro?", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                ado.Adodcide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["adod_ide"]));
                // edi.Ide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["DOC_IDE"]));
                int valor = ado.spBajaLibro();


                this.cargar();
            }
        }
        public void Crearadopcion()
        {
            this.Adoide = ado.spAgregarAdopcionM();
            btnagregar.Visible = true;
            btncancelar.Visible = true;
            btnSalir.Visible = false;
        }
        private int controlvacios()
        {
            if (LUEscuela.EditValue != null)
            {
                if (luDivision.EditValue != null)
                {
                    if (luLocalidad.EditValue != null)
                    {
                        if (luCurso.EditValue != null)
                        {
                            if (luTurnos.EditValue != null)
                            {
                                if (txtalumnos.Text != string.Empty)
                                {
                                    return 0;
                                }
                                else
                                {
                                    MessageBox.Show("Debe colocar la cantidad");
                                    txtalumnos.Focus();
                                    return 1;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe elegir el turno");
                                luTurnos.Focus();
                                return 1;
                            }
                        }
                        else {
                            MessageBox.Show("Debe elegir el curso");
                            luCurso.Focus();
                            return 1;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Debe elegir la localidad");
                        luLocalidad.Focus();
                        return 1;
                    }
                }
                else
                {
                    MessageBox.Show("Debe elegir la división");
                    luDivision.Focus();
                    return 1;
                }
            }
            else
            {
                MessageBox.Show("Debe elegir la escuela");
                LUEscuela.Focus();
                return 1;
            }

        }
        private void btnagregar_Click_1(object sender, EventArgs e)
        {
            int contro = this.controlvacios();
            if (contro == 0 )
                { 

                ado.Escuela = Convert.ToInt32(LUEscuela.EditValue);
                ado.Division = Convert.ToInt32(luDivision.EditValue);
                ado.Loc = Convert.ToInt32(luLocalidad.EditValue);
                ado.Curso = Convert.ToInt32(luCurso.EditValue);
                ado.Cantidad = Convert.ToInt32(txtalumnos.Text);
                ado.Turno = Convert.ToInt32(luTurnos.EditValue);
                ado.Obs = rTobs.Text;
                ado.Ide = this.Adoide;
                int valor = ado.spModificaAdopcionM();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                MessageBox.Show("Se ha guardado con éxito!");

                this.Dispose();
                this.Hide();
            }
    }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            ado.Ide = this.Adoide;
            int valor = ado.spBajaAdopcionM();

            //this.cargar();
            this.Dispose();
            this.Hide();
        }
        public string Obs
        {
            get { return this._obs; }
            set { this._obs = value; }
        }
        public int Escuide
        {
            get { return this._esc_ide; }
            set { this._esc_ide = value; }
        }
        public int Adoide
        {
            get { return this._adoide; }
            set { this._adoide = value; }
        }
        public int Alta
        {
            get { return this._alta; }
            set { this._alta = value; }
        }
        public int Cursoide
        {
            get { return this._cursoide; }
            set { this._cursoide = value; }
        }
        public int Division
        {
            get { return this._division; }
            set { this._division = value; }
        }
        public int Turnos
        {
            get { return this._turnos; }
            set { this._turnos = value; }
        }

        public int Localidad
        {
            get { return this._localidad; }
            set { this._localidad = value; }
        }
        public int Cantidadalu
        {
            get { return this._cantidadalu; }
            set { this._cantidadalu = value; }
        }
    }
}
