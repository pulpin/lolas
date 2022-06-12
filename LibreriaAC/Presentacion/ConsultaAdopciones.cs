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
    public partial class ConsultaAdopciones : Form
    {
        Editorial edi = new Editorial();
        Adopcion ado = new Adopcion();
        public ConsultaAdopciones()
        {
            InitializeComponent();
        }

        private void ConsultaInteres_Load(object sender, EventArgs e)
        {
            this.cargar();
            if (Globales.accesomodificaradopciones==2)
            {
                btnaltacliente.Enabled = true;
                btnmodificar.Enabled = true;
                btnborrarusu.Enabled = true;
                button1.Enabled = true;
            }
        }
        private void cargar()
        {
            int anioactual = DateTime.Now.Year;
            
            Adopcion ad = new Adopcion();
           
            LUanio.Properties.DisplayMember = "anio";
            LUanio.Properties.ValueMember = "anio";
            LUanio.Properties.DataSource = ad.Mostrar_anio();
            LUanio.Properties.PopulateColumns();
            LUanio.EditValue = anioactual;

            gConsulta.DataSource = ado.Tabladedatos_adopcionTodos();    
           // gConsulta.DataSource = edi.Tabladedatos_editorialesTodos();
            
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

            var topRowIndex = gridViewPintarFilas.TopRowIndex;
            var focusedRowHandle = gridViewPintarFilas.FocusedRowHandle;
            AltaAdopcion aa = new AltaAdopcion();
            aa.Alta = 0;
            aa.Escuide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["ado_esc_ide"]));
            aa.Cursoide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["ado_cur_ide"]));
            aa.Adoide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["ado_ide"]));
            aa.Division = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["ado_div_ide"]));
            aa.Cantidadalu = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["ado_cantialumnos"]));
            aa.Turnos = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["ado_tur_ide"]));
            aa.Localidad = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["ado_loc_ide"]));
            aa.Obs = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["ado_obs"]));
            aa.Colocardatos();
            
            if (aa.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.cargar();
                gridViewPintarFilas.FocusedRowHandle = focusedRowHandle;
                gridViewPintarFilas.TopRowIndex = topRowIndex;
            }

            }

        private void gConsulta_DoubleClick(object sender, EventArgs e)
        {
            this.seleccionado();
        }

        private void btnaltacliente_Click(object sender, EventArgs e)
        {
            AltaAdopcion aa = new AltaAdopcion();
            aa.Alta = 1;
            aa.Crearadopcion();
            if (aa.ShowDialog() == System.Windows.Forms.DialogResult.OK)
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
            if (MessageBox.Show("¿Desea eliminar ésta adopción?", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                ado.Ide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["ado_ide"]));
                // edi.Ide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["DOC_IDE"]));
                int valor = ado.spBajaAdopcionM();

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
                ado.Titulo = txttitulo.Text;
                ado.Anio =Convert.ToInt32(LUanio.EditValue);
                gConsulta.DataSource = ado.Tabladedatos_adopcionesAva();
               
                txttitulo.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultaEscuelas ce = new ConsultaEscuelas();
            ce.ShowDialog();
        }
    }
}
