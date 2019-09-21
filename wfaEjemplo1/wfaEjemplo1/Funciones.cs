using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaEjemplo1
{
    class Funciones
    {
        public String DecBin(int dec)
        {
            String bin = "";

            for (int n = 0; n < 8; n++)
            {
                int cos = dec / 2;
                int res = dec % 2;
                dec = cos;
                bin = res + bin;
            }
            return bin;
        }
    }
}
