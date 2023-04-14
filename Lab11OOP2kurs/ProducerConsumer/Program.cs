using System;

namespace ProducerConsumer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Thread producerThread = new Thread(ProducerCons.Producer);
            Thread consumerThread = new Thread(ProducerCons.Consumer);

            producerThread.Start();
            consumerThread.Start();

            producerThread.Join();
            consumerThread.Join();

            Console.ReadLine();
        }
    }
}