using AccesoaDatos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LogicaNegocios
{
    public class Genero
    {
        int _eslibro, _alta, _ide;
        string _titulo = string.Empty;
        public DataTable Tabladedatos_genero()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            return con.Mostrar_Datos("select GEN_IDE,GEN_DESC from lolasdb.genero order by GEN_DESC");
        }

        public DataTable Tabladedatos_generos()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            int esli = 0;
            con.AbrirConexio();
            if (EsLibro == 0)
            {
                esli = 0;
            }
            else
            {
                esli = 1;
            }
            return con.Mostrar_Datos("select GEN_IDE,GEN_DESC,GEN_TIPO from lolasdb.genero order by GEN_DESC");
        }
        public DataTable Tabladedatos_generos2()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            int esli = 0;
            con.AbrirConexio();
            if (EsLibro == 1)
            {
                esli = 0;
            }
            else
            {
                esli = 1;
            }
            return con.Mostrar_Datos("select GEN_IDE,GEN_DESC from lolasdb.genero where GEN_TIPO = " + esli + " order by GEN_DESC");
        }
        public DataTable Tabladedatos_generosbuscar()
        {
            string valor = string.Empty, contiene;
            if (this.Titulo != string.Empty)
            {
                contiene = "%";
                valor = "GEN_DESC like " + "'" + contiene + "" + Titulo + "%" + "'";
            }
            if (this.EsLibro == 1)
            {
                valor = valor + " and GEN_TIPO = 0";
            }
            else
            {
                valor = valor + " and GEN_TIPO = 1";
            }

            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            return con.Mostrar_Datos("select * from lolasdb.genero where " + valor + " order by GEN_DESC");
        }

        public int spAgregarGenero()
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
                myCommand.CommandText = "spAltaGenero";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pgenero", this.Titulo);
                myCommand.Parameters.AddWithValue("palta", 1);
                myCommand.Parameters.AddWithValue("pide", 0);
                myCommand.Parameters.AddWithValue("pusuide", Globales.gbUsuide);
                myCommand.Parameters.AddWithValue("peslibro", this.EsLibro);

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
        public int spModificarGenero()
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
                myCommand.CommandText = "spAltaGenero";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pgenero", this.Titulo);
                myCommand.Parameters.AddWithValue("palta", this.Alta);
                myCommand.Parameters.AddWithValue("pide", this.Ide);
                myCommand.Parameters.AddWithValue("pusuide", Globales.gbUsuide);
                myCommand.Parameters.AddWithValue("peslibro", this.EsLibro);
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
        public int EsLibro
        {
            get { return this._eslibro; }
            set { this._eslibro = value; }
        }
        public string Titulo
        {
            get { return this._titulo; }
            set { this._titulo = value; }
        }
        public int Alta
        {
            get { return this._alta; }
            set { this._alta = value; }
        }
        public int Ide
        {
            get { return this._ide; }
            set { this._ide = value; }
        }
    }
}
