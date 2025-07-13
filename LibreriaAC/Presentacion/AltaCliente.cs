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
    public partial class AltaCliente : Form
    {
        private int _alta, _situacion, _clienteide;
        private string _iva, _cuit, _razonsocial, _domicilio, _telefono;
        Clientes cli = new Clientes();
        public AltaCliente()
        {
            InitializeComponent();
            this.inicio();
        }

        public void inicio()
        {
            Clientes cli = new Clientes();

            lookUpEdit1.Properties.DisplayMember = "TIPI_DESC";
            lookUpEdit1.Properties.ValueMember = "TIPI_IDE";
            lookUpEdit1.Properties.DataSource = cli.Tabladedatos_situacion();
            lookUpEdit1.Properties.PopulateColumns();
            if (lookUpEdit1.Properties.DataSource != null && ((DataTable)lookUpEdit1.Properties.DataSource).Rows.Count > 0)
            {
                lookUpEdit1.EditValue = ((DataTable)lookUpEdit1.Properties.DataSource).Rows[0]["TIPI_IDE"];
            }
        }

        public static bool Validate(string cuit)
        {
            //cuit = cuit.Replace("-", "");
            if (string.IsNullOrEmpty(cuit)) throw new ArgumentNullException(nameof(cuit));
            if (cuit.Length != 11) throw new ArgumentException(nameof(cuit));
            bool rv = false;
            int verificador;
            int resultado = 0;
            string cuit_nro = cuit.Replace("-", string.Empty);
            string codes = "6789456789";
            long cuit_long = 0;
            if (long.TryParse(cuit_nro, out cuit_long))
            {
                verificador = int.Parse(cuit_nro[cuit_nro.Length - 1].ToString());
                int x = 0;
                while (x < 10)
                {
                    int digitoValidador = int.Parse(codes.Substring((x), 1));
                    int digito = int.Parse(cuit_nro.Substring((x), 1));
                    int digitoValidacion = digitoValidador * digito;
                    resultado += digitoValidacion;
                    x++;
                }
                resultado = resultado % 11;
                rv = (resultado == verificador);
            }
            return rv;
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

            if (lookUpEdit1.EditValue == null || string.IsNullOrEmpty(lookUpEdit1.Text))
            {
                MessageBox.Show("Por favor seleccione tipo de Situación del cliente", "Advertencia",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lookUpEdit1.Focus();
                return; // Detener el proceso de guardado
            }
            else
            {

                //verifica si el cuit/cuil es válido.
                //bool valor = validateCuit(txtcuit.Text);
                bool valor = false;
                    if (txtcuit.Text.All(char.IsDigit))
                    {
                        if (txtcuit.Text.Length <= 8)
                        {
                            valor = true;
                        }
                        else if (txtcuit.Text.Length == 11)
                        {
                            valor = Validate(txtcuit.Text);
                        }
                
                    }
            


                    if (valor == true)
                    {
                        //si es válido, verifica que no exista ya cargado en la base de datos.
                        cli.Cuit = txtcuit.Text;
                        int valor1 = cli.spVersiexiste();
                        if (valor1 == 0 && this.Alta == 1)
                        {
                   
                           this.altaclien();
                   
                        }else if (valor1 > 0 && this.Alta == 0)
                        {
                            this.modificaclien();
                        }
                        else
                        {
                            MessageBox.Show("Ya está cargado este CUIT/DNI.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Verificar el CUIT/DNI por favor.");
                    }
            }
        }

        private void altaclien()
        {
            
            cli.Cuit = txtcuit.Text;
            cli.Razonsocial = txtrazonsocial.Text;
            cli.Domicilio = txtdomicilio.Text;
            cli.Telefono = txttelefono.Text;
            cli.Situacion = Convert.ToInt32(lookUpEdit1.EditValue);
            cli.Alta = this.Alta;
            int resultado = cli.spInsertarCliente();
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
            Clientes cli = new Clientes();
            cli.Cuit = txtcuit.Text;
            cli.Razonsocial = txtrazonsocial.Text;
            cli.Domicilio = txtdomicilio.Text;
            cli.Telefono = txttelefono.Text;
            cli.Situacion = Convert.ToInt32(lookUpEdit1.EditValue);
            cli.Clienteide = this.Clienteide;
            cli.Alta = this.Alta;
            int resultado = cli.spInsertarCliente();
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
                txtrazonsocial.Focus();
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
        public void colocardatos()
        {
            txtcuit.Text = this.Cuit;
            txtrazonsocial.Text = this.Razonsocial;
            txtdomicilio.Text = this.Domicilio;
            txttelefono.Text = this.Telefono;
            lookUpEdit1.EditValue = this.Situacion;
        }
        private void btnsubir_Click(object sender, EventArgs e)
        { }
    }
}
