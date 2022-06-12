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
    public partial class ConsultaProveedorPagos : Form
    {
        int _local;
        Proveedor prov = new Proveedor();
        Adopcion ado = new Adopcion();
        public ConsultaProveedorPagos()
        {
            InitializeComponent();
        }

        private void ConsultaInteres_Load(object sender, EventArgs e)
        {
            this.cargar();
        }
        private void cargar()
        {
             
            gConsulta.DataSource = ado.Tabladedatos_proveedores(this.Local);
           
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
        public int Local
        {
            get { return this._local; }
            set { this._local = value; }
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
            Adopcion ado = new Adopcion();
            ado.Local = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["acre_local_ide"])); ;
            ado.Proveedornombre = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["acre_desc"]));
            ado.Proveedoranombre = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["acre_anombrede"]));
            ado.Proveedire = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["acre_dire"]));
            ado.Proveetele = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["acre_tel"]));
            ado.Proveemail = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["acre_mail"]));
            ado.Proveeobs = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["acre_obs"]));
            ado.Proveebanco = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["cu_banco_ide"]));
            ado.Proveecc = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["cu_ctacorriente"]));
            ado.Proveeca = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["cu_cahora"]));
            ado.Proveetitular = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["cu_titular"]));
            ado.Proveecbu = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["cu_cbu"]));
            ado.Proveecuit = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["cu_cuit"]));
            ado.Proveeide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["acre_ide"])); ;
            ado.Proveecuentaide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["cu_ide"])); ;

            AltaProveedorPagos app = new AltaProveedorPagos();
            app.Alta = 0;
            app.colocardatos(ado);
            app.deshabilitarboton();
            app.ShowDialog();

            
        }

        private void gConsulta_DoubleClick(object sender, EventArgs e)
        {
            this.seleccionado();
        }

        private void btnaltacliente_Click(object sender, EventArgs e)
        {
            AltaProveedorPagos ap = new AltaProveedorPagos();
            ap.Alta = 1;
            ap.Local = this.Local;
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
                var topRowIndex = gridViewPintarFilas.TopRowIndex;
                var focusedRowHandle = gridViewPintarFilas.FocusedRowHandle;
                ado.Proveeide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["acre_ide"]));
                ado.Proveecuentaide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["cu_ide"]));
                int valor = ado.spBajaProveeCuenta();

                this.cargar();
                gridViewPintarFilas.FocusedRowHandle = focusedRowHandle;
                gridViewPintarFilas.TopRowIndex = topRowIndex;
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            var topRowIndex = gridViewPintarFilas.TopRowIndex;
            var focusedRowHandle = gridViewPintarFilas.FocusedRowHandle;
            Adopcion ado = new Adopcion();
            ado.Local = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["acre_local_ide"])); ;
            ado.Proveedornombre = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["acre_desc"]));
            ado.Proveedoranombre = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["acre_anombrede"]));
            ado.Proveedire = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["acre_dire"]));
            ado.Proveetele = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["acre_tel"]));
            ado.Proveemail = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["acre_mail"]));
            ado.Proveeobs = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["acre_obs"]));
            ado.Proveebanco = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["cu_banco_ide"]));
            ado.Proveecc = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["cu_ctacorriente"]));
            ado.Proveeca = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["cu_cahora"]));
            ado.Proveetitular = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["cu_titular"]));
            ado.Proveecbu = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["cu_cbu"]));
            ado.Proveecuit = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["cu_cuit"]));
            ado.Proveeide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["acre_ide"])); ;
            ado.Proveecuentaide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["cu_ide"])); ;
            
            AltaProveedorPagos app = new AltaProveedorPagos();
            app.Alta = 0;
            app.colocardatos(ado);
            

            if (app.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //gConsulta.DataSource = cli.Mostrar_clientes();

                this.cargar();
                gridViewPintarFilas.FocusedRowHandle = focusedRowHandle;
                gridViewPintarFilas.TopRowIndex = topRowIndex;
            }
        }

        private void txttitulo_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //buscar acá
       
                ado.Titulo = txttitulo.Text;



                gConsulta.DataSource = ado.Tabladedatos_proveedoresBuscar(this.Local);
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
