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
    public partial class AltaProductoConsigna : Form, IproductoConsigna
    {
        private int tipopro = 0, _alta,_codigoconsigma, _codigoeditorial;
        private string _iva, _codigo;
        public AltaProductoConsigna()
        {
            InitializeComponent();

        }


        private void modificaproduc()
        {
            Productos pro = new Productos();
            
            pro.Titulo = txttitulo.Text;
            pro.Autor = txtautor.Text;


            txtprecio.Text = txtprecio.Text.Replace(",", ".");
            pro.Precio = txtprecio.Text;

            if (txtcantidad.Text != string.Empty)
            {
                pro.Cantidad = Convert.ToInt32(txtcantidad.Text);
                pro.Factura = txtfactura.Text;
            }
            else
            {
                pro.Cantidad = 0;
            }
            
            

            
            pro.Isbn = txtisbn.Text;
            pro.Barra = txtbarra.Text;
           
            pro.Tipo = this.tipopro;
          
            int retorno = pro.spModificarProducto();
            if (retorno == 0)
            {

               
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                MessageBox.Show("Se ha modificado con éxito!");

            }
            else
            {
                MessageBox.Show("Hubo un problema, por favor intentelo de nuevo.");
            }
        }

        public void altaproduc()
        {
            Consignas con = new Consignas();
            con.Codigo = this.Codigo;
            con.Cantidad = Convert.ToInt32(txtcantidad.Text);
            txtprecio.Text = txtprecio.Text.Replace(",", ".");

            txtfactura.Text = txtfactura.Text.Replace(",", ".");
            //pro.Precio = txtprecio.Text;
            if (!txtfactura.Text.Equals(txtprecio.Text))
            {
                if (MessageBox.Show("¿Desea modificar el precio del producto en el catálogo?", "Precio diferente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    con.ModificaprecioCatalogo = 1;
                }
                else
                {
                    con.ModificaprecioCatalogo = 0;
                }
                   
            }

            con.Precio = txtfactura.Text;
            con.Codigoconsig = this.CodigoConsignaM;
            con.Codigoeditorial = this.CodigoEditorial;
            int cantidadreservas = con.spControlarReserva();
            if (cantidadreservas > 0)
            {
                MessageBox.Show("Posee RESERVAS de este libro. Cantidad: " + cantidadreservas, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            int retorno = con.spInsertarConsignaDetalle();
            if (retorno == 0)
            {

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                MessageBox.Show("Se ha dado de alta con éxito!");
            }
            else if (retorno == 2)
            {
                MessageBox.Show("Ya existe ese producto en la consigna!");
            }
            else
            {
                MessageBox.Show("Hubo un problema, por favor intentelo de nuevo.");
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

                this.altaproduc();


        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

      

        private void rbartesco_CheckedChanged(object sender, EventArgs e)
        {
     
        }

        private void rbmarro_CheckedChanged(object sender, EventArgs e)
        {
         

        }

        private void rbdida_CheckedChanged(object sender, EventArgs e)
        {
       
        }

        private void AltaProducto_Load(object sender, EventArgs e)
        {
            //txtbarra.Focus();
        }

        private void AltaProducto_Activated(object sender, EventArgs e)
        {
            txtbarra.Focus();
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
                //txtfactura.Focus();
                btnagregar.Focus();
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

        private void enviar(string valor, int tipo)
        {
            //buscar acá
            Productos pro = new Productos();
            pro.Tipo = tipo;
            pro.spConsultaProductoConsigna(valor);
            txttitulo.Text = pro.Titulo;
            txtprecio.Text = pro.Precio;
            txtfactura.Text = pro.Precio;
            
            txtautor.Text = pro.Autor;
            txtecodigointed.Text = pro.Codigointernoeditorial;
            txtexistencia.Text = pro.Stock;
            txtisbn.Text = pro.Isbn;
            this.Codigo = pro.Codigo;
            txtbarra.Text = "";
            if (Convert.ToInt32(pro.Stock) < 0)
            {
                MessageBox.Show("El producto posee stock negativo, no se puede agregar a la consigna");
                btnagregar.Enabled = false;
            }
            else
            {
                btnagregar.Enabled = true;
            }
        }

        private void txtbarra_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.enviar(txtbarra.Text, 0);
                txtcantidad.Focus();
            }
        }

        private void txtcodigo_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.enviar(txtcodigo.Text, 1);
                txtcantidad.Focus();
            }
        }

        private void txtcuerpo_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {

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
            
        }

        private void txtcosto_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            
        }

        private void txtiva_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
           
        }

        private void txtporcentaje_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calcularcosto();
                txtcantidad.Focus();
            }
        }

        
        private void lUporcentaje_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            
        }

        private void lUporcentaje_EditValueChanged(object sender, EventArgs e)
        {
            calcularcosto();
        }

        private void btnbuscaportitulo_Click(object sender, EventArgs e)
        {
            ConsultaProductosAgregaC cpa = new ConsultaProductosAgregaC();
            cpa.ShowDialog(this);
            txtcantidad.Focus();
        }

        private void rblibro_CheckedChanged(object sender, EventArgs e)
        {
            
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

        public string Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }

        public int CodigoConsignaM
        {
            get { return this._codigoconsigma; }
            set { this._codigoconsigma = value; }
        }

        private void AltaProductoConsigna_Activated(object sender, EventArgs e)
        {
            txtbarra.Focus();
        }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {

        }

        public int CodigoEditorial
        {
            get { return this._codigoeditorial; }
            set { this._codigoeditorial = value; }
        }
        public void posicionarse()
        {
            txtbarra.Focus();
        }
        private void btnsubir_Click(object sender, EventArgs e)
        {
           



        }


        public void AgregaProductoC(string tituloi, string precioi, string autori, string codediinternoi, string existenciai, string isbni, string producide)
        {
            txttitulo.Text = tituloi;
            txtautor.Text = autori;
            txtprecio.Text = precioi;
            txtecodigointed.Text = codediinternoi;
            txtexistencia.Text = existenciai;
            txtisbn.Text = isbni;
            this.Codigo = producide;
        }
    }
}
