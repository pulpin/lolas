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
    public partial class AltaProducto : Form
    {
        private int tipopro = 0, _alta, _producide;
        string _codigo,_preciosinmodi;
        OpenFileDialog openFileDialog1;
        private string rutacompleta, nombrearchivo, directorioactual, _iva;
        
        public AltaProducto()
        {
            InitializeComponent();

        }


        private void modificaproduc()
        {
            string imagenconide=string.Empty;
            string extension;
            Productos pro = new Productos();
            pro.productoide = Producide;
            pro.Titulo = txttitulo.Text;
            pro.Autor = "";
            pro.Editorial = Convert.ToInt32(lUEditorial.EditValue);
            pro.Editorial = Convert.ToInt32(lUEditorial.EditValue);
            pro.Genero = Convert.ToInt32(LUgenero.EditValue);
            pro.Codigo = this.Codigo;
            
            txtprecio.Text = txtprecio.Text.Replace(",", ".");
            pro.Preciosinmodificar = this._preciosinmodi;
            pro.Precio = txtprecio.Text;
            pro.Codigoprovee = txtcodprovee.Text;
            pro.Dividido = Convert.ToInt32(txtdividido.Text);
            if (txtcantidad.Text != string.Empty)
            {
                pro.Cantidad = Convert.ToInt32(txtcantidad.Text);
                pro.Factura = txtfactura.Text;
            }
            else
            {
                pro.Cantidad = 0;
            }
            pro.Codigo = this.Codigo;
            txtcosto.Text = txtcosto.Text.Replace(",", ".");
            pro.Costo = txtcosto.Text;
            //txtiva.Text = txtiva.Text.Replace(",", ".");
            // pro.Iva = txtiva.Text;
            pro.Iva = Convert.ToString(lUporcentaje.EditValue);
            txtporcentaje.Text = txtporcentaje.Text.Replace(",", ".");
            pro.Ganancia = txtporcentaje.Text;
            pro.Isbn = txtisbn.Text;
            pro.Barra = txtbarra.Text;
            if ((nombrearchivo != string.Empty)&& (nombrearchivo != null))
            {
                extension = Path.GetExtension(nombrearchivo);
                pro.Codigo = pro.Codigo.Replace(" ", String.Empty);
                //pro.Imagen = nombrearchivo;
                imagenconide = pro.Codigo + extension;
                pro.Imagen = imagenconide;
            }
            pro.Tipo = this.tipopro;
            pro.Cuerpo = txtcuerpo.Text;
            pro.Estante = txtestante.Text;
            int retorno = pro.spModificarProducto();
            if (retorno == 0)
            {

                if (rutacompleta != null)
                {
                    /* var carpeta = @"\\10.1.10.198\Utilidadeslolasdb\libros\";

                     var archivoacopiar = System.IO.Path.Combine(carpeta, nombrearchivo);

                     string directorioacopiar = Directory.GetCurrentDirectory();


                     pro.Codigo = pro.Codigo.Replace(" ", String.Empty);
                     string archivoarenombrar = directorioacopiar + "\\libros\\" + imagenconide;

                     System.IO.File.Copy(rutacompleta, archivoacopiar, true);
                     System.IO.File.Move(archivoacopiar, archivoarenombrar);*/
                    var carpeta = @"\\10.1.10.198\Utilidadeslolasdb\libros\";

                    string directorioacopiar = Directory.GetCurrentDirectory();
                    // string archivoacopiar = directorioacopiar + "\\libros\\" + nombrearchivo;
                    pro.Codigo = pro.Codigo.Replace(" ", String.Empty);
                    string archivoarenombrar = directorioacopiar + "\\libros\\" + imagenconide;
                    //string archivoacopiar = directorioacopiar + "\\libros\\" + pro.Codigo;

                    // System.IO.File.Move(archivoacopiar, archivoarenombrar);
                   // pro.Codigo = retorno;
                    pro.spConsultaideporcodigo(pro.Codigo);
                    int liide = pro.productoide;
                    pro.Titulo = liide + imagenconide;
                    pro.spModificarNombreImagen(liide);
                    var archi = liide + imagenconide;
                    var archivoacopiar = System.IO.Path.Combine(carpeta, archi);
                    System.IO.File.Copy(rutacompleta, archivoacopiar, true);
                }
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                MessageBox.Show("Se ha modificado con éxito!");

            }
            else
            {
                MessageBox.Show("Hubo un problema, por favor intentelo de nuevo.");
            }
        }

        private void altaproduc()
        {
            string imagenconide = string.Empty;
            string extension;
            Productos pro = new Productos();
            pro.Titulo = (txttitulo.Text).ToUpper();
            pro.Autor = "";
            pro.Editorial = Convert.ToInt32(lUEditorial.EditValue);
            pro.Genero = Convert.ToInt32(LUgenero.EditValue);

            txtprecio.Text = txtprecio.Text.Replace(",", ".");
            pro.Precio = txtprecio.Text;

            pro.Cantidad = Convert.ToInt32(txtcantidad.Text);

            txtcosto.Text = txtcosto.Text.Replace(",", ".");
            pro.Costo = txtcosto.Text;
            pro.Dividido = Convert.ToInt32(txtdividido.Text);

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
                //pro.Imagen = nombrearchivo;
                extension = Path.GetExtension(nombrearchivo);
                pro.Codigo = pro.Codigo.Replace(" ", String.Empty);
                //pro.Imagen = nombrearchivo;
                imagenconide = pro.Codigo + extension;
                pro.Imagen = imagenconide;

            }
            pro.Tipo = this.tipopro;
            pro.Cuerpo = txtcuerpo.Text;
            pro.Estante = txtestante.Text;
            pro.Codigoprovee = txtcodprovee.Text;
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
            lbletra.Visible = true;
            txtdividido.Visible = true;
            lbdividido.Visible = true;
        }
        private void desactivariva()
        {
            //this.tipopro = 0;
            paneliva.Visible = false;
            lbletra.Visible = false;
            txtdividido.Visible = false;
            lbdividido.Visible = false;
        }

        private void rbartesco_CheckedChanged(object sender, EventArgs e)
        {
            this.tipopro = 1;
            lbletra.Text = "L";
            this.activariva();
            Genero gen = new Genero();
            gen.EsLibro = this.tipopro;
            LUgenero.Properties.DisplayMember = "GEN_DESC";
            LUgenero.Properties.ValueMember = "GEN_IDE";
            LUgenero.Properties.DataSource = gen.Tabladedatos_generos();
            LUgenero.Properties.PopulateColumns();
            //LUgenero.Properties.Columns[0].Visible = false;
            //LUgenero.Properties.Columns[2].Visible = false;
        }

        private void rbmarro_CheckedChanged(object sender, EventArgs e)
        {
            this.tipopro = 2;
            lbletra.Text = "M";
            this.activariva();
            Genero gen = new Genero();
            gen.EsLibro = 1;
            LUgenero.Properties.DisplayMember = "GEN_DESC";
            LUgenero.Properties.ValueMember = "GEN_IDE";
            LUgenero.Properties.DataSource = gen.Tabladedatos_generos();
            LUgenero.Properties.PopulateColumns();
           // LUgenero.Properties.Columns[0].Visible = false;
           // LUgenero.Properties.Columns[2].Visible = false;
        }

        private void rbdida_CheckedChanged(object sender, EventArgs e)
        {
            this.tipopro = 3;
            lbletra.Text = "D";
            this.activariva();
            Genero gen = new Genero();
            gen.EsLibro = 1;
            LUgenero.Properties.DisplayMember = "GEN_DESC";
            LUgenero.Properties.ValueMember = "GEN_IDE";
            LUgenero.Properties.DataSource = gen.Tabladedatos_generos();
            LUgenero.Properties.PopulateColumns();
            //LUgenero.Properties.Columns[0].Visible = false;
            //LUgenero.Properties.Columns[2].Visible = false;
        }

        private void AltaProducto_Load(object sender, EventArgs e)
        {
            this.tipopro = 1;
            Editorial edi = new Editorial();

            lUEditorial.Properties.DisplayMember = "EDI_EDITORIAL";
            lUEditorial.Properties.ValueMember = "EDI_CODIGO";
            lUEditorial.Properties.DataSource = edi.Tabladedatos_editoriales();
            lUEditorial.Properties.PopulateColumns();
            lUEditorial.Properties.Columns[0].Visible = false;

            Genero gen = new Genero();
            gen.EsLibro = this.tipopro;
            LUgenero.Properties.DisplayMember = "GEN_DESC";
            LUgenero.Properties.ValueMember = "GEN_IDE";
            LUgenero.Properties.DataSource = gen.Tabladedatos_generos();
            LUgenero.Properties.PopulateColumns();
            LUgenero.Properties.Columns[0].Visible = false;
            LUgenero.Properties.Columns[2].Visible = false;


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
            if ((LogicaNegocios.Globales.accessocuerpoestante == 1)||(LogicaNegocios.Globales.accessocuerpoestante == 2))
            {
                bloqueoporcuerpoyestante();
            }
            if ((LogicaNegocios.Globales.accesomodificartitulo == 1) || (LogicaNegocios.Globales.accesomodificartitulo == 2))
            {
                desbloqueotitulo();
            }
            
        }
        private void bloqueoporcuerpoyestante()
        {
            txttitulo.Enabled = false;
            //txtautor.Enabled = false;
            lUEditorial.Enabled = false;
            LUgenero.Enabled = false;
            txtdividido.Enabled = false;
            txtprecio.Enabled = false;
            paneliva.Enabled = false;
            txtcantidad.Enabled = false;
            txtfactura.Enabled = false;
            txtisbn.Enabled = false;
            txtbarra.Enabled = false;
            txtcodprovee.Enabled = false;
        }
        private void desbloqueotitulo()
        {
            txttitulo.Enabled = true;
            //txtautor.Enabled = true;
            lUEditorial.Enabled = true;
            LUgenero.Enabled = true;
        }
        private void txttitulo_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //txtautor.Focus();
                lUEditorial.Focus();
            }
        }

        private void txtautor_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lUEditorial.Focus();
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
                txtisbn.Focus();
            }
        }

        private void txtisbn_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtbarra.Focus();
            }
        }

        private void txtbarra_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcuerpo.Focus();
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
            Genero gen = new Genero();
            gen.EsLibro = pro.Tipopro;
            this.tipopro = pro.Tipopro;
            
            LUgenero.Properties.DisplayMember = "GEN_DESC";
            LUgenero.Properties.ValueMember = "GEN_IDE";
            LUgenero.Properties.DataSource = gen.Tabladedatos_generos();
            LUgenero.Properties.PopulateColumns();
            // LUgenero.Properties.Columns[0].Visible = false;
            
            Producide = pro.productoide;
            txttitulo.Text = pro.Titulo;
           //txtautor.Text = pro.Autor;
            lUEditorial.EditValue = pro.Editorial;
            LUgenero.EditValue = pro.Genero;
            this._preciosinmodi = pro.Precio.Replace(",", ".");
            txtprecio.Text = pro.Precio.Replace(",", ".");
            if (pro.Precioanterior == null)
            {
                lbprecioanterior.Text = string.Empty;
            }
            else
            { 
                lbprecioanterior.Text = pro.Precioanterior.Replace(",", ".");
            }
            txtcodprovee.Text = pro.Codigoprovee;
            txtisbn.Text = pro.Isbn;
            txtbarra.Text = pro.Barra;
            txtcuerpo.Text = pro.Cuerpo;
            txtestante.Text = pro.Estante;
            lbstockactual.Text = pro.Stock;
            txtcodprovee.Text = pro.Codigoprovee;
            this.Codigo = pro.Codigo;
            txtdividido.Text = Convert.ToString(pro.Dividido);
            if (pro.Tipo > 0)
            {
                txtcosto.Text = pro.Costo.Replace(",", ".");
                pro.Iva = pro.Iva.Replace(",", ".");
                this.Iva = pro.Iva;
                //lUporcentaje.EditValue = pro.Iva;

                txtporcentaje.Text = pro.Ganancia.Replace(",", ".");
                if (tipopro == 1)
                {
                    rbartesco.Checked = true;
                }
                else if (tipopro == 2)
                {
                    rbmarro.Checked = true;
                }
                else
                {
                    rbdida.Checked = true;
                }
            }
            lbletra.Text = pro.Codigo;
            lbletra.Visible = true;

            string path = Directory.GetCurrentDirectory();
            if (pro.Imagen != string.Empty)
            {
                var carpeta = @"\\10.1.10.198\Utilidadeslolasdb\";
                string fullpath = System.IO.Path.Combine(carpeta, string.Format("libros\\{0}", pro.Imagen));
                pbimagen.Image = new System.Drawing.Bitmap(fullpath);

            }
            else
            {
                pbimagen.Image = Presentacion.Properties.Resources.no_disponible;
            }

            gBtipopro.Enabled = false;
            btnagregar.Text = "Modificar";
            pro.spConsultaUsuarios();
            
            if (pro.Usuariodiodealta != "")
            {
                lbusuarioalta.Text = pro.Usuariodiodealta;
                lbfechaalta.Text = pro.Fechadiodealta;
            }
            if (pro.Usuariomodifico != "")
            {
                lbmodificado.Text = pro.Usuariomodifico;
                lbfechamodificado.Text = pro.Fechausumodi;
            }
               

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

        private void btnlugares_Click(object sender, EventArgs e)
        {
            ConsultasLugares cl = new ConsultasLugares();
            cl.Codigo =lbletra.Text;
            cl.colocarcodigo();
            cl.ShowDialog();
        }

        private void txttitulo_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("adfd");
        }

        private void txttitulo_Leave(object sender, EventArgs e)
        {
            string[] words = txttitulo.Text.Split(' ');
            //MessageBox.Show(words[0]);
            txtcodprovee.Text = words[0];
        }

        private void rblibro_CheckedChanged(object sender, EventArgs e)
        {
            //this.desactivariva();
            this.tipopro = 1;
            
            this.activariva();
            Genero gen = new Genero();
            //gen.EsLibro = this.tipopro;
            //gen.EsLibro = produc.Tipopro;
            LUgenero.Properties.DisplayMember = "GEN_DESC";
            LUgenero.Properties.ValueMember = "GEN_IDE";
            LUgenero.Properties.DataSource = gen.Tabladedatos_generos();
            LUgenero.Properties.PopulateColumns();
           // LUgenero.Properties.Columns[0].Visible = false;
           // LUgenero.Properties.Columns[2].Visible = false;
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
        public string Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
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
                                    pbimagen.Image = Image.FromFile(openFileDialog1.FileName);



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
