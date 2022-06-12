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
    public class Rendiciones
    {
        int _ediide, _cantidad, _consigna, _nrorendi;
        string _codigo, _fecha, _fechad, _fechah, _importe, _factura, _fechavta, _fecharendi;
        public DataTable Mostrar_rendiciones()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select PRENMA_IDE,PRENMA_EDI_IDE,EDI_EDITORIAL,PRENMA_FECHA,PRENMA_CANTIDAD,PRENMA_PAGADO, " +
                                    " PRENMA_DESDE, PRENMA_HASTA, PRENMA_BAJA from pararendicionmaestro " +
                                    " left join editorial on EDI_CODIGO = PRENMA_EDI_IDE order by PRENMA_IDE desc");

        }

        public DataTable Mostrar_historicodevoluciones()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select DEVM_EDI_CODIGO,EDI_EDITORIAL,DEVM_FECHA,DEVM_OBS, " +
                                     " DEVM_IDE from devolucionmaestro as dev left join " +
                                     " editorial as edi on dev.DEVM_EDI_CODIGO = edi.EDI_CODIGO " +
                                     " order by DEVM_IDE desc");

        }

        public DataTable Mostrar_rendicionesdetalles()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("SELECT PREN_LI_CODIGOVIEJO,LI_DESC,LI_AUTOR,PREN_CANTIDAD,PREN_FECHAVTA,PREN_FACTU, " +
                                    " PREN_CONSIGNA, PREN_IMPORTE FROM pararendicion left join libros on PREN_LI_CODIGOVIEJO = LI_CODIGOVIEJO " +
                                    " left join pararendicionmaestro on PRENMA_IDE = PREN_NRORENDICION where PREN_NRORENDICION = '" + this.Codigo + "' order by PREN_FACTU");

        }

        public DataTable Mostrar_rendicionesdetallesinagru()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("SELECT PREN_LI_CODIGOVIEJO,LI_CODIGOPROVEE,LI_DESC,LI_AUTOR,PREN_CANTIDAD,PREN_FECHAVTA,PREN_FACTU, " +
                                    " PREN_CONSIGNA, PREN_IMPORTE,EDI_EDITORIAL,EDI_CALLE,EDI_NRO,EDI_PORCEN,LI_BARRA FROM pararendicion left join libros on PREN_LI_CODIGOVIEJO = LI_CODIGOVIEJO " +
                                    " left join pararendicionmaestro on PRENMA_IDE = PREN_NRORENDICION left join editorial on PRENMA_EDI_IDE = EDI_CODIGO where PREN_NRORENDICION = '" + this.Codigo + "' order by PREN_FACTU");

        }

        public DataTable Mostrar_devolucionesdetalle()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select DEV_REMITO,DEV_CODIGOVIEJO,DEV_DESC,DEV_NROCONSIGNA,DEV_CANTIORIGINAL, " +
                                     " DEV_CANTIDEVOL,DEV_IMPORTE,(DEV_CANTIDEVOL*DEV_IMPORTE) as subtotal from devolucion where DEV_DEVM_IDE = '" + this.Codigo + "'");
        }

        public DataTable Mostrar_rendicionesdetallesagrupados()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("SELECT PREN_LI_CODIGOVIEJO,LI_DESC,LI_AUTOR,sum(PREN_CANTIDAD) PREN_CANTIDAD,PREN_FECHAVTA, " +
            " PREN_CONSIGNA, sum(PREN_IMPORTE) as PREN_IMPORTE, EDI_EDITORIAL, EDI_CALLE, EDI_NRO, EDI_PORCEN, LI_BARRA FROM pararendicion left join libros on PREN_LI_CODIGOVIEJO = LI_CODIGOVIEJO " +
            " left join pararendicionmaestro on PRENMA_IDE = PREN_NRORENDICION left join editorial on PRENMA_EDI_IDE = EDI_CODIGO where PREN_NRORENDICION = '" + this.Codigo + "' group by PREN_LI_CODIGOVIEJO order by PREN_FACTU");

        }

        public DataTable Mostrar_rendicionporproducto()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("SELECT PREN_FACTU,PREN_CANTIDAD,PREN_FECHAVTA,PREN_IMPORTE,PREN_CONSIGNA,PREN_NRORENDICION,PREN_FECHARENDI,PREN_LI_CODIGOVIEJO FROM pararendicion where PREN_LI_CODIGOVIEJO = '" + this.Codigo + "'");

        }

        public int spNuevaRendicion()
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

            //this.venimp21 HUGO
          /*
            this.venimpexcento = this.venimpexcento.Replace(",", ".");
            */
            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "spAltaRendicion";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("REN_EDI_IDE", this.editorialide);
                myCommand.Parameters.AddWithValue("REN_FDESDE", this.Fechad);
                myCommand.Parameters.AddWithValue("REN_FHASTA", this.Fechah);
                myCommand.Parameters.AddWithValue("REN_CANTIDAD", this.Cantidad);
                myCommand.Parameters.AddWithValue("REN_IMPORTE", this.Importe);
                myCommand.Parameters.AddWithValue("REN_USUARIO", Globales.gbUsuide);

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

        public int spNuevaRendiciondetalle()
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
                myCommand.CommandText = "spAltaRendiciondetalle";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pcodigo", this.Codigo);
                myCommand.Parameters.AddWithValue("pnrorendi", this.Nrorendi);
                myCommand.Parameters.AddWithValue("pusuide", Globales.gbUsuide);

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

        public string Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }

        public int editorialide
        {
            get { return this._ediide; }
            set { this._ediide = value; }
        }

        public string fecha
        {
            get { return this._fecha; }
            set { this._fecha = value; }
        }

        public int Cantidad
        {
            get { return this._cantidad; }
            set { this._cantidad = value; }
        }

        public string Fechad
        {
            get { return this._fechad; }
            set { this._fechad = value; }
        }

        public string Importe
        {
            get { return this._importe; }
            set { this._importe = value; }
        }

        public string Fechah
        {
            get { return this._fechah; }
            set { this._fechah = value; }
        }

        public string Factura
        {
            get { return this._factura; }
            set { this._factura = value; }
        }
        public int Consigna
        {
            get { return this._consigna; }
            set { this._consigna = value; }
        }

        public string Fechavta
        {
            get { return this._fechavta; }
            set { this._fechavta = value; }
        }

        public int Nrorendi
        {
            get { return this._nrorendi; }
            set { this._nrorendi = value; }
        }


        public string Fecharendi
        {
            get { return this._fecharendi; }
            set { this._fecharendi = value; }
        }

    }
    
}
