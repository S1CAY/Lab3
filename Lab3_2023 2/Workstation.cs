using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2023_2
{
    class Workstation : Computer, IConnectable
    {
        public Workstation(string ipAddress, int power, string operatingSystem)
            : base(ipAddress, power, operatingSystem)
        {
        }

        public void Connect(Computer computer)
        {
            Console.WriteLine($"Connected to {computer.IPAddress}.");
        }

        public void Disconnect(Computer computer)
        {
            Console.WriteLine($"Disconnected from {computer.IPAddress}.");
        }
    }
}
