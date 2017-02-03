using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

/*
 * @author: Y.Bethoule
 * La classe RandomInt() permet de génerer un réel positif aléatoire à 5 décimales
 * */

namespace RandomLib
{
    public static class RandomDouble
    {
        private static Random r = new Random();

        /*
         * @param min: borne inférieure de la génération
         * @param max: borne supérieure de la génération
         * @return un réel positif aléatoire à 5 décimales entre min et max
         * */
        public static double Next(int min, int max)
        {
            if (min < 0 || max < min)
            {
                throw new ArgumentException("Parametres incorrectes");
            }
            double dec = r.NextDouble();
            double value = RandomInt.Next(min, max-1) + dec;
            return Math.Round(value,5,MidpointRounding.AwayFromZero);
        }

        /*
         * @return: un réel positif aléatoire à 5 décimales
         * */
        public static double Next()
        {
            return RandomInt.Next() + r.NextDouble();
        }
    }
}

