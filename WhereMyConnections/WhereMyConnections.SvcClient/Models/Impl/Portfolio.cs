using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WhereMyConnections.SvcClient.StdSvcRef;

namespace WhereMyConnections.SvcClient.Models.Impl
{
    public class Portfolio : ModelBase, IPortfolio
    {
        StdConnection[] allConnection;

        public Portfolio(CallContext callContext) : base(callContext)
        {
            this.CallContext = callContext;
        }

        //public StdConnection[] AllConnections
        //{
        //    get
        //    {
        //        if (allConnection == null)
        //        {
        //            //using (var svc = WebServiceFactory.CreateStdConnectionClient())
        //            //{
        //            //    this.allConnection = svc.Instance.getConnections(this.CallContext).AllConnections;
        //            //}

        //            var svc = WebServiceFactory.CreateStdConnectionClient();
        //            try
        //            {

        //                this.allConnection = svc.Instance.getConnections(this.CallContext).AllConnections;
        //                svc.Instance.Close();
        //                svc.Dispose();
        //            }
        //            catch (TimeoutException exception)
        //            {
        //                Debug.Assert(false, exception.ToString());
        //                Trace.TraceWarning("Timeout exception", svc.ToString(), exception);
        //                svc.Dispose();
        //            }
        //            catch (CommunicationException exception)
        //            {
        //                Console.WriteLine("Got {0}", exception.GetType());
        //                svc.Dispose();
        //            }
        //        }
        //        return this.allConnection;
        //    }
        //}

        public StdConnection[] AllConnections
        {
            get
            {
                if (allConnection == null)
                {
                    using (var svc = WebServiceFactory.CreateStdConnectionClient())
                    {
                        this.allConnection = svc.Instance.getConnections(this.CallContext).AllConnections;
                    }
                }
                return this.allConnection;
            }
        }

        
    }
}
