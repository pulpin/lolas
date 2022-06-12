using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public interface IClientes
    {
        void selecciondecliente(string cuit, string nombre, string dire, string tipo, string tipoletra);
    }
}
