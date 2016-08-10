using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhereMyConnections.SvcClient.StdSvcRef;

namespace WhereMyConnections.SvcClient.Models.Impl
{
    public class RepositoryImpl : IRepository
    {
        private readonly CallContext usCallContext;

        public RepositoryImpl(string company, string logonAsUser, string language)
        {
            this.usCallContext = new CallContext
            {
                Company = company,
                LogonAsUser = logonAsUser,
                Language = language
            };
        }

        public CallContext USCallContext
        {
            get
            {
                return this.usCallContext;
            }
        }
    }
}
