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

namespace Presentacion
{
    public partial class AltaCredito : Form
    {
        private int tipopro = 0, _alta, _ide;
        string _codigo, _preciosinmodi, _titulo, _editorial, _rubro, _costo, _distribucion, _contado, _financiado, _diez, _ocho,_seis;
        OpenFileDialog openFileDialog1;
        private string rutacompleta, nombrearchivo, directorioactual, _iva;
        
        public AltaCredito()
        {
            InitializeComponent();

        }


        private void modificaproduc()
        {
            Credito cre = new Credito();
           
            
          //  pro.Codigo = this.Codigo;
            
            txtcosto.Text = txtcosto.Text.Replace(",", ".");
            txtdistribucion.Text = txtdistribucion.Text.Replace(",", ".");
            txtcontado.Text = txtcontado.Text.Replace(",", ".");
            txtfinanciado.Text = txtfinanciado.Text.Replace(",", ".");
            txtdiez.Text = txtdiez.Text.Replace(",", ".");
            txtocho.Text = txtocho.Text.Replace(",", ".");
            txtseis.Text = txtseis.Text.Replace(",", ".");
            cre.Costo = txtcosto.Text;
            cre.Distribucion = txtdistribucion.Text;
            cre.Contado = txtcontado.Text;
            cre.Financiado = txtfinanciado.Text;
            cre.Seis = txtseis.Text;
            cre.Ocho = txtocho.Text;
            cre.Diez = txtdiez.Text;
            cre.Ide = this.Ide;



            int retorno = cre.spModificarEditorial();
            if (retorno == 0)
            { 
                MessageBox.Show("Se actualizó el precio");
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void altaproduc()
        {
            string imagenconide = string.Empty;
            string extension;
            Productos pro = new Productos();
            pro.Titulo = (txttitulo.Text).ToUpper();
          

            //txtiva.Text = txtiva.Text.Replace(",", ".");

            // pro.Iva = txtiva.Text;
          
            if (nombrearchivo != string.Empty)
            {
                //pro.Imagen = nombrearchivo;
                extension = Path.GetExtension(nombrearchivo);
                pro.Codigo = pro.Codigo.Replace(" ", String.Empty);
                //pro.Imagen = nombrearchivo;
                imagenconide = pro.Codigo + extension;
                pro.Imagen = imagenconide;

            }
            pro.Tipo = this.tipopro;
            
            string retorno = pro.spInsertarProducto();
            if (retorno != "error")
            {

                if (rutacompleta != null)
                {
                    
                    var carpeta = @"\\10.1.10.198\Utilidadeslolasdb\libros\";
                    
                    

                    
                    string directorioacopiar = Directory.GetCurrentDirectory();
                   // string archivoacopiar = directorioacopiar + "\\libros\\" + nombrearchivo;
                    pro.Codigo = pro.Codigo.Replace(" ", String.Empty);
                    string archivoarenombrar = directorioacopiar + "\\libros\\" + imagenconide;
                    //string archivoacopiar = directorioacopiar + "\\libros\\" + pro.Codigo;
                    
                    // System.IO.File.Move(archivoacopiar, archivoarenombrar);
                    pro.Codigo = retorno;
                    pro.spConsultaideporcodigo(retorno);
                    int liide = pro.productoide;
                    pro.Titulo = liide + imagenconide;
                    pro.spModificarNombreImagen(liide);
                    var archi = liide + imagenconide;
                    var archivoacopiar = System.IO.Path.Combine(carpeta, archi);
                    System.IO.File.Copy(rutacompleta, archivoacopiar, true);
                }
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                MessageBox.Show("Se ha dado de alta con éxito: "+retorno);
            }
            else
            {
                MessageBox.Show("Hubo un problema, por favor intentelo de nuevo.");
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            
                this.modificaproduc();
            
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

       

        private void rbartesco_CheckedChanged(object sender, EventArgs e)
        {
            this.tipopro = 1;
           
            //LUgenero.Properties.Columns[0].Visible = false;
            //LUgenero.Properties.Columns[2].Visible = false;
        }

        private void rbmarro_CheckedChanged(object sender, EventArgs e)
        {
         
           // LUgenero.Properties.Columns[0].Visible = false;
           // LUgenero.Properties.Columns[2].Visible = false;
        }

        private void rbdida_CheckedChanged(object sender, EventArgs e)
        {
          
            //LUgenero.Properties.Columns[0].Visible = false;
            //LUgenero.Properties.Columns[2].Visible = false;
        }

        private void AltaProducto_Load(object sender, EventArgs e)
        {
            Editorial edi = new Editorial();

           
            Genero gen = new Genero();
            gen.EsLibro = this.tipopro;
           


            PorcenIVA pori = new PorcenIVA();
            if (LogicaNegocios.Globales.accesocredito == 2)
            {
                btnagregar.Enabled = true;
            }

            }
        
        
        private void txttitulo_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              
            }
        }

        private void txtautor_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               
            }
        }

        

