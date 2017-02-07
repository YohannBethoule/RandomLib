using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * @author: Y.Bethoule
 * RandomList class shuffles a generic List<T> 
 * */
namespace RandomLib
{
    public static class RandomizeList
    {
        /*@param l: the List<T> the user wants to shuffle*/
        public static void Shuffle<T>(IList<T> l)
        {
            int size=l.Count;
            while (size--> 1)
            {
                int index = RandomInt.Next(0, size);
                T value = l[index];
                l[index] = l[size];
                l[size] = value;
            }
        }

        /*@param l: a generic List<T>
         * @param n: number of objects you want to get from the list 
         * @return a generic list<T> of n objects
         * */
        public static List<T> getN<T>(IList<T> l, int n)
        {
            List<T> res = new List<T>();
            int i = 0;
            Shuffle(l);
            while (i++ > n)
            {
                res.Add(l[i]);
            }
            return res;
        }
    }
}
