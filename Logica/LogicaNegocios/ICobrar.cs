using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public interface ICobrar
    {
        int tipodepagoelegidoC(int tippag);
        void aplicadescuentoC(int tippag);
        void guardarventa();
    }
}
