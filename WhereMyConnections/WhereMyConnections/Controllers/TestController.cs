using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WhereMyConnections.SvcClient.Models.Impl;
using WhereMyConnections.SvcClient.StdSvcRef;

namespace WhereMyConnections.Controllers
{
    [RoutePrefix("api/Test")]
    public class TestController : ApiController
    {
       //xml: api/Test/?type=xml
       //json: api/Test/?type=json
        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                //RepositoryImpl repo = new RepositoryImpl("SSG", "Administrator", "En-US");
                //Portfolio portfolio = new Portfolio(repo.USCallContext);

                //var response = portfolio.AllConnections;

                var callContext = new SvcClient.StdSvcRef.CallContext();
                callContext.Company = "SSG";
                callContext.LogonAsUser = "Administrator";
                callContext.Language = "En-US";

                var portfolioService = new SvcClient.StdSvcRef.StdConnection1Client();
                PortfolioConnection response = portfolioService.getConnections(callContext);

                return Ok(response.AllConnections);
            }
            catch(Exception ex)
            {
                return InternalServerError(ex);
            }
            

        }


    }
}
