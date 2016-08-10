using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhereMyConnections.SvcClient.StdSvcRef;

namespace WhereMyConnections.SvcClient.Models
{
    public interface IRepository
    {
        CallContext USCallContext { get; }
    }
}
