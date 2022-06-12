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
using System.Xml;
using System.Text.RegularExpressions;

namespace Presentacion
{
    public partial class AltaClienteCC : Form
    {
        private int _alta, _situacion, _clienteide;
        private string _iva, _cuit, _razonsocial, _domicilio, _telefono;
        Clientes cli = new Clientes();
        public AltaClienteCC()
        {
            InitializeComponent();
            this.inicio();
        }

        public void inicio()
        {
           
        }

        private bool validateCuit(string Cuit)
        {
            Regex rg = new Regex("[A-Z_a-z]");
            Cuit = Cuit.Replace("-", "");
            if (rg.IsMatch(Cuit))
                return false;
            if (Cuit.Length != 11)
                return false;
            char[] cuitArray = Cuit.ToCharArray();
            double sum = 0;
            int bint = 0;
            int j = 7;
            for (int i = 5, c = 0; c != 10; i--, c++)
            {
                if (i >= 2)
                    sum += (Char.GetNumericValue(cuitArray[c]) * i);
                else
                    bint = 1;
                if (bint == 1 && j >= 2)
                {
                    sum += (Char.GetNumericValue(cuitArray[c]) * j);
                    j--;
                }
            }
            if ((cuitArray.Length - (sum % 11)) == Char.GetNumericValue(cuitArray[cuitArray.Length - 1]))
                return true;
            return false;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            int valor1=0;
            //verifica si el cuit/cuil es válido.
            //si es válido, verifica que no exista ya cargado en la base de datos.
            cli.Dni = Convert.ToInt32(txtdni.Text);
                cli.Nombre = txtnombre.Text;
                cli.Domicilio = txtdomicilio.Text;
                cli.Telefono = txttelefono.Text;
                cli.Clienteide = Clienteide;
                if (this.Alta == 1)
                {
                    valor1 = cli.spVersiexisteCC();
                }
                if (valor1 == 0)
                {
                    if (this.Alta == 1)
                    {
                        this.altaclien();
                    }
                    else
                    {
                        this.modificaclien();
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe un cliente cargado con el mismo DNI...");
                }
        }

        private void altaclien()
        {

            cli.Alta = this.Alta;
            int resultado = cli.spInsertarClienteCC();
            if (resultado == 0)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                MessageBox.Show("Se ha guardado el cliente!");
            }
            else
            {
                MessageBox.Show("Se ha producido un error!");
            }
        }

        private void modificaclien()
        {
            cli.Alta = this.Alta;
            int resultado = cli.spInsertarClienteCC();
            if (resultado == 0)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                MessageBox.Show("Se ha modificado el cliente!");
            }
            else
            {
                MessageBox.Show("Se ha producido un error!");
            }
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

        }

        private void txttitulo_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtnombre.Focus();
            }
        }

        private void txtautor_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
        }

        private void txtprecio_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
          
        }

        private void txtcantidad_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
           
        }

        private void txtfactura_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
           
        }

        private void txtisbn_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {

        }

        private void txtbarra_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
           
        }

        private void txtcuerpo_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {

        }

        private void txtestante_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
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
           
        }

        

        private void lUporcentaje_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
          
        }

        private void lUporcentaje_EditValueChanged(object sender, EventArgs e)
        {
           
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

        public string Cuit
        {
            get { return this._cuit; }
            set { this._cuit = value; }
        }
        public string Razonsocial
        {
            get { return this._razonsocial; }
            set { this._razonsocial = value; }
        }
        public string Domicilio
        {
            get { return this._domicilio; }
            set { this._domicilio = value; }
        }
        public string Telefono
        {
            get { return this._telefono; }
            set { this._telefono = value; }
        }
        public int Situacion
        {
            get { return this._situacion; }
            set { this._situacion = value; }
        }
        public int Clienteide
        {
            get { return this._clienteide; }
            set { this._clienteide = value; }
        }
        public void colocardatos(Clientes cl)
        {
            txtdni.Text = Convert.ToString(cl.Dni);
            txtnombre.Text = cl.Nombre;
            txtdomicilio.Text = cl.Domicilio;
            txttelefono.Text = cl.Telefono;
            Clienteide = cl.Clienteide;
        }
        private void btnsubir_Click(object sender, EventArgs e)
        { }
    }
}
