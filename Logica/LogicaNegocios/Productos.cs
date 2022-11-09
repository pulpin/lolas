using AccesoaDatos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LogicaNegocios
{
    public class Productos
    {
        string _titulo = string.Empty, _autor = string.Empty, valor = string.Empty, contiene = string.Empty, _barra = string.Empty, _codigo = string.Empty,_isbn = string.Empty, _precio = string.Empty, _preciosinmodificar=string.Empty, _costo = string.Empty,_iva = string.Empty, _ganancia = string.Empty,_factura = string.Empty, _imagen = string.Empty, _cuerpo = string.Empty,_estante = string.Empty, _importevta = string.Empty, _codigointernoedi = string.Empty, _stock = string.Empty, _remito = string.Empty,_primervalor, _segundovalor, _codigoprovee, _precioanterior, precioactual;
        decimal _precioante, _preciol;
        int _titup, _autorp, _edip, _pedidos, _alta, _notaparcial, _tipopro, _inventario;
        int _contengapala, _editorial, _genero, _tipo, _cantidad, _productoide, _nrodevta, _proveeide, _dividido, _rendido, _original, _consignacantidad,_consignanro, _consignaide, _consignaactual;
        Conexion con = new Conexion("lolasdb", Globales.ip);
        int stockp, consideactual, resultadop;
        Decimal _primervalordecimal, _segundovalordecimal, _cuartovalordecimal, _quintovalordecimal, _sextovalordecimal, _septimovalordecimal;
        int _tercervalorint, _porcentajecosto;
        string _usuariodioal, _fechadioal, _usuariomodi, _fechausumo;
        public DataTable Mostrar_productos()
        {
            valor = string.Empty;
              Conexion con = new Conexion("lolasdb", Globales.ip);
              con.AbrirConexio();
            if (this.Tipo == 0)
            {
                if (this.Contengapalabra == 1)
                {
                    contiene = "%";
                }
                if (this.Titulo != string.Empty)
                {
                    valor = "LI_DESC like " + "'" + contiene + "" + Titulo + "%" + "'";

                    if (this.Autor != string.Empty)
                    {
                        valor = valor + " and LI_AUTOR like " + "'" + this.Autor + "%" + "'";
                    }

                }
                else if (this.Autor != string.Empty)
                {
                    valor = "LI_AUTOR like " + "'" + this.Autor + "%" + "'";
                }
                if (Editorial != 0)
                {
                    if (valor == string.Empty)
                    {
                        valor = valor + " LI_EDI_CODIGO = " + this.Editorial;
                    }
                    else
                    { 
                        valor = valor + " and LI_EDI_CODIGO = " + this.Editorial;
                    }
                }
                if (Genero != 0)
                {
                    valor = valor + " and LI_GEN_IDE = " + this.Genero;
                }
                if (valor == string.Empty)
                {
                    valor = valor + " LI_BAJA = 0 limit 100";
                }
                else
                {
                    valor = valor + " and LI_BAJA = 0";
                }
            }
            else
            {
                this.Barra = this.Barra.Replace(" ", "");
                if (this.Barra != string.Empty)
                {
                    valor = " LI_BARRA = " + this.Barra;
                }
                else if (this.Codigo != string.Empty)
                {
                    int number1 = 0;
                    bool canConvert = int.TryParse(this.Codigo, out number1);
                    if (canConvert == true)
                    {
                        valor = " LI_CODIGOVIEJO = " + "" + this.Codigo + "";
                    }
                    else
                    {
                        string letra = Codigo.Substring(0, 1);
                        int ncodigo = Convert.ToInt32(Codigo.Substring(1, Codigo.Length-1));
                        valor = " LI_CODIGO = " + "" + ncodigo + "";
                        valor = valor + " and LI_LETRA = " + "'" + letra + "'";
                    }
                }
                else if (this.Isbn != string.Empty)
                {
                    valor = " LI_ISBN = '" + this.Isbn + "'";
                }
                else if (this.Codigoprovee != string.Empty)
                {
                    valor = " trim(LI_CODIGOPROVEE) = '" + (this.Codigoprovee).Trim() +"'";
                }
                if (valor == string.Empty)
                {
                    valor = valor + " LI_BAJA = 0 limit 100";
                }
                else
                {
                    valor = valor + " and LI_BAJA = 0";
                }
            }
            //CONCAT(ifnull(LI_LETRA,''),LI_CODIGO)
            return con.Mostrar_Datos("select LI_CODIGOVIEJO as LI_CODIGO,LI_DESC,LI_AUTOR,EDI_EDITORIAL,GEN_DESC,ROUND(LI_PRECIO + (LI_PRECIO* 5/100)) as LI_PRECIO, " +
                " LI_BARRA,LI_ISBN,LI_STOCK,LI_IMAGEN,LI_CUERPO,LI_ESTANTE,LI_FECHAPRE,LI_EDI_CODIGO,LI_IDE,LI_GEN_IDE,LI_TIPOPRO,LI_COSTO,LI_PORC_IVA,LI_PORC_GANAN,LI_CODIGOPROVEE,LI_PROPIO,LI_PRECIO AS li_precioori,LI_PEDIDOS,LI_PRECIOARTDI,LI_PRECIOAN,LI_INVENTA,LI_FEC_INVEN " +
                " from lolasdb.libros left join lolasdb.editorial on LI_EDI_CODIGO = EDI_CODIGO " +
                " left join lolasdb.genero on LI_GEN_IDE = GEN_IDE " +
                " where " + valor + " order by LI_DESC asc");
            /*return con.Mostrar_Datos("select * from lolasdb.producto left join lolasdb.editorial on LI_EDI_CODIGO = EDI_CODIGO " +
                " where li_ide > 0 and " + valor + "");*/

        }

        public DataTable Mostrar_productostodos()
        {
            valor = string.Empty;
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            
            //CONCAT(ifnull(LI_LETRA,''),LI_CODIGO)
            return con.Mostrar_Datos("select LI_CODIGOVIEJO as LI_CODIGO,LI_DESC,LI_AUTOR,EDI_EDITORIAL,GEN_DESC,ROUND(LI_PRECIO + (LI_PRECIO* 5/100)) as LI_PRECIO, " +
                " LI_BARRA,LI_ISBN,LI_STOCK,LI_IMAGEN,LI_CUERPO,LI_ESTANTE,LI_FECHAPRE,LI_EDI_CODIGO,LI_IDE,LI_GEN_IDE,LI_TIPOPRO,LI_COSTO,LI_PORC_IVA,LI_PORC_GANAN,LI_CODIGOPROVEE,LI_PROPIO,LI_PRECIO AS li_precioori,LI_PEDIDOS,LI_PRECIOARTDI,LI_PRECIOAN,LI_INVENTA,LI_FEC_INVEN from lolasdb.libros left join lolasdb.editorial on LI_EDI_CODIGO = EDI_CODIGO " +
                " left join lolasdb.genero on LI_GEN_IDE = GEN_IDE " +
                " where li_ide > 0");

        }
        public DataTable Mostrar_productosconsigna()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            if (this.Tipo == 0)
            {
                if (this.Contengapalabra == 1)
                {
                    contiene = "%";
                }
                if (this.Titulo != string.Empty)
                {
                    valor = "LI_DESC like " + "'" + contiene + "" + Titulo + "%" + "'";

                    if (this.Autor != string.Empty)
                    {
                        valor = valor + " and LI_AUTOR like " + "'" + this.Autor + "%" + "'";
                    }

                }
                else if (this.Autor != string.Empty)
                {
                    valor = "LI_AUTOR like " + "'" + this.Autor + "%" + "'";
                }
                if (Editorial != 0)
                {
                    valor = valor + " and LI_EDI_CODIGO = " + this.Editorial;
                }
                if (Genero != 0)
                {
                    valor = valor + " and LI_GEN_IDE = " + this.Genero;
                }
                if (valor == string.Empty)
                {
                    valor = valor + " LI_BAJA = 0 limit 100";
                }
                else
                {
                    valor = valor + " and LI_BAJA = 0";
                }
            }
            else
            {
                this.Barra = this.Barra.Replace(" ", "");
                if (this.Barra != string.Empty)
                {
                    valor = " LI_BARRA = " + this.Barra;
                }
                else if (this.Codigo != string.Empty)
                {
                    int number1 = 0;
                    bool canConvert = int.TryParse(this.Codigo, out number1);
                    if (canConvert == true)
                    {
                        valor = " LI_CODIGOVIEJO = " + "" + this.Codigo + "";
                    }
                    else
                    {
                        string letra = Codigo.Substring(0, 1);
                        int ncodigo = Convert.ToInt32(Codigo.Substring(1, Codigo.Length - 1));
                        valor = " LI_CODIGO = " + "" + ncodigo + "";
                        valor = valor + " and LI_LETRA = " + "'" + letra + "'";
                    }
                }
                else if (this.Isbn != string.Empty)
                {
                    valor = " LI_ISBN = '" + this.Isbn + "'";
                }
                else if (this.Codigoprovee != string.Empty)
                {
                    valor = " LI_CODIGOPROVEE = " + this.Codigoprovee;
                }
                if (valor == string.Empty)
                {
                    valor = valor + " LI_BAJA = 0 limit 100";
                }
                else
                {
                    valor = valor + " and LI_BAJA = 0";
                }
            }
            //CONCAT(ifnull(LI_LETRA,''),LI_CODIGO)
            return con.Mostrar_Datos("select LI_CODIGOVIEJO as LI_CODIGO,LI_DESC,LI_AUTOR,EDI_EDITORIAL,GEN_DESC,LI_PRECIO, " +
                " LI_BARRA,LI_ISBN,LI_STOCK,LI_IMAGEN,LI_CUERPO,LI_ESTANTE,LI_FECHAPRE,LI_EDI_CODIGO,LI_IDE,LI_GEN_IDE,LI_TIPOPRO,LI_COSTO,LI_PORC_IVA,LI_PORC_GANAN,LI_CODIGOPROVEE,LI_PROPIO,LI_PRECIO AS li_precioori,LI_PEDIDOS,LI_PRECIOARTDI,LI_PRECIOAN from lolasdb.libros left join lolasdb.editorial on LI_EDI_CODIGO = EDI_CODIGO " +
                " left join lolasdb.genero on LI_GEN_IDE = GEN_IDE " +
                " where " + valor + "");

        }


        //cambio de precios automatizado
        public void spConCambioPrecio(string nbarra, string precio, int tipop)
        {
            string cadenaconexion;
            Decimal Valor_Retornado = 0, Valor_Retornado2 = 0;
            Decimal Valor_Retornado3 = 0;
            
            Conexion con = new Conexion("lolasdb", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            
            mysql_conexion.Open();
            //MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            //myCommand.Transaction = sqlTran;

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "spConCambioprecio1";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("nbarra", nbarra);
                myCommand.Parameters.AddWithValue("nprecio", Convert.ToDecimal(precio));
                myCommand.Parameters.AddWithValue("tipop", tipop);


                MySqlParameter ValorRetorno = new MySqlParameter("@Rprecio", MySqlDbType.Decimal);
                MySqlParameter ValorRetorno2 = new MySqlParameter("@Rdiferencia", MySqlDbType.Decimal);
                MySqlParameter ValorRetorno3 = new MySqlParameter("@Rtipo", MySqlDbType.Decimal);
                //  MySqlParameter ValorRetorno3 = new MySqlParameter("@Resultado3", MySqlDbType.Int32);
                //MySqlParameter ValorRetorno = new MySqlParameter("RETURN_VALUE", SqlDbType.Decimal);
                ValorRetorno.Direction = ParameterDirection.Output;// Output;
                ValorRetorno2.Direction = ParameterDirection.Output;// Output;
                ValorRetorno3.Direction = ParameterDirection.Output;// Output;

                myCommand.Parameters.Add(ValorRetorno);
                myCommand.Parameters.Add(ValorRetorno2);
                myCommand.Parameters.Add(ValorRetorno3);
                // myCommand.Parameters.Add(ValorRetorno3);
                myCommand.ExecuteNonQuery();
                Valor_Retornado = Convert.ToDecimal(ValorRetorno.Value);
                Valor_Retornado2 = Convert.ToDecimal(ValorRetorno2.Value);
                Valor_Retornado3 = Convert.ToDecimal(ValorRetorno3.Value);
              //  sqlTran.Commit();
                mysql_conexion.Close();
            }
            catch (Exception ex)
            {
                // Handle the exception if the transaction fails to commit.
                Console.WriteLine(ex.Message);

                try
                {
                    // Attempt to roll back the transaction.
                //    sqlTran.Rollback();
                }
                catch (Exception exRollback)
                {
                    Console.WriteLine(exRollback.Message);
                }
            }

            this.Primervalordecimal = Valor_Retornado;
            this.Segundovalordecimal = Valor_Retornado2;
            this.Tercervalorint = Convert.ToInt32(Valor_Retornado3);
        }

        public void spConsultaUsuarios()
        {
            string cadenaconexion;
            string Valor_Retornado1 = string.Empty, Valor_Retornado2 = string.Empty;
            DateTime Valor_Retornado3=DateTime.Now, Valor_Retornado4=DateTime.Now;

            Conexion con = new Conexion("lolasdb", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);

            mysql_conexion.Open();
            //MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            //myCommand.Transaction = sqlTran;

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "spConsultaUsuarios";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("nide", this.productoide);

                MySqlParameter ValorRetorno1 = new MySqlParameter("@Susualta", MySqlDbType.VarChar);
                MySqlParameter ValorRetorno2 = new MySqlParameter("@Susumodi", MySqlDbType.VarChar);
                MySqlParameter ValorRetorno3 = new MySqlParameter("@Fechaalta", MySqlDbType.Date);
                MySqlParameter ValorRetorno4 = new MySqlParameter("@Fechamodi", MySqlDbType.Date);
                //  MySqlParameter ValorRetorno3 = new MySqlParameter("@Resultado3", MySqlDbType.Int32);
                //MySqlParameter ValorRetorno = new MySqlParameter("RETURN_VALUE", SqlDbType.Decimal);
                ValorRetorno1.Direction = ParameterDirection.Output;// Output;
                ValorRetorno2.Direction = ParameterDirection.Output;// Output;
                ValorRetorno3.Direction = ParameterDirection.Output;// Output;
                ValorRetorno4.Direction = ParameterDirection.Output;// Output;

                myCommand.Parameters.Add(ValorRetorno1);
                myCommand.Parameters.Add(ValorRetorno2);
                myCommand.Parameters.Add(ValorRetorno3);
                myCommand.Parameters.Add(ValorRetorno4);
                // myCommand.Parameters.Add(ValorRetorno3);
                myCommand.ExecuteNonQuery();
                Valor_Retornado1 = Convert.ToString(ValorRetorno1.Value);
                Valor_Retornado2 = Convert.ToString(ValorRetorno2.Value);
                Valor_Retornado3 = Convert.ToDateTime(ValorRetorno3.Value);
                
                Valor_Retornado4 = Convert.ToDateTime(ValorRetorno4.Value);
                //  sqlTran.Commit();
                mysql_conexion.Close();
            }
            catch (Exception ex)
            {
                // Handle the exception if the transaction fails to commit.
                Console.WriteLine(ex.Message);

                try
                {
                    // Attempt to roll back the transaction.
                    //    sqlTran.Rollback();
                }
                catch (Exception exRollback)
                {
                    Console.WriteLine(exRollback.Message);
                }
            }

            this.Usuariodiodealta = Valor_Retornado1;
            this.Usuariomodifico = Valor_Retornado2;
            this.Fechadiodealta = Convert.ToString(Valor_Retornado3.ToShortDateString());
            this.Fechausumodi = Convert.ToString(Valor_Retornado4.ToShortDateString());
        }
        public void spConCambioPrecioArticulos(string nprovee, string ncodigo, string precio)
        {
            string cadenaconexion;
            Decimal Valor_Retornado = 0, Valor_Retornado2 = 0;
            Decimal Valor_Retornado3 = 0, Valor_Retornado4 = 0;

            Conexion con = new Conexion("lolasdb", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);

            mysql_conexion.Open();
            //MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            //myCommand.Transaction = sqlTran;

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "spConCambioprecioAr";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("nprovee", nprovee);
                myCommand.Parameters.AddWithValue("ncodigo", ncodigo);
                myCommand.Parameters.AddWithValue("nprecio", Convert.ToDecimal(precio));


                MySqlParameter ValorRetorno = new MySqlParameter("@Rcosto", MySqlDbType.Decimal);
                MySqlParameter ValorRetorno2 = new MySqlParameter("@Riva", MySqlDbType.Decimal);
                MySqlParameter ValorRetorno3 = new MySqlParameter("@Rprecio", MySqlDbType.Decimal);
                MySqlParameter ValorRetorno4 = new MySqlParameter("@Rporcentaje", MySqlDbType.Decimal);
                //  MySqlParameter ValorRetorno3 = new MySqlParameter("@Resultado3", MySqlDbType.Int32);
                //MySqlParameter ValorRetorno = new MySqlParameter("RETURN_VALUE", SqlDbType.Decimal);
                ValorRetorno.Direction = ParameterDirection.Output;// Output;
                ValorRetorno2.Direction = ParameterDirection.Output;// Output;
                ValorRetorno3.Direction = ParameterDirection.Output;// Output;
                ValorRetorno4.Direction = ParameterDirection.Output;// Output;

                myCommand.Parameters.Add(ValorRetorno);
                myCommand.Parameters.Add(ValorRetorno2);
                myCommand.Parameters.Add(ValorRetorno3);
                myCommand.Parameters.Add(ValorRetorno4);
                // myCommand.Parameters.Add(ValorRetorno3);
                myCommand.ExecuteNonQuery();
                Valor_Retornado = Convert.ToDecimal(ValorRetorno.Value);
                Valor_Retornado2 = Convert.ToDecimal(ValorRetorno2.Value);
                Valor_Retornado3 = Convert.ToDecimal(ValorRetorno3.Value);
                Valor_Retornado4 = Convert.ToDecimal(ValorRetorno4.Value);
                //  sqlTran.Commit();
                mysql_conexion.Close();
            }
            catch (Exception ex)
            {
                // Handle the exception if the transaction fails to commit.
                Console.WriteLine(ex.Message);

                try
                {
                    // Attempt to roll back the transaction.
                    //    sqlTran.Rollback();
                }
                catch (Exception exRollback)
                {
                    Console.WriteLine(exRollback.Message);
                }
            }

            this.Cuartovalordecimal = Valor_Retornado;
            this.Quintovalordecimal = Valor_Retornado2;
            this.Sextovalordecimal = Valor_Retornado3;
            this.Septimovalordecimal = Valor_Retornado4;
        }

        public int spInsertarPedido()
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
                myCommand.CommandText = "spAltaPedido";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pcantidad", this.Cantidad);
                myCommand.Parameters.AddWithValue("pproductoide", this.productoide);
                myCommand.Parameters.AddWithValue("palta", this.Alta);
                myCommand.Parameters.AddWithValue("usuide", Globales.gbUsuide);
                myCommand.Parameters.AddWithValue("pedidos", this.pedidos);
                myCommand.Parameters.AddWithValue("codigoviejo", this.Codigo);

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

        public int spInsertarPedidoMaestro()
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
                myCommand.CommandText = "spAltaPedidomaestro";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("usuide", Globales.gbUsuide);
                myCommand.Parameters.AddWithValue("provee", this.Proveeide);

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

        public int spInsertarPedidoDetalle()
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
                myCommand.CommandText = "spAltaPedidodetalle";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pcantidad", this.Cantidad);
                myCommand.Parameters.AddWithValue("pproductoide", this.productoide);
                myCommand.Parameters.AddWithValue("pproveide", this.Proveeide);

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


        public int spInventariado()
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
                myCommand.CommandText = "spInventariado";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("produide", this.productoide);
                myCommand.Parameters.AddWithValue("ncantidad", this.Cantidad);
                myCommand.Parameters.AddWithValue("ninventario", this.Inventario);

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

        public string spInsertarProducto()
        {
            //int Valor_Retornado = 0;
            string cadenaconexion, Valor_Retornado=string.Empty;

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
                myCommand.CommandText = "spAltaproducto";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("titulo", (this.Titulo).ToUpper());
                myCommand.Parameters.AddWithValue("autor", (this.Autor).ToUpper());
                myCommand.Parameters.AddWithValue("neditorial", this.Editorial);
                myCommand.Parameters.AddWithValue("ngenero", this.Genero);
                myCommand.Parameters.AddWithValue("precio", this.Precio);
                myCommand.Parameters.AddWithValue("cantidad", this.Cantidad);
                myCommand.Parameters.AddWithValue("costo", this.Costo);
                myCommand.Parameters.AddWithValue("iva", this.Iva);
                myCommand.Parameters.AddWithValue("ganancia", this.Ganancia);
                myCommand.Parameters.AddWithValue("factura", this.Factura);
                myCommand.Parameters.AddWithValue("isbn", this.Isbn);
                myCommand.Parameters.AddWithValue("barra", this.Barra);
                myCommand.Parameters.AddWithValue("imagen", this.Imagen);
                myCommand.Parameters.AddWithValue("tipo", this.Tipo);
                myCommand.Parameters.AddWithValue("cuerpo", this.Cuerpo);
                myCommand.Parameters.AddWithValue("estante", this.Estante);
                myCommand.Parameters.AddWithValue("usuide", Globales.gbUsuide);
                myCommand.Parameters.AddWithValue("pcodigoprovee", this.Codigoprovee);
                myCommand.Parameters.AddWithValue("dividido", this.Dividido);

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

            return Valor_Retornado;
        }

       

        public int spEnvioproductoprecioautomatico()
        {
            int Valor_Retornado = 0;
            string cadenaconexion;

            Conexion con = new Conexion("lolasdb", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            // MySqlCommand myCommand = new  MySqlCommand();
            mysql_conexion.Open();
           // MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
          //  myCommand.Transaction = sqlTran;

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "spPrecioAutomatico";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("nbarra", this.Barra);
                myCommand.Parameters.AddWithValue("nprecio", this.Precio);
                myCommand.Parameters.AddWithValue("ntitulo", (this.Titulo).ToUpper());
                myCommand.Parameters.AddWithValue("nautor", (this.Autor).ToUpper());
                myCommand.Parameters.AddWithValue("neditorial", this.Editorial);
                myCommand.Parameters.AddWithValue("usuide", Globales.gbUsuide);
                
                MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.Int32);
                //MySqlParameter ValorRetorno = new MySqlParameter("RETURN_VALUE", SqlDbType.Decimal);
                ValorRetorno.Direction = ParameterDirection.Output;// Output;
                myCommand.Parameters.Add(ValorRetorno);
                myCommand.ExecuteNonQuery();
                Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);
             //   sqlTran.Commit();
                mysql_conexion.Dispose();
                mysql_conexion.Close();
            }
            catch (Exception ex)
            {
                // Handle the exception if the transaction fails to commit.
                Console.WriteLine(ex.Message);

                try
                {
                    // Attempt to roll back the transaction.
                  //  sqlTran.Rollback();
                }
                catch (Exception exRollback)
                {
                    Console.WriteLine(exRollback.Message);
                }
            }

            return Valor_Retornado;
        }
        public int spConsultaTotalenDeposito()
        {
            int Valor_Retornado = 0;
            string cadenaconexion;

            Conexion con = new Conexion("lolasdb", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            // MySqlCommand myCommand = new  MySqlCommand();
            mysql_conexion.Open();
            // MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            //  myCommand.Transaction = sqlTran;

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "lolasdb.spConsultatotalendeposito";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("ncodigo", this.Codigo);
               

                MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.Int32);
                //MySqlParameter ValorRetorno = new MySqlParameter("RETURN_VALUE", SqlDbType.Decimal);
                ValorRetorno.Direction = ParameterDirection.Output;// Output;
                myCommand.Parameters.Add(ValorRetorno);
                myCommand.ExecuteNonQuery();
                Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);
                //   sqlTran.Commit();
                mysql_conexion.Dispose();
                mysql_conexion.Close();
            }
            catch (Exception ex)
            {
                // Handle the exception if the transaction fails to commit.
                Console.WriteLine(ex.Message);

                try
                {
                    // Attempt to roll back the transaction.
                    //  sqlTran.Rollback();
                }
                catch (Exception exRollback)
                {
                    Console.WriteLine(exRollback.Message);
                }
            }

            return Valor_Retornado;
        }

        public void spConsultaPrecio(string nbarra)
        {
            string cadenaconexion, Valor_Retornado = string.Empty, Valor_Retornado2 = string.Empty;

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
                myCommand.CommandText = "spConsultaprecio";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("nbarra", nbarra);
                myCommand.Parameters.AddWithValue("ntipo", this.Tipo);

                MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.String);
                MySqlParameter ValorRetorno2 = new MySqlParameter("@Resultado2", MySqlDbType.String);
                //MySqlParameter ValorRetorno = new MySqlParameter("RETURN_VALUE", SqlDbType.Decimal);
                ValorRetorno.Direction = ParameterDirection.Output;// Output;
                ValorRetorno2.Direction = ParameterDirection.Output;// Output;
                myCommand.Parameters.Add(ValorRetorno);
                myCommand.Parameters.Add(ValorRetorno2);
                myCommand.ExecuteNonQuery();
                Valor_Retornado = Convert.ToString(ValorRetorno.Value);
                Valor_Retornado2 = Convert.ToString(ValorRetorno2.Value);
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

            this.Titulo = Valor_Retornado;
            this.Precio = Valor_Retornado2;
        }

        public void spConsultaProductoConsigna(string nbarra)
        {
            string cadenaconexion, Valor_Retornado = string.Empty, Valor_Retornado2 = string.Empty, Valor_Retornado3 = string.Empty, Valor_Retornado4 = string.Empty, Valor_Retornado5 = string.Empty, Valor_Retornado6 = string.Empty, Valor_Retornado7 = string.Empty;

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
                myCommand.CommandText = "spConsultaproducConsigna";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("nbarra", nbarra);
                myCommand.Parameters.AddWithValue("ntipo", this.Tipo);

                MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.String);
                MySqlParameter ValorRetorno2 = new MySqlParameter("@Resultado2", MySqlDbType.String);
                MySqlParameter ValorRetorno3 = new MySqlParameter("@Resultado3", MySqlDbType.String);
                MySqlParameter ValorRetorno4 = new MySqlParameter("@Resultado4", MySqlDbType.String);
                MySqlParameter ValorRetorno5 = new MySqlParameter("@Resultado5", MySqlDbType.String);
                MySqlParameter ValorRetorno6 = new MySqlParameter("@Resultado6", MySqlDbType.String);
                MySqlParameter ValorRetorno7 = new MySqlParameter("@Resultado7", MySqlDbType.String);
                //MySqlParameter ValorRetorno = new MySqlParameter("RETURN_VALUE", SqlDbType.Decimal);
                ValorRetorno.Direction = ParameterDirection.Output;// Output;
                ValorRetorno2.Direction = ParameterDirection.Output;// Output;
                ValorRetorno3.Direction = ParameterDirection.Output;// Output;
                ValorRetorno4.Direction = ParameterDirection.Output;// Output;
                ValorRetorno5.Direction = ParameterDirection.Output;// Output;
                ValorRetorno6.Direction = ParameterDirection.Output;// Output;
                ValorRetorno7.Direction = ParameterDirection.Output;// Output;
                myCommand.Parameters.Add(ValorRetorno);
                myCommand.Parameters.Add(ValorRetorno2);
                myCommand.Parameters.Add(ValorRetorno3);
                myCommand.Parameters.Add(ValorRetorno4);
                myCommand.Parameters.Add(ValorRetorno5);
                myCommand.Parameters.Add(ValorRetorno6);
                myCommand.Parameters.Add(ValorRetorno7);
                myCommand.ExecuteNonQuery();
                Valor_Retornado = Convert.ToString(ValorRetorno.Value);
                Valor_Retornado2 = Convert.ToString(ValorRetorno2.Value);
                Valor_Retornado3 = Convert.ToString(ValorRetorno3.Value);
                Valor_Retornado4 = Convert.ToString(ValorRetorno4.Value);
                Valor_Retornado5 = Convert.ToString(ValorRetorno5.Value);
                Valor_Retornado6 = Convert.ToString(ValorRetorno6.Value);
                Valor_Retornado7 = Convert.ToString(ValorRetorno7.Value);
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

            this.Titulo = Valor_Retornado;
            this.Precio = Valor_Retornado2;
            this.Codigointernoeditorial = Valor_Retornado3;
            this.Autor = Valor_Retornado4;
            this.Stock = Valor_Retornado5;
            this.Isbn = Valor_Retornado6;
            this.Codigo = Valor_Retornado7;
        }


        public void spConsultaCodigoPorBarra(string nbarra)
        {
            string cadenaconexion, Valor_Retornado = string.Empty;

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
                myCommand.CommandText = "spConsultacodigoporbarra";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("nbarra", nbarra);

                MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.String);
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

            this.Codigo = Valor_Retornado;
        }

        public void spConsultaideporcodigo(string vcodigo)
        {
            string cadenaconexion;
            int Valor_Retornado=0;
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
                myCommand.CommandText = "spConsultaideporcodigo";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("codigo", vcodigo);

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

            this.productoide = Valor_Retornado;
        }


        public int spModificarProducto()
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
                myCommand.CommandText = "spModiproducto";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("produide", this.productoide);
                myCommand.Parameters.AddWithValue("titulo", this.Titulo);
                myCommand.Parameters.AddWithValue("autor", this.Autor);
                myCommand.Parameters.AddWithValue("neditorial", this.Editorial);
                myCommand.Parameters.AddWithValue("ngenero", this.Genero);
                myCommand.Parameters.AddWithValue("precio", this.Precio);
                myCommand.Parameters.AddWithValue("ncantidad", this.Cantidad);
                myCommand.Parameters.AddWithValue("costo", this.Costo);
                myCommand.Parameters.AddWithValue("iva", this.Iva);
                myCommand.Parameters.AddWithValue("ganancia", this.Ganancia);
                myCommand.Parameters.AddWithValue("factura", this.Factura);
                myCommand.Parameters.AddWithValue("isbn", this.Isbn);
                myCommand.Parameters.AddWithValue("barra", this.Barra);
                myCommand.Parameters.AddWithValue("imagen", this.Imagen);
                myCommand.Parameters.AddWithValue("tipo", this.Tipo);
                myCommand.Parameters.AddWithValue("cuerpo", this.Cuerpo);
                myCommand.Parameters.AddWithValue("estante", this.Estante);
                myCommand.Parameters.AddWithValue("usuide", Globales.gbUsuide);
                myCommand.Parameters.AddWithValue("pcodigoprovee", this.Codigoprovee);
                myCommand.Parameters.AddWithValue("pcodigo", this.Codigo);
                myCommand.Parameters.AddWithValue("dividido", this.Dividido);
                myCommand.Parameters.AddWithValue("preciosinmodi", this.Preciosinmodificar);

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

        public int spModificarNombreImagen(int liide)
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
                myCommand.CommandText = "spNombreImagen";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("produide", liide);
                myCommand.Parameters.AddWithValue("imagen", this.Titulo);
                

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
        public int spModificarProductoPrecios()
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
                myCommand.CommandText = "spModiproductoPre";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("isbn", this.Isbn);
                myCommand.Parameters.AddWithValue("barra", this.Barra);
                myCommand.Parameters.AddWithValue("titulo", this.Titulo);
                myCommand.Parameters.AddWithValue("autor", this.Autor);
                myCommand.Parameters.AddWithValue("neditorial", this.Editorial);
                myCommand.Parameters.AddWithValue("precio", this.PrecioL);
                myCommand.Parameters.AddWithValue("precioan", this.Precioante);
                myCommand.Parameters.AddWithValue("iftitulo", this.titup);
                myCommand.Parameters.AddWithValue("ifedi", this.edip);

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


        public int spModificarProductoPreciosArt()
        {
            int Valor_Retornado = 0;
            string cadenaconexion;
            Conexion con = new Conexion("lolasdb", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            // MySqlCommand myCommand = new  MySqlCommand();
            mysql_conexion.Open();
           // MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
           // myCommand.Transaction = sqlTran;

            try

            {
                decimal costonuevo = Math.Truncate((this.PrecioL) * 100) / 100;
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "spModiproductoPreAr";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("ncodigo", Convert.ToInt32(this.Codigoprovee));
                myCommand.Parameters.AddWithValue("ncodigopro", this.Codigo);
                myCommand.Parameters.AddWithValue("costo", Convert.ToString(costonuevo));
                myCommand.Parameters.AddWithValue("precioactual", Convert.ToString(this.Precioante));

                MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.Int32);
                ValorRetorno.Direction = ParameterDirection.Output;// Output;
                myCommand.Parameters.Add(ValorRetorno);
                myCommand.ExecuteNonQuery();
                Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);
               // sqlTran.Commit();
                mysql_conexion.Close();
            }
            catch (Exception ex)
            {
                // Handle the exception if the transaction fails to commit.
                Console.WriteLine(ex.Message);

                try
                {
                    // Attempt to roll back the transaction.
                  //sqlTran.Rollback();
                }
                catch (Exception exRollback)
                {
                    Console.WriteLine(exRollback.Message);
                }
            }

            return Valor_Retornado;
        }


        public int spModificarProductoCarga()
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
                myCommand.CommandText = "spModiproductoCarga";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("produide", this.productoide);
                myCommand.Parameters.AddWithValue("precio", this.Precio);
                myCommand.Parameters.AddWithValue("ncantidad", this.Cantidad);
                myCommand.Parameters.AddWithValue("cuerpo", this.Cuerpo);
                myCommand.Parameters.AddWithValue("estante", this.Estante);
                myCommand.Parameters.AddWithValue("usuide", Globales.gbUsuide);
                myCommand.Parameters.AddWithValue("proveeide", this.Proveeide);
                myCommand.Parameters.AddWithValue("nremito", this.Remito);
                myCommand.Parameters.AddWithValue("pcodprovee", this.Codigoprovee);
                myCommand.Parameters.AddWithValue("pcodigo", this.Codigo);
                myCommand.Parameters.AddWithValue("pprecioante", this.Precioante);

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
                myCommand.CommandText = "spEliproducto";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("produide", this.productoide);
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


        public int spModificarPorcentajeEdi()
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
                myCommand.CommandText = "spModiPorcentajeEdi";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("neditorial", this.Editorial);
                myCommand.Parameters.AddWithValue("nporcentaje", this.Ganancia);
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


        public int spModificarPorcentajePrecio()
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
                myCommand.CommandText = "spCambioPrecioMasivo";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pproveedor", this.Editorial);
                myCommand.Parameters.AddWithValue("porcentaje", this.PorcentajeCosto);
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
        public int spConsultastockpropi()
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
                myCommand.CommandText = "spConsultastockpropio";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("producodigop", this.Codigo);

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


        public void spConsultaporconsigna()
        {
            int Valor_Retornado = 0, Valor_Retornado2 = 0;
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
                myCommand.CommandText = "spConsultaporconsigna";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("facturanro", this.NrodeVta);
                myCommand.Parameters.AddWithValue("producodigop", this.Codigo);

                MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.Int32);
                MySqlParameter ValorRetorno2 = new MySqlParameter("@Resultado2", MySqlDbType.Int32);
                ValorRetorno.Direction = ParameterDirection.Output;// Output;
                ValorRetorno2.Direction = ParameterDirection.Output;// Output;
                myCommand.Parameters.Add(ValorRetorno);
                myCommand.Parameters.Add(ValorRetorno2);
                myCommand.ExecuteNonQuery();
                Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);
                Valor_Retornado2 = Convert.ToInt32(ValorRetorno2.Value);
                //sqlTran.Commit();
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

            this.Consignanro = Valor_Retornado;
            this.Consignacantidad = Valor_Retornado2;
        }

        public void spTraeRendidoCantidad()
        {
            int Valor_Retornado = 0, Valor_Retornado2 = 0, Valor_Retornado3 = 0, Valor_Retornado4 = 0;
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
                myCommand.CommandText = "spConsultarendidocantidad";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("consignanro", this.Consignaactual);
                myCommand.Parameters.AddWithValue("producodigop", this.Codigo);

                MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.Int32);
                MySqlParameter ValorRetorno2 = new MySqlParameter("@Resultado2", MySqlDbType.Int32);
                MySqlParameter ValorRetorno3 = new MySqlParameter("@Resultado3", MySqlDbType.Int32);
                MySqlParameter ValorRetorno4 = new MySqlParameter("@Resultado4", MySqlDbType.Int32);
                //  MySqlParameter ValorRetorno3 = new MySqlParameter("@Resultado3", MySqlDbType.Int32);
                //MySqlParameter ValorRetorno = new MySqlParameter("RETURN_VALUE", SqlDbType.Decimal);
                ValorRetorno.Direction = ParameterDirection.Output;// Output;
                ValorRetorno2.Direction = ParameterDirection.Output;// Output;
                ValorRetorno3.Direction = ParameterDirection.Output;// Output;
                ValorRetorno4.Direction = ParameterDirection.Output;// Output;

                myCommand.Parameters.Add(ValorRetorno);
                myCommand.Parameters.Add(ValorRetorno2);
                myCommand.Parameters.Add(ValorRetorno3);
                myCommand.Parameters.Add(ValorRetorno4);
                myCommand.ExecuteNonQuery();
                Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);
                Valor_Retornado2 = Convert.ToInt32(ValorRetorno2.Value);
                Valor_Retornado3 = Convert.ToInt32(ValorRetorno3.Value);
                Valor_Retornado4 = Convert.ToInt32(ValorRetorno4.Value);

                //sqlTran.Commit();
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

            this.Cantidad = Valor_Retornado;
            this.Rendido = Valor_Retornado2;
            this.Original = Valor_Retornado3;
            this.Consignaide = Valor_Retornado4;
        }

        public int spConsultasiesLibro()
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
                myCommand.CommandText = "spConsultasiesLibro";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("producodigop", this.Codigo);

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

        public int spConsultasiesConsignado()
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
                myCommand.CommandText = "spConsultasiesConsignado";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("producodigop", this.Codigo);

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


        public int spConsultastockactual()
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
                myCommand.CommandText = "spConsultastockactual";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("producodigop", this.Codigo);

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


        private void descuentosoloconsigna()
        {
            int numerodeconsig=0,codigoedi=0,rendidos=0;
            MySqlDataReader rdr = null;
            rdr = con.Consultas("select * from lolasdb.consignas where CONS_LI_CODIGOVIEJO = '" + this.Codigo + "' and CONS_CANTIDAD > 0 order by CONS_NROCONSIG");

            int descontar = this.Cantidad;

            if (rdr != null)
            {//inicio if principal

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        
                        stockp = rdr.GetInt32(rdr.GetOrdinal("CONS_CANTIDAD"));
                        consideactual = rdr.GetInt32(rdr.GetOrdinal("CONS_IDE"));
                        numerodeconsig = rdr.GetInt32(rdr.GetOrdinal("CONS_NROCONSIG"));
                        codigoedi = rdr.GetInt32(rdr.GetOrdinal("CONS_EDI_CODIGO"));
                        rendidos = rdr.GetInt32(rdr.GetOrdinal("CONS_RENDIDO"));
                       
                        
                        if (descontar <= stockp)
                        {
                            stockp = stockp - descontar;
                            rendidos = rendidos + descontar;
                            //setear con la cantidad en la consigna
                            string queryconsig = "UPDATE lolasdb.consignas SET CONS_CANTIDAD = " + stockp + " where  CONS_IDE = " + consideactual + "";
                            con.InsertarYactualiza(queryconsig);

                            //se fija el precio actual para realizar el registro de la venta
                            //esto se usa para la rendición.
                            precioactual = this.spPrecioporcodigo(this.Codigo);

                            resultadop = this.spRegistrarlasVentas(numerodeconsig, descontar, codigoedi);
                            
                            //ahora descontar del stock

                            int stockactual = this.spConsultastockactual();
                            int stockasetear = stockactual - descontar;

                            string querypro = "UPDATE lolasdb.libros SET LI_STOCK = " + stockasetear + " where  LI_CODIGOVIEJO = '" + this.Codigo + "'";
                            con.InsertarYactualiza(querypro);

                           // resultadop = this.spRegistrarlasVentas(0, descontar);

                            descontar = 0;
                            break;
                        }
                        else
                        {
                            descontar = descontar - stockp;
                            rendidos = rendidos + stockp;

                            int stockactual = this.spConsultastockactual();
                            int stockasetear = stockactual - stockp;
                            //setear en 0 la cantidad en consigna
                            string querycon = "UPDATE lolasdb.consignas SET CONS_CANTIDAD = 0 where  CONS_IDE = " + consideactual + "";
                            con.InsertarYactualiza(querycon);

                            string querypro = "UPDATE lolasdb.libros SET LI_STOCK = " + stockasetear + " where  LI_CODIGOVIEJO = '" + this.Codigo + "'";
                            con.InsertarYactualiza(querypro);

                            //se fija el precio actual para realizar el registro de la venta
                            //esto se usa para la rendición.
                            precioactual = this.spPrecioporcodigo(this.Codigo);


                            resultadop = this.spRegistrarlasVentas(numerodeconsig, stockp, codigoedi);
                        }
                    }
                    if (descontar > 0)
                    {

                   
                        int stockpropiop1 = this.spConsultastockpropi();
                        int stockpropio1 = stockpropiop1 - descontar;

                        int stockactual = this.spConsultastockactual();
                        int stockasetear = stockactual - descontar;

                        string querypro = "UPDATE lolasdb.libros SET LI_PROPIO = " + stockpropio1 + ", LI_STOCK = " + stockasetear + " where  LI_CODIGOVIEJO = '" + this.Codigo + "'";
                        con.InsertarYactualiza(querypro);

                        resultadop = this.spRegistrarlasVentas(0, descontar,0);
                    }

                }
                else
                {
                    //no hay en consiguar para descontar por lo que descuento de propios.
                    int stockpropiop1 = this.spConsultastockpropi();
                    int stockpropio1 = stockpropiop1 - descontar;
                    int stockactual = this.spConsultastockactual();
                    int stockasetear = stockactual - descontar;

                    string querypro = "UPDATE lolasdb.libros SET LI_PROPIO = " + stockpropio1 + ", LI_STOCK = " + stockasetear + " where  LI_CODIGOVIEJO = '" + this.Codigo + "'";
                    con.InsertarYactualiza(querypro);

                    resultadop = this.spRegistrarlasVentas(0, descontar,0);
                }
            } //fin if principal
            
                
               
           
        }

        public void DescontarStock()
        {
        
            con.AbrirConexio();
            try
            {

                int stockpropiop = this.spConsultastockpropi();
                int eslibro = this.spConsultasiesLibro();
                int stockactual,propioactual=0, stockasetear, stockpropio;

                precioactual = this.spPrecioporcodigo(this.Codigo);

                if (eslibro > 0) //aca pregunto si no es un libro que haga el descuento directamente.
                {
                    stockactual = this.spConsultastockactual();
                    stockasetear = stockactual - this.Cantidad;
                    stockpropio = stockpropiop - this.Cantidad;
                    string query = "UPDATE lolasdb.libros SET LI_PROPIO = " + stockpropio + ", LI_STOCK = " + stockasetear + " where  LI_CODIGOVIEJO = '" + this.Codigo + "'";
                    con.InsertarYactualiza(query);
                    //registrar la venta
                    resultadop = this.spRegistrarlasVentas(0, this.Cantidad,0);
                }
                else
                { 
                        if (stockpropiop > 0)
                        {
                            if (this.Cantidad <= stockpropiop)
                            {
                                stockactual = this.spConsultastockactual();
                              //  propioactual = this.spConsultastockpropi();
                                stockasetear = stockactual - this.Cantidad;
                                propioactual = stockpropiop - this.Cantidad;
                                stockpropio = stockpropiop - this.Cantidad;

                                string query = "UPDATE lolasdb.libros SET LI_PROPIO = " + propioactual + ", LI_STOCK = " + stockasetear + " where  LI_CODIGOVIEJO = '" + this.Codigo + "'";
                                con.InsertarYactualiza(query);
                                //registrar la venta
                                resultadop = this.spRegistrarlasVentas(0, this.Cantidad,0);
                            }
                            else
                            {
                                stockactual = this.spConsultastockactual();
                               // propioactual = this.spConsultastockpropi();

                                //propioactual = stockpropiop - this.Cantidad;
                                stockasetear = stockactual - stockpropiop;
                                this.Cantidad = this.Cantidad - stockpropiop;
                                

                                string querypr = "UPDATE lolasdb.libros SET LI_PROPIO = 0, LI_STOCK = " + stockasetear + " where  LI_CODIGOVIEJO = '" + this.Codigo + "'";
                                con.InsertarYactualiza(querypr);
                                //registrar la venta
                                resultadop = this.spRegistrarlasVentas(0, stockpropiop,0);

                                //acá como queda por descontar busca en consignas
                                this.descuentosoloconsigna();
                            }
                        
                        }
                        else
                        {
                            this.descuentosoloconsigna();
                        }
                }
            }
            finally
            {
                //tener en cuenta el tema de las consignaciones.
                //acá descontar el stock desde this.cantidad
              /*  int stockactualp = this.spConsultastockactual();
                int stockactual = stockactualp - this.Cantidad;
                string query = "UPDATE lolasdb.libros SET LI_STOCK = " + stockactual + " where  LI_CODIGOVIEJO = '" + this.Codigo + "'";
                con.InsertarYactualiza(query);*/

            }
        }

        public void DescontarStockNotadecredito()
        {

            con.AbrirConexio();
            try
            {

                int stockpropiop = this.spConsultastockpropi();
                int eslibro = this.spConsultasiesLibro();
                int stockactual, propioactual = 0, stockasetear, stockpropio1=0;
                if (eslibro == 0) //aca pregunto si no es un libro que haga el descuento directamente.
                {
                    int cantidadadescontar = this.Cantidad;
                    int cantidadaponerstock = this.Cantidad;
                    int cantidadasumar = 0;
                    MySqlDataReader reader = null;
                    reader = con.Consultas("select PREN_CONSIGNA,PREN_CANTIDAD,PREN_IDE,PREN_NRORENDICION from pararendicion where PREN_LI_CODIGOVIEJO = '" + this.Codigo +"' AND PREN_FACTU = "+ this.NrodeVta +" order by PREN_EDICODIGO desc; ");
                    //traer los registros de pararendicion para sumar a el stock
                    while (reader.Read())
                    {
                        if (reader.IsDBNull(0) == true)
                        {
                            reader.Dispose();
                        }
                        else
                        {
                            int consignarendi = Convert.ToInt32(reader["PREN_CONSIGNA"].ToString());
                            int cantirendi = Convert.ToInt32(reader["PREN_CANTIDAD"].ToString());
                            int fuerendido = Convert.ToInt32(reader["PREN_NRORENDICION"].ToString());
                            //tengo que consultar en la consigna 
                            if (consignarendi > 0)
                            {
                                this.Consignaactual = consignarendi;
                                this.spTraeRendidoCantidad();
                                //this.Cantidad;
                                //this.Rendido;
                                //if (this.Original > this.Rendido) todavía no se rindió
                                if (fuerendido == 0)
                                {
                                    cantidadasumar = cantirendi + this.Cantidad;
                                    //hacer update cantidadasumar
                                    string query1 = "UPDATE lolasdb.consignas SET CONS_CANTIDAD = " + cantidadasumar + " where CONS_IDE = " + this.Consignaide + "";
                                    con.InsertarYactualiza(query1);

                                    int idpren = Convert.ToInt32(reader["PREN_IDE"].ToString());
                                    string queryPREN = "UPDATE lolasdb.pararendicion SET PREN_ANULADO = 1 where PREN_IDE = " + idpren + "";
                                    con.InsertarYactualiza(queryPREN);
                                    cantidadadescontar = cantidadadescontar - cantirendi;

                                    stockactual = this.spConsultastockactual();
                                    stockasetear = stockactual + cantirendi;
                                    string querystock = "UPDATE lolasdb.libros SET LI_STOCK = " + stockasetear + " where  LI_CODIGOVIEJO = '" + this.Codigo + "'";
                                    con.InsertarYactualiza(querystock);
                                }
                                else
                                {
                                    stockactual = this.spConsultastockactual();
                                    stockasetear = stockactual + cantirendi;
                                    stockpropio1 = stockpropiop + cantirendi;
                                    stockpropiop = stockpropio1;
                                    string querypro = "UPDATE lolasdb.libros SET LI_PROPIO = " + stockpropio1 + ", LI_STOCK = " + stockasetear + " where  LI_CODIGOVIEJO = '" + this.Codigo + "'";
                                    con.InsertarYactualiza(querypro);
                                    cantidadadescontar = cantidadadescontar - cantirendi;
                                }
                                //this.Consignaide;

                                //this.spConsultaporconsigna();
                                //this.Consignanro;
                                //this.Consignacantidad;
                            }
                            else
                            {
                                stockactual = this.spConsultastockactual();
                                stockasetear = stockactual + cantirendi;
                                stockpropio1 = stockpropiop + cantirendi;
                                stockpropiop = stockpropio1;
                                string querypro = "UPDATE lolasdb.libros SET LI_PROPIO = " + stockpropio1 + ", LI_STOCK = " + stockasetear + " where  LI_CODIGOVIEJO = '" + this.Codigo + "'";
                                con.InsertarYactualiza(querypro);
                                cantidadadescontar = cantidadadescontar - cantirendi;
                            }
                        }
                    }
                    //pregunto si quedó en cantidad entonces eso lo sumo a propios

                    if (cantidadadescontar > 0)
                    {
                        stockactual = this.spConsultastockactual();
                        stockasetear = stockactual + cantidadaponerstock;
                        stockpropio1 = stockpropiop + cantidadadescontar;
                        stockpropiop = stockpropio1;
                        string query2 = "UPDATE lolasdb.libros SET LI_PROPIO = " + stockpropio1 + ", LI_STOCK = " + stockasetear + " where  LI_CODIGOVIEJO = '" + this.Codigo + "'";
                        con.InsertarYactualiza(query2);
                    }
                    else
                    {
                       /* stockactual = this.spConsultastockactual();
                        stockasetear = stockactual + cantidadaponerstock;
                        string query2 = "UPDATE lolasdb.libros SET LI_STOCK = " + stockasetear + " where  LI_CODIGOVIEJO = '" + this.Codigo + "'";
                        con.InsertarYactualiza(query2);*/

                    }
                    

                    reader.Dispose();

                    
                    
                }
                else //si no es libro directamente sumo al stock propio.
                {
                   
                    stockactual = this.spConsultastockactual();
                            
                    stockasetear = stockactual + this.Cantidad;
                    propioactual = stockpropiop + this.Cantidad;
                    stockpropio1 = stockpropiop + this.Cantidad;
                    stockpropiop = stockpropio1;
                    string query = "UPDATE lolasdb.libros SET LI_PROPIO = " + propioactual + ", LI_STOCK = " + stockasetear + " where  LI_CODIGOVIEJO = '" + this.Codigo + "'";
                    con.InsertarYactualiza(query);
                    //registrar la venta

                   

                }
            }
            finally
            {
                //tener en cuenta el tema de las consignaciones.
                //acá descontar el stock desde this.cantidad
                /*  int stockactualp = this.spConsultastockactual();
                  int stockactual = stockactualp - this.Cantidad;
                  string query = "UPDATE lolasdb.libros SET LI_STOCK = " + stockactual + " where  LI_CODIGOVIEJO = '" + this.Codigo + "'";
                  con.InsertarYactualiza(query);*/

            }
        }

        public void colocarventaanulada()
        {
            int anulado = 0;
            if (this.Notaparcial == 1)
            {
                anulado = 1;
            }
            else
            {
                anulado = 2;
            }
            string queryanu = "UPDATE lolasdb.venta SET VEN_ANULADO = " + anulado + " where  VEN_IDE = '" + this.NrodeVta + "'";
            con.InsertarYactualiza(queryanu);
        }

        
        public int spRegistrarlasVentas(int consig,int cantidadadescontar,int edicodigo)
        {
            int Valor_Retornado = 0;
            string cadenaconexion;
            
            

            if (Convert.ToDecimal(this.precioactual)>0)
            {
                this.precioactual = this.precioactual.Replace(".", ",");
                this.precioactual = Convert.ToString((cantidadadescontar) * (Convert.ToDecimal(precioactual)));
                this.precioactual = this.precioactual.Replace(",", ".");
            }
            else
            {
                this.Importevta = this.Importevta.Replace(".", ",");
                this.precioactual = Convert.ToString((cantidadadescontar) * (Convert.ToDecimal(Importevta)));
                this.Importevta = this.Importevta.Replace(",", ".");
            }
            
            
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
                //ACÁ HACE EL REGISTRO DE LAS VENTAS
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "spRegistroVtas";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pcodigoviejo", this.Codigo);
                myCommand.Parameters.AddWithValue("pfactu", this.NrodeVta);
                myCommand.Parameters.AddWithValue("pconsigna", consig);
                myCommand.Parameters.AddWithValue("pcantidad", cantidadadescontar);
                myCommand.Parameters.AddWithValue("pimporte", this.precioactual);
                myCommand.Parameters.AddWithValue("pedicodigo", edicodigo);

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

        public int SetearPrecioNuevo(int codigo, decimal costo,decimal ganancia,decimal iva,int porcentaje)
        {
           

            decimal ncosto = costo + (costo * porcentaje / 100);
            decimal niva = ncosto + (ncosto * iva / 100);
            decimal precioausar = niva + (niva * ganancia / 100);
            precioausar = Math.Truncate(precioausar * 100) / 100;

            string ncosto1 = Convert.ToString(ncosto).Replace(",", ".");
            string nprecioausar1 = Convert.ToString(precioausar).Replace(",", ".");

            string querycosto = "UPDATE lolasdb.libros SET LI_COSTO = " + ncosto1 + ",LI_PRECIO= "+ nprecioausar1 + " where  LI_IDE = " + codigo + "";
            con.InsertarYactualiza(querycosto);
            
            return 0;
        }
        public string spPrecioporcodigo(string pcodigo)
        {
            string Valor_RetornadoPrecio = string.Empty;
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
                myCommand.CommandText = "spConsultaprecioporcodigo";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("ncodigo", pcodigo);

                MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.VarChar);
                ValorRetorno.Direction = ParameterDirection.Output;// Output;
                myCommand.Parameters.Add(ValorRetorno);
                myCommand.ExecuteNonQuery();
                Valor_RetornadoPrecio = Convert.ToString(ValorRetorno.Value);
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

            return Valor_RetornadoPrecio;
        }

        public MySqlDataReader obtenerdatosproductos()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            MySqlDataReader reader = null;

            //si es 0 busca por barra, si es 1 por isbn y sino por código
            if (this.Tipo == 0)
            {
                reader = con.Consultas("select LI_DESC,LI_AUTOR,LI_EDI_CODIGO,EDI_EDITORIAL,LI_GEN_IDE,GEN_DESC,LI_PRECIO, " +
                                        " LI_COSTO, LI_PORC_IVA, LI_PORC_GANAN, LI_CUERPO, LI_ESTANTE,LI_STOCK,LI_IDE,LI_CODIGOVIEJO,LI_CODIGOPROVEE,LI_BAJA,LI_BARRA " +
                                        " from libros " +
                                        " left join lolasdb.editorial on LI_EDI_CODIGO = EDI_CODIGO " +
                                        " left join lolasdb.genero on LI_GEN_IDE = GEN_IDE " +
                                        " where LI_BARRA = '"+ this.Barra +"'   ; ");
            }
            else if (this.Tipo == 1)
            {
                reader = con.Consultas("select LI_DESC,LI_AUTOR,LI_EDI_CODIGO,EDI_EDITORIAL,LI_GEN_IDE,GEN_DESC,LI_PRECIO, " +
                                        " LI_COSTO, LI_PORC_IVA, LI_PORC_GANAN, LI_CUERPO, LI_ESTANTE,LI_STOCK,LI_IDE,LI_CODIGOVIEJO,LI_CODIGOPROVEE,LI_BAJA " +
                                        " from libros " +
                                        " left join lolasdb.editorial on LI_EDI_CODIGO = EDI_CODIGO " +
                                        " left join lolasdb.genero on LI_GEN_IDE = GEN_IDE " +
                                        " where LI_CODIGOVIEJO = '" + this.Codigo + "'   ; ");

            }

            else
            {
                reader = con.Consultas("select LI_DESC,LI_AUTOR,LI_EDI_CODIGO,EDI_EDITORIAL,LI_GEN_IDE,GEN_DESC,LI_PRECIO, " +
                                        " LI_COSTO, LI_PORC_IVA, LI_PORC_GANAN, LI_CUERPO, LI_ESTANTE,LI_STOCK,LI_CODIGOPROVEE,LI_BAJA " +
                                        " from libros " +
                        " left join lolasdb.editorial on LI_EDI_CODIGO = EDI_CODIGO " +
                        " left join lolasdb.genero on LI_GEN_IDE = GEN_IDE " +
                        " where LI_ISBN = '" + this.Isbn + "'   ; ");

            }

            return reader;
        }

        public DataTable Mostrar_sincambiosdeprecio(int editorialausar)
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select LI_CODIGOPROVEE,LI_CODIGOVIEJO,LI_DESC,LI_COSTO,LI_PRECIO from libros where LI_EDI_CODIGO = " + editorialausar + " and LI_PRECIOART = 0");

        }

        public DataTable Mostrar_cambiosdepreciosporfecha(string desde, string hasta, int editorial)
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select LI_CODIGOVIEJO,LI_DESC,LI_AUTOR,EDI_EDITORIAL,LI_PRECIO,LI_PRECIOAN from libros " +
                                     " left join editorial on LI_EDI_CODIGO = EDI_codigo where (LI_FECHAPRE >= '" + desde + "' and LI_FECHAPRE <= '" + hasta + "') " +
                                     " and LI_EDI_CODIGO = " + editorial + " ORDER BY LI_CODIGOVIEJO");
        }

        public int productoide
        {
            get { return this._productoide; }
            set { this._productoide = value; }
        }

        public int pedidos
        {
            get { return this._pedidos; }
            set { this._pedidos = value; }
        }

        public int Alta
        {
            get { return this._alta; }
            set { this._alta = value; }
        }

        public int Contengapalabra
        {
            get { return this._contengapala; }
            set { this._contengapala = value; }
        }
        public int Editorial
        {
            get { return this._editorial; }
            set { this._editorial = value; }
        }
        public int Genero
        {
            get { return this._genero; }
            set { this._genero = value; }
        }
        public int Tipo
        {
            get { return this._tipo; }
            set { this._tipo = value; }
        }

        public int NrodeVta
        {
            get { return this._nrodevta; }
            set { this._nrodevta = value; }
        }
        public int Notaparcial
        {
            get { return this._notaparcial; }
            set { this._notaparcial = value; }
        }

        public string Titulo {
            get { return this._titulo; }
            set { this._titulo = value; }
        }
        public string Barra
        {
            get { return this._barra; }
            set { this._barra = value; }
        }
        public string Isbn
        {
            get { return this._isbn; }
            set { this._isbn = value; }
        }
        public string Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }
        
        public string Autor
        {
            get { return this._autor; }
            set { this._autor = value; }
        }
        public string Precio
        {
            get { return this._precio; }
            set { this._precio = value; }
        }
        public string Preciosinmodificar
        {
            get { return this._preciosinmodificar; }
            set { this._preciosinmodificar = value; }
        }

        public Decimal PrecioL
        {
            get { return this._preciol; }
            set { this._preciol = value; }
        }

        public Decimal Precioante
        {
            get { return this._precioante; }
            set { this._precioante = value; }
        }
        public string Precioanterior
        {
            get { return this._precioanterior; }
            set { this._precioanterior = value; }
        }
        public string Primervalor
        {
            get { return this._primervalor; }
            set { this._primervalor = value; }
        }

        public string Segundovalor
        {
            get { return this._segundovalor; }
            set { this._segundovalor = value; }
        }

        public decimal Primervalordecimal
        {
            get { return this._primervalordecimal; }
            set { this._primervalordecimal = value; }
        }
        public decimal Segundovalordecimal
        {
            get { return this._segundovalordecimal; }
            set { this._segundovalordecimal = value; }
        }
        public int Tercervalorint
        {
            get { return this._tercervalorint; }
            set { this._tercervalorint = value; }
        }
        public decimal Cuartovalordecimal
        {
            get { return this._cuartovalordecimal; }
            set { this._cuartovalordecimal = value; }
        }
        public decimal Quintovalordecimal
        {
            get { return this._quintovalordecimal; }
            set { this._quintovalordecimal = value; }
        }
        public decimal Sextovalordecimal
        {
            get { return this._sextovalordecimal; }
            set { this._sextovalordecimal = value; }
        }
        public decimal Septimovalordecimal
        {
            get { return this._septimovalordecimal; }
            set { this._septimovalordecimal = value; }
        }
        public int Cantidad
        {
            get { return this._cantidad; }
            set { this._cantidad = value; }
        }

        public int PorcentajeCosto
        {
            get { return this._porcentajecosto; }
            set { this._porcentajecosto = value; }
        }


        public int Inventario
        {
            get { return this._inventario; }
            set { this._inventario = value; }
        }
        public int Consignanro
        {
            get { return this._consignanro; }
            set { this._consignanro = value; }
        }
        public int Consignaactual
        {
            get { return this._consignaactual; }
            set { this._consignaactual = value; }
        }
        public int Consignacantidad
        {
            get { return this._consignacantidad; }
            set { this._consignacantidad = value; }
        }
        public int Rendido
        {
            get { return this._rendido; }
            set { this._rendido = value; }
        }
        public int Original
        {
            get { return this._original; }
            set { this._original = value; }
        }
        public int Consignaide
        {
            get { return this._consignaide; }
            set { this._consignaide = value; }
        }
        public int Dividido
        {
            get { return this._dividido; }
            set { this._dividido = value; }
        }
        public int Proveeide
        {
            get { return this._proveeide; }
            set { this._proveeide = value; }
        }
        public string Remito
        {
            get { return this._remito; }
            set { this._remito = value; }
        }
        public string Costo
        {
            get { return this._costo; }
            set { this._costo = value; }
        }
        public string Iva
        {
            get { return this._iva; }
            set { this._iva = value; }
        }
        public string Ganancia
        {
            get { return this._ganancia; }
            set { this._ganancia = value; }
        }
        public string Factura
        {
            get { return this._factura; }
            set { this._factura = value; }
        }
        public string Imagen
        {
            get { return this._imagen; }
            set { this._imagen = value; }
        }
        public string Cuerpo
        {
            get { return this._cuerpo; }
            set { this._cuerpo = value; }
        }
        public string Estante
        {
            get { return this._estante; }
            set { this._estante = value; }
        }
        public string Importevta
        {
            get { return this._importevta; }
            set { this._importevta = value; }
        }
        public string Codigointernoeditorial
        {
            get { return this._codigointernoedi; }
            set { this._codigointernoedi = value; }
        }
        public string Stock
        {
            get { return this._stock; }
            set { this._stock = value; }
        }
        public int titup
        {
            get { return this._titup; }
            set { this._titup = value; }
        }
        public int autorp
        {
            get { return this._autorp; }
            set { this._autorp = value; }
        }
        public int edip
        {
            get { return this._edip; }
            set { this._edip = value; }
        }
        public string Codigoprovee
        {
            get { return this._codigoprovee; }
            set { this._codigoprovee = value; }
        }
        public int Tipopro
        {
            get { return this._tipopro; }
            set { this._tipopro = value; }
        }
        public string Usuariodiodealta
        {
            get { return this._usuariodioal; }
            set { this._usuariodioal = value; }
        }
        public string Fechadiodealta
        {
            get { return this._fechadioal; }
            set { this._fechadioal = value; }
        }
        public string Usuariomodifico
        {
            get { return this._usuariomodi; }
            set { this._usuariomodi = value; }
        }
        public string Fechausumodi
        {
            get { return this._fechausumo; }
            set { this._fechausumo = value; }
        }
        
    }
    
}
