using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AccesoaDatos;
using MySql.Data.MySqlClient;

namespace LogicaNegocios
{
   public class Usuarios
    {
        string _clavepedido, _nombre, _nombrecompleto, _contra, _contravta, _colorfondo;
        int _usuide, _menuide, _progide, _acceder, _modificar, _tipo, _puntodeventa;
        public Usuarios() { 

        }

        public DataTable Mostrar_Datos_Usuarios()
        {
            Conexion con = new Conexion("usuarios",Globales.ip);
            con.AbrirConexio();
            return con.Mostrar_Datos("SELECT USU_NOMBRE,USU_COLOR FROM usuarios.usuarios where USU_BAJA = 0");
        }

        public DataTable Mostrar_Datos_Usuariosid()
        {
            Conexion con = new Conexion("usuarios", Globales.ip);
            con.AbrirConexio();
            return con.Mostrar_Datos("SELECT USU_NOMBRE,USU_IDE FROM usuarios.usuarios where USU_BAJA = 0");
        }

        public DataTable Mostrar_Usuarios()
        {
            Conexion con = new Conexion("usuarios", Globales.ip);
            con.AbrirConexio();
            return con.Mostrar_Datos("SELECT * FROM usuarios.usuarios where USU_BAJA = 0");
        }

        public MySqlDataReader Mostrar_Usuarios(int usuide)
        {
            //aca se habre la conexion y se hace por única vez
            Conexion con = new Conexion("usuarios", Globales.ip);
            con.AbrirConexio();
            try
            {
                MySqlDataReader rdr = null;
                rdr = con.Consultas("SELECT menu_nombre,per_acceder,per_modificar,menu_ide,menu_prog_ide,menu_descripcion " +
                                    " FROM usuarios.menu " +
                                    " LEFT JOIN usuarios.permisos ON(menu_ide = per_menu_ide) AND(menu_prog_ide = per_prog_ide) AND(per_usu_ide = "+ usuide + ")" +
                                    " WHERE menu_prog_ide = 2 " +
                                    " ORDER BY menu_codigo");

                return rdr;
            }
            finally
            {
                //mysql_conexion.Close();
            }
        }

        public DataTable Mostrar_Datos_Des()
        {
            Conexion con = new Conexion("derivacion", Globales.ip);
            con.AbrirConexio();
            return con.Mostrar_Datos("SELECT DES_DESC,DES_IDE from derivacion.destinos WHERE DES_TURNOS = 1 ORDER BY DES_DESC DESC");
        }

        public DataTable Mostrar_localidadesT()
        {
            Conexion con = new Conexion("derivacion", Globales.ip);
            con.AbrirConexio();
            return con.Mostrar_Datos("SELECT DES_DESC,DES_CP from derivacion.destinos ORDER BY DES_DESC DESC");
        }
        public DataTable Mostrar_Datos_Des(int preside)
        {
            Conexion con = new Conexion("derivacion", Globales.ip);
            con.AbrirConexio();
            return con.Mostrar_Datos("SELECT DES_DESC,DES_IDE from turnos.viajes as vi left join " +
                                    " derivacion.destinos as des ON vi.VI_LOC_IDE = des.DES_IDE WHERE DES_TURNOS = 1 AND VI_PRES_IDE = " + preside + " ORDER BY DES_DESC DESC");
        }
        public DataTable Mostrar_Localidades()
        {
            Conexion con = new Conexion("derivacion", Globales.ip);
            con.AbrirConexio();
            return con.Mostrar_Datos("SELECT DES_DESC,DES_IDE from derivacion.destinos WHERE DES_TURNOS = 1 ORDER BY DES_DESC DESC");
        }
        public void cerrarconexion()
        {
            Conexion.cerrarcone();
        }



