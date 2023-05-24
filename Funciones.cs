using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fact_Recursivo
{
    public class Funciones
    {
        public int Fact(int n)
        {
            if(n==0) return 1;
            else return Fact(n-1)*n;
        }
        public int FactCiclo(int n)
        {
            int factorial = 1;
            for(int i = 1; i <= n; i++)
            {
                factorial=factorial*i;
            }
            return factorial;
        }
    }
}
