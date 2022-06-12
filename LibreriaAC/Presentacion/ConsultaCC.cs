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
    public partial class ConsultaCC : Form
    {
        public int valor = 0;
        Clientes cli = new Clientes();
        public ConsultaCC()
        {
            InitializeComponent();
        }

        private void ConsultaInteres_Load(object sender, EventArgs e)
        {

            this.cargar();
        }
        private void cargar()
        {
            gConsulta.DataSource = cli.Mostrar_clientesCC();
            if (LogicaNegocios.Globales.accesoacuentacorriente == 2)
            {
                btnaltacliente.Enabled = true;
                btnmodificarcliente.Enabled = true;
                btnborrarcc.Enabled = true;
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
            if (valor != 0)
            {
                Facturar.clientecuentacorriente = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CC_IDE"]));
                this.Dispose();
                this.Hide();
            }
            else
            { 
                this.seleccionado();
            }
        }

        private void seleccionado()
        {
            IClientes formInterClientes = this.Owner as IClientes;
            if (formInterClientes != null)
            {
                string cuitp = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CLI_CUIT"]));
                string nombrep = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CLI_NOMBRE"]));
                string direp = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CLI_DIRE"]));
                string tipop = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["TIPI_DESC"]));
                string tipoletrap = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["TIPI_LETRA"]));
                formInterClientes.selecciondecliente(cuitp, nombrep, direp, tipop, tipoletrap);
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
            AltaClienteCC ac = new AltaClienteCC();
            ac.Alta = 1;
            if (ac.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gConsulta.DataSource = cli.Mostrar_clientesCC();
            }
        }
        public void desaparecerbotonselec()
        {
            btnseleccionado.Visible = false;
            btnaltacliente.Enabled = true;
            btnmodificarcliente.Enabled = true;
            btnborrarcc.Enabled = true;
        }
        private void btnmodificarcliente_Click(object sender, EventArgs e)
        {
            AltaClienteCC ac = new AltaClienteCC();
            Clientes cli = new Clientes();
            cli.Dni = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CC_NRODOC"]));
            cli.Nombre = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CC_NOMBRE"]));
            cli.Domicilio = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CC_DIRECCION"]));
            cli.Telefono = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CC_TEL"]));
            cli.Clienteide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CC_IDE"]));
            cli.Alta = 0;
            ac.colocardatos(cli);
           
            if (ac.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gConsulta.DataSource = cli.Mostrar_clientesCC();
            }
        }

        private void btnborrarcc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar ésta Cuenta Corriente?", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                cli.Clienteide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["EDI_IDE"]));
              //  int valor = edi.spBajaEditorial();
              // aca me quede hugo
                this.cargar();
            }
        }

        private void btncompras_Click(object sender, EventArgs e)
        {
            ConsultaCuentaCorriente ccc = new ConsultaCuentaCorriente();
            ccc.Codigo = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CC_IDE"]));
            ccc.ShowDialog();
        }

        private void txttitulo_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //buscar acá
                cli.Nombre = txttitulo.Text;
                gConsulta.DataSource = cli.Mostrar_clientesCCBuscar();
                txttitulo.Text = string.Empty;
            }
        }
    }
}
