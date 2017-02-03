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
 * La classe RandomDigits() permet de génerer un eniter positif aléatoire possédant un nombre de chiffres donné
 * */
namespace RandomLib
{
    public static class RandomDigits
    {
        /*
         * @param taille: le nombre de chiffres que l'on souhaite
         * @return un entier positif aléatoire de 'taille' chiffres
         * */
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