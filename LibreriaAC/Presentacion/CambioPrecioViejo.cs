using LogicaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Viejo : Form
    {
        Productos pro = new Productos();
       // int rendicionide;
        int codigoproveeausar;
        int tipop = 0;

        public Viejo()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void AltaconsignaMae_Load(object sender, EventArgs e)
        {

        }


        private void Modificarprecio()
        {
            string isbn,precio,nalta;
            Decimal valor1, valor2;
            int valor3;

            
            isbn = gridViewPintarFilas.GetRowCellValue(0, "isbn").ToString();

            int cantidad = isbn.Length;
            if (rbbarra.Checked)
            {
                tipop = 0;
                if (cantidad < 12)
                {
                    DialogResult result = MessageBox.Show("Está seguro que la lista de precios que va a modificar posee BARRA?", "Atención", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        //aqui el codigo
                        return;
                    }
                    

                }

            }
            else
            {
                tipop = 1;
                if (cantidad > 10)
                {
                    DialogResult result = MessageBox.Show("Está seguro que la lista de precios que va a modificar posee ISBN?", "Atención", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        //aqui el codigo
                        return;
                    }
                }
            }

            for (int i = 0; i < gridViewPintarFilas.DataRowCount; i++)
            {
                isbn = gridViewPintarFilas.GetRowCellValue(i, "isbn").ToString();
                          
                precio = gridViewPintarFilas.GetRowCellValue(i, "precio").ToString();
                pro.spConCambioPrecio(isbn,precio,tipop);
                //es es diferente de cero existe
                valor1 = pro.Primervalordecimal;
                //acá está la diferencia
                valor2 = pro.Segundovalordecimal;
                valor3 = pro.Tercervalorint;
                if (valor3 == 1)
                {
                    nalta = "ALTA";
                }
                else if (valor3 == 2)
                {
                    nalta = "MODIFICAR";
                }
                else
                {
                    nalta = "NO";
                }

                gridViewPintarFilas.SetRowCellValue(i, "precioactual",valor1);
                gridViewPintarFilas.SetRowCellValue(i, "diferencia", valor2);
                gridViewPintarFilas.SetRowCellValue(i, "modificar", nalta);
                
                 /*   if (valor3 == 2)
                    {
                        gridViewPintarFilas.SetRowCellValue(i, "modifica", valor3);
                    }
                    else if (valor3 == 1)
                    {
                        gridViewPintarFilas.SetRowCellValue(i, "modifica", 2);
                    }
                    else
                    {
                        gridViewPintarFilas.SetRowCellValue(i, "modifica", 0);
                    }
                
            */
                  /*  if (valor1 > 0)
                    {
                        //pregunto si hay diferencia de precios
                        if (valor2 > 0)
                        {
                            // si hay diferencia, entonces marco que hay que modificar.
                            gridViewPintarFilas.SetRowCellValue(i, "modifica", 1);
                        }
                        else
                        {
                            // acá marco que no se hace nada.
                            gridViewPintarFilas.SetRowCellValue(i, "modifica", 0);
                        }

                    }
                    else
                    {
                        // es nuevo, dar de alta.
                        gridViewPintarFilas.SetRowCellValue(i, "modifica", 2);
                    }
       
             */

            }

        }


        private void ModificarprecioNuevaGrilla()
        {
            string isbn, precio, nalta;
            Decimal valor1, valor2;
            int valor3;

            int tipop = 0;

            //isbn = gridViewPintarFilas.GetRowCellValue(0, "isbn").ToString();
            isbn = Convert.ToString(dgvProductos.CurrentRow.Cells[0].Value);

            int cantidad = isbn.Length;
            if (rbbarra.Checked)
            {
                tipop = 0;
                if (cantidad < 12)
                {
                    DialogResult result = MessageBox.Show("Está seguro que la lista de precios que va a modificar posee BARRA?", "Atención", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        //aqui el codigo
                        return;
                    }


                }

            }
            else
            {
                tipop = 1;
                if (cantidad > 10)
                {
                    DialogResult result = MessageBox.Show("Está seguro que la lista de precios que va a modificar posee ISBN?", "Atención", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        //aqui el codigo
                        return;
                    }
                }
            }
            double precioasacar = Convert.ToDouble(dgvProductos.RowCount);
            //dgvProductos.Columns.Add("");
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {

                isbn = Convert.ToString(row.Cells[0].Value);
                precio = Convert.ToString(row.Cells[4].Value);
                pro.spConCambioPrecio(isbn, precio, tipop);
                valor1 = pro.Primervalordecimal;
                //acá está la diferencia
                valor2 = pro.Segundovalordecimal;
                valor3 = pro.Tercervalorint;
                if (valor3 == 1)
                {
                    nalta = "ALTA";
                }
                else if (valor3 == 2)
                {
                    nalta = "MODIFICAR";
                }
                else
                {
                    nalta = "NO";
                }
                
                row.Cells[5].Value = valor1;
                row.Cells[6].Value = valor2;
                row.Cells[7].Value = nalta;
            }
    

    
        }

        private void Modificarprecioarticulos()
        {
            string npproveedor, npcodigo, costo, modif;
            Decimal valor1, valor2, valor3,valor4,nuevovalor, nuevovalor2,diferencia;

          //  npproveedor = gridViewPintarFilas.GetRowCellValue(0, "proveedor").ToString();
           // npcodigo = gridViewPintarFilas.GetRowCellValue(0, "codigo").ToString();

            for (int i = 0; i < gridViewPintarFilas.DataRowCount; i++)
            {
                npproveedor = gridViewPintarFilas.GetRowCellValue(i, "proveedor").ToString();
                npcodigo = gridViewPintarFilas.GetRowCellValue(i, "codigo").ToString();

                costo = gridViewPintarFilas.GetRowCellValue(i, "costo").ToString();
                costo = Convert.ToString(Math.Round(Convert.ToDecimal(costo), 2));
                pro.spConCambioPrecioArticulos(npproveedor, npcodigo, costo);
                //es es diferente de cero existe
                valor1 = pro.Cuartovalordecimal;
                //acá está la diferencia
                valor2 = pro.Quintovalordecimal;
                valor3 = pro.Sextovalordecimal;
                valor4 = pro.Septimovalordecimal;
                nuevovalor = Convert.ToDecimal(costo) + (Convert.ToDecimal(costo) * valor2 / 100);
                nuevovalor2 = Convert.ToDecimal(nuevovalor) + (Convert.ToDecimal(nuevovalor) * valor4 / 100);
                nuevovalor2 = Math.Round(nuevovalor2, 0);
                valor3 = Math.Round(valor3, 0);
                diferencia = nuevovalor2 - valor3;
                if (diferencia > 0)
                {
                    modif = "SI";
                }
                else {
                    modif = "NO";
                }
                if (valor1 == 0)
                {
                    modif = "NUEVO";
                }
                //  nuevovalor = nuevovalor valor3+ (nuevovalor * valor4 / 100);
                // nuevovalor = Math.Truncate((nuevovalor * 1000) / 1000);
                /* if (valor3 == 1)
                 {
                     nalta = "ALTA";
                 }
                 else if (valor3 == 2)
                 {
                     nalta = "MODIFICAR";
                 }
                 else
                 {
                     nalta = "NO";
                 }*/

                gridViewPintarFilas.SetRowCellValue(i, "costoactual", valor1);
                gridViewPintarFilas.SetRowCellValue(i, "IVAactual", valor2);
                gridViewPintarFilas.SetRowCellValue(i, "precioactual", valor3);
                gridViewPintarFilas.SetRowCellValue(i, "porcentaje", valor4);
                gridViewPintarFilas.SetRowCellValue(i, "precionuevo", nuevovalor2);
                gridViewPintarFilas.SetRowCellValue(i, "diferencia", diferencia);
                gridViewPintarFilas.SetRowCellValue(i, "modificar", modif);

            }

        }

        private void dardealta(Productos pro, int i)
        {

                string precio2;
                precio2 = gridViewPintarFilas.GetRowCellValue(i, "precio").ToString();
                //si es vacio es que no existe el articulo, crear nuevo
                pro.Titulo = gridViewPintarFilas.GetRowCellValue(i, "titulo").ToString();
                pro.Autor = gridViewPintarFilas.GetRowCellValue(i, "autor").ToString();
                string edi1 = gridViewPintarFilas.GetRowCellValue(i, "edi").ToString();
                pro.Editorial = Convert.ToInt32(edi1);
                pro.Genero = 1;
                pro.Precio = precio2;
                pro.Cantidad = 0;
                pro.Costo = "0";
                pro.Iva = "0";
                pro.Ganancia = "0";
                pro.Factura = string.Empty;

                if (rbbarra.Checked)
                {
                    string barra1 = gridViewPintarFilas.GetRowCellValue(i, "isbn").ToString(); ;
                    string isbn1 = barra1.Substring(3, 10);
                    pro.Isbn = isbn1;
                    pro.Barra = gridViewPintarFilas.GetRowCellValue(i, "isbn").ToString(); ;
                }
                else
                {
                    //pro.Barra = "0";
                    pro.Isbn = gridViewPintarFilas.GetRowCellValue(i, "isbn").ToString(); ;
                    pro.Barra = "987" + pro.Isbn;
            }
                pro.Imagen = string.Empty;
                pro.Tipo = 0;
                pro.Cuerpo = string.Empty;
                pro.Estante = string.Empty;
                string valor = pro.spInsertarProducto();
                if (valor != "error")
                {
                    //MessageBox.Show("se dió de alta");
                }
         
        }

        private void dardealtaNuevaGrilla(Productos pro, int i)
        {

           // string precio2;
            //precio2 = gridViewPintarFilas.GetRowCellValue(i, "precio").ToString();
            //precio2 = Convert.ToString(row.Cells[0].Value);
            //si es vacio es que no existe el articulo, crear nuevo
            pro.Titulo = gridViewPintarFilas.GetRowCellValue(i, "titulo").ToString();
            pro.Autor = gridViewPintarFilas.GetRowCellValue(i, "autor").ToString();
            string edi1 = gridViewPintarFilas.GetRowCellValue(i, "edi").ToString();
            pro.Editorial = Convert.ToInt32(edi1);
            pro.Genero = 1;
          //  pro.Precio = precio2;
            pro.Cantidad = 0;
            pro.Costo = "0";
            pro.Iva = "0";
            pro.Ganancia = "0";
            pro.Factura = string.Empty;

            if (rbbarra.Checked)
            {
                string barra1 = gridViewPintarFilas.GetRowCellValue(i, "isbn").ToString(); ;
                string isbn1 = barra1.Substring(3, 10);
                pro.Isbn = isbn1;
                pro.Barra = gridViewPintarFilas.GetRowCellValue(i, "isbn").ToString(); ;
            }
            else
            {
                //pro.Barra = "0";
                pro.Isbn = gridViewPintarFilas.GetRowCellValue(i, "isbn").ToString(); ;
                pro.Barra = "987" + pro.Isbn;
            }
            pro.Imagen = string.Empty;
            pro.Tipo = 0;
            pro.Cuerpo = string.Empty;
            pro.Estante = string.Empty;
            string valor = pro.spInsertarProducto();
            if (valor != "error")
            {
                //MessageBox.Show("se dió de alta");
            }

        }

        private void modificarproducto(Productos pro, int i)
        {
            int titu=0,edit=0;

            //titulo y autor
            if (chbTitulo.Checked == true)
            {
                titu = 1;
            }

            if (chbEditorial.Checked == true)
            {
                edit = 1;
            }

            string precio2,precioante;
            precio2 = gridViewPintarFilas.GetRowCellValue(i, "precio").ToString();

            precioante = gridViewPintarFilas.GetRowCellValue(i, "precioactual").ToString();
            //si es vacio es que no existe el articulo, crear nuevo
            pro.Titulo = gridViewPintarFilas.GetRowCellValue(i, "titulo").ToString();
            pro.Autor = gridViewPintarFilas.GetRowCellValue(i, "autor").ToString();
            string edi1 = gridViewPintarFilas.GetRowCellValue(i, "edi").ToString();
            pro.Editorial = Convert.ToInt32(edi1);
            pro.PrecioL = Convert.ToDecimal(precio2);
            pro.Precioante = Convert.ToDecimal(precioante);
            pro.titup = titu;
            pro.edip = edit;
            
            if (rbbarra.Checked)
            {
                pro.Barra = gridViewPintarFilas.GetRowCellValue(i, "isbn").ToString();
                pro.Isbn = "0";
            }
            else
            {
                pro.Barra = "0";
                pro.Isbn = gridViewPintarFilas.GetRowCellValue(i, "isbn").ToString(); ;
            }
            
            int valor = pro.spModificarProductoPrecios();
            if (valor == 0)
            {
                //MessageBox.Show("se dió de alta");
            }
        }

        private void modificarproductoArticulos(Productos pro, int i)
        {


           // string titulop, edip, precioante;
            pro.Codigoprovee = gridViewPintarFilas.GetRowCellValue(i, "proveedor").ToString();
            pro.Codigo = gridViewPintarFilas.GetRowCellValue(i, "codigo").ToString();
            pro.PrecioL = Convert.ToDecimal(gridViewPintarFilas.GetRowCellValue(i, "costo").ToString());
            pro.Precioante = Convert.ToDecimal(gridViewPintarFilas.GetRowCellValue(i, "precionuevo").ToString());
            
            int valor = pro.spModificarProductoPreciosArt();
            if (valor == 0)
            {
                //MessageBox.Show("se dió de alta");
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea realizar el cambio de precios?", "Opción", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                if (rBlibros.Checked == true)
                {
                    pictureBox1.Visible = true;
                    //recorrergrilla();
                    recorrergrillaNuevaGrilla();
                }
                else
                {
                    //articulos de lolasdb
                    pictureBox1.Visible = true;
                    recorrergrillaArticulos();

                    btndescontinuados.Visible = true;
                }
                

            }
            else
            {
                //presionó que no...

            }
            
        }

        private void recorrergrilla()
        {
            for (int i = 0; i < gridViewPintarFilas.DataRowCount; i++)
            {
                // no existe y se da de alta al nuevo producto.
                if (gridViewPintarFilas.GetRowCellValue(i, "modificar").ToString() == "ALTA")
                {
                    dardealta(pro, i);
                }
                // si existe y se modifica el producto.
                else if (gridViewPintarFilas.GetRowCellValue(i, "modificar").ToString() == "MODIFICAR")
                {

                    modificarproducto(pro, i);
                }

            }
            pictureBox1.Visible = false;
            gConsulta.DataSource = null;
            MessageBox.Show("Se ha realizado el cambio de precios...");

        }
        private void recorrergrillaNuevaGrilla()
        {

            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                if (Convert.ToString(row.Cells[7].Value) == "ALTA")
                {
                    //dardealta(pro, i);
                    MessageBox.Show("ALTA");
                  //  string precio2;
                   /* precio2 = gridViewPintarFilas.GetRowCellValue(i, "precio").ToString();
                    si es vacio es que no existe el articulo, crear nuevo
                    pro.Titulo = gridViewPintarFilas.GetRowCellValue(i, "titulo").ToString();
                    pro.Autor = gridViewPintarFilas.GetRowCellValue(i, "autor").ToString();
                    string edi1 = gridViewPintarFilas.GetRowCellValue(i, "edi").ToString();
                    pro.Editorial = Convert.ToInt32(edi1);
                    pro.Genero = 1;
                    pro.Precio = precio2;
                    pro.Cantidad = 0;
                    pro.Costo = "0";
                    pro.Iva = "0";
                    pro.Ganancia = "0";
                    pro.Factura = string.Empty;

                    if (rbbarra.Checked)
                    {
                        string barra1 = gridViewPintarFilas.GetRowCellValue(i, "isbn").ToString(); ;
                        string isbn1 = barra1.Substring(3, 10);
                        pro.Isbn = isbn1;
                        pro.Barra = gridViewPintarFilas.GetRowCellValue(i, "isbn").ToString(); ;
                    }
                    else
                    {
                        //pro.Barra = "0";
                        pro.Isbn = gridViewPintarFilas.GetRowCellValue(i, "isbn").ToString(); ;
                        pro.Barra = "987" + pro.Isbn;
                    }
                    pro.Imagen = string.Empty;
                    pro.Tipo = 0;
                    pro.Cuerpo = string.Empty;
                    pro.Estante = string.Empty;
                    int valor = pro.spInsertarProducto();
                    if (valor == 0)
                    {
                        //MessageBox.Show("se dió de alta");
                    }*/
                }
                else if(Convert.ToString(row.Cells[7].Value) == "MODIFICAR")
                {
                    //modificarproducto(pro, i);
                    MessageBox.Show("Modificarprecio");

                }

                
            }
                
            
            pictureBox1.Visible = false;
            gConsulta.DataSource = null;
            MessageBox.Show("Se ha realizado el cambio de precios...");

        }
        private void recorrergrillaArticulos()
        {
            int entra = 0;
            for (int i = 0; i < gridViewPintarFilas.DataRowCount; i++)
            {

                // si existe y se modifica el producto.
                if (gridViewPintarFilas.GetRowCellValue(i, "modificar").ToString() == "SI")
                {
                    if (entra == 0)
                    {
                        codigoproveeausar = Convert.ToInt32(gridViewPintarFilas.GetRowCellValue(i, "proveedor").ToString());
                        entra++;
                    }

                    modificarproductoArticulos(pro, i);
                }

            }
            pictureBox1.Visible = false;
            gConsulta.DataSource = null;
            MessageBox.Show("Se ha realizado el cambio de precios...");

        }
        private void btnbuscarventas_Click(object sender, EventArgs e)
        {
            /*Venta ve = new Venta();
            int codedi = Convert.ToInt32(lUEditorial.EditValue);

            DateTime fdesde = Convert.ToDateTime(desde.EditValue);
            string fdesdee = fdesde.ToString("yyyy-MM-dd");

            DateTime fhasta = Convert.ToDateTime(hasta.EditValue);
            string fhastae = fhasta.ToString("yyyy-MM-dd");

            
            gConsulta.DataSource = ve.Mostrar_ventasentrefechas(codedi,fdesdee,fhastae);
            if (gridViewPintarFilas.DataRowCount == 0)
            {
                MessageBox.Show("No existen ventas de libros consignados en esas fechas...");
            }
            */

            

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

        private void exportarAExcelToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (sfdRuta.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {

                gConsulta.ExportToXlsx(sfdRuta.FileName);

            }
        }

        private void exportarAPDFToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (sfdRuta1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                gConsulta.ExportToPdf(sfdRuta1.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

                string extension, constr = string.Empty;
                extension = Path.GetExtension(ruta.Text);

                if (extension == ".xlsx")
                {
                    constr = "Provider = MicroSoft.ACE.OLEDB.12.0; Data Source=" + ruta.Text + "; Extended Properties =\"Excel 12.0 Xml; HDR=Yes;IMEX=1\";";
                }
                else if (extension == ".xls")
                {
                    constr = "Provider = MicroSoft.Jet.OLEDB.4.0; Data Source=" + ruta.Text + "; Extended Properties =\"Excel 8.0; HDR=Yes;\";";
                }
                else
                {
                    MessageBox.Show("No se reconoce el tipo de formato del archivo. Debe ser Excel");            }
                //
 
               // string constr = "Provider = Microsoft.ACE.OLEDB.12.0; Extended Properties='Excel 12.0 Xml;HDR=Yes;IMEX=1';";
                OleDbConnection con = new OleDbConnection(constr);
                OleDbDataAdapter sda = new OleDbDataAdapter("Select * From [" + textBox2.Text + "$]", con);
                DataTable dt = new DataTable();

                sda.Fill(dt);
                gConsulta.DataSource = dt;
                dgvProductos.DataSource = dt;

            
        }

        private void btnabrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = " Archivos Excel (*.xlsx)|*.xlsx|Archivos Excel (*.xls)|*.xls";
            open.Title = "archivos Excel";
            if (open.ShowDialog() == DialogResult.OK)
            {
                ruta.Text = open.FileName;
            }
        }

        private void btndiferencia_Click(object sender, EventArgs e)
        {
            if (gridViewPintarFilas.DataRowCount == 0)
            {
                MessageBox.Show("No existen registros para poder realizar un cambioPrecio");
            }
            else
            {
                //libros
                if (rBlibros.Checked == true)
                {
                   //  this.ModificarprecioNuevaGrilla();
                    this.Modificarprecio();
                    btnagregar.Enabled = true;
                }
                else //articulos de lolasdb
                {
                    this.Modificarprecioarticulos();
                    btnagregar.Enabled = true;
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar éste registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                //DevExpress.XtraGrid.GridControl view = sender as DevExpress.XtraGrid.GridControl;


                if (this.gridViewPintarFilas.SelectedRowsCount > 0)
                {
                    gridViewPintarFilas.DeleteSelectedRows();
                }
            }
        }

        private void rBlolasdb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rBlibros_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btndescontinuados_Click(object sender, EventArgs e)
        {
            Productos pd = new Productos();
            gConsulta.DataSource = null;
            gridViewPintarFilas.Columns.Clear();
            gConsulta.DataBindings.Clear();
            /*
            gridViewPintarFilas.AddNewRow();
            int rowHandle = gridViewPintarFilas.GetRowHandle(gridViewPintarFilas.DataRowCount);
            if (gridViewPintarFilas.IsNewItemRow(rowHandle))
            {
                gridViewPintarFilas.SetRowCellValue(rowHandle, gridViewPintarFilas.Columns[0], "adsf");
                gridViewPintarFilas.SetRowCellValue(rowHandle, gridViewPintarFilas.Columns[1], "ffff");
                gridViewPintarFilas.SetRowCellValue(rowHandle, gridViewPintarFilas.Columns[2], "ccc");
            }
            */
            gConsulta.DataSource = pd.Mostrar_sincambiosdeprecio(codigoproveeausar);
        }
    }
}
