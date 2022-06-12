using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocios;
using MySql.Data.MySqlClient;

namespace Presentacion
{
    public partial class ConsultaPermisos : Form
    {
        int _codigo;
        Usuarios usu = new Usuarios();
        public ConsultaPermisos()
        {
            InitializeComponent();
        }

        private void ConsultaInteres_Load(object sender, EventArgs e)
        {
            this.cargarpermisos();
        }
        private void cargar()
        {
           // gConsulta.DataSource = usu.Mostrar_Usuarios(Codigo);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            this.seleccionado();
        }


        public void cargarpermisos()
        {
            //creo la tabla temporal.
            DataSet Ds = new DataSet("ds");
            DataTable Tabla = new DataTable("Tabla");
            Tabla.Columns.Add("menu_nombre", System.Type.GetType("System.String"));
            Tabla.Columns.Add("per_acceder", System.Type.GetType("System.Boolean"));
            Tabla.Columns.Add("per_modificar", System.Type.GetType("System.Boolean"));
            Tabla.Columns.Add("menu_ide", System.Type.GetType("System.Int32"));
            Tabla.Columns.Add("menu_prog_ide", System.Type.GetType("System.Int32"));
            Tabla.Columns.Add("menu_descripcion", System.Type.GetType("System.String"));
            Ds.Tables.Add(Tabla);
            DataRow drt;

            //hago la consulta a la Base de Datos.

            MySqlDataReader myReader = usu.Mostrar_Usuarios(Codigo);
            if (myReader.HasRows)
            {
                int valor1=0,valor2=0;
                int i = 0;
                while (myReader.Read())
                {
                    drt = Ds.Tables[i].NewRow();
                    drt["menu_nombre"] = myReader.GetString(myReader.GetOrdinal("menu_nombre"));

                    if (!myReader.IsDBNull(myReader.GetOrdinal("per_acceder")))
                    {
                        drt["per_acceder"] = myReader.GetInt32(myReader.GetOrdinal("per_acceder"));
                        valor1 = myReader.GetInt32(myReader.GetOrdinal("per_acceder"));
                    }
                    else
                    {
                        drt["per_acceder"] = 0;
                    }

                    if (!myReader.IsDBNull(myReader.GetOrdinal("per_modificar")))
                    {
                        drt["per_modificar"] = myReader.GetInt32(myReader.GetOrdinal("per_modificar"));
                        valor2 = myReader.GetInt32(myReader.GetOrdinal("per_acceder"));
                    }
                    else
                    {
                        drt["per_modificar"] = 0;
                    }

                    if (!myReader.IsDBNull(myReader.GetOrdinal("menu_ide")))
                    {
                        drt["menu_ide"] = myReader.GetInt32(myReader.GetOrdinal("menu_ide"));
                    }
                    else
                    {
                        drt["menu_ide"] = 0;
                    }

                    if (!myReader.IsDBNull(myReader.GetOrdinal("menu_prog_ide")))
                    {
                        drt["menu_prog_ide"] = myReader.GetInt32(myReader.GetOrdinal("menu_prog_ide"));
                    }
                    else
                    {
                        drt["menu_prog_ide"] = 0;
                    }
                    drt["menu_descripcion"] = myReader.GetString(myReader.GetOrdinal("menu_descripcion"));

                    Ds.Tables[i].Rows.Add(drt);
                    
                }
            }

            gConsulta.DataSource = Tabla;

        }

        private void seleccionado()
        {
            IClientes formInterClientes = this.Owner as IClientes;
            if (formInterClientes != null)
            {
                string cuitp = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CLI_CUIT"]));
                string nombrep = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CLI_NOMBRE"]));
                string direp = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CLI_DIRE"]));
                string tipop = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["TIPI_DESC"]));
                string tipoletrap = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["TIPI_LETRA"]));
                formInterClientes.selecciondecliente(cuitp, nombrep, direp, tipop, tipoletrap);
                this.Dispose();
                this.Hide();
            }
        }

        private void gConsulta_DoubleClick(object sender, EventArgs e)
        {
            this.seleccionado();
        }

        private void btnaltacliente_Click(object sender, EventArgs e)
        {
            AltaCliente ac = new AltaCliente();
            ac.Alta = 1;
            
            if (ac.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //gConsulta.DataSource = cli.Mostrar_clientes();
            }
        }

        private void btnmodificarcliente_Click(object sender, EventArgs e)
        {
            AltaCliente ac = new AltaCliente();
            ac.Cuit = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CLI_CUIT"]));
            ac.Razonsocial = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CLI_NOMBRE"]));
            ac.Domicilio = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CLI_DIRE"]));
            ac.Telefono = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CLI_TELEFONO"]));
            ac.Situacion = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CLI_TIPI_IDE"]));
            ac.Clienteide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CLI_IDE"]));
            ac.colocardatos();
            ac.Alta = 0;
            if (ac.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //gConsulta.DataSource = cli.Mostrar_clientes();
            }
        }
        public int Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void btnagregar_Click_1(object sender, EventArgs e)
        {
            //primero eliminar todo los permisos del usuario
            Usuarios usu = new Usuarios();
            usu.Usuide = this.Codigo;
            int valor = usu.spBorrarPermisos();
            //acá hacer un insert de todos permisos
            int menu1=0, prog1=0, accede=0, modifica=0;
            if (valor == 0)
            {
                for (int i = 0; i < gridViewPintarFilas.DataRowCount; i++)
                {
                    menu1 = Convert.ToInt32(gridViewPintarFilas.GetRowCellValue(i, "menu_ide"));
                    prog1 = Convert.ToInt32(gridViewPintarFilas.GetRowCellValue(i, "menu_prog_ide"));

                    accede = Convert.ToInt32(gridViewPintarFilas.GetRowCellValue(i, "per_acceder"));
                    modifica = Convert.ToInt32(gridViewPintarFilas.GetRowCellValue(i, "per_modificar"));

                   // usu.Usuide = this.Codigo;
                    usu.Menuide = menu1;
                    usu.Progide = prog1;
                    usu.Acceder = accede;
                    usu.Modificar = modifica;
                    int val = usu.spAgregarPermisos();
                }
                this.Dispose();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hubo un error en la Base de Datos, vuelva a intentarlo por favor.");
            }
        }
    }
}
