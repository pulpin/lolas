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
    public partial class ModificaReserva : Form,IClienteRe,IagregaReserva
    {
        int _liide, _cliide, _alta, _cantidad, _reseide, _clienide;
        DateTime _paraavisarfe, _avisadofe, _entregadofe, _alaventafe, _fechamodificado, _fechadealta;
        string _codigo, _titulo, _autor, _editorial,_precio, _barra, _cliente, _telefono, _obs, _paraavisarusu, _avisadousu, _entregadousu, _alaventausu, _usuariomodifico, _usuarioalta;
        public ModificaReserva()
        {
            InitializeComponent();
            this.inicio();
        }

        public void inicio()
        {

           // lookUpEdit1.Properties.Columns[0].Visible = false;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (Alta == 1)
            {
                this.altaReserva();
            }
            else
            {
                this.modificaReserva();
            }
        }

        private void altaReserva()
        {
            Reservas re = new Reservas();
            re.Cliide = this.Cliide;
            re.Clitelefono = txttelefono.Text;
            re.Codigolibro = txtcodigo.Text;
            re.Desc = txttitulo.Text;
            re.Editorial = txteditorial.Text;
            txtprecio.Text = txtprecio.Text.Replace(",", ".");
            re.Precio = txtprecio.Text;

            int retorno = re.spInsertarReserva1();
            //int retorno = pro.spInsertarProducto();
            
            if (retorno == 0)
            {

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                MessageBox.Show("Se ha dado de alta con éxito!");
            }
            else
            {
                MessageBox.Show("Hubo un problema, por favor intentelo de nuevo.");
            }
        }

        private void modificaReserva()
        {
            Reservas re = new Reservas();
            if (chBparaavisar.Checked == true && chBparaavisar.Enabled == true)
            {
                re.Paraavisar = 1;
                re.Estado = 1;
            }
            if (chBavisado.Checked == true && chBavisado.Enabled == true)
            {
                re.Avisado = 1;
                re.Estado = 2;
            }
            if (chBentregado.Checked == true && chBentregado.Enabled == true)
            {
                re.Entregado = 1;
                re.Estado = 3;
            }
            if (chBalaventa.Checked == true && chBalaventa.Enabled == true)
            {
                re.Alaventa = 1;
                re.Estado = 4;
            }

            re.Cliide = this.Cliide;
            re.Clitelefono = txttelefono.Text;
            re.Codigolibro = txtcodigo.Text;
            re.Desc = txttitulo.Text;
            re.Autor = txtautor.Text;
            re.Editorial = txteditorial.Text;
            txtprecio.Text = txtprecio.Text.Replace(",", ".");
            re.Precio = txtprecio.Text;
            re.Cantidad = Convert.ToInt32(txtcantidad.Text);
            re.Reservaide = this.Reservaide;
            re.Obs = txtobs.Text;
            int retorno = re.spModificarReserva();
            //int retorno = pro.spInsertarProducto();

            if (retorno == 0)
            {

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                MessageBox.Show("Se ha dado de alta con éxito!");
            }
            else
            {
                MessageBox.Show("Hubo un problema, por favor intentelo de nuevo.");
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
                ConsultaProductosAgregaRe cpa = new ConsultaProductosAgregaRe();
                
                cpa.ShowDialog(this);
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

        public int Liide
        {
            get { return this._liide; }
            set { this._liide = value; }
        }

        public int Cliide
        {
            get { return this._cliide; }
            set { this._cliide = value; }
        }

        public int Cantidad
        {
            get { return this._cantidad; }
            set { this._cantidad = value; }
        }

        public String Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }

        public String Titulo
        {
            get { return this._titulo; }
            set { this._titulo = value; }
        }

        public String Autor
        {
            get { return this._autor; }
            set { this._autor = value; }
        }

        public String Editorial
        {
            get { return this._editorial; }
            set { this._editorial = value; }
        }

        private void chBparaavisar_CheckedChanged(object sender, EventArgs e)
        {
            if (chBparaavisar.Checked == true)
            {
                lbfparaavisar.Text = DateTime.Now.ToString();
                lbusuparaavisar.Text = Globales.usureservanombre;
                chBavisado.Enabled = true;
                gavisar.Visible = true;
            }
            else
            {
                gavisar.Visible = false;
            }

        }

        private void chBavisado_CheckedChanged(object sender, EventArgs e)
        {
            if (chBavisado.Checked == true)
            {
                lbfavisado.Text = DateTime.Now.ToString();
                lbusuavisado.Text = Globales.gbUsuario;
                chBentregado.Enabled = true;
                chBalaventa.Enabled = true;
                gavisado.Visible = true;
            }
            else
            {
                gavisado.Visible = false;
            }
        }

        private void chBentregado_CheckedChanged(object sender, EventArgs e)
        {
            if (chBentregado.Checked == true)
            {
                lbfentregado.Text = DateTime.Now.ToString();
                lbusuentregado.Text = Globales.gbUsuario;
                chBalaventa.Enabled = true;
                gentregado.Visible = true;
            }
            else
            {
                gentregado.Visible = false;
            }
        }

        private void chBalaventa_CheckedChanged(object sender, EventArgs e)
        {
            if (chBalaventa.Checked == true)
            {
                lbfalaventa.Text = DateTime.Now.ToString();
                lbusualaventa.Text = Globales.gbUsuario;
                galaventa.Visible = true;
            }
            else
            {
                galaventa.Visible = false;
            }
        }

        

        public String Cliente
        {
            get { return this._cliente; }
            set { this._cliente = value; }
        }

        public String Telefono
        {
            get { return this._telefono; }
            set { this._telefono = value; }
        }

        public String Barra
        {
            get { return this._barra; }
            set { this._barra = value; }
        }

        private void btnnoaparececatalogo_Click(object sender, EventArgs e)
        {
            txtbarra.Text = string.Empty;
            txtbarra.Enabled = true;
            txtcodigo.Text = string.Empty;
           // txtcodigo.Enabled = true;
            txttitulo.Text = string.Empty;
            txttitulo.Enabled = true;
            txtautor.Text = string.Empty;
            txtautor.Enabled = true;
            txteditorial.Text = string.Empty;
            txteditorial.Enabled = true;
            txtprecio.Text = string.Empty;
            txtprecio.Enabled = true;
            txtprecio.Text = "0";
        }

        public String Precio
        {
            get { return this._precio; }
            set { this._precio = value; }
        }

        public int Reservaide
        {
            get { return this._reseide; }
            set { this._reseide = value; }
        }

        public int Clienteide
        {
            get { return this._clienide; }
            set { this._clienide = value; }
        }

        public string Paraavisarusu
        {
            get { return this._paraavisarusu; }
            set { this._paraavisarusu = value; }
        }

        public string Avisadousu
        {
            get { return this._avisadousu; }
            set { this._avisadousu = value; }
        }

        public string Entregadousu
        {
            get { return this._entregadousu; }
            set { this._entregadousu = value; }
        }

        public string Alaventausu
        {
            get { return this._alaventausu; }
            set { this._alaventausu = value; }
        }

        public DateTime ParaavisarFe
        {
            get { return this._paraavisarfe;}
            set { this._paraavisarfe = value; }
        }

        public DateTime Avisadofe
        {
            get { return this._avisadofe; }
            set { this._avisadofe = value; }
        }


        public DateTime Fechadealta
        {
            get { return this._fechadealta; }
            set { this._fechadealta = value; }
        }
        public DateTime Entregadofe
        {
            get { return this._entregadofe; }
            set { this._entregadofe = value; }
        }
        public DateTime Alaventafe
        {
            get { return this._alaventafe; }
            set { this._alaventafe = value; }
        }
        public DateTime fechamodificado
        {
            get { return this._fechamodificado; }
            set { this._fechamodificado = value; }
        }
        public string Obs
        {
            get { return this._obs; }
            set { this._obs = value; }
        }

        public string Usuarioalta
        {
            get { return this._usuarioalta; }
            set { this._usuarioalta = value; }
        }
        public string Usuariomodifico
        {
            get { return this._usuariomodifico; }
            set { this._usuariomodifico = value; }
        }
        public void colocarDatos()
        {

            txtcodigo.Text = this.Codigo;
            txttitulo.Text = this.Titulo;
            txtautor.Text = this.Autor;
            txtcantidad.Text = Convert.ToString(this.Cantidad);
            txteditorial.Text = this.Editorial;
            txtprecio.Text = this.Precio;
            txtbarra.Text = this.Barra;
            txtcliente.Text = this.Cliente;
            txttelefono.Text = this.Telefono;
            txtobs.Text = this.Obs;
            lbcargadopor.Text = this.Usuarioalta;
            lbfechaalta.Text = Convert.ToString(this.Fechadealta);
            if (Paraavisarusu != string.Empty)
            {
                gavisar.Visible = true;
                chBparaavisar.Checked = true;
                chBparaavisar.Enabled = false;
                lbfparaavisar.Text = Convert.ToString(this.ParaavisarFe);
                lbusuparaavisar.Text = this.Paraavisarusu;
                bloqueartextos();
            }
            if (Avisadousu != string.Empty)
            {
                gavisado.Visible = true;
                chBavisado.Checked = true;
                chBavisado.Enabled = false;
                lbfavisado.Text = Convert.ToString(this.Avisadofe);
                lbusuavisado.Text = this.Avisadousu;
                bloqueartextos();
            }
            if (Entregadousu != string.Empty)
            {
                gentregado.Visible = true;
                chBentregado.Checked = true;
                chBentregado.Enabled = false;
                lbfentregado.Text = Convert.ToString(this.Entregadofe);
                lbusuentregado.Text = this.Entregadousu;
                bloqueartextos();
            }
            if (Alaventausu != string.Empty)
            {
                galaventa.Visible = true;
                chBalaventa.Checked = true;
                chBalaventa.Enabled = false;
                lbfalaventa.Text = Convert.ToString(this.Alaventafe);
                lbusualaventa.Text = this.Alaventausu;
                bloqueartextos();
            }
            lbusumodifico.Text = this.Usuariomodifico;
            fechaultimamod.Text = Convert.ToString(this.fechamodificado);
        }
        private void bloqueartextos()
        {
            txttitulo.Enabled = false;
            txtcliente.Enabled = false;
            txttelefono.Enabled = false;
            txtcantidad.Enabled = false;
            btnnoaparececatalogo.Enabled = false;
        }
        private void btnbuscacli_Click(object sender, EventArgs e)
        {

        }

        private void txtcliente_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConsultaClienteLi ccl = new ConsultaClienteLi();
                ccl.Nombre = txtcliente.Text;
                ccl.Entranombre=1;
                ccl.inicio();
                ccl.ShowDialog(this); 
            }
        }

        private void txttitulo_DoubleClick(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConsultaProductosAgregaRe cpa = new ConsultaProductosAgregaRe();
                cpa.Show();
            }
        }

        public void agregacliente(int cliide, string clinombre, string clitelefono)
        {
            this.Cliide = cliide;
            this.txtcliente.Text = clinombre;
            this.txttelefono.Text = clitelefono;
        }


        public void AgregaProductoR(string tituloi, string precioi, string autori, string codediinternoi, string Editorial, string barra, string codigoide)
        {
            txttitulo.Text = tituloi;
            txtprecio.Text = precioi;
            txtautor.Text = autori;
            txteditorial.Text = Editorial;
            txtcodigo.Text = codigoide;
        }
    }
}