        private void txtcantidad_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
            }
        }

        private void txtfactura_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               
            }
        }

        private void txtisbn_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
            }
        }

        private void txtbarra_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
            }
        }
        private void calcularvalor()
        {
           /* txtfinanciado.Text = txtfinanciado.Text.Replace(",", ".");
            txtcosto.Text = txtcosto.Text.Replace(",", ".");
            txtdistribucion.Text = txtdistribucion.Text.Replace(",", ".");
            txtcontado.Text = txtcontado.Text.Replace(",", ".");
            txtdiez.Text = txtdiez.Text.Replace(",", ".");
            txtocho.Text = txtocho.Text.Replace(",", ".");
            txtseis.Text = txtseis.Text.Replace(",", ".");*/
            // MessageBox.Show("valor: "+txtcosto.Text);
            txtfinanciado.Text = Convert.ToString(Convert.ToDouble(txtcosto.Text) * Convert.ToDouble(txtcalfin.Text));
            txtcontado.Text = Convert.ToString(Convert.ToDouble(txtfinanciado.Text) - (Convert.ToDouble(txtfinanciado.Text) * Convert.ToDouble(txtcalcon.Text) / 100));
            txtdistribucion.Text = Convert.ToString(Convert.ToDouble(txtcosto.Text) + (Convert.ToDouble(txtcosto.Text) * Convert.ToDouble(txtcaldis.Text)/100));
            txtdiez.Text = Convert.ToString(Convert.ToDouble(txtfinanciado.Text) / 10);
            txtocho.Text = Convert.ToString(Convert.ToDouble(txtfinanciado.Text) / 8);
            txtseis.Text = Convert.ToString(Convert.ToDouble(txtfinanciado.Text) / 6);
        }
        private void txtcosto_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.calcularvalor();
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
            if (txtseis.Text != string.Empty )
            {
                decimal costo = Convert.ToDecimal(txtseis.Text, CultureInfo.CreateSpecificCulture("en-US"));
                
                
                // double centecimo = 0.5;
                // valorfinal = centecimo + valorfinal;
                // valorfinal = Math.Truncate(centecimo + valorfinal);
                
                
            }
        }

        

        private void txtiva_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calcularcosto();
                //txtporcentaje.Focus();
            }
        }

        private void txtporcentaje_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calcularcosto();
               // txtcantidad.Focus();
            }
        }

        public void colocardatos()
        {
           
            txttitulo.Text = this.Titulo;
            txteditorial.Text = this.Editorial;
            txtrubro.Text = this.Rubro;
            txtcosto.Text = this.Costo;
            txtdistribucion.Text = this.Distribucion;
            txtcontado.Text = this.Contado;
            txtfinanciado.Text = this.Financiado;
            txtdiez.Text = this.Diez;
            txtocho.Text = this.Ocho;
            txtseis.Text = this.Seis;
           //this._preciosinmodi = pro.Precio.Replace(",", ".");
           // txtprecio.Text = pro.Precio.Replace(",", ".");
            
          
           
        }

        private void txtcosto_TextChanged(object sender, EventArgs e)
        {
            this.calcularvalor();
        }

        private void txtcosto_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtcosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtdistribucion_TextChanged(object sender, EventArgs e)
        {
            //this.calcularvalor();
        }

        private void txtcontado_TextChanged(object sender, EventArgs e)
        {
            //this.calcularvalor();
        }

        private void txtfinanciado_TextChanged(object sender, EventArgs e)
        {
            //this.calcularvalor();
        }

        private void txtdistribucion_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtdistribucion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void lUporcentaje_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              
            }
        }

        private void lUporcentaje_EditValueChanged(object sender, EventArgs e)
        {
            calcularcosto();
        }

        private void rblibro_CheckedChanged(object sender, EventArgs e)
        {
           
            Genero gen = new Genero();
            gen.EsLibro = this.tipopro;
            //gen.EsLibro = produc.Tipopro;
           
           // LUgenero.Properties.Columns[0].Visible = false;
           // LUgenero.Properties.Columns[2].Visible = false;
        }
        public int Ide
        {
            get { return this._ide; }
            set { this._ide = value; }
        }
        public int Alta
        {
            get { return this._alta; }
            set { this._alta = value; }
        }

        public string Titulo
        {
            get { return this._titulo; }
            set { this._titulo = value; }
        }

        public string Editorial
        {
            get { return this._editorial; }
            set { this._editorial = value; }
        }
        public string Rubro
        {
            get { return this._rubro; }
            set { this._rubro = value; }
        }

        public string Costo
        {
            get { return this._costo; }
            set { this._costo = value; }
        }

        public string Distribucion
        {
            get { return this._distribucion; }
            set { this._distribucion = value; }
        }
        public string Contado
        {
            get { return this._contado; }
            set { this._contado = value; }
        }
        public string Financiado
        {
            get { return this._financiado; }
            set { this._financiado = value; }
        }
        public string Diez
        {
            get { return this._diez; }
            set { this._diez = value; }
        }
        public string Ocho
        {
            get { return this._ocho; }
            set { this._ocho = value; }
        }
        public string Seis
        {
            get { return this._seis; }
            set { this._seis = value; }
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
