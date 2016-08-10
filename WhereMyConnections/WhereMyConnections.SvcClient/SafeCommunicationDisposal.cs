using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WhereMyConnections.SvcClient
{
    public class SafeCommunicationDisposal<T> : IDisposable where T : ICommunicationObject
    {
        private bool _disposed;
        public T Instance { get; private set; }

        public SafeCommunicationDisposal(T client)
        {
            this.Instance = client;
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    this.Close();
                }
                this._disposed = true;
            }
        }

        private void Close()
        {
            try
            {
                this.Instance.Close();
            }
            catch (Exception ex)
            {
                Debug.Assert(false, ex.ToString());
                Trace.TraceWarning("Failed to close communication object in state: {0}. Aborting. Error was {1}", this.Instance.State, ex);
                this.Instance.Abort();
            }
        }
    }
}
