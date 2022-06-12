using AccesoaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class Pagos
    {
        int _codigo;
        string esli = string.Empty, valor = string.Empty,consultafecha=string.Empty;
        public DataTable Mostrar_Pagosporfecha(string fechadesde, string fechahasta, int local, int provee, int pagados, int fechad, int fechah)
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            if (provee > 0)
            {
                valor = " and acre_ide = "+ provee +"  ";
            }
            if (pagados > 0)
            {
                if (pagados==1)
                {
                    // valor = valor + " and fac_fecpago is not null and ";
                    if (fechad == 1)
                    {
                        consultafecha = " and fac_fecpago >= '" + fechadesde + "'";
                    }
                    else
                    {
                        consultafecha = string.Empty;
                    }
                    if (fechah == 1)
                    {
                        consultafecha = consultafecha + " and fac_fecpago <= '" + fechahasta + "'";
                    }
                    consultafecha = consultafecha + " and fac_fecpago is not null ";
                }
                if (pagados==2)
                {
                    // valor = valor + " and fac_fecpago is null and ";
                    if (fechad == 1)
                    {
                        consultafecha = " and fac_fecvence >= '" + fechadesde + "'";
                    }
                    else
                    {
                        consultafecha = string.Empty;
                    }
                    if (fechah == 1)
                    {
                        consultafecha = consultafecha + " and fac_fecvence <= '" + fechahasta + "'";
                    }
                    consultafecha = consultafecha + " and fac_fecpago is null ";
                }
            }else
            { 
                if (fechad == 1)
                {
                    consultafecha = " and fac_fecvence >= '" + fechadesde + "'";
                }
                else {
                    consultafecha = string.Empty;
                }
                if (fechah == 1)
                {
                    consultafecha = consultafecha + " and fac_fecvence <= '" + fechahasta + "'";
                }
            }
            return con.Mostrar_Datos("select acre_desc,fac_nro,fac_fecha,fac_fecvence,fac_fecpago,fac_importe,fac_obs,fac_marcapagado,fac_ide, " +
            " banco_desc, cu_cahora, cu_ctacorriente, cu_titular, cu_cbu, cu_cuit, acre_tel " +
            " from pagos.facturas left join pagos.acreedores on fac_acre_ide = acre_ide " +
            " left " +
            " join pagos.cuentas on cu_acre_ide = acre_ide " +
            " left " +
            " join pagos.bancos on cu_banco_ide = banco_ide where acre_local_ide = " + local +"  "+ consultafecha +"  "+ valor +"" +
                                    " ");

        }

       
        public DataTable Mostrar_Pagosportexto(int local, int provee, string txtbuscar)
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            if (provee > 0)
            {
                valor = " and acre_ide = " + provee + "  ";
            }
            
         
            return con.Mostrar_Datos("select acre_desc,fac_nro,fac_fecha,fac_fecvence,fac_fecpago,fac_importe,fac_obs,fac_marcapagado,fac_ide from pagos.facturas left join pagos.acreedores on fac_acre_ide = acre_ide where acre_local_ide = " + local + "  " + valor + "  " +
                                    "  and fac_nro = " + txtbuscar + "");

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
