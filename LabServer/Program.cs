using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace LabServer
{
    class Program
    {
        static void Main(string[] args)
        {
            RemotingConfiguration.Configure("LabServer.exe.config", false);
            Console.WriteLine("Press return to exit...\n");
            Console.ReadLine();
        }
    }
}
