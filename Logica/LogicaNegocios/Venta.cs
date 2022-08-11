using AccesoaDatos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class Venta
    {
        string _vennombre, _vendireccion, _vencuit, _venimporte, _venimporteiva, _ventotal, _ventipofactura, _vennroticket, _vendescuento, _ventipoiva, _venliide, _vendimporteu, _vendimporte, _vendimporteiva21, _vendiva21, _vendimporteiva1050, _vendivavalor, _vendivaimporte, _vendiva, _obs;
        string _vendimporteivac, _vendimporteiva, _vendivavalorc, _vendimportec, _vendimporteuc;
        string _venimp21 = "0", _veniva21 = "0", _venimp105 = "0", _veniva105 = "0", _venimpexcento = "0", _venproducide, _telefono;
        int _venptodeventa, _venccorriente, _ventipopago, _venide, _vencantidad, _vendtieneiva, _venusuventapedido, _proformaide, _ventaidparanota, _eslibro, _editorial;
        public int spVentaProducto()
        {
            int Valor_Retornado = 0;
            string cadenaconexion;

            this.ventotal = this.ventotal.Replace(",", ".");
            this.venimp21 = this.venimp21.Replace(",", ".");
         
            this.venIVA21 = this.venIVA21.Replace(",", ".");
            this.venimp105 = this.venimp105.Replace(",", ".");
            this.venIVA105 = this.venIVA105.Replace(",", ".");
            this.venimpexcento = this.venimpexcento.Replace(",", ".");

            Conexion con = new Conexion("lolasdb", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            // MySqlCommand myCommand = new  MySqlCommand();
            mysql_conexion.Open();
            MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            myCommand.Transaction = sqlTran;

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "spAltaVenta";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("VEN_NOMBREp", this.Vennombre);
                myCommand.Parameters.AddWithValue("VEN_CUITp", this.Vencuit);
                myCommand.Parameters.AddWithValue("VEN_DIREp", this.Vendireccion);
                myCommand.Parameters.AddWithValue("VEN_TIPI_IDEp", this.Ventipoiva);
                myCommand.Parameters.AddWithValue("VEN_TOTALp", this.ventotal);
                myCommand.Parameters.AddWithValue("VEN_TIP_IDEp", this.ventipopago);
                myCommand.Parameters.AddWithValue("VEN_TIPOFACTUp", this.ventipofactura);
                myCommand.Parameters.AddWithValue("VEN_PTOVTAp", this.venptodeventa);
                myCommand.Parameters.AddWithValue("VEN_VENUSU_IDEp", Globales.usuventaide);
                myCommand.Parameters.AddWithValue("VEN_CC_IDEp", this.venccorriente);
                myCommand.Parameters.AddWithValue("VEN_PEDIDOp", 2);
                myCommand.Parameters.AddWithValue("VEN_IMP21p", this.venimp21);
                myCommand.Parameters.AddWithValue("VEN_IVA21p", this.venIVA21);
                myCommand.Parameters.AddWithValue("VEN_IMP10p", this.venimp105);
                myCommand.Parameters.AddWithValue("VEN_IVA10p", this.venIVA105);
                myCommand.Parameters.AddWithValue("VEN_EXCENTOp", this.venimpexcento);

                MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.Int32);
                ValorRetorno.Direction = ParameterDirection.Output;// Output;
                myCommand.Parameters.Add(ValorRetorno);
                myCommand.ExecuteNonQuery();
                Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);
                sqlTran.Commit();
                mysql_conexion.Close();
            }
            catch (Exception ex)
            {
                // Handle the exception if the transaction fails to commit.
                Console.WriteLine(ex.Message);

                try
                {
                    // Attempt to roll back the transaction.
                    sqlTran.Rollback();
                }
                catch (Exception exRollback)
                {
                    Console.WriteLine(exRollback.Message);
                }
            }

            return Valor_Retornado;
        }

        public int spProformaMaestro()
        {
            int Valor_Retornado = 0;
            string cadenaconexion;

            this.ventotal = this.ventotal.Replace(",", ".");
            this.venimp21 = this.venimp21.Replace(",", ".");
            this.venIVA21 = this.venIVA21.Replace(",", ".");
            this.venimp105 = this.venimp105.Replace(",", ".");
            this.venIVA105 = this.venIVA105.Replace(",", ".");
            this.venimpexcento = this.venimpexcento.Replace(",", ".");

            Conexion con = new Conexion("lolasdb", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            // MySqlCommand myCommand = new  MySqlCommand();
            mysql_conexion.Open();
            MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            myCommand.Transaction = sqlTran;

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "spAltaProforma";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("VEN_NOMBREp", this.Vennombre);
                myCommand.Parameters.AddWithValue("VEN_CUITp", this.Vencuit);
                myCommand.Parameters.AddWithValue("VEN_DIREp", this.Vendireccion);
                myCommand.Parameters.AddWithValue("VEN_TIPI_IDEp", this.Ventipoiva);
                myCommand.Parameters.AddWithValue("VEN_TOTALp", this.ventotal);
                myCommand.Parameters.AddWithValue("VEN_TIP_IDEp", this.ventipopago);
                myCommand.Parameters.AddWithValue("VEN_TIPOFACTUp", this.ventipofactura);
                myCommand.Parameters.AddWithValue("VEN_PTOVTAp", this.venptodeventa);
                myCommand.Parameters.AddWithValue("VEN_VENUSU_IDEp", Globales.usuventaide);
                myCommand.Parameters.AddWithValue("VEN_CC_IDEp", this.venccorriente);
                myCommand.Parameters.AddWithValue("VEN_PEDIDOp", Globales.imprimirfactura);
                myCommand.Parameters.AddWithValue("VEN_IMP21p", this.venimp21);
                myCommand.Parameters.AddWithValue("VEN_IVA21p", this.venIVA21);
                myCommand.Parameters.AddWithValue("VEN_IMP10p", this.venimp105);
                myCommand.Parameters.AddWithValue("VEN_IVA10p", this.venIVA105);
                myCommand.Parameters.AddWithValue("VEN_EXCENTOp", this.venimpexcento);

                MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.Int32);
                ValorRetorno.Direction = ParameterDirection.Output;// Output;
                myCommand.Parameters.Add(ValorRetorno);
                myCommand.ExecuteNonQuery();
                Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);
                sqlTran.Commit();
                mysql_conexion.Close();
            }
            catch (Exception ex)
            {
                // Handle the exception if the transaction fails to commit.
                Console.WriteLine(ex.Message);

                try
                {
                    // Attempt to roll back the transaction.
                    sqlTran.Rollback();
                }
                catch (Exception exRollback)
                {
                    Console.WriteLine(exRollback.Message);
                }
            }

            return Valor_Retornado;
        }


        public int spConsultaCantiReservas()
        {
            string cadenaconexion;
            int Valor_Retornado = 0;

            Conexion con = new Conexion("lolasdb", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            // MySqlCommand myCommand = new  MySqlCommand();
            mysql_conexion.Open();
            MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            myCommand.Transaction = sqlTran;



            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "spConsultacantireservas";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("ncodigo", this.venproductoide);
                

                MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.Int32);
                
                //MySqlParameter ValorRetorno = new MySqlParameter("RETURN_VALUE", SqlDbType.Decimal);
                ValorRetorno.Direction = ParameterDirection.Output;// Output;
                
                myCommand.Parameters.Add(ValorRetorno);
                
                myCommand.ExecuteNonQuery();
                Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);

                sqlTran.Commit();
                mysql_conexion.Close();
            }
            catch (Exception ex)
            {
                // Handle the exception if the transaction fails to commit.
                Console.WriteLine(ex.Message);

                try
                {
                    // Attempt to roll back the transaction.
                    sqlTran.Rollback();
                }
                catch (Exception exRollback)
                {
                    Console.WriteLine(exRollback.Message);
                }
            }

            //this.Titulo = Valor_Retornado;
            //this.Precio = Valor_Retornado2;
            return Valor_Retornado;
        }

        public string spConsultaTipopago(int tipopaide)
        {
            string cadenaconexion;
            string Valor_Retornado=string.Empty;

            Conexion con = new Conexion("lolasdb", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            // MySqlCommand myCommand = new  MySqlCommand();
            mysql_conexion.Open();
            MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            myCommand.Transaction = sqlTran;



            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "spConsultatipopago";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("ntipo", tipopaide);


                MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.VarChar);

                //MySqlParameter ValorRetorno = new MySqlParameter("RETURN_VALUE", SqlDbType.Decimal);
                ValorRetorno.Direction = ParameterDirection.Output;// Output;

                myCommand.Parameters.Add(ValorRetorno);

                myCommand.ExecuteNonQuery();
                Valor_Retornado = Convert.ToString(ValorRetorno.Value);

                sqlTran.Commit();
                mysql_conexion.Close();
            }
            catch (Exception ex)
            {
                // Handle the exception if the transaction fails to commit.
                Console.WriteLine(ex.Message);

                try
                {
                    // Attempt to roll back the transaction.
                    sqlTran.Rollback();
                }
                catch (Exception exRollback)
                {
                    Console.WriteLine(exRollback.Message);
                }
            }

            //this.Titulo = Valor_Retornado;
            //this.Precio = Valor_Retornado2;
            return Valor_Retornado;
        }


        public int spModificaProforma()
        {
            int Valor_Retornado = 0;
            string cadenaconexion;

            
            Conexion con = new Conexion("lolasdb", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            // MySqlCommand myCommand = new  MySqlCommand();
            mysql_conexion.Open();
            MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            myCommand.Transaction = sqlTran;

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "spModiproforma";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pproide", this.proformaide);
                myCommand.Parameters.AddWithValue("pnombre", this.Vennombre);
                myCommand.Parameters.AddWithValue("pdomicilio", this.Vendireccion);
                myCommand.Parameters.AddWithValue("ptelefono", this.telefono);
                myCommand.Parameters.AddWithValue("pcuit", this.Vencuit);
                myCommand.Parameters.AddWithValue("pobs", this.Obs);
                myCommand.Parameters.AddWithValue("ptipofactu", this.ventipofactura);

                MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.Int32);
                ValorRetorno.Direction = ParameterDirection.Output;// Output;
                myCommand.Parameters.Add(ValorRetorno);
                myCommand.ExecuteNonQuery();
                Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);
                sqlTran.Commit();
                mysql_conexion.Close();
            }
            catch (Exception ex)
            {
                // Handle the exception if the transaction fails to commit.
                Console.WriteLine(ex.Message);

                try
                {
                    // Attempt to roll back the transaction.
                    sqlTran.Rollback();
                }
                catch (Exception exRollback)
                {
                    Console.WriteLine(exRollback.Message);
                }
            }

            return Valor_Retornado;
        }

        public int spVentaProductodefinitiva()
        {
            int Valor_Retornado = 0;
            string cadenaconexion;

            this.ventotal = this.ventotal.Replace(",", ".");

            Conexion con = new Conexion("lolasdb", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            // MySqlCommand myCommand = new  MySqlCommand();
            mysql_conexion.Open();
            MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            myCommand.Transaction = sqlTran;

            //this.venimp21 HUGO
            this.venimp21 = this.venimp21.Replace(",", ".");
            this.venIVA21 = this.venIVA21.Replace(",", ".");
            this.venimp105 = this.venimp105.Replace(",", ".");
            this.venIVA105 = this.venIVA105.Replace(",", ".");
            this.venimpexcento = this.venimpexcento.Replace(",", ".");

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "spAltaVentadefinitiva";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("VEN_NOMBREp", this.Vennombre);
                myCommand.Parameters.AddWithValue("VEN_CUITp", this.Vencuit);
                myCommand.Parameters.AddWithValue("VEN_DIREp", this.Vendireccion);
                myCommand.Parameters.AddWithValue("VEN_TIPI_IDEp", this.Ventipoiva);
                myCommand.Parameters.AddWithValue("VEN_TOTALp", this.ventotal);
                myCommand.Parameters.AddWithValue("VEN_TIP_IDEp", this.ventipopago);
                myCommand.Parameters.AddWithValue("VEN_TIPOFACTUp", this.ventipofactura);
                myCommand.Parameters.AddWithValue("VEN_PTOVTAp", Globales.puntodeventa);
                myCommand.Parameters.AddWithValue("VEN_VENUSU_IDEp", this.venusuventapedido);
                myCommand.Parameters.AddWithValue("VEN_CC_IDEp", this.venccorriente);
                myCommand.Parameters.AddWithValue("VEN_PEDIDOp", Globales.imprimirfactura);
                myCommand.Parameters.AddWithValue("VEN_IMP21p", this.venimp21);
                myCommand.Parameters.AddWithValue("VEN_IVA21p",this.venIVA21);
                myCommand.Parameters.AddWithValue("VEN_IMP10p", this.venimp105);
                myCommand.Parameters.AddWithValue("VEN_IVA10p", this.venIVA105);
                myCommand.Parameters.AddWithValue("VEN_EXCENTOp", this.venimpexcento);
                myCommand.Parameters.AddWithValue("VEN_COBUSUp", Globales.gbUsuide);
                
                MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.Int32);
                ValorRetorno.Direction = ParameterDirection.Output;// Output;
                myCommand.Parameters.Add(ValorRetorno);
                myCommand.ExecuteNonQuery();
                Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);
                sqlTran.Commit();
                mysql_conexion.Close();
            }
            catch (Exception ex)
            {
                // Handle the exception if the transaction fails to commit.
                Console.WriteLine(ex.Message);

                try
                {
                    // Attempt to roll back the transaction.
                    sqlTran.Rollback();
                }
                catch (Exception exRollback)
                {
                    Console.WriteLine(exRollback.Message);
                }
            }

            return Valor_Retornado;
        }

        public int spNotadeCredito()
        {
            int Valor_Retornado = 0;
            string cadenaconexion;

            this.ventotal = this.ventotal.Replace(",", ".");

            Conexion con = new Conexion("lolasdb", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            // MySqlCommand myCommand = new  MySqlCommand();
            mysql_conexion.Open();
            MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            myCommand.Transaction = sqlTran;

            //this.venimp21 HUGO
            this.venimp21 = this.venimp21.Replace(",", ".");
            this.venIVA21 = this.venIVA21.Replace(",", ".");
            this.venimp105 = this.venimp105.Replace(",", ".");
            this.venIVA105 = this.venIVA105.Replace(",", ".");
            this.venimpexcento = this.venimpexcento.Replace(",", ".");

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "spAltaNotadeCredito";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("VEN_NOMBREp", this.Vennombre);
                myCommand.Parameters.AddWithValue("VEN_CUITp", this.Vencuit);
                myCommand.Parameters.AddWithValue("VEN_DIREp", this.Vendireccion);
                myCommand.Parameters.AddWithValue("VEN_TIPI_IDEp", this.Ventipoiva);
                myCommand.Parameters.AddWithValue("VEN_TOTALp", this.ventotal);
                myCommand.Parameters.AddWithValue("VEN_TIP_IDEp", this.ventipopago);
                myCommand.Parameters.AddWithValue("VEN_TIPOFACTUp", this.ventipofactura);
                myCommand.Parameters.AddWithValue("VEN_PTOVTAp", Globales.puntodeventa);
                myCommand.Parameters.AddWithValue("VEN_VENUSU_IDEp", this.venusuventapedido);
                myCommand.Parameters.AddWithValue("VEN_CC_IDEp", this.venccorriente);
                myCommand.Parameters.AddWithValue("VEN_IMP21p", this.venimp21);
                myCommand.Parameters.AddWithValue("VEN_IVA21p", this.venIVA21);
                myCommand.Parameters.AddWithValue("VEN_IMP10p", this.venimp105);
                myCommand.Parameters.AddWithValue("VEN_IVA10p", this.venIVA105);
                myCommand.Parameters.AddWithValue("VEN_EXCENTOp", this.venimpexcento);
                myCommand.Parameters.AddWithValue("VEN_COBUSUp", Globales.gbUsuide);
                myCommand.Parameters.AddWithValue("VEN_IDEp", this.VentaidparaNota);
                myCommand.Parameters.AddWithValue("VEN_obsp", this.Obs);

                MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.Int32);
                ValorRetorno.Direction = ParameterDirection.Output;// Output;
                myCommand.Parameters.Add(ValorRetorno);
                myCommand.ExecuteNonQuery();
                Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);
                sqlTran.Commit();
                mysql_conexion.Close();
            }
            catch (Exception ex)
            {
                // Handle the exception if the transaction fails to commit.
                Console.WriteLine(ex.Message);

                try
                {
                    // Attempt to roll back the transaction.
                    sqlTran.Rollback();
                }
                catch (Exception exRollback)
                {
                    Console.WriteLine(exRollback.Message);
                }
            }

            return Valor_Retornado;
        }

        public int spGuardarTicketFiscal(int ultimaventa, int nroticketg)
        {
            int Valor_Retornado = 0;
            string cadenaconexion;
            
            Conexion con = new Conexion("lolasdb", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            // MySqlCommand myCommand = new  MySqlCommand();
            mysql_conexion.Open();
            MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            myCommand.Transaction = sqlTran;
            
            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "spGuardarTicketFiscalv";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("nroticket", nroticketg);
                myCommand.Parameters.AddWithValue("venide", ultimaventa);
                MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.Int32);
                ValorRetorno.Direction = ParameterDirection.Output;// Output;
                myCommand.Parameters.Add(ValorRetorno);
                myCommand.ExecuteNonQuery();
                Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);
                sqlTran.Commit();
                mysql_conexion.Close();
            }
            catch (Exception ex)
            {
                // Handle the exception if the transaction fails to commit.
                Console.WriteLine(ex.Message);

                try
                {
                    // Attempt to roll back the transaction.
                    sqlTran.Rollback();
                }
                catch (Exception exRollback)
                {
                    Console.WriteLine(exRollback.Message);
                }
            }

            return Valor_Retornado;
        }

        public int spVentaProductoDetalle()
        {
            int Valor_Retornado = 0;
            string cadenaconexion;

            this.vendimporteu = this.vendimporteu.Replace(",", ".");
            this.vendimporte = this.vendimporte.Replace(",", ".");
            this.vendimporteC = this.vendimporteC.Replace(",", ".");
            this.vendvaloriva = this.vendvaloriva.Replace(",", ".");
            this.vendimporteiva = this.vendimporteiva.Replace(",", ".");
            this.vendiva = this.vendiva.Replace(",", ".");
            this.vendvalorivaC = this.vendvalorivaC.Replace(",", ".");
            this.vendimporteivaC = this.vendimporteivaC.Replace(",", ".");

            Conexion con = new Conexion("lolasdb", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            // MySqlCommand myCommand = new  MySqlCommand();
            mysql_conexion.Open();
            MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            myCommand.Transaction = sqlTran;

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "spAltaVentadetalle";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("VEND_VEN_IDEp", this.Vendide);
                myCommand.Parameters.AddWithValue("VEND_LI_IDEp", this.Vendliide);
                myCommand.Parameters.AddWithValue("VEND_CANTIDADp", this.Vendcantidad);
                myCommand.Parameters.AddWithValue("VEND_IMPORTEUp", this.vendimporteu);
                myCommand.Parameters.AddWithValue("VEND_IMPORTEp", this.vendimporte);
                myCommand.Parameters.AddWithValue("VEND_IMPORTEUCp", this.vendimporteuC);
                myCommand.Parameters.AddWithValue("VEND_IMPORTECp", this.vendimporteC);
                myCommand.Parameters.AddWithValue("VEND_VALORIVAp", this.vendvaloriva);
                myCommand.Parameters.AddWithValue("VEND_IMPORTEIVAp", this.vendimporteiva);
                myCommand.Parameters.AddWithValue("VEND_IVAp", this.vendiva);
                myCommand.Parameters.AddWithValue("VEND_VALORIVACp", this.vendvalorivaC);
                myCommand.Parameters.AddWithValue("VEND_IMPORTEIVACp", this.vendimporteivaC);
                myCommand.Parameters.AddWithValue("VEN_PEDIDOp", 2);
                myCommand.Parameters.AddWithValue("VEN_TIPOP", this.ventipopago);

                MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.Int32);
                ValorRetorno.Direction = ParameterDirection.Output;// Output;
                myCommand.Parameters.Add(ValorRetorno);
                myCommand.ExecuteNonQuery();
                Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);
                sqlTran.Commit();
                mysql_conexion.Close();
            }
            catch (Exception ex)
            {
                // Handle the exception if the transaction fails to commit.
                Console.WriteLine(ex.Message);

                try
                {
                    // Attempt to roll back the transaction.
                    sqlTran.Rollback();
                }
                catch (Exception exRollback)
                {
                    Console.WriteLine(exRollback.Message);
                }
            }

            return Valor_Retornado;
        }

        public int spProformaDetalle()
        {
            int Valor_Retornado = 0;
            string cadenaconexion;

            this.vendimporteu = this.vendimporteu.Replace(",", ".");
            this.vendimporte = this.vendimporte.Replace(",", ".");
            this.vendimporteC = this.vendimporteC.Replace(",", ".");
            this.vendimporteuC = this.vendimporteuC.Replace(",", ".");
            this.vendvaloriva = this.vendvaloriva.Replace(",", ".");
            this.vendimporteiva = this.vendimporteiva.Replace(",", ".");
            this.vendiva = this.vendiva.Replace(",", ".");
            this.vendvalorivaC = this.vendvalorivaC.Replace(",", ".");
            this.vendimporteivaC = this.vendimporteivaC.Replace(",", ".");

            Conexion con = new Conexion("lolasdb", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            // MySqlCommand myCommand = new  MySqlCommand();
            mysql_conexion.Open();
            MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            myCommand.Transaction = sqlTran;

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "spProformadetalle";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("VEND_VEN_IDEp", this.Vendide);
                myCommand.Parameters.AddWithValue("VEND_LI_IDEp", this.Vendliide);
                myCommand.Parameters.AddWithValue("VEND_CANTIDADp", this.Vendcantidad);
                myCommand.Parameters.AddWithValue("VEND_IMPORTEUp", this.vendimporteu);
                myCommand.Parameters.AddWithValue("VEND_IMPORTEp", this.vendimporte);
                myCommand.Parameters.AddWithValue("VEND_IMPORTEUCp", this.vendimporteuC);
                myCommand.Parameters.AddWithValue("VEND_IMPORTECp", this.vendimporteC);
                myCommand.Parameters.AddWithValue("VEND_VALORIVAp", this.vendvaloriva);
                myCommand.Parameters.AddWithValue("VEND_IMPORTEIVAp", this.vendimporteiva);
                myCommand.Parameters.AddWithValue("VEND_IVAp", this.vendiva);
                myCommand.Parameters.AddWithValue("VEND_VALORIVACp", this.vendvalorivaC);
                myCommand.Parameters.AddWithValue("VEND_IMPORTEIVACp", this.vendimporteivaC);
                myCommand.Parameters.AddWithValue("VEN_PEDIDOp", Globales.imprimirfactura);
                myCommand.Parameters.AddWithValue("VEN_TIPOP", this.ventipopago);

                MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.Int32);
                ValorRetorno.Direction = ParameterDirection.Output;// Output;
                myCommand.Parameters.Add(ValorRetorno);
                myCommand.ExecuteNonQuery();
                Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);
                sqlTran.Commit();
                mysql_conexion.Close();
            }
            catch (Exception ex)
            {
                // Handle the exception if the transaction fails to commit.
                Console.WriteLine(ex.Message);

                try
                {
                    // Attempt to roll back the transaction.
                    sqlTran.Rollback();
                }
                catch (Exception exRollback)
                {
                    Console.WriteLine(exRollback.Message);
                }
            }

            return Valor_Retornado;
        }

        public int spVentaProductoDetalledefinitiva()
        {
            int Valor_Retornado = 0;
            string cadenaconexion;

            this.vendimporteu = this.vendimporteu.Replace(",", ".");
            this.vendimporte = this.vendimporte.Replace(",", ".");
            this.vendimporteC = this.vendimporteC.Replace(",", ".");
            this.vendvaloriva = this.vendvaloriva.Replace(",", ".");
            this.vendimporteiva = this.vendimporteiva.Replace(",", ".");
            this.vendiva = this.vendiva.Replace(",", ".");
            this.vendvalorivaC = this.vendvalorivaC.Replace(",", ".");
            this.vendimporteivaC = this.vendimporteivaC.Replace(",", ".");
            this.vendimporteuC = this.vendimporteuC.Replace(",", ".");

            Conexion con = new Conexion("lolasdb", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            // MySqlCommand myCommand = new  MySqlCommand();
            mysql_conexion.Open();
            MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            myCommand.Transaction = sqlTran;

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "spAltaVentadetalledefinitiva";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("VEND_VEN_IDEp", this.Vendide);
                myCommand.Parameters.AddWithValue("VEND_LI_IDEp", this.Vendliide);
                myCommand.Parameters.AddWithValue("VEND_CANTIDADp", this.Vendcantidad);
                myCommand.Parameters.AddWithValue("VEND_IMPORTEUp", this.vendimporteu);
                myCommand.Parameters.AddWithValue("VEND_IMPORTEp", this.vendimporte);
                myCommand.Parameters.AddWithValue("VEND_IMPORTEUCp", this.vendimporteuC);
                myCommand.Parameters.AddWithValue("VEND_IMPORTECp", this.vendimporteC);
                myCommand.Parameters.AddWithValue("VEND_VALORIVAp", this.vendvaloriva);
                myCommand.Parameters.AddWithValue("VEND_IMPORTEIVAp", this.vendimporteiva);
                myCommand.Parameters.AddWithValue("VEND_IVAp", this.vendiva);
                myCommand.Parameters.AddWithValue("VEND_VALORIVACp", this.vendvalorivaC);
                myCommand.Parameters.AddWithValue("VEND_IMPORTEIVACp", this.vendimporteivaC);
                myCommand.Parameters.AddWithValue("VEN_PEDIDOp", Globales.imprimirfactura);

                MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.Int32);
                ValorRetorno.Direction = ParameterDirection.Output;// Output;
                myCommand.Parameters.Add(ValorRetorno);
                myCommand.ExecuteNonQuery();
                Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);
                sqlTran.Commit();
                mysql_conexion.Close();
            }
            catch (Exception ex)
            {
                // Handle the exception if the transaction fails to commit.
                Console.WriteLine(ex.Message);

                try
                {
                    // Attempt to roll back the transaction.
                    sqlTran.Rollback();
                }
                catch (Exception exRollback)
                {
                    Console.WriteLine(exRollback.Message);
                }
            }

            return Valor_Retornado;
        }

        public int spNotadeCreditoDetalle()
        {
            int Valor_Retornado = 0;
            string cadenaconexion;

            this.vendimporteu = this.vendimporteu.Replace(",", ".");
            this.vendimporte = this.vendimporte.Replace(",", ".");
            this.vendimporteC = this.vendimporteC.Replace(",", ".");
            this.vendvaloriva = this.vendvaloriva.Replace(",", ".");
            this.vendimporteiva = this.vendimporteiva.Replace(",", ".");
            this.vendiva = this.vendiva.Replace(",", ".");
            this.vendvalorivaC = this.vendvalorivaC.Replace(",", ".");
            this.vendimporteivaC = this.vendimporteivaC.Replace(",", ".");
            this.vendimporteuC = this.vendimporteuC.Replace(",", ".");

            Conexion con = new Conexion("lolasdb", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            // MySqlCommand myCommand = new  MySqlCommand();
            mysql_conexion.Open();
            MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            myCommand.Transaction = sqlTran;

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "spAltaNotadeCreditoDetalle";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("VEND_VEN_IDEp", this.Vendide);
                myCommand.Parameters.AddWithValue("VEND_LI_IDEp", this.Vendliide);
                myCommand.Parameters.AddWithValue("VEND_CANTIDADp", this.Vendcantidad);
                myCommand.Parameters.AddWithValue("VEND_IMPORTEUp", this.vendimporteu);
                myCommand.Parameters.AddWithValue("VEND_IMPORTEp", this.vendimporte);
                myCommand.Parameters.AddWithValue("VEND_IMPORTEUCp", this.vendimporteuC);
                myCommand.Parameters.AddWithValue("VEND_IMPORTECp", this.vendimporteC);
                myCommand.Parameters.AddWithValue("VEND_VALORIVAp", this.vendvaloriva);
                myCommand.Parameters.AddWithValue("VEND_IMPORTEIVAp", this.vendimporteiva);
                myCommand.Parameters.AddWithValue("VEND_IVAp", this.vendiva);
                myCommand.Parameters.AddWithValue("VEND_VALORIVACp", this.vendvalorivaC);
                myCommand.Parameters.AddWithValue("VEND_IMPORTEIVACp", this.vendimporteivaC);
                myCommand.Parameters.AddWithValue("VEN_PEDIDOp", Globales.imprimirfactura);

                MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.Int32);
                ValorRetorno.Direction = ParameterDirection.Output;// Output;
                myCommand.Parameters.Add(ValorRetorno);
                myCommand.ExecuteNonQuery();
                Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);
                sqlTran.Commit();
                mysql_conexion.Close();
            }
            catch (Exception ex)
            {
                // Handle the exception if the transaction fails to commit.
                Console.WriteLine(ex.Message);

                try
                {
                    // Attempt to roll back the transaction.
                    sqlTran.Rollback();
                }
                catch (Exception exRollback)
                {
                    Console.WriteLine(exRollback.Message);
                }
            }

            return Valor_Retornado;
        }


        public int spMarcarImprimioNotadeCredito()
        {
            int Valor_Retornado = 0;
            string cadenaconexion;


            Conexion con = new Conexion("lolasdb", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            // MySqlCommand myCommand = new  MySqlCommand();
            mysql_conexion.Open();
            MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            myCommand.Transaction = sqlTran;

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "spMarcarqueimprimefiscal";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("VEND_VEN_IDEp", this.Vendide);

                MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.Int32);
                ValorRetorno.Direction = ParameterDirection.Output;// Output;
                myCommand.Parameters.Add(ValorRetorno);
                myCommand.ExecuteNonQuery();
                Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);
                sqlTran.Commit();
                mysql_conexion.Close();
            }
            catch (Exception ex)
            {
                // Handle the exception if the transaction fails to commit.
                Console.WriteLine(ex.Message);

                try
                {
                    // Attempt to roll back the transaction.
                    sqlTran.Rollback();
                }
                catch (Exception exRollback)
                {
                    Console.WriteLine(exRollback.Message);
                }
            }

            return Valor_Retornado;
        }


        public int spDescuentodelStockproducto()
        {
            int Valor_Retornado = 0;
            string cadenaconexion;


            Conexion con = new Conexion("lolasdb", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            // MySqlCommand myCommand = new  MySqlCommand();
            mysql_conexion.Open();
            MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            myCommand.Transaction = sqlTran;

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "spDescontarStockProducto";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("LI_IDEp", this.Vendliide);
                myCommand.Parameters.AddWithValue("cantidadp", this.Vendcantidad);

                MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.Int32);
                ValorRetorno.Direction = ParameterDirection.Output;// Output;
                myCommand.Parameters.Add(ValorRetorno);
                myCommand.ExecuteNonQuery();
                Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);
                sqlTran.Commit();
                mysql_conexion.Close();
            }
            catch (Exception ex)
            {
                // Handle the exception if the transaction fails to commit.
                Console.WriteLine(ex.Message);

                try
                {
                    // Attempt to roll back the transaction.
                    sqlTran.Rollback();
                }
                catch (Exception exRollback)
                {
                    Console.WriteLine(exRollback.Message);
                }
            }

            return Valor_Retornado;
        }


        public int spEliminarventatemporal()
        {
            int Valor_Retornado = 0;
            string cadenaconexion;


            Conexion con = new Conexion("lolasdb", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            // MySqlCommand myCommand = new  MySqlCommand();
            mysql_conexion.Open();
            MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            myCommand.Transaction = sqlTran;

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "spEliminaventatemporal";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("VEN_IDEp", this.Vendide);

                MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.Int32);
                ValorRetorno.Direction = ParameterDirection.Output;// Output;
                myCommand.Parameters.Add(ValorRetorno);
                myCommand.ExecuteNonQuery();
                Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);
                sqlTran.Commit();
                mysql_conexion.Close();
            }
            catch (Exception ex)
            {
                // Handle the exception if the transaction fails to commit.
                Console.WriteLine(ex.Message);

                try
                {
                    // Attempt to roll back the transaction.
                    sqlTran.Rollback();
                }
                catch (Exception exRollback)
                {
                    Console.WriteLine(exRollback.Message);
                }
            }

            return Valor_Retornado;
        }


        public DataTable Mostrar_ventasentrefechas(int codedi, string fechadesde, string fechahasta)
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            /* return con.Mostrar_Datos("SELECT PREN_LI_CODIGOVIEJO,LI_DESC,LI_AUTOR,PREN_CANTIDAD,PREN_FECHAVTA,PREN_FACTU, " +
                                     " PREN_CONSIGNA, PREN_IMPORTE " +
                                     " FROM pararendicion left join libros on PREN_LI_CODIGOVIEJO = LI_CODIGOVIEJO " +
                                     " left join consignasmaestro on PREN_CONSIGNA = CONMA_IDE " +
                                     " where PREN_NRORENDICION = 0 AND PREN_EDICODIGO = " + codedi + " and PREN_FECHAVTA >= '"+ fechadesde + "' and PREN_FECHAVTA <= '" + fechahasta + "' ");
                                     */
            return con.Mostrar_Datos("SELECT PREN_LI_CODIGOVIEJO,LI_DESC,LI_AUTOR,PREN_CANTIDAD,PREN_FECHAVTA,PREN_FACTU, " +
                                    " PREN_CONSIGNA, PREN_IMPORTE,PREN_IDE FROM pararendicion " +
                                    " left join consignasmaestro on PREN_CONSIGNA = CONMA_IDE " +
                                    " left join libros on PREN_LI_CODIGOVIEJO = LI_CODIGOVIEJO " +
                                    " where PREN_CONSIGNA > 0 AND PREN_EDICODIGO = "+ codedi + " AND " +
                                    " PREN_FECHAVTA >= '" + fechadesde + "' and PREN_FECHAVTA <= '" + fechahasta + "' " +
                                    " AND PREN_NRORENDICION = 0 and PREN_ANULADO = 0 order by PREN_FACTU");
        }


        public DataTable Mostrar_paraproforma()
        {
            string usuarioss = String.Empty;
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("SELECT VEND_LI_IDE,LI_DESC,LI_AUTOR,EDI_EDITORIAL,VEND_CANTIDAD, " +
                                     " VEND_IMPORTEU, VEND_IMPORTE, VEN_TOTAL " +
                                     " from proforma as pro left join proformadetalle as pd " +
                                     " on pro.VEN_IDE = pd.VEND_VEN_IDE " +
                                     " left join libros as li on VEND_LI_IDE = li.LI_CODIGOVIEJO " +
                                     " left join editorial as ed on LI_EDI_CODIGO = EDI_CODIGO " +
                                     " where VEN_IDE = "+ this.proformaide +"");

        }

        public DataTable Mostrar_ventas()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            
            return con.Mostrar_Datos("select VEN_IDE,VEN_TIPOFACTU, " +
                " VEN_NROTICKET,VEN_FECHA,VEN_NOMBRE,VEN_TOTAL " +
                " from venta ORDER BY VEN_IDE DESC");
        }

        public DataTable Mostrar_pedidotemporal()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();


            return con.Mostrar_Datos("select VEN_IDE,VEN_TIPOFACTU,VEN_FECHA,VEN_NOMBRE,VEN_TOTAL,USU_NCOMPLETO " +
                                     " from lolasdb.tempventa left join usuarios.usuarios on VEN_VENUSU_IDE = USU_IDE ORDER BY VEN_IDE DESC");
        }

        public DataTable Mostrar_ventas100()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();


            return con.Mostrar_Datos("select VEN_IDE,VEN_TIPOFACTU, " +
                " VEN_NROTICKET,VEN_FECHA,(case when VEN_TIP_IDE = 12 then CC_NOMBRE else VEN_NOMBRE END) as VEN_NOMBRE,VEN_TOTAL,VEN_ANULADO,TIP_DESC,VEN_PTOVTA " +
                " from venta left join tipopago on VEN_TIP_IDE = TIP_IDE left join cuentacorriente as cc on VEN_IDE = CUCO_VEN_IDE " +
                " left join cccliente as ccc on CUCO_CC_IDE = CC_IDE where VEN_PTOVTA = "+ Globales.gbpuntodeventapredetermindado +"  ORDER BY VEN_IDE DESC limit 100");
        }

        public DataTable Mostrar_ventasporparametro(string desde, string hasta, int nrofactu,int puntodvta, int ticket)
        {
            int ingresa = 0;
            string valor = string.Empty;
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            if ((desde != string.Empty && hasta != string.Empty) && (desde != "0001-01-01" && hasta != "0001-01-01"))
            {
                ingresa = 1;
                valor = " VEN_FECHA >= '" + desde + "' and VEN_FECHA <= '" + hasta + "'";
                if (nrofactu != 0)
                {
                    valor = valor + " and VEN_IDE = "+ nrofactu +"";
                }
            }
            else
            {
                
                if (nrofactu > 0)
                {
                    if (ingresa == 0)
                    {
                        valor = " VEN_IDE = " + nrofactu + " ";
                    }
                    else
                    {
                        
                        valor = valor + " and VEN_IDE = " + nrofactu + " ";
                    }
                    ingresa = 1;

                }
                if (ticket > 0)
                {
                    if (ingresa == 0)
                    {
                        valor = " VEN_NROTICKET = " + ticket + " ";
                    }
                    else
                    {
                        valor = valor + " AND VEN_NROTICKET = " + ticket + " ";
                    }
                    ingresa = 1;
                    
                }

            }
            if (puntodvta > 0)
            {
                if (ingresa == 1)
                {
                    valor = valor + " and VEN_PTOVTA = " + puntodvta + " ";
                }
                else
                {
                    valor = " VEN_PTOVTA = " + puntodvta + " ";
                }
                
            }
            return con.Mostrar_Datos("select VEN_IDE,VEN_TIPOFACTU, " +
                " VEN_NROTICKET,VEN_FECHA,(case when VEN_TIP_IDE = 12 then CC_NOMBRE else VEN_NOMBRE END) as VEN_NOMBRE,VEN_TOTAL,VEN_ANULADO,TIP_DESC,VEN_PTOVTA " +
                " from venta left join tipopago on VEN_TIP_IDE = TIP_IDE left join cuentacorriente as cc on VEN_IDE = CUCO_VEN_IDE " +
                " left join cccliente as ccc on CUCO_CC_IDE = CC_IDE where " + valor +" ORDER BY VEN_IDE DESC");
        }

        public DataTable Mostrar_ventasporparametrofiltro(string desde, string hasta, int puntodvta, int tipop)
        {
           // int ingresa = 0;
            string valor = string.Empty;
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
           
            return con.Mostrar_Datos("select VEN_IDE,VEN_TIPOFACTU, " +
                " VEN_NROTICKET,VEN_FECHA,(case when VEN_TIP_IDE = 12 then CC_NOMBRE else VEN_NOMBRE END) as VEN_NOMBRE,VEN_TOTAL,VEN_ANULADO,TIP_DESC,VEN_PTOVTA " +
                " from venta left join tipopago on VEN_TIP_IDE = TIP_IDE left join cuentacorriente as cc on VEN_IDE = CUCO_VEN_IDE " +
                " left join cccliente as ccc on CUCO_CC_IDE = CC_IDE where (VEN_FECHA >= '" + desde + "' and VEN_FECHA <= '" + hasta + "') and VEN_PTOVTA = " + puntodvta + " and VEN_TIP_IDE = "+ tipop + " ORDER BY VEN_IDE DESC");
        }

        public DataTable Mostrar_ventasparacontador(string desde, string hasta, int puntodvta)
        {
           // int ingresa = 0;
            string valor = string.Empty;
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select VEN_PTOVTA, VEN_TIPOFACTU, VEN_NROTICKET, VEN_NOMBRE, " +
                                    " VEN_CUIT, VEN_DIRE, VEN_FECHA, VEN_IMP21, " +
                                    " VEN_IVA21, VEN_IMP1050, VEN_IMPIVA1050, VEN_EXENTO, " +
                                    " VEN_TOTAL,'' as Obs,ven_ide  " +
                                    " from venta " +
                                    " where (VEN_FECHA >= '" + desde + "' and VEN_FECHA <= '" + hasta + "') and VEN_PTOVTA = " + puntodvta + " and VEN_NROTICKET > 0 " +
                                    " union select VEN_PTOVTA, VEN_TIPOFACTU, VEN_NROTICKET, VEN_NOMBRE, " +
                                    " VEN_CUIT, VEN_DIRE, VEN_FECHA, (VEN_IMP21 * -1) as VEN_IMP21, " +
                                    " (VEN_IVA21 * -1) as VEN_IVA21, (VEN_IMP1050 *-1) as VEN_IMP1050, (VEN_IMPIVA1050*-1) as VEN_IMPIVA1050, (VEN_EXENTO *-1) as VEN_EXENTO, " +
                                    " (VEN_TOTAL*-1) as VEN_TOTAL, 'Nota de credito' as Obs, ven_ide from notadecredito " +
                                    " where (VEN_FECHA >= '" + desde + "' and VEN_FECHA <= '" + hasta + "') and VEN_PTOVTA = " + puntodvta + " ORDER BY ven_ide DESC ");
        }

       

        public DataTable Mostrar_proformas()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();


            return con.Mostrar_Datos("select VEN_IDE,VEN_FECHA,VEN_NOMBRE,VEN_DIRE,VEN_CUIT,VEN_TELEFONO from proforma  ORDER BY VEN_IDE DESC");
        }


        public DataTable Mostrar_ventasdProductos()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();


            return con.Mostrar_Datos("select VEND_LI_IDE,LI_DESC,VEND_CANTIDAD,VEND_IMPORTEIVA, " +
                                " VEND_VALORIVA, VEND_IMPORTE " +
                                " from ventadetalle " +
                                " left join libros on LI_CODIGOVIEJO = VEND_LI_IDE " +
                                " where VEND_VEN_IDE = "+ this.Vendide +"");
        }


        public DataTable Mostrar_registrodelasventas()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select REGV_FECHAVTA,REGV_CANTIDAD,REGV_NROVTA,(case when REGV_TIPO = 0 then 'Propio' else 'Consigna' end) as tipo from registrodeventas where REGV_LI_CODIGOVIEJO = '"+ this.venproductoide +"'");

        }

        public DataTable Mostrar_movimientosdeproductos()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select MOV_FECHA,MOV_CANTIDAD,MOV_REMITO,PROV_DESC,(CASE WHEN MOV_USUA_IDE is null then MOV_USUARIOVIEJO else USU_NOMBRE end) as usuario from movimientos " +
                                     " left join proveedor on MOV_CARPRO_IDE = PROV_IDE " +
                                     " left join usuarios.usuarios on MOV_USUA_IDE = USU_IDE " +
                                     " where mov_li_codigoviejo = '" + this.venproductoide + "'");

        }

        public DataTable Mostrar_reservasdeproducto()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select CLIEN_NOMBRE,RESE_CANTIDAD,RESE_FECHA from reservas as re left join clientesli as cl on re.RESE_CLIE_IDE = cl.CLIEN_IDE " +
                                    " where RESE_ESTADO = 0 and RESE_LI_CODIGOVIEJO = '" + this.venproductoide + "'");

        }
        public DataTable Mostrar_pedidosrealizados()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select pro.PROV_DESC,pm.PED_FECHA,pd.PEDD_CANTIDAD from pedidosdetalle as pd left join pedidosmaestro as pm " +
                                     " on pd.PEDD_PED_IDE = pm.PED_IDE " +
                                     " left join proveedor as pro on pm.PED_PROV_IDE = pro.PROV_IDE " +
                                     " left join libros as li on pd.PEDD_LI_IDE = li.LI_IDE " +
                                     " where li.LI_CODIGOVIEJO = '" + this.venproductoide + "'");

        }

        public DataTable Mostrar_ventasporproducto()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select ven.VEN_IDE,vend.VEND_LI_IDE,ven.VEN_FECHA,vend.VEND_CANTIDAD,vend.VEND_IMPORTE from venta as ven left join ventadetalle as vend " +
                                     " on ven.VEN_IDE = vend.VEND_VEN_IDE " +
                                     " where vend.VEND_LI_IDE = '" + this.venproductoide + "'");

        }

        public DataTable Mostrar_ventasporfecha(string fechadesde, string fechahasta,int puntodevta,int usuario,int todos)
        {
            string usuarioss = String.Empty;
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            if (todos == 1)
            {
                usuarioss = "ve.VEN_COBUSU_IDE > 0 and ";
            }
            else
            {
                usuarioss = "ve.VEN_COBUSU_IDE = "+ usuario +" and ";
            }

            return con.Mostrar_Datos("select tp.TIP_DESC as descrip,(case when VEN_TIP_IDE = 12 then 0 else SUM(ve.VEN_TOTAL) end) as total,ve.VEN_IDE, tp.TIP_IDE from venta as ve left join tipopago as tp " +
                                    " on ve.VEN_TIP_IDE = tp.TIP_IDE " +
                                    " where "+ usuarioss +" ve.VEN_PTOVTA = " + puntodevta +" and ve.VEN_FECHA >= '" + fechadesde + "' AND ve.VEN_FECHA <= '" + fechahasta + "' " +
                                    " and ve.VEN_CC_IDE is null and ve.VEN_ANULADO=0 " +
                                    " group by VEN_TIP_IDE " + 
                                    " union " +
                                    " select taj.TIA_DESC as descrip, va.VENA_IMPORTE as total,va.VENA_IDE,0 as TIP_IDE from ventaajuste as va " +
                                    " left join tipoajuste taj on va.VENA_TIA_IDE = taj.TIA_IDE " +
                                    " where va.VENA_FECHA >= '" + fechadesde + "' AND va.VENA_FECHA <= '" + fechahasta + "' " +
                                    " and va.VENA_PTOVTA = " + puntodevta + " ");


           /* return con.Mostrar_Datos("select taj.TIA_DESC as descrip,va.VENA_IMPORTE as total,va.VENA_IDE from ventaajuste as va " +
            " left join tipoajuste taj on va.VENA_TIA_IDE = taj.TIA_IDE " +
            " where va.VENA_FECHA >= '" + fecha + "' AND va.VENA_FECHA <= '" + fecha + "' " +
            " and va.VENA_PTOVTA = " + ptovta + " " +
            " ");*/
        }
        public DataTable Mostrar_ventasporfecha1(string fechadesde, string fechahasta, int puntodevta, int usuario, int todos)
        {
            string usuarioss = String.Empty;
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            if (todos == 1)
            {
                usuarioss = "ve.VEN_COBUSU_IDE > 0 and ";
            }
            else
            {
                usuarioss = "ve.VEN_COBUSU_IDE = " + usuario + " and ";
            }

            return con.Mostrar_Datos("select tp.TIP_DESC as descrip,SUM(ve.VEN_TOTAL) as total,ve.VEN_IDE,tp.TIP_IDE from venta as ve left join tipopago as tp " +
                                    " on ve.VEN_TIP_IDE = tp.TIP_IDE " +
                                    " where " + usuarioss + " ve.VEN_PTOVTA = " + puntodevta + " and ve.VEN_FECHA >= '" + fechadesde + "' AND ve.VEN_FECHA <= '" + fechahasta + "' " +
                                    " and ve.VEN_CC_IDE is null " +
                                    " group by VEN_TIP_IDE " +
                                    " union " +
                                    " select taj.TIA_DESC as descrip, va.VENA_IMPORTE as total,va.VENA_IDE,0 AS TIP_IDE from ventaajuste as va " +
                                    " left join tipoajuste taj on va.VENA_TIA_IDE = taj.TIA_IDE " +
                                    " where va.VENA_FECHA >= '" + fechadesde + "' AND va.VENA_FECHA <= '" + fechahasta + "' " +
                                    " and va.VENA_PTOVTA = " + puntodevta + "");

        }

        public DataTable Mostrar_VentasporfechaPedido(string fechadesde, string fechahasta)
        {
            string eslibro = string.Empty;
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            if (this.EsLibro == 1)
            {
                eslibro = " li.LI_TIPOPRO = 0 ";
            }
            else
            {
                eslibro = " li.LI_TIPOPRO > 0 ";
            }

            return con.Mostrar_Datos("select li.LI_IDE, li.LI_CODIGOVIEJO as codigo,li.LI_DESC,li.LI_AUTOR,edi.EDI_EDITORIAL,SUM(vend.VEND_CANTIDAD) as cantidad,0 as valor,vend.VEND_IMPORTEU " +
                                     " from venta as ven left join ventadetalle as vend on ven.VEN_IDE = vend.VEND_VEN_IDE " +
                                     " left join libros as li on vend.VEND_LI_IDE = li.LI_CODIGOVIEJO " +
                                     " left join editorial as edi on li.LI_EDI_CODIGO = edi.EDI_CODIGO " +
                                     " where (VEN_FECHA >= '" + fechadesde + "' and  VEN_FECHA <= '" + fechahasta + "' ) and "+ eslibro +" " +
                                     " group by LI_IDE ");

        }

        public DataTable Mostrar_VentasporfechaPedidoPorMarca(string fechadesde, string fechahasta)
        {
            string eslibro = string.Empty,edito = string.Empty;

            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            if (this.EsLibro == 1)
            {
                eslibro = " li.LI_TIPOPRO = 0 ";
            }
            else
            {
                eslibro = " li.LI_TIPOPRO > 0 ";
            }
            if (this.Editorial > 0)
            {
                edito = " LI_EDI_CODIGO = "+ this.Editorial +" and ";
            }

            return con.Mostrar_Datos("select li.LI_IDE, li.LI_CODIGOVIEJO as codigo,li.LI_DESC,li.LI_AUTOR,edi.EDI_EDITORIAL,vend.VEND_CANTIDAD,0 as valor,vend.VEND_IMPORTEU,vend.VEND_IMPORTE,tp.TIP_DESC " +
                                     " from venta as ven left join ventadetalle as vend on ven.VEN_IDE = vend.VEND_VEN_IDE " +
                                     " left join libros as li on vend.VEND_LI_IDE = li.LI_CODIGOVIEJO " +
                                     " left join editorial as edi on li.LI_EDI_CODIGO = edi.EDI_CODIGO " +
                                     " left join tipopago as tp on ven.VEN_TIP_IDE = tp.TIP_IDE " +
                                     " where " + edito +" (VEN_FECHA >= '" + fechadesde + "' and  VEN_FECHA <= '" + fechahasta + "' ) and " + eslibro + " " +
                                     "  ");

        }

        public DataTable Tabladedatos_Ajustes(int ptovta,string fecha)
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            return con.Mostrar_Datos("select taj.TIA_DESC as descrip,va.VENA_IMPORTE as total,va.VENA_IDE,va.VENA_OBS from ventaajuste as va " +
                        " left join tipoajuste taj on va.VENA_TIA_IDE = taj.TIA_IDE " +
                        " where va.VENA_FECHA >= '" + fecha + "' AND va.VENA_FECHA <= '" + fecha + "' " +
                        " and va.VENA_PTOVTA = " + ptovta + " " + 
                        " ");
        }

        public int Vendide
        {
            get { return this._venide; }
            set { this._venide = value; }
        }

        public string Vendliide
        {
            get { return this._venliide; }
            set { this._venliide = value; }
        }

        public int Vendcantidad
        {
            get { return this._vencantidad; }
            set { this._vencantidad = value; }
        }

        public string vendimporteu
        {
            get { return this._vendimporteu; }
            set { this._vendimporteu = value; }
        }

        public string vendimporteuC
        {
            get { return this._vendimporteuc; }
            set { this._vendimporteuc = value; }
        }

        public string vendimporte
        {
            get { return this._vendimporte; }
            set { this._vendimporte = value; }
        }

        public string telefono
        {
            get { return this._telefono; }
            set { this._telefono = value; }
        }

        public string vendimporteC
        {
            get { return this._vendimportec; }
            set { this._vendimportec = value; }
        }

        public string vendvaloriva
        {
            get { return this._vendivavalor; }
            set { this._vendivavalor = value; }
        }

        public string vendvalorivaC
        {
            get { return this._vendivavalorc; }
            set { this._vendivavalorc = value; }
        }

        public string vendimporteiva
        {
            get { return this._vendimporteiva; }
            set { this._vendimporteiva = value; }
        }

        public string vendimporteivaC
        {
            get { return this._vendimporteivac; }
            set { this._vendimporteivac = value; }
        }



        public string vendivaimporte
        {
            get { return this._vendivaimporte; }
            set { this._vendivaimporte = value; }
        }

        public string vendiva
        {
            get { return this._vendiva; }
            set { this._vendiva = value; }
        }
        public string vendimporteiva21
        {
            get { return this._vendimporteiva21; }
            set { this._vendimporteiva21 = value; }
        }

        public int vendtieneiva
        {
            get { return this._vendtieneiva; }
            set { this._vendtieneiva = value; }
        }

        public string vendiva21
        {
            get { return this._vendiva21; }
            set { this._vendiva21 = value; }
        }

        public string vendimporteiva1050
        {
            get { return this._vendimporteiva1050; }
            set { this._vendimporteiva1050 = value; }
        }

        public string vendiva1050
        {
            get { return this.vendiva1050; }
            set { this.vendiva1050 = value; }
        }

        public string Vennombre
        {
            get { return this._vennombre; }
            set { this._vennombre = value; }
        }
        public string Vencuit
        {
            get { return this._vencuit; }
            set { this._vencuit = value; }
        }
        public string Obs
        {
            get { return this._obs; }
            set { this._obs = value; }
        }
        public int EsLibro
        {
            get { return this._eslibro; }
            set { this._eslibro = value; }
        }

        public int Editorial
        {
            get { return this._editorial; }
            set { this._editorial = value; }
        }
        public string Vendireccion
        {
            get { return this._vendireccion; }
            set { this._vendireccion = value; }
        }
        public string Ventipoiva
        {
            get { return this._ventipoiva; }
            set { this._ventipoiva = value; }
        }
        public string venimporte
        {
            get { return this._venimporte; }
            set { this._venimporte = value; }
        }
     
        public string venimporteiva
        {
            get { return this._venimporteiva; }
            set { this._venimporteiva = value; }
        }
        public string ventotal
        {
            get { return this._ventotal; }
            set { this._ventotal = value; }
        }
        public int ventipopago
        {
            get { return this._ventipopago; }
            set { this._ventipopago = value; }
        }
        public string ventipofactura
        {
            get { return this._ventipofactura; }
            set { this._ventipofactura = value; }
        }
        public string vennroticket
        {
            get { return this._vennroticket; }
            set { this._vennroticket = value; }
        }
        public int venptodeventa
        {
            get { return this._venptodeventa; }
            set { this._venptodeventa = value; }
        }
        public string vendescuento
        {
            get { return this._vendescuento; }
            set { this._vendescuento = value; }
        }
        public int venccorriente
        {
            get { return this._venccorriente; }
            set { this._venccorriente = value; }
        }

        public string venimp21
        {
            get { return this._venimp21; }
            set { this._venimp21 = value; }
        }
        public string venIVA21
        {
            get { return this._veniva21; }
            set { this._veniva21 = value; }
        }
        public string venimp105
        {
            get { return this._venimp105; }
            set { this._venimp105 = value; }
        }
        public string venIVA105
        {
            get { return this._veniva105; }
            set { this._veniva105 = value; }
        }
        public string venimpexcento
        {
            get { return this._venimpexcento; }
            set { this._venimpexcento = value; }
        }
        public int venusuventapedido
        {
            get { return this._venusuventapedido; }
            set { this._venusuventapedido = value; }
        }
        public int VentaidparaNota
        {
            get { return this._ventaidparanota; }
            set { this._ventaidparanota = value; }
        }
        public string venproductoide
        {
            get { return this._venproducide; }
            set { this._venproducide = value; }
        }
        public int proformaide
        {
            get { return this._proformaide; }
            set { this._proformaide = value; }
        }
    }
}
