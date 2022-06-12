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
namespace Presentacion
{
    public partial class AltaEditorial : Form
    {
        private int _alta, _situacion, _clienteide, _tipo, _usuide,_numero, _ide, _porcentaje;
        private string _iva, _cuit, _razonsocial, _domicilio, _telefono;
        private string _nombre, _nombrecompleto, _contra, _contravta;
        string _titulo, _calle, _localidad, _provincia, _cliente;
        public AltaEditorial()
        {
            InitializeComponent();
            this.inicio();
        }

        public void inicio()
        {
          /*  Clientes cli = new Clientes();

            lookUpEdit1.Properties.DisplayMember = "TIPI_DESC";
            lookUpEdit1.Properties.ValueMember = "TIPI_IDE";
            lookUpEdit1.Properties.DataSource = cli.Tabladedatos_situacion();
            lookUpEdit1.Properties.PopulateColumns();
            */
            
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (this.Alta == 1)
            {
                this.Altaeditorial();
            }
            else
            {
                this.modificaEditorial();
            }
        }

        public void colocardatosEdi()
        {
            txteditorial.Text = this.Titulo;
            txtcalle.Text = this.Calle;
            txtnumero.Text = Convert.ToString(this.Numero);
            txtporcentaje.Text = Convert.ToString(this.Porcentaje);
            txtlocalidad.Text = this.Localidad;
            txtprovincia.Text = this.Provincia;
            txttelefono.Text = this.Telefono;
            txtcuit.Text = this.Cuit;
            txtcliente.Text = this.Cliente;
            btnagregar.Text = "Modificar";
            this.Alta = 0;
        }

        private void Altaeditorial()
        {
            Editorial edi = new Editorial();
            edi.Titulo = (txteditorial.Text).ToUpper();
            if (txtcalle.Text == string.Empty)
            {
                edi.Calle = string.Empty;
            }
            else
            {
                edi.Calle = txtcalle.Text;
            }
            if (txtnumero.Text == string.Empty)
            {
                edi.Numero = 0;
            }
            else
            {
                edi.Numero = Convert.ToInt32(txtnumero.Text);
            }
            if (txtporcentaje.Text == string.Empty)
            {
                edi.Porcentaje = 0;
            }
            else
            {
                edi.Porcentaje = Convert.ToInt32(txtporcentaje.Text);
            }
            if (txtlocalidad.Text == string.Empty)
            {
                edi.Localidad = string.Empty;
            }
            else
            {
                edi.Localidad = txtlocalidad.Text;
            }
            if (txtprovincia.Text == string.Empty)
            {
                edi.Provincia = string.Empty;
            }
            else
            {
                edi.Provincia = txtprovincia.Text;
            }
            if (txttelefono.Text == string.Empty)
            {
                edi.Telefono = string.Empty;
            }
            else
            {
                edi.Telefono = txttelefono.Text;
            }
            if (txtcuit.Text == string.Empty)
            {
                edi.Cuit = string.Empty;
            }
            else
            {
                edi.Cuit = txtcuit.Text;
            }
            if (txtcliente.Text == string.Empty)
            {
                edi.Cliente = string.Empty;
            }
            else
            {
                edi.Cliente = txtcliente.Text;
            }
            edi.Alta = 1;
            int resultado = edi.spAgregarEditorial();
            if (resultado == 0)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                MessageBox.Show("Se ha guardado creado la Editorial!");
            }
            else
            {
                MessageBox.Show("Se ha producido un error!");
            }
        }

        private void modificaEditorial()
        {
            Editorial edi = new Editorial();
            edi.Titulo = txteditorial.Text;
            edi.Calle = txtcalle.Text;
            edi.Numero = Convert.ToInt32(txtnumero.Text);
            edi.Porcentaje = Convert.ToInt32(txtporcentaje.Text);
            edi.Localidad = txtlocalidad.Text;
            edi.Provincia = txtprovincia.Text;
            edi.Telefono = txttelefono.Text;
            edi.Cuit = txtcuit.Text;
            edi.Cliente = txtcliente.Text;
            edi.Alta = 0;
            edi.Ide = this.Ide;
            int resultado = edi.spModificarEditorial();
            if (resultado == 0)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                MessageBox.Show("Se ha Modificado la Editorial!");
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
                txtcalle.Focus();
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

        public int Usuide
        {
            get { return this._usuide; }
            set { this._usuide = value; }
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
            txteditorial.Text = this.Cuit;
            txtcalle.Text = this.Razonsocial;
            txtnumero.Text = this.Domicilio;
            txtlocalidad.Text = this.Telefono;
            
        }
        private void btnsubir_Click(object sender, EventArgs e)
        { }

        public void colocardatosdelusuario()
        {
            this.txteditorial.Text = this.Nombre;
            this.txtcalle.Text = this.NombreCompleto;
            this.txtnumero.Text = this.Contrase;
            this.txtlocalidad.Text = this.Contrasevta;
            
        }

        public int Ide
        {
            get { return this._ide; }
            set { this._ide = value; }
        }

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public string NombreCompleto
        {
            get { return this._nombrecompleto; }
            set { this._nombrecompleto = value; }
        }

        public string Contrase
        {
            get { return this._contra; }
            set { this._contra = value; }
        }

        public string Contrasevta
        {
            get { return this._contravta; }
            set { this._contravta = value; }
        }
        public int Tipo
        {
            get { return this._tipo; }
            set { this._tipo = value; }
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

        public string Cliente
        {
            get { return this._cliente; }
            set { this._cliente = value; }
        }
    }
}
