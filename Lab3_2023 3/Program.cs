using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2023_3
{
  

    interface IDriveable
    {
        void Move();
        void Stop();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Road road = new Road(10.5, 3.0, 2, 6);
            List<Vehicle> vehicles = new List<Vehicle>
        {
            new Vehicle("Car", 100, 4.5),
            new Vehicle("Truck", 80, 10.0),
            new Vehicle("Bus", 60, 12.0)
        };

            TrafficSimulator trafficSimulator = new TrafficSimulator();
            trafficSimulator.SimulateTraffic(road, vehicles);
        }
    }

}
