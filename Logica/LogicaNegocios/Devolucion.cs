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
    public class Devolucion
    {
        string _codigo, _desc,_remito;
        int _nroconsigna,_cantiori,_cantidev, _consignaide, _rendido, _codigoeditorial, _maestro;
        decimal _precio;
     
        public int spInsertarDevolucion()
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
                myCommand.CommandText = "spAltadevolucion";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pcodigo", this.Codigo);
                myCommand.Parameters.AddWithValue("pdesc", this.Desc);
                myCommand.Parameters.AddWithValue("premito", this.Remito);
                myCommand.Parameters.AddWithValue("pnroconsigna", this.NroConsigna);
                myCommand.Parameters.AddWithValue("pcantiori", this.Cantioriginal);
                myCommand.Parameters.AddWithValue("pcantidev", this.Cantidevolucion);
                myCommand.Parameters.AddWithValue("pimporte", this.Precio);
                myCommand.Parameters.AddWithValue("pusuide", Globales.gbUsuide);
                myCommand.Parameters.AddWithValue("pconsignaide", this.ConsignaIde);
                myCommand.Parameters.AddWithValue("prendido", this.Rendido);
                myCommand.Parameters.AddWithValue("pcodigomaestro", this.CodigoMaestro);

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

        public int spInsertarDevolucionMaestro()
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
                myCommand.CommandText = "spAltadevolucionmae";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pcodigoeditorial", this.CodigoEditorial);
                myCommand.Parameters.AddWithValue("pobs", this.Desc);

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


        public DataTable Mostrar_devoluciones()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select DEV_IDE,DEV_REMITO,DEV_NROCONSIGNA, " +
                                     " DEV_CANTIORIGINAL, DEV_CANTIDEVOL, DEV_IMPORTE, DEVM_FECHA,DEVM_OBS " +
                                     " from devolucion as dev left join devolucionmaestro as devm " +
                                     " on dev.DEV_DEVM_IDE = devm.DEVM_IDE where DEV_CODIGOVIEJO = '" + this.Codigo + "' AND DEVM_EDI_CODIGO = "+ this.CodigoEditorial +"");

        }

        public DataTable Mostrar_consignasdevolucionimprimir()
        {
            string usuarioss = String.Empty;
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select DEV_REMITO,li.LI_BARRA,DEV_CODIGOVIEJO,li.LI_DESC,DEV_CANTIORIGINAL,DEV_CANTIDEVOL, " +
                                    " DEV_IMPORTE,(DEV_CANTIDEVOL * DEV_IMPORTE) as subtotal from devolucion as dev left join devolucionmaestro as devm on " +
                                    " dev.DEV_DEVM_IDE = devm.DEVM_IDE left join libros as li on " +
                                    " dev.DEV_CODIGOVIEJO = li.LI_CODIGOVIEJO " +
                                    " where devm.DEVM_IDE = " + this.CodigoMaestro + " ");

        }

        public string Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }
        public string Desc
        {
            get { return this._desc; }
            set { this._desc = value; }
        }
        public string Remito
        {
            get { return this._remito; }
            set { this._remito = value; }
        }
        public int NroConsigna
        {
            get { return this._nroconsigna; }
            set { this._nroconsigna = value; }
        }
        public int ConsignaIde
        {
            get { return this._consignaide; }
            set { this._consignaide = value; }
        }
        public int Rendido
        {
            get { return this._rendido; }
            set { this._rendido = value; }
        }
        public int Cantioriginal
        {
            get { return this._cantiori; }
            set { this._cantiori = value; }
        }
        public int CodigoEditorial
        {
            get { return this._codigoeditorial; }
            set { this._codigoeditorial = value; }
        }

        public int CodigoMaestro
        {
            get { return this._maestro; }
            set { this._maestro = value; }
        }
        public int Cantidevolucion
        {
            get { return this._cantidev; }
            set { this._cantidev = value; }
        }
        public decimal Precio
        {
            get { return this._precio; }
            set { this._precio = value; }
        }


    }
}
