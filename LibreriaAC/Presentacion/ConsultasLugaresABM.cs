﻿using DevExpress.XtraPrinting;
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
    public partial class ConsultasLugaresABM : Form
    {
        string _codigo;
        Deposito dep = new Deposito();
        public ConsultasLugaresABM()
        {
            InitializeComponent();
        }

        private void ConsultasConsignas_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            
            gConsulta.DataSource = dep.Mostrar_depositodetalleLugares();
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
        public void colocarcodigo()
        {
            lbrendicion.Text = this.Codigo;
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

        private void btnaltacliente_Click(object sender, EventArgs e)
        {
            AltaDepositoABM ad = new AltaDepositoABM();
            ad.Codigo = this.Codigo;
            ad.Habia = 0;
            ad.Ide = 0;
            ad.Alta = 1;
            if (ad.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //gConsulta.DataSource = cli.Mostrar_clientes();
                this.cargar();
            }
            
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            AltaDepositoABM ad = new AltaDepositoABM();
            ad.Codigo = this.Codigo;
            ad.Alta = 0;
            //ad. = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["DEPO_CANTIDAD"]));
            //ad.Habia = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["DEPO_CANTIDAD"]));
            ad.LugaresABM = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LUD_DESC"]));
            ad.Ide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LUD_IDE"]));
            ad.colocardatos();
            if (ad.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //gConsulta.DataSource = cli.Mostrar_clientes();
                this.cargar();
            }
        }

        private void btnborrarusu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el stock de este lugar?", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Deposito ad = new Deposito();
                ad.Codigo = this.Codigo;
                ad.Alta = 0;
                ad.Cantidad = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["DEPO_CANTIDAD"]));
                ad.Habia = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["DEPO_CANTIDAD"]));
                ad.Lugar = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["DEPO_LUD_IDE"]));
                ad.Depoide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["DEPO_IDE"]));

                int valor = ad.spBajaDeposito();

                this.cargar();
            }
        }

        private void btnhistorico_Click(object sender, EventArgs e)
        {
            ConsultasLugaresHis clh = new ConsultasLugaresHis();
            clh.Codigo = this.Codigo;
            clh.colocarcodigo();
            clh.ShowDialog();
        }
    }
}
