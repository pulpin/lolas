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
    public class Reservas
    {
        int _cliide, _cantidad, _reseide, _paraavisar, _avisado, _entregado, _alaventa, _estado;
        string _clitelefono=string.Empty, _codigolibro, _desc, _editorial, _precio, _autor, _obs, _nombre=string.Empty;

        public int spInsertarReserva()
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
                myCommand.CommandText = "spAltaReserva";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("cliidep", this.Cliide);
                myCommand.Parameters.AddWithValue("telefonop", this.Clitelefono);
                myCommand.Parameters.AddWithValue("codigoviejop", this.Codigolibro);
                myCommand.Parameters.AddWithValue("descp", this.Desc);
                myCommand.Parameters.AddWithValue("editorialp", this.Editorial);
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

        public int spInsertarReserva1()
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
                myCommand.CommandText = "spAltaReserva";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("cliidep", this.Cliide);
                myCommand.Parameters.AddWithValue("codigoviejop", this.Codigolibro);
                myCommand.Parameters.AddWithValue("descp", this.Desc);
                myCommand.Parameters.AddWithValue("autorp", this.Autor);
                myCommand.Parameters.AddWithValue("editorialp", this.Editorial);
                myCommand.Parameters.AddWithValue("preciop", this.Precio);
                myCommand.Parameters.AddWithValue("cantidadp", this.Cantidad);
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


        public int spModificarReserva()
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
                myCommand.CommandText = "spModificaReserva";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("cliidep", this.Cliide);
                myCommand.Parameters.AddWithValue("codigoviejop", this.Codigolibro);
                myCommand.Parameters.AddWithValue("descp", this.Desc.Trim());
                myCommand.Parameters.AddWithValue("autorp", this.Autor.Trim());
                myCommand.Parameters.AddWithValue("editorialp", this.Editorial.Trim());
                myCommand.Parameters.AddWithValue("preciop", this.Precio);
                myCommand.Parameters.AddWithValue("cantidadp", this.Cantidad);
                myCommand.Parameters.AddWithValue("reseidep", this.Reservaide);
                myCommand.Parameters.AddWithValue("obsp", this.Obs);
                myCommand.Parameters.AddWithValue("reservausuide", Globales.usureservaide);
                myCommand.Parameters.AddWithValue("paraavisarp", this.Paraavisar);
                myCommand.Parameters.AddWithValue("avisadop", this.Avisado);
                myCommand.Parameters.AddWithValue("entregadop", this.Entregado);
                myCommand.Parameters.AddWithValue("alaventap", this.Alaventa);
                myCommand.Parameters.AddWithValue("estadop", this.Estado);
                myCommand.Parameters.AddWithValue("usuide", Globales.usureservaide);

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

        public int spMarcarparaAvisar()
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
                myCommand.CommandText = "spMarcaParaAvisar";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("preseride", this.Reservaide);
                myCommand.Parameters.AddWithValue("pobs", this.Obs);
                myCommand.Parameters.AddWithValue("pusuide", Globales.usureservaide);
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

        public DataTable Mostrar_Reservas()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select CLIEN_NOMBRE,CLIEN_TELEFONO,RESE_LI_CODIGOVIEJO,RESE_DESC,RESE_AUTOR, " +
                                    " RESE_EDITORIAL, RESE_PRECIO, RESE_FECHA,RESE_CANTIDAD,  " +
                                    " RESE_IDE,RESE_USUA_IDE,RESE_USUL_IDE,RESE_USUE_IDE,usu1.USU_NOMBRE as Cargado,usu4.USU_NOMBRE as paraavisar,RESE_USUP_FE,usu2.USU_NOMBRE as Avisado,RESE_USUL_FE,usu3.USU_NOMBRE as Entregado,RESE_USUE_FE,usu5.USU_NOMBRE as Alaventa,RESE_USUV_FE,RESE_USUE_FE,RESE_ESTADO,RESE_CLIE_IDE,RESE_OBS,usu6.USU_NOMBRE as usumodificar,RESE_USUM_FE,u.USU_NOMBRE as usualta from reservas " +
                                    " left join clientesli on RESE_CLIE_IDE = CLIEN_IDE " +
                                    " left join usuarios.usuarios as u on RESE_USUA_IDE = USU_IDE " +
                                    " left join usuarios.usuarios as usu1 on RESE_USUA_IDE = usu1.USU_IDE " +
                                    " left join usuarios.usuarios as usu2 on RESE_USUL_IDE = usu2.USU_IDE " +
                                    " left join usuarios.usuarios as usu3 on RESE_USUE_IDE = usu3.USU_IDE " +
                                    " left join usuarios.usuarios as usu4 on RESE_USUP_IDE = usu4.USU_IDE " +
                                    " left join usuarios.usuarios as usu5 on RESE_USUV_IDE = usu5.USU_IDE " +
                                    " left join usuarios.usuarios as usu6 on RESE_USUM_IDE = usu6.USU_IDE ");

        }

        public DataTable Mostrar_ReservasBuscar()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            string contiene = "%",valor = string.Empty;
            valor = "CLIEN_IDE > 0";
            if(this.Nombre != string.Empty)
            { 
                valor = "CLIEN_NOMBRE like " + "'" + contiene + "" + this.Nombre + "%" + "'";
                
            }
            if (this.Clitelefono != string.Empty)
            {
                valor = "CLIEN_TELEFONO = " + this.Clitelefono;
            }
            if (this.Desc != string.Empty)
            {
                valor = "RESE_DESC like " + "'" + contiene + "" + this.Desc + "%" + "'";
            }
            return con.Mostrar_Datos("select CLIEN_NOMBRE,CLIEN_TELEFONO,RESE_LI_CODIGOVIEJO,RESE_DESC,RESE_AUTOR, " +
                                    " RESE_EDITORIAL, RESE_PRECIO, RESE_FECHA,RESE_CANTIDAD,  " +
                                    " RESE_IDE,RESE_USUA_IDE,RESE_USUL_IDE,RESE_USUE_IDE,usu1.USU_NOMBRE as Cargado,usu4.USU_NOMBRE as paraavisar,RESE_USUP_FE,usu2.USU_NOMBRE as Avisado,RESE_USUL_FE,usu3.USU_NOMBRE as Entregado,usu5.USU_NOMBRE as Alaventa,RESE_USUV_FE,RESE_USUE_FE,RESE_ESTADO,RESE_CLIE_IDE,RESE_OBS,usu6.USU_NOMBRE as usumodificar,RESE_USUM_FE,u.USU_NOMBRE as usualta,RESE_USUA_FE" +
                                    " from reservas " +
                                    " left join clientesli on RESE_CLIE_IDE = CLIEN_IDE " +
                                    " left join usuarios.usuarios as u on RESE_USUA_IDE = USU_IDE " +
                                    " left join usuarios.usuarios as usu1 on RESE_USUA_IDE = usu1.USU_IDE " +
                                    " left join usuarios.usuarios as usu2 on RESE_USUL_IDE = usu2.USU_IDE " +
                                    " left join usuarios.usuarios as usu3 on RESE_USUE_IDE = usu3.USU_IDE " +
                                    " left join usuarios.usuarios as usu4 on RESE_USUP_IDE = usu4.USU_IDE " +
                                    " left join usuarios.usuarios as usu5 on RESE_USUV_IDE = usu5.USU_IDE " +
                                    " left join usuarios.usuarios as usu6 on RESE_USUM_IDE = usu6.USU_IDE  where " + valor + "");
        }

    public DataTable Mostrar_Reservasunproducto()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select CLIEN_NOMBRE,CLIEN_TELEFONO,RESE_LI_CODIGOVIEJO,RESE_DESC,RESE_AUTOR, " +
                                    " RESE_EDITORIAL, RESE_PRECIO, RESE_FECHA,RESE_CANTIDAD,  " +
                                    " RESE_IDE,RESE_USUA_IDE,RESE_USUL_IDE,RESE_USUE_IDE,usu1.USU_NOMBRE as Cargado,usu4.USU_NOMBRE as paraavisar,RESE_USUP_FE,usu2.USU_NOMBRE as Avisado,RESE_USUL_FE,usu3.USU_NOMBRE as Entregado,usu5.USU_NOMBRE as Alaventa,RESE_USUV_FE,RESE_USUE_FE,RESE_ESTADO,RESE_CLIE_IDE,RESE_OBS,usu6.USU_NOMBRE as usumodificar,RESE_USUM_FE from reservas " +
                                    " left join clientesli on RESE_CLIE_IDE = CLIEN_IDE " +
                                    " left join usuarios.usuarios on RESE_USUA_IDE = USU_IDE " +
                                    " left join usuarios.usuarios as usu1 on RESE_USUA_IDE = usu1.USU_IDE " +
                                    " left join usuarios.usuarios as usu2 on RESE_USUL_IDE = usu2.USU_IDE " +
                                    " left join usuarios.usuarios as usu3 on RESE_USUE_IDE = usu3.USU_IDE " +
                                    " left join usuarios.usuarios as usu4 on RESE_USUP_IDE = usu4.USU_IDE " +
                                    " left join usuarios.usuarios as usu5 on RESE_USUV_IDE = usu5.USU_IDE " +
                                    " left join usuarios.usuarios as usu6 on RESE_USUM_IDE = usu6.USU_IDE where RESE_LI_CODIGOVIEJO = '"+ this.Codigolibro +"'");

        }

        public DataTable Mostrar_Reservasporfecha(string fechadesde, string fechahasta)
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select RESE_LI_CODIGOVIEJO,RESE_DESC,RESE_AUTOR, " +
                                    " RESE_EDITORIAL, RESE_FECHA, sum(RESE_CANTIDAD) as RESE_CANTIDAD, " +
                                    " RESE_IDE, RESE_USUA_IDE,LI_IDE from reservas  " +
                                    " left join clientesli on RESE_CLIE_IDE = CLIEN_IDE " +
                                    " left join usuarios.usuarios on RESE_USUA_IDE = USU_IDE " +
                                    " left join usuarios.usuarios as usu1 on RESE_USUA_IDE = usu1.USU_IDE " +
                                    " left join usuarios.usuarios as usu2 on RESE_USUL_IDE = usu2.USU_IDE " +
                                    " left join usuarios.usuarios as usu3 on RESE_USUE_IDE = usu3.USU_IDE " +
                                    " left join usuarios.usuarios as usu4 on RESE_USUP_IDE = usu4.USU_IDE " +
                                    " left join usuarios.usuarios as usu5 on RESE_USUV_IDE = usu5.USU_IDE " +
                                    " left join usuarios.usuarios as usu6 on RESE_USUM_IDE = usu6.USU_IDE  " +
                                    " LEFT JOIN libros on RESE_LI_CODIGOVIEJO = li_codigoviejo where RESE_ESTADO = 0 " +
                                    " and RESE_FECHA >= '" + fechadesde + "' AND RESE_FECHA <= '" + fechahasta + "' AND RESE_LI_CODIGOVIEJO <> '' and RESE_FUEPEDIDO = FALSE group by RESE_LI_CODIGOVIEJO");

        }

        public DataTable Mostrar_pedidos(int eslibro)
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            string tipopro = string.Empty;
            
            con.AbrirConexio();
            if (eslibro == 1)
            {
                tipopro = " and li.LI_TIPOPRO = 0 ";
            }
            else
            {
                tipopro = " and li.LI_TIPOPRO > 0 ";
            }
            return con.Mostrar_Datos("select EDI_EDITORIAL,EDI_CODIGO from libros as li left join editorial as ed " +
                                    " on li.LI_EDI_CODIGO = ed.EDI_CODIGO " +
                                    " WHERE LI_PEDIDOS > 0  " + tipopro + "" +
                                    " GROUP BY EDI_EDITORIAL");

        }

        public DataTable Mostrar_pedidosporeditorial(string editoriales)
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select li.LI_CODIGOVIEJO,li.LI_BARRA,li.LI_DESC,li.LI_AUTOR,EDI_EDITORIAL as editorial,li.LI_PEDIDOS,li.LI_EDI_CODIGO,li.LI_IDE,li.LI_CODIGOPROVEE from libros as li left join editorial as ed " +
                                       " on li.LI_EDI_CODIGO = ed.EDI_CODIGO " +
                                       " WHERE " + editoriales + " and LI_PEDIDOS > 0 " +
                                       " ");

        }

        public DataTable Mostrar_Reservas(int estado)
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select CLIEN_NOMBRE,CLIEN_TELEFONO,RESE_LI_CODIGOVIEJO,RESE_DESC, " +
                                    " RESE_EDITORIAL, RESE_PRECIO, RESE_FECHA,RESE_CANTIDAD,  " +
                                    " RESE_IDE,RESE_USUA_IDE,RESE_USUL_IDE,RESE_USUE_IDE,usu1.USU_NOMBRE as Cargado,usu4.USU_NOMBRE as paraavisar,RESE_USUP_FE,usu2.USU_NOMBRE as Avisado,RESE_USUL_FE,usu3.USU_NOMBRE as Entregado,usu5.USU_NOMBRE as Alaventa,RESE_USUV_FE,RESE_USUE_FE,RESE_ESTADO,RESE_CLIE_IDE,RESE_OBS from reservas " +
                                    " left join clientesli on RESE_CLIE_IDE = CLIEN_IDE " +
                                    " left join usuarios.usuarios on RESE_USUA_IDE = USU_IDE " +
                                    " left join usuarios.usuarios as usu1 on RESE_USUA_IDE = usu1.USU_IDE " +
                                    " left join usuarios.usuarios as usu2 on RESE_USUL_IDE = usu2.USU_IDE " +
                                    " left join usuarios.usuarios as usu3 on RESE_USUE_IDE = usu3.USU_IDE " +
                                    " left join usuarios.usuarios as usu4 on RESE_USUP_IDE = usu4.USU_IDE " +
                                    " left join usuarios.usuarios as usu5 on RESE_USUV_IDE = usu5.USU_IDE where RESE_ESTADO = " + estado +"");

        }

        public int Cliide
        {
            get { return this._cliide; }
            set { this._cliide = value; }
        }

        public int Paraavisar
        {
            get { return this._paraavisar; }
            set { this._paraavisar = value; }
        }

        public int Avisado
        {
            get { return this._avisado; }
            set { this._avisado = value; }
        }

        public int Entregado
        {
            get { return this._entregado; }
            set { this._entregado = value; }
        }

        public int Alaventa
        {
            get { return this._alaventa; }
            set { this._alaventa = value; }
        }

        public int Estado
        {
            get { return this._estado; }
            set { this._estado = value; }
        }

        public int Cantidad
        {
            get { return this._cantidad; }
            set { this._cantidad = value; }
        }

        public int Reservaide
        {
            get { return this._reseide; }
            set { this._reseide = value; }
        }

        public string Clitelefono
        {
            get { return this._clitelefono; }
            set { this._clitelefono = value; }
        }

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public string Obs
        {
            get { return this._obs; }
            set { this._obs = value; }
        }

        public string Codigolibro
        {
            get { return this._codigolibro; }
            set { this._codigolibro = value; }
        }
        public string Desc
        {
            get { return this._desc; }
            set { this._desc = value; }
        }
        public string Autor
        {
            get { return this._autor; }
            set { this._autor = value; }
        }
        public string Editorial
        {
            get { return this._editorial; }
            set { this._editorial = value; }
        }
        public string Precio
        {
            get { return this._precio; }
            set { this._precio = value; }
        }
    }
}
