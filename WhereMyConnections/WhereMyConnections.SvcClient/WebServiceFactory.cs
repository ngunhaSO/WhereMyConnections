using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhereMyConnections.SvcClient.StdSvcRef;

namespace WhereMyConnections.SvcClient
{
    public class WebServiceFactory
    {
        public static SafeCommunicationDisposal<StdConnection1Client> CreateStdConnectionClient()
        {
            var rawClient = new StdSvcRef.StdConnection1Client();
            var client = new SafeCommunicationDisposal<StdConnection1Client>(rawClient);
            return client;
        }
    }
}
