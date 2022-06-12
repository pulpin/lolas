using DevExpress.XtraPrinting;
using LogicaNegocios;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class MovimientosdeProducto : Form
    {
        string _codigo, _codigoviejo;
        int _producide, _editorialide;
        
        Productos pro = new Productos();
        Editorial edi = new Editorial();
        Consignas con = new Consignas();
        Devolucion dev = new Devolucion();
        Rendiciones ren = new Rendiciones();
        public MovimientosdeProducto()
        {
            InitializeComponent();
        }

        private void ConsultasConsignas_Load(object sender, EventArgs e)
        {
            
            cBEeditorial.Properties.DisplayMember = "EDI_EDITORIAL";
            cBEeditorial.Properties.ValueMember = "EDI_CODIGO";
            cBEeditorial.Properties.DataSource = edi.Tabladedatos_editoriales();
            
            cBEeditorial.Properties.PopulateColumns();
           //cBEeditorial.Properties.Columns[0].Visible = false;

            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            // Create an unbound DataGridView by declaring a column count.
          

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

        public int Producide
        {
            get { return this._producide; }
            set { this._producide = value; }
        }
        public string Codigoviejo
        {
            get { return this._codigoviejo; }
            set { this._codigoviejo = value; }
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
            pl.Component = gConsulta1;
            pl.CreateMarginalHeaderArea += new CreateAreaEventHandler(pl_CreateReportHeaderArea);
            pl.CreateReportHeaderArea += new CreateAreaEventHandler(pl_CreateReportHeaderArea2);
            pl.PaperKind = System.Drawing.Printing.PaperKind.A4;
            pl.Margins = new System.Drawing.Printing.Margins(20, 20, 20, 20);
            pl.Landscape = true;
            pl.CreateDocument();

            gridView1.OptionsView.ShowFooter = true;
            pl.ShowPreview();
        }

        private void exportarAExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdRuta.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                gConsulta1.ExportToXlsx(sfdRuta.FileName);

            }
        }

        private void exportarAPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdRuta1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                gConsulta1.ExportToPdf(sfdRuta1.FileName);
            }
        }
        private void cargar()
        {

           /* int todos;
            LogicaNegocios.Venta ve = new LogicaNegocios.Venta();

            DateTime fdesde = Convert.ToDateTime(fechadesde.EditValue);
            string fdesdee = fdesde.ToString("yyyy-MM-dd");

            DateTime fhasta = Convert.ToDateTime(fechahasta.EditValue);
            string fhastae = fhasta.ToString("yyyy-MM-dd");

            if (chbTitulo.Checked == true)
            {
                todos = 1;
            }
            else
            {
                todos = 0;
            }

            gConsulta.DataSource = re.Mostrar_Reservasporfecha(fdesdee, fhastae);
            */
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.cargar();

        }
        

        private void chbTitulo_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void gridViewPintarFilas_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            MessageBox.Show("dd");
            this.cargardatos();
        }
        private void cargardatos()
        {
           // MessageBox.Show("ddf");
          /*  this.Codigo = Convert.ToString(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["PREN_LI_CODIGOVIEJO"]));
            Rendiciones ren = new Rendiciones();
            ren.Codigo = this.Codigo;
            gConsulta2.DataSource = ren.Mostrar_rendicionporproducto();*/
           /* ven.venproductoide = this.Codigo;
           
            gConsulta2.DataSource = ven.Mostrar_registrodelasventas();

            gConsulta1.DataSource = ven.Mostrar_movimientosdeproductos();*/
        }
        private void gConsulta_Click(object sender, EventArgs e)
        {

        }
        private void traerdatosproducto(int tipo)
        {

            MySqlDataReader reader = null;
           // Productos pro = new Productos();
            pro.Barra = txtbarra.Text;
            pro.Isbn = txtisbn.Text;
            pro.Codigo = txtcodigo.Text;
            pro.Tipo = tipo;
            reader = pro.obtenerdatosproductos();

            if (reader.Read() != false)
            {
                if (reader.IsDBNull(0) == true)
                {
                    reader.Dispose();
                }
                else
                {

                    this.Producide = Convert.ToInt32(reader["LI_IDE"].ToString());
                    lbdesc.Text = reader["LI_DESC"].ToString();
                    lbautor.Text = reader["LI_AUTOR"].ToString();
                    this.Codigoviejo = reader["LI_CODIGOVIEJO"].ToString();
                    int baja = Convert.ToInt32(reader["LI_BAJA"].ToString());
                    if (baja == 1)
                    {
                        lbbaja.Visible = true;
                    }
                    lbcodigo.Text = this.Codigoviejo;
                    con.Codigo = this.Codigoviejo;
                    //con.Codigoeditorial = Convert.ToInt32(cBEeditorial.EditValue);
                    this.Editorialide = Convert.ToInt32(cBEeditorial.EditValue);

                    con.Codigo = this.Codigoviejo;
                    con.Codigoeditorial = this.Editorialide;
                    gConsulta1.DataSource = con.Mostrar_consignasporproducto();
                    dev.Codigo = con.Codigo;
                    dev.CodigoEditorial = this.Editorialide;
                    gConsulta2.DataSource = dev.Mostrar_devoluciones();

                    ren.Codigo = con.Codigo;
                    ren.editorialide = this.Editorialide;
                    gConsulta3.DataSource = ren.Mostrar_rendicionporproducto();
                }
            }
            else
            {
                this.vaciartextos();
            }
        }

       
        private void vaciartextos()
        {
            MessageBox.Show("No se encontró ningún producto con esas características, vuelva a intentarlo.");

            lbdesc.Text = string.Empty;
            lbautor.Text = string.Empty;
            txtbarra.Text = string.Empty;
            txtcodigo.Text = string.Empty;
            txtisbn.Text = string.Empty;
            txtbarra.Focus();
        }
        private void txtbarra_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //buscar acá
                if (Convert.ToInt32(cBEeditorial.EditValue) > 0)
                {
                    this.traerdatosproducto(0);
                    txtbarra.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una editorial");
                }
            }
        }

        private void txtisbn_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //buscar acá
                // this.busquedasimple();
                if (Convert.ToInt32(cBEeditorial.EditValue) > 0)
                {
                    this.traerdatosproducto(2);
                    txtisbn.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una editorial");
                }

            }
        }

        private void txtcodigo_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //buscar acá
                if (Convert.ToInt32(cBEeditorial.EditValue) > 0)
                {
                    this.traerdatosproducto(1);
                    txtcodigo.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una editorial");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }
        public int Editorialide
        {
            get { return this._editorialide; }
            set { this._editorialide = value; }
        }

        private void btnmovvtas_Click(object sender, EventArgs e)
        {
            ConsultaMoviVtas cmv = new ConsultaMoviVtas();
            cmv.Codigo = this.Codigoviejo;
            cmv.ShowDialog();
        }

        private void gConsulta1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("ddfdfe");
            cargardatos();

        }

        private void gConsulta2_DoubleClick(object sender, EventArgs e)
        {
            int valornumero = Convert.ToInt32(this.gridView2.GetRowCellValue(gridView2.FocusedRowHandle, this.gridView2.Columns["DEV_IDE"]));
            MessageBox.Show(Convert.ToString(valornumero));
        }

        private void btngenerardevolucion_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
