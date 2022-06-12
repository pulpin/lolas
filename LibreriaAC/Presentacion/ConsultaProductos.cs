using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicaNegocios;
using System.IO;

namespace Presentacion
{
    public partial class ConsultaProductos : Form
    {
        readonly Editorial edi = new Editorial();
        Productos pro = new Productos();
        readonly Genero gen = new Genero();
        ToolTip tol = new ToolTip();
        public ConsultaProductos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            /*if (txttitulo.Text == string.Empty && txtautor.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar el texto a buscar");

            }
            else
            {*/
                this.busquedaavanzada();
           // }
        }

        public void busquedasporprovee(string codprovee)
        {
            pro.Tipo = 1;
            pro.Barra = txtbarra.Text;
            pro.Codigo = txtcodigo.Text;
            pro.Codigoprovee = codprovee;
            pro.Isbn = txtisbn.Text;
            gConsulta.DataSource = pro.Mostrar_productos();
            txtbarra.Text = string.Empty;
            txtcodigo.Text = string.Empty;
            txtprovee.Text = string.Empty;
            txtisbn.Text = string.Empty;
            this.cargardatos();
        }

        private void busquedasimple()
        {
            pro.Tipo = 1;
            pro.Barra = txtbarra.Text;
            pro.Codigo = txtcodigo.Text;
            pro.Codigoprovee = txtprovee.Text;
            pro.Isbn = txtisbn.Text;
            gConsulta.DataSource = pro.Mostrar_productos();
            /*txtbarra.Text = string.Empty;
            txtcodigo.Text = string.Empty;
            txtprovee.Text = string.Empty;
            txtisbn.Text = string.Empty;*/
            this.limpiartextos();
            this.cargardatos();
            //this.cargardatos();
        }
              

        private void busquedaavanzada()
        {
            pro.Tipo = 0;
            pro.Titulo = txttitulo.Text;
            pro.Editorial = Convert.ToInt32(cBEeditorial.EditValue);
            pro.Genero = Convert.ToInt32(lUEgenero.EditValue);
            if (chbpalabra.Checked == true)
            {
                pro.Contengapalabra = 1;
            }
            else
            {
                pro.Contengapalabra = 0;
            }
            pro.Autor = txtautor.Text;

            gConsulta.DataSource = pro.Mostrar_productos();
            this.limpiartextos();
            this.cargardatos();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            /*Boolean respuesta;
            string x = "X";
            string p = "P";
          //  respuesta = this.axPrinterFiscal1.CloseJournal(ref x,ref p);
          */

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }



        private void limpiartextos()
        {
            txttitulo.Text = string.Empty;
            txtautor.Text = string.Empty;
            chbpalabra.Checked = false;
        }
        private void blimpiar_Click(object sender, EventArgs e)
        {
            this.limpiartextos();
            this.cBEeditorial.EditValue = null;
            this.lUEgenero.EditValue = null;

            this.cargarcombos();

        }

        private void cargarcombos()
        {

            cBEeditorial.Properties.DisplayMember = "EDI_EDITORIAL";
            cBEeditorial.Properties.ValueMember = "EDI_CODIGO";
            cBEeditorial.Properties.DataSource = edi.Tabladedatos_editoriales();
            cBEeditorial.Properties.PopulateColumns();
            cBEeditorial.Properties.Columns[0].Visible = false;
           // cBEeditorial.Properties.Columns[1].Visible = false;

            lUEgenero.Properties.DataSource = gen.Tabladedatos_genero();
            lUEgenero.Properties.DisplayMember = "GEN_DESC";
            lUEgenero.Properties.ValueMember = "GEN_IDE";
            lUEgenero.Properties.PopulateColumns();
            lUEgenero.Properties.Columns[0].Visible = false;
        }
        private void ConsultaProductos_Load(object sender, EventArgs e)
        {
            this.cargarcombos();
            tol.SetToolTip(this.bbuscar,"Buscar");
            tol.SetToolTip(this.blimpiar, "Limpiar todos los textos");
            tol.SetToolTip(this.btnagregar, "Agregar un nuevo producto");
            tol.SetToolTip(this.btnmodificar, "Modificar producto");
            tol.SetToolTip(this.btneliminar, "Eliminar producto");
            tol.SetToolTip(this.btnzoom, "Ver imagen en tamaño completo");
            if (LogicaNegocios.Globales.accesoaproductos == 2 || LogicaNegocios.Globales.accessocuerpoestante == 1)
            {
                btnmodificar.Enabled = true;
            }
            if (LogicaNegocios.Globales.eliminarproductos == 2)
            {
                btneliminar.Enabled = true;
            }
            txtbarra.Focus();
        }

