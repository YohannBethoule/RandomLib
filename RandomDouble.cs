using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

/*
 * @author: Y.Bethoule
 * La classe RandomDouble() permet de gérer un entier aléatoire dans une borne
 * */

namespace RandomApp.Métier
{
    public static class RandomDouble
    {
        private static RNGCryptoServiceProvider r = new RNGCryptoServiceProvider();
        private static byte[] b = new byte[8];

        /*
         * @param min: borne inférieure de la génération
         * @param max: borne supérieure de la génération
         * @return un réel positif aléatoire entre min et max
         * */
        public static double Next(int min, int max)
        {
            if (min < 0 || max < min)
            {
                throw new ArgumentException("Parametres incorrectes");
            }
            r.GetBytes(b);
            double dec = BitConverter.ToDouble(b, 0);
            if (dec < 0)
            {
                dec = -dec;
            }
            double value = RandomInt.Next(min, max-1) + dec;
            return Math.Round(value,5);
        }

        /*
         * @return: un entier positif aléatoire
         * */
        public static double Next()
        {
            r.GetBytes(b);
            double value = BitConverter.ToDouble(b, 0);
            if (value < 0)
            {
                value = -value;
            }
            return Math.Round(value,5);
        }
    }
}

