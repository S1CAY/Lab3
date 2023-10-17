using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2023_2
{
    class Router : Computer, IConnectable
    {
        public List<Computer> ConnectedComputers { get; }

        public Router(string ipAddress, int power, string operatingSystem)
            : base(ipAddress, power, operatingSystem)
        {
            ConnectedComputers = new List<Computer>();
        }

        public void Connect(Computer computer)
        {
            ConnectedComputers.Add(computer);
            Console.WriteLine($"Connected {computer.IPAddress} to the router.");
        }

        public void Disconnect(Computer computer)
        {
            ConnectedComputers.Remove(computer);
            Console.WriteLine($"Disconnected {computer.IPAddress} from the router.");
        }
    }
}
