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
    public partial class DevolucionConsigna : Form
    {
        string _codigo, _codigoviejo;
        int _producide;
        object[] rowsenviar;
        Productos pro = new Productos();
        Editorial edi = new Editorial();
        Consignas con = new Consignas();
        public DevolucionConsigna()
        {
            InitializeComponent();
        }

        private void ConsultasConsignas_Load(object sender, EventArgs e)
        {
            
            cBEeditorial.Properties.DisplayMember = "EDI_EDITORIAL";
            cBEeditorial.Properties.ValueMember = "EDI_CODIGO";
            cBEeditorial.Properties.DataSource = edi.Tabladedatos_editoriales();
            cBEeditorial.Properties.PopulateColumns();
           // cBEeditorial.Properties.Columns[0].Visible = false;

            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            // Create an unbound DataGridView by declaring a column count.
            dgvProductos.ColumnCount = 10;
            dgvProductos.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvProductos.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Set the column header names.
            dgvProductos.Columns[0].Name = "Remito";
            dgvProductos.Columns[1].Name = "Código";
            dgvProductos.Columns[2].Name = "Título";
            dgvProductos.Columns[3].Name = "Cantidad";
            dgvProductos.Columns[4].Name = "Devueltos";
            dgvProductos.Columns[5].Name = "Importe";
            dgvProductos.Columns[6].Name = "Nroconsigna";
            dgvProductos.Columns[7].Name = "ConsignaIde";
            dgvProductos.Columns[8].Name = "Rendido";
            dgvProductos.Columns[9].Name = "Subtotal";
            /*dgvProductos.Columns[9].Name = "importeiva";
            dgvProductos.Columns[10].Name = "iva";
            dgvProductos.Columns[11].Name = "valorivac";
            dgvProductos.Columns[12].Name = "importeivac";*/

            dgvProductos.Columns[0].Width = 70;
            dgvProductos.Columns[0].DefaultCellStyle.Alignment =
        DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.Columns[1].DefaultCellStyle.Alignment =
       DataGridViewContentAlignment.MiddleCenter;
           /* dgvProductos.Columns[2].Width = 300;
            dgvProductos.Columns[3].Width = 190;
            dgvProductos.Columns[4].Width = 100;
            dgvProductos.Columns[4].DefaultCellStyle.Alignment =
        DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.Columns[5].DefaultCellStyle.Alignment =
        DataGridViewContentAlignment.MiddleCenter;
        */
            //  dgvProductos.Columns[6].Visible = false;
            //  dgvProductos.Columns[7].Visible = false;

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
            /* string fecha;
             fecha = "fecha: " + DateTime.Now;

             TextBrick brick2 = e.Graph.DrawString(fecha, Color.Black,
             new RectangleF(0, 0, 620, 20), DevExpress.XtraPrinting.BorderSide.None);
             //brick2.HorzAlignment = DevExpress.Utils.HorzAlignment.Center;
             //   brick1.HorzAlignment = HorzAlignment.Center;
             brick2.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold);
             */
            string fecha, nombre, nombre2, nombre3, planilla;
            fecha = "fecha: " + DateTime.Now;
            nombre = "Librería Editorial Distribuidora A.C. Santa Cruz";
            nombre2 = "de Juan C. Alvado";
            nombre3 = "Fagnano 195 - Tel. 02966-437670";
            planilla = "Planilla de devoluciones";
            // edi = "Señores:  ";
            // dom = "Domicilio: ";
            //  tel = "teléfono: ";
            TextBrick brick1 = e.Graph.DrawString(nombre, Color.Black,
            new RectangleF(0, 0, 620, 20), DevExpress.XtraPrinting.BorderSide.None);
            TextBrick brick2 = e.Graph.DrawString(nombre2, Color.Black,
            new RectangleF(0, 25, 900, 40), DevExpress.XtraPrinting.BorderSide.None);
            TextBrick brick3 = e.Graph.DrawString(nombre3, Color.Black,
            new RectangleF(0, 50, 900, 40), DevExpress.XtraPrinting.BorderSide.None);
            TextBrick brick12 = e.Graph.DrawString(planilla, Color.Blue,
             new RectangleF(0, 95, 900, 40), DevExpress.XtraPrinting.BorderSide.None);
            
            // TextBrick brick4 = e.Graph.DrawString(edi, Color.Black,
            //  new RectangleF(0, 80, 900, 40), DevExpress.XtraPrinting.BorderSide.None);
            // TextBrick brick5 = e.Graph.DrawString(dom, Color.Black,
            // new RectangleF(0, 95, 900, 40), DevExpress.XtraPrinting.BorderSide.None);
            //  TextBrick brick6 = e.Graph.DrawString(tel, Color.Black,
            // new RectangleF(0, 110, 900, 40), DevExpress.XtraPrinting.BorderSide.None);
            TextBrick brick7 = e.Graph.DrawString("Señores: " + cBEeditorial.Text, Color.Black,
            new RectangleF(0, 130, 900, 40), DevExpress.XtraPrinting.BorderSide.None);
            TextBrick brick13 = e.Graph.DrawString("Observación: " + txtobs.Text, Color.Black,
            new RectangleF(0, 150, 900, 40), DevExpress.XtraPrinting.BorderSide.None);
            //   TextBrick brick8 = e.Graph.DrawString("Domicilio: " + domi + " " + dominro, Color.Black,
            //  new RectangleF(0, 150, 900, 40), DevExpress.XtraPrinting.BorderSide.None);
            // TextBrick brick9 = e.Graph.DrawString("Subtotal: " + lbtotal.Text, Color.Red,
            //  new RectangleF(0, 190, 900, 40), DevExpress.XtraPrinting.BorderSide.None);
            //  TextBrick brick10 = e.Graph.DrawString("Porcentaje: " + lbporcentaje.Text, Color.Red,
            // new RectangleF(0, 210, 900, 40), DevExpress.XtraPrinting.BorderSide.None);
            //  TextBrick brick11 = e.Graph.DrawString("Total a Rendir: " + lbtotalg.Text, Color.Red,
            //  new RectangleF(0, 230, 900, 40), DevExpress.XtraPrinting.BorderSide.None);

            //  TextBrick brick2 = e.Graph.DrawString(fecha, Color.Black,
            //  new RectangleF(0, 0, 820, 40), DevExpress.XtraPrinting.BorderSide.None);
            //brick2.HorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            //   brick1.HorzAlignment = HorzAlignment.Center;
            brick1.Font = new Font(FontFamily.GenericSansSerif, 16, FontStyle.Bold);
            brick2.Font = new Font(FontFamily.GenericSansSerif, 16, FontStyle.Bold);
            brick3.Font = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold);
            // brick4.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
            // brick5.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
            // brick6.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
            brick7.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
         //   brick8.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
          //  brick9.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
          //  brick10.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
          //  brick11.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
            brick12.Font = new Font(FontFamily.GenericSansSerif, 16, FontStyle.Bold);
            brick13.Font = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Regular);

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            PrintableComponentLink pl = new PrintableComponentLink(new PrintingSystem());
            pl.Component = gridControl1;
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
            this.cargardatos();
        }
        private void cargardatos()
        {
           /* this.Codigo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["RESE_LI_CODIGOVIEJO"]));
            ven.venproductoide = this.Codigo;
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
                    lbcodigo.Text = this.Codigoviejo;
                    con.Codigo = this.Codigoviejo;
                    con.Codigoeditorial = Convert.ToInt32(cBEeditorial.EditValue);
                    gConsulta.DataSource = con.Mostrar_consignasdevolucion();
                    this.recorrergrillaysumar();
                }
            }
            else
            {
                this.vaciartextos();
            }
        }

        private void recorrergrillaysumar()
        {
            int suma=0;
            for (int i = 0; i < gridViewPintarFilas.DataRowCount; i++)
            {
                suma = suma +  Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(i, this.gridViewPintarFilas.Columns["CONS_CANTIDAD"]));
                    
            }
            txttotalconsignado.Text = Convert.ToString(suma);
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
        public void AgregarProducto(object[] rows)
        {
            foreach (string[] rowArray in rows)
            {
                dgvProductos.Rows.Add(rowArray);
            }

        }

        private void btngenerardevolucion_Click(object sender, EventArgs e)
        {
            Devolucion devo = new Devolucion();
            devo.CodigoEditorial = con.Codigoeditorial;
            devo.Desc = txtobs.Text;
            int resultadod=0;
            int resultadom = devo.spInsertarDevolucionMaestro();
            if (resultadom > 0)
            {

                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    devo.Remito = Convert.ToString(row.Cells[0].Value);
                    devo.Codigo = Convert.ToString(row.Cells[1].Value);
                    devo.Desc = Convert.ToString(row.Cells[2].Value);
                    devo.Cantioriginal = Convert.ToInt32(row.Cells[3].Value);
                    devo.Cantidevolucion = Convert.ToInt32(row.Cells[4].Value);
                    devo.Precio = Convert.ToDecimal(row.Cells[5].Value);
                    devo.NroConsigna = Convert.ToInt32(row.Cells[6].Value);
                    devo.ConsignaIde = Convert.ToInt32(row.Cells[7].Value);
                    devo.Rendido = Convert.ToInt32(row.Cells[8].Value);
                    devo.CodigoMaestro = resultadom;
                    resultadod = devo.spInsertarDevolucion();
                    /*if (resultado == 0)
                    {
                        MessageBox.Show("Se ha generado la devolución!");
                    }
                    else
                    {
                        MessageBox.Show("Se ha producido un error!");
                    }*/
                }
                if (resultadod == 0)
                {
                    MessageBox.Show("Se ha generado la devolución, ahora puede imprimir!");
                    devo.CodigoMaestro = resultadom;
                    gridControl1.DataSource = devo.Mostrar_consignasdevolucionimprimir();
                    btneliminar.Visible = true;
                    btngenerardevolucion.Visible = false;
                }
                else
                {
                    MessageBox.Show("Se ha producido un error!");
                }
            }
            else
            {
                MessageBox.Show("Se ha producido un error!");
            }
           // this.Dispose();
          //  this.Hide();

        }
        private void ponerenlista()
        {
            int cantidadadescontar = Convert.ToInt32(txtcantidaddev.Text);
            string remito = string.Empty, canti = string.Empty, impor = string.Empty, devueltos = string.Empty, nroconsig = string.Empty, consignaide = string.Empty, rendido = string.Empty;
            decimal impototal=0;
            if (Convert.ToInt32(txtcantidaddev.Text) <= Convert.ToInt32(txttotalconsignado.Text))
            {
                for (int i = 0; i < gridViewPintarFilas.DataRowCount; i++)
                {
                    if (cantidadadescontar != 0)
                    {
                        canti = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(i, this.gridViewPintarFilas.Columns["CONS_CANTIDAD"]));
                        if (cantidadadescontar >= Convert.ToInt32(canti))
                        {
                            devueltos = canti;
                            cantidadadescontar = cantidadadescontar - Convert.ToInt32(canti);
                        }
                        else
                        {
                            //canti = Convert.ToString(Convert.ToInt32(canti) - cantidadadescontar);
                            devueltos = Convert.ToString(cantidadadescontar);
                            cantidadadescontar = 0;
                        }
                        remito = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(i, this.gridViewPintarFilas.Columns["CONS_REMITO"]));
                        impor = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(i, this.gridViewPintarFilas.Columns["CONS_IMPORTE"]));
                        nroconsig = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(i, this.gridViewPintarFilas.Columns["CONS_NROCONSIG"]));
                        consignaide = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(i, this.gridViewPintarFilas.Columns["CONS_IDE"]));
                        rendido = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(i, this.gridViewPintarFilas.Columns["CONS_RENDIDO"]));
                        impototal = Convert.ToDecimal(cantidadadescontar) * Convert.ToDecimal(impor);

                        string[] row1 = new string[] { remito, lbcodigo.Text, lbdesc.Text, canti, devueltos, impor, nroconsig, consignaide, rendido,Convert.ToString(impototal) };
                        rowsenviar = new object[] { row1 };

                        AgregarProducto(rowsenviar);
                        txtcantidaddev.Text = "";

                    }
                }
                //  txtcantidaddev.Enabled = false;
                // button3.Enabled = false; 
            }
            else
            {
                MessageBox.Show("La cantidad a devolver debe ser igual o menor que la consignada");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int exis = 0;
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                if (Convert.ToString(row.Cells[1].Value) == this.Codigoviejo)
                {
                    exis = 1;
                }
                
            }
            if (exis == 1)
            {
                MessageBox.Show("El producto ya ha sido seleccionado para la devolución");
            }
            else
            {
                ponerenlista();
            }
        }
    }
}
