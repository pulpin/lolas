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
    public partial class AltaDepositoABM : Form
    {
        private int _alta, _cantidad, _clienteide, _tipo, _usuide,_numero, _ide, _lugar, _habia;
        private string _codigo, _cuit, _razonsocial, _domicilio, _telefono, _lugaresabm;
        private string _nombre, _nombrecompleto, _contra, _contravta;
        string _titulo, _calle, _localidad, _provincia, _cliente;
        public AltaDepositoABM()
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
               // txtprecio.Text = txtprecio.Text.Replace(",", ".");
                this.Altadeposito();
            }
            else
            {
                this.Modificardeposito();
            }
        }



        private void Altadeposito()
        {
            //Tipoajuste ta = new Tipoajuste();
            Deposito de = new Deposito();
            //ta. = txtprecio.Text;
            de.Lugardesc = txtdeposito.Text;
         //   de.Lugar = Convert.ToInt32(lUTipoajuste.EditValue);
           
            de.Alta = this.Alta;
            int resultado = de.spAgregarDepositoABM();
            if (resultado == 0)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                MessageBox.Show("Se ha guardado el depósito!");
            }
            else
            {
                MessageBox.Show("Se ha producido un error!");
            }
        }

        private void Modificardeposito()
        {
            //Tipoajuste ta = new Tipoajuste();
            Deposito de = new Deposito();
            //ta. = txtprecio.Text;
            //de.Cantidad = Convert.ToInt32(txtprecio.Text);
            //de.Lugar = Convert.ToInt32(lUTipoajuste.EditValue);
            de.Lugardesc = txtdeposito.Text;
            de.Depoide = this.Ide;
            de.Alta = this.Alta;
           
            int resultado = de.spAgregarDepositoABM();
            if (resultado == 0)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                MessageBox.Show("Se ha modificado el depósito!");
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
        public void colocardatos()
        {
            //txtprecio.Text = this.canti
            //txtprecio.Text = Convert.ToString(this.Cantidad);
            txtdeposito.Text = this.LugaresABM;
            this.Alta = 0;
           // lUTipoajuste.EditValue = this.Lugar;
        }
        private void AltaProducto_Load(object sender, EventArgs e)
        {
         

            //dateEnvio.EditValue = DateTime.Today;
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

        public string Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
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
        public int Cantidad
        {
            get { return this._cantidad; }
            set { this._cantidad = value; }
        }
        public int Lugar
        {
            get { return this._lugar; }
            set { this._lugar = value; }
        }
        public int Habia
        {
            get { return this._habia; }
            set { this._habia = value; }
        }
        public string LugaresABM
        {
            get { return this._lugaresabm; }
            set { this._lugaresabm = value; }
        }
    }
}
