using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicaNegocios;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace Presentacion
{
    public partial class Cargarapida : Form
    {
        private int tipopro = 0, _alta, _producide;
        OpenFileDialog openFileDialog1;
        private string rutacompleta, nombrearchivo, directorioactual, _iva, _codigoviejo,precioanterior;
        
        public Cargarapida()
        {
            InitializeComponent();

        }


        private void modificaproduc()
        {
            Productos pro1 = new Productos();
            pro1.productoide = this.Producide;
            pro1.Codigo = this.Codigoviejo;
            // pro.Titulo = txttitulo.Text;
            // pro.Autor = txtautor.Text;
            // pro.Editorial = Convert.ToInt32(lUEdito.EditValue);
            // pro.Editorial = Convert.ToInt32(lUEdito.EditValue);
            // pro.Genero = Convert.ToInt32(LUgenero.EditValue);
            pro1.Proveeide = Convert.ToInt32(lUEproveedor.EditValue);
            txtprecio.Text = txtprecio.Text.Replace(",", ".");
            this.precioanterior = precioanterior.Replace(",", ".");
            pro1.Precio = txtprecio.Text;
            pro1.Precioanterior = this.precioanterior;
            pro1.Remito = txtfactura.Text;
            pro1.Codigoprovee = txtcodprove.Text;
            if (txtcantidad.Text != string.Empty)
            {
                pro1.Cantidad = Convert.ToInt32(txtcantidad.Text);
                pro1.Factura = txtfactura.Text;
            }
            else
            {
                pro1.Cantidad = 0;
            }

            // txtcosto.Text = txtcosto.Text.Replace(",", ".");
            // pro.Costo = txtcosto.Text;

            //txtiva.Text = txtiva.Text.Replace(",", ".");
            // pro.Iva = txtiva.Text;
            // pro.Iva = Convert.ToString(lUporcentaje.EditValue);

            //txtporcentaje.Text = txtporcentaje.Text.Replace(",", ".");
            //pro.Ganancia = txtporcentaje.Text;


            //pro.Isbn = txtisbn.Text;
            //pro.Barra = txtbarra.Text;
            //if (nombrearchivo != string.Empty)
            //{
            //  pro.Imagen = nombrearchivo;
            //}
            //pro.Tipo = this.tipopro;
            pro1.Cuerpo = txtcuerpo.Text;
            pro1.Estante = txtestante.Text;
            int retorno = pro1.spModificarProductoCarga();
            if (retorno == 0)
            {
                if (rutacompleta != null)
                {
                    string directorioacopiar = Directory.GetCurrentDirectory();
                    string archivoacopiar = directorioacopiar + "\\libros\\" + nombrearchivo;
                    System.IO.File.Copy(rutacompleta, archivoacopiar, true);
                }
                // this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Venta ven = new Venta();
                ven.venproductoide = this.Codigoviejo;
                int cantidadreser = ven.spConsultaCantiReservas();
                if (cantidadreser > 0)
                {
                    MessageBox.Show("Existen: " + cantidadreser + " Reservas de este artículo ", "Atención hay reservas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Se ha modificado con éxito!");
                }
                
                this.vaciartexto();
            }
            else
            {
                MessageBox.Show("Hubo un problema, por favor intentelo de nuevo.");
            }
        }

        
        private void altaproduc()
        {
            Productos pro = new Productos();
            pro.Titulo = txttitulo.Text;
            pro.Autor = txtautor.Text;
            pro.Editorial = Convert.ToInt32(lUEdito.EditValue);
            pro.Genero = Convert.ToInt32(LUgenero.EditValue);

            txtprecio.Text = txtprecio.Text.Replace(",", ".");
            pro.Precio = txtprecio.Text;

            pro.Cantidad = Convert.ToInt32(txtcantidad.Text);

            txtcosto.Text = txtcosto.Text.Replace(",", ".");
            pro.Costo = txtcosto.Text;

            pro.Codigoprovee = txtcodprove.Text;

            //txtiva.Text = txtiva.Text.Replace(",", ".");

            // pro.Iva = txtiva.Text;
            pro.Iva = Convert.ToString(lUporcentaje.EditValue);

            txtporcentaje.Text = txtporcentaje.Text.Replace(",", ".");
            pro.Ganancia = txtporcentaje.Text;

            pro.Factura = txtfactura.Text;
            pro.Isbn = txtisbn.Text;
            pro.Barra = txtbarra.Text;
            if (nombrearchivo != string.Empty)
            {
                pro.Imagen = nombrearchivo;
            }
            pro.Tipo = this.tipopro;
            pro.Cuerpo = txtcuerpo.Text;
            pro.Estante = txtestante.Text;
            string retorno = pro.spInsertarProducto();
            if (retorno != "error")
            {

                if (rutacompleta != null)
                {
                    string directorioacopiar = Directory.GetCurrentDirectory();
                    string archivoacopiar = directorioacopiar + "\\libros\\" + nombrearchivo;
                    System.IO.File.Copy(rutacompleta, archivoacopiar, true);
                }
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                MessageBox.Show("Se ha dado de alta con éxito: " + retorno);
            }
            else
            {
                MessageBox.Show("Hubo un problema, por favor intentelo de nuevo.");
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (this.Alta == 1)
            {
                this.altaproduc();
            }
            else
            {
                this.modificaproduc();
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void activariva()
        {
            paneliva.Visible = true;

        }
        private void desactivariva()
        {
            this.tipopro = 0;
            paneliva.Visible = false;

        }

        private void rbartesco_CheckedChanged(object sender, EventArgs e)
        {
            this.tipopro = 1;

            this.activariva();
        }

        private void rbmarro_CheckedChanged(object sender, EventArgs e)
        {
            this.tipopro = 2;

            this.activariva();

        }

        private void rbdida_CheckedChanged(object sender, EventArgs e)
        {
            this.tipopro = 3;

            this.activariva();
        }

        private void AltaProducto_Load(object sender, EventArgs e)
        {
            this.cargar();

            Editorial edi = new Editorial();

            lUEdito.Properties.DisplayMember = "EDI_EDITORIAL";
            lUEdito.Properties.ValueMember = "EDI_CODIGO";
            lUEdito.Properties.DataSource = edi.Tabladedatos_editoriales();
            lUEdito.Properties.PopulateColumns();
            lUEdito.Properties.Columns[0].Visible = false;


            Genero gen = new Genero();
            LUgenero.Properties.DisplayMember = "GEN_DESC";
            LUgenero.Properties.ValueMember = "GEN_IDE";
            LUgenero.Properties.DataSource = gen.Tabladedatos_genero();
            LUgenero.Properties.PopulateColumns();
            LUgenero.Properties.Columns[0].Visible = false;



            PorcenIVA pori = new PorcenIVA();
            lUporcentaje.Properties.DisplayMember = "POR_IVA";
            lUporcentaje.Properties.ValueMember = "POR_IVA";
            lUporcentaje.Properties.DataSource = pori.Tabladedatos_porcetajes();
            lUporcentaje.Properties.PopulateColumns();
            // lUporcentaje.Properties.Columns[0].Visible = false;
            if (this.Iva != null)
            {
                lUporcentaje.EditValue = this.Iva;
            }
            else
            {
                lUporcentaje.EditValue = "21.00";
            }
            txtbarra.Select();
        }

        private void cargar()
        {
      

            Proveedor prove = new Proveedor();

            if (rBlibros.Checked == true)
            {
                prove.EsLibro = 1;
            }
            else
            {
                prove.EsLibro = 0;
            }

            lUEproveedor.Properties.DisplayMember = "PROV_DESC";
            lUEproveedor.Properties.ValueMember = "PROV_IDE";
            lUEproveedor.Properties.DataSource = prove.Tabladedatos_proveedores();
            lUEproveedor.Properties.PopulateColumns();
            lUEproveedor.Properties.Columns[0].Visible = false;
            lUEproveedor.Properties.Columns[2].Visible = false;


        }
        private void txttitulo_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtautor.Focus();
            }
        }

        private void txtautor_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lUEdito.Focus();
            }
        }

        private void txtprecio_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcantidad.Focus();
            }
        }

        private void txtcantidad_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtfactura.Focus();
            }
        }

        private void txtfactura_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //txtisbn.Focus();
                btnagregar.Focus();
            }
        }

        private void txtisbn_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                traerdatosproducto(2);
                txtbarra.Text = string.Empty;
                
            }
        }

        private void traerdatosproducto(int tipo)
        {
            
            MySqlDataReader reader = null;
            Productos pro = new Productos();
            pro.Barra = txtbarra.Text;
            pro.Isbn = txtisbn.Text;
            pro.Codigo = txtcodigo.Text;
            pro.Tipo = tipo;
            reader = pro.obtenerdatosproductos();

            if (reader.Read() != false)
            {
                if (reader.IsDBNull(0) == true)
                {
                    reader.Dispose();
                }
                else
                {

                    this.Producide = Convert.ToInt32(reader["LI_IDE"].ToString());
                    txttitulo.Text = reader["LI_DESC"].ToString();
                    txtautor.Text = reader["LI_AUTOR"].ToString();
                    this.Codigoviejo = reader["LI_CODIGOVIEJO"].ToString();
                    //lUEditorial.Text = reader["EDI_EDITORIAL"].ToString();
                    lUEdito.EditValue = Convert.ToInt32(reader["LI_EDI_CODIGO"].ToString());
                    LUgenero.EditValue = Convert.ToInt32(reader["LI_GEN_IDE"].ToString());
                    txtprecio.Text = reader["LI_PRECIO"].ToString();
                    precioanterior = reader["LI_PRECIO"].ToString();
                    txtcosto.Text = reader["LI_COSTO"].ToString();
                    lUporcentaje.Text = reader["LI_PORC_IVA"].ToString();
                    txtporcentaje.Text = reader["LI_PORC_GANAN"].ToString();
                    txtcuerpo.Text = reader["LI_CUERPO"].ToString();
                    txtestante.Text = reader["LI_ESTANTE"].ToString();
                    txtstockactual.Text = reader["LI_STOCK"].ToString();
                    txtcodprove.Text = reader["LI_CODIGOPROVEE"].ToString();
                    
                    lUEdito.Refresh();
                    LUgenero.Refresh();
                    txtcantidad.Focus();
                }
            }
            else
            {
                this.vaciartextos();
            }
        }

        private void vaciartextos()
        {
            MessageBox.Show("No se encontró ningún producto con esas características, vuelva a intentarlo.");

            txttitulo.Text = string.Empty;
            txtautor.Text = string.Empty;
            txtprecio.Text = string.Empty;
            txtstockactual.Text = string.Empty;
            txtcosto.Text = string.Empty;
            txtporcentaje.Text = string.Empty;
            txtcantidad.Text = string.Empty;
            txtfactura.Text = string.Empty;
            txtcuerpo.Text = string.Empty;
            txtestante.Text = string.Empty;


            lUEdito.EditValue = null;
            LUgenero.EditValue = null;


            txtbarra.Focus();
        }

        private void vaciartexto()
        {

            txttitulo.Text = string.Empty;
            txtautor.Text = string.Empty;
            txtprecio.Text = string.Empty;
            txtstockactual.Text = string.Empty;
            txtcosto.Text = string.Empty;
            txtporcentaje.Text = string.Empty;
            txtcantidad.Text = string.Empty;
           // txtfactura.Text = string.Empty;
            txtcuerpo.Text = string.Empty;
            txtestante.Text = string.Empty;

            txtcodprove.Text = string.Empty;
            lUEdito.EditValue = null;
            LUgenero.EditValue = null;


            txtbarra.Focus();
        }

        private void txtbarra_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                traerdatosproducto(0);
                txtbarra.Text = string.Empty;
                
            }
        }

        private void txtcuerpo_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtestante.Focus();
            }
        }

        private void txtestante_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnagregar.Focus();
            }
        }

        private void calcularcosto()
        {
            if (txtcosto.Text != string.Empty && txtporcentaje.Text != string.Empty)
            {
                decimal costo = Convert.ToDecimal(txtcosto.Text, CultureInfo.CreateSpecificCulture("en-US"));
                decimal iva = Convert.ToDecimal(lUporcentaje.EditValue, CultureInfo.CreateSpecificCulture("en-US"));
                decimal porcentaje = Convert.ToDecimal(txtporcentaje.Text, CultureInfo.CreateSpecificCulture("en-US"));
                decimal valorconiva = costo + (costo * iva / 100);
                decimal valorfinal = valorconiva + (valorconiva * porcentaje / 100);
                // double centecimo = 0.5;
                // valorfinal = centecimo + valorfinal;
                // valorfinal = Math.Truncate(centecimo + valorfinal);
                valorfinal = Math.Round(valorfinal, 1);
                string valoracolocar = Convert.ToString(valorfinal);
                valoracolocar = valoracolocar.Replace(",", ".");
                txtprecio.Text = valoracolocar;
            }
        }

        private void txtcosto_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calcularcosto();
                lUporcentaje.Focus();
            }
        }

        private void txtiva_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calcularcosto();
                txtporcentaje.Focus();
            }
        }

        private void txtporcentaje_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calcularcosto();
                txtcantidad.Focus();
            }
        }

        public void colocardatos(Productos pro)
        {
            Producide = pro.productoide;
            txttitulo.Text = pro.Titulo;
            txtautor.Text = pro.Autor;
            lUEdito.EditValue = pro.Editorial;
            LUgenero.EditValue = pro.Genero;

            txtprecio.Text = pro.Precio.Replace(",", ".");

            txtisbn.Text = pro.Isbn;
            txtbarra.Text = pro.Barra;
            txtcuerpo.Text = pro.Cuerpo;
            txtestante.Text = pro.Estante;
            if (pro.Tipo > 0)
            {
                txtcosto.Text = pro.Costo.Replace(",", ".");
                pro.Iva = pro.Iva.Replace(",", ".");
                this.Iva = pro.Iva;
                //lUporcentaje.EditValue = pro.Iva;

                txtporcentaje.Text = pro.Ganancia.Replace(",", ".");
                if (tipopro == 1)
                {

                }
                else if (tipopro == 2)
                {

                }
                else
                {

                }
            }



            string path = Directory.GetCurrentDirectory();
            if (pro.Imagen != string.Empty)
            {

                string fullpath = System.IO.Path.Combine(path, string.Format("libros\\{0}", pro.Imagen));
                

            }
            else
            {
               
            }


            btnagregar.Text = "Modificar";
        }

        private void lUporcentaje_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtporcentaje.Focus();
            }
        }

        private void lUporcentaje_EditValueChanged(object sender, EventArgs e)
        {
            calcularcosto();
        }

        private void rBlibros_CheckedChanged(object sender, EventArgs e)
        {
            this.cargar();
        }

        private void rBlolasdb_CheckedChanged(object sender, EventArgs e)
        {
            this.cargar();
        }

        private void txtcodigo_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                traerdatosproducto(1);
                txtbarra.Text = string.Empty;
                
            }
        }

    

      
        private void rblibro_CheckedChanged(object sender, EventArgs e)
        {
            this.desactivariva();
        }
        
        public int Alta
        {
            get { return this._alta; }
            set { this._alta = value; }
        }

        public string Iva
        {
            get { return this._iva; }
            set { this._iva = value; }
        }

        public int Producide
        {
            get { return this._producide; }
            set { this._producide = value; }
        }

        public string Codigoviejo
        {
            get { return this._codigoviejo; }
            set { this._codigoviejo = value; }
        }

        private void btnsubir_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            openFileDialog1 = new OpenFileDialog();


            //openFileDialog1.Filter = "Jpg (*.jpg)|*.jpg|files Gif files (*.gif)|*.gif|Bitmap files (*.Bmp)|*.bmp|PNG files (*.png)|*.png*";
            openFileDialog1.Filter = "Archivo de imagen (*.jpg, *.gif, *.Bmp, *.png)|*.jpg;*.gif;*.Bmp;*.png";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    System.IO.FileInfo f2 = new System.IO.FileInfo(openFileDialog1.FileName);


                            if ((myStream = openFileDialog1.OpenFile()) != null)
                            {
                                using (myStream)
                                {
                                    // MessageBox.Show(openFileDialog1.FileName); //ruta completa del archivo
                                    rutacompleta = openFileDialog1.FileName;

                                    nombrearchivo = openFileDialog1.SafeFileName;
                                         

                                    directorioactual = Path.GetDirectoryName(rutacompleta);


                        }
                            

                        
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Error: " + ex.Message);
                }
            }

        }
    }
}
