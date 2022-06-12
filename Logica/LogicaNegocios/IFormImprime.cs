using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    //Esta inferface se usa para que actue como comunicación entre formularios
    public interface IFormImprime
    {
        void AgregarProducto(string barra,string codigo,string desc, string precio);
    }

    
}
