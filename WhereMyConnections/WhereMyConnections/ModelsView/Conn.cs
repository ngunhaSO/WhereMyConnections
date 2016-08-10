using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WhereMyConnections.SvcClient.StdSvcRef;

namespace WhereMyConnections.ModelsView
{
    public class Conn
    {
        public string ConnectionId { get; set; }

        public string EanId { get; set; }

        public string ExternalConnectionId { get; set; }

        public string Debtor { get; set; }

        public string ContractStatus { get; set; }

        public string UtilityType { get; set; }

        public string Direction { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public string Address { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string Country { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }
    }
}