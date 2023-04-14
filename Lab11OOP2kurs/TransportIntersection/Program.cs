using TransportIntersection;
using System;

namespace TransportIntersection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Thread trafficLight1 = new Thread(() => Semaphor.TrafficLight(1));
            Thread trafficLight2 = new Thread(() => Semaphor.TrafficLight(2));
            Thread trafficLight3 = new Thread(() => Semaphor.TrafficLight(3));
            Thread trafficLight4 = new Thread(() => Semaphor.TrafficLight(4));

            trafficLight1.Start();
            trafficLight2.Start();
            trafficLight3.Start();
            trafficLight4.Start();

            trafficLight1.Join();
            trafficLight2.Join();
            trafficLight3.Join();
            trafficLight4.Join();

            Console.ReadLine();
        }
    }
}