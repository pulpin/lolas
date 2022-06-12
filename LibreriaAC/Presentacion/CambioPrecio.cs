using LogicaNegocios;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Presentacion
{
    public partial class CambioPrecio : Form
    {
       // int tipop = 0;
       // string server = "127.0.0.1";
        string server = "10.1.10.202";
        //string server = "192.168.0.105";
        string database = "lolasdb";
        string uid = "cambioprecio";
        //string uid = "root";
        
        string password = "123123";
        //string password = "lolasdb99";

        Productos pro = new Productos();
        //int rendicionide;
        int codigoproveeausar, contar = 0;
        Thread hilo, hilonuevo;
        public CambioPrecio()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void AltaconsignaMae_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Editorial edi = new Editorial();

            lUEditorial.Properties.DisplayMember = "EDI_EDITORIAL";
            lUEditorial.Properties.ValueMember = "EDI_CODIGO";
            lUEditorial.Properties.DataSource = edi.Tabladedatos_editoriales();
            lUEditorial.Properties.PopulateColumns();
          //  lUEditorial.Properties.Columns[0].Visible = false;
        }


        private void Modificarprecio()
        {
            string isbn,precio,nalta;
            Decimal valor1, valor2;
            int valor3;

            int tipop = 0;

            isbn = gridViewPintarFilas.GetRowCellValue(0, "isbn").ToString();

            int cantidad = isbn.Length;
            

            for (int i = 0; i < gridViewPintarFilas.DataRowCount; i++)
            {
                isbn = gridViewPintarFilas.GetRowCellValue(i, "isbn").ToString();
                          
                precio = gridViewPintarFilas.GetRowCellValue(i, "precio").ToString();

                pro.spConCambioPrecio(isbn,precio,tipop);
                
                //es es diferente de cero existe
                valor1 = pro.Primervalordecimal;
                //acá está la diferencia
                valor2 = pro.Segundovalordecimal;
                valor3 = pro.Tercervalorint;
                if (valor3 == 1)
                {
                    nalta = "ALTA";
                }
                else if (valor3 == 2)
                {
                    nalta = "MODIFICAR";
                }
                else
                {
                    nalta = "NO";
                }

                gridViewPintarFilas.SetRowCellValue(i, "precioactual",valor1);
                gridViewPintarFilas.SetRowCellValue(i, "diferencia", valor2);
                gridViewPintarFilas.SetRowCellValue(i, "modificar", nalta);
                
                 /*   if (valor3 == 2)
                    {
                        gridViewPintarFilas.SetRowCellValue(i, "modifica", valor3);
                    }
                    else if (valor3 == 1)
                    {
                        gridViewPintarFilas.SetRowCellValue(i, "modifica", 2);
                    }
                    else
                    {
                        gridViewPintarFilas.SetRowCellValue(i, "modifica", 0);
                    }
                
            */
                  /*  if (valor1 > 0)
                    {
                        //pregunto si hay diferencia de precios
                        if (valor2 > 0)
                        {
                            // si hay diferencia, entonces marco que hay que modificar.
                            gridViewPintarFilas.SetRowCellValue(i, "modifica", 1);
                        }
                        else
                        {
                            // acá marco que no se hace nada.
                            gridViewPintarFilas.SetRowCellValue(i, "modifica", 0);
                        }

                    }
                    else
                    {
                        // es nuevo, dar de alta.
                        gridViewPintarFilas.SetRowCellValue(i, "modifica", 2);
                    }
       
             */

            }

        }


        private void ModificarprecioNuevaGrilla()
        {
            string isbn, precio, nalta;
            Decimal valor1, valor2;
            int valor3;

            int tipop = 0;

            //isbn = gridViewPintarFilas.GetRowCellValue(0, "isbn").ToString();
            isbn = Convert.ToString(dgvProductos.CurrentRow.Cells[0].Value);

            int cantidad = isbn.Length;
            /*if (rbbarra.Checked)
            {
                tipop = 0;
                if (cantidad < 12)
                {
                    DialogResult result = MessageBox.Show("Está seguro que la lista de precios que va a modificar posee BARRA?", "Atención", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        //aqui el codigo
                        return;
                    }


                }

            }
            else
            {
                tipop = 1;
                if (cantidad > 10)
                {
                    DialogResult result = MessageBox.Show("Está seguro que la lista de precios que va a modificar posee ISBN?", "Atención", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        //aqui el codigo
                        return;
                    }
                }
            }*/
            double precioasacar = Convert.ToDouble(dgvProductos.RowCount);
            //dgvProductos.Columns.Add("");
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {

                isbn = Convert.ToString(row.Cells[0].Value);
                precio = Convert.ToString(row.Cells[4].Value);
                pro.spConCambioPrecio(isbn, precio, tipop);
                valor1 = pro.Primervalordecimal;
                //acá está la diferencia
                valor2 = pro.Segundovalordecimal;
                valor3 = pro.Tercervalorint;
                if (valor3 == 1)
                {
                    nalta = "ALTA";
                }
                else if (valor3 == 2)
                {
                    nalta = "MODIFICAR";
                }
                else
                {
                    nalta = "NO";
                }
                
                row.Cells[5].Value = valor1;
                row.Cells[6].Value = valor2;
                row.Cells[7].Value = nalta;
            }
    

    
        }

        private void Modificarprecioarticulos()
        {
            string npproveedor, npcodigo, costo, modif;
            Decimal valor1, valor2, valor3,valor4,nuevovalor, nuevovalor2,diferencia;

          //  npproveedor = gridViewPintarFilas.GetRowCellValue(0, "proveedor").ToString();
           // npcodigo = gridViewPintarFilas.GetRowCellValue(0, "codigo").ToString();

            for (int i = 0; i < gridViewPintarFilas.DataRowCount; i++)
            {
                npproveedor = gridViewPintarFilas.GetRowCellValue(i, "proveedor").ToString();
                npcodigo = gridViewPintarFilas.GetRowCellValue(i, "codigo").ToString();

                costo = gridViewPintarFilas.GetRowCellValue(i, "costo").ToString();
                costo = Convert.ToString(Math.Round(Convert.ToDecimal(costo), 2));
                pro.spConCambioPrecioArticulos(npproveedor, npcodigo, costo);
                //es es diferente de cero existe
                valor1 = pro.Cuartovalordecimal;
                //acá está la diferencia
                valor2 = pro.Quintovalordecimal;
                valor3 = pro.Sextovalordecimal;
                valor4 = pro.Septimovalordecimal;
                nuevovalor = Convert.ToDecimal(costo) + (Convert.ToDecimal(costo) * valor2 / 100);
                nuevovalor2 = Convert.ToDecimal(nuevovalor) + (Convert.ToDecimal(nuevovalor) * valor4 / 100);
                nuevovalor2 = Math.Round(nuevovalor2, 0);
                valor3 = Math.Round(valor3, 0);
                diferencia = nuevovalor2 - valor3;
                if (diferencia > 0)
                {
                    modif = "SI";
                }
                else {
                    modif = "NO";
                }
                if (valor1 == 0)
                {
                    modif = "NUEVO";
                }
                //  nuevovalor = nuevovalor valor3+ (nuevovalor * valor4 / 100);
                // nuevovalor = Math.Truncate((nuevovalor * 1000) / 1000);
                /* if (valor3 == 1)
                 {
                     nalta = "ALTA";
                 }
                 else if (valor3 == 2)
                 {
                     nalta = "MODIFICAR";
                 }
                 else
                 {
                     nalta = "NO";
                 }*/

                gridViewPintarFilas.SetRowCellValue(i, "costoactual", valor1);
                gridViewPintarFilas.SetRowCellValue(i, "IVAactual", valor2);
                gridViewPintarFilas.SetRowCellValue(i, "precioactual", valor3);
                gridViewPintarFilas.SetRowCellValue(i, "porcentaje", valor4);
                gridViewPintarFilas.SetRowCellValue(i, "precionuevo", nuevovalor2);
                gridViewPintarFilas.SetRowCellValue(i, "diferencia", diferencia);
                gridViewPintarFilas.SetRowCellValue(i, "modificar", modif);

            }

        }

        private void dardealta(Productos pro, int i)
        {

                string precio2;
                precio2 = gridViewPintarFilas.GetRowCellValue(i, "precio").ToString();
                //si es vacio es que no existe el articulo, crear nuevo
                pro.Titulo = gridViewPintarFilas.GetRowCellValue(i, "titulo").ToString();
                pro.Autor = gridViewPintarFilas.GetRowCellValue(i, "autor").ToString();
                string edi1 = gridViewPintarFilas.GetRowCellValue(i, "edi").ToString();
                pro.Editorial = Convert.ToInt32(edi1);
            pro.Precio = precio2;
            /*pro.Genero = 1;
            pro.Precio = precio2;
            pro.Cantidad = 0;
            pro.Costo = "0";
            pro.Iva = "0";
            pro.Ganancia = "0";
            pro.Factura = string.Empty;
            */
           /* if (rbbarra.Checked)
                {
                    string barra1 = gridViewPintarFilas.GetRowCellValue(i, "isbn").ToString(); ;
                    string isbn1 = barra1.Substring(3, 10);
                    pro.Isbn = isbn1;
                    pro.Barra = gridViewPintarFilas.GetRowCellValue(i, "isbn").ToString(); ;
                }
                else
                {
                    //pro.Barra = "0";
                    pro.Isbn = gridViewPintarFilas.GetRowCellValue(i, "isbn").ToString(); ;
                    pro.Barra = "987" + pro.Isbn;
            }*/
            /*  pro.Imagen = string.Empty;
              pro.Tipo = 0;
              pro.Cuerpo = string.Empty;
              pro.Estante = string.Empty;*/
            int valor = pro.spEnvioproductoprecioautomatico();
                if (valor == 0)
                {
                    //MessageBox.Show("se dió de alta");
                }
         
        }

        private void dardealtaNuevaGrilla(Productos pro, int i)
        {

           // string precio2;
            //precio2 = gridViewPintarFilas.GetRowCellValue(i, "precio").ToString();
            //precio2 = Convert.ToString(row.Cells[0].Value);
            //si es vacio es que no existe el articulo, crear nuevo
            pro.Titulo = gridViewPintarFilas.GetRowCellValue(i, "titulo").ToString();
            pro.Autor = gridViewPintarFilas.GetRowCellValue(i, "autor").ToString();
            string edi1 = gridViewPintarFilas.GetRowCellValue(i, "edi").ToString();
            pro.Editorial = Convert.ToInt32(edi1);
            pro.Genero = 1;
          //  pro.Precio = precio2;
            pro.Cantidad = 0;
            pro.Costo = "0";
            pro.Iva = "0";
            pro.Ganancia = "0";
            pro.Factura = string.Empty;

            /*if (rbbarra.Checked)
            {
                string barra1 = gridViewPintarFilas.GetRowCellValue(i, "isbn").ToString(); ;
                string isbn1 = barra1.Substring(3, 10);
                pro.Isbn = isbn1;
                pro.Barra = gridViewPintarFilas.GetRowCellValue(i, "isbn").ToString(); ;
            }
            else
            {
                //pro.Barra = "0";
                pro.Isbn = gridViewPintarFilas.GetRowCellValue(i, "isbn").ToString(); ;
                pro.Barra = "987" + pro.Isbn;
            }*/
            pro.Imagen = string.Empty;
            pro.Tipo = 0;
            pro.Cuerpo = string.Empty;
            pro.Estante = string.Empty;
            string valor = pro.spInsertarProducto();
            if (valor != "error")
            {
                //MessageBox.Show("se dió de alta");
            }

        }

        private void modificarproducto(Productos pro, int i)
        {
            int titu=0,edit=0;

            //titulo y autor
            if (chbTitulo.Checked == true)
            {
                titu = 1;
            }

            if (chbEditorial.Checked == true)
            {
                edit = 1;
            }

            string precio2,precioante;
            precio2 = gridViewPintarFilas.GetRowCellValue(i, "precio").ToString();

            precioante = gridViewPintarFilas.GetRowCellValue(i, "precioactual").ToString();
            //si es vacio es que no existe el articulo, crear nuevo
            pro.Titulo = gridViewPintarFilas.GetRowCellValue(i, "titulo").ToString();
            pro.Autor = gridViewPintarFilas.GetRowCellValue(i, "autor").ToString();
            string edi1 = gridViewPintarFilas.GetRowCellValue(i, "edi").ToString();
            pro.Editorial = Convert.ToInt32(edi1);
            pro.PrecioL = Convert.ToDecimal(precio2);
            pro.Precioante = Convert.ToDecimal(precioante);
            pro.titup = titu;
            pro.edip = edit;
            
            /*if (rbbarra.Checked)
            {
                pro.Barra = gridViewPintarFilas.GetRowCellValue(i, "isbn").ToString();
                pro.Isbn = "0";
            }
            else
            {
                pro.Barra = "0";
                pro.Isbn = gridViewPintarFilas.GetRowCellValue(i, "isbn").ToString(); ;
            }*/
            
            int valor = pro.spModificarProductoPrecios();
            if (valor == 0)
            {
                //MessageBox.Show("se dió de alta");
            }
        }

        private void modificarproductoArticulos(Productos pro, int i)
        {


            //string titulop, edip, precioante;
            pro.Codigoprovee = gridViewPintarFilas.GetRowCellValue(i, "proveedor").ToString();
            pro.Codigo = gridViewPintarFilas.GetRowCellValue(i, "codigo").ToString();
            pro.PrecioL = Convert.ToDecimal(gridViewPintarFilas.GetRowCellValue(i, "costo").ToString());
            pro.Precioante = Convert.ToDecimal(gridViewPintarFilas.GetRowCellValue(i, "precionuevo").ToString());
            
            int valor = pro.spModificarProductoPreciosArt();
            if (valor == 0)
            {
                //MessageBox.Show("se dió de alta");
            }
        }



        private void btnagregar_Click(object sender, EventArgs e)
        {
            timer1.Start();
            DialogResult result = MessageBox.Show("¿Seguro que desea realizar el cambio de precios?", "Opción", MessageBoxButtons.YesNo);
            string isbn=string.Empty;
            
            //DialogResult resultad;
            
            if (result == DialogResult.Yes)
            {

                if (rBlibros.Checked == true)
                {

                   /* if (lUEditorial.EditValue == null)
                    {
                        MessageBox.Show("Debe seleccionar la editorial");
                        lUEditorial.Select();
                    }
                    else
                    {*/
                        pictureBox1.Visible = true;
                        hilo = new Thread(recorrergrillasp1);
                        hilo.Start();
                  //  }

                }
                else
                {
                    if (lUEditorial.EditValue == null)
                    {
                        MessageBox.Show("Debe seleccionar el proveedor");
                        lUEditorial.Select();
                    }
                    else {
                        //articulos de lolasdb
                        /*  pictureBox1.Visible = true;
                          recorrergrillaArticulos();
                          btndescontinuados.Visible = true;*/
                        pictureBox1.Visible = true;
                        // recorrergrilla();
                        // Thread t = new Thread(recorrergrillasp1);
                        hilo = new Thread(recorrergrillasp1Articulos);
                       // recorrergrillaArticulos();
                        hilo.Start();
                        btndescontinuados.Visible = true;
                    }
                }
                

            }
            else
            {
                //presionó que no...

            }
            
        }

       

        private void recorrergrilla()
        {
            //int Valor_Retornado = 0;
            //string cadenaconexion;

            //string server = "10.1.10.202";
            string server = "127.0.0.1";
            string database = "lolasdb";
            string uid = "root";
            string password = "lolasdb99";
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" + "Allow Zero Datetime=true";

            MySqlConnection mysql_conexion = new MySqlConnection(connectionString);
           // MySqlCommand myCommand = mysql_conexion.CreateCommand();
            // MySqlCommand myCommand = new  MySqlCommand();
            mysql_conexion.Open();

            MySqlDataReader reader = null;

            // MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            decimal pprecio;

            for (int i = 0; i < gridViewPintarFilas.DataRowCount; i++)
            {
                // no existe y se da de alta al nuevo producto.
                /* if (gridViewPintarFilas.GetRowCellValue(i, "modificar").ToString() == "ALTA")
                 {
                     dardealta(pro, i);
                 }
                 // si existe y se modifica el producto.
                 else if (gridViewPintarFilas.GetRowCellValue(i, "modificar").ToString() == "MODIFICAR")
                 {

                     modificarproducto(pro, i);
                 }

                                string precio2;
                precio2 = gridViewPintarFilas.GetRowCellValue(i, "precio").ToString();
                //si es vacio es que no existe el articulo, crear nuevo
                pro.Titulo = gridViewPintarFilas.GetRowCellValue(i, "titulo").ToString();
                pro.Autor = gridViewPintarFilas.GetRowCellValue(i, "autor").ToString();
                string edi1 = gridViewPintarFilas.GetRowCellValue(i, "edi").ToString();
                pro.Editorial = Convert.ToInt32(edi1);
            pro.Precio = precio2;


                 */
                //dardealta(pro, i);
                /*
               string pbarra = gridViewPintarFilas.GetRowCellValue(i, "isbn").ToString();
               string pprecio = gridViewPintarFilas.GetRowCellValue(i, "precio").ToString();
               string ptitulo = (gridViewPintarFilas.GetRowCellValue(i, "titulo").ToString()).ToUpper();
               string pautor = (gridViewPintarFilas.GetRowCellValue(i, "autor").ToString()).ToUpper();
               int peditorial = Convert.ToInt32(gridViewPintarFilas.GetRowCellValue(i, "edi").ToString());
               try
               {
                   MySqlCommand myCommand = mysql_conexion.CreateCommand();
                   // myCommand.Transaction = sqlTran;
                   myCommand.Connection = mysql_conexion;

                   myCommand.CommandText = "spPrecioAutomatico";
                   myCommand.CommandType = CommandType.StoredProcedure;
                   myCommand.Parameters.AddWithValue("nbarra",pbarra );
                   myCommand.Parameters.AddWithValue("nprecio", pprecio);
                   myCommand.Parameters.AddWithValue("ntitulo",ptitulo );
                   myCommand.Parameters.AddWithValue("nautor", pautor);
                   myCommand.Parameters.AddWithValue("neditorial", peditorial);
                   myCommand.Parameters.AddWithValue("usuide", Globales.gbUsuide);

                   MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.Int32);
                   //MySqlParameter ValorRetorno = new MySqlParameter("RETURN_VALUE", SqlDbType.Decimal);
                   ValorRetorno.Direction = ParameterDirection.Output;// Output;
                   myCommand.Parameters.Add(ValorRetorno);
                   myCommand.ExecuteNonQuery();
                   Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);


                   //MySqlCommand myCommand = mysql_conexion.CreateCommand();
                   //  myCommand.Transaction = sqlTran;

                   // mysql_conexion.Dispose();
                   //mysql_conexion.Close();
               }
               catch (Exception ex)
               {
                   // Handle the exception if the transaction fails to commit.
                   Console.WriteLine(ex.Message);

                   try
                   {
                       // Attempt to roll back the transaction.
                      //   sqlTran.Rollback();
                   }
                   catch (Exception exRollback)
                   {
                       Console.WriteLine(exRollback.Message);
                   }
               }
               // modificarproducto(pro, i);
           }
           // sqlTran.Commit();
           // mysql_conexion.Dispose();

           */
                string pbarra = gridViewPintarFilas.GetRowCellValue(i, "isbn").ToString();
                //string pbarra = "234324324";
                 string query_selecionar = "select LI_PRECIO from libros where li_barra = "+ pbarra +"";
                //string query_selecionar = "update libros set li_stock = 0 where li_barra = " + pbarra + "";
                MySqlCommand myCommand = new MySqlCommand(query_selecionar, mysql_conexion);
               // myCommand.ExecuteReader();
                reader = myCommand.ExecuteReader();

                if (reader.Read() != false)
                {
                    if (reader.IsDBNull(0) == true)
                    {
                        reader.Dispose();
                    }
                    else
                    {
                        pprecio = Convert.ToDecimal(gridViewPintarFilas.GetRowCellValue(i, "precio").ToString());
                        decimal preciobd = Convert.ToDecimal(reader["LI_PRECIO"].ToString());
                        if (pprecio > preciobd)
                        {
                            reader.Close();
                            string query_selecionar2 = "update libros set li_precio =@pprecio where li_barra = @pbarra";
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = query_selecionar2;
                            cmd.Parameters.AddWithValue("@pbarra",pbarra);
                            cmd.Parameters.AddWithValue("@pprecio", pprecio);
                            cmd.Connection = mysql_conexion;
                            cmd.ExecuteNonQuery();
                            // MySqlCommand myCommand2 = new MySqlCommand(query_selecionar2, mysql_conexion);
                            // myCommand.ExecuteReader();
                            
                            // MessageBox.Show("cambiar de preciobd");

                        }

                        //MessageBox.Show(Convert.ToString(preciobd));
                    }
                }
                else
                {
                   // MessageBox.Show("no existe dar de alta");
                }
                reader.Close();
            }
            mysql_conexion.Close();

            pictureBox1.Visible = false;
            gConsulta.DataSource = null;
            MessageBox.Show("Se ha realizado el cambio de precios...");

        }

        private void recorrergrillasp()
        {
            int Valor_Retornado = 0;
           // string cadenaconexion;
            int contador = 0;
            //string server = "10.1.10.202";
            string server = "127.0.0.1";
            string database = "lolasdb";
            string uid = "root";
            string password = "lolasdb99";
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" + "Allow Zero Datetime=true";

            MySqlConnection mysql_conexion = new MySqlConnection(connectionString);
            // MySqlCommand myCommand = mysql_conexion.CreateCommand();
            // MySqlCommand myCommand = new  MySqlCommand();
            mysql_conexion.Open();

            MySqlTransaction sqlTran = null;
            MySqlCommand myCommand;
            for (int i = 0; i < gridViewPintarFilas.DataRowCount; i++)
            {
                
                //dardealta(pro, i);
               
               string pbarra = gridViewPintarFilas.GetRowCellValue(i, "isbn").ToString();
               decimal pprecio = Convert.ToDecimal(gridViewPintarFilas.GetRowCellValue(i, "precio").ToString());
               string ptitulo = (gridViewPintarFilas.GetRowCellValue(i, "titulo").ToString()).ToUpper();
               string pautor = (gridViewPintarFilas.GetRowCellValue(i, "autor").ToString()).ToUpper();
               int peditorial = Convert.ToInt32(gridViewPintarFilas.GetRowCellValue(i, "edi").ToString());
               try
               {
                    sqlTran = mysql_conexion.BeginTransaction();
                    myCommand = mysql_conexion.CreateCommand();
                    myCommand.Transaction = sqlTran;

                    myCommand.Connection = mysql_conexion;

                   myCommand.CommandText = "spPrecioAutomatico";
                   myCommand.CommandType = CommandType.StoredProcedure;
                   myCommand.Parameters.AddWithValue("nbarra",pbarra );
                   myCommand.Parameters.AddWithValue("nprecio", pprecio);
                   myCommand.Parameters.AddWithValue("ntitulo",ptitulo );
                   myCommand.Parameters.AddWithValue("nautor", pautor);
                   myCommand.Parameters.AddWithValue("neditorial", peditorial);
                   myCommand.Parameters.AddWithValue("usuide", Globales.gbUsuide);

                   MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.Int32);
                   //MySqlParameter ValorRetorno = new MySqlParameter("RETURN_VALUE", SqlDbType.Decimal);
                   ValorRetorno.Direction = ParameterDirection.Output;// Output;
                   myCommand.Parameters.Add(ValorRetorno);
                   myCommand.ExecuteNonQuery();
                   Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);
                   sqlTran.Commit();
                    lbprocesados.Text = Convert.ToString(contador++);
                    //MySqlCommand myCommand = mysql_conexion.CreateCommand();
                    //  myCommand.Transaction = sqlTran;

                    // mysql_conexion.Dispose();
                    //mysql_conexion.Close();
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
                // modificarproducto(pro, i);
                
                
            }
           // sqlTran.Commit();
            mysql_conexion.Close();
            // sqlTran.Commit();
            // mysql_conexion.Dispose();




            pictureBox1.Visible = false;
            gConsulta.DataSource = null;
            MessageBox.Show("Se ha realizado el cambio de precios...");

        }
        private void recorrergrillasp1()
        {
            int Valor_Retornado = 0;
           // string cadenaconexion;
           // int contador = 0;
          //  string server = "10.1.10.202";
          //  string server = "127.0.0.1";
          //  string database = "lolasdb";
          //  string uid = "cambioprecio";
          //  string password = "123123";
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" + "Allow Zero Datetime=true";

            MySqlConnection mysql_conexion = new MySqlConnection(connectionString);
            // MySqlCommand myCommand = mysql_conexion.CreateCommand();
            // MySqlCommand myCommand = new  MySqlCommand();
            mysql_conexion.Open();

            MySqlTransaction sqlTran = null;
            MySqlCommand myCommand;
            // for (int i = 0; i < gridViewPintarFilas.DataRowCount; i++)
            //{
            string pbarra, isbn=string.Empty, codigoprovee = string.Empty;
            int codigoeditorial=0,cambioprove=0,cambioedito=0;


            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                pbarra = Convert.ToString(row.Cells[0].Value);
                if (pbarra != string.Empty)
                {

                    int numerodigitos = pbarra.Length;

                    decimal pprecio;
                    if (lUEditorial.EditValue != null)
                    {
                        codigoeditorial = Convert.ToInt32(lUEditorial.EditValue);
                        pprecio = Convert.ToDecimal(row.Cells[3].Value);
                        if (chkprovee.Checked == true)
                        { 
                            codigoprovee = Convert.ToString(row.Cells[4].Value);
                            cambioprove = 1;
                        }
                    }
                    else
                    {
                        codigoeditorial = Convert.ToInt32(row.Cells[3].Value);
                        pprecio = Convert.ToDecimal(row.Cells[4].Value);
                        if (chkprovee.Checked == true)
                        {
                           codigoprovee = Convert.ToString(row.Cells[5].Value);
                            cambioprove = 1;
                        }
                    }

                    string ptitulo = (Convert.ToString(row.Cells[1].Value)).ToUpper();
                    if (ptitulo.Length > 59)
                    {
                        ptitulo = ptitulo.Substring(0, 59);
                    }
                    else if (ptitulo == string.Empty)
                    {
                        ptitulo = "SIN TITULO";
                    }
                    string pautor = (Convert.ToString(row.Cells[2].Value).ToUpper());
                    if (pautor.Length > 39)
                    {
                        pautor = pautor.Substring(0, 39);
                    }
                    else if (pautor == string.Empty)
                    {
                        pautor = "VARIOS";
                    }
                    if (chbEditorial.Checked == true)
                    {
                        cambioedito = 1;
                    }
                    // int peditorial = Convert.ToInt32(row.Cells[3].Value);
                    try
                    {
                        sqlTran = mysql_conexion.BeginTransaction();
                        myCommand = mysql_conexion.CreateCommand();
                        myCommand.Transaction = sqlTran;

                        myCommand.Connection = mysql_conexion;

                        if (numerodigitos == 13)
                        {
                            isbn = pbarra.Substring(pbarra.Length - 10);
                            if (chksinimportarpre.Checked == true)
                            {
                                myCommand.CommandText = "spPrecioAutomaticos";
                            }
                            else
                            { 
                                myCommand.CommandText = "spPrecioAutomatico";
                            }
                        }
                        else if (numerodigitos == 10)
                        {
                            isbn = pbarra;
                            pbarra = "978" + pbarra;
                            if (chksinimportarpre.Checked == true)
                            {
                                myCommand.CommandText = "spPrecioAutomaticois";
                            }
                            else
                            {
                                myCommand.CommandText = "spPrecioAutomaticoi";
                            }
                        }
                        myCommand.CommandType = CommandType.StoredProcedure;
                        myCommand.Parameters.AddWithValue("nbarra", pbarra);
                        myCommand.Parameters.AddWithValue("nprecio", pprecio);
                        myCommand.Parameters.AddWithValue("ntitulo", ptitulo);
                        myCommand.Parameters.AddWithValue("nautor", pautor);
                        myCommand.Parameters.AddWithValue("neditorial", codigoeditorial);
                        myCommand.Parameters.AddWithValue("usuide", Globales.gbUsuide);
                        myCommand.Parameters.AddWithValue("nisbn", isbn);
                        myCommand.Parameters.AddWithValue("ncambioe", cambioedito);
                        myCommand.Parameters.AddWithValue("ncambiocp", cambioprove);
                        myCommand.Parameters.AddWithValue("ncodprovee", codigoprovee);

                        MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.Int32);
                        //MySqlParameter ValorRetorno = new MySqlParameter("RETURN_VALUE", SqlDbType.Decimal);
                        ValorRetorno.Direction = ParameterDirection.Output;// Output;
                        myCommand.Parameters.Add(ValorRetorno);
                        myCommand.ExecuteNonQuery();
                        Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);
                        sqlTran.Commit();
                        // lbprocesados.Text = Convert.ToString(contador++);
                        contar++;
                        //MySqlCommand myCommand = mysql_conexion.CreateCommand();
                        //  myCommand.Transaction = sqlTran;

                        // mysql_conexion.Dispose();
                        //mysql_conexion.Close();
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
                    // modificarproducto(pro, i);
                }
                else
                {
                    break;
                }
    
            }
            // sqlTran.Commit();
            mysql_conexion.Close();
            // sqlTran.Commit();
            // mysql_conexion.Dispose();
             pictureBox1.Visible = false;
             gConsulta.DataSource = null;
             lbprocesados.Text = Convert.ToString(contar);
             MessageBox.Show("Se ha realizado el cambio de precios...");

        }
        public int VaciarProveedor(MySqlConnection mysql_conexion, MySqlTransaction sqlTran, MySqlCommand myCommand, int codigoprovee)
        {
            int Valor_Retornado1 = 0;
            try
            {
                sqlTran = mysql_conexion.BeginTransaction();
                myCommand = mysql_conexion.CreateCommand();
                myCommand.Transaction = sqlTran;

                myCommand.Connection = mysql_conexion;

                myCommand.CommandText = "spVaciarProveedor";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pcodigoprovee", codigoprovee);
                
                MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.Int32);
                //MySqlParameter ValorRetorno = new MySqlParameter("RETURN_VALUE", SqlDbType.Decimal);
                ValorRetorno.Direction = ParameterDirection.Output;// Output;
                myCommand.Parameters.Add(ValorRetorno);
                myCommand.ExecuteNonQuery();
                Valor_Retornado1 = Convert.ToInt32(ValorRetorno.Value);
                sqlTran.Commit();
                // lbprocesados.Text = Convert.ToString(contador++);
               
                //MySqlCommand myCommand = mysql_conexion.CreateCommand();
                //  myCommand.Transaction = sqlTran;

                // mysql_conexion.Dispose();
                //mysql_conexion.Close();
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
            return Valor_Retornado1;
        }
        private void recorrergrillasp1Articulos()
        {
            int Valor_Retornado = 0;
          //  string cadenaconexion;
           // int contador = 0;
          //  string server = "10.1.10.202";
           /* string server = "127.0.0.1";
            string database = "lolasdb";
            string uid = "cambioprecio";
            string password = "lolasdb99";*/
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" + "Allow Zero Datetime=true";

            MySqlConnection mysql_conexion = new MySqlConnection(connectionString);
            // MySqlCommand myCommand = mysql_conexion.CreateCommand();
            // MySqlCommand myCommand = new  MySqlCommand();
            mysql_conexion.Open();

            MySqlTransaction sqlTran = null;
            MySqlCommand myCommand = null;
            // for (int i = 0; i < gridViewPintarFilas.DataRowCount; i++)
            //{
            
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {

                //dardealta(pro, i);

                string pcodigo = Convert.ToString(row.Cells[0].Value);
                if (pcodigo == string.Empty)
                {
                    break;
                }
                decimal pprecio = Convert.ToDecimal(row.Cells[1].Value);
                //string ptitulo = (Convert.ToString(row.Cells[1].Value)).ToUpper();
                //string pautor = (Convert.ToString(row.Cells[2].Value).ToUpper());
                //int peditorial = Convert.ToInt32(row.Cells[3].Value);
                string modifi = Convert.ToString(row.Cells[2].Value);
                if (modifi == "SI")
                { 
                    try
                    {
                        sqlTran = mysql_conexion.BeginTransaction();
                        myCommand = mysql_conexion.CreateCommand();
                        myCommand.Transaction = sqlTran;

                        myCommand.Connection = mysql_conexion;
                        if (chksinimportarpre.Checked == true)
                        {
                            myCommand.CommandText = "spPrecioAutomaticoArts";
                        }
                        else
                        {
                            myCommand.CommandText = "spPrecioAutomaticoArt";
                        }
                        
                        myCommand.CommandType = CommandType.StoredProcedure;
                        myCommand.Parameters.AddWithValue("pproveedor", Convert.ToInt32(lUEditorial.EditValue));
                        myCommand.Parameters.AddWithValue("pcodigo", pcodigo);
                        myCommand.Parameters.AddWithValue("precio", pprecio);

                        MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.Int32);
                        //MySqlParameter ValorRetorno = new MySqlParameter("RETURN_VALUE", SqlDbType.Decimal);
                        ValorRetorno.Direction = ParameterDirection.Output;// Output;
                        myCommand.Parameters.Add(ValorRetorno);
                        myCommand.ExecuteNonQuery();
                        Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);
                        sqlTran.Commit();
                        // lbprocesados.Text = Convert.ToString(contador++);
                        contar++;
                        //MySqlCommand myCommand = mysql_conexion.CreateCommand();
                        //  myCommand.Transaction = sqlTran;

                        // mysql_conexion.Dispose();
                        //mysql_conexion.Close();
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
                    // modificarproducto(pro, i);

                }

            }
            // sqlTran.Commit();
            mysql_conexion.Close();
            // sqlTran.Commit();
            // mysql_conexion.Dispose();
            pictureBox1.Visible = false;
            gConsulta.DataSource = null;
            lbprocesados.Text = Convert.ToString(contar);
            //btndescontinuados.Visible = true;
            MessageBox.Show("Se han realizado los cambios de precios...");
            

        }
        private void recorrergrillasp1ArticulosVerificador()
        {
            int Valor_Retornado = 0;
            String Valor_Retornado1 = string.Empty, Valor_Retornado2 = string.Empty;
            string modif = string.Empty;
            //string cadenaconexion;
            //int contador = 0;
            //  string server = "10.1.10.202";

            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" + "Allow Zero Datetime=true";

            MySqlConnection mysql_conexion = new MySqlConnection(connectionString);
            // MySqlCommand myCommand = mysql_conexion.CreateCommand();
            // MySqlCommand myCommand = new  MySqlCommand();
            mysql_conexion.Open();

            MySqlTransaction sqlTran = null;
            MySqlCommand myCommand = null;

            //vaciar proveedor
            int valordevuelto = this.VaciarProveedor(mysql_conexion, sqlTran, myCommand, Convert.ToInt32(lUEditorial.EditValue));
            if (valordevuelto != 0)
            {
                MessageBox.Show("Ocurrió un error");
            }
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {

                //dardealta(pro, i);

                string pcodigo = Convert.ToString(row.Cells[0].Value);
                if (pcodigo == string.Empty)
                {
                    break;
                }
                
                decimal pprecio = Convert.ToDecimal(row.Cells[1].Value);
                //string ptitulo = (Convert.ToString(row.Cells[1].Value)).ToUpper();
                //string pautor = (Convert.ToString(row.Cells[2].Value).ToUpper());
                //int peditorial = Convert.ToInt32(row.Cells[3].Value);
                try
                {
                    sqlTran = mysql_conexion.BeginTransaction();
                    myCommand = mysql_conexion.CreateCommand();
                    myCommand.Transaction = sqlTran;

                    myCommand.Connection = mysql_conexion;

                    myCommand.CommandText = "spPrecioAutomaticoArtVerificador";
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.AddWithValue("pproveedor", Convert.ToInt32(lUEditorial.EditValue));
                    myCommand.Parameters.AddWithValue("pcodigo", pcodigo);
                    myCommand.Parameters.AddWithValue("precio", pprecio);

                    MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.Int32);
                    MySqlParameter ValorRetorno1 = new MySqlParameter("@Rprecioactual", MySqlDbType.VarChar);
                    MySqlParameter ValorRetorno2 = new MySqlParameter("@Rprecionuevo", MySqlDbType.VarChar);
                    //MySqlParameter ValorRetorno = new MySqlParameter("RETURN_VALUE", SqlDbType.Decimal);
                    ValorRetorno.Direction = ParameterDirection.Output;// Output;
                    ValorRetorno1.Direction = ParameterDirection.Output;// Output;
                    ValorRetorno2.Direction = ParameterDirection.Output;// Output;
                    myCommand.Parameters.Add(ValorRetorno);
                    myCommand.Parameters.Add(ValorRetorno1);
                    myCommand.Parameters.Add(ValorRetorno2);
                    myCommand.ExecuteNonQuery();
                    Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);
                    Valor_Retornado1 = Convert.ToString(ValorRetorno1.Value);
                    Valor_Retornado2 = Convert.ToString(ValorRetorno2.Value);
                    sqlTran.Commit();
                    // lbprocesados.Text = Convert.ToString(contador++);
                    contar++;
                    //MySqlCommand myCommand = mysql_conexion.CreateCommand();
                    //  myCommand.Transaction = sqlTran;

                    // mysql_conexion.Dispose();
                    //mysql_conexion.Close();
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
                // modificarproducto(pro, i);

                if (Valor_Retornado == 0)
                {
                    modif = "NO";
                }
                else
                {
                    modif = "SI";
                    row.Cells[3].Value = Valor_Retornado1;
                    row.Cells[4].Value = Valor_Retornado2;
                }
                row.Cells[2].Value = modif;
               
            }

           /* for (int i = 0; i < gridViewPintarFilas.DataRowCount; i++)
            {
                string pcodigo = gridViewPintarFilas.GetRowCellValue(i, "codigo").ToString();
                if (pcodigo == string.Empty)
                {
                    break;
                }
                //decimal pprecio = Convert.ToDecimal(gridViewPintarFilas.GetRowCellValue(i, "costo").ToString());
                string pprecio = gridViewPintarFilas.GetRowCellValue(i, "costo").ToString();
                pprecio = Convert.ToString(Math.Round(Convert.ToDecimal(pprecio), 2));
                //pprecio1 = pprecio1.Replace(",",".");
                //decimal pprecio = Convert.ToDecimal(pprecio1);
                try
                {
                    sqlTran = mysql_conexion.BeginTransaction();
                    myCommand = mysql_conexion.CreateCommand();
                    myCommand.Transaction = sqlTran;

                    myCommand.Connection = mysql_conexion;

                    myCommand.CommandText = "spPrecioAutomaticoArtVerificador";
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.AddWithValue("pproveedor", Convert.ToInt32(lUEditorial.EditValue));
                    myCommand.Parameters.AddWithValue("pcodigo", pcodigo);
                    myCommand.Parameters.AddWithValue("precio", Convert.ToDecimal(pprecio));

                    MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.Int32);
                    //MySqlParameter ValorRetorno = new MySqlParameter("RETURN_VALUE", SqlDbType.Decimal);
                    ValorRetorno.Direction = ParameterDirection.Output;// Output;
                    myCommand.Parameters.Add(ValorRetorno);
                    myCommand.ExecuteNonQuery();
                    Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);
                    sqlTran.Commit();
                    // lbprocesados.Text = Convert.ToString(contador++);
                    //contar++;
                    //MySqlCommand myCommand = mysql_conexion.CreateCommand();
                    //  myCommand.Transaction = sqlTran;

                    // mysql_conexion.Dispose();
                    //mysql_conexion.Close();
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
                
                if (Valor_Retornado == 0)
                {
                    modif = "NO";
                }
                else
                {
                    modif = "SI";
                    
                }
                gridViewPintarFilas.SetRowCellValue(i, "modificar", modif);
            }
            */
            // sqlTran.Commit();
            mysql_conexion.Close();
            // sqlTran.Commit();
            // mysql_conexion.Dispose();
            pictureBox1.Visible = false;
           // gConsulta.DataSource = null;
            //lbprocesados.Text = Convert.ToString(contar);
            //btndescontinuados.Visible = true;
            MessageBox.Show("Se han recorrido los artículos1, verificar...");


        }
        private void recorrergrillaNuevaGrilla()
        {

            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                if (Convert.ToString(row.Cells[7].Value) == "ALTA")
                {
                    //dardealta(pro, i);
                    MessageBox.Show("ALTA");
                   // string precio2;
                   /* precio2 = gridViewPintarFilas.GetRowCellValue(i, "precio").ToString();
                    si es vacio es que no existe el articulo, crear nuevo
                    pro.Titulo = gridViewPintarFilas.GetRowCellValue(i, "titulo").ToString();
                    pro.Autor = gridViewPintarFilas.GetRowCellValue(i, "autor").ToString();
                    string edi1 = gridViewPintarFilas.GetRowCellValue(i, "edi").ToString();
                    pro.Editorial = Convert.ToInt32(edi1);
                    pro.Genero = 1;
                    pro.Precio = precio2;
                    pro.Cantidad = 0;
                    pro.Costo = "0";
                    pro.Iva = "0";
                    pro.Ganancia = "0";
                    pro.Factura = string.Empty;

                    if (rbbarra.Checked)
                    {
                        string barra1 = gridViewPintarFilas.GetRowCellValue(i, "isbn").ToString(); ;
                        string isbn1 = barra1.Substring(3, 10);
                        pro.Isbn = isbn1;
                        pro.Barra = gridViewPintarFilas.GetRowCellValue(i, "isbn").ToString(); ;
                    }
                    else
                    {
                        //pro.Barra = "0";
                        pro.Isbn = gridViewPintarFilas.GetRowCellValue(i, "isbn").ToString(); ;
                        pro.Barra = "987" + pro.Isbn;
                    }
                    pro.Imagen = string.Empty;
                    pro.Tipo = 0;
                    pro.Cuerpo = string.Empty;
                    pro.Estante = string.Empty;
                    int valor = pro.spInsertarProducto();
                    if (valor == 0)
                    {
                        //MessageBox.Show("se dió de alta");
                    }*/
                }
                else if(Convert.ToString(row.Cells[7].Value) == "MODIFICAR")
                {
                    //modificarproducto(pro, i);
                    MessageBox.Show("Modificarprecio");

                }

                
            }
                
            
            pictureBox1.Visible = false;
            gConsulta.DataSource = null;
            MessageBox.Show("Se ha realizado el cambio de precios...");

        }
        private void recorrergrillaArticulos()
        {
            int entra = 0;
            for (int i = 0; i < gridViewPintarFilas.DataRowCount; i++)
            {

                // si existe y se modifica el producto.
                if (gridViewPintarFilas.GetRowCellValue(i, "modificar").ToString() == "SI")
                {
                    if (entra == 0)
                    {
                        codigoproveeausar = Convert.ToInt32(gridViewPintarFilas.GetRowCellValue(i, "proveedor").ToString());
                        entra++;
                    }

                    modificarproductoArticulos(pro, i);
                }

            }
            pictureBox1.Visible = false;
            gConsulta.DataSource = null;
            MessageBox.Show("Se ha realizado el cambio de precios...");

        }
        private void btnbuscarventas_Click(object sender, EventArgs e)
        {
            /*Venta ve = new Venta();
            int codedi = Convert.ToInt32(lUEditorial.EditValue);

            DateTime fdesde = Convert.ToDateTime(desde.EditValue);
            string fdesdee = fdesde.ToString("yyyy-MM-dd");

            DateTime fhasta = Convert.ToDateTime(hasta.EditValue);
            string fhastae = fhasta.ToString("yyyy-MM-dd");

            
            gConsulta.DataSource = ve.Mostrar_ventasentrefechas(codedi,fdesdee,fhastae);
            if (gridViewPintarFilas.DataRowCount == 0)
            {
                MessageBox.Show("No existen ventas de libros consignados en esas fechas...");
            }
            */

            

        }

        private void exportarAExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdRuta.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                
                gConsulta.ExportToXlsx(sfdRuta.FileName);
                
            }
        }

        private void exportarAPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdRuta1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                gConsulta.ExportToPdf(sfdRuta1.FileName);
            }
        }

        private void exportarAExcelToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (sfdRuta.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {

                gconsulta2.ExportToXlsx(sfdRuta.FileName);

            }
        }

        private void exportarAPDFToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (sfdRuta1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                gconsulta2.ExportToPdf(sfdRuta1.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

                string extension, constr = string.Empty;
                extension = Path.GetExtension(ruta.Text);

                if (extension == ".xlsx")
                {
                    constr = "Provider = MicroSoft.ACE.OLEDB.12.0; Data Source=" + ruta.Text + "; Extended Properties =\"Excel 12.0 Xml; HDR=Yes;IMEX=1\";";
                }
                else if (extension == ".xls")
                {
                    constr = "Provider = MicroSoft.Jet.OLEDB.4.0; Data Source=" + ruta.Text + "; Extended Properties =\"Excel 8.0; HDR=Yes;\";";
                }
                else
                {
                    MessageBox.Show("No se reconoce el tipo de formato del archivo. Debe ser Excel");            }
                //
 
               // string constr = "Provider = Microsoft.ACE.OLEDB.12.0; Extended Properties='Excel 12.0 Xml;HDR=Yes;IMEX=1';";
                OleDbConnection con = new OleDbConnection(constr);
                OleDbDataAdapter sda = new OleDbDataAdapter("Select * From [" + textBox2.Text + "$]", con);
                DataTable dt = new DataTable();

                sda.Fill(dt);
              //  gConsulta.DataSource = dt;
                dgvProductos.DataSource = dt;

            
        }

        private void btnabrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = " Archivos Excel (*.xlsx)|*.xlsx|Archivos Excel (*.xls)|*.xls";
            open.Title = "archivos Excel";
            if (open.ShowDialog() == DialogResult.OK)
            {
                ruta.Text = open.FileName;
            }
        }

        private void btndiferencia_Click(object sender, EventArgs e)
        {
           // Conexion con = new Conexion("lolasdb", Globales.ip);
           // con.AbrirConexio();

           
            hilonuevo = new Thread(recorrergrillasp1ArticulosVerificador);
            //recorrergrillasp1ArticulosVerificador();
            pictureBox1.Visible = true;
            btnagregar.Visible = true;
            hilonuevo.Start();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar éste registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                //DevExpress.XtraGrid.GridControl view = sender as DevExpress.XtraGrid.GridControl;


                if (this.gridViewPintarFilas.SelectedRowsCount > 0)
                {
                    gridViewPintarFilas.DeleteSelectedRows();
                }
            }
        }

        private void rBlolasdb_CheckedChanged(object sender, EventArgs e)
        {
            if (rBlolasdb.Checked == true)
            {
                //  lUEditorial.Visible = true;
                //  label3.Visible = true;
                btnagregar.Visible = false;
                btndiferencia.Visible = true;
                groupBox4.Visible = false;
                groupBox5.Visible = true;
            }
        }

        private void rBlibros_CheckedChanged(object sender, EventArgs e)
        {
            if (rBlibros.Checked == true)
            {
                // lUEditorial.Visible = false;
                // label3.Visible = false;
                btnagregar.Visible = true;
                btndiferencia.Visible = false;
                groupBox4.Visible = true;
                groupBox5.Visible = false;
            }
        }

        private void btndescontinuados_Click(object sender, EventArgs e)
        {
            Productos pd = new Productos();
           // gConsulta.DataSource = null;
           // gridViewPintarFilas.Columns.Clear();
           // gConsulta.DataBindings.Clear();
            /*
            gridViewPintarFilas.AddNewRow();
            int rowHandle = gridViewPintarFilas.GetRowHandle(gridViewPintarFilas.DataRowCount);
            if (gridViewPintarFilas.IsNewItemRow(rowHandle))
            {
                gridViewPintarFilas.SetRowCellValue(rowHandle, gridViewPintarFilas.Columns[0], "adsf");
                gridViewPintarFilas.SetRowCellValue(rowHandle, gridViewPintarFilas.Columns[1], "ffff");
                gridViewPintarFilas.SetRowCellValue(rowHandle, gridViewPintarFilas.Columns[2], "ccc");
            }
            */
            int codigoprovee = Convert.ToInt32(lUEditorial.EditValue);
            gconsulta2.DataSource = pd.Mostrar_sincambiosdeprecio(codigoprovee);
            gConsulta.Visible = false;
            dgvProductos.Visible = false;
            gconsulta2.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show(Convert.ToString("Prueba"));
            Thread.Sleep(TimeSpan.FromSeconds(10));
            lbprocesados.Text = Convert.ToString(contar);

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           /* string algo = "9789875645213";
            algo = algo.Substring(algo.Length-10);
            MessageBox.Show(algo);
            string isbn = "950123654";*/
        }

        private void lUEditorial_EditValueChanged(object sender, EventArgs e)
        {
            if (lUEditorial.EditValue != null)
            {
                label6.Visible = false;
            }
            else
            {
                label6.Visible = true;
            }
        }

        private void chkprovee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkprovee.Checked == true)
            {
                label7.Visible = true;
            }
            else
            {
                label7.Visible = false;
            }
        }

        private void dgvProductos_DoubleClick(object sender, EventArgs e)
        {
            if (rBlolasdb.Checked == true)
            {
                string codigoc = Convert.ToString(dgvProductos.CurrentRow.Cells[0].Value);
                ConsultaProductos cp = new ConsultaProductos();
                cp.busquedasporprovee(codigoc);
                cp.ShowDialog();
               // MessageBox.Show("Ver");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread.Sleep(TimeSpan.FromSeconds(10));
            lbprocesados.Text = Convert.ToString(contar);
        }
    }
}
