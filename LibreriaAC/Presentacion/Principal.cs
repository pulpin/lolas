using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicaNegocios;
using System.Threading;

namespace Presentacion
{
    public partial class Principal : Form
    {
        public string usuarioPri;
        public int idusu, localid, cam, contador = 0;
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

        //private static IFUniversal.ModeloPrn MODELO = IFUniversal.ModeloPrn.modEpsonTMT900FA;
        //private static int PUERTO = 0;
        /* Globa variable */
        private bool _WorkThreadRunning = false;
        public void WorkThreadFunction()
        {
            try
            {
                int error;

                /* print x */
                error = ImprimirCierreX();
                MessageBox.Show("Closure Cashier (thread number 1): " + error.ToString());
            }
            catch (Exception ex)
            {
                // log errors
                Console.WriteLine(ex);   
            }

            /* nothing to do */
            System.Threading.Thread.Sleep(1000);

            /* flag */
            _WorkThreadRunning = false;
        }

        public Principal()
        {
            InitializeComponent();
            
        }

            public void seteoUsuario(String usu, int ide, string locali, int localide, string perfil)
        {

            this.usuarioPri = usu;
            this.idusu = ide; // el id del usuario que se logueó...
            this.localid = localide;
            //this.label2.Text = Convert.ToString(ide);
            this.ponerNombreUsu(LogicaNegocios.Globales.gbUsuario);
            this.ponerLocaliUsu(LogicaNegocios.Globales.gbLocalidad);
            this.ponerPerfilUsu(LogicaNegocios.Globales.gbtipousuario);

        }

            public void activarprestadores()
            {
                menuFacturar.Enabled = true;
            }
            public void activarturnos()
            {
                tMConsultaP.Enabled = true;
            }

            public void activarturnoshoy() 
            {
                
            }

            public void activarbuscarafi()
            {
                
            }

            public void activarturnosviejos()
            {
                
            }

            public void activarbusquedaporlocalidad()
            {
                
            }

            private void ponerNombreUsu(string u)
            {
                this.txtusuario.Text = u; // pone el nombre del usuario que se logueó...
            }
            private void ponerLocaliUsu(string l)
            {
                this.lblocalidad.Text = l; // pone la localidad del usuario que se logueó...
            }
            public void cambiarfondo()
            {
             this.BackColor = Globales.colorfondo;
             toolStrip1.BackColor = Globales.colorfondo;
             panel1.BackColor = Globales.colorfondo;
             menuprincipal.BackColor = Globales.colorfondo;
            }
            private void ponerPerfilUsu(string p)
            {
                this.lbtipo.Text = p; // pone el perfil del usuario que se logueó...
            }

            private void tSBsalir_Click(object sender, EventArgs e)
            {

            }

            private void menuViaje_Click(object sender, EventArgs e)
            {
                Facturar fa = new Facturar();
                fa.ShowDialog();
            }

            private void toolTurnos_Click(object sender, EventArgs e)
            {
                ConsultaProductos cp = new ConsultaProductos();
                cp.cambiarfondo();
                cp.ShowDialog();
            }

            private void tBsBuscarusu_Click(object sender, EventArgs e)
            {
            }

        private void button1_Click(object sender, EventArgs e)
        {
  
        }

        private void menuPrecios_Click(object sender, EventArgs e)
        {
            ConsultaPrecios cp = new ConsultaPrecios();
            cp.ShowDialog();
        }

        private void TlSMIConsulinte_Click(object sender, EventArgs e)
        {
            ConsultaInteres ci = new ConsultaInteres();
            ci.ShowDialog();
        }

        private void TSMIconsulI_Click(object sender, EventArgs e)
        {
            ConsultaInteres ci = new ConsultaInteres();
            ci.ShowDialog();
        }

        private void altaTSMIacons_Click(object sender, EventArgs e)
        {
            ConsultasConsignas cc = new ConsultasConsignas();
            cc.ShowDialog();
        }

        private void TSMenuItemConsulren_Click(object sender, EventArgs e)
        {
            ConsultasRendiciones cr = new ConsultasRendiciones();
            cr.ShowDialog();
        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            ConsultaReservas cr = new ConsultaReservas();
            cr.cargar();
            cr.ShowDialog();
        }

        private void tSBVentas_Click(object sender, EventArgs e)
        {
            ConsultaVentas cv = new ConsultaVentas();
            cv.ShowDialog();
        }

        private void TSMIUsuarios_Click(object sender, EventArgs e)
        {
            ConsultaUsuarios cu = new ConsultaUsuarios();
            cu.ShowDialog();
        }

