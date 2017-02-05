using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * @author: Y.Bethoule
 * RandomString class generates a random string of alphanumerical characters. 
 * */
namespace RandomLib
{
    public static class RandomString
    {
        private static string[] array = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j","k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
            "0","1","2","3","4","5","6","7","8","9"
        };
        /*
         * @param length: length of the string you want to get
         * @return a alphanumerical string of 'length' characters
         * */
        public static string Next(int length)
        {
            int i=length;
            string s="";
            while (i-- > 0)
            {
                int r = RandomInt.Next(0, 61);
                s = s + array[r];
            }
            return s;
        }
    }
}
