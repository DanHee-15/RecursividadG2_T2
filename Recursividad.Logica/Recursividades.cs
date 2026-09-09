using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad.Logica
{
    public class Recursividades
    {
        public int CalcularFactorail(int num)
        {
            //caso base o condicion de salida

            if(num == 1)
            {
                return 1;
            }

            //Caso General
            return num = num * CalcularFactorail(num - 1);
        }
    }
}
