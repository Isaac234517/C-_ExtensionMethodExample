using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> data = Enumerable.Range(12, 6);
            IEnumerable<int> subData = EnumerableUtil.headThree<int>(data);
            int difference = EnumerableUtil.difference(subData);
            foreach(int element in subData)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine(string.Format("Difference of the head three element {0} ", difference.ToString()));

            
            Console.WriteLine("Extension Method");
            IEnumerable<int> subData2 = data.headThree<int>();
            foreach (int element in subData)
            {
                Console.WriteLine(element);
            }

            int difference2 = data.headThree<int>().difference();
            Console.WriteLine(string.Format("Difference of the head three element {0} ", difference2.ToString()));
            Console.Read();
        }
    }
}
