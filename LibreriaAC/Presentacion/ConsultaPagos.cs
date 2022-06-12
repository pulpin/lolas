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
    public partial class ConsultaPagos : Form
    {
        string _codigo;
        int EsLibro1 = 0,local=0;
        Pedidos pe = new Pedidos();
        Pagos pa = new Pagos();
        Productos pro = new Productos();
        Adopcion ado = new Adopcion();
        decimal importesuma = 0;
        public ConsultaPagos()
        {
            InitializeComponent();
        }

        private void ConsultasConsignas_Load(object sender, EventArgs e)
        {
            this.local = 1;
            lUProveedor.Properties.DisplayMember = "acre_desc";
            lUProveedor.Properties.ValueMember = "acre_ide";
            lUProveedor.Properties.DataSource = ado.Tabladedatos_proveedorescombo(this.local);
            lUProveedor.Properties.PopulateColumns();
            lUProveedor.Properties.Columns[0].Visible = false;


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
          

        }

        public void pl_CreateReportHeaderArea2(object sender, CreateAreaEventArgs e)
        {
            string nombre,tele, local,dueño,fecha,deposito,proveedor,banco,importe,ca,titular,cc,cuit,cbu,telepro,detalledepagos;
            if (rBdistribuidora.Checked == true)
            {
                local = "                                              DISTRIBUIDORA AC. SANTA CRUZ";
            }else if (rBcredito.Checked == true)
            {
                local = "                                                             CRÉDITO";
            }else if (rBlolas.Checked == true)
            {
                local = "                                                           LENCERÍA LOLA´S";
            }
            else
            {
                local = "                                                   ARTÍCULOS ESCOLARES";
            }
            DateTime fec = Convert.ToDateTime(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["PED_FECHA"]));
            nombre = "Fagnano 195/199 - Río Gallegos (Santa Cruz)";
            tele = "Teléfono: 2966 437670";
            dueño = " de Alvado Juan Carlos";
            deposito = "DETALLE DEL DEPÓSITO O TRANSFERENCIA";
            fecha = DateTime.Now.ToLongDateString();
            proveedor = "Proveedor: " + Convert.ToString(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["acre_desc"])); 
            banco = "Banco: " + Convert.ToString(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["banco_desc"])); 
            importe = "Importe: " + importesuma;
            ca = "Caja de ahorro: " + Convert.ToString(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["cu_cahora"]));
            titular = "Titular: " + Convert.ToString(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["cu_titular"])); 
            cc = "Cuenta Corriente:" + Convert.ToString(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["cu_ctacorriente"])); 
            cuit = "Cuit: " + Convert.ToString(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["cu_cuit"])); ;
            cbu = "CBU:" + Convert.ToString(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["cu_cbu"]));
            telepro = "Teléfono: " + Convert.ToString(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["acre_tel"])); ;
            detalledepagos = "DETALLE DE LOS PAGOS";
            string pro = Convert.ToString(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["proveedor"]));
            
            TextBrick brick3 = e.Graph.DrawString(local, Color.Black,
            new RectangleF(15, 20, 720, 25), DevExpress.XtraPrinting.BorderSide.All);
            brick3.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
            

            TextBrick brick2 = e.Graph.DrawString(nombre, Color.Black,
            new RectangleF(260, 80, 250, 20), DevExpress.XtraPrinting.BorderSide.None);
            brick2.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold);

            TextBrick brick5 = e.Graph.DrawString(tele, Color.Black,
            new RectangleF(320, 105, 250, 20), DevExpress.XtraPrinting.BorderSide.None);
            brick5.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold);

            TextBrick brick6 = e.Graph.DrawString(dueño, Color.Black,
           new RectangleF(20, 55, 150, 20), DevExpress.XtraPrinting.BorderSide.None);
            brick6.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold);
            TextBrick brick7 = e.Graph.DrawString(fecha, Color.Black,
           new RectangleF(500, 55, 150, 20), DevExpress.XtraPrinting.BorderSide.None);
            brick7.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold);

            TextBrick brick8 = e.Graph.DrawString(deposito, Color.Black,
            new RectangleF(120, 130, 600, 20), DevExpress.XtraPrinting.BorderSide.None);
            brick8.Font = new Font(FontFamily.GenericSansSerif, 16, FontStyle.Bold);

            TextBrick brick9 = e.Graph.DrawString(proveedor, Color.Black,
            new RectangleF(120, 160, 300, 20), DevExpress.XtraPrinting.BorderSide.Bottom);
            brick9.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold);

            TextBrick brick10 = e.Graph.DrawString(banco, Color.Black,
            new RectangleF(120, 185, 300, 20), DevExpress.XtraPrinting.BorderSide.Bottom);
            brick10.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold);

            TextBrick brick11 = e.Graph.DrawString(importe, Color.Black,
            new RectangleF(120, 210, 300, 20), DevExpress.XtraPrinting.BorderSide.Bottom);
            brick11.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold);

            TextBrick brick12 = e.Graph.DrawString(ca, Color.Black,
            new RectangleF(85, 245, 300, 20), DevExpress.XtraPrinting.BorderSide.None);
            brick12.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold);

            TextBrick brick13 = e.Graph.DrawString(titular, Color.Black,
           new RectangleF(400, 245, 300, 20), DevExpress.XtraPrinting.BorderSide.None);
            brick13.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold);

            TextBrick brick14 = e.Graph.DrawString(cc, Color.Black,
           new RectangleF(85, 270, 300, 20), DevExpress.XtraPrinting.BorderSide.None);
            brick14.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold);

            TextBrick brick15 = e.Graph.DrawString(cuit, Color.Black,
           new RectangleF(400, 270, 300, 20), DevExpress.XtraPrinting.BorderSide.None);
            brick15.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold);

            TextBrick brick16 = e.Graph.DrawString(cbu, Color.Black,
           new RectangleF(85, 295, 300, 20), DevExpress.XtraPrinting.BorderSide.None);
            brick16.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold);

            TextBrick brick17 = e.Graph.DrawString(telepro, Color.Black,
           new RectangleF(400, 295, 300, 20), DevExpress.XtraPrinting.BorderSide.None);
            brick17.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold);

            TextBrick brick18 = e.Graph.DrawString(detalledepagos, Color.Black,
          new RectangleF(300, 340, 300, 20), DevExpress.XtraPrinting.BorderSide.None);
            brick18.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold);

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            importesuma = 0;

            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                
               
                    importesuma = importesuma + Convert.ToDecimal(gridView1.GetRowCellValue(i, "fac_importe").ToString());
                
            }
            importesuma = decimal.Round(importesuma, 2);
            

            PrintableComponentLink pl = new PrintableComponentLink(new PrintingSystem());
            //pl.Component = gConsulta;
            pl.Component = gridControl1;
            pl.CreateMarginalHeaderArea += new CreateAreaEventHandler(pl_CreateReportHeaderArea);
            pl.CreateReportHeaderArea += new CreateAreaEventHandler(pl_CreateReportHeaderArea2);
            pl.PaperKind = System.Drawing.Printing.PaperKind.A4;
            
            pl.Margins = new System.Drawing.Printing.Margins(20, 20, 20, 20);
            pl.Landscape = false;
            pl.CreateDocument();
            
            gridView2.OptionsView.ShowFooter = true;
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
        private void txttitulo_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                //buscar acá
                int provee;


                if (rBdistribuidora.Checked == true)
                {
                    local = 1;
                }
                else if (rBcredito.Checked == true)
                {
                    local = 2;
                }
                else if (rBlolas.Checked == true)
                {
                    local = 3;
                }
                else
                {
                    local = 4;
                }
                if (lUProveedor.Text == string.Empty)
                {
                    provee = 0;

                }
                else
                {
                    provee = Convert.ToInt32(lUProveedor.EditValue);

                }

                gConsulta.DataSource = pa.Mostrar_Pagosportexto(local,provee,txttitulo.Text);

            }
        }
        private void cargar()
        {

            int provee = 0,pagados=0,buscafechadesde=0,buscafechahasta=0;
            LogicaNegocios.Venta ve = new LogicaNegocios.Venta();

            if (rBdistribuidora.Checked == true)
            {
                this.EsLibro1 = 1;
            }
            else
            {
                this.EsLibro1 = 0;
            }

            if (lUProveedor.Text == string.Empty)
            {
                provee = 0;

            }
            else {
                provee = Convert.ToInt32(lUProveedor.EditValue);

            }
            if (chpagados.Checked == true && chnopagados.Checked == true)
            {
                pagados = 0;
            }
            else
            {
                if (chpagados.Checked == true)
                {
                    pagados = 1;
                }
                if (chnopagados.Checked == true)
                {
                    pagados = 2;
                }
            }
            DateTime fdesde = Convert.ToDateTime(fechadesde.EditValue);
            string fdesdee = fdesde.ToString("yyyy-MM-dd");

            DateTime fhasta = Convert.ToDateTime(fechahasta.EditValue);
            string fhastae = fhasta.ToString("yyyy-MM-dd");

            if (rBdistribuidora.Checked == true)
            {
                local = 1;
            }
            else if (rBcredito.Checked == true)
            {
                local = 2;
            }
            else if (rBlolas.Checked == true)
            {
                local = 3;
            }
            else {
                local = 4;
            }
            if (chfechadesde.Checked == true)
            {
                buscafechadesde = 1;
            }
            if (chfechahasta.Checked == true)
            {
                buscafechahasta = 1;
            }

            gConsulta.DataSource = pa.Mostrar_Pagosporfecha(fdesdee, fhastae,local,provee,pagados,buscafechadesde,buscafechahasta);

            gridControl1.DataSource = gConsulta.DataSource;
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
           
            pe.Codigo = Convert.ToInt32(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["PED_IDE"]));


            gConsulta.DataSource = pe.Mostrar_pedidosdetalle();
        }
        private void gConsulta_Click(object sender, EventArgs e)
        {

        }
        private void cargarcombo()
        {
            lUProveedor.Properties.DisplayMember = "acre_desc";
            lUProveedor.Properties.ValueMember = "acre_ide";
            lUProveedor.Properties.DataSource = ado.Tabladedatos_proveedorescombo(this.local);
            lUProveedor.Properties.PopulateColumns();
            lUProveedor.Properties.Columns[0].Visible = false;
        }
        private void rBdistribuidora_CheckedChanged(object sender, EventArgs e)
        {
            if (rBdistribuidora.Checked == true)
            {
                this.local = 1;
                this.cargarcombo();
                this.cargar();
            }
        }

        private void rBcredito_CheckedChanged(object sender, EventArgs e)
        {
            if (rBcredito.Checked == true)
            {
                this.local = 2;
                this.cargarcombo();
                this.cargar();
            }
        }

        private void rBlolas_CheckedChanged(object sender, EventArgs e)
        {
            if (rBlolas.Checked == true)
            {
                this.local = 3;
                this.cargarcombo();
                this.cargar();
            }
        }

        private void rBarticulos_CheckedChanged(object sender, EventArgs e)
        {
            if (rBarticulos.Checked == true)
            {
                this.local = 4;
                this.cargarcombo();
                this.cargar();
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            int marca = Convert.ToInt32(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["fac_marcapagado"]));
            if (marca == 0)
            {
                var topRowIndex = gridView1.TopRowIndex;
                var focusedRowHandle = gridView1.FocusedRowHandle;
                Pagarp pa = new Pagarp();
                pa.Importe = Convert.ToString(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["fac_importe"]));
                pa.Obs = Convert.ToString(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["fac_obs"]));
                pa.Factura = Convert.ToString(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["fac_nro"]));
                pa.Ide = Convert.ToInt32(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["fac_ide"]));
                pa.colocarvalores();
                
                if (pa.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.cargar();
                    gridView1.FocusedRowHandle = focusedRowHandle;
                    gridView1.TopRowIndex = topRowIndex;
                }
            }
            else {
                MessageBox.Show("Esta factura ya se encuentra pagada.");
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
         
                var topRowIndex = gridView1.TopRowIndex;
                var focusedRowHandle = gridView1.FocusedRowHandle;
                ModificarFactura pa = new ModificarFactura();
                pa.Importe = Convert.ToString(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["fac_importe"]));
                pa.Obs = Convert.ToString(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["fac_obs"]));
                pa.Factura = Convert.ToString(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["fac_nro"]));
                pa.Ide = Convert.ToInt32(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["fac_ide"]));
                pa.Fechafactu = Convert.ToDateTime(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["fac_fecha"]));
                pa.Fechavto = Convert.ToDateTime(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["fac_fecvence"]));
                pa.colocarvalores();

                if (pa.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.cargar();
                    gridView1.FocusedRowHandle = focusedRowHandle;
                    gridView1.TopRowIndex = topRowIndex;
                }
            
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar este pago?", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                ado.Ide = Convert.ToInt32(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["fac_ide"]));
                // edi.Ide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["DOC_IDE"]));
                int valor = ado.spBajaFactu();

                this.cargar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AltaFactura af = new AltaFactura();
            af.Local = this.local;
            af.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            ConsultaProveedorPagos cpp = new ConsultaProveedorPagos();
            cpp.Local = this.local;
            cpp.ShowDialog();
        }

        private void chfechadesde_CheckedChanged(object sender, EventArgs e)
        {
            if (chfechadesde.Checked == true)
            {
                label2.Visible = true;
                fechadesde.Visible = true;
            }
            else {
                label2.Visible = false;
                fechadesde.Visible = false;
            }
        }

        private void chfechahasta_CheckedChanged(object sender, EventArgs e)
        {
            if (chfechahasta.Checked == true)
            {
                label3.Visible = true;
                fechahasta.Visible = true;
            }
            else
            {
                label3.Visible = false;
                fechahasta.Visible = false;
            }
        }

        private void btnbancos_Click(object sender, EventArgs e)
        {
            ConsultaBancos cb = new ConsultaBancos();
            cb.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // MessageBox.Show(Convert.ToString(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.GetGroupSummaryValue["fac_importe"])));
            //this.gridView1.GridControl.foot
            
            // Obtain the summary item displayed in the focused column
            // within the focused group row's footer
           //label6.Text = Convert.ToString( this.gridView1.GetRowSummaryItem(gridView1.FocusedRowHandle, this.gridView1.Columns["fac_importe"]));
          //  label6.Text = this.gridView1.GetRowSummaryItem(this.gridView1.FocusedRowHandle, this.gridView1.Columns["fac_importe"]).ToString();
           // var summaryItem = this.gridView1.GetRowSummaryItem(this.gridView1.GetRowHandle, this.gridView1.Columns["fac_importe"]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AltaPedido ap = new AltaPedido();
            ap.Producto = Convert.ToString(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["RESE_DESC"]));
            ap.Ide = Convert.ToInt32(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["LI_IDE"]));
            ap.colocarnombre();
            ap.CodigoViejo = Convert.ToString(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["RESE_LI_CODIGOVIEJO"]));
            ap.Pedidos = 1;
            ap.Cantidad = Convert.ToInt32(this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, this.gridView1.Columns["RESE_CANTIDAD"]));
            ap.colocarcantidad();
            ap.Alta = 1;
            if (ap.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //gConsulta.DataSource = cli.Mostrar_clientes();
                //gConsulta.DataSource = pro.Mostrar_productos();
                this.cargar();
            }
        }
    }
}
