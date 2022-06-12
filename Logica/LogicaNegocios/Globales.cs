using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public static class Globales
    {
        public static int gbUsuide;
        public static string gbUsuario;
        public static string gbLocalidad;
        public static int gbLocalide;
        public static string gbtipousuario;
        public static int gbtipousuarioide;
        public static int gbpuntodeventapredetermindado;
        public static Color colorfondo;

        public static string ip;

        public static int accesoaproductos;
        public static int eliminarproductos;
        public static int registrodeventas;
        public static int accesoareservas;
        public static int accesoaeditoriales;
        public static int accesoaclientes;
        public static int imprimirfactura;
        public static int accesoacuentacorriente;
        public static int accesoaconsignas;
        public static int accesoarendiciones;
        public static int accesoainteres;
        public static int accesoacargarapida;
        public static int accesoapedidos;
        public static int accesoausuarios;
        public static int accesoaproveedores;
        public static int puntodeventa;
        public static int accessocuerpoestante;
        public static int accessoventacredito;
        public static int accessoporcentajesedi;
        public static int accesocontador;
        public static int accesomodificartitulo;
        public static int accesomodificaradopciones;
        public static int accesopagos;
        public static int accesocredito;

        public static int usuventaide;

        public static int usureservaide;

        public static string usureservanombre;

        public static void Inicializar(string _usuario, string _localidad, int _usuide, int _localide, string _tipousuario)
        {
            gbUsuario = _usuario;
            gbLocalidad = _localidad;
            gbLocalide = _localide;
            gbUsuide = _usuide;
            gbtipousuario = _tipousuario;
        }

    }
}
