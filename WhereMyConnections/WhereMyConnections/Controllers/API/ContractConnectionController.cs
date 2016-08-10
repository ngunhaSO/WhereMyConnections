using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WhereMyConnections.Helpers;
using WhereMyConnections.ModelsView;
using WhereMyConnections.SvcClient.Models.Impl;
using WhereMyConnections.SvcClient.StdSvcRef;

namespace WhereMyConnections.Controllers.API
{
    [RoutePrefix("api/ContractConnection")]
    public class ContractConnectionController : ApiController
    {
        //xml: api/ContractConnection/?type=xml
        //json: api/ContractConnection/?type=json
        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                RepositoryImpl repo = new RepositoryImpl("SSG", "Administrator", "En-US");
                Portfolio portfolio = new Portfolio(repo.USCallContext);

                var response = portfolio.AllConnections;

                var cons = ObjectMappers.MapStdConnectionToConnection(response);
                return Ok(cons);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        //api/ContractConnection/wa
        //api/ContractConnection/ca
        [HttpGet]
        [Route("{stateFilter}")]
        public IHttpActionResult Get(string stateFilter)
        {
            try
            {
                RepositoryImpl repo = new RepositoryImpl("SSG", "Administrator", "En-US");
                Portfolio portfolio = new Portfolio(repo.USCallContext);

                var response = portfolio.AllConnections;

                var cons = ObjectMappers.MapStdConnectionToConnection(response);
                var filters = cons.Where(c => c.State.ToLower() == stateFilter.ToLower());
                return Ok(filters);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        //api/ContractConnection/wa/seattle
        //api/ContractConnection/ca/sandiego
        [HttpGet]
        [Route("{stateFilter}/{city}")]
        public IHttpActionResult Get(string stateFilter, string city)
        {
            try
            {
                RepositoryImpl repo = new RepositoryImpl("SSG", "Administrator", "En-US");
                Portfolio portfolio = new Portfolio(repo.USCallContext);

                var response = portfolio.AllConnections;

                var cons = ObjectMappers.MapStdConnectionToConnection(response);
                var filters = cons.Where(c => c.State.ToLower() == stateFilter.ToLower() 
                 && c.City.ToLower() == city.ToLower());
                return Ok(filters);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        //api/ContractConnection/wa/seattle/initial
        //api/ContractConnection/ca/sandiego/signed
        [HttpGet]
        [Route("{stateFilter}/{city}/{contractStatus}")]
        public IHttpActionResult Get(string stateFilter, string city, string contractStatus)
        {
            try
            {
                RepositoryImpl repo = new RepositoryImpl("SSG", "Administrator", "En-US");
                Portfolio portfolio = new Portfolio(repo.USCallContext);

                var response = portfolio.AllConnections;

                var cons = ObjectMappers.MapStdConnectionToConnection(response);
                var filters = cons.Where(c => c.State.ToLower() == stateFilter.ToLower()
                 && c.City.ToLower() == city.ToLower()
                 && c.ContractStatus.ToLower() == contractStatus.ToLower());
                return Ok(filters);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
