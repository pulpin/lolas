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
    public class Clientes
    {
        string _cuit, _razonsocial, _domicilio, _telefono, _nombre, _obs;
        int _situacion, _alta, _clienteide, _dni, _consultapornombre;
        public DataTable Mostrar_clientes()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select CLI_CUIT,CLI_NOMBRE,CLI_DIRE,CLI_TELEFONO,TIPI_DESC,CLI_IDE,TIPI_LETRA,CLI_TIPI_IDE,CLI_IDE FROM clientes LEFT JOIN tipoiva as tiv ON CLI_TIPI_IDE = TIPI_IDE");

        }
        public DataTable Mostrar_clientesReservas()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select CLIEN_NOMBRE,CLIEN_TELEFONO,CLIEN_IDE,CLIEN_OBS FROM clientesli order by CLIEN_NOMBRE");

        }
        public DataTable Mostrar_clientesBuscar()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            string contiene = "%";
            string valor = this.Nombre;
            string filtro = $"(CLI_NOMBRE LIKE '%{valor}%' OR " +
                $"CLI_TELEFONO LIKE '%{valor}%' OR " +
                $"CLI_CUIT LIKE '%{valor}%' OR " +
                $"CLI_IDE LIKE '%{valor}%')";

            return con.Mostrar_Datos("SELECT CLI_CUIT, CLI_NOMBRE, CLI_DIRE, CLI_TELEFONO, TIPI_DESC, CLI_IDE, TIPI_LETRA, CLI_TIPI_IDE " +
                                     "FROM clientes " +
                                     "LEFT JOIN tipoiva as tiv ON CLI_TIPI_IDE = TIPI_IDE " +
                                     "WHERE " + filtro);
        }

        public DataTable Mostrar_clientesBuscarReservas()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            string contiene = "%";
            string valor = "CLIEN_NOMBRE like " + "'" + contiene + "" + this.Nombre + "%" + "'";

            return con.Mostrar_Datos("select CLIEN_NOMBRE,CLIEN_TELEFONO,CLIEN_IDE,CLIEN_OBS FROM clientesli where " + valor + "");
        }
        public DataTable Mostrar_clientesCC()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select CC_IDE,CC_NRODOC,CC_NOMBRE,CC_DIRECCION,CC_TEL FROM cccliente where CC_HABILITADO = 0");

        }
        public DataTable Mostrar_clientesCCBuscar()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            string contiene = "%";
            string valor = "CC_NOMBRE like " + "'" + contiene + "" + this.Nombre + "%" + "'";

            return con.Mostrar_Datos("select CC_IDE,CC_NRODOC,CC_NOMBRE,CC_DIRECCION,CC_TEL FROM cccliente where "+ valor +" and CC_HABILITADO = 0");

        }

        public DataTable Mostrar_detallecuentacorriente()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select CUCO_VEN_IDE,CUCO_FECHAVTA,CUCO_APAGAR,CUCO_PAGO,CUCO_FECHAPAGO,CUCO_SALDO,CUCO_IDE " +
                                     " from cuentacorriente as cc WHERE cc.CUCO_CC_IDE = " + this.Clienteide + "");

        }

        public DataTable Mostrar_clientesLI()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            
            string porcentaje = "%";
            if (Consultapornombre == 1)
            {
                return con.Mostrar_Datos("select * FROM clientesli where CLIEN_NOMBRE like " + "'" + porcentaje + "" + this.Nombre + "%" + "'");
            }
            else
            {
                return con.Mostrar_Datos("select * FROM clientesli where CLIEN_TELEFONO =  '" + this.Telefono +"'");
            }

        }

        public DataTable Tabladedatos_situacion()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            return con.Mostrar_Datos("select TIPI_IDE,TIPI_DESC from lolasdb.tipoiva order by TIPI_DESC");
        }

        public int spInsertarCliente()
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
                myCommand.CommandText = "spAltaCliente";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pcuit", this.Cuit);
                myCommand.Parameters.AddWithValue("prazonsocial", this.Razonsocial);
                myCommand.Parameters.AddWithValue("pdomicilio", this.Domicilio);
                myCommand.Parameters.AddWithValue("ptelefono", this.Telefono);
                myCommand.Parameters.AddWithValue("psituacion", this.Situacion);
                myCommand.Parameters.AddWithValue("palta", this.Alta);
                myCommand.Parameters.AddWithValue("pcliide", this.Clienteide);
                myCommand.Parameters.AddWithValue("usuide", Globales.gbUsuide);

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


        
        public int spInsertarClienteCC()
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
                myCommand.CommandText = "spAltaClienteCC";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pdni", this.Dni);
                myCommand.Parameters.AddWithValue("pnombre", this.Nombre);
                myCommand.Parameters.AddWithValue("pdomicilio", this.Domicilio);
                myCommand.Parameters.AddWithValue("ptelefono", this.Telefono);
                myCommand.Parameters.AddWithValue("palta", this.Alta);
                myCommand.Parameters.AddWithValue("usuide", Globales.gbUsuide);
                myCommand.Parameters.AddWithValue("ccidep", this.Clienteide);

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

        public int spControlaSiExisteTele(string tele)
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
                myCommand.CommandText = "spControlaExisTele";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("ptelefono", tele);

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

        public int spInsertarClienteReservas()
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
                myCommand.CommandText = "spAltaClienteRe";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pnombre", this.Nombre);
                myCommand.Parameters.AddWithValue("ptelefono", this.Telefono);
                myCommand.Parameters.AddWithValue("palta", this.Alta);
                myCommand.Parameters.AddWithValue("usuide", Globales.gbUsuide);
                myCommand.Parameters.AddWithValue("clienide", this.Clienteide);
                myCommand.Parameters.AddWithValue("pobs", this.Obs);

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


        public int spVersiexiste()
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
                myCommand.CommandText = "spexistecuit";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("cuitp", this.Cuit);

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

        public int spVersiexisteCC()
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
                myCommand.CommandText = "spexistecliCC";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("dnip", this.Dni);

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

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public int Dni
        {
            get { return this._dni; }
            set { this._dni = value; }
        }

        public int Consultapornombre
        {
            get { return this._consultapornombre; }
            set { this._consultapornombre = value; }
        }

        public string Cuit
        {
            get { return this._cuit; }
            set { this._cuit = value; }
        }
        public string Razonsocial
        {
            get { return this._razonsocial; }
            set { this._razonsocial = value; }
        }
        public string Domicilio
        {
            get { return this._domicilio; }
            set { this._domicilio = value; }
        }
        public string Telefono
        {
            get { return this._telefono; }
            set { this._telefono = value; }
        }
        public string Obs
        {
            get { return this._obs; }
            set { this._obs = value; }
        }
        public int Situacion
        {
            get { return this._situacion; }
            set { this._situacion = value; }
        }
        public int Alta
        {
            get { return this._alta; }
            set { this._alta = value; }
        }

        public int Clienteide
        {
            get { return this._clienteide; }
            set { this._clienteide = value; }
        }
    }
}
