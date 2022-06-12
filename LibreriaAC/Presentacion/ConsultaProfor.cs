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
    public partial class ConsultaProfor : Form
    {
        int _vendidep;
        Venta ve = new Venta();
        public ConsultaProfor()
        {
            InitializeComponent();
        }

        private void ConsultaInteres_Load(object sender, EventArgs e)
        {
            this.cargar();
        }
        private void cargar()
        {
            ve.Vendide = this.Vendidep;
            gConsulta.DataSource = ve.Mostrar_proformas();
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

                int venidep = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["VEN_IDE"]));
                
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
                //gConsulta.DataSource = cli.Mostrar_clientes();
            }
        }

        public int Vendidep
        {
            get { return this._vendidep; }
            set { this._vendidep = value; }
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

        private void btnproforma_Click(object sender, EventArgs e)
        {
            Proforma pro = new Proforma();
            pro.Ide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["VEN_IDE"]));
            pro.Nombre = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["VEN_NOMBRE"]));
            pro.Direccion = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["VEN_DIRE"]));
            pro.Telefono = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["VEN_TELEFONO"]));
            pro.Cuit = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["VEN_CUIT"]));
            pro.Colocardatos(pro);
            pro.recorrergrilla();
            pro.ShowDialog();
        }
    }
}
