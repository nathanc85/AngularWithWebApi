using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DotNetWebApi.Controllers
{
    public class ValuesController : ApiController
    {

        // First method
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // Second method
        //public HttpResponseMessage Get()
        //{
        //    var returnValue = new { key1 = "value1", key2 = "value2" };

        //    return Request.CreateResponse(HttpStatusCode.OK, returnValue);
        //}

        // GET api/values
        public IHttpActionResult Get()
        {
            var returnValue = new { key1 = "value1", key2 = "value2", key3 = "value3" };

            return Ok(returnValue);
        }
        

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
