using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * @author: Y.Bethoule
 * RandomListLinking class allows to randomly link 2 lists 
 * */
namespace RandomLib
{
    public static class RandomListLinking
    {
        /*@param l1: a generic list
         * @param l2: a generic list
         * @return a Dictionary gathering both of the lists 
         * */
        public static Dictionary<T, T> Link2Lists<T, T>(IList<T> l1, IList<T> l2)
        {
            int size, i=0;
            Dictionary<T, T> res = new Dictionary<T, T>();
            if (l1.Count <= l2.Count)
            {
                size = l1.Count;
            }else
            {
                size = l2.Count;
            }

            RandomizeList.Shuffle(l1);
            RandomizeList.Shuffle(l2);

            while (i++ < size)
            {
                res.Add(l1[i], l2[i]);
            }
            return res;
        }
    }
}
