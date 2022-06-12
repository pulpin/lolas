using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccesoaDatos;
using System.Data;
using MySql.Data.MySqlClient;

namespace LogicaNegocios
{
    public class VersionProg
    {
        public MySqlDataReader MostrarVersion()
        {
            Conexion con = new Conexion("usuarios", Globales.ip);
            //aca se habre la conexion y se hace por única vez
            con.AbrirConexio();
            try
            {
                MySqlDataReader rdr = null;
                rdr = con.Consultas("select prog_version from usuarios.programas where prog_ide = 16");

                return rdr;
            }
            finally
            {
                //mysql_conexion.Close();
            }
        }
    }
}
