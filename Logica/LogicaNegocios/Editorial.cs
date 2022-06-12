using AccesoaDatos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LogicaNegocios
{
    public class Editorial
    {
        int _numero, _alta, _ide, _porcentaje;
        string _titulo,_calle, _localidad,_provincia,_telefono,_cuit,_cliente;
        public DataTable Tabladedatos_editoriales()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            return con.Mostrar_Datos("select EDI_CODIGO,EDI_EDITORIAL from lolasdb.editorial order by EDI_EDITORIAL");
        }

        public DataTable Tabladedatos_editorialesTodos()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            return con.Mostrar_Datos("select * from lolasdb.editorial order by EDI_EDITORIAL");
        }

        public DataTable Tabladedatos_editorialesAva()
        {
            string valor = string.Empty,contiene;
            if (this.Titulo != string.Empty)
            {
                contiene = "%";
                valor = "EDI_EDITORIAL like " + "'" + contiene + "" + Titulo + "%" + "'";
            }

            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            return con.Mostrar_Datos("select * from lolasdb.editorial where "+ valor +" order by EDI_EDITORIAL");
        }

        public int spAgregarEditorial()
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
                myCommand.CommandText = "spAltaEditorial";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("peditorial", this.Titulo);
                myCommand.Parameters.AddWithValue("pcalle", this.Calle);
                myCommand.Parameters.AddWithValue("pnumero", this.Numero);
                myCommand.Parameters.AddWithValue("plocalidad", this.Localidad);
                myCommand.Parameters.AddWithValue("pprovincia", this.Provincia);
                myCommand.Parameters.AddWithValue("ptelefono", this.Telefono);
                myCommand.Parameters.AddWithValue("pcuit", this.Cuit);
                myCommand.Parameters.AddWithValue("pcliente", this.Cliente);
                myCommand.Parameters.AddWithValue("palta", this.Alta);
                myCommand.Parameters.AddWithValue("pide", this.Ide);
                myCommand.Parameters.AddWithValue("pporcentaje", this.Porcentaje);
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


        public int spModificarEditorial()
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
                myCommand.CommandText = "spAltaEditorial";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("peditorial", this.Titulo);
                myCommand.Parameters.AddWithValue("pcalle", this.Calle);
                myCommand.Parameters.AddWithValue("pnumero", this.Numero);
                myCommand.Parameters.AddWithValue("plocalidad", this.Localidad);
                myCommand.Parameters.AddWithValue("pprovincia", this.Provincia);
                myCommand.Parameters.AddWithValue("ptelefono", this.Telefono);
                myCommand.Parameters.AddWithValue("pcuit", this.Cuit);
                myCommand.Parameters.AddWithValue("pcliente", this.Cliente);
                myCommand.Parameters.AddWithValue("palta", this.Alta);
                myCommand.Parameters.AddWithValue("pide", this.Ide);
                myCommand.Parameters.AddWithValue("pporcentaje", this.Porcentaje);
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

        public int spBajaEditorial()
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
                myCommand.CommandText = "spbajaeditorial";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("ediidep", this.Ide);

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

        public int Ide
        {
            get { return this._ide; }
            set { this._ide = value; }
        }

        public string Titulo
        {
            get { return this._titulo; }
            set { this._titulo = value; }
        }
        public string Calle
        {
            get { return this._calle; }
            set { this._calle = value; }
        }
        public int Numero
        {
            get { return this._numero; }
            set { this._numero = value; }
        }
        public int Porcentaje
        {
            get { return this._porcentaje; }
            set { this._porcentaje = value; }
        }
        public int Alta
        {
            get { return this._alta; }
            set { this._alta = value; }
        }

        public string Localidad
        {
            get { return this._localidad; }
            set { this._localidad = value; }
        }
        public string Provincia
        {
            get { return this._provincia; }
            set { this._provincia = value; }
        }
        public string Telefono
        {
            get { return this._telefono; }
            set { this._telefono = value; }
        }
        public string Cuit
        {
            get { return this._cuit; }
            set { this._cuit = value; }
        }
        public string Cliente
        {
            get { return this._cliente; }
            set { this._cliente = value; }
        }
    }


}