        private void textBox2_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {

        }

        private void txtbarra_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //buscar acá
                busquedasimple();
                txtbarra.Text = "";
            }
        }



        private void activartexbox(TextBox texboxentrada)
        {
            texboxentrada.BackColor = SystemColors.InactiveBorder; 
        }
        private void desactivartexbox(TextBox texboxentrada)
        {
            texboxentrada.BackColor = Color.White;
        }

        private void txttitulo_Enter(object sender, EventArgs e)
        {
            this.activartexbox(txttitulo);
        }

        private void txttitulo_Leave(object sender, EventArgs e)
        {
            this.desactivartexbox(txttitulo);
        }
        private void txtautor_Enter(object sender, EventArgs e)
        {
            this.activartexbox(txtautor);
        }

        private void txtautor_Leave(object sender, EventArgs e)
        {
            this.desactivartexbox(txtautor);
        }

        private void txtbarra_Enter(object sender, EventArgs e)
        {
            this.activartexbox(txtbarra);
        }

        private void txtbarra_Leave(object sender, EventArgs e)
        {
            this.desactivartexbox(txtbarra);
        }

        private void txtisbn_Enter(object sender, EventArgs e)
        {
            this.activartexbox(txtisbn);
        }

        private void txtisbn_Leave(object sender, EventArgs e)
        {
            this.desactivartexbox(txtisbn);
        }

        private void txtcodigo_Enter(object sender, EventArgs e)
        {
            this.activartexbox(txtcodigo);
        }

        private void txtcodigo_Leave(object sender, EventArgs e)
        {
            this.desactivartexbox(txtcodigo);
        }

        private void txttitulo_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //buscar acá
                this.busquedaavanzada();
                
            }
        }

        private void txtautor_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //buscar acá
                this.busquedaavanzada();
                
            }
        }



        private void cargardatos()
        {
            lbtitulo.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_DESC"]));
            lbprecio.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_PRECIO"]));
            lbprecio2.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["li_precioori"]));
            int stock = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_STOCK"]));
            if (stock > 0 && stock < 5)
            {
                pbcirculo.Image = Presentacion.Properties.Resources.circuloamarillo30;
            }
            else if (stock < 1)
            {
                pbcirculo.Image = Presentacion.Properties.Resources.circulorojo30;
            }
            else
            {
                pbcirculo.Image = Presentacion.Properties.Resources.circuloverde30;
            }
            lbstock.Text = Convert.ToString(stock);
            string imagen = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_IMAGEN"]));
            string path = Directory.GetCurrentDirectory();
            if (imagen != string.Empty)
            {
                var carpeta = @"\\10.1.10.198\Utilidadeslolasdb\";
                string fullpath = System.IO.Path.Combine(carpeta, string.Format("libros\\{0}", imagen));
                pbimagen.Image = new System.Drawing.Bitmap(fullpath);

            }
            else
            {
                pbimagen.Image = Presentacion.Properties.Resources.no_disponible;
            }
            lbbarra.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_BARRA"]));
            lbisbn.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_ISBN"]));
            lbcodinterno.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_CODIGO"]));
            lbcuerpo.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_CUERPO"]));
            lbestante.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_ESTANTE"]));
            lbeditorial.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["EDI_EDITORIAL"]));
            lbgenero.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["GEN_DESC"]));
            lbcodprovee.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_CODIGOPROVEE"]));
            lbpedidos.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_PEDIDOS"]));
            lbultimaap.Text = "";
            if (Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_FECHAPRE"])) != "")
            {
                DateTime fechaactu = Convert.ToDateTime(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_FECHAPRE"]));
                lbultimaap.Text = fechaactu.ToShortDateString();
            }
            int inven = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_INVENTA"]));
            if (inven == 1)
            {
                DateTime fechainventa = Convert.ToDateTime(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_FEC_INVEN"]));
                lbfechainventario.Text = fechainventa.ToShortDateString();
            }
            else
            {
                lbfechainventario.Text = "";
            }
            pro.Codigo = lbcodinterno.Text;
            int esconsigna = pro.spConsultasiesConsignado();
            if (esconsigna == 0)
            {
                // MessageBox.Show("Propio");
                panel3.BackColor = SystemColors.GradientInactiveCaption;
            }
            else
            {
                panel3.BackColor = Color.LightGreen;
            }
        }

        private void gridViewPintarFilas_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.cargardatos();
        }

        private void btnzoom_Click(object sender, EventArgs e)
        {
            try
            {
                ImagenCompleta ic = new ImagenCompleta();
                //ic.PonerImagen(System.Drawing.Bitmap.FromStream(this.ms));
                
                ic.PonerImagen(pbimagen.Image);
                ic.ShowDialog();
            }
            catch
            {
                MessageBox.Show("No hay imágenes para mostrar");
            }
        }

        private void btngoogle_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com.ar/search?q= "+ lbbarra.Text + " &source=lnms&tbm=isch&sa=X&ved=0ahUKEwinis2r9oDPAhXBIJAKHSdLBeYQ_AUICCgB&biw=1024&bih=662");
        }

        private void txtisbn_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //buscar acá
                this.busquedasimple();
                
            }
        }

        private void txtcodigo_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //buscar acá
                this.busquedasimple();

            }
        }

        public void cambiarfondo()
        {
            this.BackColor = Globales.colorfondo;
            panel1.BackColor = Globales.colorfondo;

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            AltaProducto ap = new AltaProducto();
            ap.Alta = 1;
            if (ap.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gConsulta.DataSource = pro.Mostrar_productos();
            }
                
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            var topRowIndex = gridViewPintarFilas.TopRowIndex;
            var focusedRowHandle = gridViewPintarFilas.FocusedRowHandle;
            Productos pro2 = new Productos();
            pro2.productoide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_IDE"]));
            pro2.Codigo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_CODIGO"]));
            pro2.Titulo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_DESC"]));
            pro2.Autor = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_AUTOR"]));
            pro2.Editorial = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_EDI_CODIGO"]));
            pro2.Genero = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_GEN_IDE"]));
            // pro.Precio = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_PRECIO"]));
            pro2.Precio = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["li_precioori"]));
            pro2.Precioanterior = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_PRECIOAN"]));
            pro2.Stock = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_STOCK"]));
            int tipopro = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_TIPOPRO"]));
            pro2.Tipopro = tipopro; 
            pro2.Codigoprovee = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_CODIGOPROVEE"]));
            pro2.Dividido = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_PRECIOARTDI"]));
            pro2.Tipo = tipopro;
            if (tipopro > 0)
            {
                pro2.Costo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_COSTO"]));
                pro2.Iva = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_PORC_IVA"]));
                pro2.Ganancia = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_PORC_GANAN"]));
            }
            pro2.Isbn = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_ISBN"]));
            pro2.Barra = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_BARRA"]));
            pro2.Imagen = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_IMAGEN"]));
            pro2.Cuerpo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_CUERPO"]));
            pro2.Estante = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_ESTANTE"]));
            pro2.Codigoprovee = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_CODIGOPROVEE"]));
            AltaProducto ap = new AltaProducto();
            ap.Alta = 0;
            
            ap.colocardatos(pro2);
            pro.Codigo = string.Empty;
            if (ap.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gConsulta.DataSource = pro.Mostrar_productos();
                gridViewPintarFilas.FocusedRowHandle = focusedRowHandle;
                gridViewPintarFilas.TopRowIndex = topRowIndex;
            }
                
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar éste producto?", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                    
                    Productos pro2 = new Productos(); var topRowIndex = gridViewPintarFilas.TopRowIndex;
                    var focusedRowHandle = gridViewPintarFilas.FocusedRowHandle;
                    pro2.productoide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_IDE"]));
                    int retorno = pro2.spEliminarProducto();
                    if (retorno == 0)
                    {
                        gConsulta.DataSource = pro.Mostrar_productos(); 
                        gridViewPintarFilas.FocusedRowHandle = focusedRowHandle;
                        gridViewPintarFilas.TopRowIndex = topRowIndex;
                        MessageBox.Show("Se ha eliminado el producto con éxito!");
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error en la eliminación del producto!");
                    }
                
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            ConsultaMoviVtas cmv = new ConsultaMoviVtas();
            cmv.Codigo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_CODIGO"]));
            cmv.ShowDialog();
        }

        private void btnlugares_Click(object sender, EventArgs e)
        {
            ConsultasLugares cl = new ConsultasLugares();
            cl.Codigo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_CODIGO"]));
            cl.colocarcodigo();
            cl.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ConsultaPedidosRealizados cpr = new ConsultaPedidosRealizados();
            cpr.Liide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_IDE"]));
            cpr.cargar();
            cpr.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var topRowIndex = gridViewPintarFilas.TopRowIndex;
            var focusedRowHandle = gridViewPintarFilas.FocusedRowHandle;
            AltaPedido ap = new AltaPedido();
            ap.Producto = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_DESC"]));
            ap.colocarnombre();
            ap.Ide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_IDE"]));
            ap.Alta = 1;
            /*if (ap.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //gConsulta.DataSource = cli.Mostrar_clientes();
                gConsulta.DataSource = pro.Mostrar_productos();
            }*/
            if (ap.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gConsulta.DataSource = pro.Mostrar_productos();
                gridViewPintarFilas.FocusedRowHandle = focusedRowHandle;
                gridViewPintarFilas.TopRowIndex = topRowIndex;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (gridViewPintarFilas.RowCount > 0)
            {
                AltaReserva ar = new AltaReserva();
                ar.Alta = 1;
                ar.Codigo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_CODIGO"]));
                ar.Titulo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_DESC"]));
                ar.Autor = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_AUTOR"]));
                ar.Precio = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_PRECIO"]));
                ar.Editorial = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["EDI_EDITORIAL"]));
                ar.EditorialCodigo = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_EDI_CODIGO"]));
                ar.Barra = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_BARRA"]));
                ar.Isbn = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_ISBN"]));
                ar.colocarDatos();
                ar.ShowDialog();
            }
            else
            {
                AltaReserva ar = new AltaReserva();
                ar.Alta = 1;
                ar.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConsultaReservas cr = new ConsultaReservas();
            cr.Codigo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_CODIGO"]));
            cr.cargarreseunproducto();
            cr.ShowDialog();
        }

        private void btnstock_Click(object sender, EventArgs e)
        {
            lbstock cpc = new lbstock();
            cpc.Codigo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_CODIGO"]));
            cpc.Stock = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_STOCK"]));
            cpc.Propio = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_PROPIO"]));
            cpc.colocarstockypropio();
            cpc.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (lbprecio.Visible == true)
            {
                lbprecio2.Visible = true;
                lbprecio.Visible = false;
            }
            else
            {
                lbprecio2.Visible = false;
                lbprecio.Visible = true;
            }
        }

        private void txtprovee_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprovee_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void txtprove_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
           
        }

        private void txtprovee_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //buscar acá
                this.busquedasimple();

            }
        }

        private void gConsulta_Click(object sender, EventArgs e)
        {

        }

        private void btninventario_Click(object sender, EventArgs e)
        {
            var topRowIndex = gridViewPintarFilas.TopRowIndex;
            var focusedRowHandle = gridViewPintarFilas.FocusedRowHandle;
            Inventario inv = new Inventario();
            Productos pro3 = new Productos();
            pro3.productoide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_IDE"]));
            pro3.Stock = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_STOCK"]));
            pro3.Codigo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_CODIGO"]));
            inv.colocardatos(pro3);
            if (inv.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gConsulta.DataSource = pro.Mostrar_productos();
                gridViewPintarFilas.FocusedRowHandle = focusedRowHandle;
                gridViewPintarFilas.TopRowIndex = topRowIndex;
            }
            
        }
    }

    }

