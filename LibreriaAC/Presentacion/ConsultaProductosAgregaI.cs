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
    public partial class ConsultaProductosAgregaI : Form
    {
        Editorial edi = new Editorial();
        Productos pro = new Productos();
        Genero gen = new Genero();
        ToolTip tol = new ToolTip();
        int _alta;
        public ConsultaProductosAgregaI()
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
            if (txttitulo.Text == string.Empty && txtautor.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar el texto a buscar");

            }
            else
            {
                this.busquedaavanzada();
            }
        }

        private void busquedasimple()
        {
            pro.Tipo = 1;
            pro.Barra = txtbarra.Text;
            pro.Codigo = txtcodigo.Text;
            pro.Isbn = txtisbn.Text;
            gConsulta.DataSource = pro.Mostrar_productos();
            txtbarra.Text = string.Empty;
            txtcodigo.Text = string.Empty;
            txtisbn.Text = string.Empty;
            this.cargardatos();
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
            tol.SetToolTip(this.bbuscar, "Buscar");
            tol.SetToolTip(this.blimpiar, "Limpiar todos los textos");
            tol.SetToolTip(this.btnzoom, "Ver imagen en tamaño completo");
            txtbarra.Select();
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
                this.cargarcanti();
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
            lbpedidos.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_PEDIDOS"]));
            if (Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_FECHAPRE"])) != "")
            {
                DateTime fechaactu = Convert.ToDateTime(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_FECHAPRE"]));
                lbultimaap.Text = fechaactu.ToShortDateString();
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

        private void cargardatos11()
        {
            lbtitulo.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_DESC"]));
            lbprecio.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_PRECIO"]));
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

                string fullpath = System.IO.Path.Combine(path, string.Format("libros\\{0}", imagen));
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
            lbultimaap.Text = "";
            if (Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_FECHAPRE"])) != "")
            {
                DateTime fechaactu = Convert.ToDateTime(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_FECHAPRE"]));
                lbultimaap.Text = fechaactu.ToShortDateString();
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
            System.Diagnostics.Process.Start("https://www.google.com.ar/search?q= " + lbbarra.Text + " &source=lnms&tbm=isch&sa=X&ved=0ahUKEwinis2r9oDPAhXBIJAKHSdLBeYQ_AUICCgB&biw=1024&bih=662");
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
            Productos pro = new Productos();
            pro.productoide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_IDE"]));
            pro.Codigo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_CODIGO"]));
            pro.Titulo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_DESC"]));
            pro.Autor = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_AUTOR"]));
            pro.Editorial = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_EDI_CODIGO"]));
            pro.Genero = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_GEN_IDE"]));
            pro.Precio = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_PRECIO"]));

            int tipopro = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_TIPOPRO"]));
            pro.Tipo = tipopro;
            if (tipopro > 0)
            {
                pro.Costo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_COSTO"]));
                pro.Iva = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_PORC_IVA"]));
                pro.Ganancia = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_PORC_GANAN"]));
            }
            pro.Isbn = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_ISBN"]));
            pro.Barra = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_BARRA"]));
            pro.Imagen = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_IMAGEN"]));
            pro.Cuerpo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_CUERPO"]));
            pro.Estante = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_ESTANTE"]));

            AltaProducto ap = new AltaProducto();
            ap.Alta = 0;
            ap.colocardatos(pro);
            if (ap.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gConsulta.DataSource = pro.Mostrar_productos();
            }

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar éste producto?", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {


                Productos pro = new Productos();
                pro.productoide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_IDE"]));
                int retorno = pro.spEliminarProducto();
                if (retorno == 0)
                {
                    gConsulta.DataSource = null;
                    MessageBox.Show("Se ha eliminado el producto con éxito!");
                }
                else
                {
                    MessageBox.Show("Hubo un error en la eliminación del producto!");
                }

            }
        }

        private void gConsulta_DoubleClick(object sender, EventArgs e)
        {
             


            
        }

        private void gridViewPintarFilas_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.cargardatos();
        }

        private void ConsultaProductosAgrega_DoubleClick(object sender, EventArgs e)
        {
          
        }
        private void cargarcanti()
        {
            pro.productoide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_IDE"]));
            string nombre = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_DESC"]));
            string cod = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_CODIGOVIEJO"]));
            CargarCantidad cc = new CargarCantidad();
            cc.Titulo = nombre;
            cc.Codigo = cod;
            cc.colocartitulo();
            if (cc.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string cantidadelegida = Convert.ToString(cc.Cantielegida);
                int tipodeproducto = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_TIPOPRO"]));
                string codigo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_CODIGO"]));
                string desc = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_DESC"]));
                string barra = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_BARRA"]));
                string preciou = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_PRECIO"]));
                string editorialu = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["EDI_EDITORIAL"]));
                double iva = Convert.ToDouble(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_PORC_IVA"]));
                double importetemporal = Convert.ToDouble(preciou) * Convert.ToDouble(cantidadelegida);
                string subtotal = Convert.ToString(importetemporal);
                string ivavalor1;
                int productoide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_TIPOPRO"]));

                //calculo del IVA e importe de IVA
                double ivavalor = 0, importedeliva = 0;
                if (tipodeproducto > 0)
                {
                    if (iva == 21)
                    {
                        ivavalor = (importetemporal / 1.21);
                    }
                    else //10.5
                    {
                        ivavalor = (importetemporal / 1.105);
                    }
                    ivavalor1 = string.Format("{0:N4}", ivavalor);
                    ivavalor = Convert.ToDouble(ivavalor1);
                    //ivavalor = (importetemporal * iva / 100);
                    //ivavalor = Math.Round(ivavalor, 2);

                    importedeliva = importetemporal - ivavalor;
                    //  importedeliva = Math.Round(importedeliva, 2);
                }
                string preciouc = preciou;
                string subtotalc = subtotal;

                IFormImprime formdeInterface1 = this.Owner as IFormImprime;
                if (formdeInterface1 != null)
                {

                    string[] row1 = new string[] { cantidadelegida , codigo.Trim(), nombre,
                        editorialu,preciou,subtotal,preciouc,subtotalc,Convert.ToString(ivavalor),Convert.ToString(importedeliva),Convert.ToString(iva),Convert.ToString(ivavalor),Convert.ToString(importedeliva)};
                    object[] rowsenviar = new object[] { row1 };

                    formdeInterface1.AgregarProducto(barra,codigo,desc, preciou);
                }

            }
        }
        private void gConsulta_DoubleClick_1(object sender, EventArgs e)
        {
            this.cargarcanti();
        }

        public int Alta
        {
            get { return this._alta; }
            set { this._alta = value; }
        }

        private void btnagregare_Click(object sender, EventArgs e)
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

        private void btnverrese_Click(object sender, EventArgs e)
        {
            ConsultaReservas cr = new ConsultaReservas();
            cr.Codigo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_CODIGO"]));
            cr.cargarreseunproducto();
            cr.ShowDialog();
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

        private void button6_Click(object sender, EventArgs e)
        {
            AltaPedido ap = new AltaPedido();
            ap.Producto = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_DESC"]));
            ap.colocarnombre();
            ap.Ide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_IDE"]));
            ap.Alta = 1;
            if (ap.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //gConsulta.DataSource = cli.Mostrar_clientes();
                gConsulta.DataSource = pro.Mostrar_productos();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ConsultaPedidosRealizados cpr = new ConsultaPedidosRealizados();
            cpr.Liide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_IDE"]));
            cpr.cargar();
            cpr.ShowDialog();
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
    }
}

