using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhereMyConnections.SvcClient.StdSvcRef;

namespace WhereMyConnections.SvcClient.Models.Impl
{
    /// <summary>
    /// Base class implementations of business layer objects.
    /// Merely a container for some data that is often needed
    /// </summary>
    public class ModelBase
    {
        protected CallContext CallContext;
        protected ModelBase(CallContext callctx)
        {
            this.CallContext = callctx;
        }
    }
}
