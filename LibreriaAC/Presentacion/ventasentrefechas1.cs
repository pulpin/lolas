using DevExpress.XtraPrinting;
using LogicaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class ventasentrefechas1 : Form
    {
        string _codigo;
        Rendiciones ren = new Rendiciones();
        public ventasentrefechas1()
        {
            InitializeComponent();
        }

        private void ConsultasConsignas_Load(object sender, EventArgs e)
        {
            
            Puntodevta pdv = new Puntodevta();
            LUpunto.Properties.DisplayMember = "PTOVTA_DESC";
            LUpunto.Properties.ValueMember = "PTOVTA_NUMERO";
            LUpunto.Properties.DataSource =  pdv.Tabladedatos_ptodevta();
            LUpunto.Properties.PopulateColumns();
            LUpunto.Properties.Columns[0].Visible = false;

            Usuarios usu = new Usuarios();

            LUusuarios.Properties.DisplayMember = "USU_NOMBRE";
            LUusuarios.Properties.ValueMember = "USU_IDE";
            LUusuarios.Properties.DataSource = usu.Mostrar_Datos_Usuariosid();
            LUusuarios.Properties.PopulateColumns();
            LUusuarios.Properties.Columns[1].Visible = false;

            fechadesde.EditValue = DateTime.Today;
            fechahasta.EditValue = DateTime.Today;
        }
        

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void btnagregacon_Click(object sender, EventArgs e)
        {

        }

        public string Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }
        

        private void btnseleccionado_Click(object sender, EventArgs e)
        {

        }

        public void pl_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
        {
            string desti = "Listado de derivaciones por Anexo/Item: ";
            TextBrick brick1 = e.Graph.DrawString(desti, Color.Black,
               new RectangleF(0, 0, 620, 20), DevExpress.XtraPrinting.BorderSide.None);
            brick1.HorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            brick1.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);

        }

        public void pl_CreateReportHeaderArea2(object sender, CreateAreaEventArgs e)
        {
            string fecha;
            fecha = "fecha: " + DateTime.Now;

            TextBrick brick2 = e.Graph.DrawString(fecha, Color.Black,
            new RectangleF(0, 0, 620, 20), DevExpress.XtraPrinting.BorderSide.None);
            //brick2.HorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            //   brick1.HorzAlignment = HorzAlignment.Center;
            brick2.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            PrintableComponentLink pl = new PrintableComponentLink(new PrintingSystem());
            pl.Component = gConsulta;
            pl.CreateMarginalHeaderArea += new CreateAreaEventHandler(pl_CreateReportHeaderArea);
            pl.CreateReportHeaderArea += new CreateAreaEventHandler(pl_CreateReportHeaderArea2);
            pl.PaperKind = System.Drawing.Printing.PaperKind.A4;
            pl.Margins = new System.Drawing.Printing.Margins(20, 20, 20, 20);
            pl.Landscape = true;
            pl.CreateDocument();

            gridViewPintarFilas.OptionsView.ShowFooter = true;
            pl.ShowPreview();
        }

        private void exportarAExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdRuta.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                gConsulta.ExportToXlsx(sfdRuta.FileName);

            }
        }

        private void exportarAPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdRuta1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                gConsulta.ExportToPdf(sfdRuta1.FileName);
            }
        }

        public void consultaparavervendidos()
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int todos;
            LogicaNegocios.Venta ve = new LogicaNegocios.Venta();

            DateTime fdesde = Convert.ToDateTime(fechadesde.EditValue);
            string fdesdee = fdesde.ToString("yyyy-MM-dd");

            DateTime fhasta = Convert.ToDateTime(fechahasta.EditValue);
            string fhastae = fhasta.ToString("yyyy-MM-dd");

            if (chbTitulo.Checked == true)
            {
                todos = 1;
            }
            else {
                todos = 0;
            }

            gConsulta.DataSource = ve.Mostrar_ventasporfecha(fdesdee, fhastae, Convert.ToInt32(LUpunto.EditValue), Convert.ToInt32(LUusuarios.EditValue),todos);
            gConsulta2.DataSource = ve.Mostrar_ventasporfecha1(fdesdee, fhastae, Convert.ToInt32(LUpunto.EditValue), Convert.ToInt32(LUusuarios.EditValue), todos);
            decimal importesuma=0;
            int tipopag = 0;
            for (int i = 0; i < gridViewPintarFilas2.DataRowCount; i++)
            {
                // ren.Factura = gridViewPintarFilas.GetRowCellValue(i, "PREN_FACTU").ToString();
                tipopag = Convert.ToInt32(gridViewPintarFilas2.GetRowCellValue(i, "TIP_IDE").ToString());
                if (tipopag == 12)
                { 
                    importesuma = importesuma + Convert.ToDecimal(gridViewPintarFilas2.GetRowCellValue(i, "total").ToString());
                }
            }
            importesuma = decimal.Round(importesuma, 2);
            lbcreditop.Text = Convert.ToString(importesuma);
        }
        

        private void chbTitulo_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTitulo.Checked == true)
            {
                LUusuarios.Enabled = false;
            }
            else
            {
                LUusuarios.Enabled = true;
            }
        }

        private void gConsulta_DoubleClick(object sender, EventArgs e)
        {
            ConsultaVentas cv = new ConsultaVentas();
            DateTime fdesde = Convert.ToDateTime(fechadesde.EditValue);
            string fdesdee = fdesde.ToString("yyyy-MM-dd");

            DateTime fhasta = Convert.ToDateTime(fechahasta.EditValue);
            string fhastae = fhasta.ToString("yyyy-MM-dd");
            int tipop = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["TIP_IDE"]));
            cv.consultaventasfiltros(fdesde, fhasta, Convert.ToInt32(LUpunto.EditValue),tipop);
            cv.Filtro = 1;
            cv.ShowDialog();
        }
    }
}
