using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class Dado
    {
        Random rnd = new Random();

        public int Lanzar()
        {
            int r = rnd.Next(1, 7);
            return r;
        }
    }
}
