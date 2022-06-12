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
    public partial class ConsultasHistoricoD : Form
    {
        string _codigo, _editorial, _obs;
        DateTime _fecha;
        Rendiciones ren = new Rendiciones();
        public ConsultasHistoricoD()
        {
            InitializeComponent();
        }

        private void ConsultasConsignas_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            //double importeren=0,porcen;
            ren.Codigo = this.Codigo;
            gConsulta.DataSource = ren.Mostrar_devolucionesdetalle();
           // gConsulta2.DataSource = ren.Mostrar_rendicionesdetallesagrupados();
           /* for (int i = 0; i < gridViewPintarFilas.DataRowCount; i++)
            {
                // ren.Factura = gridViewPintarFilas.GetRowCellValue(i, "PREN_FACTU").ToString();
                importeren += Convert.ToDouble(gridViewPintarFilas.GetRowCellValue(i, "PREN_IMPORTE").ToString());
            }
            senores = gridViewPintarFilas.GetRowCellValue(0, "EDI_EDITORIAL").ToString();
            domi = gridViewPintarFilas.GetRowCellValue(0, "EDI_CALLE").ToString();
            dominro = gridViewPintarFilas.GetRowCellValue(0, "EDI_NRO").ToString();
            
            lbtotal.Text = Convert.ToString(importeren);
            porcen = Convert.ToDouble(gridViewPintarFilas.GetRowCellValue(0, "EDI_PORCEN").ToString());
            lbporcentaje.Text = Convert.ToString(porcen);
            lbtotalg.Text = Convert.ToString(importeren - (importeren * porcen / 100)); 
            */
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
        public string Editorial
        {
            get { return this._editorial; }
            set { this._editorial = value; }
        }
        public DateTime Fecha
        {
            get { return this._fecha; }
            set { this._fecha = value; }
        }
        public string Obs
        {
            get { return this._obs; }
            set { this._obs = value; }
        }
        public void colocarrendicionmae()
        {
            lbrendicion.Text = this.Editorial;
            lbfecha.Text =  Convert.ToString(this.Fecha).Substring(0,10);
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
            string nombre,nombre2,nombre3,planilla;
           // fecha = "fecha: " + DateTime.Now;
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
             TextBrick brick4 = e.Graph.DrawString("Fecha: "+ Convert.ToString(Fecha).Substring(0,10), Color.Black,
              new RectangleF(0, 85, 900, 40), DevExpress.XtraPrinting.BorderSide.None);
            // TextBrick brick5 = e.Graph.DrawString(dom, Color.Black,
            // new RectangleF(0, 95, 900, 40), DevExpress.XtraPrinting.BorderSide.None);
            //  TextBrick brick6 = e.Graph.DrawString(tel, Color.Black,
            // new RectangleF(0, 110, 900, 40), DevExpress.XtraPrinting.BorderSide.None);
            TextBrick brick7 = e.Graph.DrawString("Señores: "+Editorial, Color.Black,
            new RectangleF(0, 130, 900, 40), DevExpress.XtraPrinting.BorderSide.None);
            //TextBrick brick8 = e.Graph.DrawString("Domicilio: "+domi+" "+dominro, Color.Black,
            //new RectangleF(0, 150, 900, 40), DevExpress.XtraPrinting.BorderSide.None);
            /*TextBrick brick9 = e.Graph.DrawString("Subtotal: "+lbtotal.Text, Color.Red,
            new RectangleF(0, 190, 900, 40), DevExpress.XtraPrinting.BorderSide.None);
            TextBrick brick10 = e.Graph.DrawString("Porcentaje: "+lbporcentaje.Text, Color.Red,
            new RectangleF(0, 210, 900, 40), DevExpress.XtraPrinting.BorderSide.None);
            TextBrick brick11 = e.Graph.DrawString("Total a Rendir: "+lbtotalg.Text, Color.Red,
            new RectangleF(0, 230, 900, 40), DevExpress.XtraPrinting.BorderSide.None);
            */
            //  TextBrick brick2 = e.Graph.DrawString(fecha, Color.Black,
            //  new RectangleF(0, 0, 820, 40), DevExpress.XtraPrinting.BorderSide.None);
            //brick2.HorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            //   brick1.HorzAlignment = HorzAlignment.Center;
            brick1.Font = new Font(FontFamily.GenericSansSerif, 16, FontStyle.Bold);
            brick2.Font = new Font(FontFamily.GenericSansSerif, 16, FontStyle.Bold);
            brick3.Font = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold);
            brick4.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
           // brick5.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
           // brick6.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
            brick7.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
           // brick8.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
           /* brick9.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
            brick10.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
            brick11.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);*/
            brick12.Font = new Font(FontFamily.GenericSansSerif, 16, FontStyle.Bold);

        }
        public void pl_CreateMarginalFooterArea(object sender, CreateAreaEventArgs e)
        {
            string desti = "Listado de derivaciones por Anexo/Item: ";
            TextBrick brick1 = e.Graph.DrawString(desti, Color.Black,
               new RectangleF(0, 0, 620, 20), DevExpress.XtraPrinting.BorderSide.None);
            brick1.HorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            brick1.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);

        }
        public void pl_CreateMarginalFooterArea2(object sender, CreateAreaEventArgs e)
        {
            string desti = "Listado de derivaciones por Anexo/Item: ";
            TextBrick brick1 = e.Graph.DrawString(desti, Color.Black,
               new RectangleF(0, 0, 620, 20), DevExpress.XtraPrinting.BorderSide.None);
            brick1.HorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            brick1.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);

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

            // gridViewPintarFilas.OptionsView.ShowFooter = true;
            gridViewPintarFilas.OptionsView.ShowFooter = true;
            //pl.CreateMarginalFooterArea += new CreateAreaEventHandler(pl_CreateMarginalFooterArea);
            //pl.CreateReportFooterArea += new CreateAreaEventHandler(pl_CreateMarginalFooterArea2);
           // pl. = "algo";
           
            pl.ShowPreview();
           
        }

        private void gConsulta_Click(object sender, EventArgs e)
        {

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
    }
}
