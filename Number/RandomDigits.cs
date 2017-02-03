using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomApp.Métier
{
    public static class RandomDigits
    {
        public static double Next(int taille)
        {
            int i;
            double res = 0;
            for(i=taille-1; i>=0; i--)
            {
                res = res + RandomInt.Next(0,9) * Math.Pow(10, i);
            }
            return res;
        }
    }
}