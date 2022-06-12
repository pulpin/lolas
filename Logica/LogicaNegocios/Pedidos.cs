using AccesoaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class Pedidos
    {
        int _codigo;
        string esli = string.Empty;
        public DataTable Mostrar_Pedidosporfecha(string fechadesde, string fechahasta,int Eslibro)
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            if (Eslibro == 1)
            {
                esli = " and PROV_LIBRO = 0";
            }
            else
            {
                esli = " and PROV_LIBRO = 1";
            }
            return con.Mostrar_Datos("select pr.PROV_DESC AS proveedor,pm.PED_FECHA,pm.PED_IDE from pedidosmaestro as pm " +
                                    " left join proveedor as pr on pm.PED_PROV_IDE = pr.PROV_IDE where " +
                                    " (PED_FECHA >= '" + fechadesde + "' AND PED_FECHA <= '" + fechahasta + "') "+ esli +"");

        }

        public DataTable Mostrar_PedidosRealizados()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select PROV_DESC,PED_FECHA,PEDD_CANTIDAD from pedidosmaestro pm " +
                                      " left join pedidosdetalle as pd on " +
                                      " pm.PED_IDE = pd.PEDD_PED_IDE " +
                                      " left join proveedor as pr on pm.PED_PROV_IDE = pr.PROV_IDE " +
                                      " where PEDD_LI_IDE = "+ this.Codigo +"");

        }
        public DataTable Mostrar_pedidosdetalle()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select li.LI_CODIGOVIEJO,li.LI_DESC,li.LI_AUTOR,EDI_EDITORIAL as editorial,PEDD_CANTIDAD " +
                                     " from pedidosmaestro as pm left join pedidosdetalle as pd " +
                                     " on pm.PED_IDE = pd.PEDD_PED_IDE " +
                                     " left join libros as li on pd.PEDD_LI_IDE = li.LI_IDE " +
                                     " left join editorial as ed on li.LI_EDI_CODIGO = ed.EDI_CODIGO " +
                                     " WHERE PEDD_PED_IDE = "+ this.Codigo +" ");

        }
        public int Codigo
        {
            set { this._codigo = value; }
            get { return this._codigo; }
        }
    }
}
