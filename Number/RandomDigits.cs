using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * @author: Y.Bethoule
 * RandomDigits class generates a positive integer of a given number of digits
 * */
namespace RandomLib
{
    public static class RandomDigits
    {
        /*
         * @param length: number of digits wanted
         * @return a positive integer of 'length' digits
         * */
        public static double Next(int length)
        {
            int i;
            double res = 0;
            for(i=length-1; i>=0; i--)
            {
                res = res + RandomInt.Next(0,9) * Math.Pow(10, i);
            }
            return res;
        }
    }
}