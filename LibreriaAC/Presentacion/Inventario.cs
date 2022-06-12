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
    public partial class Inventario : Form
    {
        private int _alta, _situacion, _clienteide, _tipo, _usuide,_numero, _ide;
        private string _factura, _cuit, _razonsocial, _domicilio, _telefono, _obs;
        private string _nombre, _nombrecompleto, _contra, _contravta, _importe;
        string _titulo, _calle, _localidad, _provincia, _cliente,_precio, _saldoactual, _fechapago;
        DateTime  _fechavto, _fechafactu;
        Productos produ;
        public Inventario()
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
            produ.Cantidad = Convert.ToInt32(txtimporte.Text);
            if (chkinventariado.Checked == true)
            {
                produ.Inventario = 1;
            }
            else

            {
                produ.Inventario = 0;
            }
            int valr = produ.spInventariado();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }



        


        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        public void colocardatos(Productos pro)
        {
            this.produ = pro;
            lbstock.Text = pro.Stock;
            int totalendepo = pro.spConsultaTotalenDeposito();
            lbdeposito.Text = Convert.ToString(totalendepo);
            lbsalon.Text = Convert.ToString(Convert.ToInt32(pro.Stock) - Convert.ToInt32(totalendepo));
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