        private void CRPTSMIalta_Click(object sender, EventArgs e)
        {
            Cargarapida cr = new Cargarapida();
            cr.ShowDialog();
        }

        private void TSMIcambiopre_Click(object sender, EventArgs e)
        {
            CambioPrecio cp = new CambioPrecio();
            cp.ShowDialog();
            /*Viejo v = new Viejo();
            v.ShowDialog();*/
        }

        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaProductos cp = new ConsultaProductos();
            cp.cambiarfondo();
            cp.ShowDialog();
        }

        private void editorialToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultasEditoriales ced = new ConsultasEditoriales();
            ced.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Usuarios usu = new Usuarios();
            usu.cerrarconexion();
            usu = null;
            //System.Diagnostics.Process.Start(@"C:\Program Files\MySQL\MySQL Server 5.6\bin\backupLolas.bat");
            Application.Exit();
           

        }

        private void editorialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tSBEditorial_Click(object sender, EventArgs e)
        {
            ConsultaProfor cp = new ConsultaProfor();
            cp.ShowDialog();
        }

        private void TSMIcliente_Click(object sender, EventArgs e)
        {
            ConsultaCliente cc = new ConsultaCliente();
            cc.desaparecerbotonselec();
            cc.ShowDialog();

        }

        private void TSMIccorrientes_Click(object sender, EventArgs e)
        {
            ConsultaCC ccc = new ConsultaCC();
           // ccc.desaparecerbotonselec();
            ccc.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            if (LogicaNegocios.Globales.accesoaproductos == 2 || LogicaNegocios.Globales.accesoaproductos == 1)
            {
                tMConsultaP.Enabled = true;
                productoToolStripMenuItem.Enabled = true;
                cargaTSMItem.Enabled = true;
            }
            if (LogicaNegocios.Globales.registrodeventas == 1)
            {
                tSBVentas.Enabled = true;
                ventaEntreFechasToolStripMenuItem.Enabled = true;
                dVTSMItem.Enabled = true;
            }
            if (LogicaNegocios.Globales.accesoareservas == 2 || LogicaNegocios.Globales.accesoareservas == 1)
            {
                menuReservas.Enabled = true;
            }
            if (LogicaNegocios.Globales.accesoaeditoriales == 2 || LogicaNegocios.Globales.accesoaeditoriales == 1)
            {
                tlSBed.Enabled = true;
                editorialToolStripMenuItem.Enabled = true;
            }
            if (LogicaNegocios.Globales.accesoaclientes == 2 || LogicaNegocios.Globales.accesoaclientes == 1)
            {
                TSMIcliente.Enabled = true;
            }
            if (LogicaNegocios.Globales.accesoacuentacorriente == 2 || LogicaNegocios.Globales.accesoacuentacorriente == 1)
            {
                TSMIccorrientes.Enabled = true;
            }
            if (LogicaNegocios.Globales.accesoaconsignas == 2)
            {
                //consignasToolStripMenuItem.Enabled = true;
            }
            if (LogicaNegocios.Globales.accesoarendiciones == 2)
            {
               // TSMItemRendi.Enabled = true;
            }
            if (LogicaNegocios.Globales.accesoainteres == 2 || LogicaNegocios.Globales.accesoainteres == 1)
            {
                interesesToolStripMenuItem.Enabled = true;
            }
            /*if (LogicaNegocios.Globales.accesoacargarapida == 2)
            {
                //altaToolStripMenuItem.Enabled = true;
            }*/
            if (LogicaNegocios.Globales.accesoapedidos == 2)
            {
                pedidosToolStripMenuItem.Enabled = true;
            }
            if (LogicaNegocios.Globales.accesoausuarios == 2)
            {
                usuariosToolStripMenuItem.Enabled = true;
            }
            if (LogicaNegocios.Globales.accesoaproveedores == 2 || LogicaNegocios.Globales.accesoaproveedores == 1)
            {
                tSBproveedor.Enabled = true;
            }
            if (Globales.imprimirfactura == 2)
            {
                tSBArqueo.Enabled = true;
            }
            if (LogicaNegocios.Globales.accessoporcentajesedi == 2 || LogicaNegocios.Globales.accessoporcentajesedi == 1)
            {
                cPTSMprecio.Enabled = true;
            }


                if (LogicaNegocios.Globales.accesocontador == 2 || LogicaNegocios.Globales.accesocontador == 1)
            {
                TSMIContador.Enabled = true;
            }
            if (LogicaNegocios.Globales.accesopagos == 2)
            {
                //tsPagos.Enabled = true;
            }
            
        }
        void dll_version()
        {
            const int str_len = 500;
            StringBuilder str = new StringBuilder(str_len);
            int mayor = 0;
            int menor = 0;

            /* call exported function from "EpsonFiscalInterface.h" */
            ConsultarVersionDll(str, str_len, ref mayor, ref menor);

            /* show */
            string msg = "-Descripción: " + str.ToString() + "  -Mayor: " + mayor.ToString() + "  -Menor: " + menor.ToString();
            MessageBox.Show(msg);
        }
        private void cierreXToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  this.CierreXIFU();

           
           // dll_version();

            int error;

            
                error = ComenzarLog(true);

               
                ConfigurarVelocidad(9600);

               
                ConfigurarPuerto("0");
              
               
                error = Conectar();
                MessageBox.Show("Se conecta: " + error.ToString());

               
                error = ImprimirCierreX();
                MessageBox.Show("Cierre x #1: " + error.ToString());
            
                _WorkThreadRunning = true;
                System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(WorkThreadFunction));
                thread.Start();

                
                do
                {
                  
                    System.Threading.Thread.Sleep(0);

                } while (_WorkThreadRunning);

            
            error = Desconectar();
            MessageBox.Show("Disconect: " + error.ToString());

            
            DetenerLog();
            
            
        }

        /*
        private void CierreXIFU()
        {
            try
            {

                IFUniversal.IDriver Fiscal = new IFUniversal.Driver();
                Fiscal.Modelo = MODELO;

                if (Fiscal.Error != 0)
                    throw new Exception(Fiscal.ErrorDesc);

                Fiscal.Puerto = PUERTO;
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
        }
        */
        /*
        private void CierreZIFU()
        {
            try
            {

                IFUniversal.IDriver Fiscal = new IFUniversal.Driver();
                Fiscal.Modelo = MODELO;

                if (Fiscal.Error != 0)
                    throw new Exception(Fiscal.ErrorDesc);

                Fiscal.Puerto = PUERTO;
                Fiscal.Baudios = IFUniversal.Baudio.bd9600;

                if (!Fiscal.Inicializar())
                    throw new Exception(Fiscal.ErrorDesc);


                Fiscal.CancelarComprobante();

                if (!Fiscal.CierreZ())
                    throw new Exception(Fiscal.ErrorDesc);

                MessageBox.Show("Cierre realizado exitosamente");
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
        */
        private void cierraZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.CierreZIFU();
            
            int error;
            
            error = ComenzarLog(true);
            
            ConfigurarVelocidad(9600);
            
            ConfigurarPuerto("0");
           
            error = Conectar();
            MessageBox.Show("Se conecta: " + error.ToString());
            
            error = ImprimirCierreZ();
            MessageBox.Show("Closure Day: " + error.ToString());
            
            error = Desconectar();
            MessageBox.Show("Disconect: " + error.ToString());
            
            DetenerLog();
            
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dll_version();
        }

        private void descargarPeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int error;
            /* config baudrate */
            ConfigurarVelocidad(9600);

            /* config port */
            ConfigurarPuerto("0");
            //ConfigurarPuerto("usb:USB");
            //ConfigurarPuerto("lan:172.22.107.226");

            /* real conection */
            error = Conectar();
            MessageBox.Show("Se conecta: " + error.ToString());
            error = DescargarPeriodoPendiente(@"c:\descargas\");
            MessageBox.Show("Descargado: " + error.ToString());
            error = Desconectar();
            MessageBox.Show("Desconectada: " + error.ToString());

        }

        private void ventaEntreFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ventasentrefechas1 vef = new ventasentrefechas1();
            vef.Show();
        }

        private void reservasEntreFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reservasentrefecha re = new reservasentrefecha();
            re.ShowDialog();
        }

        private void hacerPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hacerpedido hp = new hacerpedido();
            hp.ShowDialog();
        }

        private void consultarPedidosRealizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaPedidosR cpr = new ConsultaPedidosR();
            cpr.ShowDialog();
        }

        private void devolverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevolucionConsigna dc = new DevolucionConsigna();
            dc.ShowDialog();
        }

        private void controlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlaConsignas cc = new ControlaConsignas();
            cc.ShowDialog();
        }

        private void movimientosDeUnProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovimientosdeProducto mdp = new MovimientosdeProducto();
            mdp.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaProfor cp = new ConsultaProfor();
            cp.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ConsultaEditoriales ce = new ConsultaEditoriales();
            ce.ShowDialog();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaProductos cp = new ConsultaProductos();
            cp.cambiarfondo();
            cp.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Usuarios usu = new Usuarios();
            usu.cerrarconexion();
            usu = null;
            this.Dispose();
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
        }

        private void históricoDeDevolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultasHistoricoDev chd = new ConsultasHistoricoDev();
            chd.ShowDialog();
        }

        private void ventasEntreFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ventasentrefechapedido vefp = new ventasentrefechapedido();
            vefp.ShowDialog();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            ConsultaProveedor cp = new ConsultaProveedor();
            cp.ShowDialog();
        }

        private void tSBArqueo_Click(object sender, EventArgs e)
        {
            ArqueodeCaja adc = new ArqueodeCaja();
            adc.colocardiaactual();
            adc.ShowDialog();
        }

        private void menuReservas_Click(object sender, EventArgs e)
        {
            ConsultaReservas cr = new ConsultaReservas();
            cr.cargar();
            cr.ShowDialog();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            double preciod;
            string precio;
            preciod = Convert.ToDouble(textBox2.Text);
            precio = string.Format("{0:N4}", preciod);
            precio = precio.Replace(".", String.Empty);
            //precio = precio.Replace(" ", String.Empty);
            precio = precio.Replace(',', '.');
            textBox1.Text = precio;
        }

        private void cierreXNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TsMIPorcentaje_Click(object sender, EventArgs e)
        {
           
        }

        private void TSMIContador_Click(object sender, EventArgs e)
        {
            Contador_nuevo cn = new Contador_nuevo();
            cn.ShowDialog();
        }

        private void TSMIgenero_Click(object sender, EventArgs e)
        {
            ConsultaGenero cg = new ConsultaGenero();
            cg.ShowDialog();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int error;
            const int ERROR_NINGUNO = 0;
            ConfigurarVelocidad(9600);
            ConfigurarPuerto("0");


            error = Conectar();
            //MessageBox.Show("Se conecta: " + error.ToString());
            error = CerrarComprobante();
            if (error != ERROR_NINGUNO)
            {
                MessageBox.Show("Error al cerrar comprobante: " + error.ToString());
            }

            error = Desconectar();
            //MessageBox.Show("Disconect: " + error.ToString());
        }

        private void preciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImprimePrecio ip = new ImprimePrecio();
            ip.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
          
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string importetemI = "43155,9098000001";
            decimal valortemI = Convert.ToDecimal(importetemI);
            valortemI = Math.Floor(valortemI * 10000) / 10000;
            string al = Convert.ToString(valortemI);

            MessageBox.Show(al);
        }

        private void tSBadopcion_Click(object sender, EventArgs e)
        {
            ConsultaAdopciones ca = new ConsultaAdopciones();
            ca.ShowDialog();
        }

        private void clientesReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaClienteReserva ccr = new ConsultaClienteReserva();
            ccr.ShowDialog();
        }

        private void tsPagos_Click(object sender, EventArgs e)
        {
            ConsultaPagos cp = new ConsultaPagos();
            cp.ShowDialog();
        }

        private void TlMcredito_Click(object sender, EventArgs e)
        {
            ConsultaCredito ccre = new ConsultaCredito();
            ccre.ShowDialog();
        }

        private void actualizaCatálogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizaCatalogo ap = new ActualizaCatalogo();
            ap.ShowDialog();
        }

        private void interesesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*ActualizaCatalogo ac = new ActualizaCatalogo();
            ac.ShowDialog();*/
        }

        private void tSBclientes_Click(object sender, EventArgs e)
        {
            ConsultaClienteReserva ccr = new ConsultaClienteReserva();
            ccr.ShowDialog();
        }

        private void porMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarPorcentajePrecio cp = new CambiarPorcentajePrecio();
            cp.ShowDialog();
        }

        private void porNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaProductosPrecio cpp = new ConsultaProductosPrecio();
            cpp.ShowDialog();
        }

        private void cambioDePreciosPorPorcentajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dVTSMItem_Click(object sender, EventArgs e)
        {
            ventasentrefechadetalles vefd = new ventasentrefechadetalles();
            vefd.ShowDialog();
        }

        private void cargaRápidaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cargarapida cr = new Cargarapida();
            cr.ShowDialog();
        }

        private void toolTurnosD_Click(object sender, EventArgs e)
            {
                
            }

            private void tsBbuscartuviejos_Click(object sender, EventArgs e)
            {
  
            }

            private void tSBbuscalocalidad_Click(object sender, EventArgs e)
            {

            }
    }
}
