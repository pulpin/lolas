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
    public partial class ConsultaClienteReserva : Form
    {
        Clientes cli = new Clientes();
        public ConsultaClienteReserva()
        {
            InitializeComponent();
        }

        private void ConsultaInteres_Load(object sender, EventArgs e)
        {

            this.cargar();
            if (LogicaNegocios.Globales.accesoaclientes == 2)
            {
                btnaltacliente.Enabled = true;
                btnmodificarcliente.Enabled = true;
            }
        }
        private void cargar()
        {
            gConsulta.DataSource = cli.Mostrar_clientesReservas();
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
            IClientes formInterClientes = this.Owner as IClientes;
            if (formInterClientes != null)
            {
                string cuitp = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CLI_CUIT"]));
                string nombrep = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CLI_NOMBRE"]));
                string direp = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CLI_DIRE"]));
                string tipop = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["TIPI_DESC"]));
                string tipoletrap = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["TIPI_LETRA"]));
                int cliide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CLI_IDE"]));
                formInterClientes.selecciondecliente(cuitp, nombrep, direp, tipop, tipoletrap, cliide);
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
            AltaClienteReservas ac = new AltaClienteReservas();
            ac.Alta = 1;
            
            if (ac.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gConsulta.DataSource = cli.Mostrar_clientesReservas();
            }
        }

        private void txttitulo_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //buscar acá
                cli.Nombre = txttitulo.Text;
                gConsulta.DataSource = cli.Mostrar_clientesBuscarReservas();
                txttitulo.Text = string.Empty;
            }
        }

    
        private void btnmodificarcliente_Click(object sender, EventArgs e)
        {
            AltaClienteReservas ac = new AltaClienteReservas();
            ac.Nombre = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CLIEN_NOMBRE"]));
            
            ac.Telefono = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CLIEN_TELEFONO"]));
            ac.Obs = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CLIEN_OBS"]));
            ac.Clienteide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CLIEN_IDE"]));
            ac.colocardatos();
            ac.Alta = 0;
            if (ac.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gConsulta.DataSource = cli.Mostrar_clientesReservas();
            }
        }

        

    }
}
