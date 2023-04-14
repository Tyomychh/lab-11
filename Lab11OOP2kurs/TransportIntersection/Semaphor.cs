using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportIntersection
{
    public class Semaphor
    {
        static Semaphore semaphore = new Semaphore(2, 2);

        public static void TrafficLight(int trafficLightNumber)
        {
            while (true)
            {
                lock (semaphore)
                {
                    Console.WriteLine($"Свiтлофор {trafficLightNumber}: Зелений");
                    Thread.Sleep(3000);
                    Console.WriteLine($"Свiтлофор {trafficLightNumber}: Жовтий");
                    Thread.Sleep(1000);
                    Console.WriteLine($"Свiтлофор {trafficLightNumber}: Червоний");
                    Thread.Sleep(2000);
                    Console.WriteLine($"Свiтлофор {trafficLightNumber}: Синiй");
                    Thread.Sleep(500);
                }
            }
        }
    }
}
