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
        public static void doQueueDemo()
        {
            Console.WriteLine("\n~~~~~~~Queue Demo~~~~~~~");
            Queue<string> queue = new Queue<string>();
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            queue.Enqueue("Shubham Singh");
            queue.Enqueue("Niraj Pal");
            queue.Enqueue("Irbaz Patel");
            queue.Enqueue("KK");
            Console.WriteLine("Head:" + queue.Peek());
            Console.WriteLine("\nIterating the queue elements: ");
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("Dequeue element: " + dequeue);
            Console.WriteLine("\nIterating the queue elements after dequeu one element:");
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
