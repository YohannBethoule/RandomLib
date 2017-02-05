using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
/*
 * @author: Y.Bethoule
 * RandomInt class generates a random positive integer using RNGCryptoServiceProvider class, 
 * more powerful for random generation than Random class.
 * */

namespace RandomLib
{
    public static class RandomInt
    {
        private static RNGCryptoServiceProvider r = new RNGCryptoServiceProvider();
        private static byte[] b = new byte[4];
        
        /*
         * @param min: lower bound of the generation
         * @param max: upper bound of the generation, must be higher than 0 
         * @return a random positive integer between 'min' and 'max'
         * */
        public static int Next(int min, int max)
        {
            if (min < 0 || max<min)
            {
                throw new ArgumentException("Parametres incorrectes");
            }
            r.GetBytes(b);
            int value =(min+ BitConverter.ToInt32(b, 0) ) % (max+1);
            if (value < 0)
            {
                value = -value;
            }
            return value;
        }

        /*
         * @return: a random positive integer
         * */
        public static int Next()
        {
            r.GetBytes(b);
            int value = BitConverter.ToInt32(b, 0);
            if (value < 0)
            {
                value = -value;
            }
            return value;
        }
    }
}
