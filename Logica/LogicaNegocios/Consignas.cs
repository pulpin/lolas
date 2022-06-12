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
    public class Consignas
    {
        string _codigo, _fecharecep, _fechaenvio, _remito, _precio, _produide;
        int _cantidad, _codigoconsig, _consigide, _codigoeditorial, _modicatalogo;
        public int spInsertarConsignaMae()
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
                myCommand.CommandText = "spAltaConsigMae";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pcodigo", this.Codigo);
                myCommand.Parameters.AddWithValue("pfechaenvio", this.Fechaenvio);
                myCommand.Parameters.AddWithValue("pfecharecep", this.Fecharecep);
                myCommand.Parameters.AddWithValue("premito", this.Remito);
                myCommand.Parameters.AddWithValue("pusuide", Globales.gbUsuide);

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

            return Valor_Retornado;
        }

        public int spInsertarConsignaDetalle()
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
                myCommand.CommandText = "spAltaConsigDet";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pcodigo", this.Codigo);
                myCommand.Parameters.AddWithValue("pcantidad", this.Cantidad);
                myCommand.Parameters.AddWithValue("pprecio", this.Precio);
                myCommand.Parameters.AddWithValue("pconsignam", this.Codigoconsig);
                myCommand.Parameters.AddWithValue("pcodigoedi", this.Codigoeditorial);
                myCommand.Parameters.AddWithValue("pusuide", Globales.gbUsuide);
                myCommand.Parameters.AddWithValue("modicatalogo", this.ModificaprecioCatalogo);

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

            return Valor_Retornado;
        }

        public int spControlarReserva()
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
                myCommand.CommandText = "spControlaReserva";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pcodigo", this.Codigo);

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

            return Valor_Retornado;
        }

        public DataTable Mostrar_consignas()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select CONMA_IDE,CONMA_EDI_CODIGO,EDI_EDITORIAL,CONMA_FECRECEPCION,CONMA_FECENVIO,CONMA_REMITO from consignasmaestro left join editorial on EDI_CODIGO = CONMA_EDI_CODIGO order by CONMA_IDE desc");

        }

        public DataTable Mostrar_consignasdetalles()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("SELECT CONS_LI_CODIGOVIEJO,LI_DESC,LI_AUTOR,CONS_CANTIDAD,CONS_IMPORTE,CONS_RENDIDO,CONS_IDE FROM consignas left join libros on CONS_LI_CODIGOVIEJO = LI_CODIGOVIEJO where CONS_NROCONSIG = '" + this.Codigo + "'");

        }

        public DataTable Mostrar_consignasdevolucion()
        {
            string usuarioss = String.Empty;
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select CONS_NROCONSIG,conm.CONMA_REMITO as CONS_REMITO,CONS_FECENVIO,CONS_FECRECEP, " +
                                     " CONS_CANTIDAD, CONS_IMPORTE, CONS_ORIGINAL, CONS_RENDIDO,CONS_FECCARGA,CONS_IDE from consignas as co " +
                                     " left join consignasmaestro as conm on co.CONS_NROCONSIG = conm.CONMA_IDE " +
                                     " where CONS_EDI_CODIGO = "+ this.Codigoeditorial +" and CONS_CANTIDAD > 0 and CONS_LI_CODIGOVIEJO = '" + this.Codigo + "'");

        }

        

        public DataTable Mostrar_consignasporproducto()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select CONS_NROCONSIG,CONS_REMITO,CONS_FECENVIO,CONS_FECRECEP, " +
                                      " CONS_CANTIDAD, CONS_IMPORTE, CONS_ORIGINAL, CONS_RENDIDO from consignas as co " +
                                      " left join consignasmaestro as conm on co.CONS_NROCONSIG = conm.CONMA_IDE where CONS_LI_CODIGOVIEJO = '" + this.Codigo + "' and CONMA_EDI_CODIGO = "+ this.Codigoeditorial +"");

        }

        public DataTable Mostrar_consignasporproductosineditorial()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select CONS_NROCONSIG,CONMA_REMITO as CONS_REMITO,CONMA_FECENVIO as CONS_FECENVIO,CONMA_FECRECEPCION as CONS_FECRECEP, " +
                                      " CONS_CANTIDAD, CONS_IMPORTE, CONS_ORIGINAL, CONS_RENDIDO from consignas as co " +
                                      " left join consignasmaestro as conm on co.CONS_NROCONSIG = conm.CONMA_IDE where CONS_LI_CODIGOVIEJO = '" + this.Codigo + "' order by CONS_NROCONSIG desc");

        }

        public int spEliminarProducto()
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
                myCommand.CommandText = "spEliminarproCon";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("produide", this.Producide);
                myCommand.Parameters.AddWithValue("cantidad", this.Cantidad);
                myCommand.Parameters.AddWithValue("considep", this.Consigide);
                myCommand.Parameters.AddWithValue("usuide", Globales.gbUsuide);

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

        public string Producide
        {
            get { return this._produide; }
            set { this._produide = value; }
        }

        public int Consigide
        {
            get { return this._consigide; }
            set { this._consigide = value; }
        }

        
        public int Cantidad
        {
            get { return this._cantidad; }
            set { this._cantidad = value; }
        }
        public int Codigoconsig
        {
            get { return this._codigoconsig; }
            set { this._codigoconsig = value; }
        }
        public int Codigoeditorial
        {
            get { return this._codigoeditorial; }
            set { this._codigoeditorial = value; }
        }

        public int ModificaprecioCatalogo
        {
            get { return this._modicatalogo; }
            set { this._modicatalogo = value; }
        }

        public string Precio
        {
            get { return this._precio; }
            set { this._precio = value; }
        }
        public string Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }
        public string Fecharecep
        {
            get { return this._fecharecep; }
            set { this._fecharecep = value; }
        }
        public string Fechaenvio
        {
            get { return this._fechaenvio; }
            set { this._fechaenvio = value; }
        }
        public string Remito
        {
            get { return this._remito; }
            set { this._remito = value; }
        }

    }
}
