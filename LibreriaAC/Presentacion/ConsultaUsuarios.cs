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
    public partial class ConsultaUsuarios : Form
    {
        Usuarios usu = new Usuarios();
        public ConsultaUsuarios()
        {
            InitializeComponent();
        }

        private void ConsultaInteres_Load(object sender, EventArgs e)
        {
            this.cargar();
        }
        private void cargar()
        {
            gConsulta.DataSource = usu.Mostrar_Usuarios();
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
            AltaUsuario ac = new AltaUsuario();
            ac.Alta = 1;
            
            if (ac.ShowDialog() == System.Windows.Forms.DialogResult.OK)
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
            if (MessageBox.Show("¿Desea eliminar éste usuario?", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {


                Usuarios usu = new Usuarios();
                usu.Usuide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["USU_IDE"]));
                int valor = usu.spBajaUsuario();

                this.cargar();
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            AltaUsuario ac = new AltaUsuario();
            ac.Alta = 0;

            ac.Usuide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["USU_IDE"]));
            ac.Nombre = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["USU_NOMBRE"]));
            ac.NombreCompleto = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["USU_NCOMPLETO"]));
            ac.Contrase = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["USU_CONTRASE"]));
            ac.Contrasevta = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["USU_CONTRAVENTA"]));
            ac.Tipo = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["USU_TIPO"]));
            ac.PuntodeVenta = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["USU_PTOVENTA"]));
            ac.Colorelegido = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["USU_COLOR"]));
            
            ac.colocardatosdelusuario();

            if (ac.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //gConsulta.DataSource = cli.Mostrar_clientes();
                this.cargar();
            }
        }
    }
}
