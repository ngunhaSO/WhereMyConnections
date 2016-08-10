using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WhereMyConnections.ModelsView;
using WhereMyConnections.SvcClient.StdSvcRef;

namespace WhereMyConnections.Helpers
{
    public static class ObjectMappers
    {
        public static List<Conn> MapStdConnectionToConnection(StdConnection[] stdConn)
        {
            List<Conn> cons = new List<Conn>();
            for (var i = 0; i < stdConn.Length; i++)
            {
                var con = new Conn
                {
                    ConnectionId = stdConn[i].ConnectionId,
                    EanId = stdConn[i].EanId,
                    ExternalConnectionId = stdConn[i].ExternalConnectionId,
                    Debtor = stdConn[i].Debtor,
                    ContractStatus = stdConn[i].ContractStatusLabel,
                    UtilityType = stdConn[i].UtilityTypeLabel,
                    Direction = stdConn[i].DirectionTypeLabel,
                    StartDateTime = stdConn[i].StartDateTimeLabel,
                    EndDateTime = stdConn[i].EndDateTimeLabel,
                    Street = stdConn[i].StreetAddress,
                    City = stdConn[i].City,
                    State = stdConn[i].State,
                    Country = stdConn[i].Country,
                    ZipCode = stdConn[i].ZipCode,
                    Address = stdConn[i].StreetAddress + " " + stdConn[i].City + ", " + stdConn[i].State + " " + stdConn[i].ZipCode + " " + stdConn[i].Country,
                    Latitude = stdConn[i].Latitude,
                    Longitude = stdConn[i].Longtitude
                };
                cons.Add(con);
            }
            return cons;
        }
    }
}