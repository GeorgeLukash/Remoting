using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;

namespace RemoteLibrary
{
    public class ObjectClass: MarshalByRefObject
    {
        public string History()
        {
            return "25/12/2017; Diagnosis: cold | Treatment: take 2 and call me in the morning.\n\r27/12/2017; Diagnosis: broken toe | Treatment: nothing.";
        }
        public string PersonalInformation()
        {
            return "Patient ID : 001 Demo Patient";
        }
    }
}
