using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
/*
 * @author: Y. Bethoule
 * Test of the library
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
            List<string> days = new List<string>();
            days.Add("Lundi");
            days.Add("Mardi");
            days.Add("Mercredi");
            days.Add("Jeudi");
            days.Add("Vendredi");
            days.Add("Samedi");
            days.Add("Dimanche");
            List<int> digits = new List<int>();
            for (i=0; i < 10; i++)
            {
                digits.Add(i);
            }
            ShuffleList.Shuffle(days);
            foreach(string day in days)
            {
                Console.WriteLine(day);
            }
            ShuffleList.Shuffle(digits);
            foreach (int d in digits)
            {
                Console.WriteLine(d);
            }
            Console.ReadKey();
        }
    }
}
