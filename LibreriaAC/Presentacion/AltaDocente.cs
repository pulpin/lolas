using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocios;

namespace Presentacion
{
    public partial class AltaDocente : Form
    {
        Adopcion ado = new Adopcion();
        int _adoide;
        public AltaDocente()
        {
            InitializeComponent();
        }
        private void cargar()
        {
            gConsulta.DataSource = ado.Tabladedatos_ListaDocentes();
        }
        private void ConsultaClienteLi_Load(object sender, EventArgs e)
        {
            this.cargar();
        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            this.seleccionado();
        }

       
       
        private void seleccionado()
        {
            
                int docide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["doc_ide"]));
                ado.Docide = docide;
                ado.Ide = this.Adoide;
                int valor = ado.spAgregarDocente();
                if (valor == -1)
                {
                    MessageBox.Show("Ya existe este docente en la adopción.");
                }
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Dispose();
                this.Hide();
            
        }

        private void gConsulta_DoubleClick(object sender, EventArgs e)
        {
            this.seleccionado();
        }

        private void btnaltacliente_Click(object sender, EventArgs e)
        {
            
        }

        private void btnmodificarcliente_Click(object sender, EventArgs e)
        {
            
        }

        private void gConsulta_DoubleClick_1(object sender, EventArgs e)
        {
            this.seleccionado();
        }
       
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if ((txtnombre.Text == string.Empty)||(txttelefono.Text == string.Empty))
            {
                MessageBox.Show("Debe completar Apellido, nombre y teléfono");
            }
            else
            { 

                Clientes cli = new Clientes();
                ado.Telefono = txtcaracteristica.Text + txttelefono.Text;
                //cli.Telefono = txtcaracteristica.Text + txttelefono.Text;
                ado.Alta = 1;
                //Controlo si existe telefono
                int cantidad = ado.spControlaSiExisteDocente(ado.Telefono);
                if (cantidad > 0)
                { MessageBox.Show("Este teléfono ya se encuentra cargado"); }
                else
                { 
                ado.Nombredocente = txtnombre.Text;
                ado.Ide = this.Adoide;
                int valor = ado.spAltaDocenteYagrega();
                if (valor > 0) { 
                        MessageBox.Show("Se ha dado de alta al docente");
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Dispose();
                        this.Hide();
                    }
                }
            }
        }
        public int Adoide
        {
            get { return this._adoide; }
            set { this._adoide = value; }
        }
    }
}
