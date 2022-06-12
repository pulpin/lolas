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
    public partial class ConsultaClienteLi : Form
    {
        string _nombre, _telefono;
        int _entranombre=0;
        Clientes cli = new Clientes();
        public ConsultaClienteLi()
        {
            InitializeComponent();
        }

        private void ConsultaClienteLi_Load(object sender, EventArgs e)
        {

           
        }
        public void inicio()
        {
            
            if (Entranombre == 1)
            {
                cli.Nombre = this.Nombre;
                cli.Consultapornombre = 1;
                gConsulta.DataSource = cli.Mostrar_clientesLI();
            }
            else
            {
                cli.Telefono = this.Telefono;
                cli.Consultapornombre = 0;
                gConsulta.DataSource = cli.Mostrar_clientesLI();
            }
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

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
        public string Telefono
        {
            get { return this._telefono; }
            set { this._telefono = value; }
        }
        public int Entranombre
        {
            get { return this._entranombre; }
            set { this._entranombre = value; }
        }
        private void seleccionado()
        {
            IClienteRe formInterClientes = this.Owner as IClienteRe;
            if (formInterClientes != null)
              {
                int cliide1 = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CLIEN_IDE"]));
                string clinombre1 = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CLIEN_NOMBRE"]));
                string clitelefono1 = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CLIEN_TELEFONO"]));

                formInterClientes.agregacliente(cliide1, clinombre1, clitelefono1);
                this.Dispose();
                this.Hide();
            }
        }

        private void gConsulta_DoubleClick(object sender, EventArgs e)
        {
            this.seleccionado();
        }

        private void btnaltacliente_Click(object sender, EventArgs e)
        {
            AltaCliente ac = new AltaCliente();
            ac.Alta = 1;
            
            if (ac.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gConsulta.DataSource = cli.Mostrar_clientes();
            }
        }

        private void btnmodificarcliente_Click(object sender, EventArgs e)
        {
            AltaCliente ac = new AltaCliente();
            ac.Cuit = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CLI_CUIT"]));
            ac.Razonsocial = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CLI_NOMBRE"]));
            ac.Domicilio = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CLI_DIRE"]));
            ac.Telefono = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CLI_TELEFONO"]));
            ac.Situacion = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CLI_TIPI_IDE"]));
            ac.Clienteide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CLI_IDE"]));
            ac.colocardatos();
            ac.Alta = 0;
            if (ac.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gConsulta.DataSource = cli.Mostrar_clientes();
            }
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
                cli.Telefono = txtcaracteristica.Text + txttelefono.Text;
                cli.Alta = 1;
                //Controlo si existe telefono
                int cantidad = cli.spControlaSiExisteTele(cli.Telefono);
                if (cantidad > 0)
                { MessageBox.Show("Este teléfono ya se encuentra cargado"); }
                else
                { 
                cli.Nombre = txtnombre.Text;
                
                int valor = cli.spInsertarClienteReservas();

                    IClienteRe formInterClientes = this.Owner as IClienteRe;
                    if (formInterClientes != null)
                    {
                        formInterClientes.agregacliente(valor, txtnombre.Text, txttelefono.Text);
                        this.Dispose();
                        this.Hide();
                    }
                }
            }
        }
    }
}
