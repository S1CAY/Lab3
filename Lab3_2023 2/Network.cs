using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2023_2
{
    class Network
    {
        public List<Computer> Computers { get; set; }

        public Network()
        {
            Computers = new List<Computer>();
        }

        public void TransmitData(Computer sender, Computer receiver, string data)
        {
            Console.WriteLine($"Data transmitted from {sender.IPAddress} to {receiver.IPAddress}: {data}");
        }
    }

}
