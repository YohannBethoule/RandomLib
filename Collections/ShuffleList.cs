using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * @author: Y.Bethoule
 * ShuffleList class shuffles a generic List<T> 
 * */
namespace RandomLib
{
    public static class ShuffleList
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
    }
}
