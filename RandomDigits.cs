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
        private static Random r=new Random();
        
        public static double Next(int taille)
        {
            double res = 0;
            int i = taille - 1;
            while (i > 0)
            {
                res = res + RandomInt.Next() * Math.Pow(10, i);
                i = i - 1;
            }
            return res;
        }
    }
}