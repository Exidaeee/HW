using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3._2
{
    static class Delegate
    {
        public static IEnumerable<T> FirstOrDefault2<T>(this IEnumerable<T> scr, Func<T, bool> func )
        { 
            foreach ( var item in scr )
            {
                if (func(item))
                {
                    yield return item;
                    yield break;
                }
            }
            yield return default;
        }
        public static IEnumerable<T> SkipWhile2<T>(this IEnumerable<T> scr, Func<T, bool> func)
        {
            foreach (var item in scr)
            {
              
                if (!func(item))
                {
                    yield return item;
                }

            }

        }
    }
}
