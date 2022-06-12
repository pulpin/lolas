using AccesoaDatos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LogicaNegocios
{
    public class Adopcion
    {
        int _numero, _alta, _ide, _porcentaje, _anio, addc_ide, _docide, _libide, _areaide, _sinedi,_opcional, _escuela, _curso, _local;
        int _division, _turno,_cantidad, _loc, _borrarpago, _proveebanco, _proveecuentaide, _proveeide;
        string _titulo,_calle, _localidad,_provincia,_telefono,_cuit,_cliente, _nombredocente, _obs, _importe, _fecha, _fechavto, _facturanro;
        string _proveenombre, _proveeanombre, _proveedire, _proveemail, _proveeobs, _proveecc, _proveeca, _proveetitular, _proveecbu, _proveetele, _proveecuit;
        public DataTable Tabladedatos_editoriales()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            return con.Mostrar_Datos("select EDI_CODIGO,EDI_EDITORIAL from lolasdb.editorial order by EDI_EDITORIAL");
        }

        public DataTable Tabladedatos_areas()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            return con.Mostrar_Datos("select area_ide,area_desc from lolasdb.areas order by area_desc");
        }

        public DataTable Tabladedatos_adopcionTodos()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            return con.Mostrar_Datos("select e.esc_desc,c.cur_desc,d.div_desc as ado_division,t.tur_desc,a.ado_cantialumnos,a.ado_ide,a.ado_tur_ide,t.tur_desc as turno,l.loc_desc,a.ado_esc_ide,a.ado_cur_ide,a.ado_div_ide,a.ado_tur_ide,a.ado_loc_ide,a.ado_obs from adopcion a left join escuelas e on a.ado_esc_ide = e.esc_ide " +
                                    " left join cursos c on a.ado_cur_ide = c.cur_ide " +
                                    " left join turno t on a.ado_tur_ide = t.tur_ide left join division d on a.ado_div_ide = d.div_ide" +
                                    " left join localidades l on a.ado_loc_ide = l.loc_ide ");
        }

        public DataTable Tabladedatos_adopcionDetalle()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            return con.Mostrar_Datos("select li.LI_CODIGOVIEJO,li.LI_DESC," +
                                    "(CASE WHEN ad.adod_opcional=1 then 'OPCIONAL' WHEN ad.adod_sineditorial=1 then 'CUALQUIER EDITORIAL' ELSE e.EDI_EDITORIAL END) AS EDI_EDITORIAL," +
                                    " a2.area_desc,ad.adod_ide from adopcion a left join adopcion_detalle ad " +
                                    " on a.ado_ide = ad.adod_ado_ide " +
                                    " left join libros li on ad.adod_lib_ide = li.li_ide " +
                                    " left join editorial e on li.LI_EDI_CODIGO = e.EDI_CODIGO " +
                                    " left join areas a2 on ad.adod_area_ide = a2.area_ide " +
                                    " where a.ado_ide = "+this.Ide+" ");
        }
        public DataTable Tabladedatos_proveedorescombo(int local)
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            return con.Mostrar_Datos("select acre_ide,acre_desc from pagos.acreedores ac " +
            " where acre_local_ide = " + local + " order by acre_desc");
        }
        public DataTable Tabladedatos_proveedores(int local)
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            return con.Mostrar_Datos("select acre_ide,acre_desc,acre_local_ide,acre_anombrede,acre_dire,acre_tel, " +
            " acre_mail, acre_obs, cu_ide, cu_banco_ide, cu_ctacorriente, cu_cahora, cu_titular, " +
            " cu_cbu, cu_cuit from pagos.acreedores ac left " +
            " join pagos.cuentas cu on ac.acre_ide = cu.cu_acre_ide where acre_local_ide = "+local+ " order by acre_desc");
        }
        public DataTable Tabladedatos_bancos()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            return con.Mostrar_Datos("select banco_ide,banco_desc from pagos.bancos order by banco_desc");
        }
        public DataTable Tabladedatos_proveedoresBuscar(int local)
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            string contiene = "%";
            string valor = "acre_desc like " + "'" + contiene + "" + this.Titulo + "%" + "'";
            return con.Mostrar_Datos("select acre_ide,acre_desc,acre_local_ide,acre_anombrede,acre_dire,acre_tel, " +
                            " acre_mail, acre_obs, cu_ide, cu_banco_ide, cu_ctacorriente, cu_cahora, cu_titular, " +
                            " cu_cbu, cu_cuit from pagos.acreedores ac left " +
                            " join pagos.cuentas cu on ac.acre_ide = cu.cu_acre_ide where acre_local_ide = " + local + " and "+ valor +" order by acre_desc");
        }
        public DataTable Tabladedatos_adopcionEscuelas()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            return con.Mostrar_Datos("select esc_ide,esc_desc from escuelas ");
        }

        public DataTable Tabladedatos_adopcionBancos()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            return con.Mostrar_Datos("select banco_ide,banco_desc from pagos.bancos ");
        }

        public DataTable Tabladedatos_adopcionDocentes()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            return con.Mostrar_Datos("select d.doc_ayn,d.doc_celular,ad.addc_ide from adopcion a left join adop_docente ad on a.ado_ide = ad.addc_ado_ide " +
                                    " left join docentes d on ad.addc_doc_ide = d.doc_ide "+
                                    " where a.ado_ide = " + this.Ide + " ");
        }

        public DataTable Tabladedatos_ListaDocentes()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            return con.Mostrar_Datos("select doc_ayn, doc_celular,doc_ide from docentes order by doc_ayn");
        }
        public DataTable Mostrar_anio()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select distinct (EXTRACT(YEAR FROM a.ado_fecha)) AS anio from adopcion a");

        }

        public DataTable Mostrar_escuela()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select esc_ide, esc_desc from escuelas e");

        }

        public DataTable Mostrar_curso()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select cur_ide, cur_desc from cursos ");

        }

        public DataTable Mostrar_division()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select div_ide, div_desc from division ");

        }

        public DataTable Mostrar_turnos()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select tur_ide, tur_desc from turno ");

        }

        public DataTable Mostrar_localidad()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select loc_ide, loc_desc from localidades ");

        }

        public DataTable Tabladedatos_adopcionesAva()
        {
            string valor = string.Empty,contiene, anio = string.Empty;
            if (this.Titulo != string.Empty)
            {
                contiene = "%";
                valor = " esc_desc like " + "'" + contiene + "" + Titulo + "%" + "'" + " or doc.doc_ayn like " + "'" + contiene + "" + Titulo + "%" + "'";
                //valor = valor + " and doc.doc_ayn like " + "'" + contiene + "" + Titulo + "%" + "'";
            }
            anio = "YEAR(a.ado_fecha)="+this.Anio+""; 

            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            /*return con.Mostrar_Datos("select e.esc_desc,c.cur_desc,d.div_desc as ado_division,t.tur_desc,a.ado_cantialumnos,a.ado_ide,a.ado_tur_ide,t.tur_desc as turno,l.loc_desc,a.ado_esc_ide,a.ado_cur_ide,a.ado_div_ide,a.ado_tur_ide,a.ado_loc_ide from adopcion a left join escuelas e on a.ado_esc_ide = e.esc_ide " +
                                    " left join cursos c on a.ado_cur_ide = c.cur_ide " +
                                    " left join turno t on a.ado_tur_ide = t.tur_ide left join division d on a.ado_div_ide = d.div_ide" +
                                    " left join localidades l on a.ado_loc_ide = l.loc_ide where " + valor + " and "+ anio +" order by esc_desc");*/
            return con.Mostrar_Datos("select e.esc_desc,c.cur_desc,d.div_desc as ado_division,t.tur_desc,a.ado_cantialumnos,a.ado_ide,a.ado_tur_ide,t.tur_desc as turno,l.loc_desc,a.ado_esc_ide,a.ado_cur_ide,a.ado_div_ide,a.ado_tur_ide,a.ado_loc_ide,a.ado_obs from adopcion a left join escuelas e on a.ado_esc_ide = e.esc_ide " +
                                      " left join cursos c on a.ado_cur_ide = c.cur_ide " +
                                      " left join turno t on a.ado_tur_ide = t.tur_ide left join division d on a.ado_div_ide = d.div_ide " +
                                      " left join localidades l on a.ado_loc_ide = l.loc_ide " +
                                      " left join adop_docente ac on a.ado_ide = ac.addc_ado_ide " +
                                      " left join docentes doc on ac.addc_doc_ide = doc.doc_ide " +
                                      "  where " + valor + " and  " + anio + "  " +
                                      "  GROUP BY e.esc_desc, c.cur_desc, d.div_desc, t.tur_desc, a.ado_cantialumnos, a.ado_ide, a.ado_tur_ide, t.tur_desc, l.loc_desc, a.ado_esc_ide, a.ado_cur_ide, a.ado_div_ide, a.ado_tur_ide, a.ado_loc_ide order by esc_desc");
        }
       
        public int spAgregarEscuela()
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
                myCommand.CommandText = "spAltaEscuela";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pescuela", this.Titulo);
                myCommand.Parameters.AddWithValue("palta", this.Alta);
                myCommand.Parameters.AddWithValue("pide", this.Ide);

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


        public int spAgregarBanco()
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
                myCommand.CommandText = "pagos.spAltaBanco";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pbanco", this.Titulo);
                myCommand.Parameters.AddWithValue("palta", this.Alta);
                myCommand.Parameters.AddWithValue("pide", this.Ide);

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
        public int spAgregarAdopcionM()
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
                myCommand.CommandText = "spAltaAdopcionM";
                myCommand.CommandType = CommandType.StoredProcedure;
                

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


        public int spAgregarProveedor()
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
                myCommand.CommandText = "pagos.spAltaProveedor";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("plocal", this.Local);
                myCommand.Parameters.AddWithValue("pnombre", this.Proveedornombre);
                myCommand.Parameters.AddWithValue("panombre", this.Proveedoranombre);
                myCommand.Parameters.AddWithValue("pdire", this.Proveedire);
                myCommand.Parameters.AddWithValue("ptelefono", this.Proveetele);
                myCommand.Parameters.AddWithValue("pmail", this.Proveemail);
                myCommand.Parameters.AddWithValue("pobs", this.Proveeobs);
                myCommand.Parameters.AddWithValue("pbanco", this.Proveebanco);
                myCommand.Parameters.AddWithValue("pcc", this.Proveecc);
                myCommand.Parameters.AddWithValue("pca", this.Proveeca);
                myCommand.Parameters.AddWithValue("ptitular", this.Proveetitular);
                myCommand.Parameters.AddWithValue("pcbu", this.Proveecbu);
                myCommand.Parameters.AddWithValue("pcuit", this.Proveecuit);
                myCommand.Parameters.AddWithValue("palta", this.Alta);
                myCommand.Parameters.AddWithValue("pproveeide", this.Proveeide);
                myCommand.Parameters.AddWithValue("pcuentaide", this.Proveecuentaide);

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

        public int spModificaAdopcionM()
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
                myCommand.CommandText = "spModificaAdopM";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pescide", this.Escuela);
                myCommand.Parameters.AddWithValue("pcuride", this.Curso);
                myCommand.Parameters.AddWithValue("pdivide", this.Division);
                myCommand.Parameters.AddWithValue("pturide", this.Turno);
                myCommand.Parameters.AddWithValue("pcanti", this.Cantidad);
                myCommand.Parameters.AddWithValue("plocide", this.Loc);
                myCommand.Parameters.AddWithValue("pobs", this.Obs);
                myCommand.Parameters.AddWithValue("pide", this.Ide);

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
        public int spAgregarDocente()
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
                myCommand.CommandText = "spAltaDocenteAdo";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pdocide", this.Docide);
                myCommand.Parameters.AddWithValue("padoide", this.Ide);

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

        public int spAgregarLibros()
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
                myCommand.CommandText = "spAltaLibroDet";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("padoide", this.Ide);
                myCommand.Parameters.AddWithValue("plibide", this.Libide);
                myCommand.Parameters.AddWithValue("pareaide", this.Area);
                myCommand.Parameters.AddWithValue("popcional", this.Opcional);
                myCommand.Parameters.AddWithValue("psineditorial", this.SinEditorial);

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
        public int spAgregarPagofactu()
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
                myCommand.CommandText = "pagos.spPagoFac";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("ide", this.Ide);
                myCommand.Parameters.AddWithValue("pfecha", this.Fecha);


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
        public int spAltaFactu()
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
                myCommand.CommandText = "pagos.spAltaFac";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pacreide", this.Ide);
                myCommand.Parameters.AddWithValue("pfecha", this.Fecha);
                myCommand.Parameters.AddWithValue("pfechavto", this.Fechavto);
                myCommand.Parameters.AddWithValue("pimporte", this.Importe);
                myCommand.Parameters.AddWithValue("pfactu", this.Facturanro);
                myCommand.Parameters.AddWithValue("pobs", this.Obs);
                

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

        public int spModificaFactu()
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
                myCommand.CommandText = "pagos.spModificaFac";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("ide", this.Ide);
                myCommand.Parameters.AddWithValue("pfecha", this.Fecha);
                myCommand.Parameters.AddWithValue("pfechavto", this.Fechavto);
                myCommand.Parameters.AddWithValue("pimporte", this.Importe);
                myCommand.Parameters.AddWithValue("pfactu", this.Facturanro);
                myCommand.Parameters.AddWithValue("pobs", this.Obs);
                myCommand.Parameters.AddWithValue("pborrar", this.Borrarpago);


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
        public int spAltaDocenteYagrega()
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
                myCommand.CommandText = "spAltaDocenteyAgrega";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pnombre", this.Nombredocente);
                myCommand.Parameters.AddWithValue("ptelefono", this.Telefono);
                myCommand.Parameters.AddWithValue("padoide", this.Ide);

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

        public int spControlaSiExisteDocente(string tele)
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
                myCommand.CommandText = "spControlaExisDoce";
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
        public int spBajaDocente()
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
                myCommand.CommandText = "spbajadocente";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("addcide", this.Adodcide);

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

        public int spBajaAdopcionM()
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
                myCommand.CommandText = "spbajaadopcionm";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("padoide", this.Ide);

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
        public int spBajaFactu()
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
                myCommand.CommandText = "pagos.spbajafactu";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pfacide", this.Ide);

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


        public int spBajaProveeCuenta()
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
                myCommand.CommandText = "pagos.spbajaproveecuenta";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pprovee", this.Proveeide);
                myCommand.Parameters.AddWithValue("pcuenta", this.Proveecuentaide);

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

        public int spBajaLibro()
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
                myCommand.CommandText = "spbajalibro";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("addcide", this.Adodcide);

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
        public int Adodcide
        {
            get { return this.addc_ide; }
            set { this.addc_ide = value; }
        }

        public int Escuela
        {
            get { return this._escuela; }
            set { this._escuela = value; }
        }
        public int Curso
        {
            get { return this._curso; }
            set { this._curso = value; }
        }
        
        public int Division
        {
            get { return this._division; }
            set { this._division = value; }
        }
        public int Turno
        {
            get { return this._turno; }
            set { this._turno = value; }
        }
        public int Borrarpago
        {
            get { return this._borrarpago; }
            set { this._borrarpago = value; }
        }
        public int Cantidad
        {
            get { return this._cantidad; }
            set { this._cantidad = value; }
        }
        public string Obs
        {
            get { return this._obs; }
            set { this._obs = value; }
        }
        public string Fecha
        {
            get { return this._fecha; }
            set { this._fecha = value; }
        }
        public string Fechavto
        {
            get { return this._fechavto; }
            set { this._fechavto = value; }
        }
        public string Importe
        {
            get { return this._importe; }
            set { this._importe = value; }
        }
        public string Facturanro
        {
            get { return this._facturanro; }
            set { this._facturanro = value; }
        }
        public int Docide
        {
            get { return this._docide; }
            set { this._docide = value; }
        }

        public int Anio
        {
            get { return this._anio; }
            set { this._anio = value; }
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
        public int Loc
        {
            get { return this._loc; }
            set { this._loc = value; }
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
        public string Proveedornombre
        {
            get { return this._proveenombre; }
            set { this._proveenombre = value; }
        }
        public string Proveedoranombre
        {
            get { return this._proveeanombre; }
            set { this._proveeanombre = value; }
        }
        public string Proveedire
        {
            get { return this._proveedire; }
            set { this._proveedire = value; }
        }
        
        public string Proveetele
        {
            get { return this._proveetele; }
            set { this._proveetele = value; }
        }
        public string Proveemail
        {
            get { return this._proveemail; }
            set { this._proveemail = value; }
        }
        public string Proveeobs
        {
            get { return this._proveeobs; }
            set { this._proveeobs = value; }
        }
        public string Proveecc
        {
            get { return this._proveecc; }
            set { this._proveecc = value; }
        }
        public string Proveeca
        {
            get { return this._proveeca; }
            set { this._proveeca = value; }
        }
        public string Proveetitular
        {
            get { return this._proveetitular; }
            set { this._proveetitular = value; }
        }
        public string Proveecbu
        {
            get { return this._proveecbu; }
            set { this._proveecbu = value; }
        }
        public string Proveecuit
        {
            get { return this._proveecuit; }
            set { this._proveecuit = value; }
        }
        public int Proveebanco
        {
            get { return this._proveebanco; }
            set { this._proveebanco = value; }
        }
        public int Proveecuentaide
        {
            get { return this._proveecuentaide; }
            set { this._proveecuentaide = value; }
        }
        public int Proveeide
        {
            get { return this._proveeide; }
            set { this._proveeide = value; }
        }
        public int Local
        {
            get { return this._local; }
            set { this._local = value; }
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
        public string Nombredocente
        {
            get { return this._nombredocente; }
            set { this._nombredocente = value; }
        }

        public int Libide
        {
            get { return this._libide; }
            set { this._libide = value; }
        }
        public int Area
        {
            get { return this._areaide; }
            set { this._areaide = value; }
        }
        public int Opcional
        {
            get { return this._opcional; }
            set { this._opcional = value; }
        }
        public int SinEditorial
        {
            get { return this._sinedi; }
            set { this._sinedi = value; }
        }
    }


}


