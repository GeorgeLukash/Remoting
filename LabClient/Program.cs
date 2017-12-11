using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using RemoteLibrary;

namespace LabClient
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClientChannel channel = new TcpClientChannel();
            ChannelServices.RegisterChannel(channel, false);
            RemotingConfiguration.RegisterWellKnownClientType(typeof(ObjectClass), "tcp://localhost:9000/Patient.rem");
            ObjectClass newPatient = new ObjectClass();
            Console.WriteLine(newPatient.PersonalInformation());
            Console.WriteLine(newPatient.History());
        }
    }
}
