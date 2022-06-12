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
    public partial class ConsultaProveedor : Form
    {
        
        Proveedor prov = new Proveedor();
        public ConsultaProveedor()
        {
            InitializeComponent();
        }

        private void ConsultaInteres_Load(object sender, EventArgs e)
        {
            this.cargar();
        }
        private void cargar()
        {
            if (rBlibros.Checked == true)
            {
                prov.EsLibro = 1;
            }
            else
            {
                prov.EsLibro = 0;
            }
            gConsulta.DataSource = prov.Tabladedatos_proveedores();
            if (LogicaNegocios.Globales.accesoaproveedores == 2 )
            {
                btnaltacliente.Enabled = true;
                btnmodificar.Enabled = true;
                btnborrarusu.Enabled = true;
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
            AltaProveedor ap = new AltaProveedor();
            ap.Alta = 1;
            
            if (ap.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //gConsulta.DataSource = cli.Mostrar_clientes();
                this.cargar();
            }
        }

        private void btnmodificarcliente_Click(object sender, EventArgs e)
        {
            ConsultaPermisos cp = new ConsultaPermisos();
            cp.Codigo = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["USU_IDE"]));
            if (cp.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //gConsulta.DataSource = cli.Mostrar_clientes();

            }
        }

        private void btnborrarusu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar este Proveedor?", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                
                prov.Ide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["PROV_IDE"]));
                int valor = prov.spBajaProveedor();

                this.cargar();
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            AltaProveedor ap = new AltaProveedor();
            ap.Alta = 0;
            ap.Ide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["PROV_IDE"]));
            ap.Titulo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["PROV_DESC"]));
            ap.EsLibro = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["PROV_LIBRO"]));
            ap.colocardatosEdi();

            if (ap.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //gConsulta.DataSource = cli.Mostrar_clientes();
                this.cargar();
            }
        }

        private void txttitulo_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //buscar acá
                prov.Titulo = txttitulo.Text;
                if (rBlibros.Checked == true)
                {
                    prov.EsLibro = 1;
                }
                else
                {
                    prov.EsLibro = 0;
                }
                gConsulta.DataSource = prov.Tabladedatos_proveedoresbuscar();
                txttitulo.Text = string.Empty;
            }
        }

        private void rBlibros_CheckedChanged(object sender, EventArgs e)
        {
            this.cargar();
        }

        private void rBlolasdb_CheckedChanged(object sender, EventArgs e)
        {
            this.cargar();
        }
    }
}
