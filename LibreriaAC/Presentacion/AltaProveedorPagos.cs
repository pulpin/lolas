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
    public partial class AltaProveedorPagos : Form
    {
        private int _alta, _situacion, _clienteide, _tipo, _usuide,_numero, _ide, _porcentaje, _eslibro, _local, _proveeide,_cuenta;
        private string _iva, _cuit, _razonsocial, _domicilio, _telefono;
        private string _nombre, _nombrecompleto, _contra, _contravta;
        string _titulo, _calle, _localidad, _provincia, _cliente;
        Adopcion ado = new Adopcion();
        public AltaProveedorPagos()
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
                this.Altaproveedor();
            }
            else
            {
                this.modificaProveedor();
            }
        }

        public void colocardatosEdi()
        {
            txtproveedor.Text = this.Titulo;
           
            btnagregar.Text = "Modificar";
            
            this.Alta = 0;
        }

        private void Altaproveedor()
        {
      
            Adopcion ado = new Adopcion();
            ado.Local = this.Local;
            ado.Proveedornombre = (txtproveedor.Text).ToUpper();
            ado.Proveedoranombre = (txtanombrede.Text).ToUpper();
            ado.Proveedire = (txtdireccion.Text).ToUpper(); ;
            ado.Proveemail = txtmail.Text;
            ado.Proveeobs = rTobs.Text;
            ado.Proveebanco = Convert.ToInt32(lUBanco.EditValue);
            ado.Proveecc = txtcc.Text;
            ado.Proveeca = txtca.Text;
            ado.Proveetitular = (txttitular.Text).ToUpper();
            ado.Proveecbu = txtcbu.Text;
            ado.Proveecuit = txtcuit.Text;


            ado.Alta = 1;
            int resultado = ado.spAgregarProveedor();
            
            if (resultado != 0)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                MessageBox.Show("Se ha creado el Proveedor!");
            }
            else
            {
                MessageBox.Show("Se ha producido un error!");
            }
        }

        private void modificaProveedor()
        {
            //Adopcion ado = new Adopcion();
            ado.Local = this.Local;
            ado.Proveedornombre = (txtproveedor.Text).ToUpper();
            ado.Proveedoranombre = (txtanombrede.Text).ToUpper();
            ado.Proveedire = (txtdireccion.Text).ToUpper();
            ado.Proveetele = txttelefono.Text;
            ado.Proveemail = txtmail.Text;
            ado.Proveeobs = rTobs.Text;
            ado.Proveebanco = Convert.ToInt32(lUBanco.EditValue);
            ado.Proveecc = txtcc.Text;
            ado.Proveeca = txtca.Text;
            ado.Proveetitular = (txttitular.Text).ToUpper();
            ado.Proveecbu = txtcbu.Text;
            ado.Proveecuit = txtcuit.Text;
            ado.Proveeide = this.Proveedoride;
            ado.Proveecuentaide = this.Cuenta;

            ado.Alta = 0;
            int resultado = ado.spAgregarProveedor();

            if (resultado == 0)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                MessageBox.Show("Se ha modificado el Proveedor!");
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
           
            lUBanco.Properties.DisplayMember = "banco_desc";
            lUBanco.Properties.ValueMember = "banco_ide";
            lUBanco.Properties.DataSource = ado.Tabladedatos_bancos();
            lUBanco.Properties.PopulateColumns();
            lUBanco.Properties.Columns[0].Visible = false;
        }

        private void txttitulo_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
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
        public void deshabilitarboton()
        {
            btnagregar.Visible = false;
        }
        public void colocardatos(Adopcion adop)
        {
            /*lUBanco.Properties.DisplayMember = "banco_desc";
            lUBanco.Properties.ValueMember = "banco_ide";
            lUBanco.Properties.DataSource = ado.Tabladedatos_bancos();
            lUBanco.Properties.PopulateColumns();
            lUBanco.Properties.Columns[0].Visible = false;
            */
            txtproveedor.Text = adop.Proveedornombre;
            txtanombrede.Text = adop.Proveedoranombre;
            txtdireccion.Text = adop.Proveedire;
            txttelefono.Text = adop.Proveetele;
            txtmail.Text = adop.Proveemail;
            lUBanco.EditValue = adop.Proveebanco;
            txtcc.Text = adop.Proveecc;
            txtca.Text = adop.Proveeca;
            txttitular.Text = adop.Proveetitular;
            txtcbu.Text = adop.Proveecbu;
            txtcuit.Text = adop.Proveecuit;
            this.Local = adop.Local;
            this.Proveedoride = adop.Proveeide;
            this.Cuenta = adop.Proveecuentaide;
            
        }
        private void btnsubir_Click(object sender, EventArgs e)
        { }

        public void colocardatosdelusuario()
        {
            this.txtproveedor.Text = this.Nombre;
            
            
        }

        public int Ide
        {
            get { return this._ide; }
            set { this._ide = value; }
        }
        public int Local
        {
            get { return this._local; }
            set { this._local = value; }
        }
        public int Cuenta
        {
            get { return this._cuenta; }
            set { this._cuenta = value; }
        }
        public int Proveedoride
        {
            get { return this._proveeide; }
            set { this._proveeide = value; }
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
        public int EsLibro
        {
            get { return this._eslibro; }
            set { this._eslibro = value; }
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
