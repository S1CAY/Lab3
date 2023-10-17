using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2023_2
{
   
    interface IConnectable
    {
        void Connect(Computer computer);
        void Disconnect(Computer computer);
    }

    
  
    class Program
    {
        static void Main(string[] args)
        {
            Network network = new Network();

            Server server = new Server("192.168.1.1", 1000, "Windows Server", 10);
            Workstation workstation1 = new Workstation("192.168.1.2", 500, "Windows 10");
            Workstation workstation2 = new Workstation("192.168.1.3", 600, "Windows 10");
            Router router = new Router("192.168.1.4", 800, "Custom Router OS");

            network.Computers.Add(server);
            network.Computers.Add(workstation1);
            network.Computers.Add(workstation2);
            network.Computers.Add(router);

            server.Connect(workstation1);
            server.Connect(workstation2);
            router.Connect(server);
            workstation1.Connect(router);
            workstation2.Connect(router);

            network.TransmitData(workstation1, workstation2, "Hello, workstation2!");

            server.Disconnect(workstation1);

            workstation1.Disconnect(router);
        }
    }

}
