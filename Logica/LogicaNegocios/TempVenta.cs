using AccesoaDatos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class TempVenta
    {
        int _vendide;
        public MySqlDataReader Mostrarpedidos()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            //aca se habre la conexion y se hace por única vez
            con.AbrirConexio();
            try
            {
                MySqlDataReader rdr = null;
                rdr = con.Consultas("select * from lolasdb.tempventa as tv left join lolasdb.tempventadetalle tvd on tv.VEN_IDE = tvd.VEND_VEN_IDE " +
                                    " left join lolasdb.libros as lb on tvd.VEND_LI_IDE = lb.LI_CODIGOVIEJO " +
                                    " left join lolasdb.editorial as ed on lb.LI_EDI_CODIGO = ed.EDI_CODIGO " +
                                    " left join lolasdb.tipopago as tp on tv.VEN_TIP_IDE = tp.TIP_IDE" +
                                    " where VEN_IDE = " + Venide +"");

                return rdr;
            }
            finally
            {
                //mysql_conexion.Close();
            }
        }
        public MySqlDataReader Mostrarventasparanota()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            //aca se habre la conexion y se hace por única vez
            con.AbrirConexio();
            try
            {
                MySqlDataReader rdr = null;
                rdr = con.Consultas("select * from lolasdb.venta as tv left join lolasdb.ventadetalle tvd on tv.VEN_IDE = tvd.VEND_VEN_IDE " +
                                    " left join lolasdb.libros as lb on tvd.VEND_LI_IDE = lb.LI_CODIGOVIEJO " +
                                    " left join lolasdb.editorial as ed on lb.LI_EDI_CODIGO = ed.EDI_CODIGO " +
                                    " left join lolasdb.tipopago as tp on tv.VEN_TIP_IDE = tp.TIP_IDE" +
                                    " where VEN_IDE = " + Venide + "");

                return rdr;
            }
            finally
            {
                //mysql_conexion.Close();
            }
        }
        public MySqlDataReader MostrarventasparanotaVista()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            //aca se habre la conexion y se hace por única vez
            con.AbrirConexio();
            try
            {
                MySqlDataReader rdr = null;
                rdr = con.Consultas("select * from lolasdb.notadecredito as tv left join lolasdb.notadecreditod tvd on tv.VEN_IDE = tvd.VEND_VEN_IDE " +
                                    " left join lolasdb.libros as lb on tvd.VEND_LI_IDE = lb.LI_CODIGOVIEJO " +
                                    " left join lolasdb.editorial as ed on lb.LI_EDI_CODIGO = ed.EDI_CODIGO " +
                                    " left join lolasdb.tipopago as tp on tv.VEN_TIP_IDE = tp.TIP_IDE" +
                                    " where VEN_IDE = " + Venide + "");

                return rdr;
            }
            finally
            {
                //mysql_conexion.Close();
            }
        }
        public MySqlDataReader Mostrarproforma()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            //aca se habre la conexion y se hace por única vez
            con.AbrirConexio();
            try
            {
                MySqlDataReader rdr = null;
                rdr = con.Consultas("select * from lolasdb.proforma as tv left join lolasdb.proformadetalle tvd on tv.VEN_IDE = tvd.VEND_VEN_IDE " +
                                    " left join lolasdb.libros as lb on tvd.VEND_LI_IDE = lb.LI_CODIGOVIEJO " +
                                    " left join lolasdb.editorial as ed on lb.LI_EDI_CODIGO = ed.EDI_CODIGO " +
                                    " left join lolasdb.tipopago as tp on tv.VEN_TIP_IDE = tp.TIP_IDE" +
                                    " where VEN_IDE = " + Venide + "");

                return rdr;
            }
            finally
            {
                //mysql_conexion.Close();
            }
        }
        public int Venide
        {
            set { this._vendide = value; }
            get { return this._vendide; }
        }
    }
}
