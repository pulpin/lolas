using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

//using ProyectoDerivaciones.Datos;

namespace AccesoaDatos
{
    public class Conexion
    {
        private string connectionString;
        
        private string server;
        private string database;
        private string uid;
        private string password;


        private static string connectionString1;

        private static MySqlConnection mysql_conexion;
        private static MySqlConnection cn;

        //Constructor
        public Conexion(String basededatos, string ips)
        {
            Initialize(basededatos, ips);
        }

        //Initialize values
        private void Initialize(String basededatos, string ip)
        {
            //pregunto si viene por el S.I.O.S., sino seteo los parametros del servidor
            if (string.IsNullOrWhiteSpace(ip))
            {
                //server = "200.51.42.91";
                //  server = "200.51.42.91"; 
                server = "127.0.0.1";
                //server = "10.1.10.248";
                //server = "192.168.0.105";
               
            }

            else
            {
                server = ip;
            }
            database = basededatos;
            //uid = "hugo";
            uid = "root";
            //password = "lolasdb99";
            password = "123123";
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";port=3307;" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" + "Allow Zero Datetime=true";
            connectionString1 = "SERVER=" + server + ";" + "DATABASE=" + database + ";port=3307;" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" + "Allow Zero Datetime=true";
        }

        public string inicializa()
        {
          //  server = "200.51.42.91";
            database = "lolasdb";
            //uid = "hugo";
            uid = "root";
            //password = "lolasdb99";
            password = "123123";
            return connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";port=3307;" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" + "Allow Zero Datetime=true";
        }

        public void OpenConexion(MySqlConnection mysql_conexion1)
        {
            mysql_conexion1.Open();
        }

        public void CloseConexion(MySqlConnection mysql_conexion1)
        {
            mysql_conexion1.Close();
        }

        public MySqlConnection AbrirConexion(String caracterdeConexion)
        {
            MySqlConnection mysql_conexion1 = new MySqlConnection(caracterdeConexion);
            return mysql_conexion1;
        }

        public static void cerrarcone()
        {
            if (mysql_conexion != null)
            {
                if (mysql_conexion.State == ConnectionState.Open)
                {
                    mysql_conexion.Close();
                }
            }
        }

        public void AbrirConexio()
        {
            //if (mysql_conexion.State != ConnectionState.Open)

            if (mysql_conexion != null)
            {
                if (mysql_conexion.State != ConnectionState.Open)
                {
                    mysql_conexion = new MySqlConnection(connectionString1);
                    mysql_conexion.Open();
                }
                else
                {
                    mysql_conexion.Close();
                    mysql_conexion.Open();
                }

            }
            else
            {
                    mysql_conexion = new MySqlConnection(connectionString1);
                    mysql_conexion.Open();                

            }


      //      mysql_conexion = new MySqlConnection(connectionString);
      //      mysql_conexion.Open();

        }

        public MySqlDataAdapter ProcesaDatos(String caracterdeConexion, MySqlConnection mysql_conexio)
        {
            MySqlDataAdapter mysql_data1 = new MySqlDataAdapter(caracterdeConexion, mysql_conexio);
            return mysql_data1;
        }
        //----------------------------------------------------------------
        public MySqlDataReader Recuperar_registro(String query_selecionar)
        {
            try
            {

                MySqlConnection mysql_conexion = AbrirConexion(connectionString);

                MySqlCommand miCommando = new MySqlCommand(query_selecionar, mysql_conexion);

                MySqlDataReader Reader = miCommando.ExecuteReader();

                mysql_conexion.Open();
                // para probar
                if (Reader.HasRows)
                    while (Reader.Read())
                    {
                        MessageBox.Show(Convert.ToString(Reader.GetInt32(0)));
                    }

                // fin probar
                return Reader;
                //mysql_conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public void InsertarYactualiza(string _query)
        {
            //string query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";
            string query = _query;
            MySqlConnection mysql_conexion = AbrirConexion(connectionString);
            mysql_conexion.Open();
         //   MySqlTransaction trans = mysql_conexion.BeginTransaction();
            MySqlCommand miCommando = new MySqlCommand(query, mysql_conexion);
            miCommando.ExecuteNonQuery();
            mysql_conexion.Close();
          //  trans.Commit();
        }

        public MySqlDataReader Consultas(String query_selecionar)
        {
            try
            {

                // MySqlConnection mysql_conexion = AbrirConexion(connectionString);

               // MySqlConnection mysql_conexion = getConexion();

                
                
                MySqlConnection mysql_conexion = retornoConexion();
             //   mysql_conexion.Open();
                MySqlCommand myCommand = new MySqlCommand(query_selecionar, mysql_conexion);
                return myCommand.ExecuteReader();
            }
            catch
            {
                //sacar este mensaje porque pasa por acá cuando se hace la consulta y no hay registros
                MessageBox.Show("hubo un error en la conexión con la Base de Datos! ");
                return null;
            }
            finally
            {
                //     mysql_conexion.Close();
            }


        }

        public DataTable Mostrar_Datos(String query_selecionar)
        {
            try
            {

                DataTable tabla = new DataTable();
                
                //MySqlConnection mysql_conexion = AbrirConexion(connectionString);
                MySqlConnection mysql_conexion = retornoConexion();

                MySqlDataAdapter mysql_data = ProcesaDatos(query_selecionar, mysql_conexion);

                //Ejecutar Query y LLenar Tabla
                mysql_data.Fill(tabla);

                //Cerrar Conexion
                mysql_conexion.Close();

                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static MySqlConnection getConexion()
        {
            try
            {
                cn = new MySqlConnection(connectionString1);
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                return null;
            }
        }


     /*   public void getConexion()
        {
            try
            {
                server1 = "200.51.42.91";
                database1 = "usuarios";
                uid1 = "conexion";
                password1 = "c69775";
                string connectionString1;
                connectionString1 = "SERVER=" + server1 + ";" + "DATABASE=" + database1 + ";" + "UID=" + uid1 + ";" + "PASSWORD=" + password1 + ";" + "Allow Zero Datetime=true";
                MySqlConnection cn = new MySqlConnection(connectionString1);

                cn.Open();
                //return cn;
            }
            catch (Exception ex)
            {
              //  return null;
            }
        }*/

        public static MySqlConnection retornoConexion() 
        {
            return mysql_conexion;
        }


    }
}
