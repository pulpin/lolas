using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class CargarProAdo : Form
    {
        int _cantielegida, _adopide, _liide;
        string _titulo, _codigo;
        LogicaNegocios.Adopcion ado = new LogicaNegocios.Adopcion();
        public CargarProAdo()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }
        public int Liide
        {
            get { return this._liide; }
            set { this._liide = value; }
        }
        public int Cantielegida
        {
            get { return this._cantielegida; }
            set { this._cantielegida = value; }
        }
        public string Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }
        public int Adopide
        {
            get { return this._adopide; }
            set { this._adopide = value; }
        }
        public string Titulo
        {
            get { return this._titulo; }
            set { this._titulo = value; }
        }
        public void colocartitulo()
        {
            lbcodigo.Text = this.Codigo;
            lbtitulo.Text = this.Titulo;
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            ado.Ide = this.Adopide;
            ado.Libide = this.Liide;
            ado.Area = Convert.ToInt32(lUArea.EditValue);
            if (rBopcional.Checked == true)
            {
                ado.Opcional = 1;
            }
            else
            {
                ado.Opcional = 0;
            }
            if (rBcualquier.Checked == true)
            {
                ado.SinEditorial = 1;
            }
            else
            {
                ado.SinEditorial = 0;
            }

            ado.spAgregarLibros();
            //comprobar acá si es numerico
          //  if ((txtcantidad.Text).i)
            //Cantielegida = Convert.ToInt32(txtcantidad.Text);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Dispose();
            this.Hide();
        }

        private void CargarProAdo_Load(object sender, EventArgs e)
        {
            lUArea.Properties.DisplayMember = "area_desc";
            lUArea.Properties.ValueMember = "area_ide";
            lUArea.Properties.DataSource = ado.Tabladedatos_areas();
            lUArea.Properties.PopulateColumns();
        }

        private void txtcantidad_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnagregar.Focus();
            }
        }
    }
}