        public int spIngresoclavepedido()
        {
            int Valor_Retornado = 0;
            string cadenaconexion;


            Conexion con = new Conexion("usuarios", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            mysql_conexion.Open();
            MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            myCommand.Transaction = sqlTran;

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "usuarios.spClavepedido";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("clavep", this.Clavepedido);

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

        public string spTraerNombreusuario()
        {
            string Valor_Retornado = string.Empty;
            string cadenaconexion;


            Conexion con = new Conexion("usuarios", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            mysql_conexion.Open();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();


            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "usuarios.spTraeNombreusu";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("Usuidep", this.Usuide);

                MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.VarChar);
                ValorRetorno.Direction = ParameterDirection.Output;// Output;
                myCommand.Parameters.Add(ValorRetorno);
                myCommand.ExecuteNonQuery();
                Valor_Retornado = Convert.ToString(ValorRetorno.Value);
                mysql_conexion.Close();
            }
            catch (Exception ex)
            {
                // Handle the exception if the transaction fails to commit.
                Console.WriteLine(ex.Message);

                try
                {
                    // Attempt to roll back the transaction.
                 
                }
                catch (Exception exRollback)
                {
                    Console.WriteLine(exRollback);
                }
            }

            return Valor_Retornado;
        }

        public int spBorrarPermisos()
        {
            int Valor_Retornado = 0;
            string cadenaconexion;


            Conexion con = new Conexion("usuarios", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            mysql_conexion.Open();
            MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            myCommand.Transaction = sqlTran;

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "usuarios.spborrarpermisos";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("usuidep", this.Usuide);

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


        public int spBajaUsuario()
        {
            int Valor_Retornado = 0;
            string cadenaconexion;


            Conexion con = new Conexion("usuarios", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            mysql_conexion.Open();
            MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            myCommand.Transaction = sqlTran;

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "usuarios.spbajausuarios";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("usuidep", this.Usuide);

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

        public int spAgregarPermisos()
        {
            int Valor_Retornado = 0;
            string cadenaconexion;


            Conexion con = new Conexion("usuarios", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            mysql_conexion.Open();
            MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            myCommand.Transaction = sqlTran;

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "usuarios.spAgregaPermisos";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("usuidep", this.Usuide);
                myCommand.Parameters.AddWithValue("menuidep", this.Menuide);
                myCommand.Parameters.AddWithValue("progidep", this.Progide);
                myCommand.Parameters.AddWithValue("accederp", this.Acceder);
                myCommand.Parameters.AddWithValue("modificarp", this.Modificar);
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

        public int spAgregarUsuario()
        {
            int Valor_Retornado = 0;
            string cadenaconexion;


            Conexion con = new Conexion("usuarios", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            mysql_conexion.Open();
            MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            myCommand.Transaction = sqlTran;

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "usuarios.spAgregaUsuario";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("nombrep", this.Nombre);
                myCommand.Parameters.AddWithValue("nombrecp", this.NombreCompleto);
                myCommand.Parameters.AddWithValue("contrap", this.Contrase);
                myCommand.Parameters.AddWithValue("contravtap", this.Contrasevta);
                myCommand.Parameters.AddWithValue("tipop", this.Tipo);
                myCommand.Parameters.AddWithValue("colorelep", this.Colorfondo);
                myCommand.Parameters.AddWithValue("puntodevta", this.PuntodeVenta);
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

        public int spVerificarColorElegido()
        {
            int Valor_Retornado = 0;
            string cadenaconexion;


            Conexion con = new Conexion("usuarios", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            mysql_conexion.Open();
            MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            myCommand.Transaction = sqlTran;

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "usuarios.spColorElegido";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("coloreleg", this.Colorfondo);
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

        public int spVerificarColorElegidoLogueo()
        {
            int Valor_Retornado = 0;
            string cadenaconexion;


            Conexion con = new Conexion("usuarios", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            mysql_conexion.Open();
            MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            myCommand.Transaction = sqlTran;

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "usuarios.spColorElegidologueo";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("coloreleg", this.Colorfondo);
                myCommand.Parameters.AddWithValue("usuidep", this.Usuide);
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

        public int spModificaUsuario()
        {
            int Valor_Retornado = 0;
            string cadenaconexion;


            Conexion con = new Conexion("usuarios", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            mysql_conexion.Open();
            MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            myCommand.Transaction = sqlTran;

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "usuarios.spModificaUsuario";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("nombrep", this.Nombre);
                myCommand.Parameters.AddWithValue("nombrecp", this.NombreCompleto);
                myCommand.Parameters.AddWithValue("contrap", this.Contrase);
                myCommand.Parameters.AddWithValue("contravtap", this.Contrasevta);
                myCommand.Parameters.AddWithValue("tipop", this.Tipo);
                myCommand.Parameters.AddWithValue("usuidep", this.Usuide);
                myCommand.Parameters.AddWithValue("puntodevta", this.PuntodeVenta);
                myCommand.Parameters.AddWithValue("colorelep", this.Colorfondo);
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

        public string Clavepedido
        {
            get { return this._clavepedido; }
            set { this._clavepedido = value; }
        }

        public int Usuide
        {
            get { return this._usuide; }
            set { this._usuide = value; }
        }

        public int Menuide
        {
            get { return this._menuide; }
            set { this._menuide = value; }
        }

        public int Progide
        {
            get { return this._progide; }
            set { this._progide = value; }
        }
        public int Acceder
        {
            get { return this._acceder; }
            set { this._acceder = value; }
        }
        public int Modificar
        {
            get { return this._modificar; }
            set { this._modificar = value; }
        }



        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public string NombreCompleto
        {
            get { return this._nombrecompleto; }
            set { this._nombrecompleto = value; }
        }

        public string Contrase
        {
            get { return this._contra; }
            set { this._contra = value; }
        }

        public string Contrasevta
        {
            get { return this._contravta; }
            set { this._contravta = value; }
        }
        public int Tipo
        {
            get { return this._tipo; }
            set { this._tipo = value; }
        }
        public int PuntodeVenta
        {
            get { return this._puntodeventa; }
            set { this._puntodeventa = value; }
        }
        public string Colorfondo
        {
            get { return this._colorfondo; }
            set { this._colorfondo = value; }
        }
        
    }
}
