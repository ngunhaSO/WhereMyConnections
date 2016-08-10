using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhereMyConnections.SvcClient.Models.Impl;
using WhereMyConnections.SvcClient.StdSvcRef;

namespace WhereMyConnections.SvcClient
{
    public class Test
    {
        public static void dummy()
        {
            //RepositoryImpl repo = new RepositoryImpl("SSG", "Administrator", "En-US");
            //Portfolio portfolio = new Portfolio(repo.USCallContext);
            //Console.WriteLine(portfolio.AllConnections.Length);


            var callContext = new StdSvcRef.CallContext();
            callContext.Company = "SSG";
            callContext.LogonAsUser = "Administrator";
            callContext.Language = "En-US";

            var portfolioService = new StdSvcRef.StdConnection1Client();
            PortfolioConnection response = portfolioService.getConnections(callContext);

            if (response != null)
            {
                foreach (var connectionData in response.AllConnections)
                {
                    Console.WriteLine("Connection id: " + connectionData.ConnectionId);
                    Console.WriteLine("Personal Description:" + connectionData.Debtor);
                    Console.WriteLine("Utility Type: " + connectionData.UtilityType);
                    Console.WriteLine("Utility Label: " + connectionData.UtilityTypeLabel);
                    Console.WriteLine("Start date: " + connectionData.StartDateTime);
                    Console.WriteLine("End date: " + connectionData.EndDateTime);
                    Console.WriteLine("Address: " + connectionData.StreetNumber + " " + connectionData.StreetAddress);
                    Console.WriteLine("City: " + connectionData.City);
                    Console.WriteLine("State: " + connectionData.State);
                    Console.WriteLine("Zip code: " + connectionData.ZipCode);
                    Console.WriteLine("Country: " + connectionData.Country);
                    Console.WriteLine("Latitude: " + connectionData.Latitude);
                    Console.WriteLine("Longitude: " + connectionData.Longtitude);
                    Console.WriteLine("Start: " + connectionData.StartDateTimeLabel);
                    Console.WriteLine("End: " + connectionData.EndDateTimeLabel);
                    Console.WriteLine("========================================");
                }
            }

            Console.ReadLine();
        }
    }
}
