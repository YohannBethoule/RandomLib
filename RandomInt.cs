using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
/*
 * @author: Y.Bethoule
 * La classe RandomInt() permet de génerer un entier positif aléatoire en utilisant la classe RNGCryptoServiceProvider, 
 * plus puissante pour la génération aléatoire que la classe Random.
 * */

namespace RandomApp.Métier
{
    public static class RandomInt
    {
        private static RNGCryptoServiceProvider r = new RNGCryptoServiceProvider();
        private static byte[] b = new byte[4];
        
        /*
         * @param min: borne inférieure de la génération
         * @param max: borne supérieure de la génération, doit être supérieur à 0
         * @return un entier aléatoire entre min et max
         * */
        public static int Next(int min, int max)
        {
            if (min < 0 || max<min)
            {
                throw new ArgumentException("Parametres incorrectes");
            }
            r.GetBytes(b);
            int value =(min+ BitConverter.ToInt32(b, 0))%max;
            if (value < 0)
            {
                value = -value;
            }
            return value;
        }

        /*
         * @return: un entier positif aléatoire
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
