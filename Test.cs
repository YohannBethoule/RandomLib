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

namespace RandomLib
{
    class Test
    {
        static void Main(String[] args)
        {
            int i;
            for (i = 1; i < 10; i++)
            {
                Console.Write("RandomInt.Next(0,4): " + RandomInt.Next(0, 4)+"\n");
            }
            for (i = 1; i < 10; i++)
            {
                Console.Write("RandomString("+i+"): " + RandomString.Next(i)+"\n");
            }
            Console.ReadKey();
        }
    }
}
