using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
/*
 * @author: Y. Bethoule
 * Classe de test de mon métier
 * */

namespace RandomApp.Métier
{
    class Test
    {
        static void Main(String[] args)
        {
            int i;
            for (i = 1; i < 10; i++)
            {
                Console.Write("RandomInt.Next(0,50): "+RandomInt.Next(0, 50)+"\n");
            }
            for (i = 0; i < 10; i++)
            {
                Console.Write("RandomDouble.Next(0,50): "+RandomDouble.Next(0, 50)+"\n");
            }
            for (i = 1; i < 10; i++)
            {
                Console.Write("RandomDigots.Next("+i+"): "+RandomDigits.Next(i)+"\n");
            }
            Console.ReadKey();
        }
    }
}
