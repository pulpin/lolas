using DevExpress.XtraPrinting;
using LogicaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class ArqueodeCaja : Form
    {
        string _codigo;
        int _pcide, _alta;
        Rendiciones ren = new Rendiciones();
        public ArqueodeCaja()
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

           // fechadesde.EditValue = DateTime.Today;
            
        }

        public void colocardiaactual()
        {
            fechadesde.EditValue = DateTime.Today;
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
            /*PrintableComponentLink pl = new PrintableComponentLink(new PrintingSystem());
            pl.Component = chartControl1;
            
            pl.CreateMarginalHeaderArea += new CreateAreaEventHandler(pl_CreateReportHeaderArea);
            pl.CreateReportHeaderArea += new CreateAreaEventHandler(pl_CreateReportHeaderArea2);
            pl.PaperKind = System.Drawing.Printing.PaperKind.A4;
            pl.Margins = new System.Drawing.Printing.Margins(20, 20, 20, 20);
            pl.Landscape = true;
            pl.CreateDocument();
            
            pl.ShowPreview();
            */
            imprimirtiqueadora();
        }

        private void imprimirtiqueadora()
        {
            string cabecera = "DISTRIBUIDORA AC SANTA CRUZ";
            string dire = "Fagnano 197/9  Tel. 02966-437670";
            string dire2 = "(9400) Rio Gallegos - Santa Cruz";
            string dire3 = "e-mail lolasdbacsantacruz@gmail.com";
            string dire4 = "ALVADO JUAN CARLOS";
            string dire5 = "CUIT Nro.: 20-13393350-7";
            
            string dire10 = "Fecha: " + DateTime.Now;


            PrintDocument p = new PrintDocument();
            p.PrintPage += (s, e) =>
            {
                e.Graphics.DrawString(cabecera,
                                         new Font("Times New Roman", 12),
                                         new SolidBrush(Color.Black),
                                         new RectangleF(10, 5, p.DefaultPageSettings.PrintableArea.Width,
                                                         p.DefaultPageSettings.PrintableArea.Height));

                e.Graphics.DrawString(dire,
                                     new Font("Times New Roman", 11),
                                     new SolidBrush(Color.Black),
                                     new RectangleF(5, 35, p.DefaultPageSettings.PrintableArea.Width,
                                                     p.DefaultPageSettings.PrintableArea.Height));

                e.Graphics.DrawString(dire2,
                                     new Font("Times New Roman", 11),
                                     new SolidBrush(Color.Black),
                                     new RectangleF(5, 60, p.DefaultPageSettings.PrintableArea.Width,
                                                     p.DefaultPageSettings.PrintableArea.Height));
                e.Graphics.DrawString(dire3,
                                     new Font("Times New Roman", 11),
                                     new SolidBrush(Color.Black),
                                     new RectangleF(5, 85, p.DefaultPageSettings.PrintableArea.Width,
                                                     p.DefaultPageSettings.PrintableArea.Height));
                e.Graphics.DrawString(dire4,
                                     new Font("Times New Roman", 11),
                                     new SolidBrush(Color.Black),
                                     new RectangleF(5, 110, p.DefaultPageSettings.PrintableArea.Width,
                                                     p.DefaultPageSettings.PrintableArea.Height));
                e.Graphics.DrawString(dire5,
                                    new Font("Times New Roman", 11),
                                    new SolidBrush(Color.Black),
                                    new RectangleF(5, 135, p.DefaultPageSettings.PrintableArea.Width,
                                                    p.DefaultPageSettings.PrintableArea.Height));

                

                e.Graphics.DrawString(dire10,
                                   new Font("Times New Roman", 11),
                                   new SolidBrush(Color.Black),
                                   new RectangleF(5, 190, p.DefaultPageSettings.PrintableArea.Width,
                                                   p.DefaultPageSettings.PrintableArea.Height));


                //imprime productos
               // string productodesc, cantidad, precio, iva, codigointerno, imprimeproducto, imprimeprecioporcanti, preciosubim, preciototalim;
                //double preciod, preciosub, preciototal;
                int linea = 240;
               // int linea2 = 0;
               
                linea = linea + 10;
                //preciototal = Convert.ToDouble(lbtotalg.Text);
                /*preciototalim = string.Format("{0:N2}", "Dinero");
                e.Graphics.DrawString("TOTAL",
                                  new Font("Times New Roman", 11),
                                  new SolidBrush(Color.Black),
                                  new RectangleF(10, linea, p.DefaultPageSettings.PrintableArea.Width,
                                                  p.DefaultPageSettings.PrintableArea.Height));

                e.Graphics.DrawString(preciototalim,
                                  new Font("Times New Roman", 11),
                                  new SolidBrush(Color.Black),
                                  new RectangleF(210, linea, p.DefaultPageSettings.PrintableArea.Width,
                                                  p.DefaultPageSettings.PrintableArea.Height));*/

               // linea = linea + 40;
                e.Graphics.DrawString("Efectivo",
                                 new Font("Times New Roman", 10),
                                 new SolidBrush(Color.Black),
                                 new RectangleF(5, linea, p.DefaultPageSettings.PrintableArea.Width,
                                                 p.DefaultPageSettings.PrintableArea.Height));

                e.Graphics.DrawString(txtdinerocaja.Text,
                                 new Font("Times New Roman", 10),
                                 new SolidBrush(Color.Black),
                                 new RectangleF(205, linea, p.DefaultPageSettings.PrintableArea.Width,
                                                 p.DefaultPageSettings.PrintableArea.Height));

                linea = linea + 30;
                e.Graphics.DrawString("Ventas y ajustes",
                                 new Font("Times New Roman", 10),
                                 new SolidBrush(Color.Black),
                                 new RectangleF(5, linea, p.DefaultPageSettings.PrintableArea.Width,
                                                 p.DefaultPageSettings.PrintableArea.Height));

                e.Graphics.DrawString(txttotalventas.Text,
                                 new Font("Times New Roman", 10),
                                 new SolidBrush(Color.Black),
                                 new RectangleF(205, linea, p.DefaultPageSettings.PrintableArea.Width,
                                                 p.DefaultPageSettings.PrintableArea.Height));

                linea = linea + 30;
                e.Graphics.DrawString("Dinero en caja",
                                 new Font("Times New Roman", 10),
                                 new SolidBrush(Color.Black),
                                 new RectangleF(5, linea, p.DefaultPageSettings.PrintableArea.Width,
                                                 p.DefaultPageSettings.PrintableArea.Height));

                e.Graphics.DrawString(txtingresototal.Text,
                                 new Font("Times New Roman", 10),
                                 new SolidBrush(Color.Black),
                                 new RectangleF(205, linea, p.DefaultPageSettings.PrintableArea.Width,
                                                 p.DefaultPageSettings.PrintableArea.Height));

                linea = linea + 30;
                e.Graphics.DrawString("Diferencia",
                                 new Font("Times New Roman", 10),
                                 new SolidBrush(Color.Black),
                                 new RectangleF(5, linea, p.DefaultPageSettings.PrintableArea.Width,
                                                 p.DefaultPageSettings.PrintableArea.Height));
               // linea = linea + 30;
                e.Graphics.DrawString(txtdiferencia.Text,
                                 new Font("Times New Roman", 10),
                                 new SolidBrush(Color.Black),
                                 new RectangleF(205, linea, p.DefaultPageSettings.PrintableArea.Width,
                                                 p.DefaultPageSettings.PrintableArea.Height));
         

            };

            p.Print();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtingresototal.Text != string.Empty)&&(txttarjetascaja.Text != string.Empty))
            {
                int todos;
                decimal subtotal, diferencia, ingresotot,tarjetascaja,totalenlacaja;
                DineroCaja dc = new DineroCaja();
                LogicaNegocios.Venta ve = new LogicaNegocios.Venta();

                DateTime fdesde = Convert.ToDateTime(fechadesde.EditValue);
                string fdesdee = fdesde.ToString("yyyy-MM-dd");
                
                string dinerodelacaja = dc.spConsultaCajadeDia(Convert.ToInt32(LUpunto.EditValue), fdesdee);
                if (this.Alta == 0)
                { 
                    this.PCIde = dc.Ide;
                }
                dinerodelacaja = dinerodelacaja.Replace(".", ",");
                decimal dinerodelacajad = Convert.ToDecimal(dinerodelacaja);
                txtdinerocaja.Text = dinerodelacaja;

                if (chbTitulo.Checked == true)
                {
                    todos = 1;
                }
                else
                {
                    todos = 0;
                }

                gConsulta.DataSource = ve.Mostrar_ventasporfecha(fdesdee, fdesdee, Convert.ToInt32(LUpunto.EditValue), Convert.ToInt32(LUusuarios.EditValue), todos);

                decimal importesumaefe = 0, importetarjeta = 0, importeajuste = 0;
                int tipopag = 0;
                for (int i = 0; i < gridViewPintarFilas.DataRowCount; i++)
                {
                    // ren.Factura = gridViewPintarFilas.GetRowCellValue(i, "PREN_FACTU").ToString();
                    tipopag = Convert.ToInt32(gridViewPintarFilas.GetRowCellValue(i, "TIP_IDE").ToString());
                    if (tipopag == 1)
                    {
                        importesumaefe = importesumaefe + Convert.ToDecimal(gridViewPintarFilas.GetRowCellValue(i, "total").ToString());
                    }
                    else if (tipopag == 0)
                    {
                        importeajuste = importeajuste + Convert.ToDecimal(gridViewPintarFilas.GetRowCellValue(i, "total").ToString());
                    }
                    else
                    {
                        importetarjeta = importetarjeta + Convert.ToDecimal(gridViewPintarFilas.GetRowCellValue(i, "total").ToString());
                    }
                }
                importesumaefe = decimal.Round(importesumaefe, 2);
                importetarjeta = decimal.Round(importetarjeta, 2);
                importeajuste = decimal.Round(importeajuste, 2);
                //importetotalventas = importesumaefe + importeajuste;
                txtefectivo.Text = Convert.ToString(importesumaefe);
                txttarjeta.Text = Convert.ToString(importetarjeta);
                txtajustes.Text = Convert.ToString(importeajuste);
               // txttotalventas.Text = Convert.ToString(importetotalventas);
                //lbcreditop.Text = Convert.ToString(importesuma);
                subtotal = importesumaefe + dinerodelacajad + importetarjeta + importeajuste;
                txttotalventas.Text = Convert.ToString(subtotal);
                // txtingresototal.Text = Convert.ToString(subtotal);
                ingresotot = Convert.ToDecimal((txtingresototal.Text).Replace(".", ","));
                tarjetascaja = Convert.ToDecimal((txttarjetascaja.Text).Replace(".", ","));
                totalenlacaja = ingresotot + tarjetascaja;
                txttotalencaja.Text = Convert.ToString(totalenlacaja);

                diferencia = totalenlacaja - subtotal;
                txtdiferencia.Text = Convert.ToString(diferencia);
                btnGuardar.Visible = true;

            }
            else
            {
                MessageBox.Show("Debe ingresar el dinero que tiene en la caja y el importe de tarjetas");
            }
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

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
                DineroCaja dc = new DineroCaja();
                dc.Totalefectivo = (txtefectivo.Text).Replace(",", ".");
                dc.Totaltarjeta = (txttarjeta.Text).Replace(",", ".");
                dc.Totalajuste = (txtajustes.Text).Replace(",", ".");
                dc.Subtotalvta = (txttotalventas.Text).Replace(",", ".");
                dc.DineroCaja1 = (txtingresototal.Text).Replace(",", ".");
                dc.Tarjetaencaja = (txttarjetascaja.Text).Replace(",", ".");
                dc.Subtotalencaja = (txttotalencaja.Text).Replace(",", ".");
                dc.Diferencia = (txtdiferencia.Text).Replace(",", ".");
                dc.Ide = this.PCIde;
                dc.Alta = this.Alta;
                int valor = dc.spAltaArqueo();
                if (valor == 0)
                {
                    if (this.Alta == 1)
                    {
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                    //this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    MessageBox.Show("Se ha dado de alta el Arqueo");
                }
           
        }
        public void Colocardatos(int pcide, DateTime Fecha,string dinero, int puntodevta, string totalefec, string totaltarje, string totalajus, string subtoventas, string dineroencaja, string tarjetaencaja, string subencaja, string diferencia)
        {
            LUpunto.EditValue = puntodevta;
            LUpunto.Enabled = false;
            fechadesde.EditValue = new DateTime(Fecha.Year,Fecha.Month,Fecha.Day);

            //DateTime fdesde = Convert.ToDateTime(fechadesde.EditValue);
            //string fdesdee = fdesde.ToString("yyyy-MM-dd");
            this.PCIde = pcide;
            fechadesde.Enabled = false;
            txtdinerocaja.Text = dinero;
            txtefectivo.Text = totalefec;
            txttarjeta.Text = totaltarje;
            txtajustes.Text = totalajus;
            txttotalventas.Text = subtoventas;
            txtingresototal.Text = dineroencaja;
            txttarjetascaja.Text = tarjetaencaja;
            txttotalencaja.Text = subencaja;
            txtdiferencia.Text = diferencia;
            //btnGuardar.Enabled = false;
            btnGuardar.Text = "Modificar";

        }
        public int PCIde
        {
            get { return this._pcide; }
            set { this._pcide = value; }
        }
        public int Alta
        {
            get { return this._alta; }
            set { this._alta = value; }
        }
    }
}
