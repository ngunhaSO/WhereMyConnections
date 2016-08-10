using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WhereMyConnections.Helpers;
using WhereMyConnections.SvcClient.Models.Impl;

namespace WhereMyConnections.Controllers.API
{
    [RoutePrefix("api/SignedContract")]
    public class SignedContractController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                RepositoryImpl repo = new RepositoryImpl("SSG", "Administrator", "En-US");
                Portfolio portfolio = new Portfolio(repo.USCallContext);

                var response = portfolio.AllConnections;

                var cons = ObjectMappers.MapStdConnectionToConnection(response);

                var signedContract = cons.Where(c => c.ContractStatus.ToLower() == "signed");
                return Ok(signedContract);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
