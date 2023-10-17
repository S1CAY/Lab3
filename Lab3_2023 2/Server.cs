using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2023_2
{
    class Server : Computer, IConnectable
    {
        public int MaxConnections { get; set; }
        public List<Computer> ConnectedComputers { get; }

        public Server(string ipAddress, int power, string operatingSystem, int maxConnections)
            : base(ipAddress, power, operatingSystem)
        {
            MaxConnections = maxConnections;
            ConnectedComputers = new List<Computer>();
        }

        public void Connect(Computer computer)
        {
            if (ConnectedComputers.Count < MaxConnections)
            {
                ConnectedComputers.Add(computer);
                Console.WriteLine($"Connected {computer.IPAddress} to the server.");
            }
            else
            {
                Console.WriteLine($"Connection to {computer.IPAddress} failed. Server is at maximum capacity.");
            }
        }

        public void Disconnect(Computer computer)
        {
            ConnectedComputers.Remove(computer);
            Console.WriteLine($"Disconnected {computer.IPAddress} from the server.");
        }
    }
}
