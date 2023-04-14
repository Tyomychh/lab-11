using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    public class ProducerCons
    {
        static Queue<int> queue = new Queue<int>();
        static object lockObject = new object();
        static Random random = new Random();

        public static void Producer()
        {
            while (true)
            {
                int item = random.Next(1, 101); 

                lock (lockObject) 
                {
                    queue.Enqueue(item); 
                    Console.WriteLine($"Виробник: {item} додано до черги.");
                }

                Thread.Sleep(random.Next(500, 2001)); 
            }
        }

        public static void Consumer()
        {
            while (true)
            {
                int item = 0;

                lock (lockObject) 
                {
                    if (queue.Count > 0)
                    {
                        item = queue.Dequeue(); 
                    }
                }

                if (item > 0)
                {
                    Console.WriteLine($"Споживач: {item} знято з черги."); 
                }

                Thread.Sleep(random.Next(500, 2001));
            }
        }
    }
}

