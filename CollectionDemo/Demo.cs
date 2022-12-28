using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class Demo
    {
        public static void doSetDemo()
        {
            var set = new HashSet<string>();
            set.Add("Saurabh");
            set.Add("Akash");
            set.Add("Irbaz");
            set.Add("KK");
            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
