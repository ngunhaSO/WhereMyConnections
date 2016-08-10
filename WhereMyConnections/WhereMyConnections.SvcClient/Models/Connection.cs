using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhereMyConnections.SvcClient.StdSvcRef;

namespace WhereMyConnections.SvcClient.Models
{
    public class Connection
    {
        public string ConnectionId { get; set; }

        public string Description { get; set; }

        public McsUtilityTypes UtilityType { get; set; }

        public string UtilityTypeLabel { get; set; }

        public DateTime StartDateTimeLabel { get; set; }

        public DateTime EndDateTimeLabel { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string Country { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }
    }
}
