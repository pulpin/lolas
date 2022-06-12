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
    public partial class AltaUsuario : Form
    {
        private int _alta, _situacion, _clienteide, _tipo, _usuide, _puntodeventa;
        private string _iva, _cuit, _razonsocial, _domicilio, _telefono, _colorelegido;
        private string _nombre, _nombrecompleto, _contra, _contravta;
        public AltaUsuario()
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
            lookUpEdit1.Properties.ValueMember = lookUpEdit1.Properties.DisplayMember = "Column";
            lookUpEdit1.Properties.DataSource = new string[2] { "No", "Si" };
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (this.Alta == 1)
            {
                this.Altausuarios();
            }
            else
            {
                this.modificaUsuarios();
            }
        }

        private void Altausuarios()
        {
            Usuarios usu = new Usuarios();
            usu.Nombre = txtnombre.Text;
            usu.NombreCompleto = txtnombrecompleto.Text;
            usu.Contrase = txtcontra.Text;
            usu.Contrasevta = txtcontravta.Text;
            usu.PuntodeVenta = Convert.ToInt32(lUPuntovta.EditValue);
            usu.Colorfondo = Convert.ToString(colorEdit1.Color.Name);
            if (Convert.ToString(lookUpEdit1.EditValue) == "No")
            {
                usu.Tipo = 0;
            }
            else
            {
                usu.Tipo = 1;
            }
            int resultadov = usu.spVerificarColorElegido();
            if (resultadov == 0)
            {
                int resultado = usu.spAgregarUsuario();
                if (resultado == 0)
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    MessageBox.Show("Se ha guardado creado Usuario!");
                }
                else
                {
                    MessageBox.Show("Se ha producido un error!");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar otro COLOR para el USUARIO");
            }
        }

        private void modificaUsuarios()
        {
            Usuarios usu = new Usuarios();
            usu.Nombre = txtnombre.Text;
            usu.NombreCompleto = txtnombrecompleto.Text;
            usu.Contrase = txtcontra.Text;
            usu.Contrasevta = txtcontravta.Text;
            usu.Usuide = this.Usuide;
            usu.PuntodeVenta = Convert.ToInt32(lUPuntovta.EditValue);
            usu.Colorfondo = Convert.ToString(colorEdit1.Color.Name);
            if (Convert.ToString(lookUpEdit1.EditValue) == "No")
            {
                usu.Tipo = 0;
            }
            else
            {
                usu.Tipo = 1;
            }

            int resultadov = usu.spVerificarColorElegidoLogueo();
            if (resultadov == 0)
            {
                int resultado = usu.spModificaUsuario();
                if (resultado == 0)
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    MessageBox.Show("Se ha Modificado el Usuario!");
                }
                else
                {
                    MessageBox.Show("Se ha producido un error!");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar otro COLOR para el USUARIO");
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
            iniciarptoventa();
        }

        private void txttitulo_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtnombrecompleto.Focus();
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

        private void iniciarptoventa()
        {

            Puntodevta ptovta = new Puntodevta();
            lUPuntovta.Properties.DisplayMember = "PTOVTA_DESC";
            lUPuntovta.Properties.ValueMember = "PTOVTA_NUMERO";
            lUPuntovta.Properties.DataSource = ptovta.Tabladedatos_ptodevta();
            lUPuntovta.Properties.PopulateColumns();
            lUPuntovta.EditValue = 4;
            //lUPuntovta.Properties.Columns[0].Visible = false;
            
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(lookUpEdit1.EditValue) == "Si")
            {
                lUPuntovta.Visible = true;
                label6.Visible = true;
            }
            else
            {
                lUPuntovta.Visible = false;
                label6.Visible = false ;
            }
        }

        private void colorEdit1_EditValueChanged(object sender, EventArgs e)
        {
            panelColor.BackColor = colorEdit1.Color;
           // Globales.colorfondo = colorEdit1.Color;
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
            txtnombre.Text = this.Cuit;
            txtnombrecompleto.Text = this.Razonsocial;
            txtcontra.Text = this.Domicilio;
            txtcontravta.Text = this.Telefono;
            lookUpEdit1.EditValue = this.Situacion;
        }
        private void btnsubir_Click(object sender, EventArgs e)
        { }

        public void colocardatosdelusuario()
        {
            this.txtnombre.Text = this.Nombre;
            this.txtnombrecompleto.Text = this.NombreCompleto;
            this.txtcontra.Text = this.Contrase;
            this.txtcontravta.Text = this.Contrasevta;
            this.lUPuntovta.EditValue = this.PuntodeVenta;
            if (this.Tipo == 0)
            {
                lookUpEdit1.EditValue = "No";
                lUPuntovta.Visible = false;
                label6.Visible = false;
            }
            else
            {
                lookUpEdit1.EditValue = "Si";
                lUPuntovta.Visible = true;
                label6.Visible = true;
            }
            colorEdit1.Color = Color.FromName(this.Colorelegido);
            //colorEdit1.Color = Color.FromName(Convert.ToString(LUEusuario.EditValue));
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
        public int PuntodeVenta
        {
            get { return this._puntodeventa; }
            set { this._puntodeventa = value; }
        }
        public string Colorelegido
        {
            get { return this._colorelegido; }
            set { this._colorelegido = value; }
        }
    }
}
