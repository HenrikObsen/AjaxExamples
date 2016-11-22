using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using RepoMZ;

namespace AjaxExamples.Controllers
{
    //Web api2 Tutorial https://www.asp.net/web-api/overview/getting-started-with-aspnet-web-api/tutorial-your-first-web-api
    public class WebController : ApiController
    {
        IndholdFac inf = new IndholdFac();
        // GET api/<controller>
    
        public Indhold Get()
        {
            return inf.Get(1);
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}