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
    public partial class AltaFactura : Form
    {
        private int _alta, _situacion, _clienteide, _tipo, _usuide,_numero, _ide, _local;
        private string _factura, _cuit, _razonsocial, _domicilio, _telefono, _obs;
        private string _nombre, _nombrecompleto, _contra, _contravta, _importe;
        string _titulo, _calle, _localidad, _provincia, _cliente,_precio, _saldoactual, _fechapago;
        DateTime  _fechavto, _fechafactu;
        Adopcion ado = new Adopcion();
        public AltaFactura()
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
           
            this.Altafactura();
            
        }



        private void Altafactura()
        {
            DateTime ffactu = Convert.ToDateTime(fechafactu.EditValue);
            DateTime fvto = Convert.ToDateTime(fechavto.EditValue);

            string fdesdee = ffactu.ToString("yyyy-MM-dd");
            string fvtoo = fvto.ToString("yyyy-MM-dd");


            Adopcion ado = new Adopcion();

            ado.Fecha = fdesdee;
            ado.Fechavto = fvtoo;
            ado.Facturanro = (txtfactura.Text).Trim(' ');
            txtimporte.Text = txtimporte.Text.Replace(",", ".");
            ado.Importe = txtimporte.Text;
            ado.Obs = rTobs.Text;
            ado.Ide = Convert.ToInt32(lUProveedor.EditValue);

            int resultado = ado.spAltaFactu();
            
            if (resultado == 0)
            {
                MessageBox.Show("Se ha realizado el alta de la factura!");
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                
                //this.Dispose();
                //this.Hide();
            }else if (resultado == -1)
            {
                MessageBox.Show("Se existe una factura con ese número!","Atención");
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

        public void colocarvalores()
        {
            txtimporte.Text = this.Importe;
            txtfactura.Text = this.Factura;
            rTobs.Text = this.Obs;
            fechafactu.EditValue = DateTime.Today;
            fechavto.EditValue = DateTime.Today;

            fechafactu.EditValue = this.Fechafactu;
            fechavto.EditValue = this.Fechavto;
            
        }

        private void AltaProducto_Load(object sender, EventArgs e)
        {
            
            lUProveedor.Properties.DisplayMember = "acre_desc";
            lUProveedor.Properties.ValueMember = "acre_ide";
            lUProveedor.Properties.DataSource = ado.Tabladedatos_proveedorescombo(this.Local);
            lUProveedor.Properties.PopulateColumns();
            lUProveedor.Properties.Columns[0].Visible = false;
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

        public string Factura
        {
            get { return this._factura; }
            set { this._factura = value; }
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
        public string Importe
        {
            get { return this._importe; }
            set { this._importe = value; }
        }
        public string Saldoactual
        {
            get { return this._saldoactual; }
            set { this._saldoactual = value; }
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
        
        private void btnsubir_Click(object sender, EventArgs e)
        { }

       

        public int Ide
        {
            get { return this._ide; }
            set { this._ide = value; }
        }

        public DateTime Fechavto
        {
            get { return this._fechavto; }
            set { this._fechavto = value; }
        }

        public string Fechapago
        {
            get { return this._fechapago; }
            set { this._fechapago = value; }
        }
        public DateTime Fechafactu
        {
            get { return this._fechafactu; }
            set { this._fechafactu = value; }
        }

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public string Obs
        {
            get { return this._obs; }
            set { this._obs = value; }
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

        public int Local
        {
            get { return this._local; }
            set { this._local = value; }
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
        public string Precio
        {
            get { return this._precio; }
            set { this._precio = value; }
        }
    }
}
