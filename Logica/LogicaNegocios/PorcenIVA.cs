using AccesoaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class PorcenIVA
    {
        public DataTable Tabladedatos_porcetajes()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            return con.Mostrar_Datos("select trim(POR_IVA) AS POR_IVA from lolasdb.porcentajesiva order by POR_IVA");
        }
    }
}
