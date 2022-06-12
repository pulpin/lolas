using AccesoaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class Puntodevta
    {
        public DataTable Tabladedatos_ptodevta()
        {
            Conexion con = new Conexion("lolasdb", Globales.ip);
            con.AbrirConexio();
            return con.Mostrar_Datos("select PTOVTA_NUMERO,PTOVTA_DESC from lolasdb.puntosdevta order by PTOVTA_DESC");
        }
    }
}
