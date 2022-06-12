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
    public class DineroCaja
    {
        string _obs, _precio, _totalefectivo, _totaltarjeta, _totalajuste, _subtotalvta, _dinerocaja1, _diferencia, _tarjetaencaja, _subtotalencaja;
        int _ide, _alta;
        public DataTable Mostrar_dinerocaja()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select PC_FECHA,PC_DINERO,PC_OBS,PC_IDE,PC_PUNTODEVTA,PC_TOTALEFECTIVO,PC_TOTALTARJETA,PC_TOTALAJUSTE,PC_SUBTOTALVENTAS,PC_DINEROENCAJA,PC_TARJETAENCAJA,PC_SUBTOTALENCAJA,PC_DIFERENCIA from plata_caja where PC_PUNTODEVTA = " + Globales.puntodeventa + " order by PC_FECHA desc");

        }

        public DataTable Mostrar_dinerocajahoy()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select PC_FECHA,PC_DINERO,PC_OBS,PC_IDE,PC_PUNTODEVTA,PC_TOTALEFECTIVO,PC_TOTALTARJETA,PC_TOTALAJUSTE,PC_SUBTOTALVENTAS,PC_DINEROENCAJA,PC_TARJETAENCAJA,PC_SUBTOTALENCAJA,PC_DIFERENCIA from plata_caja where PC_PUNTODEVTA = " + Globales.puntodeventa + " and PC_FECHA = CURDATE() order by PC_FECHA desc");

        }

        public int spVerDineroCaja()
        {
            int Valor_Retornado = 0;
            string cadenaconexion;


            Conexion con = new Conexion("lolasdb", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            mysql_conexion.Open();
            MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            myCommand.Transaction = sqlTran;

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "spVerDineroCaja";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("ptodeventa", Globales.puntodeventa);
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

        public string spConsultaCajadeDia(int puntodeventa,string fecha)
        {
            string Valor_Retornado = string.Empty;
            string cadenaconexion;


            Conexion con = new Conexion("lolasdb", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            mysql_conexion.Open();
            MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            myCommand.Transaction = sqlTran;

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "spConsultaCajadelDia";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("ptodeventa", puntodeventa);
                myCommand.Parameters.AddWithValue("pfecha", fecha);
                MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.VarChar);
                MySqlParameter ValorRetorno2 = new MySqlParameter("@Resultado2", MySqlDbType.Int32);
                ValorRetorno.Direction = ParameterDirection.Output;// Output;
                ValorRetorno2.Direction = ParameterDirection.Output;// Output;
                myCommand.Parameters.Add(ValorRetorno);
                myCommand.Parameters.Add(ValorRetorno2);
                myCommand.ExecuteNonQuery();
                Valor_Retornado = Convert.ToString(ValorRetorno.Value);
                this.Ide = Convert.ToInt32(ValorRetorno2.Value);
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

        public int spAltaDineroCaja()
        {
            int Valor_Retornado = 0;
            string cadenaconexion;

            Conexion con = new Conexion("lolasdb", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            mysql_conexion.Open();
            MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            myCommand.Transaction = sqlTran;

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "spAltaDineroCaja";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("ptodeventa", Globales.puntodeventa);
                myCommand.Parameters.AddWithValue("precio", this.Precio);
                myCommand.Parameters.AddWithValue("obs", this.Obs);
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

        public int spAltaArqueo()
        {
            int Valor_Retornado = 0;
            string cadenaconexion;

            Conexion con = new Conexion("lolasdb", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            mysql_conexion.Open();
            MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            myCommand.Transaction = sqlTran;

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "spAltaArqueo";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pide", this.Ide);
                myCommand.Parameters.AddWithValue("ptotalefectivo", this.Totalefectivo);
                myCommand.Parameters.AddWithValue("ptotaltarjeta", this.Totaltarjeta);
                myCommand.Parameters.AddWithValue("ptotalajuste", this.Totalajuste);
                myCommand.Parameters.AddWithValue("psubtotalvta", this.Subtotalvta);
                myCommand.Parameters.AddWithValue("pdineroencaja", this.DineroCaja1);
                myCommand.Parameters.AddWithValue("ptarjetaencaja", this.Tarjetaencaja);
                myCommand.Parameters.AddWithValue("psubtotalencaja", this.Subtotalencaja);
                myCommand.Parameters.AddWithValue("pdiferencia", this.Diferencia);
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

        public int spBajaDineroCaja()
        {
            int Valor_Retornado = 0;
            string cadenaconexion;


            Conexion con = new Conexion("lolasdb", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            mysql_conexion.Open();
            MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            myCommand.Transaction = sqlTran;

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "spbajadinerocaja";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pcide", this.Ide);
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
        public string Obs
        {
            get { return this._obs; }
            set { this._obs = value; }
        }

        public string Precio
        {
            get { return this._precio; }
            set { this._precio = value; }
        }
       
        public string Totalefectivo
        {
            get { return this._totalefectivo; }
            set { this._totalefectivo = value; }
        }
        public string Totaltarjeta
        {
            get { return this._totaltarjeta; }
            set { this._totaltarjeta = value; }
        }
        public string Totalajuste
        {
            get { return this._totalajuste; }
            set { this._totalajuste = value; }
        }
        public string Subtotalvta
        {
            get { return this._subtotalvta; }
            set { this._subtotalvta = value; }
        }
        public string DineroCaja1
        {
            get { return this._dinerocaja1; }
            set { this._dinerocaja1 = value; }
        }

        public string Tarjetaencaja
        {
            get { return this._tarjetaencaja; }
            set { this._tarjetaencaja = value; }
        }

        public string Subtotalencaja
        {
            get { return this._subtotalencaja; }
            set { this._subtotalencaja = value; }
        }

        public string Diferencia
        {
            get { return this._diferencia; }
            set { this._diferencia = value; }
        }
        public int Ide
        {
            get { return this._ide; }
            set { this._ide = value; }
        }
        public int Alta
        {
            get { return this._alta; }
            set { this._alta = value; }
        }

    }
}
