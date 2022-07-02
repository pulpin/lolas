using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccesoaDatos;
using MySql.Data.MySqlClient;
using System.Data;

namespace LogicaNegocios
{
    public class SeteoUsuario
    {
        string _colorfondo, _colorelegido;
        int _usuide;
        public bool tryLogin(string username, string password)
        {
            try
            {
                
                Conexion con = new Conexion("lolasdb",Globales.ip);
                
                
                con.AbrirConexio();
                

                MySqlDataReader reader = null;
                reader = con.Consultas("SELECT * FROM usuarios.usuarios WHERE USU_NOMBRE = '" + username + "' AND USU_CONTRASE = '" + password + "';");
                //reader = con.Consultas("SELECT * FROM usuarios.usuarios as us WHERE USU_USUARIO = '" + username + "' AND USU_CONTRASENIA = '" + password + "';");

                if (reader.Read() != false)
                {
                    if (reader.IsDBNull(0) == true)
                    {
                        reader.Dispose();
                        return false;
                    }
                    else
                    {
                        LogicaNegocios.Globales.gbUsuario = reader["USU_NOMBRE"].ToString();
                        LogicaNegocios.Globales.gbLocalidad = "Río Gallegos";
                        LogicaNegocios.Globales.gbLocalide = 1;
                        LogicaNegocios.Globales.gbUsuide = Convert.ToInt32(reader["USU_IDE"].ToString());
                        LogicaNegocios.Globales.gbtipousuario = "Administrativo";
                        LogicaNegocios.Globales.gbpuntodeventapredetermindado = Convert.ToInt32(reader["USU_PTOVENTA"].ToString());
                        
                        // Conexion con1 = new Conexion("usuarios",Globales.ip);
                        con.AbrirConexio();
                        MySqlDataReader reader1 = null;
                        /*reader1 = con.Consultas("SELECT menu_nombre,per_acceder,per_modificar " +
                            " From usuarios.permisos " +
                            " LEFT JOIN usuarios.menu ON menu_ide=per_menu_ide and menu_prog_ide=per_prog_ide " +
                            " WHERE per_usu_ide= " + LogicaNegocios.Globales.gbUsuide + " AND per_prog_ide= 16;");
                            */
                        /*  reader1 = con.Consultas("SELECT MOD_NOMBRE,PER_TIPO FROM usuarios.permisos LEFT JOIN " +
                                                  " usuarios.modulo on PER_MOD_IDE = MOD_IDE where " +
                                                  " PER_USU_IDE = "+ Globales.gbUsuide +" and MOD_PROG_IDE = 2 order by PER_MOD_IDE; ");

                          */

                        LogicaNegocios.Globales.accesoaproductos = 0;
                        LogicaNegocios.Globales.eliminarproductos = 0;
                        LogicaNegocios.Globales.registrodeventas = 0;
                        LogicaNegocios.Globales.accesoareservas = 0;
                        LogicaNegocios.Globales.accesoaeditoriales = 0;
                        LogicaNegocios.Globales.accesoaclientes = 0;
                        LogicaNegocios.Globales.accesoacuentacorriente = 0;
                        LogicaNegocios.Globales.accesoaconsignas = 0;
                        LogicaNegocios.Globales.accesoarendiciones = 0;
                        LogicaNegocios.Globales.accesoainteres = 0;
                        LogicaNegocios.Globales.accesoacargarapida = 0;
                        LogicaNegocios.Globales.accesoapedidos = 0;
                        LogicaNegocios.Globales.accesoausuarios = 0;
                        LogicaNegocios.Globales.imprimirfactura = 0;
                        LogicaNegocios.Globales.accesoaproveedores = 0;
                        LogicaNegocios.Globales.accessoporcentajesedi = 0;
                        LogicaNegocios.Globales.accesocontador = 0;
                        LogicaNegocios.Globales.accesomodificartitulo = 0;
                        LogicaNegocios.Globales.accesomodificaradopciones = 0;
                        LogicaNegocios.Globales.accesopagos = 0;
                        LogicaNegocios.Globales.accesocredito = 0;


                        reader1 = con.Consultas(" SELECT menu_nombre,per_acceder,per_modificar " +
                                                                " FROM usuarios.menu " +
                                                                " LEFT JOIN usuarios.permisos ON(menu_ide = per_menu_ide) AND(menu_prog_ide = per_prog_ide) AND(per_usu_ide = " + Globales.gbUsuide + ") " +
                                                                " WHERE menu_prog_ide = 2 " +
                                                                " ORDER BY menu_codigo");

                        if (reader1.HasRows == false)
                        {
                            LogicaNegocios.Globales.gbtipousuario = "Administrativo";
                        }

                        while (reader1.Read())
                        {
                            //menu modificar
                            if ((reader1["menu_nombre"].ToString() == "Productos"))
                            {
                                int acceder = reader1.GetInt32(reader1.GetOrdinal("per_acceder"));
                                int modificar = reader1.GetInt32(reader1.GetOrdinal("per_modificar"));
                                if (acceder == 1)
                                {
                                    LogicaNegocios.Globales.accesoaproductos = 1;
                                }
                                if (modificar == 1)
                                {
                                    LogicaNegocios.Globales.accesoaproductos = 2;
                                }
                            }

                            if ((reader1["menu_nombre"].ToString() == "Eliminar productos"))
                            {
                                // if (!reader1.IsDBNull(reader1.GetOrdinal("per_acceder")))
                                //myReader2.GetInt32(myReader2.GetOrdinal("prog_version")
                                int acceder = reader1.GetInt32(reader1.GetOrdinal("per_acceder"));
                                int modificar = reader1.GetInt32(reader1.GetOrdinal("per_modificar"));
                              /*  if (acceder == 1)
                                {
                                    LogicaNegocios.Globales.eliminarproductos = 1;
                                }*/
                                if (modificar == 1)
                                {
                                    LogicaNegocios.Globales.eliminarproductos = 2;
                                }
                            }

                            if ((reader1["menu_nombre"].ToString() == "Registro de ventas"))
                            {
                                int acceder = reader1.GetInt32(reader1.GetOrdinal("per_acceder"));
                                int modificar = reader1.GetInt32(reader1.GetOrdinal("per_modificar"));
                                if (acceder == 1)
                                {
                                    LogicaNegocios.Globales.registrodeventas = 1;
                                }
                               
                            }

                            if ((reader1["menu_nombre"].ToString() == "Reservas"))
                            {
                                int acceder = reader1.GetInt32(reader1.GetOrdinal("per_acceder"));
                                int modificar = reader1.GetInt32(reader1.GetOrdinal("per_modificar"));
                                if (acceder == 1)
                                {
                                    LogicaNegocios.Globales.accesoareservas = 1;
                                }
                                if (modificar == 1)
                                {
                                    LogicaNegocios.Globales.accesoareservas = 2;
                                }
                            }
                            if ((reader1["menu_nombre"].ToString() == "Editoriales"))
                            {
                                int acceder = reader1.GetInt32(reader1.GetOrdinal("per_acceder"));
                                int modificar = reader1.GetInt32(reader1.GetOrdinal("per_modificar"));
                                if (acceder == 1)
                                {
                                    LogicaNegocios.Globales.accesoaeditoriales = 1;
                                }
                                if (modificar == 1)
                                {
                                    LogicaNegocios.Globales.accesoaeditoriales = 2;
                                }
                            }

                            if ((reader1["menu_nombre"].ToString() == "Clientes"))
                            {
                                int acceder = reader1.GetInt32(reader1.GetOrdinal("per_acceder"));
                                int modificar = reader1.GetInt32(reader1.GetOrdinal("per_modificar"));
                                if (acceder == 1)
                                {
                                    LogicaNegocios.Globales.accesoaclientes = 1;
                                }
                                if (modificar == 1)
                                {
                                    LogicaNegocios.Globales.accesoaclientes = 2;
                                }
                            }
                            if ((reader1["menu_nombre"].ToString() == "Cuenta Corriente"))
                            {
                                int acceder = reader1.GetInt32(reader1.GetOrdinal("per_acceder"));
                                int modificar = reader1.GetInt32(reader1.GetOrdinal("per_modificar"));
                                if (acceder == 1)
                                {
                                    LogicaNegocios.Globales.accesoacuentacorriente = 1;
                                }
                                if (modificar == 1)
                                {
                                    LogicaNegocios.Globales.accesoacuentacorriente = 2;
                                }
                            }

                            /*if ((reader1["menu_nombre"].ToString() == "Consignas"))
                            {
                                int acceder = reader1.GetInt32(reader1.GetOrdinal("per_acceder"));
                                int modificar = reader1.GetInt32(reader1.GetOrdinal("per_modificar"));
                                if (acceder == 1)
                                {
                                    LogicaNegocios.Globales.accesoaconsignas = 1;
                                }
                                if (modificar == 1)
                                {
                                    LogicaNegocios.Globales.accesoaconsignas = 2;
                                }
                            }

                            if ((reader1["menu_nombre"].ToString() == "Rendiciones"))
                            {
                                int acceder = reader1.GetInt32(reader1.GetOrdinal("per_acceder"));
                                int modificar = reader1.GetInt32(reader1.GetOrdinal("per_modificar"));
                                if (acceder == 1)
                                {
                                    LogicaNegocios.Globales.accesoarendiciones = 1;
                                }
                                if (modificar == 1)
                                {
                                    LogicaNegocios.Globales.accesoarendiciones = 2;
                                }
                            }*/

                            if ((reader1["menu_nombre"].ToString() == "Interes"))
                            {
                                int acceder = reader1.GetInt32(reader1.GetOrdinal("per_acceder"));
                                int modificar = reader1.GetInt32(reader1.GetOrdinal("per_modificar"));
                                if (acceder == 1)
                                {
                                    LogicaNegocios.Globales.accesoainteres = 1;
                                }
                                if (modificar == 1)
                                {
                                    LogicaNegocios.Globales.accesoainteres = 2;
                                }
                            }

                            if ((reader1["menu_nombre"].ToString() == "Carga rapida"))
                            {
                                int acceder = reader1.GetInt32(reader1.GetOrdinal("per_acceder"));
                                int modificar = reader1.GetInt32(reader1.GetOrdinal("per_modificar"));
                                if (acceder == 1)
                                {
                                    LogicaNegocios.Globales.accesoacargarapida = 1;
                                }
                                if (modificar == 1)
                                {
                                    LogicaNegocios.Globales.accesoacargarapida = 2;
                                }
                            }
                            if ((reader1["menu_nombre"].ToString() == "Pedidos"))
                            {
                                int acceder = reader1.GetInt32(reader1.GetOrdinal("per_acceder"));
                                int modificar = reader1.GetInt32(reader1.GetOrdinal("per_modificar"));
                                if (acceder == 1)
                                {
                                    LogicaNegocios.Globales.accesoapedidos = 1;
                                }
                                if (modificar == 1)
                                {
                                    LogicaNegocios.Globales.accesoapedidos = 2;
                                }
                            }

                            if ((reader1["menu_nombre"].ToString() == "Usuarios"))
                            {
                                int acceder = reader1.GetInt32(reader1.GetOrdinal("per_acceder"));
                                int modificar = reader1.GetInt32(reader1.GetOrdinal("per_modificar"));
                                if (acceder == 1)
                                {
                                    LogicaNegocios.Globales.accesoausuarios = 1;
                                }
                                if (modificar == 1)
                                {
                                    LogicaNegocios.Globales.accesoausuarios = 2;
                                }
                            }
                            

                            if ((reader1["menu_nombre"].ToString() == "Imprimir factura"))
                            {
                                int acceder = reader1.GetInt32(reader1.GetOrdinal("per_acceder"));
                                int modificar = reader1.GetInt32(reader1.GetOrdinal("per_modificar"));
                                if (acceder == 1)
                                {
                                    LogicaNegocios.Globales.imprimirfactura = 1;
                                }
                                if (modificar == 1)
                                {
                                    LogicaNegocios.Globales.imprimirfactura = 2;
                                }
                            }
                            if ((reader1["menu_nombre"].ToString() == "Proveedores"))
                            {
                                int acceder = reader1.GetInt32(reader1.GetOrdinal("per_acceder"));
                                int modificar = reader1.GetInt32(reader1.GetOrdinal("per_modificar"));
                                if (acceder == 1)
                                {
                                    LogicaNegocios.Globales.accesoaproveedores = 1;
                                }
                                if (modificar == 1)
                                {
                                    LogicaNegocios.Globales.accesoaproveedores = 2;
                                }
                            }
                            

                            if ((reader1["menu_nombre"].ToString() == "Cambiar cuerpo estante"))
                            {
                                int acceder = reader1.GetInt32(reader1.GetOrdinal("per_acceder"));
                                if (acceder == 1)
                                {
                                    LogicaNegocios.Globales.accessocuerpoestante = 1;
                                }

                            }
                            if ((reader1["menu_nombre"].ToString() == "Credito personal"))
                            {
                                int acceder = reader1.GetInt32(reader1.GetOrdinal("per_acceder"));
                                int modificar = reader1.GetInt32(reader1.GetOrdinal("per_modificar"));
                                if (acceder == 1)
                                {
                                    LogicaNegocios.Globales.accessoventacredito = 1;
                                }
                                if (modificar == 1)
                                {
                                    LogicaNegocios.Globales.accessoventacredito = 2;
                                }
                            }

                            if ((reader1["menu_nombre"].ToString() == "Porcentaje de editoriales"))
                            {
                                int acceder = reader1.GetInt32(reader1.GetOrdinal("per_acceder"));
                                int modificar = reader1.GetInt32(reader1.GetOrdinal("per_modificar"));
                                if (acceder == 1)
                                {
                                    LogicaNegocios.Globales.accessoporcentajesedi = 1;
                                }
                                if (modificar == 1)
                                {
                                    LogicaNegocios.Globales.accessoporcentajesedi = 2;
                                }
                            }
                            if ((reader1["menu_nombre"].ToString() == "Contador"))
                            {
                                int acceder = reader1.GetInt32(reader1.GetOrdinal("per_acceder"));
                                int modificar = reader1.GetInt32(reader1.GetOrdinal("per_modificar"));
                                if (acceder == 1)
                                {
                                    LogicaNegocios.Globales.accesocontador = 1;
                                }
                                if (modificar == 1)
                                {
                                    LogicaNegocios.Globales.accesocontador = 2;
                                }
                            }
                            if ((reader1["menu_nombre"].ToString() == "Modificar titulo"))
                            {
                                int acceder = reader1.GetInt32(reader1.GetOrdinal("per_acceder"));
                                int modificar = reader1.GetInt32(reader1.GetOrdinal("per_modificar"));
                                if (acceder == 1)
                                {
                                    LogicaNegocios.Globales.accesomodificartitulo = 1;
                                }
                                if (modificar == 1)
                                {
                                    LogicaNegocios.Globales.accesomodificartitulo = 2;
                                }
                            }

                           /* if ((reader1["menu_nombre"].ToString() == "Modificar adopciones"))
                            {
                                int acceder = reader1.GetInt32(reader1.GetOrdinal("per_acceder"));
                                int modificar = reader1.GetInt32(reader1.GetOrdinal("per_modificar"));
                                if (acceder == 1)
                                {
                                    LogicaNegocios.Globales.accesomodificaradopciones = 1;
                                }
                                if (modificar == 1)
                                {
                                    LogicaNegocios.Globales.accesomodificaradopciones = 2;
                                }
                            }
                            if ((reader1["menu_nombre"].ToString() == "Pagos"))
                            {
                                int acceder = reader1.GetInt32(reader1.GetOrdinal("per_acceder"));
                                int modificar = reader1.GetInt32(reader1.GetOrdinal("per_modificar"));
                                if (acceder == 1)
                                {
                                    LogicaNegocios.Globales.accesopagos = 1;
                                }
                                if (modificar == 1)
                                {
                                    LogicaNegocios.Globales.accesopagos = 2;
                                }
                            }
                            if ((reader1["menu_nombre"].ToString() == "Credito"))
                            {
                                int acceder = reader1.GetInt32(reader1.GetOrdinal("per_acceder"));
                                int modificar = reader1.GetInt32(reader1.GetOrdinal("per_modificar"));
                                if (acceder == 1)
                                {
                                    LogicaNegocios.Globales.accesocredito = 1;
                                }
                                if (modificar == 1)
                                {
                                    LogicaNegocios.Globales.accesocredito = 2;
                                }
                            }*/

                        }


                        reader.Dispose();
                        
                        return true;

                    }

                }
                else
                {
                    return false;
                }


            }
            catch (MySqlException)
            {
                //       MessageBox.Show("Se produjo un error al conectar a la Base de datos" + Convert.ToString(ex));
                return false;
            }
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
                myCommand.Parameters.AddWithValue("coloreleg", this.ColorElegido);
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


        public void ModificarColorFondo()
        {
            Conexion con = new Conexion("usuarios", Globales.ip);
            con.AbrirConexio();
            string query = "UPDATE usuarios.usuarios SET USU_COLOR = '"+ Colorfondo + "' where USU_IDE = "+ Usuide +"";
            con.InsertarYactualiza(query);
        }

        public string Colorfondo
        {
            set { this._colorfondo = value; }
            get { return this._colorfondo; }
        }

        public string ColorElegido
        {
            set { this._colorelegido = value; }
            get { return this._colorelegido; }
        }
        public int Usuide
        {
            set { this._usuide = value; }
            get { return this._usuide; }
        }
    }
}