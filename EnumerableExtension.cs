using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExample
{
    public static class EnumerableExtension
    {
        public static IEnumerable<T> headThree<T>(this IEnumerable<T> source)
        {
            int i = 0;
            foreach (T element in source)
            {
                if(i < 3)
                {
                    i++;
                    yield return element;
                }
            }
        }

        public static int difference(this IEnumerable<int> source)
        {
            if (source.GetEnumerator().MoveNext())
            {
                int result = 0;
                foreach (int element in source)
                {
                    result = result == 0 ? element : result - element;
                }
                return result;
            }
            else
            {
                throw new Exception("source cannot be empty");
            }
        }
    }
}
