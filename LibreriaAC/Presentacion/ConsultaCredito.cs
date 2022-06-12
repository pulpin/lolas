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
    public partial class ConsultaCredito : Form
    {
        Credito cre = new Credito();
        public ConsultaCredito()
        {
            InitializeComponent();
        }

        private void ConsultaInteres_Load(object sender, EventArgs e)
        {
            this.cargar();
        }
        private void cargar()
        {
            gConsulta.DataSource = cre.Tabladedatos_creditoTodos();
            if (LogicaNegocios.Globales.accesocredito == 2 )
            {
               
                btnmodificar.Enabled = true;
                
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
           // MessageBox.Show("Hola");
            AltaCredito ac = new AltaCredito();
            ac.Ide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["li_codigo"]));
            ac.Titulo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["li_titulo"]));
            ac.Editorial = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["li_editorial"]));
            ac.Rubro = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["li_rubro"]));
            ac.Costo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["li_costo"]));
            ac.Distribucion = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["li_distribucion"]));
            ac.Contado = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["li_contado"]));
            ac.Financiado = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["li_financiado"]));
            ac.Diez = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["li_diez"]));
            ac.Ocho = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["li_ocho"]));
            ac.Seis = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["li_seis"]));
            ac.colocardatos();
           // ac.ShowDialog();
            if (ac.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //gConsulta.DataSource = cli.Mostrar_clientes();
                this.cargar();
            }
            /*
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
            */
        }

        private void gConsulta_DoubleClick(object sender, EventArgs e)
        {
            
                this.seleccionado();
            
        }

        private void btnaltacliente_Click(object sender, EventArgs e)
        {
            AltaEditorial ae = new AltaEditorial();
            ae.Alta = 1;
            
            if (ae.ShowDialog() == System.Windows.Forms.DialogResult.OK)
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
            if (MessageBox.Show("¿Desea eliminar ésta Editorial?", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                //edi.Ide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["EDI_IDE"]));
                //int valor = edi.spBajaEditorial();

                this.cargar();
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            this.seleccionado();
        }

        private void txttitulo_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //buscar acá
                
                cre.Titulo = txttitulo.Text;
                gConsulta.DataSource = cre.Tabladedatos_creditoAva();
                txttitulo.Text = string.Empty;
            }
        }
    }
}
