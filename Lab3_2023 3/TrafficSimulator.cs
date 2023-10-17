using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2023_3
{
    class TrafficSimulator
    {
        public void SimulateTraffic(Road road, List<Vehicle> vehicles)
        {
            Console.WriteLine($"Traffic simulation on a road of length {road.Length} km with {road.NumberOfLanes} lanes.");

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Vehicle Type: {vehicle.Type}, Speed: {vehicle.Speed} km/h, Size: {vehicle.Size} meters");
                vehicle.Move();

                if (road.TrafficLevel > 5)
                {
                    Console.WriteLine($"Traffic is heavy on this road. {vehicle.Type} has to slow down.");
                    vehicle.Speed -= 10;
                    vehicle.Move();
                }

                vehicle.Stop();
                Console.WriteLine();
            }
        }
    }
}
